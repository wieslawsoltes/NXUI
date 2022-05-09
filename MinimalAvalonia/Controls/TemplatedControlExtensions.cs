namespace MinimalAvalonia.Controls;

public static class TemplatedControlExtensions
{
    public static T Padding<T>(this T templatedControl, double uniformLength) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty] = new Thickness(uniformLength);
        return templatedControl;
    }

    public static T Padding<T>(this T templatedControl, double horizontal, double vertical) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty] = new Thickness(horizontal, vertical);
        return templatedControl;
    }

    public static T Padding<T>(this T templatedControl, double left, double top, double right, double bottom) where T : TemplatedControl
    {
        templatedControl[Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty] = new Thickness(left, top, right, bottom);
        return templatedControl;
    }

    // TODO:
    // TemplateProperty
    // IsTemplateFocusTargetProperty
    // TemplateAppliedEvent
}
