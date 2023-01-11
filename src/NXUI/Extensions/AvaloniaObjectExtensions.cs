namespace NXUI.Extensions;

/// <summary>
/// 
/// </summary>
public static class AvaloniaObjectExtensions
{
    public static Builder<IBinding> ToBinding1<T>(this IObservable<T> source)
    {
        return new ()
        {
            Activator = () => Avalonia.AvaloniaObjectExtensions.ToBinding(source)
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="targetProperty"></param>
    /// <param name="source"></param>
    /// <param name="sourceProperty"></param>
    /// <param name="compositeDisposable"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BindOneWay<T>(
        this T target, 
        AvaloniaProperty targetProperty, 
        AvaloniaObject source, 
        AvaloniaProperty sourceProperty, 
        CompositeDisposable? compositeDisposable = null) where T : AvaloniaObject
    {
        var targetDisposable = target.Bind(targetProperty, source.GetObservable(sourceProperty));
        compositeDisposable?.Add(targetDisposable);
        return target;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="targetProperty"></param>
    /// <param name="source"></param>
    /// <param name="compositeDisposable"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BindOneWay<T>(
        this T target, 
        AvaloniaProperty<T> targetProperty, 
        IObservable<BindingValue<T>> source, 
        CompositeDisposable? compositeDisposable = null) where T : AvaloniaObject
    {
        var targetDisposable = target.Bind(targetProperty, source);
        compositeDisposable?.Add(targetDisposable);
        return target;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="targetProperty"></param>
    /// <param name="source"></param>
    /// <param name="compositeDisposable"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BindOneWay<T>(
        this T target, 
        AvaloniaProperty targetProperty, 
        IObservable<BindingValue<T>> source, 
        CompositeDisposable? compositeDisposable = null) where T : AvaloniaObject
    {
        var targetDisposable = target.Bind(targetProperty, source.ToBinding());
        compositeDisposable?.Add(targetDisposable);
        return target;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="targetProperty"></param>
    /// <param name="source"></param>
    /// <param name="compositeDisposable"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BindOneWay<T>(
        this T target, 
        AvaloniaProperty<T> targetProperty, 
        IObservable<object?> source, 
        CompositeDisposable? compositeDisposable = null) where T : AvaloniaObject
    {
        var targetDisposable = target.Bind(targetProperty, source);
        compositeDisposable?.Add(targetDisposable);
        return target;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="targetProperty"></param>
    /// <param name="source"></param>
    /// <param name="compositeDisposable"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BindOneWay<T>(
        this T target, 
        AvaloniaProperty targetProperty, 
        IObservable<object?> source, 
        CompositeDisposable? compositeDisposable = null) where T : AvaloniaObject
    {
        var targetDisposable = target.Bind(targetProperty, source);
        compositeDisposable?.Add(targetDisposable);
        return target;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="targetProperty"></param>
    /// <param name="source"></param>
    /// <param name="sourceProperty"></param>
    /// <param name="compositeDisposable"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BindTwoWay<T>(
        this T target,
        AvaloniaProperty targetProperty, 
        AvaloniaObject source, 
        AvaloniaProperty sourceProperty, 
        CompositeDisposable? compositeDisposable = null) where T : AvaloniaObject
    {
        var targetDisposable = target.Bind(targetProperty, source.GetObservable(sourceProperty));
        var sourceDisposable = source.Bind(sourceProperty, target.GetObservable(targetProperty));
        compositeDisposable?.Add(targetDisposable);
        compositeDisposable?.Add(sourceDisposable);
        return target;
    }
}
