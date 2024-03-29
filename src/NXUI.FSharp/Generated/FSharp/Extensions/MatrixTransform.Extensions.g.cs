// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.MatrixTransform"/> class property extension methods.
/// </summary>
public static partial class MatrixTransformExtensions
{
    // Avalonia.Media.MatrixTransform.MatrixProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/> value on an object of type <see cref="Avalonia.Media.MatrixTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.MatrixTransform matrix(this Avalonia.Media.MatrixTransform obj, Avalonia.Matrix value)
    {
        obj[Avalonia.Media.MatrixTransform.MatrixProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/> on an object of type <see cref="Avalonia.Media.MatrixTransform"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.MatrixTransform matrix(
        this Avalonia.Media.MatrixTransform obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.MatrixTransform.MatrixProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/> on an object of type <see cref="Avalonia.Media.MatrixTransform"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.MatrixTransform matrix(
        this Avalonia.Media.MatrixTransform obj,
        IObservable<Avalonia.Matrix> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.MatrixTransform.MatrixProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/> binding on an object of type <see cref="Avalonia.Media.MatrixTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindMatrix(
        this Avalonia.Media.MatrixTransform obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.MatrixTransform.MatrixProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/> on an object of type <see cref="Avalonia.Media.MatrixTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Matrix> ObserveMatrix(this Avalonia.Media.MatrixTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.MatrixTransform.MatrixProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.MatrixTransform.MatrixProperty"/> property on an object of type <see cref="Avalonia.Media.MatrixTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.MatrixTransform OnMatrix(this Avalonia.Media.MatrixTransform obj, Action<Avalonia.Media.MatrixTransform, IObservable<Avalonia.Matrix>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.MatrixTransform.MatrixProperty);
        handler(obj, observable);
        return obj;
    }
}
