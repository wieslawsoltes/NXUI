#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Nodes;

using System;

/// <summary>
/// Lightweight wrapper that allows heterogenous element builders to be passed into APIs that expect control children.
/// </summary>
public readonly struct ElementChildBuilder
{
    internal ElementChildBuilder(ElementNode node)
    {
        Node = node ?? throw new ArgumentNullException(nameof(node));
    }

    internal ElementNode Node { get; }
}
#endif
