using Avalonia;
using Avalonia.Headless;
using Avalonia.Themes.Fluent;
using Generator;

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .AfterSetup(x =>
    {
        var theme = new FluentTheme(new Uri($"avares://{System.Reflection.Assembly.GetExecutingAssembly().GetName()}"))
        {
            Mode = FluentThemeMode.Light
        };
        x.Instance?.Styles.Add(theme);

        if (args.Length == 1)
        {
            MinimalGenerator.Generate(args[0]);
        }
    })
    .UseHeadless(new AvaloniaHeadlessPlatformOptions { UseCompositor = false, UseHeadlessDrawing = false }).SetupWithoutStarting();

