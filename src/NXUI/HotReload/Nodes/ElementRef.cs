#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Nodes;

using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using Avalonia;

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
}

internal sealed class ElementRefHost<TControl> : IElementAttachment
    where TControl : AvaloniaObject
{
    private readonly Dictionary<AvaloniaProperty, IPropertyRelay> _relays = new();
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

    private interface IPropertyRelay
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
}
#endif
