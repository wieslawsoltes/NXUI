AppBuilder.Configure<Application>()
          .UsePlatformDetect()
          .UseFluentTheme()
          .StartWithClassicDesktopLifetime(desktop => {
              var count = 0;
              var window = new Window();
              var button = new Button { Content = "Welcome to Avalonia, please click me!" };
              var tb1 = new TextBox { Text = "Minimal Avalonia" };
              var tb2 = new TextBox { [!!TextBlockText] = window[!!WindowTitle] };
              var label = new Label { [!ContentControlContent] = button.OnClick().Select(_ => ++count).Select(x => $"You clicked {x} times.").ToBinding() };
              window[!!WindowTitle] = tb1.GetObservable(TextBoxText).Select(x => x.ToUpper()).ToBinding();
              window[ContentControlContent] = new StackPanel { Children = { button, tb1, tb2, label } };
              desktop.MainWindow = window;
          }, args);
