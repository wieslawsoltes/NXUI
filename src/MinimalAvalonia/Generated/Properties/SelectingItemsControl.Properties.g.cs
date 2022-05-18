namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Boolean> SelectingItemsControlAutoScrollToSelectedItem => Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.SelectingItemsControl,System.Int32> SelectingItemsControlSelectedIndex => Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.SelectingItemsControl,System.Object> SelectingItemsControlSelectedItem => Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty;
}
