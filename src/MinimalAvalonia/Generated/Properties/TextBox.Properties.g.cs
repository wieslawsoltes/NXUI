namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.DirectProperty<Avalonia.Controls.TextBox,System.Boolean> TextBoxCanCopy => Avalonia.Controls.TextBox.CanCopyProperty;

    public static Avalonia.StyledProperty<System.Boolean> TextBoxAcceptsReturn => Avalonia.Controls.TextBox.AcceptsReturnProperty;

    public static Avalonia.StyledProperty<System.Boolean> TextBoxAcceptsTab => Avalonia.Controls.TextBox.AcceptsTabProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TextBox,System.Int32> TextBoxCaretIndex => Avalonia.Controls.TextBox.CaretIndexProperty;

    public static Avalonia.StyledProperty<System.Boolean> TextBoxIsReadOnly => Avalonia.Controls.TextBox.IsReadOnlyProperty;

    public static Avalonia.StyledProperty<System.Char> TextBoxPasswordChar => Avalonia.Controls.TextBox.PasswordCharProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> TextBoxSelectionBrush => Avalonia.Controls.TextBox.SelectionBrushProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> TextBoxSelectionForegroundBrush => Avalonia.Controls.TextBox.SelectionForegroundBrushProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.IBrush> TextBoxCaretBrush => Avalonia.Controls.TextBox.CaretBrushProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TextBox,System.Int32> TextBoxSelectionStart => Avalonia.Controls.TextBox.SelectionStartProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TextBox,System.Int32> TextBoxSelectionEnd => Avalonia.Controls.TextBox.SelectionEndProperty;

    public static Avalonia.StyledProperty<System.Int32> TextBoxMaxLength => Avalonia.Controls.TextBox.MaxLengthProperty;

    public static Avalonia.StyledProperty<System.Int32> TextBoxMaxLines => Avalonia.Controls.TextBox.MaxLinesProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TextBox,System.String> TextBoxText => Avalonia.Controls.TextBox.TextProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.TextAlignment> TextBoxTextAlignment => Avalonia.Controls.TextBox.TextAlignmentProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.HorizontalAlignment> TextBoxHorizontalContentAlignment => Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty;

    public static Avalonia.StyledProperty<Avalonia.Layout.VerticalAlignment> TextBoxVerticalContentAlignment => Avalonia.Controls.TextBox.VerticalContentAlignmentProperty;

    public static Avalonia.StyledProperty<Avalonia.Media.TextWrapping> TextBoxTextWrapping => Avalonia.Controls.TextBox.TextWrappingProperty;

    public static Avalonia.StyledProperty<System.Double> TextBoxLineHeight => Avalonia.Controls.TextBox.LineHeightProperty;

    public static Avalonia.StyledProperty<System.String> TextBoxWatermark => Avalonia.Controls.TextBox.WatermarkProperty;

    public static Avalonia.StyledProperty<System.Boolean> TextBoxUseFloatingWatermark => Avalonia.Controls.TextBox.UseFloatingWatermarkProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TextBox,System.String> TextBoxNewLine => Avalonia.Controls.TextBox.NewLineProperty;

    public static Avalonia.StyledProperty<System.Object> TextBoxInnerLeftContent => Avalonia.Controls.TextBox.InnerLeftContentProperty;

    public static Avalonia.StyledProperty<System.Object> TextBoxInnerRightContent => Avalonia.Controls.TextBox.InnerRightContentProperty;

    public static Avalonia.StyledProperty<System.Boolean> TextBoxRevealPassword => Avalonia.Controls.TextBox.RevealPasswordProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TextBox,System.Boolean> TextBoxCanCut => Avalonia.Controls.TextBox.CanCutProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TextBox,System.Boolean> TextBoxCanPaste => Avalonia.Controls.TextBox.CanPasteProperty;

    public static Avalonia.StyledProperty<System.Boolean> TextBoxIsUndoEnabled => Avalonia.Controls.TextBox.IsUndoEnabledProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.TextBox,System.Int32> TextBoxUndoLimit => Avalonia.Controls.TextBox.UndoLimitProperty;

}
