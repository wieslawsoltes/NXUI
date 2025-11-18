namespace NXUI.Fody.BoundaryWeaver;

using System;
using System.Linq;
using Mono.Cecil;

internal static class MetadataHandlerInjector
{
    private const string AttributeFullName = "System.Reflection.Metadata.MetadataUpdateHandlerAttribute";
    private const string HandlerFullName = "NXUI.HotReload.HotReloadMetadataUpdateHandler";

    internal static void Inject(ModuleDefinition module, Action<string>? infoLogger, Action<string>? warningLogger)
    {
        if (module.Assembly is null)
        {
            return;
        }

        if (HasHandlerAttribute(module.Assembly))
        {
            return;
        }

        var attributeCtor = GetMetadataAttributeConstructor(module, warningLogger);
        if (attributeCtor is null)
        {
            warningLogger?.Invoke("NXUI MetadataUpdateHandler weaver could not locate MetadataUpdateHandlerAttribute.");
            return;
        }

        var handlerType = TryImportType(module, HandlerFullName);
        if (handlerType is null)
        {
            warningLogger?.Invoke("NXUI MetadataUpdateHandler weaver could not locate HotReloadMetadataUpdateHandler. Ensure the target project references NXUI.");
            return;
        }

        var attribute = new CustomAttribute(attributeCtor);
        var typeReference = module.ImportReference(typeof(Type));
        attribute.ConstructorArguments.Add(new CustomAttributeArgument(typeReference, handlerType));

        module.Assembly.CustomAttributes.Add(attribute);
        infoLogger?.Invoke($"NXUI MetadataUpdateHandler weaver injected handler attribute into '{module.Assembly.Name.Name}'.");
    }

    private static bool HasHandlerAttribute(AssemblyDefinition assembly)
    {
        return assembly.CustomAttributes.Any(attr => attr.AttributeType.FullName == AttributeFullName);
    }

    private static MethodReference? GetMetadataAttributeConstructor(ModuleDefinition module, Action<string>? warningLogger)
    {
        try
        {
            var runtimeType = ResolveMetadataAttributeRuntimeType();
            if (runtimeType is null)
            {
                warningLogger?.Invoke("NXUI MetadataUpdateHandler weaver could not load MetadataUpdateHandlerAttribute from the current runtime.");
                return null;
            }

            var attributeType = module.ImportReference(runtimeType);
            var resolved = attributeType?.Resolve();
            if (resolved is null)
            {
                return null;
            }

            var ctor = resolved.Methods.FirstOrDefault(m => m.IsConstructor && !m.IsStatic && m.Parameters.Count == 1);
            return ctor is null ? null : module.ImportReference(ctor);
        }
        catch (Exception ex)
        {
            warningLogger?.Invoke($"Failed to import MetadataUpdateHandlerAttribute: {ex.Message}");
            return null;
        }
    }

    private static TypeReference? TryImportType(ModuleDefinition module, string fullName)
    {
        var self = module.GetType(fullName);
        if (self is not null)
        {
            return module.ImportReference(self);
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
            }
        }

        return null;
    }

    private static Type? ResolveMetadataAttributeRuntimeType()
    {
        return Type.GetType("System.Reflection.Metadata.MetadataUpdateHandlerAttribute, System.Runtime")
            ?? Type.GetType("System.Reflection.Metadata.MetadataUpdateHandlerAttribute");
    }
}
