var celsius = new Subject<double?>();
var fahrenheit = new Subject<double?>();

Window Build()
  => Window()
    .Title("TempConv").Padding(12).Width(450).Height(200)
    .Content(
      StackPanel()
        .OrientationHorizontal().Spacing(12).HorizontalAlignmentCenter().VerticalAlignmentCenter()
        .Children(
          TextBox()
            .Text(celsius.Select(x => x.ToString()))
            .OnText((tc, o) => o.Subscribe(x =>
            {
              tc.Errors(Enumerable.Empty<string>());
              if (string.IsNullOrWhiteSpace(x)) return;
              if (!double.TryParse(x, out var c))
              {
                tc.Errors(new[] { "Invalid number." });
                return;
              }

              fahrenheit.OnNext(Math.Round(c * (9d / 5d) + 32d));
            })),
          Label()
            .HorizontalAlignmentCenter().VerticalAlignmentCenter()
            .Content("Celsius = "),
          TextBox()
            .Text(fahrenheit.Select(x => x.ToString()))
            .OnText((tf, o) => o.Subscribe(x =>
            {
              tf.Errors(Enumerable.Empty<string>());
              if (string.IsNullOrWhiteSpace(x)) return;
              if (!double.TryParse(x, out var f))
              {
                tf.Errors(new[] { "Invalid number." });
                return;
              }

              celsius.OnNext(Math.Round((f - 32d) * (5d / 9d)));
            })),
          Label()
            .HorizontalAlignmentCenter().VerticalAlignmentCenter()
            .Content("Fahrenheit")));

AppBuilder.Configure<Application>()
  .UsePlatformDetect()
  .UseFluentTheme()
  .WithApplicationName("TempConv")
  .StartWithClassicDesktopLifetime(Build, args);
