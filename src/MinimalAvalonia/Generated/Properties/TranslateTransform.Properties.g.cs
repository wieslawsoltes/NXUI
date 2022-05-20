namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> TranslateTransformX => Avalonia.Media.TranslateTransform.XProperty;

    public static Avalonia.StyledProperty<System.Double> TranslateTransformY => Avalonia.Media.TranslateTransform.YProperty;
}
