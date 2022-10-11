namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Media.Brush.OpacityProperty"/> property defined in <see cref="Avalonia.Media.Brush"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Double> BrushOpacity => Avalonia.Media.Brush.OpacityProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.Brush.TransformProperty"/> property defined in <see cref="Avalonia.Media.Brush"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Media.ITransform> BrushTransform => Avalonia.Media.Brush.TransformProperty;

    /// <summary>
    /// The <see cref="Avalonia.Media.Brush.TransformOriginProperty"/> property defined in <see cref="Avalonia.Media.Brush"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.RelativePoint> BrushTransformOrigin => Avalonia.Media.Brush.TransformOriginProperty;
}
