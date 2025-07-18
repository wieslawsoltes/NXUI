// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell"/> class property extension methods.
/// </summary>
public static partial class TreeDataGridTemplateCellExtensions
{
    // Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindContent(
        this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Object> ObserveContent(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.TreeDataGridTemplateCell OnContent(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj, Action<Avalonia.Controls.Primitives.TreeDataGridTemplateCell, IObservable<System.Object>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<System.Object>> ObserveBindingContent(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.TreeDataGridTemplateCell OnBindingContent(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj, Action<Avalonia.Controls.Primitives.TreeDataGridTemplateCell, IObservable<BindingValue<System.Object>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveContentChanged(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.TreeDataGridTemplateCell OnContentChanged(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj, Action<Avalonia.Controls.Primitives.TreeDataGridTemplateCell, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindContentTemplate(
        this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveContentTemplate(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.TreeDataGridTemplateCell OnContentTemplate(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj, Action<Avalonia.Controls.Primitives.TreeDataGridTemplateCell, IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Controls.Templates.IDataTemplate>> ObserveBindingContentTemplate(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.TreeDataGridTemplateCell OnBindingContentTemplate(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj, Action<Avalonia.Controls.Primitives.TreeDataGridTemplateCell, IObservable<BindingValue<Avalonia.Controls.Templates.IDataTemplate>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveContentTemplateChanged(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.TreeDataGridTemplateCell OnContentTemplateChanged(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj, Action<Avalonia.Controls.Primitives.TreeDataGridTemplateCell, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.ContentTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindEditingTemplate(
        this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveEditingTemplate(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.TreeDataGridTemplateCell OnEditingTemplate(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj, Action<Avalonia.Controls.Primitives.TreeDataGridTemplateCell, IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a binding observable for <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable including binding errors.</returns>
    public static IObservable<BindingValue<Avalonia.Controls.Templates.IDataTemplate>> ObserveBindingEditingTemplate(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj)
    {
        return obj.GetBindingObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with a binding observable for <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and binding observable.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.TreeDataGridTemplateCell OnBindingEditingTemplate(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj, Action<Avalonia.Controls.Primitives.TreeDataGridTemplateCell, IObservable<BindingValue<Avalonia.Controls.Templates.IDataTemplate>>> handler)
    {
        var observable = obj.GetBindingObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets a property change observable for <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable with property change details.</returns>
    public static IObservable<AvaloniaPropertyChangedEventArgs> ObserveEditingTemplateChanged(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj)
    {
        return obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with property change observable for <see cref="Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and property change observable.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.TreeDataGridTemplateCell OnEditingTemplateChanged(this Avalonia.Controls.Primitives.TreeDataGridTemplateCell obj, Action<Avalonia.Controls.Primitives.TreeDataGridTemplateCell, IObservable<AvaloniaPropertyChangedEventArgs>> handler)
    {
        var observable = obj.GetPropertyChangedObservable(Avalonia.Controls.Primitives.TreeDataGridTemplateCell.EditingTemplateProperty);
        handler(obj, observable);
        return obj;
    }
}
