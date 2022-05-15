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
                        .OnText(o => o.Subscribe(x => {
                            if (x is null) {
                                return; // TODO: Handle error.
                            }
                            if (!double.TryParse(x, out var c)) {
                                return; // TODO: Handle error.
                            }
                            var f = Math.Round(c * (9d / 5d) + 32d);
                            fahrenheit.OnNext($"{f}");
                        })),
                    Label()
                        .HorizontalAlignmentCenter().VerticalAlignmentCenter()
                        .Content("Celsius = "),
                    TextBox()
                        .Text(fahrenheit)
                        .OnText(o => o.Subscribe(x => {
                            if (x is null) {
                                return; // TODO: Handle error.
                            }
                            if (!double.TryParse(x, out var f)) {
                                return; // TODO: Handle error.
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
