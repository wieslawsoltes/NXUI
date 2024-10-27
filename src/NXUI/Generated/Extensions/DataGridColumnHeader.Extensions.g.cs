// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.DataGridColumnHeader"/> class property extension methods.
/// </summary>
public static partial class DataGridColumnHeaderExtensions
{
    // Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SeparatorBrush<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.DataGridColumnHeader
    {
        obj[Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SeparatorBrush<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.DataGridColumnHeader
    {
        var descriptor = Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SeparatorBrush<T>(
        this T obj,
        IObservable<Avalonia.Media.IBrush> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.DataGridColumnHeader
    {
        var descriptor = Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSeparatorBrush(
        this Avalonia.Controls.DataGridColumnHeader obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.IBrush> ObserveSeparatorBrush(this Avalonia.Controls.DataGridColumnHeader obj)
    {
        return obj.GetObservable(Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSeparatorBrush<T>(this T obj, Action<Avalonia.Controls.DataGridColumnHeader, IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.DataGridColumnHeader
    {
        var observable = obj.GetObservable(Avalonia.Controls.DataGridColumnHeader.SeparatorBrushProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AreSeparatorsVisible<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.DataGridColumnHeader
    {
        obj[Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AreSeparatorsVisible<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.DataGridColumnHeader
    {
        var descriptor = Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AreSeparatorsVisible<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.DataGridColumnHeader
    {
        var descriptor = Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindAreSeparatorsVisible(
        this Avalonia.Controls.DataGridColumnHeader obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveAreSeparatorsVisible(this Avalonia.Controls.DataGridColumnHeader obj)
    {
        return obj.GetObservable(Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnAreSeparatorsVisible<T>(this T obj, Action<Avalonia.Controls.DataGridColumnHeader, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.DataGridColumnHeader
    {
        var observable = obj.GetObservable(Avalonia.Controls.DataGridColumnHeader.AreSeparatorsVisibleProperty);
        handler(obj, observable);
        return obj;
    }
}
