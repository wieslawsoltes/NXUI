﻿var counters = Enumerable.Range(0, 5).Select(i => new BehaviorSubject<int>(i));

Window Build()
  => Window()
    .Title("Counters")
    .Padding(12).Width(300).Height(200)
    .Content(
      ItemsControl()
        .ItemTemplate(new FuncDataTemplate<BehaviorSubject<int>>((count, _) =>
            StackPanel()
              .OrientationHorizontal().Spacing(12).HorizontalAlignmentCenter().VerticalAlignmentCenter()
              .Children(
                Label()
                  .HorizontalAlignmentCenter().VerticalAlignmentCenter().MinWidth(24)
                  .Content(count.ToBinding()),
                Button()
                  .OnClick((_, o) => o.Subscribe(_ => count.OnNext(count.Value + 1)))
                  .Content("Count"))
          , true))
        .ItemsSource(counters));

AppBuilder.Configure<Application>()
  .UsePlatformDetect()
  .UseFluentTheme()
  .WithApplicationName("Counters")
  .StartWithClassicDesktopLifetime(Build, args);
