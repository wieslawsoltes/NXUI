namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Themes.Fluent.FluentThemeMode> FluentThemeMode => Avalonia.Themes.Fluent.FluentTheme.ModeProperty;

    public static Avalonia.StyledProperty<Avalonia.Themes.Fluent.DensityStyle> FluentThemeDensityStyle => Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty;
}
