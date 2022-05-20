namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.ScrollContentPresenter,System.Boolean> ScrollContentPresenterCanHorizontallyScroll => Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.ScrollContentPresenter,System.Boolean> ScrollContentPresenterCanVerticallyScroll => Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.ScrollContentPresenter,Avalonia.Size> ScrollContentPresenterExtent => Avalonia.Controls.Presenters.ScrollContentPresenter.ExtentProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.ScrollContentPresenter,Avalonia.Vector> ScrollContentPresenterOffset => Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.ScrollContentPresenter,Avalonia.Size> ScrollContentPresenterViewport => Avalonia.Controls.Presenters.ScrollContentPresenter.ViewportProperty;

    public static Avalonia.StyledProperty<System.Boolean> ScrollContentPresenterIsScrollChainingEnabled => Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty;
}
