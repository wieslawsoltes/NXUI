namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.AttachedProperty<System.Double> CanvasLeft => Avalonia.Controls.Canvas.LeftProperty;

    public static Avalonia.AttachedProperty<System.Double> CanvasTop => Avalonia.Controls.Canvas.TopProperty;

    public static Avalonia.AttachedProperty<System.Double> CanvasRight => Avalonia.Controls.Canvas.RightProperty;

    public static Avalonia.AttachedProperty<System.Double> CanvasBottom => Avalonia.Controls.Canvas.BottomProperty;
}
