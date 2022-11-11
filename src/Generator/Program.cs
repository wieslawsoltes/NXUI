using Avalonia;
using Generator;

if (args.Length != 1)
{
    Console.WriteLine("Usage: Generator <OutputPath>");
    return;
}

var excludedClasses = new HashSet<string>
{
    "AboutAvaloniaDialog"
};

void Generate() 
    => MinimalGenerator.Generate(
        args[0], 
        a =>
        {
            // Console.WriteLine($"[Assembly] {a}");
            var name = a.GetName().Name;
            return name is { } && name.StartsWith("Avalonia");
        }, 
        t =>
        {
            // Console.WriteLine($"[Type] {t}");
            if (excludedClasses.Contains(t.Name))
            {
                return false;
            }
            return true;
        });

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(_ => Generate())
    .SetupWithoutStarting();
