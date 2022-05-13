namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.ListBox,Avalonia.Controls.Primitives.IScrollable> ListBoxScroll => Avalonia.Controls.ListBox.ScrollProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.ItemVirtualizationMode> ListBoxVirtualizationMode => Avalonia.Controls.ListBox.VirtualizationModeProperty;
}
