namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> RectangleRadiusX => Avalonia.Controls.Shapes.Rectangle.RadiusXProperty;

    public static Avalonia.StyledProperty<System.Double> RectangleRadiusY => Avalonia.Controls.Shapes.Rectangle.RadiusYProperty;
}
