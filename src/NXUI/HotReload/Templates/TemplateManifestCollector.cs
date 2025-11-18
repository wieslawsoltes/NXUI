namespace NXUI.HotReload.Templates;

using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia;
using NXUI.HotReload.Nodes;

internal static class TemplateManifestCollector
{
    internal static TemplateManifest Create(ElementNode root)
    {
        ArgumentNullException.ThrowIfNull(root);
        return new TemplateManifest(CreateNode(root));
    }

    private static TemplateManifestNode CreateNode(ElementNode node)
    {
        var children = node.Children.Count == 0
            ? Array.Empty<TemplateManifestNode>()
            : node.Children.Select(CreateNode).ToArray();

        return new TemplateManifestNode(
            node.ControlType,
            TryGetName(node),
            children);
    }

    private static string? TryGetName(ElementNode node)
    {
        foreach (var mutation in node.Properties)
        {
            var property = mutation.Property ?? mutation.Descriptor?.Property;
            if (property == StyledElement.NameProperty)
            {
                return mutation.Value as string;
            }
        }

        return null;
    }
}
