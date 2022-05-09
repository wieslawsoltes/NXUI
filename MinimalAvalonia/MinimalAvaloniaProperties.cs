using System.Diagnostics.CodeAnalysis;

namespace MinimalAvalonia;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class MinimalAvaloniaProperties
{
    public static readonly StyledProperty<object> ContentControlContent = Avalonia.Controls.ContentControl.ContentProperty;

    public static readonly StyledProperty<IBrush?> TemplatedControlBackground = Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty;

    public static readonly DirectProperty<TextBox, string> TextBoxText = Avalonia.Controls.TextBox.TextProperty;

    public static readonly DirectProperty<TextBlock, string> TextBlockText = Avalonia.Controls.TextBlock.TextProperty;

    public static readonly StyledProperty<string> WindowTitle = Avalonia.Controls.Window.TitleProperty;
}
