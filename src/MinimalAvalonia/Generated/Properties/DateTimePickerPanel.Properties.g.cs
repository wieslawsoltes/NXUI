namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> DateTimePickerPanelItemHeight => Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Primitives.DateTimePickerPanelType> DateTimePickerPanelPanelType => Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty;

    public static Avalonia.StyledProperty<System.String> DateTimePickerPanelItemFormat => Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty;

    public static Avalonia.StyledProperty<System.Boolean> DateTimePickerPanelShouldLoop => Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty;
}
