namespace MinimalAvalonia;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    // Button

    public static RoutedEvent<RoutedEventArgs> ButtonClick => Avalonia.Controls.Button.ClickEvent;

    // Control
    
    public static RoutedEvent<RequestBringIntoViewEventArgs> ControlRequestBringIntoView => Avalonia.Controls.Control.RequestBringIntoViewEvent;
    public static RoutedEvent<ContextRequestedEventArgs> ControlContextRequested => Avalonia.Controls.Control.ContextRequestedEvent;
    
    // InputElement

    public static RoutedEvent<GotFocusEventArgs> InputElementGotFocus => Avalonia.Input.InputElement.GotFocusEvent;
    public static RoutedEvent<RoutedEventArgs> InputElementLostFocus => Avalonia.Input.InputElement.LostFocusEvent;
    public static RoutedEvent<KeyEventArgs> InputElementKeyDown => Avalonia.Input.InputElement.KeyDownEvent;
    public static RoutedEvent<KeyEventArgs> InputElementKeyUp => Avalonia.Input.InputElement.KeyUpEvent;
    public static RoutedEvent<TextInputEventArgs> InputElementTextInput => Avalonia.Input.InputElement.TextInputEvent;
    public static RoutedEvent<TextInputMethodClientRequestedEventArgs> InputElementTextInputMethodClientRequested => Avalonia.Input.InputElement.TextInputMethodClientRequestedEvent;
    public static RoutedEvent<PointerEventArgs> InputElementPointerEnter => Avalonia.Input.InputElement.PointerEnterEvent;
    public static RoutedEvent<PointerEventArgs> InputElementPointerLeave => Avalonia.Input.InputElement.PointerLeaveEvent;
    public static RoutedEvent<PointerEventArgs> InputElementPointerMoved => Avalonia.Input.InputElement.PointerMovedEvent;
    public static RoutedEvent<PointerPressedEventArgs> InputElementPointerPressed => Avalonia.Input.InputElement.PointerPressedEvent;
    public static RoutedEvent<PointerReleasedEventArgs> InputElementPointerReleased => Avalonia.Input.InputElement.PointerReleasedEvent;
    public static RoutedEvent<PointerCaptureLostEventArgs> InputElementPointerCaptureLost => Avalonia.Input.InputElement.PointerCaptureLostEvent;
    public static RoutedEvent<PointerWheelEventArgs> InputElementPointerWheelChanged => Avalonia.Input.InputElement.PointerWheelChangedEvent;

    // TemplatedControl

    public static RoutedEvent<TemplateAppliedEventArgs> TemplatedControlTemplateApplied => Avalonia.Controls.Primitives.TemplatedControl.TemplateAppliedEvent;

    // TextBox

    public static RoutedEvent<RoutedEventArgs> TextBoxCopyingToClipboard => Avalonia.Controls.TextBox.CopyingToClipboardEvent;
    public static RoutedEvent<RoutedEventArgs> TextBoxCuttingToClipboard => Avalonia.Controls.TextBox.CuttingToClipboardEvent;
    public static RoutedEvent<RoutedEventArgs> TextBoxPastingFromClipboard => Avalonia.Controls.TextBox.PastingFromClipboardEvent;
    
    // Window
    
    public static RoutedEvent WindowWindowClosed => Avalonia.Controls.Window.WindowClosedEvent;
    public static RoutedEvent WindowWindowOpened => Avalonia.Controls.Window.WindowOpenedEvent;
}
