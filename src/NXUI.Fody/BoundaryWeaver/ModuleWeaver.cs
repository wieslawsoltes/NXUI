namespace NXUI.Fody.BoundaryWeaver;

using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Mono.Cecil;

/// <summary>
/// Entry point invoked by Fody during module weaving.
/// </summary>
public sealed class ModuleWeaver
{
    private const string ManifestAttribute = "ManifestPath";

    /// <summary>
    /// Gets or sets the module being processed by Fody.
    /// </summary>
    public ModuleDefinition? ModuleDefinition { get; set; }

    /// <summary>
    /// Gets or sets the optional XML configuration node from <c>FodyWeavers.xml</c>.
    /// </summary>
    public XElement? Config { get; set; }

    /// <summary>
    /// Gets or sets the directory that hosts the add-in files (manifest, weavers.xml, etc.).
    /// </summary>
    public string? AddinDirectoryPath { get; set; }

    /// <summary>
    /// Gets or sets the logging delegate for informational messages.
    /// </summary>
    public Action<string>? LogInfo { get; set; }

    /// <summary>
    /// Gets or sets the logging delegate for warnings.
    /// </summary>
    public Action<string>? LogWarning { get; set; }

    /// <summary>
    /// Executes the weaving pass for the current module.
    /// </summary>
    public void Execute()
    {
        if (ModuleDefinition is null)
        {
            throw new InvalidOperationException("ModuleDefinition has not been initialized.");
        }

        var manifestPath = Config?.Attribute(ManifestAttribute)?.Value;
        var manifest = BoundaryManifest.Load(AddinDirectoryPath, manifestPath, LogInfo, LogWarning);
        if (manifest.Count == 0)
        {
            LogInfo?.Invoke("NXUI BoundaryWeaver manifest was empty. Skipping weaving.");
            return;
        }

        var referenceResolver = BoundaryReferenceResolver.Create(ModuleDefinition, LogWarning);
        if (referenceResolver is null)
        {
            return;
        }

        var annotator = new BoundaryAnnotator(ModuleDefinition, referenceResolver, LogInfo);
        var appliedCount = annotator.Annotate(manifest);
        LogInfo?.Invoke($"NXUI BoundaryWeaver applied implicit boundaries to {appliedCount} types.");

        MetadataHandlerInjector.Inject(ModuleDefinition, LogInfo, LogWarning);
    }

    /// <summary>
    /// Provides additional assemblies that should be scanned by Fody (none required here).
    /// </summary>
    public IEnumerable<string> GetAssembliesForScanning()
    {
        yield break;
    }
}
