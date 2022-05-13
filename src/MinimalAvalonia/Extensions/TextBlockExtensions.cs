namespace MinimalAvalonia.Extensions;

public static partial class TextBlockExtensions
{
    // PaddingProperty

    public static T Padding<T>(this T textBlock, double uniformLength) where T : TextBlock
    {
        textBlock[Avalonia.Controls.TextBlock.PaddingProperty] = new Thickness(uniformLength);
        return textBlock;
    }

    public static T Padding<T>(this T textBlock, double horizontal, double vertical) where T : TextBlock
    {
        textBlock[Avalonia.Controls.TextBlock.PaddingProperty] = new Thickness(horizontal, vertical);
        return textBlock;
    }

    public static T Padding<T>(this T textBlock, double left, double top, double right, double bottom) where T : TextBlock
    {
        textBlock[Avalonia.Controls.TextBlock.PaddingProperty] = new Thickness(left, top, right, bottom);
        return textBlock;
    }
}
