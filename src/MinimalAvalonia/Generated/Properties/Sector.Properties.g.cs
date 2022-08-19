namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> SectorStartAngle => Avalonia.Controls.Shapes.Sector.StartAngleProperty;

    public static Avalonia.StyledProperty<System.Double> SectorSweepAngle => Avalonia.Controls.Shapes.Sector.SweepAngleProperty;
}
