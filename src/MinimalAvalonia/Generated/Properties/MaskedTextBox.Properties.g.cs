namespace MinimalAvalonia;

[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<System.Boolean> MaskedTextBoxAsciiOnly => Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.MaskedTextBox,System.Globalization.CultureInfo> MaskedTextBoxCulture => Avalonia.Controls.MaskedTextBox.CultureProperty;

    public static Avalonia.StyledProperty<System.Boolean> MaskedTextBoxHidePromptOnLeave => Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.MaskedTextBox,System.Nullable<System.Boolean>> MaskedTextBoxMaskCompleted => Avalonia.Controls.MaskedTextBox.MaskCompletedProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.MaskedTextBox,System.Nullable<System.Boolean>> MaskedTextBoxMaskFull => Avalonia.Controls.MaskedTextBox.MaskFullProperty;

    public static Avalonia.StyledProperty<System.String> MaskedTextBoxMask => Avalonia.Controls.MaskedTextBox.MaskProperty;

    public static Avalonia.StyledProperty<System.Char> MaskedTextBoxPromptChar => Avalonia.Controls.MaskedTextBox.PromptCharProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.MaskedTextBox,System.Boolean> MaskedTextBoxResetOnPrompt => Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty;

    public static Avalonia.DirectProperty<Avalonia.Controls.MaskedTextBox,System.Boolean> MaskedTextBoxResetOnSpace => Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty;
}
