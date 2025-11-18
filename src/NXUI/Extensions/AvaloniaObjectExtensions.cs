namespace NXUI.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class AvaloniaObjectExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="targetProperty"></param>
    /// <param name="source"></param>
    /// <param name="sourceProperty"></param>
    /// <param name="targetDisposable"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BindOneWay<T>(
        this T target, 
        AvaloniaProperty targetProperty, 
        AvaloniaObject source, 
        AvaloniaProperty sourceProperty, 
        out IDisposable? targetDisposable) where T : AvaloniaObject
    {
        targetDisposable = target.Bind(targetProperty, source.GetObservable(sourceProperty));
        return target;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="targetProperty"></param>
    /// <param name="source"></param>
    /// <param name="targetDisposable"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BindOneWay<T>(
        this T target, 
        AvaloniaProperty<T> targetProperty, 
        IObservable<BindingValue<T>> source, 
        out IDisposable? targetDisposable) where T : AvaloniaObject
    {
        targetDisposable = target.Bind(targetProperty, source);
        return target;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="targetProperty"></param>
    /// <param name="source"></param>
    /// <param name="targetDisposable"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BindOneWay<T>(
        this T target, 
        AvaloniaProperty targetProperty, 
        IObservable<BindingValue<T>> source, 
        out IDisposable? targetDisposable) where T : AvaloniaObject
    {
        targetDisposable = target.Bind(targetProperty, source.ToBinding());
        return target;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="targetProperty"></param>
    /// <param name="source"></param>
    /// <param name="targetDisposable"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BindOneWay<T>(
        this T target, 
        AvaloniaProperty<T> targetProperty, 
        IObservable<object?> source, 
        out IDisposable? targetDisposable) where T : AvaloniaObject
    {
        targetDisposable = target.Bind(targetProperty, source);
        return target;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="targetProperty"></param>
    /// <param name="source"></param>
    /// <param name="targetDisposable"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BindOneWay<T>(
        this T target, 
        AvaloniaProperty targetProperty, 
        IObservable<object?> source, 
        out IDisposable? targetDisposable) where T : AvaloniaObject
    {
        targetDisposable = target.Bind(targetProperty, source);
        return target;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="target"></param>
    /// <param name="targetProperty"></param>
    /// <param name="source"></param>
    /// <param name="sourceProperty"></param>
    /// <param name="targetDisposable"></param>
    /// <param name="sourceDisposable"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T BindTwoWay<T>(
        this T target,
        AvaloniaProperty targetProperty, 
        AvaloniaObject source, 
        AvaloniaProperty sourceProperty, 
        out IDisposable? targetDisposable,
        out IDisposable? sourceDisposable) where T : AvaloniaObject
    {
        targetDisposable = target.Bind(targetProperty, source.GetObservable(sourceProperty));
        sourceDisposable = source.Bind(sourceProperty, target.GetObservable(targetProperty));
        return target;
    }
}
