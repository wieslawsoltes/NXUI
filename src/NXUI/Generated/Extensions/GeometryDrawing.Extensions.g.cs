// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.GeometryDrawing"/> class property extension methods.
/// </summary>
public static partial class GeometryDrawingExtensions
{
    // Avalonia.Media.GeometryDrawing.GeometryProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.GeometryDrawing.GeometryProperty"/> value on an object of type <see cref="Avalonia.Media.GeometryDrawing"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing obj, Avalonia.Media.Geometry value)
    {
        obj[Avalonia.Media.GeometryDrawing.GeometryProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.GeometryDrawing.GeometryProperty"/> on an object of type <see cref="Avalonia.Media.GeometryDrawing"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.GeometryDrawing Geometry(
        this Avalonia.Media.GeometryDrawing obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.GeometryDrawing.GeometryProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.GeometryDrawing.GeometryProperty"/> on an object of type <see cref="Avalonia.Media.GeometryDrawing"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.GeometryDrawing Geometry(
        this Avalonia.Media.GeometryDrawing obj,
        IObservable<Avalonia.Media.Geometry> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.GeometryDrawing.GeometryProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.GeometryDrawing.GeometryProperty"/> binding on an object of type <see cref="Avalonia.Media.GeometryDrawing"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.GeometryDrawing.GeometryProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindGeometry(
        this Avalonia.Media.GeometryDrawing obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.GeometryDrawing.GeometryProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.GeometryDrawing.GeometryProperty"/> on an object of type <see cref="Avalonia.Media.GeometryDrawing"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Media.Geometry> ObserveGeometry(this Avalonia.Media.GeometryDrawing obj)
    {
        return obj.GetObservable(Avalonia.Media.GeometryDrawing.GeometryProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.GeometryDrawing.GeometryProperty"/> property on an object of type <see cref="Avalonia.Media.GeometryDrawing"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.GeometryDrawing OnGeometry(this Avalonia.Media.GeometryDrawing obj, Action<Avalonia.Media.GeometryDrawing, IObservable<Avalonia.Media.Geometry>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.GeometryDrawing.GeometryProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.GeometryDrawing.GeometryProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Media.Geometry>> ObserveBindingGeometry(this Avalonia.Media.GeometryDrawing obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.GeometryDrawing.GeometryProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.GeometryDrawing.GeometryProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.GeometryDrawing OnBindingGeometry(this Avalonia.Media.GeometryDrawing obj, Action<Avalonia.Media.GeometryDrawing, IObservable<BindingValue<Avalonia.Media.Geometry>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.GeometryDrawing.GeometryProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.GeometryDrawing.GeometryProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveGeometryChanged(this Avalonia.Media.GeometryDrawing obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.GeometryDrawing.GeometryProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.GeometryDrawing.GeometryProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.GeometryDrawing OnGeometryChanged(this Avalonia.Media.GeometryDrawing obj, Action<Avalonia.Media.GeometryDrawing, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.GeometryDrawing.GeometryProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.GeometryDrawing.BrushProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.GeometryDrawing.BrushProperty"/> value on an object of type <see cref="Avalonia.Media.GeometryDrawing"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing obj, Avalonia.Media.IBrush value)
    {
        obj[Avalonia.Media.GeometryDrawing.BrushProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.GeometryDrawing.BrushProperty"/> on an object of type <see cref="Avalonia.Media.GeometryDrawing"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.GeometryDrawing Brush(
        this Avalonia.Media.GeometryDrawing obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.GeometryDrawing.BrushProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.GeometryDrawing.BrushProperty"/> on an object of type <see cref="Avalonia.Media.GeometryDrawing"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.GeometryDrawing Brush(
        this Avalonia.Media.GeometryDrawing obj,
        IObservable<Avalonia.Media.IBrush> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.GeometryDrawing.BrushProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.GeometryDrawing.BrushProperty"/> binding on an object of type <see cref="Avalonia.Media.GeometryDrawing"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.GeometryDrawing.BrushProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindBrush(
        this Avalonia.Media.GeometryDrawing obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.GeometryDrawing.BrushProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.GeometryDrawing.BrushProperty"/> on an object of type <see cref="Avalonia.Media.GeometryDrawing"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Media.IBrush> ObserveBrush(this Avalonia.Media.GeometryDrawing obj)
    {
        return obj.GetObservable(Avalonia.Media.GeometryDrawing.BrushProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.GeometryDrawing.BrushProperty"/> property on an object of type <see cref="Avalonia.Media.GeometryDrawing"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.GeometryDrawing OnBrush(this Avalonia.Media.GeometryDrawing obj, Action<Avalonia.Media.GeometryDrawing, IObservable<Avalonia.Media.IBrush>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.GeometryDrawing.BrushProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.GeometryDrawing.BrushProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Media.IBrush>> ObserveBindingBrush(this Avalonia.Media.GeometryDrawing obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.GeometryDrawing.BrushProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.GeometryDrawing.BrushProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.GeometryDrawing OnBindingBrush(this Avalonia.Media.GeometryDrawing obj, Action<Avalonia.Media.GeometryDrawing, IObservable<BindingValue<Avalonia.Media.IBrush>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.GeometryDrawing.BrushProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.GeometryDrawing.BrushProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveBrushChanged(this Avalonia.Media.GeometryDrawing obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.GeometryDrawing.BrushProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.GeometryDrawing.BrushProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.GeometryDrawing OnBrushChanged(this Avalonia.Media.GeometryDrawing obj, Action<Avalonia.Media.GeometryDrawing, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.GeometryDrawing.BrushProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.GeometryDrawing.PenProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.GeometryDrawing.PenProperty"/> value on an object of type <see cref="Avalonia.Media.GeometryDrawing"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing obj, Avalonia.Media.IPen value)
    {
        obj[Avalonia.Media.GeometryDrawing.PenProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.GeometryDrawing.PenProperty"/> on an object of type <see cref="Avalonia.Media.GeometryDrawing"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.GeometryDrawing Pen(
        this Avalonia.Media.GeometryDrawing obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.GeometryDrawing.PenProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.GeometryDrawing.PenProperty"/> on an object of type <see cref="Avalonia.Media.GeometryDrawing"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.GeometryDrawing Pen(
        this Avalonia.Media.GeometryDrawing obj,
        IObservable<Avalonia.Media.IPen> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.GeometryDrawing.PenProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.GeometryDrawing.PenProperty"/> binding on an object of type <see cref="Avalonia.Media.GeometryDrawing"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.GeometryDrawing.PenProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPen(
        this Avalonia.Media.GeometryDrawing obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.GeometryDrawing.PenProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.GeometryDrawing.PenProperty"/> on an object of type <see cref="Avalonia.Media.GeometryDrawing"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Media.IPen> ObservePen(this Avalonia.Media.GeometryDrawing obj)
    {
        return obj.GetObservable(Avalonia.Media.GeometryDrawing.PenProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.GeometryDrawing.PenProperty"/> property on an object of type <see cref="Avalonia.Media.GeometryDrawing"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.GeometryDrawing OnPen(this Avalonia.Media.GeometryDrawing obj, Action<Avalonia.Media.GeometryDrawing, IObservable<Avalonia.Media.IPen>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.GeometryDrawing.PenProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.GeometryDrawing.PenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Media.IPen>> ObserveBindingPen(this Avalonia.Media.GeometryDrawing obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.GeometryDrawing.PenProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.GeometryDrawing.PenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.GeometryDrawing OnBindingPen(this Avalonia.Media.GeometryDrawing obj, Action<Avalonia.Media.GeometryDrawing, IObservable<BindingValue<Avalonia.Media.IPen>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.GeometryDrawing.PenProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.GeometryDrawing.PenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObservePenChanged(this Avalonia.Media.GeometryDrawing obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.GeometryDrawing.PenProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.GeometryDrawing.PenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.GeometryDrawing OnPenChanged(this Avalonia.Media.GeometryDrawing obj, Action<Avalonia.Media.GeometryDrawing, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.GeometryDrawing.PenProperty);
        handler(obj, observable);
        return obj;
    }
}
