// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Shapes.Line"/> class style setters extension methods.
/// </summary>
public static partial class LineSetters
{
    // Avalonia.Controls.Shapes.Line.StartPointProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Shapes.Line.StartPointProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetLineStartPoint(this Style style, Avalonia.Point value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Shapes.Line.StartPointProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Shapes.Line.StartPointProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetLineStartPoint(this KeyFrame keyFrame, Avalonia.Point value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Shapes.Line.StartPointProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Shapes.Line.StartPointProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetLineStartPoint(this Style style, IObservable<Avalonia.Point> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Shapes.Line.StartPointProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Shapes.Line.StartPointProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetLineStartPoint(this KeyFrame keyFrame, IObservable<Avalonia.Point> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Shapes.Line.StartPointProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Shapes.Line.StartPointProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetLineStartPoint(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Shapes.Line.StartPointProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Shapes.Line.StartPointProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetLineStartPoint(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Shapes.Line.StartPointProperty, binding));
        return keyFrame;
    }

    // Avalonia.Controls.Shapes.Line.EndPointProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Shapes.Line.EndPointProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetLineEndPoint(this Style style, Avalonia.Point value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Shapes.Line.EndPointProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Shapes.Line.EndPointProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetLineEndPoint(this KeyFrame keyFrame, Avalonia.Point value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Shapes.Line.EndPointProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Shapes.Line.EndPointProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetLineEndPoint(this Style style, IObservable<Avalonia.Point> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Shapes.Line.EndPointProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Shapes.Line.EndPointProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetLineEndPoint(this KeyFrame keyFrame, IObservable<Avalonia.Point> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Shapes.Line.EndPointProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Shapes.Line.EndPointProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetLineEndPoint(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Shapes.Line.EndPointProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Shapes.Line.EndPointProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetLineEndPoint(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Shapes.Line.EndPointProperty, binding));
        return keyFrame;
    }
}
