namespace MinimalAvalonia.Controls;

public static class TextBoxExtensions
{
    public static T Text<T>(this T textBox, string text) where T : TextBox
    {
        textBox[TextBox.TextProperty] = text;
        return textBox;
    }

    // TODO:
    // AcceptsReturnProperty
    // AcceptsTabProperty
    // CaretIndexProperty
    // IsReadOnlyProperty
    // PasswordCharProperty
    // SelectionBrushProperty
    // SelectionForegroundBrushProperty
    // CaretBrushProperty
    // SelectionStartProperty
    // SelectionEndProperty
    // MaxLengthProperty
    // WatermarkProperty
    // UseFloatingWatermarkProperty
    // NewLineProperty
    // InnerLeftContentProperty
    // InnerRightContentProperty
    // RevealPasswordProperty
    // CopyingToClipboardEvent
    // CuttingToClipboardEvent
    // PastingFromClipboardEvent
}
