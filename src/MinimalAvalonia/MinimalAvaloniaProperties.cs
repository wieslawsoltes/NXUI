namespace MinimalAvalonia;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    // Button
    
    public static StyledProperty<KeyGesture?> ButtonHotKey => Avalonia.Controls.Button.HotKeyProperty;
    public static RoutedEvent<RoutedEventArgs> ButtonClick => Avalonia.Controls.Button.ClickEvent;

    // Control
    
    public static RoutedEvent<RequestBringIntoViewEventArgs> ControlRequestBringIntoView => Avalonia.Controls.Control.RequestBringIntoViewEvent;
    public static RoutedEvent<ContextRequestedEventArgs> ControlContextRequested => Avalonia.Controls.Control.ContextRequestedEvent;
    
    // InputElement
    
    public static StyledProperty<bool> InputElementIsTabStop => Avalonia.Input.InputElement.IsTabStopProperty;
    public static RoutedEvent<GotFocusEventArgs> InputElementGotFocus => Avalonia.Input.InputElement.GotFocusEvent;
    public static RoutedEvent<RoutedEventArgs> InputElementLostFocus => Avalonia.Input.InputElement.LostFocusEvent;
    public static RoutedEvent<KeyEventArgs> InputElementKeyDown => Avalonia.Input.InputElement.KeyDownEvent;
    public static RoutedEvent<KeyEventArgs> InputElementKeyUp => Avalonia.Input.InputElement.KeyUpEvent;
    public static StyledProperty<int> InputElementTabIndex => Avalonia.Input.InputElement.TabIndexProperty;
    public static RoutedEvent<TextInputEventArgs> InputElementTextInput => Avalonia.Input.InputElement.TextInputEvent;
    public static RoutedEvent<TextInputMethodClientRequestedEventArgs> InputElementTextInputMethodClientRequested => Avalonia.Input.InputElement.TextInputMethodClientRequestedEvent;
    //public static RoutedEvent<TextInputOptionsQueryEventArgs> InputElementTextInputOptionsQuery => Avalonia.Input.InputElement.TextInputOptionsQueryEvent;
    public static RoutedEvent<PointerEventArgs> InputElementPointerEnter => Avalonia.Input.InputElement.PointerEnterEvent;
    public static RoutedEvent<PointerEventArgs> InputElementPointerLeave => Avalonia.Input.InputElement.PointerLeaveEvent;
    public static RoutedEvent<PointerEventArgs> InputElementPointerMoved => Avalonia.Input.InputElement.PointerMovedEvent;
    public static RoutedEvent<PointerPressedEventArgs> InputElementPointerPressed => Avalonia.Input.InputElement.PointerPressedEvent;
    public static RoutedEvent<PointerReleasedEventArgs> InputElementPointerReleased => Avalonia.Input.InputElement.PointerReleasedEvent;
    public static RoutedEvent<PointerCaptureLostEventArgs> InputElementPointerCaptureLost => Avalonia.Input.InputElement.PointerCaptureLostEvent;
    public static RoutedEvent<PointerWheelEventArgs> InputElementPointerWheelChanged => Avalonia.Input.InputElement.PointerWheelChangedEvent;
    //public static RoutedEvent<RoutedEventArgs> InputElementTapped => Avalonia.Input.InputElement.TappedEvent;
    //public static RoutedEvent<RoutedEventArgs> InputElementDoubleTapped => Avalonia.Input.InputElement.DoubleTappedEvent;

    // Panel

    public static StyledProperty<IBrush?> PanelBackground => Avalonia.Controls.Panel.BackgroundProperty;

    // StackPanel

    public static StyledProperty<double> StackPanelSpacing => Avalonia.Controls.StackPanel.SpacingProperty;
    public static StyledProperty<Orientation> StackPanelOrientation => Avalonia.Controls.StackPanel.OrientationProperty;

    // TabControl

    public static StyledProperty<HorizontalAlignment> TabControlHorizontalContentAlignment => Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty;
    public static StyledProperty<VerticalAlignment> TabControlVerticalContentAlignment => Avalonia.Controls.TabControl.VerticalContentAlignmentProperty;
    public static StyledProperty<IDataTemplate?> TabControlContentTemplate => Avalonia.Controls.TabControl.ContentTemplateProperty;

    // TabItem

    public static StyledProperty<Dock> TabItemTabStripPlacement => Avalonia.Controls.TabItem.TabStripPlacementProperty;
    public static StyledProperty<bool> TabItemIsSelected => Avalonia.Controls.TabItem.IsSelectedProperty;

    // TemplatedControl

    public static StyledProperty<IBrush?> TemplatedControlBackground => Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty;
    public static StyledProperty<IBrush?> TemplatedControlBorderBrush => Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty;
    public static StyledProperty<Thickness> TemplatedControlBorderThickness => Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty;
    public static StyledProperty<CornerRadius> TemplatedControlCornerRadius => Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty;
    public static StyledProperty<FontFamily> TemplatedControlFontFamily => Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty;
    public static StyledProperty<double> TemplatedControlFontSize => Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty;
    public static StyledProperty<FontStyle> TemplatedControlFontStyle => Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty;
    public static StyledProperty<FontWeight> TemplatedControlFontWeight => Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty;
    public static StyledProperty<IBrush?> TemplatedControlForeground => Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty;
    public static StyledProperty<Thickness> TemplatedControlPadding => Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty;
    public static RoutedEvent<TemplateAppliedEventArgs> TemplatedControlTemplateApplied => Avalonia.Controls.Primitives.TemplatedControl.TemplateAppliedEvent;

    // TextBlock

    public static StyledProperty<IBrush?> TextBlockBackground => Avalonia.Controls.TextBlock.BackgroundProperty;
    public static StyledProperty<Thickness> TextBlockPadding => Avalonia.Controls.TextBlock.PaddingProperty;
    public static StyledProperty<FontFamily> TextBlockFontFamily => Avalonia.Controls.TextBlock.FontFamilyProperty;
    public static StyledProperty<double> TextBlockFontSize => Avalonia.Controls.TextBlock.FontSizeProperty;
    public static StyledProperty<FontStyle> TextBlockFontStyle => Avalonia.Controls.TextBlock.FontStyleProperty;
    public static StyledProperty<FontWeight> TextBlockFontWeight => Avalonia.Controls.TextBlock.FontWeightProperty;
    public static StyledProperty<IBrush?> TextBlockForeground => Avalonia.Controls.TextBlock.ForegroundProperty;

    // TextBox
    
    public static StyledProperty<TextAlignment> TextBoxTextAlignment => Avalonia.Controls.TextBox.TextAlignmentProperty;
    public static StyledProperty<HorizontalAlignment> TextBoxHorizontalContentAlignment => Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty;
    public static StyledProperty<VerticalAlignment> TextBoxVerticalContentAlignment => Avalonia.Controls.TextBox.VerticalContentAlignmentProperty;
    public static StyledProperty<TextWrapping> TextBoxTextWrapping => Avalonia.Controls.TextBox.TextWrappingProperty;
    public static RoutedEvent<RoutedEventArgs> TextBoxCopyingToClipboard => Avalonia.Controls.TextBox.CopyingToClipboardEvent;
    public static RoutedEvent<RoutedEventArgs> TextBoxCuttingToClipboard => Avalonia.Controls.TextBox.CuttingToClipboardEvent;
    public static RoutedEvent<RoutedEventArgs> TextBoxPastingFromClipboard => Avalonia.Controls.TextBox.PastingFromClipboardEvent;

    // TopLevel

    public static DirectProperty<TopLevel, Size> TopLevelClientSize => Avalonia.Controls.TopLevel.ClientSizeProperty;
    public static DirectProperty<TopLevel, Size?> TopLevelFrameSize => Avalonia.Controls.TopLevel.FrameSizeProperty;
    public static StyledProperty<IInputElement?> TopLevelPointerOverElement => Avalonia.Controls.TopLevel.PointerOverElementProperty;
    public static StyledProperty<WindowTransparencyLevel> TopLevelTransparencyLevelHint => Avalonia.Controls.TopLevel.TransparencyLevelHintProperty;
    public static DirectProperty<TopLevel, WindowTransparencyLevel> TopLevelActualTransparencyLevel => Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty;
    public static StyledProperty<IBrush> TopLevelTransparencyBackgroundFallback => Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty;

    // Window
    
    public static RoutedEvent WindowWindowClosed => Avalonia.Controls.Window.WindowClosedEvent;
    public static RoutedEvent WindowWindowOpened => Avalonia.Controls.Window.WindowOpenedEvent;
}
