using System.Diagnostics.CodeAnalysis;

namespace MinimalAvalonia;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static class MinimalAvaloniaProperties
{
    // Animatable

    public static StyledProperty<IClock> AnimatableClock => Avalonia.Animation.Animatable.ClockProperty;
    public static StyledProperty<Transitions?> AnimatableTransitions => Avalonia.Animation.Animatable.TransitionsProperty;

    // Animation

    public static DirectProperty<Animation, TimeSpan> AnimationDuration => Avalonia.Animation.Animation.DurationProperty;
    public static DirectProperty<Animation, IterationCount> AnimationIterationCount => Avalonia.Animation.Animation.IterationCountProperty;
    public static DirectProperty<Animation, PlaybackDirection> AnimationPlaybackDirection => Avalonia.Animation.Animation.PlaybackDirectionProperty;
    public static DirectProperty<Animation, FillMode> AnimationFillMode => Avalonia.Animation.Animation.FillModeProperty;
    public static DirectProperty<Animation, Easing> AnimationEasing => Avalonia.Animation.Animation.EasingProperty;
    public static DirectProperty<Animation, TimeSpan> AnimationDelay => Avalonia.Animation.Animation.DelayProperty;
    public static DirectProperty<Animation, TimeSpan> AnimationDelayBetweenIterations => Avalonia.Animation.Animation.DelayBetweenIterationsProperty;
    public static DirectProperty<Animation, double> AnimationSpeedRatio => Avalonia.Animation.Animation.SpeedRatioProperty;

    // Border

    public static StyledProperty<IBrush> BorderBackground => Avalonia.Controls.Border.BackgroundProperty;
    public static StyledProperty<IBrush> BorderBorderBrush => Avalonia.Controls.Border.BorderBrushProperty;
    public static StyledProperty<Thickness> BorderBorderThickness => Avalonia.Controls.Border.BorderThicknessProperty;
    public static StyledProperty<CornerRadius> BorderCornerRadius => Avalonia.Controls.Border.CornerRadiusProperty;
    public static StyledProperty<BoxShadows> BorderBoxShadow => Avalonia.Controls.Border.BoxShadowProperty;
    public static StyledProperty<double> BorderBorderDashOffset => Avalonia.Controls.Border.BorderDashOffsetProperty;
    public static StyledProperty<AvaloniaList<double>?> BorderBorderDashArray => Avalonia.Controls.Border.BorderDashArrayProperty;
    public static StyledProperty<PenLineCap> BorderBorderLineCap => Avalonia.Controls.Border.BorderLineCapProperty;
    public static StyledProperty<PenLineJoin> BorderBorderLineJoin => Avalonia.Controls.Border.BorderLineJoinProperty;

    // Button

    public static StyledProperty<ClickMode> ButtonClickMode => Avalonia.Controls.Button.ClickModeProperty;
    public static DirectProperty<Button, ICommand> ButtonCommand => Avalonia.Controls.Button.CommandProperty;
    public static StyledProperty<KeyGesture> ButtonHotKey => Avalonia.Controls.Button.HotKeyProperty;
    public static StyledProperty<object> ButtonCommandParameter => Avalonia.Controls.Button.CommandParameterProperty;
    public static StyledProperty<bool> ButtonIsDefault => Avalonia.Controls.Button.IsDefaultProperty;
    public static StyledProperty<bool> ButtonIsCancel => Avalonia.Controls.Button.IsCancelProperty;
    public static RoutedEvent<RoutedEventArgs> ButtonClick => Avalonia.Controls.Button.ClickEvent;
    public static StyledProperty<bool> ButtonIsPressed => Avalonia.Controls.Button.IsPressedProperty;
    public static StyledProperty<FlyoutBase> ButtonFlyout => Avalonia.Controls.Button.FlyoutProperty;

    // ContentControl

    public static StyledProperty<object> ContentControlContent => Avalonia.Controls.ContentControl.ContentProperty;
    public static StyledProperty<IDataTemplate> ContentControlContentTemplate => Avalonia.Controls.ContentControl.ContentTemplateProperty;
    public static StyledProperty<HorizontalAlignment> ContentControlHorizontalContentAlignment => Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty;
    public static StyledProperty<VerticalAlignment> ContentControlVerticalContentAlignment => Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty;

    // Control

