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
              Window(out var window)
                  .Content(
                      StackPanel()
                          .Children(
                              Button(out var button)
                                  .Content("Welcome to Avalonia, please click me!"), 
                              TextBox(out var tb1)
                                  .Text("Minimal Avalonia"), 
                              TextBox()
                                  .Text(window.Title()), 
                              Label()
                                  .Content(button.OnClick().Select(_ => ++count).Select(x => $"You clicked {x} times.").ToBinding())))
                  .Title(tb1.GetObservable(TextBoxText).Select(x => x?.ToUpper()).ToBinding());
#endif
              desktop.MainWindow = window;
          }, args);
