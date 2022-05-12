namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Boolean> PathFigureIsClosed => Avalonia.Media.PathFigure.IsClosedProperty;

    public static Avalonia.StyledProperty<System.Boolean> PathFigureIsFilled => Avalonia.Media.PathFigure.IsFilledProperty;

    public static Avalonia.DirectProperty<Avalonia.Media.PathFigure,Avalonia.Media.PathSegments> PathFigureSegments => Avalonia.Media.PathFigure.SegmentsProperty;

    public static Avalonia.StyledProperty<Avalonia.Point> PathFigureStartPoint => Avalonia.Media.PathFigure.StartPointProperty;
}
