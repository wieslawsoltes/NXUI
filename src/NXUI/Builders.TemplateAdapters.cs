namespace NXUI;

using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Markup.Xaml;
#if NXUI_HOTRELOAD
using NXUI.HotReload.Nodes;
#endif

/// <summary>
/// Template helpers that keep the fluent builder syntax working under hot reload.
/// </summary>
public static partial class Builders
{
#if NXUI_HOTRELOAD
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
#else
    /// <summary>
    /// Wraps a control factory in a <see cref="FuncTemplate{TControl}"/>.
    /// </summary>
    public static FuncTemplate<TControl> FuncTemplate<TControl>(Func<TControl> build)
        where TControl : Control
    {
        ArgumentNullException.ThrowIfNull(build);
        return new FuncTemplate<TControl>(build);
    }

    /// <summary>
    /// Creates a <see cref="FuncDataTemplate{TItem}"/> from a control factory.
    /// </summary>
    public static FuncDataTemplate<TItem> FuncDataTemplate<TItem, TControl>(
        Func<TItem, TControl> build,
        bool supportsRecycling = false)
        where TItem : class
        where TControl : Control
    {
        ArgumentNullException.ThrowIfNull(build);
        return new FuncDataTemplate<TItem>((item, _) => build(item), supportsRecycling);
    }

    /// <summary>
    /// Creates a <see cref="FuncDataTemplate{TItem}"/> from a control factory that observes the scope.
    /// </summary>
    public static FuncDataTemplate<TItem> FuncDataTemplate<TItem, TControl>(
        Func<TItem, INameScope?, TControl> build,
        bool supportsRecycling = false)
        where TItem : class
        where TControl : Control
    {
        ArgumentNullException.ThrowIfNull(build);
        return new FuncDataTemplate<TItem>((item, scope) => build(item, scope), supportsRecycling);
    }
#endif
}
