namespace MinimalAvalonia.Extensions;

public static partial class VisualExtensions
{
    // AttachedToVisualTree

    public static Visual OnAttachedToVisualTree(this Visual visual, Action<IObservable<VisualTreeAttachmentEventArgs>> handler)
    {
        var observable = Observable
            .FromEventPattern<EventHandler<VisualTreeAttachmentEventArgs>, VisualTreeAttachmentEventArgs>(
                h => visual.AttachedToVisualTree += h, 
                h => visual.AttachedToVisualTree -= h)
            .Select(x => x.EventArgs);
        handler(observable);
        return visual;
    }

    public static IObservable<VisualTreeAttachmentEventArgs> OnAttachedToVisualTree(this Visual visual)
    {
        return Observable
            .FromEventPattern<EventHandler<VisualTreeAttachmentEventArgs>, VisualTreeAttachmentEventArgs>(
                h => visual.AttachedToVisualTree += h, 
                h => visual.AttachedToVisualTree -= h)
            .Select(x => x.EventArgs);
    }

    // DetachedFromVisualTree

    public static Visual OnDetachedFromVisualTree(this Visual visual, Action<IObservable<VisualTreeAttachmentEventArgs>> handler)
    {
        var observable = Observable
            .FromEventPattern<EventHandler<VisualTreeAttachmentEventArgs>, VisualTreeAttachmentEventArgs>(
                h => visual.DetachedFromVisualTree += h, 
                h => visual.DetachedFromVisualTree -= h)
            .Select(x => x.EventArgs);
        handler(observable);
        return visual;
    }

    public static IObservable<VisualTreeAttachmentEventArgs> OnDetachedFromVisualTree(this Visual visual)
    {
        return Observable
            .FromEventPattern<EventHandler<VisualTreeAttachmentEventArgs>, VisualTreeAttachmentEventArgs>(
                h => visual.DetachedFromVisualTree += h, 
                h => visual.DetachedFromVisualTree -= h)
            .Select(x => x.EventArgs);
    }
}
