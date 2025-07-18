// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.RectangleGeometry"/> class property extension methods.
/// </summary>
public static partial class RectangleGeometryExtensions
{
    // Avalonia.Media.RectangleGeometry.RadiusXProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.RectangleGeometry.RadiusXProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T RadiusX<T>(this T obj, System.Double value) where T : Avalonia.Media.RectangleGeometry
    {
        obj[Avalonia.Media.RectangleGeometry.RadiusXProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RectangleGeometry.RadiusXProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T RadiusX<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.RectangleGeometry
    {
        var descriptor = Avalonia.Media.RectangleGeometry.RadiusXProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RectangleGeometry.RadiusXProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T RadiusX<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.RectangleGeometry
    {
        var descriptor = Avalonia.Media.RectangleGeometry.RadiusXProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.RectangleGeometry.RadiusXProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.RectangleGeometry.RadiusXProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindRadiusX(
        this Avalonia.Media.RectangleGeometry obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RectangleGeometry.RadiusXProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.RectangleGeometry.RadiusXProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveRadiusX(this Avalonia.Media.RectangleGeometry obj)
    {
        return obj.GetObservable(Avalonia.Media.RectangleGeometry.RadiusXProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.RectangleGeometry.RadiusXProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnRadiusX<T>(this T obj, Action<Avalonia.Media.RectangleGeometry, IObservable<System.Double>> handler) where T : Avalonia.Media.RectangleGeometry
    {
        var observable = obj.GetObservable(Avalonia.Media.RectangleGeometry.RadiusXProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.RectangleGeometry.RadiusXProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Double>> ObserveBindingRadiusX(this Avalonia.Media.RectangleGeometry obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.RectangleGeometry.RadiusXProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.RectangleGeometry.RadiusXProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingRadiusX<T>(this T obj, Action<Avalonia.Media.RectangleGeometry, IObservable<BindingValue<System.Double>>> handler) where T : Avalonia.Media.RectangleGeometry
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.RectangleGeometry.RadiusXProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.RectangleGeometry.RadiusXProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveRadiusXChanged(this Avalonia.Media.RectangleGeometry obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.RectangleGeometry.RadiusXProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.RectangleGeometry.RadiusXProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnRadiusXChanged<T>(this T obj, Action<Avalonia.Media.RectangleGeometry, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Media.RectangleGeometry
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.RectangleGeometry.RadiusXProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.RectangleGeometry.RadiusYProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.RectangleGeometry.RadiusYProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T RadiusY<T>(this T obj, System.Double value) where T : Avalonia.Media.RectangleGeometry
    {
        obj[Avalonia.Media.RectangleGeometry.RadiusYProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RectangleGeometry.RadiusYProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T RadiusY<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.RectangleGeometry
    {
        var descriptor = Avalonia.Media.RectangleGeometry.RadiusYProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RectangleGeometry.RadiusYProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T RadiusY<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.RectangleGeometry
    {
        var descriptor = Avalonia.Media.RectangleGeometry.RadiusYProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.RectangleGeometry.RadiusYProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.RectangleGeometry.RadiusYProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindRadiusY(
        this Avalonia.Media.RectangleGeometry obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RectangleGeometry.RadiusYProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.RectangleGeometry.RadiusYProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveRadiusY(this Avalonia.Media.RectangleGeometry obj)
    {
        return obj.GetObservable(Avalonia.Media.RectangleGeometry.RadiusYProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.RectangleGeometry.RadiusYProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnRadiusY<T>(this T obj, Action<Avalonia.Media.RectangleGeometry, IObservable<System.Double>> handler) where T : Avalonia.Media.RectangleGeometry
    {
        var observable = obj.GetObservable(Avalonia.Media.RectangleGeometry.RadiusYProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.RectangleGeometry.RadiusYProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Double>> ObserveBindingRadiusY(this Avalonia.Media.RectangleGeometry obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.RectangleGeometry.RadiusYProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.RectangleGeometry.RadiusYProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingRadiusY<T>(this T obj, Action<Avalonia.Media.RectangleGeometry, IObservable<BindingValue<System.Double>>> handler) where T : Avalonia.Media.RectangleGeometry
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.RectangleGeometry.RadiusYProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.RectangleGeometry.RadiusYProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveRadiusYChanged(this Avalonia.Media.RectangleGeometry obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.RectangleGeometry.RadiusYProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.RectangleGeometry.RadiusYProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnRadiusYChanged<T>(this T obj, Action<Avalonia.Media.RectangleGeometry, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Media.RectangleGeometry
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.RectangleGeometry.RadiusYProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.RectangleGeometry.RectProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Rect<T>(this T obj, Avalonia.Rect value) where T : Avalonia.Media.RectangleGeometry
    {
        obj[Avalonia.Media.RectangleGeometry.RectProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Rect<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.RectangleGeometry
    {
        var descriptor = Avalonia.Media.RectangleGeometry.RectProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Rect<T>(
        this T obj,
        IObservable<Avalonia.Rect> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.RectangleGeometry
    {
        var descriptor = Avalonia.Media.RectangleGeometry.RectProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindRect(
        this Avalonia.Media.RectangleGeometry obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RectangleGeometry.RectProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Rect> ObserveRect(this Avalonia.Media.RectangleGeometry obj)
    {
        return obj.GetObservable(Avalonia.Media.RectangleGeometry.RectProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnRect<T>(this T obj, Action<Avalonia.Media.RectangleGeometry, IObservable<Avalonia.Rect>> handler) where T : Avalonia.Media.RectangleGeometry
    {
        var observable = obj.GetObservable(Avalonia.Media.RectangleGeometry.RectProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Rect>> ObserveBindingRect(this Avalonia.Media.RectangleGeometry obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.RectangleGeometry.RectProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingRect<T>(this T obj, Action<Avalonia.Media.RectangleGeometry, IObservable<BindingValue<Avalonia.Rect>>> handler) where T : Avalonia.Media.RectangleGeometry
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.RectangleGeometry.RectProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveRectChanged(this Avalonia.Media.RectangleGeometry obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.RectangleGeometry.RectProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.RectangleGeometry.RectProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnRectChanged<T>(this T obj, Action<Avalonia.Media.RectangleGeometry, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Media.RectangleGeometry
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.RectangleGeometry.RectProperty);
        handler(obj, observable);
        return obj;
    }
}
