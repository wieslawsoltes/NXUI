namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.TextDecorationCollection> InlineTextDecorations => Avalonia.Controls.Documents.Inline.TextDecorationsProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.BaselineAlignment> InlineBaselineAlignment => Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty;
}
