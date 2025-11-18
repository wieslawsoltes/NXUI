#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Metadata;

using System;
using System.Collections.Generic;
using Avalonia;

/// <summary>
/// Represents an Avalonia property participating in the hot reload pipeline.
/// </summary>
internal readonly record struct PropertyMetadataEntry(
    int Id,
    int OwnerTypeId,
    string Name,
    AvaloniaProperty Property,
    PropertyValueComparer? Comparer = null);

/// <summary>
/// Lookup table for generated property metadata.
/// </summary>
internal static partial class PropertyMetadata
{
    internal const int InvalidPropertyId = 0;

    private static readonly PropertyMetadataEntry[] s_entries = BuildEntries();
    private static readonly Dictionary<AvaloniaProperty, int> s_propertyLookup = BuildLookup();

    /// <summary>
    /// Resolves the metadata entry for the provided property id.
    /// </summary>
    internal static ref readonly PropertyMetadataEntry GetEntry(int propertyId)
    {
        if ((uint)propertyId >= (uint)s_entries.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(propertyId));
        }

        return ref s_entries[propertyId];
    }

    /// <summary>
    /// Attempts to resolve the generated identifier for the provided <see cref="AvaloniaProperty"/>.
    /// </summary>
    internal static bool TryGetId(AvaloniaProperty property, out int propertyId)
    {
        ArgumentNullException.ThrowIfNull(property);
        return s_propertyLookup.TryGetValue(property, out propertyId);
    }

    private static PropertyMetadataEntry[] BuildEntries()
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

        var table = new PropertyMetadataEntry[maxId + 1];
        for (var i = 0; i < rawEntries.Length; i++)
        {
            var entry = rawEntries[i];
            var comparer = PropertyComparerRegistry.Resolve(entry.Property);
            if (comparer is not null)
            {
                entry = entry with { Comparer = comparer };
            }

            table[entry.Id] = entry;
        }

        return table;
    }

    private static Dictionary<AvaloniaProperty, int> BuildLookup()
    {
        var lookup = new Dictionary<AvaloniaProperty, int>(s_entries.Length - 1);
        for (var i = 1; i < s_entries.Length; i++)
        {
            var entry = s_entries[i];
            lookup[entry.Property] = entry.Id;
        }

        return lookup;
    }

    private static partial PropertyMetadataEntry[] CreateEntries();

    /// <summary>
    /// Attempts to retrieve a comparer for the provided property identifier.
    /// </summary>
    internal static bool TryGetComparer(int propertyId, out PropertyValueComparer comparer)
    {
        comparer = null!;
        if ((uint)propertyId >= (uint)s_entries.Length)
        {
            return false;
        }

        var entry = s_entries[propertyId];
        if (entry.Comparer is null)
        {
            return false;
        }

        comparer = entry.Comparer;
        return true;
    }
}
#endif
