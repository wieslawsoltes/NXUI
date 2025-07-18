// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.ColorPreviewer"/> class property extension methods.
/// </summary>
public static partial class ColorPreviewerExtensions
{
    // Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HsvColor<T>(this T obj, Avalonia.Media.HsvColor value) where T : Avalonia.Controls.Primitives.ColorPreviewer
    {
        obj[Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HsvColor<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ColorPreviewer
    {
        var descriptor = Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HsvColor<T>(
        this T obj,
        IObservable<Avalonia.Media.HsvColor> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ColorPreviewer
    {
        var descriptor = Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindHsvColor(
        this Avalonia.Controls.Primitives.ColorPreviewer obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.HsvColor> ObserveHsvColor(this Avalonia.Controls.Primitives.ColorPreviewer obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnHsvColor<T>(this T obj, Action<Avalonia.Controls.Primitives.ColorPreviewer, IObservable<Avalonia.Media.HsvColor>> handler) where T : Avalonia.Controls.Primitives.ColorPreviewer
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Media.HsvColor>> ObserveBindingHsvColor(this Avalonia.Controls.Primitives.ColorPreviewer obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingHsvColor<T>(this T obj, Action<Avalonia.Controls.Primitives.ColorPreviewer, IObservable<BindingValue<Avalonia.Media.HsvColor>>> handler) where T : Avalonia.Controls.Primitives.ColorPreviewer
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveHsvColorChanged(this Avalonia.Controls.Primitives.ColorPreviewer obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnHsvColorChanged<T>(this T obj, Action<Avalonia.Controls.Primitives.ColorPreviewer, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.Primitives.ColorPreviewer
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsAccentColorsVisible<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.ColorPreviewer
    {
        obj[Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsAccentColorsVisible<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ColorPreviewer
    {
        var descriptor = Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsAccentColorsVisible<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ColorPreviewer
    {
        var descriptor = Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsAccentColorsVisible(
        this Avalonia.Controls.Primitives.ColorPreviewer obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsAccentColorsVisible(this Avalonia.Controls.Primitives.ColorPreviewer obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsAccentColorsVisible<T>(this T obj, Action<Avalonia.Controls.Primitives.ColorPreviewer, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Primitives.ColorPreviewer
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Boolean>> ObserveBindingIsAccentColorsVisible(this Avalonia.Controls.Primitives.ColorPreviewer obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBindingIsAccentColorsVisible<T>(this T obj, Action<Avalonia.Controls.Primitives.ColorPreviewer, IObservable<BindingValue<System.Boolean>>> handler) where T : Avalonia.Controls.Primitives.ColorPreviewer
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveIsAccentColorsVisibleChanged(this Avalonia.Controls.Primitives.ColorPreviewer obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsAccentColorsVisibleChanged<T>(this T obj, Action<Avalonia.Controls.Primitives.ColorPreviewer, IObservable<AvaloniaPropertyChangedEventArgs>> handler) where T : Avalonia.Controls.Primitives.ColorPreviewer
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty);
        handler(obj, observable);
        return obj;
    }
}
