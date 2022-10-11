namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.ListBox.ScrollProperty"/> property defined in <see cref="Avalonia.Controls.ListBox"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.ListBox,Avalonia.Controls.Primitives.IScrollable> ListBoxScroll => Avalonia.Controls.ListBox.ScrollProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.ListBox.VirtualizationModeProperty"/> property defined in <see cref="Avalonia.Controls.ListBox"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.ItemVirtualizationMode> ListBoxVirtualizationMode => Avalonia.Controls.ListBox.VirtualizationModeProperty;
}
