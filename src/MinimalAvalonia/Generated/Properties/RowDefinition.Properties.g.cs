namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> RowDefinitionMaxHeight => Avalonia.Controls.RowDefinition.MaxHeightProperty;

    public static Avalonia.StyledProperty<System.Double> RowDefinitionMinHeight => Avalonia.Controls.RowDefinition.MinHeightProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.GridLength> RowDefinitionHeight => Avalonia.Controls.RowDefinition.HeightProperty;
}
