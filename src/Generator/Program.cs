using Avalonia;
using Generator;

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(x =>
    {
        if (args.Length == 1)
        {
            MinimalGenerator.Generate(args[0]);
        }
    })
    .SetupWithoutStarting();

