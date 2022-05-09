using System.Diagnostics.CodeAnalysis;

namespace MinimalAvalonia;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class MinimalAvaloniaProperties
{
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

    // Control

    // Decorator

    // Easing

    // HeaderedContentControl

    // ItemsControl

    // KeyFrame

    // Label

    // Layoutable

    // Panel

    // StackPanel

    // StyledElement

    // Style

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
}
