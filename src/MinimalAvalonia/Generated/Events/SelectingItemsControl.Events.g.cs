namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.IsSelectedChangedEvent"/> event defined in <see cref="Avalonia.Controls.Primitives.SelectingItemsControl"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> SelectingItemsControlIsSelectedChanged => Avalonia.Controls.Primitives.SelectingItemsControl.IsSelectedChangedEvent;

    /// <summary>
    /// The <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent"/> event defined in <see cref="Avalonia.Controls.Primitives.SelectingItemsControl"/> class.
    /// </summary>
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Controls.SelectionChangedEventArgs> SelectingItemsControlSelectionChanged => Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent;
}
