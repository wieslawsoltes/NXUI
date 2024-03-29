// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.ImageDrawing"/> class style setters extension methods.
/// </summary>
public static partial class ImageDrawingSetters
{
    // Avalonia.Media.ImageDrawing.ImageSourceProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.ImageDrawing.ImageSourceProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetImageDrawingImageSource(this Style style, Avalonia.Media.IImage value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.ImageSourceProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.ImageDrawing.ImageSourceProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetImageDrawingImageSource(this KeyFrame keyFrame, Avalonia.Media.IImage value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.ImageSourceProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.ImageDrawing.ImageSourceProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetImageDrawingImageSource(this Style style, IObservable<Avalonia.Media.IImage> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.ImageSourceProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.ImageDrawing.ImageSourceProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetImageDrawingImageSource(this KeyFrame keyFrame, IObservable<Avalonia.Media.IImage> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.ImageSourceProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.ImageDrawing.ImageSourceProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetImageDrawingImageSource(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.ImageSourceProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.ImageDrawing.ImageSourceProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetImageDrawingImageSource(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.ImageSourceProperty, binding));
        return keyFrame;
    }

    // Avalonia.Media.ImageDrawing.RectProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.ImageDrawing.RectProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetImageDrawingRect(this Style style, Avalonia.Rect value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.RectProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.ImageDrawing.RectProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetImageDrawingRect(this KeyFrame keyFrame, Avalonia.Rect value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.RectProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.ImageDrawing.RectProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetImageDrawingRect(this Style style, IObservable<Avalonia.Rect> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.RectProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.ImageDrawing.RectProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetImageDrawingRect(this KeyFrame keyFrame, IObservable<Avalonia.Rect> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.RectProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.ImageDrawing.RectProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetImageDrawingRect(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.RectProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.ImageDrawing.RectProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetImageDrawingRect(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.RectProperty, binding));
        return keyFrame;
    }
}
