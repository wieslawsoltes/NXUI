using System.Diagnostics.CodeAnalysis;

namespace MinimalAvalonia;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class MinimalAvaloniaProperties
{
    // Animation

    // AnimationSetter

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
