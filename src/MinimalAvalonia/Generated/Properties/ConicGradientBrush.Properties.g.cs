namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.RelativePoint> ConicGradientBrushCenter => Avalonia.Media.ConicGradientBrush.CenterProperty;

    public static Avalonia.StyledProperty<System.Double> ConicGradientBrushAngle => Avalonia.Media.ConicGradientBrush.AngleProperty;
}
