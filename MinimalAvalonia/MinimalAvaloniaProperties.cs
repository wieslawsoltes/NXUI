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

    // Button

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
