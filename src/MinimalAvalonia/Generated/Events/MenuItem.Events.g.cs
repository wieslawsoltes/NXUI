namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuItem.ClickEvent"/> event defined in <see cref="Avalonia.Controls.MenuItem"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> MenuItemClick => Avalonia.Controls.MenuItem.ClickEvent;

    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuItem.PointerEnteredItemEvent"/> event defined in <see cref="Avalonia.Controls.MenuItem"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.PointerEventArgs> MenuItemPointerEnteredItem => Avalonia.Controls.MenuItem.PointerEnteredItemEvent;

    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuItem.PointerExitedItemEvent"/> event defined in <see cref="Avalonia.Controls.MenuItem"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.PointerEventArgs> MenuItemPointerExitedItem => Avalonia.Controls.MenuItem.PointerExitedItemEvent;

    /// <summary>
    /// The <see cref="Avalonia.Controls.MenuItem.SubmenuOpenedEvent"/> event defined in <see cref="Avalonia.Controls.MenuItem"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> MenuItemSubmenuOpened => Avalonia.Controls.MenuItem.SubmenuOpenedEvent;
}
