namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> ScrollBarViewportSize => Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Primitives.ScrollBarVisibility> ScrollBarVisibility => Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.Orientation> ScrollBarOrientation => Avalonia.Controls.Primitives.ScrollBar.OrientationProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.ScrollBar,System.Boolean> ScrollBarIsExpanded => Avalonia.Controls.Primitives.ScrollBar.IsExpandedProperty;

    public static Avalonia.StyledProperty<System.Boolean> ScrollBarAllowAutoHide => Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty;

    public static Avalonia.StyledProperty<System.TimeSpan> ScrollBarHideDelay => Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty;

    public static Avalonia.StyledProperty<System.TimeSpan> ScrollBarShowDelay => Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty;
}
