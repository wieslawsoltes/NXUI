var count = new BehaviorSubject<int>(0);

Builder<Window> Build1()
  => Window1()
    .Title1("Counter")
    .Content1(
      StackPanel1()
        .OrientationHorizontal()
        .Children(
          Label()
            .HorizontalAlignmentCenter().VerticalAlignmentCenter()
            .Content(count.ToBinding()),
          Button()
            .OnClick((_, o) => o.Subscribe(_ => count.OnNext(count.Value + 1)))
            .Content("Count")));

Window Build()
  => Window()
    .Title("Counter").Padding(12).Width(300).Height(200)
    .Content(
      StackPanel()
        .OrientationHorizontal().Spacing(12).HorizontalAlignmentCenter().VerticalAlignmentCenter()
        .Children(
          Label()
            .HorizontalAlignmentCenter().VerticalAlignmentCenter()
            .Content(count.ToBinding()),
          Button()
            .OnClick((_, o) => o.Subscribe(_ => count.OnNext(count.Value + 1)))
            .Content("Count")));

AppBuilder.Configure<Application>()
  .UsePlatformDetect()
  .UseFluentTheme()
  .WithApplicationName("Counter")
  .StartWithClassicDesktopLifetime(Build1(), args);
