namespace MinimalAvalonia.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class TextBoxExtensions
{
    // TextAlignmentProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="mode"></param>
    /// <returns></returns>
    public static IBinding TextAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.TextAlignmentProperty.Bind().WithMode(mode)];
    }

    // HorizontalContentAlignmentProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="mode"></param>
    /// <returns></returns>
    public static IBinding HorizontalContentAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    // VerticalContentAlignmentProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="mode"></param>
    /// <returns></returns>
    public static IBinding VerticalContentAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.VerticalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    // TextWrappingProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="mode"></param>
    /// <returns></returns>
    public static IBinding TextWrapping(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.TextWrappingProperty.Bind().WithMode(mode)];
    }
}
