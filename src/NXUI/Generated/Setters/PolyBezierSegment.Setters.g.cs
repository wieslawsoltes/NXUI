// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.PolyBezierSegment"/> class style setters extension methods.
/// </summary>
public static partial class PolyBezierSegmentSetters
{
    // Avalonia.Media.PolyBezierSegment.PointsProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.PolyBezierSegment.PointsProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPolyBezierSegmentPoints(this Style style, Avalonia.Points value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.PolyBezierSegment.PointsProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.PolyBezierSegment.PointsProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPolyBezierSegmentPoints(this KeyFrame keyFrame, Avalonia.Points value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.PolyBezierSegment.PointsProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.PolyBezierSegment.PointsProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPolyBezierSegmentPoints(this Style style, IObservable<Avalonia.Points> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.PolyBezierSegment.PointsProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.PolyBezierSegment.PointsProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPolyBezierSegmentPoints(this KeyFrame keyFrame, IObservable<Avalonia.Points> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.PolyBezierSegment.PointsProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.PolyBezierSegment.PointsProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPolyBezierSegmentPoints(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.PolyBezierSegment.PointsProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.PolyBezierSegment.PointsProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPolyBezierSegmentPoints(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.PolyBezierSegment.PointsProperty, binding));
        return keyFrame;
    }
}
