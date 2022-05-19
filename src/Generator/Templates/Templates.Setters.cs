using System.Diagnostics.CodeAnalysis;

// ReSharper disable once CheckNamespace
namespace Generator;

[SuppressMessage("ReSharper", "InconsistentNaming")]
internal static partial class Templates
{
    public static string PropertySettersHeaderTemplate = @"
public static partial class %ClassName%Setters
{";

    public static string PropertySettersFooterTemplate = @"}";

    public static string PropertySettersTemplate = @"    // %Name%Property

    public static Style Set%ClassName%%Name%(this Style style, %ValueType% value)
    {
        style.Setters.Add(new Setter(%ClassType%.%Name%Property, value));
        return style;
    }

    public static Style Set%ClassName%%Name%(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(%ClassType%.%Name%Property, binding));
        return style;
    }

    public static Style Set%ClassName%%Name%(this Style style, IObservable<%ValueType%> observable)
    {
        style.Setters.Add(new Setter(%ClassType%.%Name%Property, observable.ToBinding()));
        return style;
    }

    public static KeyFrame Set%ClassName%%Name%(this KeyFrame keyFrame, %ValueType% value)
    {
        keyFrame.Setters.Add(new Setter(%ClassType%.%Name%Property, value));
        return keyFrame;
    }

    public static KeyFrame Set%ClassName%%Name%(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(%ClassType%.%Name%Property, binding));
        return keyFrame;
    }

    public static KeyFrame Set%ClassName%%Name%(this KeyFrame keyFrame, IObservable<%ValueType%> observable)
    {
        keyFrame.Setters.Add(new Setter(%ClassType%.%Name%Property, observable.ToBinding()));
        return keyFrame;
    }";
}
