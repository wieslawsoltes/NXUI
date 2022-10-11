namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.DockPanel.DockProperty"/> property defined in <see cref="Avalonia.Controls.DockPanel"/> class.
    /// </summary>
    public static Avalonia.AttachedProperty<Avalonia.Controls.Dock> DockPanelDock => Avalonia.Controls.DockPanel.DockProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.DockPanel.LastChildFillProperty"/> property defined in <see cref="Avalonia.Controls.DockPanel"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> DockPanelLastChildFill => Avalonia.Controls.DockPanel.LastChildFillProperty;
}
