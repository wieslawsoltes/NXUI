namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Layout.UniformGridLayoutItemsJustification> UniformGridLayoutItemsJustification => Avalonia.Layout.UniformGridLayout.ItemsJustificationProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.UniformGridLayoutItemsStretch> UniformGridLayoutItemsStretch => Avalonia.Layout.UniformGridLayout.ItemsStretchProperty;

    public static Avalonia.StyledProperty<System.Double> UniformGridLayoutMinColumnSpacing => Avalonia.Layout.UniformGridLayout.MinColumnSpacingProperty;

    public static Avalonia.StyledProperty<System.Double> UniformGridLayoutMinItemHeight => Avalonia.Layout.UniformGridLayout.MinItemHeightProperty;

    public static Avalonia.StyledProperty<System.Double> UniformGridLayoutMinItemWidth => Avalonia.Layout.UniformGridLayout.MinItemWidthProperty;

    public static Avalonia.StyledProperty<System.Double> UniformGridLayoutMinRowSpacing => Avalonia.Layout.UniformGridLayout.MinRowSpacingProperty;

    public static Avalonia.StyledProperty<System.Int32> UniformGridLayoutMaximumRowsOrColumns => Avalonia.Layout.UniformGridLayout.MaximumRowsOrColumnsProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.Orientation> UniformGridLayoutOrientation => Avalonia.Layout.UniformGridLayout.OrientationProperty;
}
