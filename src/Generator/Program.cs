using Avalonia;
using Generator;

if (args.Length > 2)
{
    Console.WriteLine("Usage: Generator <OutputPath> [-fsharp]");
    return;
}

var includedAssemblies = new HashSet<string>
{
    "Avalonia.Base",
    "Avalonia.Controls",
    "Avalonia.Desktop",
};

var excludedClasses = new HashSet<string>
{
    "AboutAvaloniaDialog"
};

var genFSharp = args.Length == 2 && args[1] == "-fsharp";
void Generate() 
    => MainGenerator.Generate(
        args[0], 
        a =>
        {
            // Console.WriteLine($"[Assembly] {a}");
            var name = a.GetName().Name;
            var isAvalonia = name is { } && includedAssemblies.Contains(name);
            return isAvalonia;
        }, 
        t =>
        {
            // Console.WriteLine($"[Type] {t}");
            if (excludedClasses.Contains(t.Name))
            {
                return false;
            }
            return true;
        },
        genFSharp: genFSharp
        );

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(_ => Generate())
    .SetupWithoutStarting();
