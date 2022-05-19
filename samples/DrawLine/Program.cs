Window Build() 
    => Window()
        .Title("DrawLine").Width(500).Height(400)
        .Content(MainView());

Control MainView()
    => Canvas()
        .Background(Brushes.WhiteSmoke)
        .Var(default(Line), out var line)
        .OnPointerPressed((canvas, o)
            => o.Select(x => x.GetPosition(canvas)).Subscribe(x =>
            {
                canvas.Children(line = Line().Styles(LineStyle()).StartPoint(x).EndPoint(x));
            }))
        .OnPointerReleased((canvas, o)
            => o.Select(x => x.GetPosition(canvas)).Subscribe(_ =>
            {
                line = null;
            }))
        .OnPointerMoved((canvas, o)
            => o.Select(x => x.GetPosition(canvas)).Subscribe(x =>
            {
                line?.EndPoint(x);
            }));

Style LineStyle() {
    var strokeThickness = 1d;
    var strokeThicknessObservable = Observable
        .Timer(TimeSpan.Zero, TimeSpan.FromSeconds(1), AvaloniaScheduler.Instance)
        .Select(_ => strokeThickness += 0.5d);
    return Style()
        .Selector(x => x.OfType<Line>())
        .SetShapeStroke(Brushes.Red)
        .SetShapeStrokeThickness(strokeThicknessObservable);
}

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .WithApplicationName("DrawLine")
    .StartWithClassicDesktopLifetime(Build, args);
