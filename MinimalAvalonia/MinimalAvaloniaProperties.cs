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

    // TODO: CheckBox

    // TODO: ComboBox

    // TODO: ComboBoxItem

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

    // Grid

    public static StyledProperty<bool> GridShowGridLines => Avalonia.Controls.Grid.ShowGridLinesProperty;
    public static AttachedProperty<int> GridColumn => Avalonia.Controls.Grid.ColumnProperty;
    public static AttachedProperty<int> GridRow => Avalonia.Controls.Grid.RowProperty;
    public static AttachedProperty<int> GridColumnSpan => Avalonia.Controls.Grid.ColumnSpanProperty;
    public static AttachedProperty<int> GridRowSpan => Avalonia.Controls.Grid.RowSpanProperty;
    public static AttachedProperty<bool> GridIsSharedSizeScope => Avalonia.Controls.Grid.IsSharedSizeScopeProperty;

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

    // TODO: ListBox

    // TODO: ListBoxItem

    // TODO: Menu

    // TODO: MenuItem

    // Panel

    public static StyledProperty<IBrush> PanelBackground => Avalonia.Controls.Panel.BackgroundProperty;

    // TODO: RadioButton

    // TODO: SelectingItemsControl

    // TODO: Separator

    // StackPanel

    public static StyledProperty<double> StackPanelSpacing => Avalonia.Controls.StackPanel.SpacingProperty;
    public static StyledProperty<Orientation> StackPanelOrientation => Avalonia.Controls.StackPanel.OrientationProperty;

    // StyledElement

    public static StyledProperty<object?> StyledElementDataContext => Avalonia.StyledElement.DataContextProperty;
    public static DirectProperty<StyledElement, string?> StyledElementName => Avalonia.StyledElement.NameProperty;
    public static DirectProperty<StyledElement, IStyledElement?> StyledElementParent => Avalonia.StyledElement.ParentProperty;
    public static DirectProperty<StyledElement, ITemplatedControl?> StyledElementTemplatedParent => Avalonia.StyledElement.TemplatedParentProperty;

    // TabControl

    public static StyledProperty<Dock> TabControlTabStripPlacement => Avalonia.Controls.TabControl.TabStripPlacementProperty;
    public static StyledProperty<HorizontalAlignment> TabControlHorizontalContentAlignment => Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty;
    public static StyledProperty<VerticalAlignment> TabControlVerticalContentAlignment => Avalonia.Controls.TabControl.VerticalContentAlignmentProperty;
    public static StyledProperty<IDataTemplate> TabControlContentTemplate => Avalonia.Controls.TabControl.ContentTemplateProperty;
    public static StyledProperty<object> TabControlSelectedContent => Avalonia.Controls.TabControl.SelectedContentProperty;
    public static StyledProperty<IDataTemplate> TabControlSelectedContentTemplate => Avalonia.Controls.TabControl.SelectedContentTemplateProperty;

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
    public static StyledProperty<IControlTemplate?> TemplatedControlTemplate => Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty;
    public static AttachedProperty<bool> TemplatedControlIsTemplateFocusTarget => Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty;
    public static RoutedEvent<TemplateAppliedEventArgs> TemplatedControlTemplateApplied => Avalonia.Controls.Primitives.TemplatedControl.TemplateAppliedEvent;

    // TextBlock

    public static StyledProperty<IBrush> TextBlockBackground => Avalonia.Controls.TextBlock.BackgroundProperty;
    public static StyledProperty<Thickness> TextBlockPadding => Avalonia.Controls.TextBlock.PaddingProperty;
    public static AttachedProperty<FontFamily> TextBlockFontFamily => Avalonia.Controls.TextBlock.FontFamilyProperty;
    public static AttachedProperty<double> TextBlockFontSize => Avalonia.Controls.TextBlock.FontSizeProperty;
    public static AttachedProperty<FontStyle> TextBlockFontStyle => Avalonia.Controls.TextBlock.FontStyleProperty;
    public static AttachedProperty<FontWeight> TextBlockFontWeight => Avalonia.Controls.TextBlock.FontWeightProperty;
    public static AttachedProperty<IBrush> TextBlockForeground => Avalonia.Controls.TextBlock.ForegroundProperty;
    public static StyledProperty<double> TextBlockLineHeight => Avalonia.Controls.TextBlock.LineHeightProperty;
    public static StyledProperty<int> TextBlockMaxLines => Avalonia.Controls.TextBlock.MaxLinesProperty;
    public static DirectProperty<TextBlock, string> TextBlockText => Avalonia.Controls.TextBlock.TextProperty;
    public static StyledProperty<TextAlignment> TextBlockTextAlignment => Avalonia.Controls.TextBlock.TextAlignmentProperty;
    public static StyledProperty<TextWrapping> TextBlockTextWrapping => Avalonia.Controls.TextBlock.TextWrappingProperty;
    public static StyledProperty<TextTrimming> TextBlockTextTrimming => Avalonia.Controls.TextBlock.TextTrimmingProperty;
    public static StyledProperty<TextDecorationCollection> TextBlockTextDecorations => Avalonia.Controls.TextBlock.TextDecorationsProperty;

    // TextBox

    public static StyledProperty<bool> TextBoxAcceptsReturn => Avalonia.Controls.TextBox.AcceptsReturnProperty;
    public static StyledProperty<bool> TextBoxAcceptsTab => Avalonia.Controls.TextBox.AcceptsTabProperty;
    public static DirectProperty<TextBox, int> TextBoxCaretIndex => Avalonia.Controls.TextBox.CaretIndexProperty;
    public static StyledProperty<bool> TextBoxIsReadOnly => Avalonia.Controls.TextBox.IsReadOnlyProperty;
    public static StyledProperty<char> TextBoxPasswordChar => Avalonia.Controls.TextBox.PasswordCharProperty;
    public static StyledProperty<IBrush> TextBoxSelectionBrush => Avalonia.Controls.TextBox.SelectionBrushProperty;
    public static StyledProperty<IBrush> TextBoxSelectionForegroundBrush => Avalonia.Controls.TextBox.SelectionForegroundBrushProperty;
    public static StyledProperty<IBrush> TextBoxCaretBrush => Avalonia.Controls.TextBox.CaretBrushProperty;
    public static DirectProperty<TextBox, int> TextBoxSelectionStart => Avalonia.Controls.TextBox.SelectionStartProperty;
    public static DirectProperty<TextBox, int> TextBoxSelectionEnd => Avalonia.Controls.TextBox.SelectionEndProperty;
    public static StyledProperty<int> TextBoxMaxLength => Avalonia.Controls.TextBox.MaxLengthProperty;
    public static DirectProperty<TextBox, string> TextBoxText => Avalonia.Controls.TextBox.TextProperty;
    public static StyledProperty<TextAlignment> TextBoxTextAlignment => Avalonia.Controls.TextBox.TextAlignmentProperty;
    public static StyledProperty<HorizontalAlignment> TextBoxHorizontalContentAlignment => Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty;
    public static StyledProperty<VerticalAlignment> TextBoxVerticalContentAlignment => Avalonia.Controls.TextBox.VerticalContentAlignmentProperty;
    public static StyledProperty<TextWrapping> TextBoxTextWrapping => Avalonia.Controls.TextBox.TextWrappingProperty;
    public static StyledProperty<string> TextBoxWatermark => Avalonia.Controls.TextBox.WatermarkProperty;
    public static StyledProperty<bool> TextBoxUseFloatingWatermark => Avalonia.Controls.TextBox.UseFloatingWatermarkProperty;
    public static DirectProperty<TextBox, string> TextBoxNewLine => Avalonia.Controls.TextBox.NewLineProperty;
    public static StyledProperty<object> TextBoxInnerLeftContent => Avalonia.Controls.TextBox.InnerLeftContentProperty;
    public static StyledProperty<object> TextBoxInnerRightContent => Avalonia.Controls.TextBox.InnerRightContentProperty;
    public static StyledProperty<bool> TextBoxRevealPassword => Avalonia.Controls.TextBox.RevealPasswordProperty;
    public static DirectProperty<TextBox, bool> TextBoxCanCut => Avalonia.Controls.TextBox.CanCutProperty;
    public static DirectProperty<TextBox, bool> TextBoxCanCopy => Avalonia.Controls.TextBox.CanCopyProperty;
    public static DirectProperty<TextBox, bool> TextBoxCanPaste => Avalonia.Controls.TextBox.CanPasteProperty;
    public static StyledProperty<bool> TextBoxIsUndoEnabled => Avalonia.Controls.TextBox.IsUndoEnabledProperty;
    public static DirectProperty<TextBox, int> TextBoxUndoLimit => Avalonia.Controls.TextBox.UndoLimitProperty;
    public static RoutedEvent<RoutedEventArgs> TextBoxCopyingToClipboard => Avalonia.Controls.TextBox.CopyingToClipboardEvent;
    public static RoutedEvent<RoutedEventArgs> TextBoxCuttingToClipboard => Avalonia.Controls.TextBox.CuttingToClipboardEvent;
    public static RoutedEvent<RoutedEventArgs> TextBoxPastingFromClipboard => Avalonia.Controls.TextBox.PastingFromClipboardEvent;

    // TopLevel

    public static DirectProperty<TopLevel, Size> TopLevelClientSize => Avalonia.Controls.TopLevel.ClientSizeProperty;
    public static DirectProperty<TopLevel, Size?> TopLevelFrameSize => Avalonia.Controls.TopLevel.FrameSizeProperty;
    public static StyledProperty<IInputElement> TopLevelPointerOverElement => Avalonia.Controls.TopLevel.PointerOverElementProperty;
    public static StyledProperty<WindowTransparencyLevel> TopLevelTransparencyLevelHint => Avalonia.Controls.TopLevel.TransparencyLevelHintProperty;
    public static DirectProperty<TopLevel, WindowTransparencyLevel> TopLevelActualTransparencyLevel => Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty;
    public static StyledProperty<IBrush> TopLevelTransparencyBackgroundFallback => Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty;

    // Visual

    public static DirectProperty<Visual, Rect> VisualBounds => Avalonia.Visual.BoundsProperty;
    public static DirectProperty<Visual, TransformedBounds?> VisualTransformedBounds => Avalonia.Visual.TransformedBoundsProperty;
    public static StyledProperty<bool> VisualClipToBounds => Avalonia.Visual.ClipToBoundsProperty;
    public static StyledProperty<Geometry?> VisualClip => Avalonia.Visual.ClipProperty;
    public static StyledProperty<bool> VisualIsVisible => Avalonia.Visual.IsVisibleProperty;
    public static StyledProperty<double> VisualOpacity => Avalonia.Visual.OpacityProperty;
    public static StyledProperty<IBrush?> VisualOpacityMask => Avalonia.Visual.OpacityMaskProperty;
    public static StyledProperty<ITransform?> VisualRenderTransform => Avalonia.Visual.RenderTransformProperty;
    public static StyledProperty<RelativePoint> VisualRenderTransformOrigin => Avalonia.Visual.RenderTransformOriginProperty;
    public static DirectProperty<Visual, IVisual?> VisualVisualParent => Avalonia.Visual.VisualParentProperty;
    public static StyledProperty<int> VisualZIndex => Avalonia.Visual.ZIndexProperty;

    // Window

    public static StyledProperty<SizeToContent> WindowSizeToContent => Avalonia.Controls.Window.SizeToContentProperty;
    public static StyledProperty<bool> WindowExtendClientAreaToDecorationsHint => Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty;
    public static StyledProperty<ExtendClientAreaChromeHints> WindowExtendClientAreaChromeHints => Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty;
    public static StyledProperty<double> WindowExtendClientAreaTitleBarHeightHint => Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty;
    public static DirectProperty<Window, bool> WindowIsExtendedIntoWindowDecorations => Avalonia.Controls.Window.IsExtendedIntoWindowDecorationsProperty;
    public static DirectProperty<Window, Thickness> WindowWindowDecorationMargin => Avalonia.Controls.Window.WindowDecorationMarginProperty;
    public static DirectProperty<Window, Thickness> WindowOffScreenMargin => Avalonia.Controls.Window.OffScreenMarginProperty;
    public static StyledProperty<SystemDecorations> WindowSystemDecorations => Avalonia.Controls.Window.SystemDecorationsProperty;
    public static StyledProperty<bool> WindowShowActivated => Avalonia.Controls.Window.ShowActivatedProperty;
    public static StyledProperty<bool> WindowShowInTaskbar => Avalonia.Controls.Window.ShowInTaskbarProperty;
    public static StyledProperty<WindowState> WindowWindowState => Avalonia.Controls.Window.WindowStateProperty;
    public static StyledProperty<string> WindowTitle => Avalonia.Controls.Window.TitleProperty;
    public static StyledProperty<WindowIcon> WindowIcon => Avalonia.Controls.Window.IconProperty;
    public static DirectProperty<Window, WindowStartupLocation> WindowWindowStartupLocation => Avalonia.Controls.Window.WindowStartupLocationProperty;
    public static StyledProperty<bool> WindowCanResize => Avalonia.Controls.Window.CanResizeProperty;
    public static RoutedEvent WindowWindowClosed => Avalonia.Controls.Window.WindowClosedEvent;
    public static RoutedEvent WindowWindowOpened => Avalonia.Controls.Window.WindowOpenedEvent;


    // WrapPanel

    public static StyledProperty<Orientation> WrapPanelOrientation => Avalonia.Controls.WrapPanel.OrientationProperty;
    public static StyledProperty<double> WrapPanelItemWidth => Avalonia.Controls.WrapPanel.ItemWidthProperty;
    public static StyledProperty<double> WrapPanelItemHeight => Avalonia.Controls.WrapPanel.ItemHeightProperty;
}
