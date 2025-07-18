// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.StyledElement"/> class property extension methods.
/// </summary>
public static partial class StyledElementExtensions
{
    // Avalonia.StyledElement.DataContextProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.StyledElement.DataContextProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DataContext<T>(this T obj, System.Object value) where T : Avalonia.StyledElement
    {
        obj[Avalonia.StyledElement.DataContextProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.StyledElement.DataContextProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DataContext<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.StyledElement
    {
        var descriptor = Avalonia.StyledElement.DataContextProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.StyledElement.DataContextProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DataContext<T>(
        this T obj,
        IObservable<System.Object> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.StyledElement
    {
        var descriptor = Avalonia.StyledElement.DataContextProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.StyledElement.DataContextProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.StyledElement.DataContextProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindDataContext(
        this Avalonia.StyledElement obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.StyledElement.DataContextProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.StyledElement.DataContextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Object> ObserveDataContext(this Avalonia.StyledElement obj)
    {
        return obj.GetObservable(Avalonia.StyledElement.DataContextProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.StyledElement.DataContextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnDataContext<T>(this T obj, Action<Avalonia.StyledElement, IObservable<System.Object>> handler) where T : Avalonia.StyledElement
    {
        var observable = obj.GetObservable(Avalonia.StyledElement.DataContextProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.StyledElement.DataContextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Object>> ObserveBindingDataContext(this Avalonia.StyledElement obj)
    {
        return obj.GetBindingObservable(Avalonia.StyledElement.DataContextProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.StyledElement.DataContextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingDataContext<T>(this T obj, Action<Avalonia.StyledElement, IObservable<BindingValue<System.Object>>> handler) where T : Avalonia.StyledElement
    {
        var observable = obj.GetBindingObservable(Avalonia.StyledElement.DataContextProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.StyledElement.DataContextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveDataContextChanged(this Avalonia.StyledElement obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.StyledElement.DataContextProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.StyledElement.DataContextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnDataContextChanged<T>(this T obj, Action<Avalonia.StyledElement, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.StyledElement
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.StyledElement.DataContextProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.StyledElement.NameProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.StyledElement.NameProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Name<T>(this T obj, System.String value) where T : Avalonia.StyledElement
    {
        obj[Avalonia.StyledElement.NameProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.StyledElement.NameProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Name<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.StyledElement
    {
        var descriptor = Avalonia.StyledElement.NameProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.StyledElement.NameProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Name<T>(
        this T obj,
        IObservable<System.String> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.StyledElement
    {
        var descriptor = Avalonia.StyledElement.NameProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.StyledElement.NameProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.StyledElement.NameProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindName(
        this Avalonia.StyledElement obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.StyledElement.NameProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.StyledElement.NameProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.String> ObserveName(this Avalonia.StyledElement obj)
    {
        return obj.GetObservable(Avalonia.StyledElement.NameProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.StyledElement.NameProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnName<T>(this T obj, Action<Avalonia.StyledElement, IObservable<System.String>> handler) where T : Avalonia.StyledElement
    {
        var observable = obj.GetObservable(Avalonia.StyledElement.NameProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.StyledElement.NameProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.String>> ObserveBindingName(this Avalonia.StyledElement obj)
    {
        return obj.GetBindingObservable(Avalonia.StyledElement.NameProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.StyledElement.NameProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingName<T>(this T obj, Action<Avalonia.StyledElement, IObservable<BindingValue<System.String>>> handler) where T : Avalonia.StyledElement
    {
        var observable = obj.GetBindingObservable(Avalonia.StyledElement.NameProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.StyledElement.NameProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveNameChanged(this Avalonia.StyledElement obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.StyledElement.NameProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.StyledElement.NameProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnNameChanged<T>(this T obj, Action<Avalonia.StyledElement, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.StyledElement
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.StyledElement.NameProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.StyledElement.ParentProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.StyledElement.ParentProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.StyledElement.ParentProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindParent(
        this Avalonia.StyledElement obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.StyledElement.ParentProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.StyledElement.ParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.StyledElement> ObserveParent(this Avalonia.StyledElement obj)
    {
        return obj.GetObservable(Avalonia.StyledElement.ParentProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.StyledElement.ParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.StyledElement OnParent(this Avalonia.StyledElement obj, Action<Avalonia.StyledElement, IObservable<Avalonia.StyledElement>> handler)
    {
        var observable = obj.GetObservable(Avalonia.StyledElement.ParentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.StyledElement.ParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.StyledElement>> ObserveBindingParent(this Avalonia.StyledElement obj)
    {
        return obj.GetBindingObservable(Avalonia.StyledElement.ParentProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.StyledElement.ParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.StyledElement OnBindingParent(this Avalonia.StyledElement obj, Action<Avalonia.StyledElement, IObservable<BindingValue<Avalonia.StyledElement>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.StyledElement.ParentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.StyledElement.ParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveParentChanged(this Avalonia.StyledElement obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.StyledElement.ParentProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.StyledElement.ParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.StyledElement OnParentChanged(this Avalonia.StyledElement obj, Action<Avalonia.StyledElement, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.StyledElement.ParentProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.StyledElement.TemplatedParentProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.StyledElement.TemplatedParentProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.StyledElement.TemplatedParentProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTemplatedParent(
        this Avalonia.StyledElement obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.StyledElement.TemplatedParentProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.StyledElement.TemplatedParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.AvaloniaObject> ObserveTemplatedParent(this Avalonia.StyledElement obj)
    {
        return obj.GetObservable(Avalonia.StyledElement.TemplatedParentProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.StyledElement.TemplatedParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.StyledElement OnTemplatedParent(this Avalonia.StyledElement obj, Action<Avalonia.StyledElement, IObservable<Avalonia.AvaloniaObject>> handler)
    {
        var observable = obj.GetObservable(Avalonia.StyledElement.TemplatedParentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.StyledElement.TemplatedParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.AvaloniaObject>> ObserveBindingTemplatedParent(this Avalonia.StyledElement obj)
    {
        return obj.GetBindingObservable(Avalonia.StyledElement.TemplatedParentProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.StyledElement.TemplatedParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.StyledElement OnBindingTemplatedParent(this Avalonia.StyledElement obj, Action<Avalonia.StyledElement, IObservable<BindingValue<Avalonia.AvaloniaObject>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.StyledElement.TemplatedParentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.StyledElement.TemplatedParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveTemplatedParentChanged(this Avalonia.StyledElement obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.StyledElement.TemplatedParentProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.StyledElement.TemplatedParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.StyledElement OnTemplatedParentChanged(this Avalonia.StyledElement obj, Action<Avalonia.StyledElement, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.StyledElement.TemplatedParentProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.StyledElement.ThemeProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.StyledElement.ThemeProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Theme<T>(this T obj, Avalonia.Styling.ControlTheme value) where T : Avalonia.StyledElement
    {
        obj[Avalonia.StyledElement.ThemeProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.StyledElement.ThemeProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Theme<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.StyledElement
    {
        var descriptor = Avalonia.StyledElement.ThemeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.StyledElement.ThemeProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Theme<T>(
        this T obj,
        IObservable<Avalonia.Styling.ControlTheme> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.StyledElement
    {
        var descriptor = Avalonia.StyledElement.ThemeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.StyledElement.ThemeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.StyledElement.ThemeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTheme(
        this Avalonia.StyledElement obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.StyledElement.ThemeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.StyledElement.ThemeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Styling.ControlTheme> ObserveTheme(this Avalonia.StyledElement obj)
    {
        return obj.GetObservable(Avalonia.StyledElement.ThemeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.StyledElement.ThemeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnTheme<T>(this T obj, Action<Avalonia.StyledElement, IObservable<Avalonia.Styling.ControlTheme>> handler) where T : Avalonia.StyledElement
    {
        var observable = obj.GetObservable(Avalonia.StyledElement.ThemeProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.StyledElement.ThemeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Styling.ControlTheme>> ObserveBindingTheme(this Avalonia.StyledElement obj)
    {
        return obj.GetBindingObservable(Avalonia.StyledElement.ThemeProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.StyledElement.ThemeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingTheme<T>(this T obj, Action<Avalonia.StyledElement, IObservable<BindingValue<Avalonia.Styling.ControlTheme>>> handler) where T : Avalonia.StyledElement
    {
        var observable = obj.GetBindingObservable(Avalonia.StyledElement.ThemeProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.StyledElement.ThemeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveThemeChanged(this Avalonia.StyledElement obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.StyledElement.ThemeProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.StyledElement.ThemeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnThemeChanged<T>(this T obj, Action<Avalonia.StyledElement, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.StyledElement
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.StyledElement.ThemeProperty);
        handler(obj, observable);
        return obj;
    }
}
