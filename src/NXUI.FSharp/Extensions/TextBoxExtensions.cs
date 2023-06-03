// ReSharper disable InconsistentNaming
namespace NXUI.FSharp.Extensions;

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
    public static IBinding textAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
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
    public static IBinding horizontalContentAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
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
    public static IBinding verticalContentAlignment(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
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
    public static IBinding textWrapping(this TextBox obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBox.TextWrappingProperty.Bind().WithMode(mode)];
    }
}
