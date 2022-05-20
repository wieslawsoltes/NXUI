namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Controls.Dock> TabItemTabStripPlacement => Avalonia.Controls.TabItem.TabStripPlacementProperty;

    public static Avalonia.StyledProperty<System.Boolean> TabItemIsSelected => Avalonia.Controls.TabItem.IsSelectedProperty;
}
