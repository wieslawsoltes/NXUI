namespace MinimalAvalonia.Extensions;

public static partial class HeaderedContentControlExtensions
{
    public static T Header<T>(this T headeredContentControl, object? content) where T : HeaderedContentControl
    {
        headeredContentControl[Avalonia.Controls.Primitives.HeaderedContentControl.HeaderProperty] = content;
        return headeredContentControl;
    }

    public static T HeaderTemplate<T>(this T headeredContentControl, IDataTemplate? dataTemplate) where T : HeaderedContentControl
    {
        headeredContentControl[Avalonia.Controls.Primitives.HeaderedContentControl.HeaderTemplateProperty] = dataTemplate;
        return headeredContentControl;
    }
}
