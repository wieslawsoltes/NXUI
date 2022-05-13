namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> BrushOpacity => Avalonia.Media.Brush.OpacityProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.ITransform> BrushTransform => Avalonia.Media.Brush.TransformProperty;
}
