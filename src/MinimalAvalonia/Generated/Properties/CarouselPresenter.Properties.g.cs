namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Boolean> CarouselPresenterIsVirtualized => Avalonia.Controls.Presenters.CarouselPresenter.IsVirtualizedProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.CarouselPresenter,System.Int32> CarouselPresenterSelectedIndex => Avalonia.Controls.Presenters.CarouselPresenter.SelectedIndexProperty;

    public static Avalonia.StyledProperty<Avalonia.Animation.IPageTransition> CarouselPresenterPageTransition => Avalonia.Controls.Presenters.CarouselPresenter.PageTransitionProperty;
}
