BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

static AppBuilder BuildAvaloniaApp() 
    => AppBuilder.Configure<Application>()
                 .UsePlatformDetect()
                 .UseFluentTheme(FluentThemeMode.Dark)
                 .WithClassicDesktopStyleApplicationLifetime(desktop => {
                     desktop.MainWindow = new Window {
                         Title = "MinimalAvalonia",
                         Content = new TextBlock { Text = "MinimalAvalonia" }
                     };
                 });
