namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Layout.Orientation> WrapPanelOrientation => Avalonia.Controls.WrapPanel.OrientationProperty;

    public static Avalonia.StyledProperty<System.Double> WrapPanelItemWidth => Avalonia.Controls.WrapPanel.ItemWidthProperty;

    public static Avalonia.StyledProperty<System.Double> WrapPanelItemHeight => Avalonia.Controls.WrapPanel.ItemHeightProperty;
}
