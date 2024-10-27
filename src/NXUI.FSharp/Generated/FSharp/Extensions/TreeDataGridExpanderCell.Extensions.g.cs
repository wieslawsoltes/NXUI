// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell"/> class property extension methods.
/// </summary>
public static partial class TreeDataGridExpanderCellExtensions
{
    // Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IndentProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IndentProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IndentProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIndent(
        this Avalonia.Controls.Primitives.TreeDataGridExpanderCell obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IndentProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IndentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Int32> ObserveIndent(this Avalonia.Controls.Primitives.TreeDataGridExpanderCell obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IndentProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IndentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.TreeDataGridExpanderCell OnIndent(this Avalonia.Controls.Primitives.TreeDataGridExpanderCell obj, Action<Avalonia.Controls.Primitives.TreeDataGridExpanderCell, IObservable<System.Int32>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IndentProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T isExpanded<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.TreeDataGridExpanderCell
    {
        obj[Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T isExpanded<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.TreeDataGridExpanderCell
    {
        var descriptor = Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T isExpanded<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.TreeDataGridExpanderCell
    {
        var descriptor = Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsExpanded(
        this Avalonia.Controls.Primitives.TreeDataGridExpanderCell obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsExpanded(this Avalonia.Controls.Primitives.TreeDataGridExpanderCell obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsExpanded<T>(this T obj, Action<Avalonia.Controls.Primitives.TreeDataGridExpanderCell, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Primitives.TreeDataGridExpanderCell
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridExpanderCell.IsExpandedProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.TreeDataGridExpanderCell.ShowExpanderProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.ShowExpanderProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.ShowExpanderProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindShowExpander(
        this Avalonia.Controls.Primitives.TreeDataGridExpanderCell obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.TreeDataGridExpanderCell.ShowExpanderProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.ShowExpanderProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveShowExpander(this Avalonia.Controls.Primitives.TreeDataGridExpanderCell obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridExpanderCell.ShowExpanderProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridExpanderCell.ShowExpanderProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.TreeDataGridExpanderCell OnShowExpander(this Avalonia.Controls.Primitives.TreeDataGridExpanderCell obj, Action<Avalonia.Controls.Primitives.TreeDataGridExpanderCell, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridExpanderCell.ShowExpanderProperty);
        handler(obj, observable);
        return obj;
    }
}
