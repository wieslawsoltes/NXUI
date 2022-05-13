namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> TextElementBackground => Avalonia.Controls.Documents.TextElement.BackgroundProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.FontFamily> TextElementFontFamily => Avalonia.Controls.Documents.TextElement.FontFamilyProperty;

    public static Avalonia.AttachedProperty<System.Double> TextElementFontSize => Avalonia.Controls.Documents.TextElement.FontSizeProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.FontStyle> TextElementFontStyle => Avalonia.Controls.Documents.TextElement.FontStyleProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.FontWeight> TextElementFontWeight => Avalonia.Controls.Documents.TextElement.FontWeightProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.FontStretch> TextElementFontStretch => Avalonia.Controls.Documents.TextElement.FontStretchProperty;

    public static Avalonia.AttachedProperty<Avalonia.Media.IBrush> TextElementForeground => Avalonia.Controls.Documents.TextElement.ForegroundProperty;
}
