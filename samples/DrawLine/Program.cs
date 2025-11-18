object Build()
  => Window()
    .Title("DrawLine1").Width(500).Height(400)
    .Content(MainView());

CanvasBuilder MainView()
  => Canvas()
    .Background(Brushes.WhiteSmoke)
    .Var(default(ElementRef<Line>), out var lineRef)
    .Var(false, out var isDrawing)
    .Var(default(Point), out var startPoint)
    .Var(default(Point), out var endPoint)
    .OnPointerPressed((canvas, o)
      => o.Select(x => x.GetPosition(canvas)).Subscribe(x =>
      {
        if (isDrawing) return;
        var newLine = Line(out var createdRef)
          .Styles(LineStyle())
          .StartPoint(x)
          .EndPoint(x);
        var mountedLine = newLine.Mount();
        canvas.Children(mountedLine);
        lineRef = createdRef;
        isDrawing = true;
        startPoint = x;
        endPoint = x;
      }))
    .OnPointerReleased((canvas, o)
      => o.Select(x => x.GetPosition(canvas)).Subscribe(x =>
      {
        if (!isDrawing) return;
        lineRef.EndPoint(x);
        endPoint = x;
        var origin = new RelativePoint(
          (startPoint.X + endPoint.X) / 2,
          (startPoint.Y + endPoint.Y) / 2,
          RelativeUnit.Absolute);
        lineRef.RenderTransform(RotateTransform(out _).Mount());
        var rotationStyle = RotateAnimation(TimeSpan.FromSeconds(5), 0d, 360d, origin).Mount();
        lineRef.With(control => control.Styles.Add(rotationStyle));
        lineRef = default;
        isDrawing = false;
      }))
    .OnPointerMoved((canvas, o)
      => o.Select(x => x.GetPosition(canvas)).Subscribe(x =>
      {
        if (!isDrawing) return;
        lineRef.EndPoint(x);
        endPoint = x;
      }));

StyleBuilder LineStyle()
{
  var strokeThickness = 1d;
  var strokeThicknessObservable = Observable
    .Timer(TimeSpan.Zero, TimeSpan.FromSeconds(1))
    .Select(_ => strokeThickness += 0.5d);

  return Style()
    .Selector(x => x.OfType<Line>())
    .SetShapeStroke(Brushes.Blue)
    .SetShapeStrokeThickness(strokeThicknessObservable);
}

StyleBuilder RotateAnimation(TimeSpan duration, double startAngle, double endAngle, RelativePoint origin)
{
  var animation = Animation()
    .Duration(duration)
    .IterationCountInfinite()
    .PlaybackDirectionNormal()
    .Easing(new SpringEasing(1, 200, 2));

  var startFrame = KeyFrame()
    .Cue(0.0)
    .SetRotateTransformAngle(startAngle);

  var endFrame = KeyFrame()
    .Cue(1.0)
    .SetRotateTransformAngle(endAngle);

  animation.KeyFrames(startFrame, endFrame);

  return Style()
    .Selector(x => x.Is<Control>())
    .SetVisualClipToBounds(false)
    .SetVisualRenderTransformOrigin(origin)
    .Animations(animation);
}

return HotReloadHost.Run(Build, "DrawLine", args);
