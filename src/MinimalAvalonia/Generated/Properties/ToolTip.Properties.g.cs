namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.AttachedProperty<System.Object> ToolTipTip => Avalonia.Controls.ToolTip.TipProperty;

    public static Avalonia.AttachedProperty<System.Boolean> ToolTipIsOpen => Avalonia.Controls.ToolTip.IsOpenProperty;

    public static Avalonia.AttachedProperty<Avalonia.Controls.PlacementMode> ToolTipPlacement => Avalonia.Controls.ToolTip.PlacementProperty;

    public static Avalonia.AttachedProperty<System.Double> ToolTipHorizontalOffset => Avalonia.Controls.ToolTip.HorizontalOffsetProperty;

    public static Avalonia.AttachedProperty<System.Double> ToolTipVerticalOffset => Avalonia.Controls.ToolTip.VerticalOffsetProperty;

    public static Avalonia.AttachedProperty<System.Int32> ToolTipShowDelay => Avalonia.Controls.ToolTip.ShowDelayProperty;
}
