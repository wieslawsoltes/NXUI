namespace MinimalAvalonia.Extensions;

public static partial class TextBlockExtensions
{
    // BackgroundProperty

    public static T Background<T>(this T textBlock, IBrush background) where T : TextBlock
    {
        textBlock[Avalonia.Controls.TextBlock.BackgroundProperty] = background;
        return textBlock;
    }

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

    // FontFamilyProperty

    public static T FontFamily<T>(this T control, FontFamily fontFamily) where T : Control
    {
        control[Avalonia.Controls.TextBlock.FontFamilyProperty] = fontFamily;
        return control;
    }

    // FontSizeProperty

    public static T FontSize<T>(this T control, double fontSize) where T : Control
    {
        control[Avalonia.Controls.TextBlock.FontSizeProperty] = fontSize;
        return control;
    }

    // FontStyleProperty

    public static T FontStyle<T>(this T control, FontStyle fontStyle) where T : Control
    {
        control[Avalonia.Controls.TextBlock.FontStyleProperty] = fontStyle;
        return control;
    }

    // FontWeightProperty

    public static T FontWeight<T>(this T control, FontWeight fontWeight) where T : Control
    {
        control[Avalonia.Controls.TextBlock.FontWeightProperty] = fontWeight;
        return control;
    }

    // ForegroundProperty

    public static T Foreground<T>(this T control, IBrush foreground) where T : Control
    {
        control[Avalonia.Controls.TextBlock.ForegroundProperty] = foreground;
        return control;
    }
}
