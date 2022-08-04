namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Boolean> ProgressBarIsIndeterminate => Avalonia.Controls.ProgressBar.IsIndeterminateProperty;

    public static Avalonia.StyledProperty<System.Boolean> ProgressBarShowProgressText => Avalonia.Controls.ProgressBar.ShowProgressTextProperty;

    public static Avalonia.StyledProperty<System.String> ProgressBarProgressTextFormat => Avalonia.Controls.ProgressBar.ProgressTextFormatProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.Orientation> ProgressBarOrientation => Avalonia.Controls.ProgressBar.OrientationProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ProgressBar,System.Double> ProgressBarPercentage => Avalonia.Controls.ProgressBar.PercentageProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ProgressBar,System.Double> ProgressBarIndeterminateStartingOffset => Avalonia.Controls.ProgressBar.IndeterminateStartingOffsetProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.ProgressBar,System.Double> ProgressBarIndeterminateEndingOffset => Avalonia.Controls.ProgressBar.IndeterminateEndingOffsetProperty;
}
