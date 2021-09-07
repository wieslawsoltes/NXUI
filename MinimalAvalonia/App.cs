BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

static AppBuilder BuildAvaloniaApp() => AppBuilder.Configure<App>().UsePlatformDetect().LogToTrace();

class App : Application {
    public override void OnFrameworkInitializationCompleted() {
        Styles.Add(new FluentTheme(new Uri("avares://MinimalAvalonia")) { Mode = FluentThemeMode.Light });
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
            desktop.MainWindow = new Window {
                Title = "MinimalAvalonia",
                Content = new TextBlock {
                    Text = "MinimalAvalonia"
                }
            };
        }
        base.OnFrameworkInitializationCompleted();
    }
}
