var count = 0;

Control Build()
  => StackPanel()
    .Children(
      Button(out var button)
        .Content("Welcome to Avalonia, please click me!"),
      TextBox(out var tb1)
        .Text("Minimal Avalonia"),
      TextBox()
        .Text(tb1.ObserveText().Select(x => x?.ToUpper())),
      Label()
        .Content(button.ObserveOnClick().Select(_ => ++count).Select(x => $"You clicked {x} times.")));

AppBuilder.Configure<Application>()
  .UseFluentTheme()
  .SetupBrowserSingleViewLifetime(Build);
