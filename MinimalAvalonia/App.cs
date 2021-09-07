AppBuilder.Configure<Application>()
          .UsePlatformDetect()
          .UseFluentTheme()
          .StartWithClassicDesktopLifetime(desktop => {
              var window = new Window { Title = "Minimal Avalonia" };
              window.Content = new TextBox { [!!TextBlock.TextProperty] = window[!!Window.TitleProperty] };
              desktop.MainWindow = window;
          }, args);
