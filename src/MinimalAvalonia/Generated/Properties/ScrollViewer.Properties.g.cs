namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,System.Boolean> ScrollViewerCanHorizontallyScroll => Avalonia.Controls.ScrollViewer.CanHorizontallyScrollProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,System.Boolean> ScrollViewerCanVerticallyScroll => Avalonia.Controls.ScrollViewer.CanVerticallyScrollProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,Avalonia.Size> ScrollViewerExtent => Avalonia.Controls.ScrollViewer.ExtentProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,Avalonia.Vector> ScrollViewerOffset => Avalonia.Controls.ScrollViewer.OffsetProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,Avalonia.Size> ScrollViewerViewport => Avalonia.Controls.ScrollViewer.ViewportProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,Avalonia.Size> ScrollViewerLargeChange => Avalonia.Controls.ScrollViewer.LargeChangeProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,Avalonia.Size> ScrollViewerSmallChange => Avalonia.Controls.ScrollViewer.SmallChangeProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,System.Double> ScrollViewerHorizontalScrollBarMaximum => Avalonia.Controls.ScrollViewer.HorizontalScrollBarMaximumProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,System.Double> ScrollViewerHorizontalScrollBarValue => Avalonia.Controls.ScrollViewer.HorizontalScrollBarValueProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,System.Double> ScrollViewerHorizontalScrollBarViewportSize => Avalonia.Controls.ScrollViewer.HorizontalScrollBarViewportSizeProperty;

    public static Avalonia.AttachedProperty<Avalonia.Controls.Primitives.ScrollBarVisibility> ScrollViewerHorizontalScrollBarVisibility => Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,System.Double> ScrollViewerVerticalScrollBarMaximum => Avalonia.Controls.ScrollViewer.VerticalScrollBarMaximumProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,System.Double> ScrollViewerVerticalScrollBarValue => Avalonia.Controls.ScrollViewer.VerticalScrollBarValueProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,System.Double> ScrollViewerVerticalScrollBarViewportSize => Avalonia.Controls.ScrollViewer.VerticalScrollBarViewportSizeProperty;

    public static Avalonia.AttachedProperty<Avalonia.Controls.Primitives.ScrollBarVisibility> ScrollViewerVerticalScrollBarVisibility => Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ScrollViewer,System.Boolean> ScrollViewerIsExpanded => Avalonia.Controls.ScrollViewer.IsExpandedProperty;

    public static Avalonia.AttachedProperty<System.Boolean> ScrollViewerAllowAutoHide => Avalonia.Controls.ScrollViewer.AllowAutoHideProperty;

    public static Avalonia.AttachedProperty<System.Boolean> ScrollViewerIsScrollChainingEnabled => Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty;
}
