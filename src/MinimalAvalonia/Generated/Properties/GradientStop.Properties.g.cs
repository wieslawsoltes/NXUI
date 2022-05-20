namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> GradientStopOffset => Avalonia.Media.GradientStop.OffsetProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.Color> GradientStopColor => Avalonia.Media.GradientStop.ColorProperty;
}
