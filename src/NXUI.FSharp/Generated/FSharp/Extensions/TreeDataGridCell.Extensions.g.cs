// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.TreeDataGridCell"/> class property extension methods.
/// </summary>
public static partial class TreeDataGridCellExtensions
{
    // Avalonia.Controls.Primitives.TreeDataGridCell.IsSelectedProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.TreeDataGridCell.IsSelectedProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.TreeDataGridCell.IsSelectedProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsSelected(
        this Avalonia.Controls.Primitives.TreeDataGridCell obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.TreeDataGridCell.IsSelectedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridCell.IsSelectedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsSelected(this Avalonia.Controls.Primitives.TreeDataGridCell obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridCell.IsSelectedProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridCell.IsSelectedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.TreeDataGridCell OnIsSelected(this Avalonia.Controls.Primitives.TreeDataGridCell obj, Action<Avalonia.Controls.Primitives.TreeDataGridCell, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridCell.IsSelectedProperty);
        handler(obj, observable);
        return obj;
    }
}