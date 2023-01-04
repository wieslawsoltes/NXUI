// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.SolidColorBrush"/> class style setters extension methods.
/// </summary>
public static partial class SolidColorBrushSetters
{
    // Avalonia.Media.SolidColorBrush.ColorProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetSolidColorBrushColor(this Style style, Avalonia.Media.Color value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.SolidColorBrush.ColorProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetSolidColorBrushColor(this KeyFrame keyFrame, Avalonia.Media.Color value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.SolidColorBrush.ColorProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetSolidColorBrushColor(this Style style, IObservable<Avalonia.Media.Color> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.SolidColorBrush.ColorProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetSolidColorBrushColor(this KeyFrame keyFrame, IObservable<Avalonia.Media.Color> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.SolidColorBrush.ColorProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetSolidColorBrushColor(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.SolidColorBrush.ColorProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetSolidColorBrushColor(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.SolidColorBrush.ColorProperty, binding));
        return keyFrame;
    }
}
