using Avalonia;
using Generator;

if (args.Length != 1)
{
    Console.WriteLine("Usage: Generator <OutputPath>");
    return;
}

void Generate() => MinimalGenerator.Generate(args[0]);

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(_ => Generate())
    .SetupWithoutStarting();
