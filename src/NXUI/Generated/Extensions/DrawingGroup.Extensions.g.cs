// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.DrawingGroup"/> class property extension methods.
/// </summary>
public static partial class DrawingGroupExtensions
{
    // Avalonia.Media.DrawingGroup.OpacityProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.DrawingGroup.OpacityProperty"/> value on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup obj, System.Double value)
    {
        obj[Avalonia.Media.DrawingGroup.OpacityProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DrawingGroup.OpacityProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup Opacity(
        this Avalonia.Media.DrawingGroup obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.OpacityProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DrawingGroup.OpacityProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup Opacity(
        this Avalonia.Media.DrawingGroup obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.OpacityProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.DrawingGroup.OpacityProperty"/> binding on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.DrawingGroup.OpacityProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOpacity(
        this Avalonia.Media.DrawingGroup obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.OpacityProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.DrawingGroup.OpacityProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<System.Double> ObserveOpacity(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetObservable(Avalonia.Media.DrawingGroup.OpacityProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.DrawingGroup.OpacityProperty"/> property on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnOpacity(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.DrawingGroup.OpacityProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.DrawingGroup.OpacityProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Double>> ObserveBindingOpacity(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.DrawingGroup.OpacityProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.DrawingGroup.OpacityProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnBindingOpacity(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<BindingValue<System.Double>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.DrawingGroup.OpacityProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.DrawingGroup.OpacityProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveOpacityChanged(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.DrawingGroup.OpacityProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.DrawingGroup.OpacityProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnOpacityChanged(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.DrawingGroup.OpacityProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.DrawingGroup.TransformProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.DrawingGroup.TransformProperty"/> value on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup obj, Avalonia.Media.Transform value)
    {
        obj[Avalonia.Media.DrawingGroup.TransformProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DrawingGroup.TransformProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup Transform(
        this Avalonia.Media.DrawingGroup obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.TransformProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DrawingGroup.TransformProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup Transform(
        this Avalonia.Media.DrawingGroup obj,
        IObservable<Avalonia.Media.Transform> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.TransformProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.DrawingGroup.TransformProperty"/> binding on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.DrawingGroup.TransformProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTransform(
        this Avalonia.Media.DrawingGroup obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.TransformProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.DrawingGroup.TransformProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Media.Transform> ObserveTransform(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetObservable(Avalonia.Media.DrawingGroup.TransformProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.DrawingGroup.TransformProperty"/> property on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnTransform(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<Avalonia.Media.Transform>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.DrawingGroup.TransformProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.DrawingGroup.TransformProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Media.Transform>> ObserveBindingTransform(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.DrawingGroup.TransformProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.DrawingGroup.TransformProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnBindingTransform(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<BindingValue<Avalonia.Media.Transform>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.DrawingGroup.TransformProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.DrawingGroup.TransformProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveTransformChanged(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.DrawingGroup.TransformProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.DrawingGroup.TransformProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnTransformChanged(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.DrawingGroup.TransformProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.DrawingGroup.ClipGeometryProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.DrawingGroup.ClipGeometryProperty"/> value on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup obj, Avalonia.Media.Geometry value)
    {
        obj[Avalonia.Media.DrawingGroup.ClipGeometryProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DrawingGroup.ClipGeometryProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup ClipGeometry(
        this Avalonia.Media.DrawingGroup obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.ClipGeometryProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DrawingGroup.ClipGeometryProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup ClipGeometry(
        this Avalonia.Media.DrawingGroup obj,
        IObservable<Avalonia.Media.Geometry> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.ClipGeometryProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.DrawingGroup.ClipGeometryProperty"/> binding on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.DrawingGroup.ClipGeometryProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindClipGeometry(
        this Avalonia.Media.DrawingGroup obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.ClipGeometryProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.DrawingGroup.ClipGeometryProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Media.Geometry> ObserveClipGeometry(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetObservable(Avalonia.Media.DrawingGroup.ClipGeometryProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.DrawingGroup.ClipGeometryProperty"/> property on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnClipGeometry(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<Avalonia.Media.Geometry>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.DrawingGroup.ClipGeometryProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.DrawingGroup.ClipGeometryProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Media.Geometry>> ObserveBindingClipGeometry(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.DrawingGroup.ClipGeometryProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.DrawingGroup.ClipGeometryProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnBindingClipGeometry(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<BindingValue<Avalonia.Media.Geometry>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.DrawingGroup.ClipGeometryProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.DrawingGroup.ClipGeometryProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveClipGeometryChanged(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.DrawingGroup.ClipGeometryProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.DrawingGroup.ClipGeometryProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnClipGeometryChanged(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.DrawingGroup.ClipGeometryProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.DrawingGroup.OpacityMaskProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.DrawingGroup.OpacityMaskProperty"/> value on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup obj, Avalonia.Media.IBrush value)
    {
        obj[Avalonia.Media.DrawingGroup.OpacityMaskProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DrawingGroup.OpacityMaskProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup OpacityMask(
        this Avalonia.Media.DrawingGroup obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.OpacityMaskProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DrawingGroup.OpacityMaskProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup OpacityMask(
        this Avalonia.Media.DrawingGroup obj,
        IObservable<Avalonia.Media.IBrush> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.OpacityMaskProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.DrawingGroup.OpacityMaskProperty"/> binding on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.DrawingGroup.OpacityMaskProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOpacityMask(
        this Avalonia.Media.DrawingGroup obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.OpacityMaskProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.DrawingGroup.OpacityMaskProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Media.IBrush> ObserveOpacityMask(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetObservable(Avalonia.Media.DrawingGroup.OpacityMaskProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.DrawingGroup.OpacityMaskProperty"/> property on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnOpacityMask(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<Avalonia.Media.IBrush>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.DrawingGroup.OpacityMaskProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.DrawingGroup.OpacityMaskProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Media.IBrush>> ObserveBindingOpacityMask(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.DrawingGroup.OpacityMaskProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.DrawingGroup.OpacityMaskProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnBindingOpacityMask(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<BindingValue<Avalonia.Media.IBrush>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.DrawingGroup.OpacityMaskProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.DrawingGroup.OpacityMaskProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveOpacityMaskChanged(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.DrawingGroup.OpacityMaskProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.DrawingGroup.OpacityMaskProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnOpacityMaskChanged(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.DrawingGroup.OpacityMaskProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.DrawingGroup.ChildrenProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.DrawingGroup.ChildrenProperty"/> value on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup obj, Avalonia.Media.DrawingCollection value)
    {
        obj[Avalonia.Media.DrawingGroup.ChildrenProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DrawingGroup.ChildrenProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup Children(
        this Avalonia.Media.DrawingGroup obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.ChildrenProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DrawingGroup.ChildrenProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DrawingGroup Children(
        this Avalonia.Media.DrawingGroup obj,
        IObservable<Avalonia.Media.DrawingCollection> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.ChildrenProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.DrawingGroup.ChildrenProperty"/> binding on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.DrawingGroup.ChildrenProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindChildren(
        this Avalonia.Media.DrawingGroup obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingGroup.ChildrenProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.DrawingGroup.ChildrenProperty"/> on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Media.DrawingCollection> ObserveChildren(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetObservable(Avalonia.Media.DrawingGroup.ChildrenProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.DrawingGroup.ChildrenProperty"/> property on an object of type <see cref="Avalonia.Media.DrawingGroup"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnChildren(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<Avalonia.Media.DrawingCollection>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.DrawingGroup.ChildrenProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Media.DrawingGroup.ChildrenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Media.DrawingCollection>> ObserveBindingChildren(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetBindingObservable(Avalonia.Media.DrawingGroup.ChildrenProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Media.DrawingGroup.ChildrenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnBindingChildren(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<BindingValue<Avalonia.Media.DrawingCollection>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Media.DrawingGroup.ChildrenProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Media.DrawingGroup.ChildrenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveChildrenChanged(this Avalonia.Media.DrawingGroup obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Media.DrawingGroup.ChildrenProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Media.DrawingGroup.ChildrenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DrawingGroup OnChildrenChanged(this Avalonia.Media.DrawingGroup obj, Action<Avalonia.Media.DrawingGroup, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Media.DrawingGroup.ChildrenProperty);
        handler(obj, observable);
        return obj;
    }
}
