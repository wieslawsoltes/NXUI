using System;
using System.Collections.Generic;
using System.IO;
using Mono.Cecil;
using NXUI.Fody.BoundaryWeaver;
using Xunit;

namespace NXUI.Fody.Tests;

public class BoundaryWeaverTests
{
    private const string BoundaryAttributeName = "NXUI.HotReload.HotReloadBoundaryAttribute";

    [Fact]
    public void AnnotatesDerivedControlsUsingManifest()
    {
        using var module = LoadAssemblyUnderTest();
        var resolver = CreateResolver(module);
        var annotator = new BoundaryAnnotator(module, resolver, _ => { });
        var manifest = new List<string> { "Avalonia.Controls.TextBox" };

        var count = annotator.Annotate(manifest);
        Assert.True(count >= 1, $"Expected at least one manifest match, but recorded {count} annotations.");

        var type = module.GetType("AssemblyToProcess.DerivedTextBox");
        Assert.NotNull(type);
        Assert.Contains(type!.CustomAttributes, attr => attr.AttributeType.FullName == BoundaryAttributeName);
    }

    [Fact]
    public void PromotesCandidateAttribute()
    {
        using var module = LoadAssemblyUnderTest();
        var resolver = CreateResolver(module);
        var annotator = new BoundaryAnnotator(module, resolver, _ => { });

        var count = annotator.Annotate(Array.Empty<string>());
        Assert.True(count >= 1);

        var type = module.GetType("AssemblyToProcess.CandidateBoundaryControl");
        Assert.NotNull(type);
        Assert.Contains(type!.CustomAttributes, attr => attr.AttributeType.FullName == BoundaryAttributeName);
    }

    [Fact]
    public void SkipsTypesWithStateAdapters()
    {
        using var module = LoadAssemblyUnderTest();
        var resolver = CreateResolver(module);
        var annotator = new BoundaryAnnotator(module, resolver, _ => { });
        var manifest = new List<string> { "AssemblyToProcess.StateAdapterControl" };

        var type = module.GetType("AssemblyToProcess.StateAdapterControl");
        Assert.NotNull(type);
        Assert.DoesNotContain(type!.CustomAttributes, attr => attr.AttributeType.FullName == BoundaryAttributeName);
    }

    private static ModuleDefinition LoadAssemblyUnderTest()
    {
        var assemblyPath = Path.Combine(
            Path.GetDirectoryName(typeof(BoundaryWeaverTests).Assembly.Location)!,
            "AssemblyToProcess.dll");

        return ModuleDefinition.ReadModule(assemblyPath, new ReaderParameters { ReadSymbols = false });
    }

    private static BoundaryReferenceResolver CreateResolver(ModuleDefinition module)
    {
        var resolver = BoundaryReferenceResolver.Create(module, _ => { });
        return resolver ?? throw new InvalidOperationException("Failed to resolve NXUI boundary metadata.");
    }
}
