// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Shapes.Polyline"/> class property extension methods.
/// </summary>
public static partial class PolylineExtensions
{
    // Avalonia.Controls.Shapes.Polyline.PointsProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Shapes.Polyline.PointsProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Points<T>(this T obj, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Controls.Shapes.Polyline
    {
        obj[Avalonia.Controls.Shapes.Polyline.PointsProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Shapes.Polyline.PointsProperty"/> with binding source value.
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
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Shapes.Polyline
    {
        var descriptor = Avalonia.Controls.Shapes.Polyline.PointsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Shapes.Polyline.PointsProperty"/> with observable source value.
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
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Shapes.Polyline
    {
        var descriptor = Avalonia.Controls.Shapes.Polyline.PointsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Shapes.Polyline.PointsProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Shapes.Polyline.PointsProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPoints(
        this Avalonia.Controls.Shapes.Polyline obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Shapes.Polyline.PointsProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Shapes.Polyline.PointsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Collections.Generic.IList<Avalonia.Point>> ObservePoints(this Avalonia.Controls.Shapes.Polyline obj)
    {
        return obj.GetObservable(Avalonia.Controls.Shapes.Polyline.PointsProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Shapes.Polyline.PointsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPoints<T>(this T obj, Action<Avalonia.Controls.Shapes.Polyline, IObservable<System.Collections.Generic.IList<Avalonia.Point>>> handler) where T : Avalonia.Controls.Shapes.Polyline
    {
        var observable = obj.GetObservable(Avalonia.Controls.Shapes.Polyline.PointsProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.Shapes.Polyline.PointsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Collections.Generic.IList<Avalonia.Point>>> ObserveBindingPoints(this Avalonia.Controls.Shapes.Polyline obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.Shapes.Polyline.PointsProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.Shapes.Polyline.PointsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingPoints<T>(this T obj, Action<Avalonia.Controls.Shapes.Polyline, IObservable<BindingValue<System.Collections.Generic.IList<Avalonia.Point>>>> handler) where T : Avalonia.Controls.Shapes.Polyline
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.Shapes.Polyline.PointsProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.Shapes.Polyline.PointsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObservePointsChanged(this Avalonia.Controls.Shapes.Polyline obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.Shapes.Polyline.PointsProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.Shapes.Polyline.PointsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPointsChanged<T>(this T obj, Action<Avalonia.Controls.Shapes.Polyline, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.Shapes.Polyline
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.Shapes.Polyline.PointsProperty);
        handler(obj, observable);
        return obj;
    }
}
