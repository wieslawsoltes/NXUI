namespace MinimalAvalonia.Extensions;

public static partial class TextBlockExtensions
{
    // PaddingProperty

    /// <summary>
    /// 
    /// </summary>
    /// <param name="textBlock"></param>
    /// <param name="uniformLength"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Padding<T>(this T textBlock, double uniformLength) where T : TextBlock
    {
        textBlock[Avalonia.Controls.TextBlock.PaddingProperty] = new Thickness(uniformLength);
        return textBlock;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="textBlock"></param>
    /// <param name="horizontal"></param>
    /// <param name="vertical"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Padding<T>(this T textBlock, double horizontal, double vertical) where T : TextBlock
    {
        textBlock[Avalonia.Controls.TextBlock.PaddingProperty] = new Thickness(horizontal, vertical);
        return textBlock;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="textBlock"></param>
    /// <param name="left"></param>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Padding<T>(this T textBlock, double left, double top, double right, double bottom) where T : TextBlock
    {
        textBlock[Avalonia.Controls.TextBlock.PaddingProperty] = new Thickness(left, top, right, bottom);
        return textBlock;
    }
}
