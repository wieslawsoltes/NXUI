namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Controls.Dock> TabControlTabStripPlacement => Avalonia.Controls.TabControl.TabStripPlacementProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.HorizontalAlignment> TabControlHorizontalContentAlignment => Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.VerticalAlignment> TabControlVerticalContentAlignment => Avalonia.Controls.TabControl.VerticalContentAlignmentProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> TabControlContentTemplate => Avalonia.Controls.TabControl.ContentTemplateProperty;

    public static Avalonia.StyledProperty<System.Object> TabControlSelectedContent => Avalonia.Controls.TabControl.SelectedContentProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> TabControlSelectedContentTemplate => Avalonia.Controls.TabControl.SelectedContentTemplateProperty;
}
