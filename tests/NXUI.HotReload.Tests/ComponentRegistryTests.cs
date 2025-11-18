using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using NXUI.Extensions;
using NXUI.HotReload;
using NXUI.HotReload.Nodes;
using Xunit;
using static NXUI.Builders;

namespace NXUI.HotReload.Tests;

[Collection("HeadlessTests")]
public class ComponentRegistryTests
{
    [Fact]
    public void RefreshMatching_Updates_Only_Affected_Components()
    {
        ComponentFactoryA.Content = "Initial A";
        ComponentFactoryB.Content = "Initial B";

        var registry = new ComponentRegistry();
        var hostA = new RecordingHost();
        var hostB = new RecordingHost();

        var handleA = registry.Register("A", ComponentFactoryA.CreateNode, hostA);
        var handleB = registry.Register("B", ComponentFactoryB.CreateNode, hostB);

        handleA.Attach(ComponentFactoryA.CreateNode());
        handleB.Attach(ComponentFactoryB.CreateNode());

        ComponentFactoryA.Content = "Updated A";
        ComponentFactoryB.Content = "Updated B";

        registry.RefreshMatching(new[] { typeof(ComponentFactoryA) }, "test");

        Assert.Single(hostA.Updates);
        Assert.Empty(hostB.Updates);
    }

    [Fact]
    public void RefreshMatching_WithNullTypes_RefreshesAll()
    {
        ComponentFactoryA.Content = "Initial A";
        ComponentFactoryB.Content = "Initial B";

        var registry = new ComponentRegistry();
        var hostA = new RecordingHost();
        var hostB = new RecordingHost();

        var handleA = registry.Register("A", ComponentFactoryA.CreateNode, hostA);
        var handleB = registry.Register("B", ComponentFactoryB.CreateNode, hostB);

        handleA.Attach(ComponentFactoryA.CreateNode());
        handleB.Attach(ComponentFactoryB.CreateNode());

        ComponentFactoryA.Content = "Updated A";
        ComponentFactoryB.Content = "Updated B";

        registry.RefreshMatching(null, "test");

        Assert.Single(hostA.Updates);
        Assert.Single(hostB.Updates);
    }

    [Fact]
    public void RefreshMatching_Uses_TypeMetadata_For_Filtering()
    {
        ComponentFactoryA.Content = "Initial A";
        ComponentFactoryB.Content = "Initial B";

        var registry = new ComponentRegistry();
        var hostA = new RecordingHost();
        var hostB = new RecordingHost();

        var handleA = registry.Register("A", ComponentFactoryA.CreateNode, hostA);
        var handleB = registry.Register("B", ComponentFactoryB.CreateNode, hostB);

        handleA.Attach(ComponentFactoryA.CreateNode());
        handleB.Attach(ComponentFactoryB.CreateNode());

        ComponentFactoryA.Content = "Updated A";
        ComponentFactoryB.Content = "Updated B";

        registry.RefreshMatching(new[] { typeof(Label) }, "test");

        Assert.Single(hostA.Updates);
        Assert.Empty(hostB.Updates);
    }

    private static class ComponentFactoryA
    {
        public static string Content { get; set; } = "A";

        public static ElementNode CreateNode()
            => Label().Content(Content).Node;
    }

    private static class ComponentFactoryB
    {
        public static string Content { get; set; } = "B";

        public static ElementNode CreateNode()
            => TextBlock().Text(Content).Node;
    }

    private sealed class RecordingHost : IComponentHost
    {
        public AvaloniaObject? AttachedInstance { get; private set; }
        public List<ReconcileResult> Updates { get; } = new();

        public void AttachRoot(AvaloniaObject instance)
        {
            AttachedInstance = instance;
        }

        public void OnRootReplaced(AvaloniaObject oldRoot, AvaloniaObject newRoot)
        {
            AttachedInstance = newRoot;
        }

        public void OnComponentUpdated(ReconcileResult result)
        {
            Updates.Add(result);
        }

        public void OnComponentDisposed(AvaloniaObject? instance)
        {
            AttachedInstance = null;
        }
    }
}
