AppBuilder.Configure<Application>()
          .UsePlatformDetect()
          .UseFluentTheme()
          .StartWithClassicDesktopLifetime(desktop => {
              var count = 0;
#if false
              var window = new Window();
              var button = new Button { Content = "Welcome to Avalonia, please click me!" };
              var tb1 = new TextBox { Text = "Minimal Avalonia" };
              var tb2 = new TextBox { [!!TextBlockText] = window[!!WindowTitle] };
              var label = new Label { [!ContentControlContent] = button.OnClick().Select(_ => ++count).Select(x => $"You clicked {x} times.").ToBinding() };
              window[!!WindowTitle] = tb1.GetObservable(TextBoxText).Select(x => x.ToUpper()).ToBinding();
              window[ContentControlContent] = new StackPanel { Children = { button, tb1, tb2, label } };
#else
              Window().Ref(out var window);
              Button().Content("Welcome to Avalonia, please click me!").Ref(out var button);
              TextBox().Text("Minimal Avalonia").Ref(out var tb1);
              TextBox().Text(window.Title()).Ref(out var tb2);
              Label().Content(button.OnClick().Select(_ => ++count).Select(x => $"You clicked {x} times.").ToBinding()).Ref(out var label);
              window.Title(tb1.GetObservable(TextBoxText).Select(x => x?.ToUpper()).ToBinding());
              window.Content(StackPanel().Children(button, tb1, tb2, label));
#endif
              desktop.MainWindow = window;
          }, args);
