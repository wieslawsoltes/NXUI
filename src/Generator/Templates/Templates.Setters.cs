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
}
