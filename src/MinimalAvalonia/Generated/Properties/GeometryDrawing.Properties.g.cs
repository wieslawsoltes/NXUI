namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.Geometry> GeometryDrawingGeometry => Avalonia.Media.GeometryDrawing.GeometryProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> GeometryDrawingBrush => Avalonia.Media.GeometryDrawing.BrushProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.Pen> GeometryDrawingPen => Avalonia.Media.GeometryDrawing.PenProperty;
}
