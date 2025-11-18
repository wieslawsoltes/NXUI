#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Templates;

using System;
using System.Collections.Generic;

internal sealed class TemplateManifest
{
    public TemplateManifest(TemplateManifestNode root)
    {
        Root = root ?? throw new ArgumentNullException(nameof(root));
    }

    public TemplateManifestNode Root { get; }
}

internal sealed class TemplateManifestNode
{
    public TemplateManifestNode(Type controlType, string? name, IReadOnlyList<TemplateManifestNode> children)
    {
        ControlType = controlType ?? throw new ArgumentNullException(nameof(controlType));
        Name = name;
        Children = children ?? throw new ArgumentNullException(nameof(children));
    }

    public Type ControlType { get; }

    public string? Name { get; }

    public IReadOnlyList<TemplateManifestNode> Children { get; }
}
#endif
