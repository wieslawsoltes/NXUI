namespace NXUI.HotReload.Nodes;

using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using Avalonia;
using Avalonia.Data;
using Avalonia.Interactivity;

/// <summary>
/// Represents a lazily materialized control reference that survives hot reload rebuilds.
/// </summary>
/// <typeparam name="TControl">Control type.</typeparam>
public readonly struct ElementRef<TControl>
    where TControl : AvaloniaObject
{
    private readonly ElementRefHost<TControl>? _host;

    internal ElementRef(ElementRefHost<TControl> host)
    {
        _host = host;
    }

    /// <summary>
    /// Gets a value indicating whether the reference has been initialized.
    /// </summary>
    public bool IsInitialized => _host is not null;

    /// <summary>
    /// Observes the provided Avalonia property for the referenced control.
    /// </summary>
    public IObservable<TValue> Observe<TValue>(AvaloniaProperty<TValue> property)
    {
        if (_host is null)
        {
            throw new InvalidOperationException("ElementRef is not initialized.");
        }

        return _host.ObserveProperty(property);
    }

    /// <summary>
    /// Observes a routed event for the referenced control.
    /// </summary>
    public IObservable<TArgs> ObserveEvent<TArgs>(
        RoutedEvent<TArgs> routedEvent,
        RoutingStrategies routes = RoutingStrategies.Bubble)
        where TArgs : RoutedEventArgs
    {
        if (_host is null)
        {
            throw new InvalidOperationException("ElementRef is not initialized.");
        }

        return _host.ObserveEvent(routedEvent, routes);
    }

    /// <summary>
    /// Sets a property value on the referenced control.
    /// </summary>
    public ElementRef<TControl> SetValue<TValue>(AvaloniaProperty<TValue> property, TValue value)
    {
        if (_host is null)
        {
            throw new InvalidOperationException("ElementRef is not initialized.");
        }

        _host.SetValue(property, value);
        return this;
    }

    /// <summary>
    /// Assigns a binding to the referenced control.
    /// </summary>
    public ElementRef<TControl> SetBinding<TValue>(
        AvaloniaProperty<TValue> property,
        IBinding binding,
        BindingMode mode = BindingMode.TwoWay,
        BindingPriority priority = BindingPriority.LocalValue)
    {
        if (_host is null)
        {
            throw new InvalidOperationException("ElementRef is not initialized.");
        }

        _host.SetBinding(property, binding, mode, priority);
        return this;
    }

    /// <summary>
    /// Executes an action against the referenced control instance.
    /// </summary>
    public ElementRef<TControl> With(Action<TControl> action)
    {
        ArgumentNullException.ThrowIfNull(action);

        if (_host is null)
        {
            throw new InvalidOperationException("ElementRef is not initialized.");
        }

        _host.Invoke(action);
        return this;
    }
}

