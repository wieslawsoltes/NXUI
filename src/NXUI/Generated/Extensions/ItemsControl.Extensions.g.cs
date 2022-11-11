// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.ItemsControl"/> class property extension methods.
/// </summary>
public static partial class ItemsControlExtensions
{
    // Avalonia.Controls.ItemsControl.ItemsProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Items<T>(this T obj, System.Collections.IEnumerable value) where T : Avalonia.Controls.ItemsControl
    {
        obj[Avalonia.Controls.ItemsControl.ItemsProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Items<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Items<T>(
        this T obj,
        IObservable<System.Collections.IEnumerable> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItems(
        this Avalonia.Controls.ItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemsProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Collections.IEnumerable> ObserveItems(this Avalonia.Controls.ItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ItemsControl.ItemsProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnItems<T>(this T obj, Action<Avalonia.Controls.ItemsControl, IObservable<System.Collections.IEnumerable>> handler) where T : Avalonia.Controls.ItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ItemsControl.ItemsProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ItemsControl.ItemContainerThemeProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemContainerTheme<T>(this T obj, Avalonia.Styling.ControlTheme value) where T : Avalonia.Controls.ItemsControl
    {
        obj[Avalonia.Controls.ItemsControl.ItemContainerThemeProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemContainerTheme<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemContainerThemeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemContainerTheme<T>(
        this T obj,
        IObservable<Avalonia.Styling.ControlTheme> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemContainerThemeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItemContainerTheme(
        this Avalonia.Controls.ItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemContainerThemeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Styling.ControlTheme> ObserveItemContainerTheme(this Avalonia.Controls.ItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnItemContainerTheme<T>(this T obj, Action<Avalonia.Controls.ItemsControl, IObservable<Avalonia.Styling.ControlTheme>> handler) where T : Avalonia.Controls.ItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ItemsControl.ItemCountProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ItemsControl.ItemCountProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ItemsControl.ItemCountProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItemCount(
        this Avalonia.Controls.ItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemCountProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemCountProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Int32> ObserveItemCount(this Avalonia.Controls.ItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ItemsControl.ItemCountProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemCountProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.ItemsControl OnItemCount(this Avalonia.Controls.ItemsControl obj, Action<Avalonia.Controls.ItemsControl, IObservable<System.Int32>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.ItemsControl.ItemCountProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ItemsControl.ItemsPanelProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemsPanel<T>(this T obj, Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel> value) where T : Avalonia.Controls.ItemsControl
    {
        obj[Avalonia.Controls.ItemsControl.ItemsPanelProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemsPanel<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemsPanelProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemsPanel<T>(
        this T obj,
        IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel>> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemsPanelProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItemsPanel(
        this Avalonia.Controls.ItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemsPanelProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel>> ObserveItemsPanel(this Avalonia.Controls.ItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ItemsControl.ItemsPanelProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnItemsPanel<T>(this T obj, Action<Avalonia.Controls.ItemsControl, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel>>> handler) where T : Avalonia.Controls.ItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ItemsControl.ItemsPanelProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ItemsControl.ItemTemplateProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ItemsControl
    {
        obj[Avalonia.Controls.ItemsControl.ItemTemplateProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemTemplate<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemTemplate<T>(
        this T obj,
        IObservable<Avalonia.Controls.Templates.IDataTemplate> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ItemsControl
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItemTemplate(
        this Avalonia.Controls.ItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ItemsControl.ItemTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveItemTemplate(this Avalonia.Controls.ItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ItemsControl.ItemTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnItemTemplate<T>(this T obj, Action<Avalonia.Controls.ItemsControl, IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler) where T : Avalonia.Controls.ItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ItemsControl.ItemTemplateProperty);
        handler(obj, observable);
        return obj;
    }
}