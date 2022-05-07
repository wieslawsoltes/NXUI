namespace MinimalAvalonia.Controls;

public static class TextBlockExtensions
{
    public static T Background<T>(this T textBlock, IBrush background) where T : TextBlock
    {
        textBlock[TextBlock.BackgroundProperty] = background;
        return textBlock;
    }

    public static T Padding<T>(this T textBlock, double uniformLength) where T : TextBlock
    {
        textBlock[TextBlock.PaddingProperty] = new Thickness(uniformLength);
        return textBlock;
    }

    public static T Padding<T>(this T textBlock, double horizontal, double vertical) where T : TextBlock
    {
        textBlock[TextBlock.PaddingProperty] = new Thickness(horizontal, vertical);
        return textBlock;
    }

    public static T Padding<T>(this T textBlock, double left, double top, double right, double bottom) where T : TextBlock
    {
        textBlock[TextBlock.PaddingProperty] = new Thickness(left, top, right, bottom);
        return textBlock;
    }

    public static T FontFamily<T>(this T textBlock, FontFamily fontFamily) where T : TextBlock
    {
        textBlock[TextBlock.FontFamilyProperty] = fontFamily;
        return textBlock;
    }

    public static T FontSize<T>(this T textBlock, double fontSize) where T : TextBlock
    {
        textBlock[TextBlock.FontSizeProperty] = fontSize;
        return textBlock;
    }

    public static T FontStyle<T>(this T textBlock, FontStyle fontStyle) where T : TextBlock
    {
        textBlock[TextBlock.FontStyleProperty] = fontStyle;
        return textBlock;
    }

    public static T FontWeight<T>(this T textBlock, FontWeight fontWeight) where T : TextBlock
    {
        textBlock[TextBlock.FontWeightProperty] = fontWeight;
        return textBlock;
    }

    public static T Foreground<T>(this T textBlock, IBrush foreground) where T : TextBlock
    {
        textBlock[TextBlock.ForegroundProperty] = foreground;
        return textBlock;
    }

    public static T LineHeight<T>(this T textBlock, double lineHeight) where T : TextBlock
    {
        textBlock[TextBlock.LineHeightProperty] = lineHeight;
        return textBlock;
    }

    public static T MaxLines<T>(this T textBlock, int maxLines) where T : TextBlock
    {
        textBlock[TextBlock.MaxLinesProperty] = maxLines;
        return textBlock;
    }

    public static T Text<T>(this T textBlock, string text) where T : TextBlock
    {
        textBlock[TextBlock.TextProperty] = text;
        return textBlock;
    }

    public static T TextAlignment<T>(this T textBlock, TextAlignment textAlignment) where T : TextBlock
    {
        textBlock[TextBlock.TextAlignmentProperty] = textAlignment;
        return textBlock;
    }

    public static T TextWrapping<T>(this T textBlock, TextWrapping textWrapping) where T : TextBlock
    {
        textBlock[TextBlock.TextWrappingProperty] = textWrapping;
        return textBlock;
    }

    public static T TextTrimming<T>(this T textBlock, TextTrimming textTrimming) where T : TextBlock
    {
        textBlock[TextBlock.TextDecorationsProperty] = textTrimming;
        return textBlock;
    }

    public static T TextDecorations<T>(this T textBlock, TextDecorationCollection textDecorationCollection) where T : TextBlock
    {
        textBlock[TextBlock.TextDecorationsProperty] = textDecorationCollection;
        return textBlock;
    }
}
