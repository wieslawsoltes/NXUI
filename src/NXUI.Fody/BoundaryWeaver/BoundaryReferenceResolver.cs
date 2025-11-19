namespace NXUI.Fody.BoundaryWeaver;

using System;
using System.Linq;
using Mono.Cecil;

internal sealed class BoundaryReferenceResolver
{
    private readonly ModuleDefinition _module;
    private readonly MethodReference? _attributeConstructor;
    private readonly TypeReference? _markerInterface;

    private BoundaryReferenceResolver(
        ModuleDefinition module,
        MethodReference? attributeConstructor,
        TypeReference? markerInterface)
    {
        _module = module ?? throw new ArgumentNullException(nameof(module));
        _attributeConstructor = attributeConstructor;
        _markerInterface = markerInterface;
    }

    internal static BoundaryReferenceResolver? Create(ModuleDefinition module, Action<string>? warningLogger)
    {
        var attributeType = TryImportType(module, "NXUI.HotReload.HotReloadBoundaryAttribute");
        MethodReference? attributeConstructor = null;
        if (attributeType is not null)
        {
            var resolved = attributeType.Resolve();
            var ctor = resolved?.Methods.FirstOrDefault(m => m.IsConstructor && !m.IsStatic && !m.HasParameters);
            if (ctor is not null)
            {
                attributeConstructor = module.ImportReference(ctor);
            }
        }

        var markerInterface = TryImportType(module, "NXUI.HotReload.IHotReloadBoundaryMarker");

        if (attributeConstructor is null && markerInterface is null)
        {
            warningLogger?.Invoke("NXUI BoundaryWeaver could not locate boundary attribute or marker interface in referenced assemblies. Ensure the target project references the NXUI package.");
            return null;
        }

        return new BoundaryReferenceResolver(module, attributeConstructor, markerInterface);
    }

    internal bool TryApply(TypeDefinition type)
    {
        if (type is null)
        {
            throw new ArgumentNullException(nameof(type));
        }

        if (HasBoundaryMetadata(type))
        {
            return false;
        }

        if (_attributeConstructor is not null)
        {
            type.CustomAttributes.Add(new CustomAttribute(_attributeConstructor));
            return true;
        }

        if (_markerInterface is not null && !ImplementsMarker(type))
        {
            type.Interfaces.Add(new InterfaceImplementation(_markerInterface));
            return true;
        }

        return false;
    }

    private static TypeReference? TryImportType(ModuleDefinition module, string fullName)
    {
        if (module is null)
        {
            throw new ArgumentNullException(nameof(module));
        }

        var selfType = module.GetType(fullName);
        if (selfType is not null)
        {
            return module.ImportReference(selfType);
        }

        foreach (var reference in module.AssemblyReferences)
        {
            try
            {
                var assembly = module.AssemblyResolver.Resolve(reference);
                var type = assembly.MainModule.Types.FirstOrDefault(t => t.FullName == fullName);
                if (type is not null)
                {
                    return module.ImportReference(type);
                }
            }
            catch (AssemblyResolutionException)
            {
                // Ignore and continue searching other references.
            }
        }

        return null;
    }

    private static bool HasBoundaryMetadata(TypeDefinition type)
    {
        var hasAttribute = type.CustomAttributes.Any(
            a => a.AttributeType.FullName == "NXUI.HotReload.HotReloadBoundaryAttribute");

        if (hasAttribute)
        {
            return true;
        }

        return ImplementsMarker(type);
    }

    private static bool ImplementsMarker(TypeDefinition type)
    {
        return type.Interfaces.Any(i => i.InterfaceType.FullName == "NXUI.HotReload.IHotReloadBoundaryMarker");
    }
}
