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
                line?.Styles(RotateAnimation(TimeSpan.FromSeconds(5), 0d, 360d));
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

Style RotateAnimation(TimeSpan duration, double startAngle, double endAngle) =>
    Style()
        .Selector(x => x.Is<Control>())
        .SetVisualClipToBounds(false)
        .SetVisualRenderTransformOrigin(RelativePoint.BottomRight)
        .Animations(
            Animation()
                .Duration(duration)
                .IterationCountInfinite()
                .PlaybackDirectionNormal()
                .KeyFrames(
                    KeyFrame().Cue(0.0).SetRotateTransformAngle(startAngle),
                    KeyFrame().Cue(1.0).SetRotateTransformAngle(endAngle)));

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .WithApplicationName("DrawLine")
    .StartWithClassicDesktopLifetime(Build, args);
