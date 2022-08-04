namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.GotFocusEventArgs> InputElementGotFocus => Avalonia.Input.InputElement.GotFocusEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs> InputElementLostFocus => Avalonia.Input.InputElement.LostFocusEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.KeyEventArgs> InputElementKeyDown => Avalonia.Input.InputElement.KeyDownEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.KeyEventArgs> InputElementKeyUp => Avalonia.Input.InputElement.KeyUpEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.TextInputEventArgs> InputElementTextInput => Avalonia.Input.InputElement.TextInputEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.TextInput.TextInputMethodClientRequestedEventArgs> InputElementTextInputMethodClientRequested => Avalonia.Input.InputElement.TextInputMethodClientRequestedEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.PointerEventArgs> InputElementPointerEntered => Avalonia.Input.InputElement.PointerEnteredEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.PointerEventArgs> InputElementPointerExited => Avalonia.Input.InputElement.PointerExitedEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.PointerEventArgs> InputElementPointerMoved => Avalonia.Input.InputElement.PointerMovedEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.PointerPressedEventArgs> InputElementPointerPressed => Avalonia.Input.InputElement.PointerPressedEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.PointerReleasedEventArgs> InputElementPointerReleased => Avalonia.Input.InputElement.PointerReleasedEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.PointerCaptureLostEventArgs> InputElementPointerCaptureLost => Avalonia.Input.InputElement.PointerCaptureLostEvent;

    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Input.PointerWheelEventArgs> InputElementPointerWheelChanged => Avalonia.Input.InputElement.PointerWheelChangedEvent;
}
