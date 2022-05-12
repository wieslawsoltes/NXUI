var celsius = new Subject<string?>();
var fahrenheit = new Subject<string?>();

Window Build() 
{
    Window(out var window)
        .Title("TempConv").Padding(12).Width(350).Height(200)
        .Content(
            StackPanel()
                .OrientationHorizontal().Spacing(12).HorizontalAlignmentCenter().VerticalAlignmentCenter()
                .Children(
                    TextBox(out var tc)
                        .Text(celsius),
                    Label()
                        .HorizontalAlignmentCenter().VerticalAlignmentCenter()
                        .Content("Celsius = "),
                    TextBox(out var tf)
                        .Text(fahrenheit),
                    Label()
                        .HorizontalAlignmentCenter().VerticalAlignmentCenter()
                        .Content("Fahrenheit")));

    tc.ObserveText().Subscribe(x =>
    {
        if (x is null) return;
        if (!double.TryParse(x, out var c))
        {
            celsius.OnError(new Exception());
            return;
        }
        var f = Math.Round(c * (9d / 5d) + 32d);
        fahrenheit.OnNext($"{f}");
        Debug.WriteLine($"Celsius = {x}");
    });

    tf.ObserveText().Subscribe(x =>
    {
        if (x is null) return;
        if (!double.TryParse(x, out var f)) return;
        var c = Math.Round((f - 32d) * (5d / 9d));
        celsius.OnNext($"{c}");
        Debug.WriteLine($"Fahrenheit = {f}");
    });

    return window;
}

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .WithApplicationName("TempConv")
    .StartWithClassicDesktopLifetime(Build, args);
