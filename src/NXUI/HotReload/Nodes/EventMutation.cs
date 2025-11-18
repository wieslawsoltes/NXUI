#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Nodes;

using System;
using System.Runtime.CompilerServices;
using System.Reflection;
using Avalonia;

/// <summary>
/// Records an event subscription that should be attached when a node is materialized.
/// </summary>
public sealed class EventMutation
{
    private readonly Action<AvaloniaObject>? _attach;
    private readonly Action<AvaloniaObject>? _detach;
    private readonly Func<AvaloniaObject, Action?>? _attachWithScopedDetach;
    private readonly ConditionalWeakTable<AvaloniaObject, Action>? _detachLookup;
    private readonly EventFingerprint _fingerprint;

    /// <summary>
    /// Initializes a new instance of the <see cref="EventMutation"/> class.
    /// </summary>
    /// <param name="attach">Delegate that attaches the event handler to the instantiated control.</param>
    public EventMutation(Action<AvaloniaObject> attach)
        : this(attach, EventFingerprint.Unknown)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventMutation"/> class.
    /// </summary>
    /// <param name="attach">Delegate that attaches the event handler to the instantiated control.</param>
    /// <param name="fingerprint">Fingerprint describing the logical handler so diffs can determine changes.</param>
    public EventMutation(Action<AvaloniaObject> attach, EventFingerprint fingerprint)
    {
        _attach = attach ?? throw new ArgumentNullException(nameof(attach));
        _fingerprint = fingerprint;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventMutation"/> class with explicit detach support.
    /// </summary>
    /// <param name="attach">Delegate that attaches the handler.</param>
    /// <param name="detach">Delegate that detaches the handler.</param>
    /// <param name="fingerprint">Fingerprint describing the handler.</param>
    public EventMutation(Action<AvaloniaObject> attach, Action<AvaloniaObject> detach, EventFingerprint fingerprint = default)
        : this(attach, fingerprint)
    {
        _detach = detach ?? throw new ArgumentNullException(nameof(detach));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventMutation"/> class that captures a detach action per target instance.
    /// </summary>
    /// <param name="attach">Delegate that attaches the handler and returns a detach callback for the provided target.</param>
    /// <param name="fingerprint">Fingerprint describing the handler.</param>
    public EventMutation(Func<AvaloniaObject, Action?> attach, EventFingerprint fingerprint = default)
    {
        _attachWithScopedDetach = attach ?? throw new ArgumentNullException(nameof(attach));
        _detachLookup = new ConditionalWeakTable<AvaloniaObject, Action>();
        _fingerprint = fingerprint;
    }

    /// <summary>
    /// Attaches the recorded handler to the provided control instance.
    /// </summary>
    /// <param name="target">The control instance.</param>
    public void Attach(AvaloniaObject target)
    {
        ArgumentNullException.ThrowIfNull(target);

        if (_attachWithScopedDetach is { } scopedAttach)
        {
            var detach = scopedAttach(target);
            if (detach is not null && _detachLookup is not null)
            {
                _detachLookup.Remove(target);
                _detachLookup.Add(target, detach);
            }

            return;
        }

        _attach!(target);
    }

    /// <summary>
    /// Detaches the recorded handler from the provided control instance, if supported.
    /// </summary>
    /// <param name="target">The control instance.</param>
    public void Detach(AvaloniaObject target)
    {
        ArgumentNullException.ThrowIfNull(target);

        if (_attachWithScopedDetach is not null && _detachLookup is not null)
        {
            if (_detachLookup.TryGetValue(target, out var detach))
            {
                detach();
                _detachLookup.Remove(target);
            }

            return;
        }

        _detach?.Invoke(target);
    }

    /// <summary>
    /// Gets the fingerprint describing the underlying handler.
    /// </summary>
    internal EventFingerprint Fingerprint => _fingerprint;
}

/// <summary>
/// Describes an event handler so the diff engine can detect changes precisely.
/// </summary>
public readonly struct EventFingerprint : IEquatable<EventFingerprint>
{
    /// <summary>
    /// Gets a sentinel fingerprint used when no diagnostics are available.
    /// </summary>
    public static EventFingerprint Unknown { get; } = new();

    internal EventFingerprint(
        Type? ownerType,
        string? eventName,
        int eventId,
        object? handlerTarget,
        MethodInfo? handlerMethod)
    {
        OwnerType = ownerType;
        EventName = eventName;
        EventId = eventId;
        HandlerTarget = handlerTarget;
        HandlerMethod = handlerMethod;
    }

    /// <summary>
    /// Gets the owner type declaring the event.
    /// </summary>
    public Type? OwnerType { get; }

    /// <summary>
    /// Gets the generated metadata id for the event (if available).
    /// </summary>
    public int EventId { get; }

    /// <summary>
    /// Gets the event name for diagnostics.
    /// </summary>
    public string? EventName { get; }

    /// <summary>
    /// Gets the handler target instance.
    /// </summary>
    public object? HandlerTarget { get; }

    /// <summary>
    /// Gets the handler method.
    /// </summary>
    public MethodInfo? HandlerMethod { get; }

    /// <summary>
    /// Gets a value indicating whether this fingerprint carries diagnostic information.
    /// </summary>
    public bool IsUnknown => OwnerType is null && EventName is null && HandlerMethod is null;

    /// <summary>
    /// Creates a fingerprint from strongly typed metadata.
    /// </summary>
    public static EventFingerprint Create(Type ownerType, string eventName, Delegate? handler, int eventId = 0)
    {
        ArgumentNullException.ThrowIfNull(ownerType);
        ArgumentNullException.ThrowIfNull(eventName);

        var method = handler?.Method;
        var target = handler?.Target;

        return new EventFingerprint(ownerType, eventName, eventId, target, method);
    }

    /// <inheritdoc/>
    public bool Equals(EventFingerprint other)
    {
        return EventId == other.EventId
            && Equals(OwnerType, other.OwnerType)
            && string.Equals(EventName, other.EventName, StringComparison.Ordinal)
            && Equals(HandlerTarget, other.HandlerTarget)
            && Equals(HandlerMethod, other.HandlerMethod);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is EventFingerprint other && Equals(other);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return HashCode.Combine(
            OwnerType,
            EventName,
            EventId,
            HandlerTarget,
            HandlerMethod);
    }
}
#endif
