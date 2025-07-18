// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Notifications.WindowNotificationManager"/> class property extension methods.
/// </summary>
public static partial class WindowNotificationManagerExtensions
{
    // Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Position<T>(this T obj, Avalonia.Controls.Notifications.NotificationPosition value) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Position<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        var descriptor = Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Position<T>(
        this T obj,
        IObservable<Avalonia.Controls.Notifications.NotificationPosition> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        var descriptor = Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPosition(
        this Avalonia.Controls.Notifications.WindowNotificationManager obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Notifications.NotificationPosition> ObservePosition(this Avalonia.Controls.Notifications.WindowNotificationManager obj)
    {
        return obj.GetObservable(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPosition<T>(this T obj, Action<Avalonia.Controls.Notifications.WindowNotificationManager, IObservable<Avalonia.Controls.Notifications.NotificationPosition>> handler) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        var observable = obj.GetObservable(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Controls.Notifications.NotificationPosition>> ObserveBindingPosition(this Avalonia.Controls.Notifications.WindowNotificationManager obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingPosition<T>(this T obj, Action<Avalonia.Controls.Notifications.WindowNotificationManager, IObservable<BindingValue<Avalonia.Controls.Notifications.NotificationPosition>>> handler) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObservePositionChanged(this Avalonia.Controls.Notifications.WindowNotificationManager obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPositionChanged<T>(this T obj, Action<Avalonia.Controls.Notifications.WindowNotificationManager, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/> property value to <see cref="Avalonia.Controls.Notifications.NotificationPosition.TopLeft"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PositionTopLeft<T>(this T obj) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty] = Avalonia.Controls.Notifications.NotificationPosition.TopLeft;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/> property value to <see cref="Avalonia.Controls.Notifications.NotificationPosition.TopRight"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PositionTopRight<T>(this T obj) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty] = Avalonia.Controls.Notifications.NotificationPosition.TopRight;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/> property value to <see cref="Avalonia.Controls.Notifications.NotificationPosition.BottomLeft"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PositionBottomLeft<T>(this T obj) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty] = Avalonia.Controls.Notifications.NotificationPosition.BottomLeft;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/> property value to <see cref="Avalonia.Controls.Notifications.NotificationPosition.BottomRight"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PositionBottomRight<T>(this T obj) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty] = Avalonia.Controls.Notifications.NotificationPosition.BottomRight;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/> property value to <see cref="Avalonia.Controls.Notifications.NotificationPosition.TopCenter"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PositionTopCenter<T>(this T obj) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty] = Avalonia.Controls.Notifications.NotificationPosition.TopCenter;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty"/> property value to <see cref="Avalonia.Controls.Notifications.NotificationPosition.BottomCenter"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PositionBottomCenter<T>(this T obj) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty] = Avalonia.Controls.Notifications.NotificationPosition.BottomCenter;
        return obj;
    }

    // Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T MaxItems<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        obj[Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T MaxItems<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        var descriptor = Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T MaxItems<T>(
        this T obj,
        IObservable<System.Int32> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        var descriptor = Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindMaxItems(
        this Avalonia.Controls.Notifications.WindowNotificationManager obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Int32> ObserveMaxItems(this Avalonia.Controls.Notifications.WindowNotificationManager obj)
    {
        return obj.GetObservable(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnMaxItems<T>(this T obj, Action<Avalonia.Controls.Notifications.WindowNotificationManager, IObservable<System.Int32>> handler) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        var observable = obj.GetObservable(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Int32>> ObserveBindingMaxItems(this Avalonia.Controls.Notifications.WindowNotificationManager obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingMaxItems<T>(this T obj, Action<Avalonia.Controls.Notifications.WindowNotificationManager, IObservable<BindingValue<System.Int32>>> handler) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveMaxItemsChanged(this Avalonia.Controls.Notifications.WindowNotificationManager obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnMaxItemsChanged<T>(this T obj, Action<Avalonia.Controls.Notifications.WindowNotificationManager, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.Notifications.WindowNotificationManager
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty);
        handler(obj, observable);
        return obj;
    }
}
