using Avalonia;
using Avalonia.Headless;
using Avalonia.Themes.Fluent;
using Generator;

AppBuilder.Configure<App>()
    .UsePlatformDetect()
    .AfterSetup(x =>
    {
        var theme = new FluentTheme(new Uri($"avares://{System.Reflection.Assembly.GetExecutingAssembly().GetName()}"))
        {
            Mode = FluentThemeMode.Light
        };
        x.Instance?.Styles.Add(theme);

        ExtensionsGenerator.Generate(Console.WriteLine);
    })
    .UseHeadless()
    .SetupWithoutStarting();
    //.StartWithClassicDesktopLifetime(args);
