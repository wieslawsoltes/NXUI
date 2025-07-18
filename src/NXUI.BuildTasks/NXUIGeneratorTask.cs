using Microsoft.Build.Framework;
using MSBuildTask = Microsoft.Build.Utilities.Task;
using System;
using System.IO;
using System.Reflection;
using Avalonia;
using Avalonia.Controls;
using Generator;
using Reflectonia;

namespace NXUI.BuildTasks;

public class NXUIGeneratorTask : MSBuildTask
{
    [Required]
    public string OutputPath { get; set; } = string.Empty;

    public ITaskItem[]? AssemblyPaths { get; set; }

    public ITaskItem[]? IncludeAssemblies { get; set; }

    public override bool Execute()
    {
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

        void Generate() => new MainGenerator(factory, log).Generate(
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

        AppBuilder.Configure<Application>()
            .UsePlatformDetect()
            .AfterSetup(_ =>
            {
                var __ = new ColorPicker();
                var ___ = new ItemsRepeater();
                var ____ = new DataGrid();
                var _____ = new TreeDataGrid();
                Generate();
            })
            .SetupWithoutStarting();

        return !Log.HasLoggedErrors;
    }
}
