namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.VectorEventArgs> ThumbDragStarted => Avalonia.Controls.Primitives.Thumb.DragStartedEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.VectorEventArgs> ThumbDragDelta => Avalonia.Controls.Primitives.Thumb.DragDeltaEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.VectorEventArgs> ThumbDragCompleted => Avalonia.Controls.Primitives.Thumb.DragCompletedEvent;
}
