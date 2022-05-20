namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.RelativePoint> LinearGradientBrushStartPoint => Avalonia.Media.LinearGradientBrush.StartPointProperty;

    public static Avalonia.StyledProperty<Avalonia.RelativePoint> LinearGradientBrushEndPoint => Avalonia.Media.LinearGradientBrush.EndPointProperty;
}
