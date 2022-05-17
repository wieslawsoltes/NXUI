Window Build() 
    => Window()
        .Title("DrawLine").Width(500).Height(400)
        .Content(
            Canvas()
                .Background(Brushes.WhiteSmoke)
                .Var(default(Line), out var l)
                .OnPointerPressed((c, o)
                    => o.Select(x => x.GetPosition(c)).Subscribe(x => c.Children(l = Line().StartPoint(x).EndPoint(x))))
                .OnPointerReleased((c, o)
                    => o.Select(x => x.GetPosition(c)).Subscribe(_ => l = null))
                .OnPointerMoved((c, o)
                    => o.Select(x => x.GetPosition(c)).Subscribe(x => l?.EndPoint(x)))
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
