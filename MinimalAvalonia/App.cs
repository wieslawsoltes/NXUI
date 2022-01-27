AppBuilder.Configure<Application>()
          .UsePlatformDetect()
          .UseFluentTheme()
          .StartWithClassicDesktopLifetime(desktop => {
              var count = 0;
              var window = new Window();
              var button = new Button { Content = "Welcome to Avalonia, please click me!" };
              var tb1 = new TextBox { Text = "Minimal Avalonia" };
              var tb2 = new TextBox { [!!TextBlock.TextProperty] = window[!!Window.TitleProperty] };
              var label = new Label { [!ContentControl.ContentProperty] = button.OnClick().Select(_ => ++count).Select(x => $"You clicked {x} times.").ToBinding() };
              window[!!Window.TitleProperty] = tb1.GetObservable(TextBox.TextProperty).Select(x => x.ToUpper()).ToBinding();
              window[ContentControl.ContentProperty] = new StackPanel { Children = { button, tb1, tb2, label } };
              desktop.MainWindow = window;
          }, args);
