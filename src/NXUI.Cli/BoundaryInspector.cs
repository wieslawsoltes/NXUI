namespace NXUI.Cli;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Mono.Cecil;

internal static class BoundaryInspector
{
    private const string BoundaryAttributeName = "NXUI.HotReload.HotReloadBoundaryAttribute";
    private const string CandidateAttributeName = "NXUI.HotReload.HotReloadCandidateBoundaryAttribute";
    private const string MarkerInterfaceName = "NXUI.HotReload.IHotReloadBoundaryMarker";
    private const string StateAdapterInterfaceName = "NXUI.HotReload.State.IHotReloadStateAdapter";

    internal static IReadOnlyList<string> LoadManifestEntries(string path)
    {
        if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
        {
            return Array.Empty<string>();
        }

        try
        {
            var text = File.ReadAllText(path);
            if (string.IsNullOrWhiteSpace(text))
            {
                return Array.Empty<string>();
            }

            using var document = JsonDocument.Parse(text);
            var root = document.RootElement;

            if (root.ValueKind == JsonValueKind.Array)
            {
                return Normalize(root.EnumerateArray().Select(e => e.GetString()));
            }

            if (root.ValueKind == JsonValueKind.Object)
            {
                if (root.TryGetProperty("controls", out var controls) && controls.ValueKind == JsonValueKind.Array)
                {
                    return Normalize(controls.EnumerateArray().Select(e => e.GetString()));
                }

                if (root.TryGetProperty("boundaryTypes", out var types) && types.ValueKind == JsonValueKind.Array)
                {
                    return Normalize(types.EnumerateArray().Select(e => e.GetString()));
                }
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"[nxui] Failed to read manifest '{path}': {ex.Message}");
        }

        return Array.Empty<string>();
    }

    internal static IReadOnlyList<BoundaryInfo> Inspect(string assemblyPath, IReadOnlyCollection<string> manifestEntries)
    {
        if (!File.Exists(assemblyPath))
        {
            return Array.Empty<BoundaryInfo>();
        }

        var manifest = new HashSet<string>(manifestEntries ?? Array.Empty<string>(), StringComparer.Ordinal);
        var results = new List<BoundaryInfo>();

        using var module = ModuleDefinition.ReadModule(assemblyPath);
        foreach (var type in EnumerateTypes(module.Types))
        {
            if (!ShouldProcess(type))
            {
                continue;
            }

            var hasBoundaryAttribute = HasAttribute(type, BoundaryAttributeName);
            var hasCandidateAttribute = HasAttribute(type, CandidateAttributeName);
            var implementsMarker = ImplementsInterface(type, MarkerInterfaceName);
            var implementsStateAdapter = ImplementsInterface(type, StateAdapterInterfaceName);
            var manifestMatch = MatchesManifest(type, manifest);

            if (!hasBoundaryAttribute && !hasCandidateAttribute && !implementsMarker && !manifestMatch && !implementsStateAdapter)
            {
                continue;
            }

            results.Add(new BoundaryInfo(
                TypeName: type.FullName,
                HasBoundaryAttribute: hasBoundaryAttribute,
                HasCandidateAttribute: hasCandidateAttribute,
                ImplementsMarkerInterface: implementsMarker,
                ManifestMatch: manifestMatch,
                ImplementsStateAdapter: implementsStateAdapter));
        }

        return results;
    }

    private static bool ShouldProcess(TypeDefinition type)
    {
        return !type.IsInterface
            && !type.IsEnum
            && !type.IsValueType;
    }

    private static bool HasAttribute(TypeDefinition type, string attributeName)
    {
        return type.CustomAttributes.Any(attr => attr.AttributeType.FullName == attributeName);
    }

    private static bool ImplementsInterface(TypeDefinition type, string interfaceName)
    {
        return type.Interfaces.Any(i => i.InterfaceType.FullName == interfaceName);
    }

    private static bool MatchesManifest(TypeDefinition type, HashSet<string> manifest)
    {
        if (manifest.Count == 0)
        {
            return false;
        }

        var current = type;
        while (current is not null)
        {
            if (manifest.Contains(current.FullName))
            {
                return true;
            }

            var baseType = current.BaseType;
            if (baseType is null)
            {
                break;
            }

            if (manifest.Contains(baseType.FullName))
            {
                return true;
            }

            try
            {
                current = baseType.Resolve();
            }
            catch
            {
                break;
            }
        }

        return false;
    }

    private static IEnumerable<TypeDefinition> EnumerateTypes(IEnumerable<TypeDefinition> types)
    {
        foreach (var type in types)
        {
            if (type.FullName == "<Module>")
            {
                continue;
            }

            yield return type;

            if (type.HasNestedTypes)
            {
                foreach (var nested in EnumerateTypes(type.NestedTypes))
                {
                    yield return nested;
                }
            }
        }
    }

    private static IReadOnlyList<string> Normalize(IEnumerable<string?> values)
    {
        var set = new HashSet<string>(StringComparer.Ordinal);
        foreach (var value in values)
        {
            var trimmed = value?.Trim();
            if (string.IsNullOrEmpty(trimmed))
            {
                continue;
            }

            set.Add(trimmed);
        }

        return set.ToArray();
    }
}

internal readonly record struct BoundaryInfo(
    string TypeName,
    bool HasBoundaryAttribute,
    bool HasCandidateAttribute,
    bool ImplementsMarkerInterface,
    bool ManifestMatch,
    bool ImplementsStateAdapter);
