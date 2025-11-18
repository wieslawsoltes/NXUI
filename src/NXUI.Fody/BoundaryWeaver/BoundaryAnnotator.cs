namespace NXUI.Fody.BoundaryWeaver;

using System;
using System.Collections.Generic;
using Mono.Cecil;

internal sealed class BoundaryAnnotator
{
    private const string CandidateAttributeName = "NXUI.HotReload.HotReloadCandidateBoundaryAttribute";
    private const string StateAdapterInterfaceName = "NXUI.HotReload.State.IHotReloadStateAdapter";

    private readonly ModuleDefinition _module;
    private readonly BoundaryReferenceResolver _resolver;
    private readonly Action<string>? _infoLogger;

    internal BoundaryAnnotator(
        ModuleDefinition module,
        BoundaryReferenceResolver resolver,
        Action<string>? infoLogger)
    {
        _module = module ?? throw new ArgumentNullException(nameof(module));
        _resolver = resolver ?? throw new ArgumentNullException(nameof(resolver));
        _infoLogger = infoLogger;
    }

    internal int Annotate(IReadOnlyCollection<string> manifestEntries)
    {
        var manifest = new HashSet<string>(manifestEntries, StringComparer.Ordinal);
        var count = 0;

        foreach (var type in EnumerateTypes(_module.Types))
        {
            if (!ShouldProcess(type))
            {
                continue;
            }

            if (ImplementsStateAdapter(type))
            {
                _infoLogger?.Invoke($"NXUI BoundaryWeaver skipped '{type.FullName}' because it implements '{StateAdapterInterfaceName}'.");
                continue;
            }

            var manifestMatch = MatchesManifest(type, manifest);
            var candidateMatch = HasCandidateBoundaryAttribute(type);

            if (!manifestMatch && !candidateMatch)
            {
                continue;
            }

            if (_resolver.TryApply(type))
            {
                count++;
                _infoLogger?.Invoke($"NXUI BoundaryWeaver marked '{type.FullName}' as a hot reload boundary.");
            }
        }

        return count;
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

    private static bool ShouldProcess(TypeDefinition type)
    {
        return !type.IsInterface
            && !type.IsEnum
            && !type.IsValueType
            && type.BaseType is not null;
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
            catch (AssemblyResolutionException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        return false;
    }

    private static bool HasCandidateBoundaryAttribute(TypeDefinition type)
    {
        return type.CustomAttributes.Any(attr => attr.AttributeType.FullName == CandidateAttributeName);
    }

    private static bool ImplementsStateAdapter(TypeDefinition type)
    {
        return type.Interfaces.Any(i => i.InterfaceType.FullName == StateAdapterInterfaceName);
    }
}
