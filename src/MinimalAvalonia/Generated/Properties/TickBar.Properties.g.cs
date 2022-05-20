namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> TickBarFill => Avalonia.Controls.TickBar.FillProperty;

    public static Avalonia.StyledProperty<System.Double> TickBarMinimum => Avalonia.Controls.TickBar.MinimumProperty;

    public static Avalonia.StyledProperty<System.Double> TickBarMaximum => Avalonia.Controls.TickBar.MaximumProperty;

    public static Avalonia.StyledProperty<System.Double> TickBarTickFrequency => Avalonia.Controls.TickBar.TickFrequencyProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.Orientation> TickBarOrientation => Avalonia.Controls.TickBar.OrientationProperty;

    public static Avalonia.StyledProperty<Avalonia.Collections.AvaloniaList<System.Double>> TickBarTicks => Avalonia.Controls.TickBar.TicksProperty;

    public static Avalonia.StyledProperty<System.Boolean> TickBarIsDirectionReversed => Avalonia.Controls.TickBar.IsDirectionReversedProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.TickBarPlacement> TickBarPlacement => Avalonia.Controls.TickBar.PlacementProperty;

    public static Avalonia.StyledProperty<Avalonia.Rect> TickBarReservedSpace => Avalonia.Controls.TickBar.ReservedSpaceProperty;
}
