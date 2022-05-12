namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Media.PathGeometry,Avalonia.Media.PathFigures> PathGeometryFigures => Avalonia.Media.PathGeometry.FiguresProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.FillRule> PathGeometryFillRule => Avalonia.Media.PathGeometry.FillRuleProperty;
}
