namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> ContentPresenterBackground => Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> ContentPresenterBorderBrush => Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty;

    public static Avalonia.StyledProperty<Avalonia.Thickness> ContentPresenterBorderThickness => Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty;

    public static Avalonia.StyledProperty<Avalonia.CornerRadius> ContentPresenterCornerRadius => Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.BoxShadows> ContentPresenterBoxShadow => Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.ContentPresenter,Avalonia.Controls.IControl> ContentPresenterChild => Avalonia.Controls.Presenters.ContentPresenter.ChildProperty;

    public static Avalonia.StyledProperty<System.Object> ContentPresenterContent => Avalonia.Controls.Presenters.ContentPresenter.ContentProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.Templates.IDataTemplate> ContentPresenterContentTemplate => Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.HorizontalAlignment> ContentPresenterHorizontalContentAlignment => Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.VerticalAlignment> ContentPresenterVerticalContentAlignment => Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty;

    public static Avalonia.StyledProperty<Avalonia.Thickness> ContentPresenterPadding => Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.ContentPresenter,System.Boolean> ContentPresenterRecognizesAccessKey => Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty;
}
