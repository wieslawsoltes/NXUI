namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> TextBlockBackground => Avalonia.Controls.TextBlock.BackgroundProperty;

    public static Avalonia.StyledProperty<Avalonia.Thickness> TextBlockPadding => Avalonia.Controls.TextBlock.PaddingProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.FontFamily> TextBlockFontFamily => Avalonia.Controls.TextBlock.FontFamilyProperty;

    public static Avalonia.AttachedProperty<System.Double> TextBlockFontSize => Avalonia.Controls.TextBlock.FontSizeProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.FontStyle> TextBlockFontStyle => Avalonia.Controls.TextBlock.FontStyleProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.FontWeight> TextBlockFontWeight => Avalonia.Controls.TextBlock.FontWeightProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.IBrush> TextBlockForeground => Avalonia.Controls.TextBlock.ForegroundProperty;

    public static Avalonia.StyledProperty<System.Double> TextBlockLineHeight => Avalonia.Controls.TextBlock.LineHeightProperty;

    public static Avalonia.StyledProperty<System.Int32> TextBlockMaxLines => Avalonia.Controls.TextBlock.MaxLinesProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TextBlock,System.String> TextBlockText => Avalonia.Controls.TextBlock.TextProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.TextAlignment> TextBlockTextAlignment => Avalonia.Controls.TextBlock.TextAlignmentProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.TextWrapping> TextBlockTextWrapping => Avalonia.Controls.TextBlock.TextWrappingProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.TextTrimming> TextBlockTextTrimming => Avalonia.Controls.TextBlock.TextTrimmingProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.TextDecorationCollection> TextBlockTextDecorations => Avalonia.Controls.TextBlock.TextDecorationsProperty;
}
