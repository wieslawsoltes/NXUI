namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Media.PolylineGeometry,Avalonia.Points> PolylineGeometryPoints => Avalonia.Media.PolylineGeometry.PointsProperty;

    public static Avalonia.StyledProperty<System.Boolean> PolylineGeometryIsFilled => Avalonia.Media.PolylineGeometry.IsFilledProperty;
}
