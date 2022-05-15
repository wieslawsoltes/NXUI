namespace MinimalAvalonia;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    // https://github.com/AvaloniaUI/Avalonia/pull/8141
    public static RoutedEvent<PointerEventArgs> InputElementPointerMoved => Avalonia.Input.InputElement.PointerMovedEvent;
}
