namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.Color> ExperimentalAcrylicMaterialTintColor => Avalonia.Media.ExperimentalAcrylicMaterial.TintColorProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.AcrylicBackgroundSource> ExperimentalAcrylicMaterialBackgroundSource => Avalonia.Media.ExperimentalAcrylicMaterial.BackgroundSourceProperty;

    public static Avalonia.StyledProperty<System.Double> ExperimentalAcrylicMaterialTintOpacity => Avalonia.Media.ExperimentalAcrylicMaterial.TintOpacityProperty;

    public static Avalonia.StyledProperty<System.Double> ExperimentalAcrylicMaterialMaterialOpacity => Avalonia.Media.ExperimentalAcrylicMaterial.MaterialOpacityProperty;

    public static Avalonia.StyledProperty<System.Double> ExperimentalAcrylicMaterialPlatformTransparencyCompensationLevel => Avalonia.Media.ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.Color> ExperimentalAcrylicMaterialFallbackColor => Avalonia.Media.ExperimentalAcrylicMaterial.FallbackColorProperty;
}
