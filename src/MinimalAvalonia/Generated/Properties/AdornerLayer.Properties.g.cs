namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.AttachedProperty<Avalonia.Visual> AdornerLayerAdornedElement => Avalonia.Controls.Primitives.AdornerLayer.AdornedElementProperty;

    public static Avalonia.AttachedProperty<System.Boolean> AdornerLayerIsClipEnabled => Avalonia.Controls.Primitives.AdornerLayer.IsClipEnabledProperty;

    public static Avalonia.AttachedProperty<Avalonia.Controls.Control> AdornerLayerAdorner => Avalonia.Controls.Primitives.AdornerLayer.AdornerProperty;
}
