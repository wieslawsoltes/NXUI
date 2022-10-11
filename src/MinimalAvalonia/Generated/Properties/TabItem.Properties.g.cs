namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.TabItem.TabStripPlacementProperty"/> property defined in <see cref="Avalonia.Controls.TabItem"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.Dock> TabItemTabStripPlacement => Avalonia.Controls.TabItem.TabStripPlacementProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TabItem.IsSelectedProperty"/> property defined in <see cref="Avalonia.Controls.TabItem"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> TabItemIsSelected => Avalonia.Controls.TabItem.IsSelectedProperty;
}
