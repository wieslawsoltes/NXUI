namespace MinimalAvalonia.Extensions;

public static partial class WindowExtensions
{
    // SizeToContentProperty

    public static Window SizeToContentManual(this Window window)
    {
        window[Avalonia.Controls.Window.SizeToContentProperty] = Avalonia.Controls.SizeToContent.Manual;
        return window;
    }

    public static Window SizeToContentWidth(this Window window)
    {
        window[Avalonia.Controls.Window.SizeToContentProperty] = Avalonia.Controls.SizeToContent.Width;
        return window;
    }

    public static Window SizeToContentHeight(this Window window)
    {
        window[Avalonia.Controls.Window.SizeToContentProperty] = Avalonia.Controls.SizeToContent.Height;
        return window;
    }

    public static Window SizeToContentWidthAndHeight(this Window window)
    {
        window[Avalonia.Controls.Window.SizeToContentProperty] = Avalonia.Controls.SizeToContent.WidthAndHeight;
        return window;
    }

    // TitleProperty

    public static Window Title(this Window window, string title)
    {
        window[Avalonia.Controls.Window.TitleProperty] = title;
        return window;
    }

    public static Window Title(this Window window, IBinding binding, BindingMode mode = BindingMode.TwoWay)
    {
        var property = Avalonia.Controls.Window.TitleProperty;
        window[property.Bind().WithMode(mode)] = binding;
        return window;
    }
}
