using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Diagnostics.NETCore.Client;
using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.EventPipe;

namespace NXUI.Cli;

internal static class Program
{
    private const string ProviderName = "NXUI-HotReload";

    private static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            return Usage("Missing command.");
        }

        var command = args[0].ToLowerInvariant();
        var remaining = args.Skip(1).ToArray();

        return command switch
        {
            "hotreload" => HandleHotReload(remaining),
            "gen" => HandleGenerate(remaining),
            _ => Usage($"Unknown command '{args[0]}'."),
        };
    }

    private static int HandleHotReload(string[] args)
    {
        if (args.Length == 0)
        {
            return Usage("Missing hotreload subcommand.");
        }

        return args[0].ToLowerInvariant() switch
        {
            "trace" => HandleHotReloadTrace(args),
            "snapshot" => HandleHotReloadSnapshot(args),
            "boundaries" => HandleHotReloadBoundaries(args),
            _ => Usage($"Unknown hotreload subcommand '{args[0]}'.")
        };
    }

    private static int HandleHotReloadTrace(string[] args)
    {
        if (!TryParsePid(args.AsSpan(1), out var pid, out var error, out _))
        {
            return Usage(error);
        }

        Console.WriteLine($"[nxui] Listening for {ProviderName} events from process {pid}. Press Ctrl+C to stop.");

        using var cts = new CancellationTokenSource();
        Console.CancelKeyPress += (_, e) =>
        {
            e.Cancel = true;
            cts.Cancel();
        };

        try
        {
            TraceHotReload(pid, cts.Token);
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"[nxui] Trace failed: {ex.Message}");
            return 1;
        }
    }

    private static int HandleHotReloadSnapshot(string[] args)
    {
        if (!TryParsePid(args.AsSpan(1), out var pid, out var error, out var consumed))
        {
            return Usage(error);
        }

        var outputPath = default(string);
        var watch = false;
        var remaining = args.Skip(1 + consumed).ToArray();

        for (var i = 0; i < remaining.Length; i++)
        {
            switch (remaining[i])
            {
                case "--output" when i + 1 < remaining.Length:
                    outputPath = Path.GetFullPath(remaining[++i]);
                    break;
                case "--watch":
                    watch = true;
                    break;
                default:
                    return Usage($"Unknown option '{remaining[i]}' for snapshot command.");
            }
        }

        if (string.IsNullOrEmpty(outputPath))
        {
            Console.WriteLine("[nxui] Snapshot output not provided. JSON will be printed to the console.");
        }

        Console.WriteLine("Ensure NXUI_HOTRELOAD_SNAPSHOT=1 is set in the target process before capturing snapshots.");

        try
        {
            CaptureSnapshots(pid, outputPath, watch);
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"[nxui] Snapshot capture failed: {ex.Message}");
            return 1;
        }
    }

    private static void TraceHotReload(int pid, CancellationToken cancellationToken)
    {
        var providers = new List<EventPipeProvider>
        {
            new(ProviderName, EventLevel.Informational, keywords: 0)
        };

        var client = new DiagnosticsClient(pid);
        using var session = client.StartEventPipeSession(providers, requestRundown: false);
        using var source = new EventPipeEventSource(session.EventStream);

        var totals = new Dictionary<string, PatchStats>(StringComparer.Ordinal);

        source.Dynamic.All += traceEvent =>
        {
            if (!string.Equals(traceEvent.EventName, "PatchSummary", StringComparison.Ordinal))
            {
                return;
            }

            var root = traceEvent.PayloadByName("rootDescription") as string ?? "<unknown>";
            var stats = totals.GetValueOrDefault(root) ?? new PatchStats(root);
            stats.Add(traceEvent);
            totals[root] = stats;

            Console.WriteLine(stats.LastLine);
        };

        Task.Run(() =>
        {
            try
            {
                source.Process();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"[nxui] Trace stream ended: {ex.Message}");
            }
        }, cancellationToken);

        while (!cancellationToken.IsCancellationRequested)
        {
            Thread.Sleep(100);
        }

        session.Stop();
        Console.WriteLine();
        Console.WriteLine("[nxui] Aggregate totals:");
        foreach (var stat in totals.Values.OrderByDescending(s => s.TotalChanges))
        {
            Console.WriteLine(stat.SummaryLine);
        }
    }

    private static void CaptureSnapshots(int pid, string? outputPath, bool watch)
    {
        using var cts = new CancellationTokenSource();
        var client = new DiagnosticsClient(pid);
        using var session = client.StartEventPipeSession(
            new List<EventPipeProvider>
            {
                new(ProviderName, EventLevel.Informational, keywords: 0)
            },
            requestRundown: false);

        using var source = new EventPipeEventSource(session.EventStream);
        var snapshotReceived = new ManualResetEventSlim();
        var lockObj = new object();

        void WriteSnapshot(string json)
        {
            if (string.IsNullOrEmpty(outputPath))
            {
                Console.WriteLine("----- snapshot -----");
                Console.WriteLine(json);
                Console.WriteLine("--------------------");
                return;
            }

            var target = outputPath;
            if (watch)
            {
                var dir = Path.GetDirectoryName(outputPath);
                var name = Path.GetFileNameWithoutExtension(outputPath);
                var ext = Path.GetExtension(outputPath);
                var stamp = DateTimeOffset.Now.ToString("yyyyMMdd-HHmmssfff", CultureInfo.InvariantCulture);
                target = Path.Combine(dir ?? ".", $"{name}-{stamp}{ext}");
            }

            Directory.CreateDirectory(Path.GetDirectoryName(target) ?? ".");
            File.WriteAllText(target, json);
            Console.WriteLine($"[nxui] Snapshot written to {target}");
        }

        source.Dynamic.All += traceEvent =>
        {
            if (!string.Equals(traceEvent.EventName, "NodeSnapshot", StringComparison.Ordinal))
            {
                return;
            }

            var json = traceEvent.PayloadByName("snapshotJson") as string ?? string.Empty;
            lock (lockObj)
            {
                WriteSnapshot(json);
            }

            snapshotReceived.Set();
            if (!watch)
            {
                cts.Cancel();
            }
        };

        Console.CancelKeyPress += (_, e) =>
        {
            e.Cancel = true;
            cts.Cancel();
        };

        var processing = Task.Run(() =>
        {
            try
            {
                source.Process();
            }
            catch (Exception ex) when (!cts.IsCancellationRequested)
            {
                Console.Error.WriteLine($"[nxui] Snapshot stream ended: {ex.Message}");
            }
        }, cts.Token);

        if (!watch)
        {
            if (!snapshotReceived.Wait(TimeSpan.FromSeconds(30)))
            {
                Console.WriteLine("[nxui] No snapshot received. Ensure the app runs with NXUI_HOTRELOAD_SNAPSHOT=1.");
            }

            cts.Cancel();
        }
        else
        {
            Console.WriteLine("[nxui] Waiting for snapshots. Press Ctrl+C to stop.");
            while (!cts.IsCancellationRequested)
            {
                Thread.Sleep(100);
            }
        }

        session.Stop();
        processing.Wait(TimeSpan.FromSeconds(1));
    }

    private static int HandleHotReloadBoundaries(string[] args)
    {
        var manifestOverride = default(string);
        var assemblyPaths = new List<string>();

        for (var i = 1; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "--manifest" when i + 1 < args.Length:
                    manifestOverride = args[++i];
                    break;
                case "--assembly" when i + 1 < args.Length:
                    assemblyPaths.Add(Path.GetFullPath(args[++i]));
                    break;
                case "--list":
                    break;
                default:
                    return Usage($"Unknown option '{args[i]}' for hotreload boundaries.");
            }
        }

        var manifestPath = ResolveManifestPath(manifestOverride);
        var manifestEntries = BoundaryInspector.LoadManifestEntries(manifestPath);

        Console.WriteLine($"[nxui] Manifest entries ({manifestEntries.Count}) from '{manifestPath}':");
        if (manifestEntries.Count == 0)
        {
            Console.WriteLine("  (no entries found)");
        }
        else
        {
            foreach (var entry in manifestEntries.OrderBy(v => v, StringComparer.Ordinal))
            {
                Console.WriteLine($"  - {entry}");
            }
        }

        if (assemblyPaths.Count == 0)
        {
            Console.WriteLine("[nxui] Provide --assembly <path> to inspect a compiled assembly for implicit boundaries.");
            return 0;
        }

        foreach (var assemblyPath in assemblyPaths)
        {
            Console.WriteLine();
            Console.WriteLine($"[nxui] Assembly: {assemblyPath}");
            if (!File.Exists(assemblyPath))
            {
                Console.WriteLine("  (file not found)");
                continue;
            }

            var infos = BoundaryInspector.Inspect(assemblyPath, manifestEntries);
            if (infos.Count == 0)
            {
                Console.WriteLine("  (no implicit boundaries detected)");
                continue;
            }

            Console.WriteLine("  Type                                         Sources");
            foreach (var info in infos.OrderBy(i => i.TypeName, StringComparer.Ordinal))
            {
                var sources = new List<string>();
                if (info.ManifestMatch)
                {
                    sources.Add("manifest");
                }

                if (info.HasBoundaryAttribute)
                {
                    sources.Add("attribute");
                }

                if (info.HasCandidateAttribute)
                {
                    sources.Add("candidate");
                }

                if (info.ImplementsMarkerInterface)
                {
                    sources.Add("marker");
                }

                if (info.ImplementsStateAdapter)
                {
                    sources.Add("state-adapter (skipped)");
                }

                var reasonText = string.Join(", ", sources);
                Console.WriteLine($"  {info.TypeName,-44} {reasonText}");
            }
        }

        return 0;
    }

    private static string ResolveManifestPath(string? overridePath)
    {
        if (!string.IsNullOrWhiteSpace(overridePath))
        {
            return Path.GetFullPath(overridePath);
        }

        var currentDirCandidate = Path.Combine(Directory.GetCurrentDirectory(), "build", "HotReloadBoundaries.json");
        if (File.Exists(currentDirCandidate))
        {
            return currentDirCandidate;
        }

        var baseCandidate = Path.Combine(AppContext.BaseDirectory, "build", "HotReloadBoundaries.json");
        if (File.Exists(baseCandidate))
        {
            return baseCandidate;
        }

        return currentDirCandidate;
    }

    private static int HandleGenerate(string[] args)
    {
        if (args.Length == 0)
        {
            return Usage("Missing gen subcommand.");
        }

        if (!string.Equals(args[0], "component", StringComparison.OrdinalIgnoreCase))
        {
            return Usage($"Unknown gen subcommand '{args[0]}'.");
        }

        if (args.Length < 2)
        {
            return Usage("Missing component name.");
        }

        var componentName = args[1];
        var outputDirectory = Directory.GetCurrentDirectory();
        var ns = componentName;
        var force = false;

        for (var i = 2; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "--output" when i + 1 < args.Length:
                    outputDirectory = Path.GetFullPath(args[++i]);
                    break;
                case "--namespace" when i + 1 < args.Length:
                    ns = args[++i];
                    break;
                case "--force":
                    force = true;
                    break;
                default:
                    return Usage($"Unknown option '{args[i]}'.");
            }
        }

        try
        {
            GenerateComponent(componentName, ns, outputDirectory, force);
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"[nxui] Component generation failed: {ex.Message}");
            return 1;
        }
    }

    private static bool TryParsePid(ReadOnlySpan<string> args, out int pid, out string error, out int consumed)
    {
        pid = 0;
        error = string.Empty;
        consumed = 0;

        if (args.Length < 2 || !string.Equals(args[0], "--pid", StringComparison.OrdinalIgnoreCase))
        {
            error = "Missing '--pid <processId>' argument.";
            return false;
        }

        if (!int.TryParse(args[1], out pid) || pid <= 0)
        {
            error = "Invalid process id.";
            return false;
        }

        consumed = 2;
        return true;
    }

    private static void GenerateComponent(string componentName, string ns, string outputDirectory, bool force)
    {
        var sanitizedName = SanitizeIdentifier(componentName);
        if (string.IsNullOrWhiteSpace(sanitizedName))
        {
            throw new InvalidOperationException("Component name must contain alphanumeric characters.");
        }

        var className = sanitizedName.EndsWith("Component", StringComparison.Ordinal)
            ? sanitizedName
            : sanitizedName + "Component";

        Directory.CreateDirectory(outputDirectory);
        var filePath = Path.Combine(outputDirectory, className + ".cs");

        if (File.Exists(filePath) && !force)
        {
            throw new InvalidOperationException($"File '{filePath}' already exists. Use --force to overwrite.");
        }

        var content = ComponentTemplate(ns, className);
        File.WriteAllText(filePath, content);

        Console.WriteLine($"[nxui] Created component scaffold at {filePath}");
        Console.WriteLine($"Add a Program.cs that calls {className}.Run(args) to launch with NXUI hot reload.");
    }

    private static string ComponentTemplate(string ns, string className)
    {
        return $@"// <auto-generated by nxui>
using System;
using Avalonia.Controls;
using NXUI;
using NXUI.Extensions;
using NXUI.HotReload;
using static NXUI.Builders;

namespace {ns};

public static class {className}
{{
    public static int Run(string[] args)
    {{
        Environment.SetEnvironmentVariable(""NXUI_HOTRELOAD_DIAGNOSTICS"", ""1"");
        return HotReloadHost.Run(Build, ""{className}"", args);
    }}

    private static ElementBuilder<Window> Build()
        => Window()
            .Title(""{className}"")
            .Width(480)
            .Height(320)
            .Content(
                StackPanel()
                    .Spacing(12)
                    .Children(
                        Border()
                            .Key(""Hero"")
                            .HotReloadBoundary()
                            .Padding(16)
                            .Child(
                                TextBlock()
                                    .Key(""HeroText"")
                                    .Text(""Edit this component and save to trigger NXUI hot reload."")),
                        Button()
                            .Key(""ActionButton"")
                            .Content(""Click me"")));
}}
";
    }

    private static string SanitizeIdentifier(string name)
    {
        var builder = new System.Text.StringBuilder();
        for (var i = 0; i < name.Length; i++)
        {
            var ch = name[i];
            if (i == 0 && !char.IsLetter(ch) && ch != '_')
            {
                continue;
            }

            if (char.IsLetterOrDigit(ch) || ch == '_')
            {
                builder.Append(ch);
            }
        }

        return builder.ToString();
    }

    private static int Usage(string? error = null)
    {
        if (!string.IsNullOrEmpty(error))
        {
            Console.Error.WriteLine($"[nxui] {error}");
        }

        Console.WriteLine("Usage:");
        Console.WriteLine("  nxui hotreload trace --pid <processId>");
        Console.WriteLine("  nxui hotreload snapshot --pid <processId> [--output file.json] [--watch]");
        Console.WriteLine("  nxui hotreload boundaries [--manifest build/HotReloadBoundaries.json] [--assembly path]");
        Console.WriteLine("  nxui gen component <Name> [--namespace Namespace] [--output path] [--force]");
        Console.WriteLine();
        Console.WriteLine("Set NXUI_HOTRELOAD_DIAGNOSTICS=1 to emit patch summaries.");
        Console.WriteLine("Set NXUI_HOTRELOAD_SNAPSHOT=1 to emit ElementNode snapshot events.");
        return 1;
    }

    private sealed class PatchStats
    {
        private int _replace;
        private int _set;
        private int _bind;
        private int _clear;
        private int _add;
        private int _remove;
        private int _move;

        internal PatchStats(string root)
        {
            Root = root;
        }

        private string Root { get; }

        internal int TotalChanges => _replace + _set + _bind + _clear + _add + _remove + _move;

        internal string LastLine { get; private set; } = string.Empty;

        internal string SummaryLine
            => $"{Root,-24} total={TotalChanges} replace={_replace} set={_set} bind={_bind} clear={_clear} add={_add} remove={_remove} move={_move}";

        internal void Add(TraceEvent traceEvent)
        {
            var replace = GetInt32(traceEvent, 1);
            var set = GetInt32(traceEvent, 2);
            var bind = GetInt32(traceEvent, 3);
            var clear = GetInt32(traceEvent, 4);
            var add = GetInt32(traceEvent, 5);
            var remove = GetInt32(traceEvent, 6);
            var move = GetInt32(traceEvent, 7);
            var attach = GetInt32(traceEvent, 8);
            var detach = GetInt32(traceEvent, 9);
            var replacedRoot = GetInt32(traceEvent, 10) == 1 ? " (root replaced)" : string.Empty;

            _replace += replace;
            _set += set;
            _bind += bind;
            _clear += clear;
            _add += add;
            _remove += remove;
            _move += move;

            LastLine =
                $"[{DateTimeOffset.Now:HH:mm:ss}] {Root}: replace+={replace} set+={set} bind+={bind} clear+={clear} add+={add} remove+={remove} move+={move} attachEvt+={attach} detachEvt+={detach}{replacedRoot}";
        }

        private static int GetInt32(TraceEvent traceEvent, int index)
        {
            var value = traceEvent.PayloadValue(index);
            return value switch
            {
                int i => i,
                long l => (int)l,
                _ => Convert.ToInt32(value, CultureInfo.InvariantCulture),
            };
        }
    }
}
