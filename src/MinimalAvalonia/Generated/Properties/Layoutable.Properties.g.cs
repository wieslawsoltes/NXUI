namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Layout.Layoutable,Avalonia.Size> LayoutableDesiredSize => Avalonia.Layout.Layoutable.DesiredSizeProperty;

    public static Avalonia.StyledProperty<System.Double> LayoutableWidth => Avalonia.Layout.Layoutable.WidthProperty;

    public static Avalonia.StyledProperty<System.Double> LayoutableHeight => Avalonia.Layout.Layoutable.HeightProperty;

    public static Avalonia.StyledProperty<System.Double> LayoutableMinWidth => Avalonia.Layout.Layoutable.MinWidthProperty;

    public static Avalonia.StyledProperty<System.Double> LayoutableMaxWidth => Avalonia.Layout.Layoutable.MaxWidthProperty;

    public static Avalonia.StyledProperty<System.Double> LayoutableMinHeight => Avalonia.Layout.Layoutable.MinHeightProperty;

    public static Avalonia.StyledProperty<System.Double> LayoutableMaxHeight => Avalonia.Layout.Layoutable.MaxHeightProperty;

    public static Avalonia.StyledProperty<Avalonia.Thickness> LayoutableMargin => Avalonia.Layout.Layoutable.MarginProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.HorizontalAlignment> LayoutableHorizontalAlignment => Avalonia.Layout.Layoutable.HorizontalAlignmentProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.VerticalAlignment> LayoutableVerticalAlignment => Avalonia.Layout.Layoutable.VerticalAlignmentProperty;

    public static Avalonia.StyledProperty<System.Boolean> LayoutableUseLayoutRounding => Avalonia.Layout.Layoutable.UseLayoutRoundingProperty;
}
