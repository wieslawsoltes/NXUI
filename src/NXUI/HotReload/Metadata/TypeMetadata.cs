#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Metadata;

using System;
using System.Collections.Generic;

/// <summary>
/// Describes an Avalonia type participating in the hot reload pipeline.
/// </summary>
internal readonly record struct TypeMetadataEntry(int Id, Type Type, string Name);

/// <summary>
/// Lookup table for generated type metadata.
/// </summary>
internal static partial class TypeMetadata
{
    internal const int InvalidTypeId = 0;

    private static readonly TypeMetadataEntry[] s_entries = BuildEntries();
    private static readonly Dictionary<Type, int> s_typeLookup = BuildLookup();

    /// <summary>
    /// Resolves the metadata entry for the provided type id.
    /// </summary>
    internal static ref readonly TypeMetadataEntry GetEntry(int typeId)
    {
        if ((uint)typeId >= (uint)s_entries.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(typeId));
        }

        return ref s_entries[typeId];
    }

    /// <summary>
    /// Attempts to resolve the generated identifier for the provided type.
    /// </summary>
    internal static bool TryGetId(Type type, out int typeId)
    {
        ArgumentNullException.ThrowIfNull(type);
        return s_typeLookup.TryGetValue(type, out typeId);
    }

    private static TypeMetadataEntry[] BuildEntries()
    {
        var rawEntries = CreateEntries();
        var maxId = 0;
        for (var i = 0; i < rawEntries.Length; i++)
        {
            if (rawEntries[i].Id > maxId)
            {
                maxId = rawEntries[i].Id;
            }
        }

        var table = new TypeMetadataEntry[maxId + 1];
        for (var i = 0; i < rawEntries.Length; i++)
        {
            var entry = rawEntries[i];
            table[entry.Id] = entry;
        }

        return table;
    }

    private static Dictionary<Type, int> BuildLookup()
    {
        var lookup = new Dictionary<Type, int>(s_entries.Length - 1);
        for (var i = 1; i < s_entries.Length; i++)
        {
            var entry = s_entries[i];
            lookup[entry.Type] = entry.Id;
        }

        return lookup;
    }

    private static partial TypeMetadataEntry[] CreateEntries();
}
#endif
