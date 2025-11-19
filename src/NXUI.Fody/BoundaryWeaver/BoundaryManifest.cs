namespace NXUI.Fody.BoundaryWeaver;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

internal static class BoundaryManifest
{
    private const string DefaultFileName = "HotReloadBoundaries.json";

    internal static IReadOnlyCollection<string> Load(
        string? addinDirectory,
        string? overridePath,
        Action<string>? infoLogger,
        Action<string>? warningLogger)
    {
        var resolvedPath = ResolvePath(addinDirectory, overridePath);
        if (string.IsNullOrEmpty(resolvedPath))
        {
            warningLogger?.Invoke("NXUI BoundaryWeaver could not resolve a manifest path.");
            return Array.Empty<string>();
        }

        if (!File.Exists(resolvedPath))
        {
            warningLogger?.Invoke($"NXUI BoundaryWeaver manifest '{resolvedPath}' not found.");
            return Array.Empty<string>();
        }

        try
        {
            var content = File.ReadAllText(resolvedPath);
            var entries = Parse(content, Path.GetExtension(resolvedPath));
            infoLogger?.Invoke($"NXUI BoundaryWeaver loaded {entries.Count} entries from '{resolvedPath}'.");
            return entries;
        }
        catch (Exception ex)
        {
            warningLogger?.Invoke($"NXUI BoundaryWeaver failed to read '{resolvedPath}': {ex.Message}");
            return Array.Empty<string>();
        }
    }

    private static string? ResolvePath(string? addinDirectory, string? overridePath)
    {
        if (!string.IsNullOrWhiteSpace(overridePath))
        {
            return Path.IsPathRooted(overridePath)
                ? overridePath
                : Path.Combine(addinDirectory ?? Directory.GetCurrentDirectory(), overridePath);
        }

        if (!string.IsNullOrEmpty(addinDirectory))
        {
            var candidate = Path.Combine(addinDirectory, DefaultFileName);
            if (File.Exists(candidate))
            {
                return candidate;
            }
        }

        var fallback = Path.Combine(Directory.GetCurrentDirectory(), DefaultFileName);
        return fallback;
    }

    private static IReadOnlyCollection<string> Parse(string content, string? extension)
    {
        if (string.IsNullOrWhiteSpace(content))
        {
            return Array.Empty<string>();
        }

        var trimmed = content.TrimStart();
        if (trimmed.StartsWith("[", StringComparison.Ordinal) || trimmed.StartsWith("{", StringComparison.Ordinal))
        {
            try
            {
                if (trimmed.StartsWith("[", StringComparison.Ordinal))
                {
                    var array = JsonSerializer.Deserialize<string[]>(content);
                    return Normalize(array);
                }

                var document = JsonSerializer.Deserialize<BoundaryManifestDocument>(content);
                return Normalize(document?.Controls ?? document?.BoundaryTypes);
            }
            catch (JsonException)
            {
                // Intentional fallthrough to YAML-style parsing.
            }
        }

        return ParseLines(content);
    }

    private static IReadOnlyCollection<string> Normalize(IEnumerable<string?>? values)
    {
        if (values is null)
        {
            return Array.Empty<string>();
        }

        var set = new HashSet<string>(StringComparer.Ordinal);
        foreach (var value in values)
        {
            var candidate = value?.Trim();
            if (string.IsNullOrEmpty(candidate))
            {
                continue;
            }

            set.Add(candidate!);
        }

        return set.ToArray();
    }

    private static IReadOnlyCollection<string> ParseLines(string content)
    {
        var set = new HashSet<string>(StringComparer.Ordinal);
        using var reader = new StringReader(content);
        string? line;

        while ((line = reader.ReadLine()) is not null)
        {
            line = line.Trim();
            if (string.IsNullOrEmpty(line) || line.StartsWith("#", StringComparison.Ordinal))
            {
                continue;
            }

            if (line.StartsWith("-", StringComparison.Ordinal))
            {
                line = line.TrimStart('-').Trim();
            }

            if (!string.IsNullOrEmpty(line))
            {
                set.Add(line);
            }
        }

        return set.ToArray();
    }

    private sealed class BoundaryManifestDocument
    {
        public List<string>? Controls { get; set; }

        public List<string>? BoundaryTypes { get; set; }
    }
}
