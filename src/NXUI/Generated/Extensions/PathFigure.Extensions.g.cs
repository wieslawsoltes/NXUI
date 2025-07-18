// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.PathFigure"/> class property extension methods.
/// </summary>
public static partial class PathFigureExtensions
{
    // Avalonia.Media.PathFigure.IsClosedProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.PathFigure.IsClosedProperty"/> value on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure obj, System.Boolean value)
    {
        obj[Avalonia.Media.PathFigure.IsClosedProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PathFigure.IsClosedProperty"/> on an object of type <see cref="Avalonia.Media.PathFigure"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PathFigure IsClosed(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.IsClosedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PathFigure.IsClosedProperty"/> on an object of type <see cref="Avalonia.Media.PathFigure"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PathFigure IsClosed(
        this Avalonia.Media.PathFigure obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.IsClosedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.PathFigure.IsClosedProperty"/> binding on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.PathFigure.IsClosedProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsClosed(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.IsClosedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.PathFigure.IsClosedProperty"/> on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsClosed(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetObservable(Avalonia.Media.PathFigure.IsClosedProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.PathFigure.IsClosedProperty"/> property on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.PathFigure OnIsClosed(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.PathFigure.IsClosedProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.PathFigure.IsClosedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Boolean>> ObserveBindingIsClosed(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.PathFigure.IsClosedProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.PathFigure.IsClosedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.PathFigure OnBindingIsClosed(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<BindingValue<System.Boolean>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.PathFigure.IsClosedProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.PathFigure.IsClosedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveIsClosedChanged(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.PathFigure.IsClosedProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.PathFigure.IsClosedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.PathFigure OnIsClosedChanged(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.PathFigure.IsClosedProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.PathFigure.IsFilledProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.PathFigure.IsFilledProperty"/> value on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure obj, System.Boolean value)
    {
        obj[Avalonia.Media.PathFigure.IsFilledProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PathFigure.IsFilledProperty"/> on an object of type <see cref="Avalonia.Media.PathFigure"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PathFigure IsFilled(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.IsFilledProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PathFigure.IsFilledProperty"/> on an object of type <see cref="Avalonia.Media.PathFigure"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PathFigure IsFilled(
        this Avalonia.Media.PathFigure obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.IsFilledProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.PathFigure.IsFilledProperty"/> binding on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.PathFigure.IsFilledProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsFilled(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.IsFilledProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.PathFigure.IsFilledProperty"/> on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsFilled(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetObservable(Avalonia.Media.PathFigure.IsFilledProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.PathFigure.IsFilledProperty"/> property on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.PathFigure OnIsFilled(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.PathFigure.IsFilledProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.PathFigure.IsFilledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Boolean>> ObserveBindingIsFilled(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.PathFigure.IsFilledProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.PathFigure.IsFilledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.PathFigure OnBindingIsFilled(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<BindingValue<System.Boolean>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.PathFigure.IsFilledProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.PathFigure.IsFilledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveIsFilledChanged(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.PathFigure.IsFilledProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.PathFigure.IsFilledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.PathFigure OnIsFilledChanged(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.PathFigure.IsFilledProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.PathFigure.SegmentsProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.PathFigure.SegmentsProperty"/> value on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure obj, Avalonia.Media.PathSegments value)
    {
        obj[Avalonia.Media.PathFigure.SegmentsProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PathFigure.SegmentsProperty"/> on an object of type <see cref="Avalonia.Media.PathFigure"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PathFigure Segments(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.SegmentsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PathFigure.SegmentsProperty"/> on an object of type <see cref="Avalonia.Media.PathFigure"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PathFigure Segments(
        this Avalonia.Media.PathFigure obj,
        IObservable<Avalonia.Media.PathSegments> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.SegmentsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.PathFigure.SegmentsProperty"/> binding on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.PathFigure.SegmentsProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSegments(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.SegmentsProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.PathFigure.SegmentsProperty"/> on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Media.PathSegments> ObserveSegments(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetObservable(Avalonia.Media.PathFigure.SegmentsProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.PathFigure.SegmentsProperty"/> property on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.PathFigure OnSegments(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<Avalonia.Media.PathSegments>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.PathFigure.SegmentsProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.PathFigure.SegmentsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Media.PathSegments>> ObserveBindingSegments(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.PathFigure.SegmentsProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.PathFigure.SegmentsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.PathFigure OnBindingSegments(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<BindingValue<Avalonia.Media.PathSegments>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.PathFigure.SegmentsProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.PathFigure.SegmentsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveSegmentsChanged(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.PathFigure.SegmentsProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.PathFigure.SegmentsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.PathFigure OnSegmentsChanged(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.PathFigure.SegmentsProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.PathFigure.StartPointProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.PathFigure.StartPointProperty"/> value on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure obj, Avalonia.Point value)
    {
        obj[Avalonia.Media.PathFigure.StartPointProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PathFigure.StartPointProperty"/> on an object of type <see cref="Avalonia.Media.PathFigure"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PathFigure StartPoint(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.StartPointProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PathFigure.StartPointProperty"/> on an object of type <see cref="Avalonia.Media.PathFigure"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PathFigure StartPoint(
        this Avalonia.Media.PathFigure obj,
        IObservable<Avalonia.Point> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.StartPointProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.PathFigure.StartPointProperty"/> binding on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.PathFigure.StartPointProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindStartPoint(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.StartPointProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.PathFigure.StartPointProperty"/> on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Point> ObserveStartPoint(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetObservable(Avalonia.Media.PathFigure.StartPointProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.PathFigure.StartPointProperty"/> property on an object of type <see cref="Avalonia.Media.PathFigure"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.PathFigure OnStartPoint(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<Avalonia.Point>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.PathFigure.StartPointProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.PathFigure.StartPointProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Point>> ObserveBindingStartPoint(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.PathFigure.StartPointProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.PathFigure.StartPointProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.PathFigure OnBindingStartPoint(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<BindingValue<Avalonia.Point>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.PathFigure.StartPointProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.PathFigure.StartPointProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveStartPointChanged(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.PathFigure.StartPointProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.PathFigure.StartPointProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.PathFigure OnStartPointChanged(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.PathFigure.StartPointProperty);
        handler(obj, observable);
        return obj;
    }
}
