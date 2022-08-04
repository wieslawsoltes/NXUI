namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> TextBlockBackground => Avalonia.Controls.TextBlock.BackgroundProperty;

    public static Avalonia.StyledProperty<Avalonia.Thickness> TextBlockPadding => Avalonia.Controls.TextBlock.PaddingProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.FontFamily> TextBlockFontFamily => Avalonia.Controls.TextBlock.FontFamilyProperty;

    public static Avalonia.StyledProperty<System.Double> TextBlockFontSize => Avalonia.Controls.TextBlock.FontSizeProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.FontStyle> TextBlockFontStyle => Avalonia.Controls.TextBlock.FontStyleProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.FontWeight> TextBlockFontWeight => Avalonia.Controls.TextBlock.FontWeightProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.FontStretch> TextBlockFontStretch => Avalonia.Controls.TextBlock.FontStretchProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> TextBlockForeground => Avalonia.Controls.TextBlock.ForegroundProperty;

    public static Avalonia.AttachedProperty<System.Double> TextBlockBaselineOffset => Avalonia.Controls.TextBlock.BaselineOffsetProperty;

    public static Avalonia.AttachedProperty<System.Double> TextBlockLineHeight => Avalonia.Controls.TextBlock.LineHeightProperty;

    public static Avalonia.AttachedProperty<System.Int32> TextBlockMaxLines => Avalonia.Controls.TextBlock.MaxLinesProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TextBlock,System.String> TextBlockText => Avalonia.Controls.TextBlock.TextProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.TextAlignment> TextBlockTextAlignment => Avalonia.Controls.TextBlock.TextAlignmentProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.TextWrapping> TextBlockTextWrapping => Avalonia.Controls.TextBlock.TextWrappingProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.TextTrimming> TextBlockTextTrimming => Avalonia.Controls.TextBlock.TextTrimmingProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.TextDecorationCollection> TextBlockTextDecorations => Avalonia.Controls.TextBlock.TextDecorationsProperty;
}
