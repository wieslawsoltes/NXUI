using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Generator;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Reflectonia;

namespace Generator.Tasks;

public class RunGenerator : Task
{
    [Required]
    public string OutputDirectory { get; set; } = string.Empty;

    public override bool Execute()
    {
        try
        {
            var includedAssemblies = new HashSet<string>
            {
                "Avalonia.Base",
                "Avalonia.Controls",
                "Avalonia.Desktop",
                "Avalonia.Controls.ColorPicker",
                "Avalonia.Controls.ItemsRepeater",
                "Avalonia.Controls.DataGrid",
                "Avalonia.Controls.TreeDataGrid",
            };

            var excludedClasses = new HashSet<string>
            {
                "AboutAvaloniaDialog"
            };

            var log = new ReflectoniaLog();
            var factory = new ReflectoniaFactory(log);

            void Generate() => new MainGenerator(factory, log).Generate(
                OutputDirectory,
                a => includedAssemblies.Contains(a.GetName().Name ?? string.Empty),
                t => !excludedClasses.Contains(t.Name));

            AppBuilder.Configure<Application>()
                .UsePlatformDetect()
                .AfterSetup(_ =>
                {
                    _ = new ColorPicker();
                    _ = new ItemsRepeater();
                    _ = new DataGrid();
                    _ = new TreeDataGrid();
                    Generate();
                })
                .SetupWithoutStarting();

            return true;
        }
        catch (Exception ex)
        {
            Log.LogErrorFromException(ex, true);
            return false;
        }
    }
}
