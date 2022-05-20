namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.TreeViewItem,System.Boolean> TreeViewItemIsExpanded => Avalonia.Controls.TreeViewItem.IsExpandedProperty;

    public static Avalonia.StyledProperty<System.Boolean> TreeViewItemIsSelected => Avalonia.Controls.TreeViewItem.IsSelectedProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TreeViewItem,System.Int32> TreeViewItemLevel => Avalonia.Controls.TreeViewItem.LevelProperty;
}
