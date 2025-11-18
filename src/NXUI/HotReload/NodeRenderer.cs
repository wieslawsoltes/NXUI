namespace NXUI.HotReload;

using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using NXUI.HotReload.Diffing;
using NXUI.HotReload.Nodes;

/// <summary>
/// Materializes recorded element nodes into live Avalonia controls.
/// </summary>
public sealed class NodeRenderer
{
    /// <summary>
    /// Gets the shared renderer instance.
    /// </summary>
    public static NodeRenderer Instance { get; } = new();

    private NodeRenderer()
    {
    }

    /// <summary>
    /// Builds a control tree from the provided node.
    /// </summary>
    public AvaloniaObject Build(ElementNode node)
    {
        ArgumentNullException.ThrowIfNull(node);
        return BuildNode(node);
    }

    /// <summary>
    /// Builds a child node and attaches it to the provided parent control.
    /// </summary>
    public AvaloniaObject BuildChild(ElementNode node, Control parent)
    {
        ArgumentNullException.ThrowIfNull(node);
        ArgumentNullException.ThrowIfNull(parent);

        var child = BuildNode(node);
        AttachChild(parent, child);
        return child;
    }

    /// <summary>
    /// Diffs <paramref name="previous"/> and <paramref name="next"/> and applies the resulting patch instructions.
    /// </summary>
    public ReconcileResult Reconcile(ElementNode previous, ElementNode next)
    {
        ArgumentNullException.ThrowIfNull(previous);
        ArgumentNullException.ThrowIfNull(next);

        var currentRoot = previous.AdoptedInstance
            ?? throw new InvalidOperationException("Previous node tree has not been materialized.");

        HotReloadDiagnostics.TracePatchStart(previous, next);

        var ops = new List<PatchOp>();
        TreeDiffer.Compare(previous, next, ops);
        EmitOperationDiagnostics(ops);

        if (ops.Count == 0)
        {
            var noChangeResult = new ReconcileResult(
                currentRoot,
                ReplacedRoot: false,
                ReplaceSubtreeCount: 0,
                SetPropertyCount: 0,
                SetBindingCount: 0,
                ClearPropertyCount: 0,
                AddChildCount: 0,
                RemoveChildCount: 0,
                MoveChildCount: 0,
                AttachEventCount: 0,
                DetachEventCount: 0);

            HotReloadDiagnostics.TracePatchSummary(noChangeResult, next);
            return noChangeResult;
        }

        var patchResult = TreePatcher.Apply(ops, next);
        var rootInstance = patchResult.RootInstance ?? currentRoot;

        var result = new ReconcileResult(
            rootInstance,
            patchResult.ReplacedRoot,
            patchResult.ReplaceSubtreeCount,
            patchResult.SetPropertyCount,
            patchResult.SetBindingCount,
            patchResult.ClearPropertyCount,
            patchResult.AddChildCount,
            patchResult.RemoveChildCount,
            patchResult.MoveChildCount,
            patchResult.AttachEventCount,
            patchResult.DetachEventCount);

        HotReloadDiagnostics.TracePatchSummary(result, next);
        return result;
    }

    private static AvaloniaObject BuildNode(ElementNode node)
    {
        var instance = node.Instantiate();
        ApplyMutations(instance, node);
        node.SetMaterializedInstance(instance);
        return instance;
    }

    private static void ApplyMutations(AvaloniaObject instance, ElementNode node)
    {
        foreach (var mutation in node.Properties)
        {
            mutation.Apply(instance);
        }

        foreach (var evt in node.Events)
        {
            evt.Attach(instance);
        }
    }

    private static void AttachChild(Control parent, AvaloniaObject child)
    {
        if (parent is ContentControl contentControl)
        {
            contentControl.Content = child;
            return;
        }

        if (parent is Panel panel && child is Control control)
        {
            panel.Children.Add(control);
            return;
        }

        if (parent is ItemsControl itemsControl)
        {
            itemsControl.ItemsSource = new[] { child };
            return;
        }

        throw new InvalidOperationException($"Cannot attach child to control of type '{parent.GetType().FullName}'.");
    }

    private static void EmitOperationDiagnostics(List<PatchOp> ops)
    {
        if (!HotReloadDiagnostics.IsEnabled || ops.Count == 0)
        {
            return;
        }

        for (var i = 0; i < ops.Count; i++)
        {
            HotReloadDiagnostics.TracePatchOp(ops[i]);
        }
    }
}
