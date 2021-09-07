AppBuilder.Configure<Application>()
          .UsePlatformDetect()
          .UseFluentTheme()
          .StartWithClassicDesktopLifetime(desktop => {
              var count = 0;
              var button = new Button() { Content = "Welcome to Avalonia, please click me!" };
              var label = new Label() { 
                  [!Label.ContentProperty] = button.OnClick()
                                                   .Select(_ => count++)
                                                   .Select(x => $"You clicked {x} times.")
                                                   .ToBinding() 
              };
              desktop.MainWindow = new Window {
                  Content = new StackPanel() { 
                      Children = {
                          button,
                          label
                      }
                  }
              };
          }, args);
