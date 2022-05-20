namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Double> StackPanelSpacing => Avalonia.Controls.StackPanel.SpacingProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.Orientation> StackPanelOrientation => Avalonia.Controls.StackPanel.OrientationProperty;
}
