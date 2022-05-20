namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> SplitViewTemplateSettingsClosedPaneWidth => Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.GridLength> SplitViewTemplateSettingsPaneColumnGridLength => Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty;
}
