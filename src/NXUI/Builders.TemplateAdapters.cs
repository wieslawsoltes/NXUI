namespace NXUI;

using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Markup.Xaml;
using NXUI.HotReload.Nodes;

/// <summary>
/// Template helpers that keep the fluent builder syntax working under hot reload.
/// </summary>
public static partial class Builders
{
    /// <summary>
    /// Wraps a builder factory in a <see cref="FuncTemplate{TControl}"/>.
    /// </summary>
    public static FuncTemplate<TControl> FuncTemplate<TControl>(Func<ElementBuilder<TControl>> build)
        where TControl : Control
    {
        ArgumentNullException.ThrowIfNull(build);
        return new FuncTemplate<TControl>(() => build().Mount());
    }

    /// <summary>
    /// Wraps a builder factory in a template typed to a base control type.
    /// </summary>
    public static FuncTemplate<TBase> FuncTemplate<TBase, TControl>(Func<ElementBuilder<TControl>> build)
        where TBase : Control
        where TControl : TBase
    {
        ArgumentNullException.ThrowIfNull(build);
        return new FuncTemplate<TBase>(() => build().Mount());
    }

    /// <summary>
    /// Creates a <see cref="FuncDataTemplate{TItem}"/> from a builder factory.
    /// </summary>
    public static FuncDataTemplate<TItem> FuncDataTemplate<TItem, TControl>(
        Func<TItem, ElementBuilder<TControl>> build,
        bool supportsRecycling = false)
        where TItem : class
        where TControl : Control
    {
        ArgumentNullException.ThrowIfNull(build);
        return new FuncDataTemplate<TItem>((item, _) => build(item).Mount(), supportsRecycling);
    }

    /// <summary>
    /// Creates a <see cref="FuncDataTemplate{TItem}"/> from a builder factory that observes the scope.
    /// </summary>
    public static FuncDataTemplate<TItem> FuncDataTemplate<TItem, TControl>(
        Func<TItem, INameScope?, ElementBuilder<TControl>> build,
        bool supportsRecycling = false)
        where TItem : class
        where TControl : Control
    {
        ArgumentNullException.ThrowIfNull(build);
        return new FuncDataTemplate<TItem>((item, scope) => build(item, scope).Mount(), supportsRecycling);
    }
}
