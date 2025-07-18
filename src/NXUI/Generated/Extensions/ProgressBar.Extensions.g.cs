// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.ProgressBar"/> class property extension methods.
/// </summary>
public static partial class ProgressBarExtensions
{
    // Avalonia.Controls.ProgressBar.IsIndeterminateProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ProgressBar.IsIndeterminateProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsIndeterminate<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.IsIndeterminateProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ProgressBar.IsIndeterminateProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsIndeterminate<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ProgressBar
    {
        var descriptor = Avalonia.Controls.ProgressBar.IsIndeterminateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ProgressBar.IsIndeterminateProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsIndeterminate<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ProgressBar
    {
        var descriptor = Avalonia.Controls.ProgressBar.IsIndeterminateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ProgressBar.IsIndeterminateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ProgressBar.IsIndeterminateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsIndeterminate(
        this Avalonia.Controls.ProgressBar obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ProgressBar.IsIndeterminateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ProgressBar.IsIndeterminateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsIndeterminate(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.ProgressBar.IsIndeterminateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ProgressBar.IsIndeterminateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsIndeterminate<T>(this T obj, Action<Avalonia.Controls.ProgressBar, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.ProgressBar.IsIndeterminateProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.ProgressBar.IsIndeterminateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Boolean>> ObserveBindingIsIndeterminate(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.ProgressBar.IsIndeterminateProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.ProgressBar.IsIndeterminateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingIsIndeterminate<T>(this T obj, Action<Avalonia.Controls.ProgressBar, IObservable<BindingValue<System.Boolean>>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.ProgressBar.IsIndeterminateProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.ProgressBar.IsIndeterminateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveIsIndeterminateChanged(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.ProgressBar.IsIndeterminateProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.ProgressBar.IsIndeterminateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsIndeterminateChanged<T>(this T obj, Action<Avalonia.Controls.ProgressBar, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.ProgressBar.IsIndeterminateProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ProgressBar.ShowProgressTextProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ProgressBar.ShowProgressTextProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShowProgressText<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.ShowProgressTextProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ProgressBar.ShowProgressTextProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShowProgressText<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ProgressBar
    {
        var descriptor = Avalonia.Controls.ProgressBar.ShowProgressTextProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ProgressBar.ShowProgressTextProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShowProgressText<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ProgressBar
    {
        var descriptor = Avalonia.Controls.ProgressBar.ShowProgressTextProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ProgressBar.ShowProgressTextProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ProgressBar.ShowProgressTextProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindShowProgressText(
        this Avalonia.Controls.ProgressBar obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ProgressBar.ShowProgressTextProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ProgressBar.ShowProgressTextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveShowProgressText(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.ProgressBar.ShowProgressTextProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ProgressBar.ShowProgressTextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnShowProgressText<T>(this T obj, Action<Avalonia.Controls.ProgressBar, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.ProgressBar.ShowProgressTextProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.ProgressBar.ShowProgressTextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Boolean>> ObserveBindingShowProgressText(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.ProgressBar.ShowProgressTextProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.ProgressBar.ShowProgressTextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingShowProgressText<T>(this T obj, Action<Avalonia.Controls.ProgressBar, IObservable<BindingValue<System.Boolean>>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.ProgressBar.ShowProgressTextProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.ProgressBar.ShowProgressTextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveShowProgressTextChanged(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.ProgressBar.ShowProgressTextProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.ProgressBar.ShowProgressTextProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnShowProgressTextChanged<T>(this T obj, Action<Avalonia.Controls.ProgressBar, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.ProgressBar.ShowProgressTextProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ProgressBar.ProgressTextFormatProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ProgressBar.ProgressTextFormatProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ProgressTextFormat<T>(this T obj, System.String value) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.ProgressTextFormatProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ProgressBar.ProgressTextFormatProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ProgressTextFormat<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ProgressBar
    {
        var descriptor = Avalonia.Controls.ProgressBar.ProgressTextFormatProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ProgressBar.ProgressTextFormatProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ProgressTextFormat<T>(
        this T obj,
        IObservable<System.String> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ProgressBar
    {
        var descriptor = Avalonia.Controls.ProgressBar.ProgressTextFormatProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ProgressBar.ProgressTextFormatProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ProgressBar.ProgressTextFormatProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindProgressTextFormat(
        this Avalonia.Controls.ProgressBar obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ProgressBar.ProgressTextFormatProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ProgressBar.ProgressTextFormatProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.String> ObserveProgressTextFormat(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ProgressBar.ProgressTextFormatProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnProgressTextFormat<T>(this T obj, Action<Avalonia.Controls.ProgressBar, IObservable<System.String>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.ProgressBar.ProgressTextFormatProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.String>> ObserveBindingProgressTextFormat(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.ProgressBar.ProgressTextFormatProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingProgressTextFormat<T>(this T obj, Action<Avalonia.Controls.ProgressBar, IObservable<BindingValue<System.String>>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.ProgressBar.ProgressTextFormatProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveProgressTextFormatChanged(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.ProgressBar.ProgressTextFormatProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnProgressTextFormatChanged<T>(this T obj, Action<Avalonia.Controls.ProgressBar, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ProgressBar.OrientationProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Orientation<T>(this T obj, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.OrientationProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Orientation<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ProgressBar
    {
        var descriptor = Avalonia.Controls.ProgressBar.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Orientation<T>(
        this T obj,
        IObservable<Avalonia.Layout.Orientation> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ProgressBar
    {
        var descriptor = Avalonia.Controls.ProgressBar.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOrientation(
        this Avalonia.Controls.ProgressBar obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ProgressBar.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Layout.Orientation> ObserveOrientation(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.ProgressBar.OrientationProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOrientation<T>(this T obj, Action<Avalonia.Controls.ProgressBar, IObservable<Avalonia.Layout.Orientation>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.ProgressBar.OrientationProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Layout.Orientation>> ObserveBindingOrientation(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.ProgressBar.OrientationProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingOrientation<T>(this T obj, Action<Avalonia.Controls.ProgressBar, IObservable<BindingValue<Avalonia.Layout.Orientation>>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.ProgressBar.OrientationProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveOrientationChanged(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.ProgressBar.OrientationProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOrientationChanged<T>(this T obj, Action<Avalonia.Controls.ProgressBar, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.ProgressBar.OrientationProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/> property value to <see cref="Avalonia.Layout.Orientation.Horizontal"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationHorizontal<T>(this T obj) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.OrientationProperty] = Avalonia.Layout.Orientation.Horizontal;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ProgressBar.OrientationProperty"/> property value to <see cref="Avalonia.Layout.Orientation.Vertical"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationVertical<T>(this T obj) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.OrientationProperty] = Avalonia.Layout.Orientation.Vertical;
        return obj;
    }

    // Avalonia.Controls.ProgressBar.PercentageProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ProgressBar.PercentageProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ProgressBar.PercentageProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPercentage(
        this Avalonia.Controls.ProgressBar obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ProgressBar.PercentageProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ProgressBar.PercentageProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObservePercentage(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.ProgressBar.PercentageProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ProgressBar.PercentageProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.ProgressBar OnPercentage(this Avalonia.Controls.ProgressBar obj, Action<Avalonia.Controls.ProgressBar, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.ProgressBar.PercentageProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.ProgressBar.PercentageProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Double>> ObserveBindingPercentage(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.ProgressBar.PercentageProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.ProgressBar.PercentageProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.ProgressBar OnBindingPercentage(this Avalonia.Controls.ProgressBar obj, Action<Avalonia.Controls.ProgressBar, IObservable<BindingValue<System.Double>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.ProgressBar.PercentageProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.ProgressBar.PercentageProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObservePercentageChanged(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.ProgressBar.PercentageProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.ProgressBar.PercentageProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.ProgressBar OnPercentageChanged(this Avalonia.Controls.ProgressBar obj, Action<Avalonia.Controls.ProgressBar, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.ProgressBar.PercentageProperty);
        handler(obj, observable);
        return obj;
    }
}
