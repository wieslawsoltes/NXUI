namespace NXUI.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class WindowExtensions
{
    // SizeToContentProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="window"></param>
    /// <returns></returns>
    public static Window SizeToContentManual(this Window window)
    {
        window[Avalonia.Controls.Window.SizeToContentProperty] = Avalonia.Controls.SizeToContent.Manual;
        return window;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="window"></param>
    /// <returns></returns>
    public static Window SizeToContentWidth(this Window window)
    {
        window[Avalonia.Controls.Window.SizeToContentProperty] = Avalonia.Controls.SizeToContent.Width;
        return window;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="window"></param>
    /// <returns></returns>
    public static Window SizeToContentHeight(this Window window)
    {
        window[Avalonia.Controls.Window.SizeToContentProperty] = Avalonia.Controls.SizeToContent.Height;
        return window;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="window"></param>
    /// <returns></returns>
    public static Window SizeToContentWidthAndHeight(this Window window)
    {
        window[Avalonia.Controls.Window.SizeToContentProperty] = Avalonia.Controls.SizeToContent.WidthAndHeight;
        return window;
    }

    // TitleProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="window"></param>
    /// <param name="title"></param>
    /// <returns></returns>
    public static Window Title(this Window window, string title)
    {
        window[Avalonia.Controls.Window.TitleProperty] = title;
        return window;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="window"></param>
    /// <param name="binding"></param>
    /// <param name="mode"></param>
    /// <returns></returns>
    public static Window Title(this Window window, IBinding binding, BindingMode mode = BindingMode.TwoWay)
    {
        var property = Avalonia.Controls.Window.TitleProperty;
        window[property.Bind().WithMode(mode)] = binding;
        return window;
    }
}