    public static StyledProperty<ITemplate<IControl>?> ControlFocusAdorner => Avalonia.Controls.Control.FocusAdornerProperty;
    public static StyledProperty<object?> ControlTag => Avalonia.Controls.Control.TagProperty;
    public static StyledProperty<ContextMenu?> ControlContextMenu => Avalonia.Controls.Control.ContextMenuProperty;
    public static StyledProperty<FlyoutBase?> ControlContextFlyout => Avalonia.Controls.Control.ContextFlyoutProperty;
    public static RoutedEvent<RequestBringIntoViewEventArgs> ControlRequestBringIntoView => Avalonia.Controls.Control.RequestBringIntoViewEvent;
    public static RoutedEvent<ContextRequestedEventArgs> ControlContextRequested => Avalonia.Controls.Control.ContextRequestedEvent;

    // Decorator

    public static StyledProperty<IControl> DecoratorChild => Avalonia.Controls.Decorator.ChildProperty;
    public static StyledProperty<Thickness> DecoratorPadding => Avalonia.Controls.Decorator.PaddingProperty;

    // DockPanel

    public static AttachedProperty<Dock> DockPanelDock => Avalonia.Controls.DockPanel.DockProperty;
    public static StyledProperty<bool> DockPanelLastChildFill => Avalonia.Controls.DockPanel.LastChildFillProperty;

    // HeaderedContentControl

    public static StyledProperty<object?> HeaderedContentControlHeader => Avalonia.Controls.Primitives.HeaderedContentControl.HeaderProperty;
    public static StyledProperty<IDataTemplate?> HeaderedContentControlHeaderTemplate => Avalonia.Controls.Primitives.HeaderedContentControl.HeaderTemplateProperty;

    // InputElement

    public static StyledProperty<bool> InputElementFocusable => Avalonia.Input.InputElement.FocusableProperty;
    public static StyledProperty<bool> InputElementIsEnabled => Avalonia.Input.InputElement.IsEnabledProperty;
    public static DirectProperty<InputElement, bool> InputElementIsEffectivelyEnabled => Avalonia.Input.InputElement.IsEffectivelyEnabledProperty;
    public static StyledProperty<Cursor?> InputElementCursor => Avalonia.Input.InputElement.CursorProperty;
    public static DirectProperty<InputElement, bool> InputElementIsKeyboardFocusWithin => Avalonia.Input.InputElement.IsKeyboardFocusWithinProperty;
    public static DirectProperty<InputElement, bool> InputElementIsFocused => Avalonia.Input.InputElement.IsFocusedProperty;
    public static StyledProperty<bool> InputElementIsHitTestVisible => Avalonia.Input.InputElement.IsHitTestVisibleProperty;
    public static DirectProperty<InputElement, bool> InputElementIsPointerOver => Avalonia.Input.InputElement.IsPointerOverProperty;
    public static StyledProperty<bool> InputElementIsTabStop => Avalonia.Input.InputElement.IsTabStopProperty;
    public static RoutedEvent<GotFocusEventArgs> InputElementGotFocus => Avalonia.Input.InputElement.GotFocusEvent;
    public static RoutedEvent<RoutedEventArgs> InputElementLostFocus => Avalonia.Input.InputElement.LostFocusEvent;
    public static RoutedEvent<KeyEventArgs> InputElementKeyDown => Avalonia.Input.InputElement.KeyDownEvent;
    public static RoutedEvent<KeyEventArgs> InputElementKeyUp => Avalonia.Input.InputElement.KeyUpEvent;
    public static StyledProperty<int> InputElementTabIndex => Avalonia.Input.InputElement.TabIndexProperty;
    public static RoutedEvent<TextInputEventArgs> InputElementTextInput => Avalonia.Input.InputElement.TextInputEvent;
    public static RoutedEvent<TextInputMethodClientRequestedEventArgs> InputElementTextInputMethodClientRequested => Avalonia.Input.InputElement.TextInputMethodClientRequestedEvent;
    public static RoutedEvent<TextInputOptionsQueryEventArgs> InputElementTextInputOptionsQuery => Avalonia.Input.InputElement.TextInputOptionsQueryEvent;
    public static RoutedEvent<PointerEventArgs> InputElementPointerEnter => Avalonia.Input.InputElement.PointerEnterEvent;
    public static RoutedEvent<PointerEventArgs> InputElementPointerLeave => Avalonia.Input.InputElement.PointerLeaveEvent;
    public static RoutedEvent<PointerEventArgs> InputElementPointerMoved => Avalonia.Input.InputElement.PointerMovedEvent;
    public static RoutedEvent<PointerPressedEventArgs> InputElementPointerPressed => Avalonia.Input.InputElement.PointerPressedEvent;
    public static RoutedEvent<PointerReleasedEventArgs> InputElementPointerReleased => Avalonia.Input.InputElement.PointerReleasedEvent;
    public static RoutedEvent<PointerCaptureLostEventArgs> InputElementPointerCaptureLost => Avalonia.Input.InputElement.PointerCaptureLostEvent;
    public static RoutedEvent<PointerWheelEventArgs> InputElementPointerWheelChanged => Avalonia.Input.InputElement.PointerWheelChangedEvent;
    public static RoutedEvent<RoutedEventArgs> InputElementTapped => Avalonia.Input.InputElement.TappedEvent;
    public static RoutedEvent<RoutedEventArgs> InputElementDoubleTapped => Avalonia.Input.InputElement.DoubleTappedEvent;

