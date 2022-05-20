namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.RelativePoint> RadialGradientBrushCenter => Avalonia.Media.RadialGradientBrush.CenterProperty;

    public static Avalonia.StyledProperty<Avalonia.RelativePoint> RadialGradientBrushGradientOrigin => Avalonia.Media.RadialGradientBrush.GradientOriginProperty;

    public static Avalonia.StyledProperty<System.Double> RadialGradientBrushRadius => Avalonia.Media.RadialGradientBrush.RadiusProperty;
}
