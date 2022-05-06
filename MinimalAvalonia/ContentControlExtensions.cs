namespace MinimalAvalonia;

public static class ContentControlExtensions
{
    public static T Content<T>(this T contentControl, object content) where T : ContentControl
    {
        contentControl[ContentControl.ContentProperty] = content;
        return contentControl;
    }

    public static T Content<T>(this T contentControl, IBinding content, BindingMode bindingMode = BindingMode.OneWay)where T : ContentControl
    {
        switch (bindingMode)
        {
            case BindingMode.Default:
            case BindingMode.OneWay:
                contentControl[!ContentControl.ContentProperty] = content;
                break;
            case BindingMode.TwoWay:
                contentControl[!!ContentControl.ContentProperty] = content;
                break;
            case BindingMode.OneTime:
                // TODO:
                break;
            case BindingMode.OneWayToSource:
                // TODO:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(bindingMode), bindingMode, null);
        }
        return contentControl;
    }
    
    // TODO:
    // ContentTemplateProperty
    // HorizontalContentAlignmentProperty
    // VerticalContentAlignmentProperty
}
