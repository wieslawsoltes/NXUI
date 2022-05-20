namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.ComboBox,System.Boolean> ComboBoxIsDropDownOpen => Avalonia.Controls.ComboBox.IsDropDownOpenProperty;

    public static Avalonia.StyledProperty<System.Double> ComboBoxMaxDropDownHeight => Avalonia.Controls.ComboBox.MaxDropDownHeightProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ComboBox,System.Object> ComboBoxSelectionBoxItem => Avalonia.Controls.ComboBox.SelectionBoxItemProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.ItemVirtualizationMode> ComboBoxVirtualizationMode => Avalonia.Controls.ComboBox.VirtualizationModeProperty;

    public static Avalonia.StyledProperty<System.String> ComboBoxPlaceholderText => Avalonia.Controls.ComboBox.PlaceholderTextProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> ComboBoxPlaceholderForeground => Avalonia.Controls.ComboBox.PlaceholderForegroundProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.HorizontalAlignment> ComboBoxHorizontalContentAlignment => Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.VerticalAlignment> ComboBoxVerticalContentAlignment => Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty;
}
