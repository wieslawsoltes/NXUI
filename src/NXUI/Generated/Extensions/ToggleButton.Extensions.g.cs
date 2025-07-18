// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.ToggleButton"/> class property extension methods.
/// </summary>
public static partial class ToggleButtonExtensions
{
    // Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsChecked<T>(this T obj, System.Nullable<System.Boolean> value) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj[Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsChecked<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var descriptor = Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsChecked<T>(
        this T obj,
        IObservable<System.Nullable<System.Boolean>> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var descriptor = Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsChecked(
        this Avalonia.Controls.Primitives.ToggleButton obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Nullable<System.Boolean>> ObserveIsChecked(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsChecked<T>(this T obj, Action<Avalonia.Controls.Primitives.ToggleButton, IObservable<System.Nullable<System.Boolean>>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Nullable<System.Boolean>>> ObserveBindingIsChecked(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingIsChecked<T>(this T obj, Action<Avalonia.Controls.Primitives.ToggleButton, IObservable<BindingValue<System.Nullable<System.Boolean>>>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveIsCheckedChanged(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsCheckedChanged<T>(this T obj, Action<Avalonia.Controls.Primitives.ToggleButton, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsThreeState<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj[Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsThreeState<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var descriptor = Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsThreeState<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var descriptor = Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsThreeState(
        this Avalonia.Controls.Primitives.ToggleButton obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsThreeState(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsThreeState<T>(this T obj, Action<Avalonia.Controls.Primitives.ToggleButton, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Boolean>> ObserveBindingIsThreeState(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingIsThreeState<T>(this T obj, Action<Avalonia.Controls.Primitives.ToggleButton, IObservable<BindingValue<System.Boolean>>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveIsThreeStateChanged(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsThreeStateChanged<T>(this T obj, Action<Avalonia.Controls.Primitives.ToggleButton, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.ToggleButton.IsCheckedChangedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.ToggleButton"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnIsCheckedChangedHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj.AddHandler(Avalonia.Controls.Primitives.ToggleButton.IsCheckedChangedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.ToggleButton"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnIsCheckedChanged<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsCheckedChangedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.ToggleButton"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnIsCheckedChanged(
        this Avalonia.Controls.Primitives.ToggleButton obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsCheckedChangedEvent, routes);
    }

    // Avalonia.Controls.Primitives.ToggleButton.IsCheckedChanged

    /// <summary>
    /// Adds a handler to the `IsCheckedChanged` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsCheckedChangedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = Observable
            .FromEventPattern<System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.IsCheckedChanged += h, 
                h => obj.IsCheckedChanged -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `IsCheckedChanged` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `IsCheckedChanged` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnIsCheckedChangedEvent(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return Observable
            .FromEventPattern<System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.IsCheckedChanged += h, 
                h => obj.IsCheckedChanged -= h)
            .Select(x => x.EventArgs);
    }
}
