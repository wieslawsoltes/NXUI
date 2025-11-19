using System.Collections.Generic;
using Avalonia.Controls;
using NXUI.HotReload;
using NXUI.HotReload.Diffing;
using NXUI.HotReload.Nodes;
using Xunit;

namespace NXUI.HotReload.Tests;

public class BoundaryMetadataTests
{
    [Fact]
    public void AttributeAutomaticallyMarksElementNode()
    {
        var builder = ElementBuilder.Create(() => new AttributeBoundaryControl());
        Assert.True(builder.Node.IsBoundary);
    }

    [Fact]
    public void MarkerInterfaceAutomaticallyMarksElementNode()
    {
        var builder = ElementBuilder.Create(() => new InterfaceBoundaryControl());
        Assert.True(builder.Node.IsBoundary);
    }

    [Fact]
    public void TreeDifferSkipsSubtreeForImplicitBoundary()
    {
        var previous = BuildBoundaryTree("before");
        var next = BuildBoundaryTree("after");

        var ops = new List<PatchOp>();
        TreeDiffer.Compare(previous, next, ops);

        Assert.Empty(ops);
    }

    private static ElementNode BuildBoundaryTree(string childText)
    {
        var rootBuilder = ElementBuilder.Create(() => new AttributeBoundaryControl());
        var childBuilder = ElementBuilder.Create(() => new TextBlock());
        childBuilder.WithAction(block => block.Text = childText);

        rootBuilder.WithChild(
            childBuilder,
            (parent, child) => parent.Content = child,
            ChildSlot.Content);

        return rootBuilder.Node;
    }

    [HotReloadBoundary]
    private sealed class AttributeBoundaryControl : ContentControl
    {
    }

    private sealed class InterfaceBoundaryControl : ContentControl, IHotReloadBoundaryMarker
    {
    }
}
