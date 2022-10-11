namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.ProgressBar.IsIndeterminateProperty"/> property defined in <see cref="Avalonia.Controls.ProgressBar"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> ProgressBarIsIndeterminate => Avalonia.Controls.ProgressBar.IsIndeterminateProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.ProgressBar.ShowProgressTextProperty"/> property defined in <see cref="Avalonia.Controls.ProgressBar"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.Boolean> ProgressBarShowProgressText => Avalonia.Controls.ProgressBar.ShowProgressTextProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.ProgressBar.ProgressTextFormatProperty"/> property defined in <see cref="Avalonia.Controls.ProgressBar"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<System.String> ProgressBarProgressTextFormat => Avalonia.Controls.ProgressBar.ProgressTextFormatProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/> property defined in <see cref="Avalonia.Controls.ProgressBar"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Layout.Orientation> ProgressBarOrientation => Avalonia.Controls.ProgressBar.OrientationProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.ProgressBar.PercentageProperty"/> property defined in <see cref="Avalonia.Controls.ProgressBar"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.ProgressBar,System.Double> ProgressBarPercentage => Avalonia.Controls.ProgressBar.PercentageProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.ProgressBar.IndeterminateStartingOffsetProperty"/> property defined in <see cref="Avalonia.Controls.ProgressBar"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.ProgressBar,System.Double> ProgressBarIndeterminateStartingOffset => Avalonia.Controls.ProgressBar.IndeterminateStartingOffsetProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.ProgressBar.IndeterminateEndingOffsetProperty"/> property defined in <see cref="Avalonia.Controls.ProgressBar"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.ProgressBar,System.Double> ProgressBarIndeterminateEndingOffset => Avalonia.Controls.ProgressBar.IndeterminateEndingOffsetProperty;
}
