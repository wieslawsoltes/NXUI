using Avalonia;
using Generator;

if (args.Length != 1)
{
    Console.WriteLine("Usage: Generator <OutputPath>");
    return;
}

void Generate() 
    => MinimalGenerator.Generate(
        args[0], 
        x =>
        {
            // Console.WriteLine($"[Assembly] {x}");
            return x.StartsWith("Avalonia");
        }, 
        x =>
        {
            // Console.WriteLine($"[Type] {x}");
            return true;
        });

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(_ => Generate())
    .SetupWithoutStarting();
