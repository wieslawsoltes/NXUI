namespace MinimalAvalonia.Extensions;

public static partial class TextBoxExtensions
{
    // TextAlignmentProperty

    public static T TextAlignment<T>(this T obj, TextAlignment value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.TextAlignmentProperty] = value;
        return obj;
    }

    public static T TextAlignment<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.TextAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding TextAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.TextAlignmentProperty.Bind().WithMode(mode)];
    }

    // HorizontalContentAlignmentProperty

    public static T HorizontalContentAlignment<T>(this T obj, HorizontalAlignment value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty] = value;
        return obj;
    }

    public static T HorizontalContentAlignment<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding HorizontalContentAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    // VerticalContentAlignmentProperty

    public static T VerticalContentAlignment<T>(this T obj, VerticalAlignment value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.VerticalContentAlignmentProperty] = value;
        return obj;
    }

    public static T VerticalContentAlignment<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.VerticalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding VerticalContentAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.VerticalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    // TextWrappingProperty

    public static T TextWrapping<T>(this T obj, TextWrapping value) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.TextWrappingProperty] = value;
        return obj;
    }

    public static T TextWrapping<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : TextBox
    {
        obj[Avalonia.Controls.TextBox.TextWrappingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding TextWrapping(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.TextWrappingProperty.Bind().WithMode(mode)];
    }
}
