namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> MenuItemClick => Avalonia.Controls.MenuItem.ClickEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.PointerEventArgs> MenuItemPointerEnterItem => Avalonia.Controls.MenuItem.PointerEnterItemEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.PointerEventArgs> MenuItemPointerLeaveItem => Avalonia.Controls.MenuItem.PointerLeaveItemEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> MenuItemSubmenuOpened => Avalonia.Controls.MenuItem.SubmenuOpenedEvent;
}
