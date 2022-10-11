namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    /// <summary>
    /// The <see cref="Avalonia.Controls.TransitioningContentControl.PageTransitionProperty"/> property defined in <see cref="Avalonia.Controls.TransitioningContentControl"/> class.
    /// </summary>
    public static Avalonia.StyledProperty<Avalonia.Animation.IPageTransition> TransitioningContentControlPageTransition => Avalonia.Controls.TransitioningContentControl.PageTransitionProperty;

    /// <summary>
    /// The <see cref="Avalonia.Controls.TransitioningContentControl.CurrentContentProperty"/> property defined in <see cref="Avalonia.Controls.TransitioningContentControl"/> class.
    /// </summary>
    public static Avalonia.DirectProperty<Avalonia.Controls.TransitioningContentControl,System.Object> TransitioningContentControlCurrentContent => Avalonia.Controls.TransitioningContentControl.CurrentContentProperty;
}
