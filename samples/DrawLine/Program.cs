using NXUI.Extensions;
#if NXUI_HOTRELOAD
using NXUI.HotReload.Nodes;
#endif

object Build()
  => Window()
    .Title("DrawLine1").Width(500).Height(400)
    .Content(MainView());

#if NXUI_HOTRELOAD
ElementBuilder<Canvas> MainView()
#else
Canvas MainView()
#endif
  => Canvas()
    .Background(Brushes.WhiteSmoke)
#if NXUI_HOTRELOAD
    .Var(default(ElementRef<Line>), out var lineRef)
    .Var(false, out var isDrawing)
#else
    .Var(default(Line), out var line)
#endif
    .Var(default(Point), out var startPoint)
    .Var(default(Point), out var endPoint)
    .OnPointerPressed((canvas, o)
      => o.Select(x => x.GetPosition(canvas)).Subscribe(x =>
      {
#if NXUI_HOTRELOAD
        if (isDrawing) return;
        var newLine = Line(out var createdRef)
          .Styles(LineStyle())
          .StartPoint(x)
          .EndPoint(x);
        var mountedLine = newLine.Mount();
        canvas.Children(mountedLine);
        lineRef = createdRef;
        isDrawing = true;
#else
        if (line is not null) return;
        line = Line(out _)
          .Styles(LineStyle())
          .StartPoint(x)
          .EndPoint(x);
        canvas.Children(line);
#endif
        startPoint = x;
        endPoint = x;
      }))
    .OnPointerReleased((canvas, o)
      => o.Select(x => x.GetPosition(canvas)).Subscribe(x =>
      {
#if NXUI_HOTRELOAD
        if (!isDrawing) return;
        lineRef.EndPoint(x);
        endPoint = x;
#else
        if (line is null) return;
        line.EndPoint(x);
#endif
        var origin = new RelativePoint(
          (startPoint.X + endPoint.X) / 2,
          (startPoint.Y + endPoint.Y) / 2,
          RelativeUnit.Absolute);
#if NXUI_HOTRELOAD
        lineRef.RenderTransform(RotateTransform(out _).Mount());
        var rotationStyle = RotateAnimation(TimeSpan.FromSeconds(5), 0d, 360d, origin).Mount();
        lineRef.With(control => control.Styles.Add(rotationStyle));
        lineRef = default;
        isDrawing = false;
#else
        line.RenderTransform(RotateTransform(out _));
        line.Styles(RotateAnimation(TimeSpan.FromSeconds(5), 0d, 360d, origin));
        line = null;
#endif
      }))
    .OnPointerMoved((canvas, o)
      => o.Select(x => x.GetPosition(canvas)).Subscribe(x =>
      {
#if NXUI_HOTRELOAD
        if (!isDrawing) return;
        lineRef.EndPoint(x);
#else
        line?.EndPoint(x);
#endif
        endPoint = x;
      }));

#if NXUI_HOTRELOAD
ElementBuilder<Style> LineStyle()
#else
Style LineStyle()
#endif
{
  var strokeThickness = 1d;
  var strokeThicknessObservable = Observable
    .Timer(TimeSpan.Zero, TimeSpan.FromSeconds(1))
    .Select(_ => strokeThickness += 0.5d);

#if NXUI_HOTRELOAD
  return Style()
    .Selector(x => x.OfType<Line>())
    .SetShapeStroke(Brushes.Blue)
    .SetShapeStrokeThickness(strokeThicknessObservable);
#else
  Style(out var style)
    .Selector(x => x.OfType<Line>())
    .SetShapeStroke(Brushes.Blue)
    .SetShapeStrokeThickness(strokeThicknessObservable);
  return style;
#endif
}

#if NXUI_HOTRELOAD
ElementBuilder<Style> RotateAnimation(TimeSpan duration, double startAngle, double endAngle, RelativePoint origin)
#else
Style RotateAnimation(TimeSpan duration, double startAngle, double endAngle, RelativePoint origin)
#endif
{
#if NXUI_HOTRELOAD
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
#else
  Style(out var style)
    .Selector(x => x.Is<Control>())
    .SetVisualClipToBounds(false)
    .SetVisualRenderTransformOrigin(origin);

  Animation(out var animation)
    .Duration(duration)
    .IterationCountInfinite()
    .PlaybackDirectionNormal()
    .Easing(new SpringEasing(1, 200, 2));

  KeyFrame(out var startFrame)
    .Cue(0.0)
    .SetRotateTransformAngle(startAngle);

  KeyFrame(out var endFrame)
    .Cue(1.0)
    .SetRotateTransformAngle(endAngle);

  animation.Children.Add(startFrame);
  animation.Children.Add(endFrame);

  style.Animations(animation);
  return style;
#endif
}

return HotReloadHost.Run(Build, "DrawLine", args);
