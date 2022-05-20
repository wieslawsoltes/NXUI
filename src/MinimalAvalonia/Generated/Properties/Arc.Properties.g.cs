namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> ArcStartAngle => Avalonia.Controls.Shapes.Arc.StartAngleProperty;

    public static Avalonia.StyledProperty<System.Double> ArcSweepAngle => Avalonia.Controls.Shapes.Arc.SweepAngleProperty;
}
