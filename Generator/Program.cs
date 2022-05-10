using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Themes.Fluent;
using Generator;

try
{
    AppBuilder.Configure<App>()
        .UsePlatformDetect()
        .AfterSetup(x =>
        {
            x.Instance.Styles.Add(
                new FluentTheme(new Uri($"avares://{System.Reflection.Assembly.GetExecutingAssembly().GetName()}"))
                {
                    Mode = FluentThemeMode.Light
                });

            ExtensionsGenerator.Generate();
        })
        //.StartWithClassicDesktopLifetime(args);
        .SetupWithoutStarting();
}
catch
{
    // ignored
}

internal class App : Application
{
    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new Window();
        }

        base.OnFrameworkInitializationCompleted();
    }
}
