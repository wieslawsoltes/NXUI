namespace MinimalAvalonia.Extensions;

public static partial class TextBoxExtensions
{
    // TextAlignmentProperty

    public static IBinding TextAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.TextAlignmentProperty.Bind().WithMode(mode)];
    }

    // HorizontalContentAlignmentProperty


    public static IBinding HorizontalContentAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    // VerticalContentAlignmentProperty

    public static IBinding VerticalContentAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.VerticalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    // TextWrappingProperty

    public static IBinding TextWrapping(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.TextWrappingProperty.Bind().WithMode(mode)];
    }
}
