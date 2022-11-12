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
        if (line is null)
        {
          line = Line().Styles(LineStyle()).StartPoint(x).EndPoint(x);
          canvas.Children(line);
        }
      }))
    .OnPointerReleased((canvas, o)
      => o.Select(x => x.GetPosition(canvas)).Subscribe(x =>
      {
        if (line is not null)
        {
          line.EndPoint(x);
          var origin = new RelativePoint(
            (line.StartPoint.X + line.EndPoint.X) / 2,
            (line.StartPoint.Y + line.EndPoint.Y) / 2,
            RelativeUnit.Absolute);
          line.RenderTransform(RotateTransform());
          line.Styles(RotateAnimation(TimeSpan.FromSeconds(5), 0d, 360d, origin));
          line = null;
        }
      }))
    .OnPointerMoved((canvas, o)
      => o.Select(x => x.GetPosition(canvas)).Subscribe(x =>
      {
        line?.EndPoint(x);
      }));

Style LineStyle()
{
  var strokeThickness = 1d;
  var strokeThicknessObservable = Observable
    .Timer(TimeSpan.Zero, TimeSpan.FromSeconds(1), AvaloniaScheduler.Instance)
    .Select(_ => strokeThickness += 0.5d);
  return Style()
    .Selector(x => x.OfType<Line>())
    .SetShapeStroke(Brushes.Red)
    .SetShapeStrokeThickness(strokeThicknessObservable);
}

Style RotateAnimation(TimeSpan duration, double startAngle, double endAngle, RelativePoint origin)
  => Style()
    .Selector(x => x.Is<Control>())
    .SetVisualClipToBounds(false)
    .SetVisualRenderTransformOrigin(origin)
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
