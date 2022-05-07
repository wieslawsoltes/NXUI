namespace MinimalAvalonia.Controls;

public static class TextBoxExtensions
{
    public static T AcceptsReturn<T>(this T textBox, bool acceptsReturn) where T : TextBox
    {
        textBox[TextBox.AcceptsReturnProperty] = acceptsReturn;
        return textBox;
    }

    public static T AcceptsTab<T>(this T textBox, bool acceptsTab) where T : TextBox
    {
        textBox[TextBox.AcceptsTabProperty] = acceptsTab;
        return textBox;
    }

    public static T CaretIndex<T>(this T textBox, int caretIndex) where T : TextBox
    {
        textBox[TextBox.CaretIndexProperty] = caretIndex;
        return textBox;
    }

    public static T IsReadOnly<T>(this T textBox, bool isReadOnly) where T : TextBox
    {
        textBox[TextBox.IsReadOnlyProperty] = isReadOnly;
        return textBox;
    }

    public static T Text<T>(this T textBox, string text) where T : TextBox
    {
        textBox[TextBox.TextProperty] = text;
        return textBox;
    }

    // TODO:
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
