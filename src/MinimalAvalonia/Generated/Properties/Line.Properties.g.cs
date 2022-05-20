namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Point> LineStartPoint => Avalonia.Controls.Shapes.Line.StartPointProperty;

    public static Avalonia.StyledProperty<Avalonia.Point> LineEndPoint => Avalonia.Controls.Shapes.Line.EndPointProperty;
}
