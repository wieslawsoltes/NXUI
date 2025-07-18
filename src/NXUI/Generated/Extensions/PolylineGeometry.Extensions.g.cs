// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.PolylineGeometry"/> class property extension methods.
/// </summary>
public static partial class PolylineGeometryExtensions
{
    // Avalonia.Media.PolylineGeometry.PointsProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.PolylineGeometry.PointsProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Points<T>(this T obj, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Media.PolylineGeometry
    {
        obj[Avalonia.Media.PolylineGeometry.PointsProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PolylineGeometry.PointsProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Points<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.PolylineGeometry
    {
        var descriptor = Avalonia.Media.PolylineGeometry.PointsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PolylineGeometry.PointsProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Points<T>(
        this T obj,
        IObservable<System.Collections.Generic.IList<Avalonia.Point>> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.PolylineGeometry
    {
        var descriptor = Avalonia.Media.PolylineGeometry.PointsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.PolylineGeometry.PointsProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.PolylineGeometry.PointsProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPoints(
        this Avalonia.Media.PolylineGeometry obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PolylineGeometry.PointsProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.PolylineGeometry.PointsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Collections.Generic.IList<Avalonia.Point>> ObservePoints(this Avalonia.Media.PolylineGeometry obj)
    {
        return obj.GetObservable(Avalonia.Media.PolylineGeometry.PointsProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.PolylineGeometry.PointsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPoints<T>(this T obj, Action<Avalonia.Media.PolylineGeometry, IObservable<System.Collections.Generic.IList<Avalonia.Point>>> handler) where T : Avalonia.Media.PolylineGeometry
    {
        var observable = obj.GetObservable(Avalonia.Media.PolylineGeometry.PointsProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.PolylineGeometry.PointsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Collections.Generic.IList<Avalonia.Point>>> ObserveBindingPoints(this Avalonia.Media.PolylineGeometry obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.PolylineGeometry.PointsProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.PolylineGeometry.PointsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingPoints<T>(this T obj, Action<Avalonia.Media.PolylineGeometry, IObservable<BindingValue<System.Collections.Generic.IList<Avalonia.Point>>>> handler) where T : Avalonia.Media.PolylineGeometry
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.PolylineGeometry.PointsProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.PolylineGeometry.PointsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObservePointsChanged(this Avalonia.Media.PolylineGeometry obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.PolylineGeometry.PointsProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.PolylineGeometry.PointsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPointsChanged<T>(this T obj, Action<Avalonia.Media.PolylineGeometry, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Media.PolylineGeometry
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.PolylineGeometry.PointsProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.PolylineGeometry.IsFilledProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.PolylineGeometry.IsFilledProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsFilled<T>(this T obj, System.Boolean value) where T : Avalonia.Media.PolylineGeometry
    {
        obj[Avalonia.Media.PolylineGeometry.IsFilledProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PolylineGeometry.IsFilledProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsFilled<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.PolylineGeometry
    {
        var descriptor = Avalonia.Media.PolylineGeometry.IsFilledProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PolylineGeometry.IsFilledProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsFilled<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.PolylineGeometry
    {
        var descriptor = Avalonia.Media.PolylineGeometry.IsFilledProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.PolylineGeometry.IsFilledProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.PolylineGeometry.IsFilledProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsFilled(
        this Avalonia.Media.PolylineGeometry obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PolylineGeometry.IsFilledProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.PolylineGeometry.IsFilledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsFilled(this Avalonia.Media.PolylineGeometry obj)
    {
        return obj.GetObservable(Avalonia.Media.PolylineGeometry.IsFilledProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.PolylineGeometry.IsFilledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsFilled<T>(this T obj, Action<Avalonia.Media.PolylineGeometry, IObservable<System.Boolean>> handler) where T : Avalonia.Media.PolylineGeometry
    {
        var observable = obj.GetObservable(Avalonia.Media.PolylineGeometry.IsFilledProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.PolylineGeometry.IsFilledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Boolean>> ObserveBindingIsFilled(this Avalonia.Media.PolylineGeometry obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.PolylineGeometry.IsFilledProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.PolylineGeometry.IsFilledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingIsFilled<T>(this T obj, Action<Avalonia.Media.PolylineGeometry, IObservable<BindingValue<System.Boolean>>> handler) where T : Avalonia.Media.PolylineGeometry
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.PolylineGeometry.IsFilledProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.PolylineGeometry.IsFilledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveIsFilledChanged(this Avalonia.Media.PolylineGeometry obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.PolylineGeometry.IsFilledProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.PolylineGeometry.IsFilledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsFilledChanged<T>(this T obj, Action<Avalonia.Media.PolylineGeometry, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Media.PolylineGeometry
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.PolylineGeometry.IsFilledProperty);
        handler(obj, observable);
        return obj;
    }
}
