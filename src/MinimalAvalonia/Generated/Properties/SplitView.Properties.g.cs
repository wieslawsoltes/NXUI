namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> SplitViewCompactPaneLength => Avalonia.Controls.SplitView.CompactPaneLengthProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.SplitViewDisplayMode> SplitViewDisplayMode => Avalonia.Controls.SplitView.DisplayModeProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.SplitView,System.Boolean> SplitViewIsPaneOpen => Avalonia.Controls.SplitView.IsPaneOpenProperty;

    public static Avalonia.StyledProperty<System.Double> SplitViewOpenPaneLength => Avalonia.Controls.SplitView.OpenPaneLengthProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> SplitViewPaneBackground => Avalonia.Controls.SplitView.PaneBackgroundProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.SplitViewPanePlacement> SplitViewPanePlacement => Avalonia.Controls.SplitView.PanePlacementProperty;

    public static Avalonia.StyledProperty<System.Object> SplitViewPane => Avalonia.Controls.SplitView.PaneProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> SplitViewPaneTemplate => Avalonia.Controls.SplitView.PaneTemplateProperty;

    public static Avalonia.StyledProperty<System.Boolean> SplitViewUseLightDismissOverlayMode => Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.SplitViewTemplateSettings> SplitViewTemplateSettings => Avalonia.Controls.SplitView.TemplateSettingsProperty;
}
