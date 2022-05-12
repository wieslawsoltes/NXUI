namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.ContentPresenter,Avalonia.Controls.IControl> ContentPresenterChild => Avalonia.Controls.Presenters.ContentPresenter.ChildProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.ContentPresenter,System.Boolean> ContentPresenterRecognizesAccessKey => Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty;
}
