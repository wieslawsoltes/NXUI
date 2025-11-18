namespace NXUI.Extensions;

using System;
using NXUI.HotReload.Nodes;
using NXUI.HotReload.Templates;

/// <summary>
/// Control template helpers.
/// </summary>
public static partial class TemplatedControlExtensions
{
    /// <summary>
    /// Adds a <see cref="FuncControlTemplate"/> created from a delegate returning a live control.
    /// </summary>
    /// <exception cref="InvalidCastException">Thrown when the style target does not match <typeparamref name="TControl"/>.</exception>
    public static Style SetTemplatedControlTemplate<TControl>(
        this Style style,
        Func<TControl, INameScope, Control> build)
        where TControl : TemplatedControl
    {
        ArgumentNullException.ThrowIfNull(style);
        ArgumentNullException.ThrowIfNull(build);

        var value = new FuncControlTemplate((parent, scope) =>
        {
            if (parent is TControl typed)
            {
                return build(typed, scope);
            }

            throw new InvalidCastException();
        });
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a <see cref="FuncControlTemplate"/> created from a fluent builder delegate to keep hot reload working.
    /// </summary>
    /// <exception cref="InvalidCastException">Thrown when the style target does not match <typeparamref name="TControl"/>.</exception>
    public static Style SetTemplatedControlTemplate<TControl, TContent>(
        this Style style,
        Func<TControl, INameScope, ElementBuilder<TContent>> build)
        where TControl : TemplatedControl
        where TContent : Control
    {
        ArgumentNullException.ThrowIfNull(style);
        ArgumentNullException.ThrowIfNull(build);

        var value = CreateTemplate(build);
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, value));
        return style;
    }

    /// <summary>
    /// Builder-compatible overload that records the template assignment for hot reload.
    /// </summary>
    public static StyleBuilder SetTemplatedControlTemplate<TControl, TContent>(
        this StyleBuilder builder,
        Func<TControl, INameScope, ElementBuilder<TContent>> build)
        where TControl : TemplatedControl
        where TContent : Control
    {
        ArgumentNullException.ThrowIfNull(build);
        return builder.WithAction(style =>
        {
            var value = CreateTemplate(build);
            style.Setters.Add(new Setter(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, value));
        });
    }

    private static FuncControlTemplate CreateTemplate<TControl, TContent>(
        Func<TControl, INameScope, ElementBuilder<TContent>> build)
        where TControl : TemplatedControl
        where TContent : Control
    {
        FuncControlTemplate? templateRef = null;
        var manifestRecorded = false;

        var value = new FuncControlTemplate((parent, scope) =>
        {
            if (parent is not TControl typed)
            {
                throw new InvalidCastException();
            }

            var contentBuilder = build(typed, scope);
            if (!manifestRecorded && templateRef is not null)
            {
                var manifest = TemplateManifestCollector.Create(contentBuilder.Node);
                TemplateManifestRegistry.Register(templateRef, manifest);
                manifestRecorded = true;
            }

            return contentBuilder.Mount();
        });

        templateRef = value;
        return value;
    }
}
