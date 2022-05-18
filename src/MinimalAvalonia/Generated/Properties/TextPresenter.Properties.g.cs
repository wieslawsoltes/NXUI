namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.TextPresenter,System.Int32> TextPresenterCaretIndex => Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty;

    public static Avalonia.StyledProperty<System.Boolean> TextPresenterRevealPassword => Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty;

    public static Avalonia.StyledProperty<System.Char> TextPresenterPasswordChar => Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.TextPresenter,System.Int32> TextPresenterSelectionStart => Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.TextPresenter,System.Int32> TextPresenterSelectionEnd => Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.Presenters.TextPresenter,System.String> TextPresenterText => Avalonia.Controls.Presenters.TextPresenter.TextProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.TextAlignment> TextPresenterTextAlignment => Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.TextWrapping> TextPresenterTextWrapping => Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> TextPresenterBackground => Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty;
}
