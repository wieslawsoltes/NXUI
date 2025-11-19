namespace NXUI.Extensions;

/// <summary>
/// 
/// </summary>
public static partial class InteractiveExtensionsEx
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="o"></param>
    /// <param name="routedEvent"></param>
    /// <param name="handler"></param>
    /// <param name="routes"></param>
    /// <param name="handledEventsToo"></param>
    /// <typeparam name="TEventArgs"></typeparam>
    /// <returns></returns>
    public static IDisposable AddDisposableHandler<TEventArgs>(this Interactive o, RoutedEvent routedEvent,
        EventHandler<TEventArgs> handler,
        RoutingStrategies routes = RoutingStrategies.Direct | RoutingStrategies.Bubble,
        bool handledEventsToo = false) where TEventArgs : RoutedEventArgs
    {
        o.AddHandler(routedEvent, handler, routes, handledEventsToo);

        return Disposable.Create(
            (instance: o, handler, routedEvent),
            state => state.instance.RemoveHandler(state.routedEvent, state.handler));
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="o"></param>
    /// <param name="routedEvent"></param>
    /// <param name="routes"></param>
    /// <param name="handledEventsToo"></param>
    /// <typeparam name="TEventArgs"></typeparam>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static IObservable<TEventArgs> GetObservable<TEventArgs>(
        this Interactive o,
        RoutedEvent routedEvent,
        RoutingStrategies routes = RoutingStrategies.Direct | RoutingStrategies.Bubble,
        bool handledEventsToo = false)
        where TEventArgs : RoutedEventArgs
    {
        o = o ?? throw new ArgumentNullException(nameof(o));
        routedEvent = routedEvent ?? throw new ArgumentNullException(nameof(routedEvent));

        return Observable.Create<TEventArgs>(x => o.AddDisposableHandler<TEventArgs>(
            routedEvent, 
            (_, e) => x.OnNext(e), 
            routes,
            handledEventsToo));
    }
}
