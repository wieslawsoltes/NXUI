// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.DashStyle"/> class style setters extension methods.
/// </summary>
public static partial class DashStyleSetters
{
    // Avalonia.Media.DashStyle.DashesProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.DashStyle.DashesProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDashStyleDashes(this Style style, Avalonia.Collections.AvaloniaList<System.Double> value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.DashStyle.DashesProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.DashStyle.DashesProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDashStyleDashes(this KeyFrame keyFrame, Avalonia.Collections.AvaloniaList<System.Double> value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.DashStyle.DashesProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.DashStyle.DashesProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDashStyleDashes(this Style style, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.DashStyle.DashesProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.DashStyle.DashesProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDashStyleDashes(this KeyFrame keyFrame, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.DashStyle.DashesProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.DashStyle.DashesProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDashStyleDashes(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.DashStyle.DashesProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.DashStyle.DashesProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDashStyleDashes(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.DashStyle.DashesProperty, binding));
        return keyFrame;
    }

    // Avalonia.Media.DashStyle.OffsetProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.DashStyle.OffsetProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDashStyleOffset(this Style style, System.Double value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.DashStyle.OffsetProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.DashStyle.OffsetProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDashStyleOffset(this KeyFrame keyFrame, System.Double value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.DashStyle.OffsetProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.DashStyle.OffsetProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDashStyleOffset(this Style style, IObservable<System.Double> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.DashStyle.OffsetProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.DashStyle.OffsetProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDashStyleOffset(this KeyFrame keyFrame, IObservable<System.Double> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.DashStyle.OffsetProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.DashStyle.OffsetProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDashStyleOffset(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.DashStyle.OffsetProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.DashStyle.OffsetProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDashStyleOffset(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.DashStyle.OffsetProperty, binding));
        return keyFrame;
    }
}
