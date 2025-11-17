using System.Diagnostics.CodeAnalysis;

// ReSharper disable once CheckNamespace
namespace Generator;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static partial class Templates
{
    public static string PropertySettersHeaderTemplate = """

/// <summary>
/// The avalonia <see cref="%ClassType%"/> class style setters extension methods.
/// </summary>
public static partial class %ClassName%Setters
{
""";

    public static string PropertySettersFooterTemplate = """
}
""";

    public static string PropertySettersValueTemplate = """
    // %ClassType%.%Name%Property

    /// <summary>
    /// Adds a style setter for an <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style Set%ClassName%%Name%(this Style style, %ValueType% value)
    {
        style.Setters.Add(new Setter(%ClassType%.%Name%Property, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame Set%ClassName%%Name%(this KeyFrame keyFrame, %ValueType% value)
    {
        keyFrame.Setters.Add(new Setter(%ClassType%.%Name%Property, value));
        return keyFrame;
    }
""";

    public static string PropertySettersValueHotReloadTemplate = """
#if NXUI_HOTRELOAD

    /// <summary>
    /// Adds a builder-recorded style setter for an <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="builder">The style builder.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The style builder.</returns>
    public static ElementBuilder<Style> Set%ClassName%%Name%(this ElementBuilder<Style> builder, %ValueType% value)
    {
        return builder.WithAction(style =>
        {
            style.Setters.Add(new Setter(%ClassType%.%Name%Property, value));
        });
    }

    /// <summary>
    /// Adds a builder-recorded keyframe setter for an <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="builder">The keyframe builder.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The keyframe builder.</returns>
    public static ElementBuilder<KeyFrame> Set%ClassName%%Name%(this ElementBuilder<KeyFrame> builder, %ValueType% value)
    {
        return builder.WithAction(keyFrame =>
        {
            keyFrame.Setters.Add(new Setter(%ClassType%.%Name%Property, value));
        });
    }

#endif
""";

    public static string PropertySettersObservableTemplate = """
    /// <summary>
    /// Adds a style setter for an <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style Set%ClassName%%Name%(this Style style, IObservable<%ValueType%> observable)
    {
        style.Setters.Add(new Setter(%ClassType%.%Name%Property, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame Set%ClassName%%Name%(this KeyFrame keyFrame, IObservable<%ValueType%> observable)
    {
        keyFrame.Setters.Add(new Setter(%ClassType%.%Name%Property, observable.ToBinding()));
        return keyFrame;
    }
""";

    public static string PropertySettersObservableHotReloadTemplate = """
#if NXUI_HOTRELOAD

    /// <summary>
    /// Adds a builder-recorded style setter for an <see cref="%ClassType%.%Name%Property"/> using an observable source.
    /// </summary>
    /// <param name="builder">The style builder.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The style builder.</returns>
    public static ElementBuilder<Style> Set%ClassName%%Name%(this ElementBuilder<Style> builder, IObservable<%ValueType%> observable)
    {
        return builder.WithAction(style =>
        {
            style.Setters.Add(new Setter(%ClassType%.%Name%Property, observable.ToBinding()));
        });
    }

    /// <summary>
    /// Adds a builder-recorded keyframe setter for an <see cref="%ClassType%.%Name%Property"/> using an observable source.
    /// </summary>
    /// <param name="builder">The keyframe builder.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The keyframe builder.</returns>
    public static ElementBuilder<KeyFrame> Set%ClassName%%Name%(this ElementBuilder<KeyFrame> builder, IObservable<%ValueType%> observable)
    {
        return builder.WithAction(keyFrame =>
        {
            keyFrame.Setters.Add(new Setter(%ClassType%.%Name%Property, observable.ToBinding()));
        });
    }

#endif
""";

    public static string PropertySettersBindingTemplate = """
    /// <summary>
    /// Adds a style setter for an <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style Set%ClassName%%Name%(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(%ClassType%.%Name%Property, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="%ClassType%.%Name%Property"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame Set%ClassName%%Name%(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(%ClassType%.%Name%Property, binding));
        return keyFrame;
    }
""";

    public static string PropertySettersBindingHotReloadTemplate = """
#if NXUI_HOTRELOAD

    /// <summary>
    /// Adds a builder-recorded style setter for an <see cref="%ClassType%.%Name%Property"/> using a binding.
    /// </summary>
    /// <param name="builder">The style builder.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The style builder.</returns>
    public static ElementBuilder<Style> Set%ClassName%%Name%(this ElementBuilder<Style> builder, Avalonia.Data.IBinding binding)
    {
        return builder.WithAction(style =>
        {
            style.Setters.Add(new Setter(%ClassType%.%Name%Property, binding));
        });
    }

    /// <summary>
    /// Adds a builder-recorded keyframe setter for an <see cref="%ClassType%.%Name%Property"/> using a binding.
    /// </summary>
    /// <param name="builder">The keyframe builder.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The keyframe builder.</returns>
    public static ElementBuilder<KeyFrame> Set%ClassName%%Name%(this ElementBuilder<KeyFrame> builder, Avalonia.Data.IBinding binding)
    {
        return builder.WithAction(keyFrame =>
        {
            keyFrame.Setters.Add(new Setter(%ClassType%.%Name%Property, binding));
        });
    }

#endif
""";
}
