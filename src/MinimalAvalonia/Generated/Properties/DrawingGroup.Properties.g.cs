namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> DrawingGroupOpacity => Avalonia.Media.DrawingGroup.OpacityProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.Transform> DrawingGroupTransform => Avalonia.Media.DrawingGroup.TransformProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.Geometry> DrawingGroupClipGeometry => Avalonia.Media.DrawingGroup.ClipGeometryProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> DrawingGroupOpacityMask => Avalonia.Media.DrawingGroup.OpacityMaskProperty;
}
