namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Controls.Dock> TabControlTabStripPlacement => Avalonia.Controls.TabControl.TabStripPlacementProperty;

    public static Avalonia.StyledProperty<System.Object> TabControlSelectedContent => Avalonia.Controls.TabControl.SelectedContentProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> TabControlSelectedContentTemplate => Avalonia.Controls.TabControl.SelectedContentTemplateProperty;
}
