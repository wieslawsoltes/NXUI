AppBuilder.Configure<Application>()
          .UsePlatformDetect()
          .UseFluentTheme()
          .StartWithClassicDesktopLifetime(desktop => {
              desktop.MainWindow = new Window {
                  Title = "MinimalAvalonia",
                  Content = new TextBlock { Text = "MinimalAvalonia" }
              };
          }, args);
