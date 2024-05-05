// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Animation.TransitionBase"/> class property extension methods.
/// </summary>
public static partial class TransitionBaseExtensions
{
    // Avalonia.Animation.TransitionBase.DurationProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Animation.TransitionBase.DurationProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T duration<T>(this T obj, System.TimeSpan value) where T : Avalonia.Animation.TransitionBase
    {
        obj[Avalonia.Animation.TransitionBase.DurationProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Animation.TransitionBase.DurationProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T duration<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Animation.TransitionBase
    {
        var descriptor = Avalonia.Animation.TransitionBase.DurationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Animation.TransitionBase.DurationProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T duration<T>(
        this T obj,
        IObservable<System.TimeSpan> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Animation.TransitionBase
    {
        var descriptor = Avalonia.Animation.TransitionBase.DurationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Animation.TransitionBase.DurationProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Animation.TransitionBase.DurationProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindDuration(
        this Avalonia.Animation.TransitionBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Animation.TransitionBase.DurationProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Animation.TransitionBase.DurationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.TimeSpan> ObserveDuration(this Avalonia.Animation.TransitionBase obj)
    {
        return obj.GetObservable(Avalonia.Animation.TransitionBase.DurationProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Animation.TransitionBase.DurationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnDuration<T>(this T obj, Action<Avalonia.Animation.TransitionBase, IObservable<System.TimeSpan>> handler) where T : Avalonia.Animation.TransitionBase
    {
        var observable = obj.GetObservable(Avalonia.Animation.TransitionBase.DurationProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Animation.TransitionBase.DelayProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Animation.TransitionBase.DelayProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T delay<T>(this T obj, System.TimeSpan value) where T : Avalonia.Animation.TransitionBase
    {
        obj[Avalonia.Animation.TransitionBase.DelayProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Animation.TransitionBase.DelayProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T delay<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Animation.TransitionBase
    {
        var descriptor = Avalonia.Animation.TransitionBase.DelayProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Animation.TransitionBase.DelayProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T delay<T>(
        this T obj,
        IObservable<System.TimeSpan> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Animation.TransitionBase
    {
        var descriptor = Avalonia.Animation.TransitionBase.DelayProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Animation.TransitionBase.DelayProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Animation.TransitionBase.DelayProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindDelay(
        this Avalonia.Animation.TransitionBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Animation.TransitionBase.DelayProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Animation.TransitionBase.DelayProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.TimeSpan> ObserveDelay(this Avalonia.Animation.TransitionBase obj)
    {
        return obj.GetObservable(Avalonia.Animation.TransitionBase.DelayProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Animation.TransitionBase.DelayProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnDelay<T>(this T obj, Action<Avalonia.Animation.TransitionBase, IObservable<System.TimeSpan>> handler) where T : Avalonia.Animation.TransitionBase
    {
        var observable = obj.GetObservable(Avalonia.Animation.TransitionBase.DelayProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Animation.TransitionBase.EasingProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Animation.TransitionBase.EasingProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T easing<T>(this T obj, Avalonia.Animation.Easings.Easing value) where T : Avalonia.Animation.TransitionBase
    {
        obj[Avalonia.Animation.TransitionBase.EasingProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Animation.TransitionBase.EasingProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T easing<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Animation.TransitionBase
    {
        var descriptor = Avalonia.Animation.TransitionBase.EasingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Animation.TransitionBase.EasingProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T easing<T>(
        this T obj,
        IObservable<Avalonia.Animation.Easings.Easing> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Animation.TransitionBase
    {
        var descriptor = Avalonia.Animation.TransitionBase.EasingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Animation.TransitionBase.EasingProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Animation.TransitionBase.EasingProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindEasing(
        this Avalonia.Animation.TransitionBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Animation.TransitionBase.EasingProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Animation.TransitionBase.EasingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Animation.Easings.Easing> ObserveEasing(this Avalonia.Animation.TransitionBase obj)
    {
        return obj.GetObservable(Avalonia.Animation.TransitionBase.EasingProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Animation.TransitionBase.EasingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnEasing<T>(this T obj, Action<Avalonia.Animation.TransitionBase, IObservable<Avalonia.Animation.Easings.Easing>> handler) where T : Avalonia.Animation.TransitionBase
    {
        var observable = obj.GetObservable(Avalonia.Animation.TransitionBase.EasingProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Animation.TransitionBase.PropertyProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Animation.TransitionBase.PropertyProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T property<T>(this T obj, Avalonia.AvaloniaProperty value) where T : Avalonia.Animation.TransitionBase
    {
        obj[Avalonia.Animation.TransitionBase.PropertyProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Animation.TransitionBase.PropertyProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T property<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Animation.TransitionBase
    {
        var descriptor = Avalonia.Animation.TransitionBase.PropertyProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Animation.TransitionBase.PropertyProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T property<T>(
        this T obj,
        IObservable<Avalonia.AvaloniaProperty> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Animation.TransitionBase
    {
        var descriptor = Avalonia.Animation.TransitionBase.PropertyProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Animation.TransitionBase.PropertyProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Animation.TransitionBase.PropertyProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindProperty(
        this Avalonia.Animation.TransitionBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Animation.TransitionBase.PropertyProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Animation.TransitionBase.PropertyProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.AvaloniaProperty> ObserveProperty(this Avalonia.Animation.TransitionBase obj)
    {
        return obj.GetObservable(Avalonia.Animation.TransitionBase.PropertyProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Animation.TransitionBase.PropertyProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnProperty<T>(this T obj, Action<Avalonia.Animation.TransitionBase, IObservable<Avalonia.AvaloniaProperty>> handler) where T : Avalonia.Animation.TransitionBase
    {
        var observable = obj.GetObservable(Avalonia.Animation.TransitionBase.PropertyProperty);
        handler(obj, observable);
        return obj;
    }
}
