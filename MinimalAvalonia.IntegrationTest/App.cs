AppBuilder.Configure<Application>()
          .UsePlatformDetect()
          .UseFluentTheme()
          .StartWithClassicDesktopLifetime(desktop => {
              desktop.MainWindow = new Window {
                  Content = new Label { Content = "Minimal Avalonia" }
              };
          }, args);
