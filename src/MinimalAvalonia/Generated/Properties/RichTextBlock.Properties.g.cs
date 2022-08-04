namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Boolean> RichTextBlockIsTextSelectionEnabled => Avalonia.Controls.RichTextBlock.IsTextSelectionEnabledProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.RichTextBlock,System.Int32> RichTextBlockSelectionStart => Avalonia.Controls.RichTextBlock.SelectionStartProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.RichTextBlock,System.Int32> RichTextBlockSelectionEnd => Avalonia.Controls.RichTextBlock.SelectionEndProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.RichTextBlock,System.String> RichTextBlockSelectedText => Avalonia.Controls.RichTextBlock.SelectedTextProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> RichTextBlockSelectionBrush => Avalonia.Controls.RichTextBlock.SelectionBrushProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Documents.InlineCollection> RichTextBlockInlines => Avalonia.Controls.RichTextBlock.InlinesProperty;
}
