namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> SelectingItemsControlIsSelectedChanged => Avalonia.Controls.Primitives.SelectingItemsControl.IsSelectedChangedEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Controls.SelectionChangedEventArgs> SelectingItemsControlSelectionChanged => Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent;
}
