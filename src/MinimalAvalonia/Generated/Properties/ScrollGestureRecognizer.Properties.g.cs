namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer,System.Boolean> ScrollGestureRecognizerCanHorizontallyScroll => Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty;

    public static Avalonia.DirectProperty<Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer,System.Boolean> ScrollGestureRecognizerCanVerticallyScroll => Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty;
}
