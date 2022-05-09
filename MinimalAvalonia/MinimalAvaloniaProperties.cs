using System.Diagnostics.CodeAnalysis;

namespace MinimalAvalonia;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class MinimalAvaloniaProperties
{
    // Animation

    public static readonly DirectProperty<Animation, TimeSpan> AnimationDuration = Avalonia.Animation.Animation.DurationProperty;
    public static readonly DirectProperty<Animation, IterationCount> AnimationIterationCount = Avalonia.Animation.Animation.IterationCountProperty;
    public static readonly DirectProperty<Animation, PlaybackDirection> AnimationPlaybackDirection = Avalonia.Animation.Animation.PlaybackDirectionProperty;
    public static readonly DirectProperty<Animation, FillMode> AnimationFillMode = Avalonia.Animation.Animation.FillModeProperty;
    public static readonly DirectProperty<Animation, Easing> AnimationEasing = Avalonia.Animation.Animation.EasingProperty;
    public static readonly DirectProperty<Animation, TimeSpan> AnimationDelay = Avalonia.Animation.Animation.DelayProperty;
    public static readonly DirectProperty<Animation, TimeSpan> AnimationDelayBetweenIterations = Avalonia.Animation.Animation.DelayBetweenIterationsProperty;
    public static readonly DirectProperty<Animation, double> AnimationSpeedRatio = Avalonia.Animation.Animation.SpeedRatioProperty;

    // Border

    // Button

    // ContentControl

    public static readonly StyledProperty<object> ContentControlContent = Avalonia.Controls.ContentControl.ContentProperty;

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

    public static readonly StyledProperty<IBrush?> TemplatedControlBackground = Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty;

    // TextBlock

    public static readonly DirectProperty<TextBlock, string> TextBlockText = Avalonia.Controls.TextBlock.TextProperty;

    // TextBox

    public static readonly DirectProperty<TextBox, string> TextBoxText = Avalonia.Controls.TextBox.TextProperty;

    // Visual

    public static readonly StyledProperty<bool> VisualClipToBounds = Avalonia.Visual.ClipToBoundsProperty;

    // Window

    public static readonly StyledProperty<string> WindowTitle = Avalonia.Controls.Window.TitleProperty;
}
