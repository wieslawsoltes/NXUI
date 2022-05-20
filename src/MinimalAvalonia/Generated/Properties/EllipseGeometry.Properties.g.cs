namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Rect> EllipseGeometryRect => Avalonia.Media.EllipseGeometry.RectProperty;

    public static Avalonia.StyledProperty<System.Double> EllipseGeometryRadiusX => Avalonia.Media.EllipseGeometry.RadiusXProperty;

    public static Avalonia.StyledProperty<System.Double> EllipseGeometryRadiusY => Avalonia.Media.EllipseGeometry.RadiusYProperty;

    public static Avalonia.StyledProperty<Avalonia.Point> EllipseGeometryCenter => Avalonia.Media.EllipseGeometry.CenterProperty;
}
