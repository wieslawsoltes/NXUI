// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.DataGridCell"/> class property extension methods.
/// </summary>
public static partial class DataGridCellExtensions
{
    // Avalonia.Controls.DataGridCell.IsValidProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.DataGridCell.IsValidProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.DataGridCell.IsValidProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsValid(
        this Avalonia.Controls.DataGridCell obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.DataGridCell.IsValidProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.DataGridCell.IsValidProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsValid(this Avalonia.Controls.DataGridCell obj)
    {
        return obj.GetObservable(Avalonia.Controls.DataGridCell.IsValidProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.DataGridCell.IsValidProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.DataGridCell OnIsValid(this Avalonia.Controls.DataGridCell obj, Action<Avalonia.Controls.DataGridCell, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.DataGridCell.IsValidProperty);
        handler(obj, observable);
        return obj;
    }
}
