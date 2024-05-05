// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Shapes.Arc"/> class property extension methods.
/// </summary>
public static partial class ArcExtensions
{
    // Avalonia.Controls.Shapes.Arc.StartAngleProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Shapes.Arc.StartAngleProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T startAngle<T>(this T obj, System.Double value) where T : Avalonia.Controls.Shapes.Arc
    {
        obj[Avalonia.Controls.Shapes.Arc.StartAngleProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Shapes.Arc.StartAngleProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T startAngle<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Shapes.Arc
    {
        var descriptor = Avalonia.Controls.Shapes.Arc.StartAngleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Shapes.Arc.StartAngleProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T startAngle<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Shapes.Arc
    {
        var descriptor = Avalonia.Controls.Shapes.Arc.StartAngleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Shapes.Arc.StartAngleProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Shapes.Arc.StartAngleProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindStartAngle(
        this Avalonia.Controls.Shapes.Arc obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Shapes.Arc.StartAngleProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Shapes.Arc.StartAngleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveStartAngle(this Avalonia.Controls.Shapes.Arc obj)
    {
        return obj.GetObservable(Avalonia.Controls.Shapes.Arc.StartAngleProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Shapes.Arc.StartAngleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnStartAngle<T>(this T obj, Action<Avalonia.Controls.Shapes.Arc, IObservable<System.Double>> handler) where T : Avalonia.Controls.Shapes.Arc
    {
        var observable = obj.GetObservable(Avalonia.Controls.Shapes.Arc.StartAngleProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Shapes.Arc.SweepAngleProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Shapes.Arc.SweepAngleProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T sweepAngle<T>(this T obj, System.Double value) where T : Avalonia.Controls.Shapes.Arc
    {
        obj[Avalonia.Controls.Shapes.Arc.SweepAngleProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Shapes.Arc.SweepAngleProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T sweepAngle<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Shapes.Arc
    {
        var descriptor = Avalonia.Controls.Shapes.Arc.SweepAngleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Shapes.Arc.SweepAngleProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T sweepAngle<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Shapes.Arc
    {
        var descriptor = Avalonia.Controls.Shapes.Arc.SweepAngleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Shapes.Arc.SweepAngleProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Shapes.Arc.SweepAngleProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSweepAngle(
        this Avalonia.Controls.Shapes.Arc obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Shapes.Arc.SweepAngleProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Shapes.Arc.SweepAngleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveSweepAngle(this Avalonia.Controls.Shapes.Arc obj)
    {
        return obj.GetObservable(Avalonia.Controls.Shapes.Arc.SweepAngleProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Shapes.Arc.SweepAngleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSweepAngle<T>(this T obj, Action<Avalonia.Controls.Shapes.Arc, IObservable<System.Double>> handler) where T : Avalonia.Controls.Shapes.Arc
    {
        var observable = obj.GetObservable(Avalonia.Controls.Shapes.Arc.SweepAngleProperty);
        handler(obj, observable);
        return obj;
    }
}