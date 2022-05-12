namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Animation.IPageTransition> TransitioningContentControlPageTransition => Avalonia.Controls.TransitioningContentControl.PageTransitionProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TransitioningContentControl,System.Object> TransitioningContentControlCurrentContent => Avalonia.Controls.TransitioningContentControl.CurrentContentProperty;
}
