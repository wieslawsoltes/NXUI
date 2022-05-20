namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.RangeBase,System.Double> RangeBaseMinimum => Avalonia.Controls.Primitives.RangeBase.MinimumProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.RangeBase,System.Double> RangeBaseMaximum => Avalonia.Controls.Primitives.RangeBase.MaximumProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Primitives.RangeBase,System.Double> RangeBaseValue => Avalonia.Controls.Primitives.RangeBase.ValueProperty;

    public static Avalonia.StyledProperty<System.Double> RangeBaseSmallChange => Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty;

    public static Avalonia.StyledProperty<System.Double> RangeBaseLargeChange => Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty;
}
