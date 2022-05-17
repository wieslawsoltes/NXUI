Window Build() 
    => Window()
        .Title("DrawLine").Width(500).Height(400)
        .Content(
            Canvas()
                .Background(Brushes.WhiteSmoke)
                .Var(default(Line), out var line)
                .OnPointerPressed((canvas, o)
                    => o.Select(x => x.GetPosition(canvas)).Subscribe(x =>
                    {
                        canvas.Children(line = Line().StartPoint(x).EndPoint(x));
                    }))
                .OnPointerReleased((canvas, o)
                    => o.Select(x => x.GetPosition(canvas)).Subscribe(_ =>
                    {
                        line = null;
                    }))
                .OnPointerMoved(
                    (canvas, o)
                    => o.Select(x => x.GetPosition(canvas)).Subscribe(x =>
                    {
                        line?.EndPoint(x);
                    }))
                .Styles(
                    Style()
                        .Selector(x => x.OfType<Line>())
                        .Setter(ShapeStroke, Brushes.Black)
                        .Setter(ShapeStrokeThickness, 2d)));

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .WithApplicationName("DrawLine")
    .StartWithClassicDesktopLifetime(Build, args);
