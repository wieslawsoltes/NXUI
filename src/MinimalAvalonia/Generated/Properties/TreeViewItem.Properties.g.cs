namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.TreeViewItem.IsExpandedProperty"/> property defined in <see cref="Avalonia.Controls.TreeViewItem"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.TreeViewItem,System.Boolean> TreeViewItemIsExpanded => Avalonia.Controls.TreeViewItem.IsExpandedProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TreeViewItem.IsSelectedProperty"/> property defined in <see cref="Avalonia.Controls.TreeViewItem"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> TreeViewItemIsSelected => Avalonia.Controls.TreeViewItem.IsSelectedProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TreeViewItem.LevelProperty"/> property defined in <see cref="Avalonia.Controls.TreeViewItem"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.TreeViewItem,System.Int32> TreeViewItemLevel => Avalonia.Controls.TreeViewItem.LevelProperty;
}
