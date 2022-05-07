namespace MinimalAvalonia.Controls;

public static class HeaderedContentControlExtensions
{
    public static T Header<T>(this T headeredContentControl, object? content) where T : HeaderedContentControl
    {
        headeredContentControl[HeaderedContentControl.HeaderProperty] = content;
        return headeredContentControl;
    }

    public static T HeaderTemplate<T>(this T headeredContentControl, IDataTemplate? dataTemplate) where T : HeaderedContentControl
    {
        headeredContentControl[HeaderedContentControl.HeaderTemplateProperty] = dataTemplate;
        return headeredContentControl;
    }
}
