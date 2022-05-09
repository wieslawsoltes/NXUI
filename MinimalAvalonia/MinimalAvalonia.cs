using System.Diagnostics.CodeAnalysis;

namespace MinimalAvalonia;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class MinimalAvalonia
{
    public static readonly StyledProperty<object> ContentControlContent = Avalonia.Controls.ContentControl.ContentProperty;

    public static readonly StyledProperty<IBrush?> TemplatedControlBackground = Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty;

    public static readonly DirectProperty<TextBox, string> TextBoxText = Avalonia.Controls.TextBox.TextProperty;

    public static readonly DirectProperty<TextBlock, string> TextBlockText = Avalonia.Controls.TextBlock.TextProperty;

    public static readonly StyledProperty<string> WindowTitle = Avalonia.Controls.Window.TitleProperty;

    public static Animation Animation() => new();

    public static Border Border() => new();

    public static Button Button() => new();

    public static ContentControl ContentControl() => new();

    public static Control Control() => new();

    public static Decorator Decorator() => new();

    public static HeaderedContentControl HeaderedContentControl() => new();

    public static ItemsControl ItemsControl() => new();

    public static KeyFrame KeyFrame() => new();

    public static Label Label() => new();

    public static Layoutable Layoutable() => new();

    public static Panel Panel() => new();

    public static StackPanel StackPanel() => new();

    public static StyledElement StyledElement() => new();

    public static Style Style() => new();

    public static Setter Setter() => new();

    public static TabControl TabControl() => new();

    public static TabItem TabItem() => new();

    public static TemplatedControl TemplatedControl() => new();

    public static TextBlock TextBlock() => new();

    public static TextBox TextBox() => new();

    public static Window Window() => new();
}
