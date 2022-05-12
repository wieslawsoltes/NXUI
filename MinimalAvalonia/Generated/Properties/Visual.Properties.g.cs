namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Visual,Avalonia.Rect> VisualBounds => Avalonia.Visual.BoundsProperty;

    public static Avalonia.DirectProperty<Avalonia.Visual,System.Nullable<Avalonia.VisualTree.TransformedBounds>> VisualTransformedBounds => Avalonia.Visual.TransformedBoundsProperty;

    public static Avalonia.StyledProperty<System.Boolean> VisualClipToBounds => Avalonia.Visual.ClipToBoundsProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.Geometry> VisualClip => Avalonia.Visual.ClipProperty;

    public static Avalonia.StyledProperty<System.Boolean> VisualIsVisible => Avalonia.Visual.IsVisibleProperty;

    public static Avalonia.StyledProperty<System.Double> VisualOpacity => Avalonia.Visual.OpacityProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> VisualOpacityMask => Avalonia.Visual.OpacityMaskProperty;

    public static Avalonia.DirectProperty<Avalonia.Visual,System.Boolean> VisualHasMirrorTransform => Avalonia.Visual.HasMirrorTransformProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.ITransform> VisualRenderTransform => Avalonia.Visual.RenderTransformProperty;

    public static Avalonia.StyledProperty<Avalonia.RelativePoint> VisualRenderTransformOrigin => Avalonia.Visual.RenderTransformOriginProperty;

    public static Avalonia.DirectProperty<Avalonia.Visual,Avalonia.VisualTree.IVisual> VisualVisualParent => Avalonia.Visual.VisualParentProperty;

    public static Avalonia.StyledProperty<System.Int32> VisualZIndex => Avalonia.Visual.ZIndexProperty;
}
