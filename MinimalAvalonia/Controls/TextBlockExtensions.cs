namespace MinimalAvalonia.Controls;

public static class TextBlockExtensions
{
    public static T Text<T>(this T textBlock, string text) where T : TextBlock
    {
        textBlock[TextBlock.TextProperty] = text;
        return textBlock;
    }

    // TODO:
    // FontFamilyProperty
    // FontSizeProperty
    // FontStyleProperty
    // FontWeightProperty
    // ForegroundProperty
    // LineHeightProperty
    // MaxLinesProperty
    // TextAlignmentProperty
    // TextWrappingProperty
    // TextTrimmingProperty
    // TextDecorationsProperty
}
