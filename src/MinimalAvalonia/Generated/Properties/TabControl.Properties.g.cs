namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.TabControl.TabStripPlacementProperty"/> property defined in <see cref="Avalonia.Controls.TabControl"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.Dock> TabControlTabStripPlacement => Avalonia.Controls.TabControl.TabStripPlacementProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty"/> property defined in <see cref="Avalonia.Controls.TabControl"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Layout.HorizontalAlignment> TabControlHorizontalContentAlignment => Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TabControl.VerticalContentAlignmentProperty"/> property defined in <see cref="Avalonia.Controls.TabControl"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Layout.VerticalAlignment> TabControlVerticalContentAlignment => Avalonia.Controls.TabControl.VerticalContentAlignmentProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TabControl.ContentTemplateProperty"/> property defined in <see cref="Avalonia.Controls.TabControl"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> TabControlContentTemplate => Avalonia.Controls.TabControl.ContentTemplateProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TabControl.SelectedContentProperty"/> property defined in <see cref="Avalonia.Controls.TabControl"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Object> TabControlSelectedContent => Avalonia.Controls.TabControl.SelectedContentProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TabControl.SelectedContentTemplateProperty"/> property defined in <see cref="Avalonia.Controls.TabControl"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> TabControlSelectedContentTemplate => Avalonia.Controls.TabControl.SelectedContentTemplateProperty;
}
