namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.AttachedProperty<Avalonia.Controls.Dock> DockPanelDock => Avalonia.Controls.DockPanel.DockProperty;

    public static Avalonia.StyledProperty<System.Boolean> DockPanelLastChildFill => Avalonia.Controls.DockPanel.LastChildFillProperty;
}
