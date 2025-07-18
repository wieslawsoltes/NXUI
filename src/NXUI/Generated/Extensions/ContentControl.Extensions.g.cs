// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.ContentControl"/> class property extension methods.
/// </summary>
public static partial class ContentControlExtensions
{
    // Avalonia.Controls.ContentControl.ContentProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ContentControl.ContentProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Content<T>(this T obj, System.Object value) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.ContentProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ContentControl.ContentProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Content<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ContentControl
    {
        var descriptor = Avalonia.Controls.ContentControl.ContentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ContentControl.ContentProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Content<T>(
        this T obj,
        IObservable<System.Object> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ContentControl
    {
        var descriptor = Avalonia.Controls.ContentControl.ContentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ContentControl.ContentProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ContentControl.ContentProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindContent(
        this Avalonia.Controls.ContentControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ContentControl.ContentProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ContentControl.ContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Object> ObserveContent(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ContentControl.ContentProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ContentControl.ContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnContent<T>(this T obj, Action<Avalonia.Controls.ContentControl, IObservable<System.Object>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ContentControl.ContentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.ContentControl.ContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Object>> ObserveBindingContent(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.ContentControl.ContentProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.ContentControl.ContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingContent<T>(this T obj, Action<Avalonia.Controls.ContentControl, IObservable<BindingValue<System.Object>>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.ContentControl.ContentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.ContentControl.ContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveContentChanged(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.ContentControl.ContentProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.ContentControl.ContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnContentChanged<T>(this T obj, Action<Avalonia.Controls.ContentControl, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.ContentControl.ContentProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ContentControl.ContentTemplateProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ContentControl.ContentTemplateProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ContentTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.ContentTemplateProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ContentControl.ContentTemplateProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ContentTemplate<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ContentControl
    {
        var descriptor = Avalonia.Controls.ContentControl.ContentTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ContentControl.ContentTemplateProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ContentTemplate<T>(
        this T obj,
        IObservable<Avalonia.Controls.Templates.IDataTemplate> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ContentControl
    {
        var descriptor = Avalonia.Controls.ContentControl.ContentTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ContentControl.ContentTemplateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ContentControl.ContentTemplateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindContentTemplate(
        this Avalonia.Controls.ContentControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ContentControl.ContentTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ContentControl.ContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveContentTemplate(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ContentControl.ContentTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ContentControl.ContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnContentTemplate<T>(this T obj, Action<Avalonia.Controls.ContentControl, IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ContentControl.ContentTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.ContentControl.ContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Controls.Templates.IDataTemplate>> ObserveBindingContentTemplate(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.ContentControl.ContentTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.ContentControl.ContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingContentTemplate<T>(this T obj, Action<Avalonia.Controls.ContentControl, IObservable<BindingValue<Avalonia.Controls.Templates.IDataTemplate>>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.ContentControl.ContentTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.ContentControl.ContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveContentTemplateChanged(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.ContentControl.ContentTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.ContentControl.ContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnContentTemplateChanged<T>(this T obj, Action<Avalonia.Controls.ContentControl, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.ContentControl.ContentTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HorizontalContentAlignment<T>(this T obj, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HorizontalContentAlignment<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ContentControl
    {
        var descriptor = Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HorizontalContentAlignment<T>(
        this T obj,
        IObservable<Avalonia.Layout.HorizontalAlignment> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ContentControl
    {
        var descriptor = Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindHorizontalContentAlignment(
        this Avalonia.Controls.ContentControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Layout.HorizontalAlignment> ObserveHorizontalContentAlignment(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnHorizontalContentAlignment<T>(this T obj, Action<Avalonia.Controls.ContentControl, IObservable<Avalonia.Layout.HorizontalAlignment>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Layout.HorizontalAlignment>> ObserveBindingHorizontalContentAlignment(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingHorizontalContentAlignment<T>(this T obj, Action<Avalonia.Controls.ContentControl, IObservable<BindingValue<Avalonia.Layout.HorizontalAlignment>>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveHorizontalContentAlignmentChanged(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnHorizontalContentAlignmentChanged<T>(this T obj, Action<Avalonia.Controls.ContentControl, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/> property value to <see cref="Avalonia.Layout.HorizontalAlignment.Stretch"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HorizontalContentAlignmentStretch<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Stretch;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/> property value to <see cref="Avalonia.Layout.HorizontalAlignment.Left"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HorizontalContentAlignmentLeft<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Left;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/> property value to <see cref="Avalonia.Layout.HorizontalAlignment.Center"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HorizontalContentAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Center;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty"/> property value to <see cref="Avalonia.Layout.HorizontalAlignment.Right"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HorizontalContentAlignmentRight<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Right;
        return obj;
    }

    // Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VerticalContentAlignment<T>(this T obj, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VerticalContentAlignment<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ContentControl
    {
        var descriptor = Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VerticalContentAlignment<T>(
        this T obj,
        IObservable<Avalonia.Layout.VerticalAlignment> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ContentControl
    {
        var descriptor = Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindVerticalContentAlignment(
        this Avalonia.Controls.ContentControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Layout.VerticalAlignment> ObserveVerticalContentAlignment(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnVerticalContentAlignment<T>(this T obj, Action<Avalonia.Controls.ContentControl, IObservable<Avalonia.Layout.VerticalAlignment>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Layout.VerticalAlignment>> ObserveBindingVerticalContentAlignment(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingVerticalContentAlignment<T>(this T obj, Action<Avalonia.Controls.ContentControl, IObservable<BindingValue<Avalonia.Layout.VerticalAlignment>>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveVerticalContentAlignmentChanged(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnVerticalContentAlignmentChanged<T>(this T obj, Action<Avalonia.Controls.ContentControl, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/> property value to <see cref="Avalonia.Layout.VerticalAlignment.Stretch"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VerticalContentAlignmentStretch<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Stretch;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/> property value to <see cref="Avalonia.Layout.VerticalAlignment.Top"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VerticalContentAlignmentTop<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Top;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/> property value to <see cref="Avalonia.Layout.VerticalAlignment.Center"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VerticalContentAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Center;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty"/> property value to <see cref="Avalonia.Layout.VerticalAlignment.Bottom"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VerticalContentAlignmentBottom<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Bottom;
        return obj;
    }
}
