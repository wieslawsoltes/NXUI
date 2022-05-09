namespace MinimalAvalonia;

public static class AvaloniaObjectExtensions
{
    public static T BindOneWay<T>(
        this T target, 
        AvaloniaProperty targetProperty, 
        IAvaloniaObject source, 
        AvaloniaProperty sourceProperty, 
        CompositeDisposable? compositeDisposable = null) where T : IAvaloniaObject
    {
        var targetDisposable = target.Bind(targetProperty, source.GetObservable(sourceProperty));
        compositeDisposable?.Add(targetDisposable);
        return target;
    }

    public static T BindOneWay<T>(
        this T target, 
        AvaloniaProperty<T> targetProperty, 
        IObservable<BindingValue<T>> source, 
        CompositeDisposable? compositeDisposable = null) where T : IAvaloniaObject
    {
        var targetDisposable = target.Bind(targetProperty, source);
        compositeDisposable?.Add(targetDisposable);
        return target;
    }

    public static T BindTwoWay<T>(
        this T target,
        AvaloniaProperty targetProperty, 
        IAvaloniaObject source, 
        AvaloniaProperty sourceProperty, 
        CompositeDisposable? compositeDisposable = null) where T : IAvaloniaObject
    {
        var targetDisposable = target.Bind(targetProperty, source.GetObservable(sourceProperty));
        var sourceDisposable = source.Bind(sourceProperty, target.GetObservable(targetProperty));
        compositeDisposable?.Add(targetDisposable);
        compositeDisposable?.Add(sourceDisposable);
        return target;
    }
}
