using Microsoft.Build.Framework;
using MSBuildTask = Microsoft.Build.Utilities.Task;
using System;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Generator;
using Reflectonia;
using Reflectonia.Model;

namespace NXUI.BuildTasks;

public class NXUIGeneratorTask : MSBuildTask
{
    [Required]
    public string OutputPath { get; set; } = string.Empty;

    public ITaskItem[]? AssemblyPaths { get; set; }

    public ITaskItem[]? IncludeAssemblies { get; set; }

    private static string GetImplicitUsingsTemplate()
    {
        using var stream = typeof(NXUIGeneratorTask).Assembly.GetManifestResourceStream("NXUI.BuildTasks.ImplicitUsingsTemplate.props");
        if (stream is null)
            return string.Empty;
        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }

    public override bool Execute()
    {
        Environment.SetEnvironmentVariable("AVALONIA_HEADLESS", "1");
        var includedAssemblies = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Avalonia.Base",
            "Avalonia.Controls",
            "Avalonia.Desktop",
            "Avalonia.Controls.ColorPicker",
            "Avalonia.Controls.ItemsRepeater",
            "Avalonia.Controls.DataGrid",
            "Avalonia.Controls.TreeDataGrid",
        };

        if (IncludeAssemblies is { Length: > 0 })
        {
            foreach (var asm in IncludeAssemblies)
                includedAssemblies.Add(Path.GetFileNameWithoutExtension(asm.ItemSpec));
        }

        if (AssemblyPaths is { Length: > 0 })
        {
            foreach (var item in AssemblyPaths)
            {
                try
                {
                    Assembly.LoadFrom(item.ItemSpec);
                }
                catch (Exception e)
                {
                    Log.LogWarning($"Failed to load assembly '{item.ItemSpec}': {e.Message}");
                }
            }
        }

        var excludedClasses = new HashSet<string>
        {
            "AboutAvaloniaDialog"
        };

        var log = new ReflectoniaLog();
        var factory = new ReflectoniaFactory(log);

        List<Class> classes = new();

        List<Class> Generate() => new MainGenerator(factory, log).Generate(
            OutputPath,
            a =>
            {
                var name = a.GetName().Name;
                return name is { } && includedAssemblies.Contains(name);
            },
            t =>
            {
                if (excludedClasses.Contains(t.Name))
                    return false;
                return true;
            });

        try
        {
            AppBuilder.Configure<Application>()
                .UsePlatformDetect()
                .AfterSetup(_ =>
                {
                    classes = Generate();
                })
                .SetupWithoutStarting();
        }
        catch (InvalidOperationException)
        {
            classes = Generate();
        }

        var template = GetImplicitUsingsTemplate();
        if (!string.IsNullOrEmpty(template))
        {
            var namespaces = classes
                .Select(c => c.Type.Namespace)
                .Where(n => !string.IsNullOrEmpty(n))
                .Distinct()
                .OrderBy(x => x);

            var additional = string.Join(Environment.NewLine, namespaces.Select(n => $"    <Using Include=\"{n}\" />"));
            var propsContent = template.Replace("%NAMESPACES%", additional);
            File.WriteAllText(Path.Combine(OutputPath, "ImplicitUsings.props"), propsContent);
        }

        return !Log.HasLoggedErrors;
    }
}
