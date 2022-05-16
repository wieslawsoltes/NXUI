var count = 0;

Window Build()
    => Window(out var window)
        .Title("MinimalAvalonia").Width(400).Height(300)
        .Content(
            StackPanel()
                .Children(
                    Button(out var button)
                        .Content("Welcome to Avalonia, please click me!"),
                    TextBox(out var tb1)
                        .Text("Minimal Avalonia"),
                    TextBox()
                        .Text(window.BindTitle()),
                    Label()
                        .Content(button.ObserveOnClick().Select(_ => ++count).Select(x => $"You clicked {x} times."))))
        .Title(tb1.ObserveText().Select(x => x?.ToUpper()));

AppBuilder.Configure<Application>()
          .UsePlatformDetect()
          .UseFluentTheme()
          .WithApplicationName("MinimalAvalonia")
          .StartWithClassicDesktopLifetime(Build, args);
