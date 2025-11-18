namespace NXUI.HotReload.State;

using System;
using System.Collections.Generic;
using Avalonia.Controls;
using NXUI.HotReload.State.Internal;

/// <summary>
/// Stores <see cref="IHotReloadStateAdapter"/> instances so controls can preserve state when rebuilt.
/// </summary>
public static class HotReloadStateRegistry
{
    private static readonly object s_gate = new();
    private static readonly Dictionary<Type, IHotReloadStateAdapter> s_adapters = new();
    private static bool s_defaultsRegistered;

    /// <summary>
    /// Registers an adapter for the specified control type.
    /// </summary>
    /// <param name="controlType">Concrete control type supported by <paramref name="adapter"/>.</param>
    /// <param name="adapter">Adapter instance.</param>
    public static void RegisterAdapter(Type controlType, IHotReloadStateAdapter adapter)
    {
        ArgumentNullException.ThrowIfNull(controlType);
        ArgumentNullException.ThrowIfNull(adapter);

        if (!adapter.ControlType.IsAssignableFrom(controlType))
        {
            throw new InvalidOperationException(
                $"Adapter '{adapter.GetType().FullName}' declares ControlType '{adapter.ControlType.FullName}' but was registered for '{controlType.FullName}'. " +
                "Adapters must declare a control type that is assignable from the registered control type.");
        }

        lock (s_gate)
        {
            s_adapters[controlType] = adapter;
        }
    }

    internal static bool TryGetAdapter(Type type, out IHotReloadStateAdapter? adapter)
    {
        EnsureDefaults();

        lock (s_gate)
        {
            var current = type;
            while (current is not null)
            {
                if (s_adapters.TryGetValue(current, out adapter))
                {
                    return true;
                }

                current = current.BaseType;
            }
        }

        adapter = null;
        return false;
    }

    private static void EnsureDefaults()
    {
        if (s_defaultsRegistered)
        {
            return;
        }

        lock (s_gate)
        {
            if (s_defaultsRegistered)
            {
                return;
            }

            s_adapters[typeof(TextBox)] = new TextBoxStateAdapter();
            s_defaultsRegistered = true;
        }
    }
}
