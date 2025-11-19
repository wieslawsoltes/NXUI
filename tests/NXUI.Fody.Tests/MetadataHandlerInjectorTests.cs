using System.Collections.Generic;
using System.Linq;
using Mono.Cecil;
using NXUI.Fody.BoundaryWeaver;
using Xunit;

namespace NXUI.Fody.Tests;

public class MetadataHandlerInjectorTests
{
    [Fact]
    public void InjectAddsAttributeWhenMissing()
    {
        using var module = LoadAssembly();
        var attributeName = typeof(System.Reflection.Metadata.MetadataUpdateHandlerAttribute).FullName;
        var existing = module.Assembly.CustomAttributes
            .Where(attr => attr.AttributeType.FullName == attributeName)
            .ToList();
        foreach (var attr in existing)
        {
            module.Assembly.CustomAttributes.Remove(attr);
        }

        var warnings = new List<string>();
        MetadataHandlerInjector.Inject(module, _ => { }, warnings.Add);
        Assert.Empty(warnings);

        Assert.Contains(module.Assembly.CustomAttributes, attr => attr.AttributeType.FullName == attributeName);
    }

    [Fact]
    public void InjectIsNoOpWhenAttributeExists()
    {
        using var module = LoadAssembly();
        MetadataHandlerInjector.Inject(module, _ => { }, _ => { });

        var attributeName = typeof(System.Reflection.Metadata.MetadataUpdateHandlerAttribute).FullName;
        var initialCount = module.Assembly.CustomAttributes.Count(attr => attr.AttributeType.FullName == attributeName);

        MetadataHandlerInjector.Inject(module, _ => { }, _ => { });

        var finalCount = module.Assembly.CustomAttributes.Count(attr => attr.AttributeType.FullName == attributeName);
        Assert.Equal(initialCount, finalCount);
    }

    private static ModuleDefinition LoadAssembly()
    {
        var assemblyPath = typeof(AssemblyToProcess.DerivedTextBox).Assembly.Location;
        var resolver = new DefaultAssemblyResolver();
        resolver.AddSearchDirectory(System.IO.Path.GetDirectoryName(assemblyPath)!);
        return ModuleDefinition.ReadModule(
            assemblyPath,
            new ReaderParameters
            {
                ReadSymbols = false,
                AssemblyResolver = resolver,
            });
    }
}
