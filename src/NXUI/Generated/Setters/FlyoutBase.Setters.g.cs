// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.FlyoutBase"/> class style setters extension methods.
/// </summary>
public static partial class FlyoutBaseSetters
{
    // Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetFlyoutBaseAttachedFlyout(this Style style, Avalonia.Controls.Primitives.FlyoutBase value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetFlyoutBaseAttachedFlyout(this KeyFrame keyFrame, Avalonia.Controls.Primitives.FlyoutBase value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetFlyoutBaseAttachedFlyout(this Style style, IObservable<Avalonia.Controls.Primitives.FlyoutBase> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetFlyoutBaseAttachedFlyout(this KeyFrame keyFrame, IObservable<Avalonia.Controls.Primitives.FlyoutBase> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetFlyoutBaseAttachedFlyout(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetFlyoutBaseAttachedFlyout(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty, binding));
        return keyFrame;
    }
}
