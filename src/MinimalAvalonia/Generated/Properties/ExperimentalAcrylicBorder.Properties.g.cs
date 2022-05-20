namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.CornerRadius> ExperimentalAcrylicBorderCornerRadius => Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.ExperimentalAcrylicMaterial> ExperimentalAcrylicBorderMaterial => Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty;
}
