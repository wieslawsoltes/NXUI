namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.WrapPanel.OrientationProperty"/> property defined in <see cref="Avalonia.Controls.WrapPanel"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Layout.Orientation> WrapPanelOrientation => Avalonia.Controls.WrapPanel.OrientationProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.WrapPanel.ItemWidthProperty"/> property defined in <see cref="Avalonia.Controls.WrapPanel"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Double> WrapPanelItemWidth => Avalonia.Controls.WrapPanel.ItemWidthProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.WrapPanel.ItemHeightProperty"/> property defined in <see cref="Avalonia.Controls.WrapPanel"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Double> WrapPanelItemHeight => Avalonia.Controls.WrapPanel.ItemHeightProperty;
}
