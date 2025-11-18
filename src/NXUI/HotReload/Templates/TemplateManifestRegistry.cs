namespace NXUI.HotReload.Templates;

using System;
using System.Runtime.CompilerServices;
using Avalonia.Controls.Templates;

internal static class TemplateManifestRegistry
{
    private static readonly ConditionalWeakTable<FuncControlTemplate, TemplateManifest> s_manifestTable = new();

    internal static void Register(FuncControlTemplate template, TemplateManifest manifest)
    {
        ArgumentNullException.ThrowIfNull(template);
        ArgumentNullException.ThrowIfNull(manifest);

        lock (s_manifestTable)
        {
            s_manifestTable.Remove(template);
            s_manifestTable.Add(template, manifest);
        }
    }

    internal static bool TryGetManifest(FuncControlTemplate template, out TemplateManifest? manifest)
    {
        ArgumentNullException.ThrowIfNull(template);
        return s_manifestTable.TryGetValue(template, out manifest);
    }
}
