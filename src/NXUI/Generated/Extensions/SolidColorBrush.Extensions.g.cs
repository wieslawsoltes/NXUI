// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.SolidColorBrush"/> class property extension methods.
/// </summary>
public static partial class SolidColorBrushExtensions
{
    // Avalonia.Media.SolidColorBrush.ColorProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/> value on an object of type <see cref="Avalonia.Media.SolidColorBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush obj, Avalonia.Media.Color value)
    {
        obj[Avalonia.Media.SolidColorBrush.ColorProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/> on an object of type <see cref="Avalonia.Media.SolidColorBrush"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.SolidColorBrush Color(
        this Avalonia.Media.SolidColorBrush obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.SolidColorBrush.ColorProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/> on an object of type <see cref="Avalonia.Media.SolidColorBrush"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.SolidColorBrush Color(
        this Avalonia.Media.SolidColorBrush obj,
        IObservable<Avalonia.Media.Color> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.SolidColorBrush.ColorProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/> binding on an object of type <see cref="Avalonia.Media.SolidColorBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindColor(
        this Avalonia.Media.SolidColorBrush obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.SolidColorBrush.ColorProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/> on an object of type <see cref="Avalonia.Media.SolidColorBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Media.Color> ObserveColor(this Avalonia.Media.SolidColorBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.SolidColorBrush.ColorProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/> property on an object of type <see cref="Avalonia.Media.SolidColorBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.SolidColorBrush OnColor(this Avalonia.Media.SolidColorBrush obj, Action<Avalonia.Media.SolidColorBrush, IObservable<Avalonia.Media.Color>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.SolidColorBrush.ColorProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Media.Color>> ObserveBindingColor(this Avalonia.Media.SolidColorBrush obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.SolidColorBrush.ColorProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.SolidColorBrush OnBindingColor(this Avalonia.Media.SolidColorBrush obj, Action<Avalonia.Media.SolidColorBrush, IObservable<BindingValue<Avalonia.Media.Color>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.SolidColorBrush.ColorProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveColorChanged(this Avalonia.Media.SolidColorBrush obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.SolidColorBrush.ColorProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.SolidColorBrush.ColorProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.SolidColorBrush OnColorChanged(this Avalonia.Media.SolidColorBrush obj, Action<Avalonia.Media.SolidColorBrush, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.SolidColorBrush.ColorProperty);
        handler(obj, observable);
        return obj;
    }
}
