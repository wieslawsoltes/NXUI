namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Controls.RequestBringIntoViewEventArgs> ControlRequestBringIntoView => Avalonia.Controls.Control.RequestBringIntoViewEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Controls.ContextRequestedEventArgs> ControlContextRequested => Avalonia.Controls.Control.ContextRequestedEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> ControlLoaded => Avalonia.Controls.Control.LoadedEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> ControlUnloaded => Avalonia.Controls.Control.UnloadedEvent;
}