internal sealed class ElementRefHost<TControl> : IElementAttachment
    where TControl : AvaloniaObject
{
    private readonly Dictionary<AvaloniaProperty, IPropertyRelay> _relays = new();
    private readonly Dictionary<RoutedEvent, IEventRelay> _eventRelays = new();
    private AvaloniaObject? _currentInstance;

    public void OnAttached(ElementNode node)
    {
        ArgumentNullException.ThrowIfNull(node);
    }

    public void OnMaterialized(AvaloniaObject instance)
    {
        ArgumentNullException.ThrowIfNull(instance);
        _currentInstance = instance;

        foreach (var relay in _relays.Values)
        {
            relay.Connect(instance);
        }

        foreach (var eventRelay in _eventRelays.Values)
        {
            eventRelay.Connect(instance);
        }
    }

    public void SetValue<TValue>(AvaloniaProperty<TValue> property, TValue value)
    {
        ArgumentNullException.ThrowIfNull(property);

        if (_currentInstance is not AvaloniaObject instance)
        {
            throw new InvalidOperationException("ElementRef target is not materialized.");
        }

        instance.SetValue(property, value);
    }

    public void SetBinding<TValue>(
        AvaloniaProperty<TValue> property,
        IBinding binding,
        BindingMode mode,
        BindingPriority priority)
    {
        ArgumentNullException.ThrowIfNull(property);
        ArgumentNullException.ThrowIfNull(binding);

        if (_currentInstance is not AvaloniaObject instance)
        {
            throw new InvalidOperationException("ElementRef target is not materialized.");
        }

        var descriptor = property.Bind().WithMode(mode).WithPriority(priority);
        instance[descriptor] = binding;
    }

    public void Invoke(Action<TControl> action)
    {
        ArgumentNullException.ThrowIfNull(action);

        if (_currentInstance is not TControl instance)
        {
            throw new InvalidOperationException("ElementRef target is not materialized.");
        }

        action(instance);
    }

    public IObservable<TValue> ObserveProperty<TValue>(AvaloniaProperty<TValue> property)
    {
        ArgumentNullException.ThrowIfNull(property);

        if (!_relays.TryGetValue(property, out var relay))
        {
            var typedRelay = new ElementPropertyRelay<TValue>(property);
            _relays[property] = typedRelay;
            relay = typedRelay;

            if (_currentInstance is { })
            {
                typedRelay.Connect(_currentInstance);
            }
        }

        return ((ElementPropertyRelay<TValue>)relay).Observable;
    }

    public IObservable<TArgs> ObserveEvent<TArgs>(
        RoutedEvent<TArgs> routedEvent,
        RoutingStrategies routes)
        where TArgs : RoutedEventArgs
    {
        ArgumentNullException.ThrowIfNull(routedEvent);

        if (!_eventRelays.TryGetValue(routedEvent, out var relay))
        {
            var typedRelay = new RoutedEventRelay<TArgs>(routedEvent, routes);
            _eventRelays[routedEvent] = typedRelay;
            relay = typedRelay;

            if (_currentInstance is { })
            {
                typedRelay.Connect(_currentInstance);
            }
        }

        return ((RoutedEventRelay<TArgs>)relay).Observable;
    }

    private interface IPropertyRelay
    {
        void Connect(AvaloniaObject instance);
    }

    private interface IEventRelay
    {
        void Connect(AvaloniaObject instance);
    }

    private sealed class ElementPropertyRelay<TValue> : IPropertyRelay
    {
        private readonly AvaloniaProperty<TValue> _property;
        private readonly ReplaySubject<TValue> _subject = new(1);
        private IDisposable? _subscription;
        private AvaloniaObject? _instance;

        public ElementPropertyRelay(AvaloniaProperty<TValue> property)
        {
            _property = property ?? throw new ArgumentNullException(nameof(property));
        }

        public IObservable<TValue> Observable => _subject;

        public void Connect(AvaloniaObject instance)
        {
            if (ReferenceEquals(_instance, instance))
            {
                return;
            }

            _subscription?.Dispose();
            _instance = instance;
            _subject.OnNext(instance.GetValue<TValue>(_property));
            _subscription = instance.GetObservable(_property).Subscribe(value => _subject.OnNext(value));
        }
    }

    private sealed class RoutedEventRelay<TArgs> : IEventRelay
        where TArgs : RoutedEventArgs
    {
        private readonly RoutedEvent<TArgs> _event;
        private readonly RoutingStrategies _routes;
        private readonly ReplaySubject<TArgs> _subject = new(1);
        private AvaloniaObject? _instance;
        private IDisposable? _subscription;

        public RoutedEventRelay(RoutedEvent<TArgs> routedEvent, RoutingStrategies routes)
        {
            _event = routedEvent ?? throw new ArgumentNullException(nameof(routedEvent));
            _routes = routes;
        }

        public IObservable<TArgs> Observable => _subject;

        public void Connect(AvaloniaObject instance)
        {
            if (ReferenceEquals(_instance, instance))
            {
                return;
            }

            Detach();

            _instance = instance;
            if (instance is Interactive interactive)
            {
                _subscription = interactive
                    .GetObservable(_event, _routes)
                    .Subscribe(args => _subject.OnNext(args));
            }
        }

        private void Detach()
        {
            _subscription?.Dispose();
            _subscription = null;
            _instance = null;
        }
    }
}
