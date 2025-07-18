// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.DataValidationErrors"/> class property extension methods.
/// </summary>
public static partial class DataValidationErrorsExtensions
{
    // Avalonia.Controls.DataValidationErrors.ErrorsProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.DataValidationErrors.ErrorsProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Errors<T>(this T obj, System.Collections.Generic.IEnumerable<System.Object> value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.DataValidationErrors.ErrorsProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataValidationErrors.ErrorsProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Errors<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.ErrorsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataValidationErrors.ErrorsProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Errors<T>(
        this T obj,
        IObservable<System.Collections.Generic.IEnumerable<System.Object>> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.ErrorsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.DataValidationErrors.ErrorsProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.DataValidationErrors.ErrorsProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindErrors(
        this Avalonia.Controls.Control obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.ErrorsProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.DataValidationErrors.ErrorsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Collections.Generic.IEnumerable<System.Object>> ObserveErrors(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.DataValidationErrors.ErrorsProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.DataValidationErrors.ErrorsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnErrors<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<System.Collections.Generic.IEnumerable<System.Object>>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.DataValidationErrors.ErrorsProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.DataValidationErrors.ErrorsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Collections.Generic.IEnumerable<System.Object>>> ObserveBindingErrors(this Avalonia.Controls.Control obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.DataValidationErrors.ErrorsProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.DataValidationErrors.ErrorsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingErrors<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<BindingValue<System.Collections.Generic.IEnumerable<System.Object>>>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.DataValidationErrors.ErrorsProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.DataValidationErrors.ErrorsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveErrorsChanged(this Avalonia.Controls.Control obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.DataValidationErrors.ErrorsProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.DataValidationErrors.ErrorsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnErrorsChanged<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.DataValidationErrors.ErrorsProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.DataValidationErrors.HasErrorsProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.DataValidationErrors.HasErrorsProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HasErrors<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.DataValidationErrors.HasErrorsProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataValidationErrors.HasErrorsProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HasErrors<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.HasErrorsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataValidationErrors.HasErrorsProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HasErrors<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.HasErrorsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.DataValidationErrors.HasErrorsProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.DataValidationErrors.HasErrorsProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindHasErrors(
        this Avalonia.Controls.Control obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.HasErrorsProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.DataValidationErrors.HasErrorsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveHasErrors(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.DataValidationErrors.HasErrorsProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.DataValidationErrors.HasErrorsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnHasErrors<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.DataValidationErrors.HasErrorsProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.DataValidationErrors.HasErrorsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Boolean>> ObserveBindingHasErrors(this Avalonia.Controls.Control obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.DataValidationErrors.HasErrorsProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.DataValidationErrors.HasErrorsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingHasErrors<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<BindingValue<System.Boolean>>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.DataValidationErrors.HasErrorsProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.DataValidationErrors.HasErrorsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveHasErrorsChanged(this Avalonia.Controls.Control obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.DataValidationErrors.HasErrorsProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.DataValidationErrors.HasErrorsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnHasErrorsChanged<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.DataValidationErrors.HasErrorsProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.DataValidationErrors.ErrorConverterProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.DataValidationErrors.ErrorConverterProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ErrorConverter<T>(this T obj, System.Func<System.Object,System.Object> value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.DataValidationErrors.ErrorConverterProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataValidationErrors.ErrorConverterProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ErrorConverter<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.ErrorConverterProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataValidationErrors.ErrorConverterProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ErrorConverter<T>(
        this T obj,
        IObservable<System.Func<System.Object,System.Object>> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.ErrorConverterProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.DataValidationErrors.ErrorConverterProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.DataValidationErrors.ErrorConverterProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindErrorConverter(
        this Avalonia.Controls.Control obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.ErrorConverterProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.DataValidationErrors.ErrorConverterProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Func<System.Object,System.Object>> ObserveErrorConverter(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.DataValidationErrors.ErrorConverterProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.DataValidationErrors.ErrorConverterProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnErrorConverter<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<System.Func<System.Object,System.Object>>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.DataValidationErrors.ErrorConverterProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.DataValidationErrors.ErrorConverterProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Func<System.Object,System.Object>>> ObserveBindingErrorConverter(this Avalonia.Controls.Control obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.DataValidationErrors.ErrorConverterProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.DataValidationErrors.ErrorConverterProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingErrorConverter<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<BindingValue<System.Func<System.Object,System.Object>>>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.DataValidationErrors.ErrorConverterProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.DataValidationErrors.ErrorConverterProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveErrorConverterChanged(this Avalonia.Controls.Control obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.DataValidationErrors.ErrorConverterProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.DataValidationErrors.ErrorConverterProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnErrorConverterChanged<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.DataValidationErrors.ErrorConverterProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ErrorTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.DataValidationErrors
    {
        obj[Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ErrorTemplate<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.DataValidationErrors
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ErrorTemplate<T>(
        this T obj,
        IObservable<Avalonia.Controls.Templates.IDataTemplate> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.DataValidationErrors
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindErrorTemplate(
        this Avalonia.Controls.DataValidationErrors obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveErrorTemplate(this Avalonia.Controls.DataValidationErrors obj)
    {
        return obj.GetObservable(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnErrorTemplate<T>(this T obj, Action<Avalonia.Controls.DataValidationErrors, IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler) where T : Avalonia.Controls.DataValidationErrors
    {
        var observable = obj.GetObservable(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Controls.Templates.IDataTemplate>> ObserveBindingErrorTemplate(this Avalonia.Controls.DataValidationErrors obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingErrorTemplate<T>(this T obj, Action<Avalonia.Controls.DataValidationErrors, IObservable<BindingValue<Avalonia.Controls.Templates.IDataTemplate>>> handler) where T : Avalonia.Controls.DataValidationErrors
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveErrorTemplateChanged(this Avalonia.Controls.DataValidationErrors obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnErrorTemplateChanged<T>(this T obj, Action<Avalonia.Controls.DataValidationErrors, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.DataValidationErrors
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.DataValidationErrors.OwnerProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.DataValidationErrors.OwnerProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Owner<T>(this T obj, Avalonia.Controls.Control value) where T : Avalonia.Controls.DataValidationErrors
    {
        obj[Avalonia.Controls.DataValidationErrors.OwnerProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataValidationErrors.OwnerProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Owner<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.DataValidationErrors
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.OwnerProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DataValidationErrors.OwnerProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Owner<T>(
        this T obj,
        IObservable<Avalonia.Controls.Control> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.DataValidationErrors
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.OwnerProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.DataValidationErrors.OwnerProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.DataValidationErrors.OwnerProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOwner(
        this Avalonia.Controls.DataValidationErrors obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.DataValidationErrors.OwnerProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.DataValidationErrors.OwnerProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Control> ObserveOwner(this Avalonia.Controls.DataValidationErrors obj)
    {
        return obj.GetObservable(Avalonia.Controls.DataValidationErrors.OwnerProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.DataValidationErrors.OwnerProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOwner<T>(this T obj, Action<Avalonia.Controls.DataValidationErrors, IObservable<Avalonia.Controls.Control>> handler) where T : Avalonia.Controls.DataValidationErrors
    {
        var observable = obj.GetObservable(Avalonia.Controls.DataValidationErrors.OwnerProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.DataValidationErrors.OwnerProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Controls.Control>> ObserveBindingOwner(this Avalonia.Controls.DataValidationErrors obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.DataValidationErrors.OwnerProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.DataValidationErrors.OwnerProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingOwner<T>(this T obj, Action<Avalonia.Controls.DataValidationErrors, IObservable<BindingValue<Avalonia.Controls.Control>>> handler) where T : Avalonia.Controls.DataValidationErrors
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.DataValidationErrors.OwnerProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.DataValidationErrors.OwnerProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveOwnerChanged(this Avalonia.Controls.DataValidationErrors obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.DataValidationErrors.OwnerProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.DataValidationErrors.OwnerProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOwnerChanged<T>(this T obj, Action<Avalonia.Controls.DataValidationErrors, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.DataValidationErrors
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.DataValidationErrors.OwnerProperty);
        handler(obj, observable);
        return obj;
    }
}
