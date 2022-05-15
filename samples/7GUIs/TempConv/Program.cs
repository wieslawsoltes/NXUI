var celsius = new Subject<string?>();
var fahrenheit = new Subject<string?>();

Window Build() 
    => Window()
        .Title("TempConv").Padding(12).Width(450).Height(200)
        .Content(
            StackPanel()
                .OrientationHorizontal().Spacing(12).HorizontalAlignmentCenter().VerticalAlignmentCenter()
                .Children(
                    TextBox()
                        .Text(celsius)
                        .OnText((tc, o) => o.Subscribe(x => {
                            tc.Errors(Enumerable.Empty<string>());
                            if (string.IsNullOrWhiteSpace(x)) {
                                return;
                            }
                            if (!double.TryParse(x, out var c)) {
                                tc.Errors(new[] { "Invalid number." });
                                return;
                            }
                            var f = Math.Round(c * (9d / 5d) + 32d);
                            fahrenheit.OnNext($"{f}");
                        })),
                    Label()
                        .HorizontalAlignmentCenter().VerticalAlignmentCenter()
                        .Content("Celsius = "),
                    TextBox()
                        .Text(fahrenheit)
                        .OnText((tf, o) => o.Subscribe(x => {
                            tf.Errors(Enumerable.Empty<string>());
                            if (string.IsNullOrWhiteSpace(x)) {
                                return;
                            }
                            if (!double.TryParse(x, out var f)) {
                                tf.Errors(new[] { "Invalid number." });
                                return;
                            }
                            var c = Math.Round((f - 32d) * (5d / 9d));
                            celsius.OnNext($"{c}");
                        })),
                    Label()
                        .HorizontalAlignmentCenter().VerticalAlignmentCenter()
                        .Content("Fahrenheit")));

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .WithApplicationName("TempConv")
    .StartWithClassicDesktopLifetime(Build, args);
