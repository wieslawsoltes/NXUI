AppBuilder.Configure<Application>()
          .UsePlatformDetect()
          .UseFluentTheme()
          .StartWithClassicDesktopLifetime(desktop => {
              var tb = new TextBox() {  Text = "Minimal Avalonia" };
              desktop.MainWindow = new Window {
                  Content = tb,
                  [!!Window.TitleProperty] = tb.GetObservable(TextBox.TextProperty).Select(x => x.ToUpper()).ToBinding()
              };
          }, args);
