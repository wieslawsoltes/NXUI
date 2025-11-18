namespace NXUI.Extensions;

using System;
using System.Reactive.Subjects;
using Avalonia.Interactivity;
using NXUI.HotReload.Nodes;

/// <summary>
/// Hot reload builder helpers that mirror the runtime event extensions.
/// </summary>
public static partial class InteractiveExtensionsEx
{
    /// <summary>
    /// Records a routed event handler attachment for builder-based interactives.
    /// </summary>
    public static ElementBuilder<TInteractive> AddDisposableHandler<TInteractive, TEventArgs>(
        this ElementBuilder<TInteractive> builder,
        RoutedEvent routedEvent,
        EventHandler<TEventArgs> handler,
        RoutingStrategies routes = RoutingStrategies.Direct | RoutingStrategies.Bubble,
        bool handledEventsToo = false)
        where TInteractive : Interactive
        where TEventArgs : RoutedEventArgs
    {
        ArgumentNullException.ThrowIfNull(routedEvent);
        ArgumentNullException.ThrowIfNull(handler);

        var attachment = new RoutedEventHandlerAttachment<TInteractive, TEventArgs>(
            routedEvent,
            handler,
            routes,
            handledEventsToo);

        builder.Node.RegisterAttachment(attachment);
        return builder;
    }

    /// <summary>
    /// Creates an observable for a routed event sourced from a builder-based interactive.
    /// </summary>
    public static IObservable<TEventArgs> GetObservable<TInteractive, TEventArgs>(
        this ElementBuilder<TInteractive> builder,
        RoutedEvent routedEvent,
        RoutingStrategies routes = RoutingStrategies.Direct | RoutingStrategies.Bubble,
        bool handledEventsToo = false)
        where TInteractive : Interactive
        where TEventArgs : RoutedEventArgs
    {
        ArgumentNullException.ThrowIfNull(routedEvent);

        var attachment = new RoutedEventObservableAttachment<TEventArgs>(
            routedEvent,
            routes,
            handledEventsToo);

        builder.Node.RegisterAttachment(attachment);
        return attachment.Observable;
    }

    private sealed class RoutedEventHandlerAttachment<TInteractive, TEventArgs> : IElementAttachment
        where TInteractive : Interactive
        where TEventArgs : RoutedEventArgs
    {
        private readonly RoutedEvent _routedEvent;
        private readonly EventHandler<TEventArgs> _handler;
        private readonly RoutingStrategies _routes;
        private readonly bool _handledEventsToo;
        private Interactive? _current;
        private IDisposable? _subscription;

        public RoutedEventHandlerAttachment(
            RoutedEvent routedEvent,
            EventHandler<TEventArgs> handler,
            RoutingStrategies routes,
            bool handledEventsToo)
        {
            _routedEvent = routedEvent ?? throw new ArgumentNullException(nameof(routedEvent));
            _handler = handler ?? throw new ArgumentNullException(nameof(handler));
            _routes = routes;
            _handledEventsToo = handledEventsToo;
        }

        public void OnAttached(ElementNode node)
        {
            ArgumentNullException.ThrowIfNull(node);
        }

        public void OnMaterialized(AvaloniaObject instance)
        {
            if (ReferenceEquals(_current, instance))
            {
                return;
            }

            Detach();

            if (instance is not TInteractive interactive)
            {
                return;
            }

            _current = interactive;
            _subscription = interactive.AddDisposableHandler(
                _routedEvent,
                _handler,
                _routes,
                _handledEventsToo);
        }

        private void Detach()
        {
            _subscription?.Dispose();
            _subscription = null;
            _current = null;
        }
    }

    private sealed class RoutedEventObservableAttachment<TEventArgs> : IElementAttachment
        where TEventArgs : RoutedEventArgs
    {
        private readonly RoutedEvent _routedEvent;
        private readonly RoutingStrategies _routes;
        private readonly bool _handledEventsToo;
        private readonly Subject<TEventArgs> _subject = new();
        private Interactive? _current;
        private IDisposable? _subscription;

        public RoutedEventObservableAttachment(
            RoutedEvent routedEvent,
            RoutingStrategies routes,
            bool handledEventsToo)
        {
            _routedEvent = routedEvent ?? throw new ArgumentNullException(nameof(routedEvent));
            _routes = routes;
            _handledEventsToo = handledEventsToo;
        }

        public IObservable<TEventArgs> Observable => _subject;

        public void OnAttached(ElementNode node)
        {
            ArgumentNullException.ThrowIfNull(node);
        }

        public void OnMaterialized(AvaloniaObject instance)
        {
            if (ReferenceEquals(_current, instance))
            {
                return;
            }

            Detach();

            if (instance is not Interactive interactive)
            {
                return;
            }

            _current = interactive;
            _subscription = interactive
                .GetObservable<TEventArgs>(_routedEvent, _routes, _handledEventsToo)
                .Subscribe(_subject);
        }

        private void Detach()
        {
            _subscription?.Dispose();
            _subscription = null;
            _current = null;
        }
    }
}