    // ItemsControl

    public static DirectProperty<ItemsControl, IEnumerable> ItemsControlItems => Avalonia.Controls.ItemsControl.ItemsProperty;
    public static DirectProperty<ItemsControl, int> ItemsControlItemCount => Avalonia.Controls.ItemsControl.ItemCountProperty;
    public static StyledProperty<ITemplate<IPanel>> ItemsControlItemsPanel => Avalonia.Controls.ItemsControl.ItemsPanelProperty;
    public static StyledProperty<IDataTemplate> ItemsControlItemTemplate => Avalonia.Controls.ItemsControl.ItemTemplateProperty;

    // Label

    public static DirectProperty<Label, IInputElement> LabelTarget = Avalonia.Controls.Label.TargetProperty;

    // Layoutable

    public static DirectProperty<Layoutable, Size> LayoutableDesiredSize => Avalonia.Layout.Layoutable.DesiredSizeProperty;
    public static StyledProperty<double> LayoutableWidth => Avalonia.Layout.Layoutable.WidthProperty;
    public static StyledProperty<double> LayoutableHeight => Avalonia.Layout.Layoutable.HeightProperty;
    public static StyledProperty<double> LayoutableMinWidth => Avalonia.Layout.Layoutable.MinWidthProperty;
    public static StyledProperty<double> LayoutableMaxWidth => Avalonia.Layout.Layoutable.MaxWidthProperty;
    public static StyledProperty<double> LayoutableMinHeight => Avalonia.Layout.Layoutable.MinHeightProperty;
    public static StyledProperty<double> LayoutableMaxHeight => Avalonia.Layout.Layoutable.MaxHeightProperty;
    public static StyledProperty<Thickness> LayoutableMargin => Avalonia.Layout.Layoutable.MarginProperty;
    public static StyledProperty<HorizontalAlignment> LayoutableHorizontalAlignment => Avalonia.Layout.Layoutable.HorizontalAlignmentProperty;
    public static StyledProperty<VerticalAlignment> LayoutableVerticalAlignment => Avalonia.Layout.Layoutable.VerticalAlignmentProperty;
    public static StyledProperty<bool> LayoutableUseLayoutRounding => Avalonia.Layout.Layoutable.UseLayoutRoundingProperty;

    // Panel

    public static StyledProperty<IBrush> PanelBackground => Avalonia.Controls.Panel.BackgroundProperty;

    // StackPanel

    public static StyledProperty<double> StackPanelSpacing => Avalonia.Controls.StackPanel.SpacingProperty;
    public static StyledProperty<Orientation> StackPanelOrientation => Avalonia.Controls.StackPanel.OrientationProperty;

    // StyledElement

    // TabControl

    // TabItem

    // TemplatedControl

    public static StyledProperty<IBrush?> TemplatedControlBackground => Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty;

    // TextBlock

    public static DirectProperty<TextBlock, string> TextBlockText => Avalonia.Controls.TextBlock.TextProperty;

    // TextBox

    public static DirectProperty<TextBox, string> TextBoxText => Avalonia.Controls.TextBox.TextProperty;

    // Visual

    public static StyledProperty<bool> VisualClipToBounds => Avalonia.Visual.ClipToBoundsProperty;

    // Window

    public static StyledProperty<string> WindowTitle => Avalonia.Controls.Window.TitleProperty;

    // WrapPanel

    public static StyledProperty<Orientation> WrapPanelOrientation => Avalonia.Controls.WrapPanel.OrientationProperty;
    public static StyledProperty<double> WrapPanelItemWidth => Avalonia.Controls.WrapPanel.ItemWidthProperty;
    public static StyledProperty<double> WrapPanelItemHeight => Avalonia.Controls.WrapPanel.ItemHeightProperty;
}
