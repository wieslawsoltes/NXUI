namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.AttachedProperty<System.Double> TextBlockBaselineOffset => Avalonia.Controls.TextBlock.BaselineOffsetProperty;

    public static Avalonia.AttachedProperty<System.Double> TextBlockLineHeight => Avalonia.Controls.TextBlock.LineHeightProperty;

    public static Avalonia.AttachedProperty<System.Int32> TextBlockMaxLines => Avalonia.Controls.TextBlock.MaxLinesProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TextBlock,System.String> TextBlockText => Avalonia.Controls.TextBlock.TextProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TextBlock,Avalonia.Controls.Documents.InlineCollection> TextBlockInlines => Avalonia.Controls.TextBlock.InlinesProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.TextAlignment> TextBlockTextAlignment => Avalonia.Controls.TextBlock.TextAlignmentProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.TextWrapping> TextBlockTextWrapping => Avalonia.Controls.TextBlock.TextWrappingProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.TextTrimming> TextBlockTextTrimming => Avalonia.Controls.TextBlock.TextTrimmingProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.TextDecorationCollection> TextBlockTextDecorations => Avalonia.Controls.TextBlock.TextDecorationsProperty;
}
