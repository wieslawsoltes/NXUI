// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.TreeViewItem"/> class property extension methods.
/// </summary>
public static partial class TreeViewItemExtensions
{
    // Avalonia.Controls.TreeViewItem.IsExpandedProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TreeViewItem.IsExpandedProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsExpanded<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.TreeViewItem
    {
        obj[Avalonia.Controls.TreeViewItem.IsExpandedProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TreeViewItem.IsExpandedProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsExpanded<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TreeViewItem
    {
        var descriptor = Avalonia.Controls.TreeViewItem.IsExpandedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TreeViewItem.IsExpandedProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsExpanded<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TreeViewItem
    {
        var descriptor = Avalonia.Controls.TreeViewItem.IsExpandedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.TreeViewItem.IsExpandedProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.TreeViewItem.IsExpandedProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsExpanded(
        this Avalonia.Controls.TreeViewItem obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.TreeViewItem.IsExpandedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.TreeViewItem.IsExpandedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsExpanded(this Avalonia.Controls.TreeViewItem obj)
    {
        return obj.GetObservable(Avalonia.Controls.TreeViewItem.IsExpandedProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.TreeViewItem.IsExpandedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsExpanded<T>(this T obj, Action<Avalonia.Controls.TreeViewItem, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.TreeViewItem
    {
        var observable = obj.GetObservable(Avalonia.Controls.TreeViewItem.IsExpandedProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.TreeViewItem.LevelProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.TreeViewItem.LevelProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.TreeViewItem.LevelProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindLevel(
        this Avalonia.Controls.TreeViewItem obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.TreeViewItem.LevelProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.TreeViewItem.LevelProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Int32> ObserveLevel(this Avalonia.Controls.TreeViewItem obj)
    {
        return obj.GetObservable(Avalonia.Controls.TreeViewItem.LevelProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.TreeViewItem.LevelProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.TreeViewItem OnLevel(this Avalonia.Controls.TreeViewItem obj, Action<Avalonia.Controls.TreeViewItem, IObservable<System.Int32>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.TreeViewItem.LevelProperty);
        handler(obj, observable);
        return obj;
    }
}
