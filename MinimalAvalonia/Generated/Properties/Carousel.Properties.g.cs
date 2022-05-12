namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Boolean> CarouselIsVirtualized => Avalonia.Controls.Carousel.IsVirtualizedProperty;

    public static Avalonia.StyledProperty<Avalonia.Animation.IPageTransition> CarouselPageTransition => Avalonia.Controls.Carousel.PageTransitionProperty;
}
