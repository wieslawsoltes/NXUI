using System;
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
public class ComponentHandleTests
{
    [Fact]
    public void Attach_uses_initial_snapshot()
    {
        var host = new TestHost();
        var initial = Label().Content("Hello");

        var handle = new ComponentHandle(
            "Label",
            () => throw new InvalidOperationException("Factory should not be invoked for initial attach."),
            host,
            _ => { });

        var root = handle.Attach(initial.Node);

        Assert.Same(root, host.AttachedInstance);
        var label = Assert.IsType<Label>(host.AttachedInstance);
        Assert.Equal("Hello", label.Content);
    }

    [Fact]
    public void TryRefresh_updates_existing_root()
    {
        var host = new TestHost();
        var content = "Hello";

        ElementNode CreateNode() => Label().Content(content).Node;

        var handle = new ComponentHandle("Label", CreateNode, host, _ => { });

        handle.Attach(CreateNode());

        content = "Updated";
        handle.TryRefresh("test");

        var label = Assert.IsType<Label>(host.AttachedInstance);
        Assert.Equal("Updated", label.Content);
        Assert.Single(host.Updates);
        Assert.Null(host.Replacement);
    }

    [Fact]
    public void TryRefresh_notifies_replacement()
    {
        var host = new TestHost();
        var useLabel = true;

        ElementNode CreateNode() => useLabel ? Label().Content("L").Node : TextBlock().Text("T").Node;

        var handle = new ComponentHandle("Root", CreateNode, host, _ => { });

        handle.Attach(CreateNode());

        useLabel = false;
        handle.TryRefresh("test");

        Assert.NotNull(host.Replacement);
        Assert.IsType<TextBlock>(host.AttachedInstance);
        Assert.Empty(host.Updates);
    }

    private sealed class TestHost : IComponentHost
    {
        public AvaloniaObject? AttachedInstance { get; private set; }
        public (AvaloniaObject OldRoot, AvaloniaObject NewRoot)? Replacement { get; private set; }
        public List<ReconcileResult> Updates { get; } = new();
        public AvaloniaObject? DisposedInstance { get; private set; }

        public void AttachRoot(AvaloniaObject instance)
        {
            AttachedInstance = instance;
        }

        public void OnRootReplaced(AvaloniaObject oldRoot, AvaloniaObject newRoot)
        {
            Replacement = (oldRoot, newRoot);
            AttachedInstance = newRoot;
        }

        public void OnComponentUpdated(ReconcileResult result)
        {
            Updates.Add(result);
        }

        public void OnComponentDisposed(AvaloniaObject? instance)
        {
            DisposedInstance = instance;
            AttachedInstance = null;
        }
    }
}
