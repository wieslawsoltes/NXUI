namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Boolean> TreeViewAutoScrollToSelectedItem => Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TreeView,System.Object> TreeViewSelectedItem => Avalonia.Controls.TreeView.SelectedItemProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TreeView,System.Collections.IList> TreeViewSelectedItems => Avalonia.Controls.TreeView.SelectedItemsProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.SelectionMode> TreeViewSelectionMode => Avalonia.Controls.TreeView.SelectionModeProperty;
}
