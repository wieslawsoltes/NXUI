namespace MinimalAvalonia;

public static class WindowExtensions
{
    public static Window SizeToContentManual(this Window window)
    {
        window[Window.SizeToContentProperty] = SizeToContent.Manual;
        return window;
    }

    public static Window SizeToContentWidth(this Window window)
    {
        window[Window.SizeToContentProperty] = SizeToContent.Width;
        return window;
    }

    public static Window SizeToContentHeight(this Window window)
    {
        window[Window.SizeToContentProperty] = SizeToContent.Height;
        return window;
    }

    public static Window SizeToContentWidthAndHeight(this Window window)
    {
        window[Window.SizeToContentProperty] = SizeToContent.WidthAndHeight;
        return window;
    }

    public static Window Title(this Window window, string title)
    {
        window.Title = title;
        return window;
    }

    // TODO:
    // HasSystemDecorationsProperty
    // ExtendClientAreaToDecorationsHintProperty
    // ExtendClientAreaChromeHintsProperty
    // ExtendClientAreaTitleBarHeightHintProperty
    // SystemDecorationsProperty
    // ShowActivatedProperty
    // ShowInTaskbarProperty
    // WindowStateProperty
    // IconProperty
    // WindowStartupLocationProperty
    // CanResizeProperty
    // WindowClosedEvent
    // WindowOpenedEvent
}
