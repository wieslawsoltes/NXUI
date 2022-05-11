namespace MinimalAvalonia.Extensions;

public static partial class VisualExtensions
{
    public static T ClipToBounds<T>(this T visual, bool clipToBounds) where T : Visual
    {
        visual[Avalonia.Visual.ClipToBoundsProperty] = clipToBounds;
        return visual;
    }

    public static T Clip<T>(this T visual, Geometry? clip) where T : Visual
    {
        visual[Avalonia.Visual.ClipProperty] = clip;
        return visual;
    }

    public static T IsVisible<T>(this T visual, bool isVisible) where T : Visual
    {
        visual[Avalonia.Visual.IsVisibleProperty] = isVisible;
        return visual;
    }

    public static T Opacity<T>(this T visual, double opacity) where T : Visual
    {
        visual[Avalonia.Visual.OpacityProperty] = opacity;
        return visual;
    }

    public static T OpacityMask<T>(this T visual, IBrush? opacityMask) where T : Visual
    {
        visual[Avalonia.Visual.OpacityMaskProperty] = opacityMask;
        return visual;
    }

    public static T RenderTransform<T>(this T visual, ITransform? renderTransform) where T : Visual
    {
        visual[Avalonia.Visual.RenderTransformProperty] = renderTransform;
        return visual;
    }

    public static T RenderTransformOrigin<T>(this T visual, RelativePoint renderTransformOrigin) where T : Visual
    {
        visual[Avalonia.Visual.RenderTransformOriginProperty] = renderTransformOrigin;
        return visual;
    }

    public static T ZIndex<T>(this T visual, int zIndex) where T : Visual
    {
        visual[Avalonia.Visual.ZIndexProperty] = zIndex;
        return visual;
    }

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
