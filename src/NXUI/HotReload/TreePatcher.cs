namespace NXUI.HotReload;

using System;
using System.Collections;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Threading;
using NXUI.HotReload.Diffing;
using NXUI.HotReload.Nodes;

/// <summary>
/// Applies <see cref="PatchOp"/> instructions against the live Avalonia tree.
/// </summary>
internal static class TreePatcher
{
    /// <summary>
    /// Applies the provided patch operations to the live control tree described by <paramref name="rootSnapshot"/>.
    /// </summary>
    internal static TreePatchResult Apply(IReadOnlyList<PatchOp> ops, ElementNode rootSnapshot)
    {
        ArgumentNullException.ThrowIfNull(ops);
        ArgumentNullException.ThrowIfNull(rootSnapshot);

        if (ops.Count == 0)
        {
            return TreePatchResult.FromRoot(rootSnapshot.AdoptedInstance);
        }

        if (Dispatcher.UIThread.CheckAccess())
        {
            using (Dispatcher.UIThread.DisableProcessing())
            {
                return ApplyCore(ops, rootSnapshot);
            }
        }

        return Dispatcher.UIThread.InvokeAsync(() =>
        {
            using (Dispatcher.UIThread.DisableProcessing())
            {
                return ApplyCore(ops, rootSnapshot);
            }
        }).GetAwaiter().GetResult();
    }

    private static TreePatchResult ApplyCore(IReadOnlyList<PatchOp> ops, ElementNode rootSnapshot)
    {
        var executor = new Executor(rootSnapshot);
        for (var i = 0; i < ops.Count; i++)
        {
            executor.Apply(ops[i]);
        }

        return executor.ToResult();
    }

    private sealed class Executor
    {
        private readonly ElementNode _root;
        private AvaloniaObject? _rootInstance;
        private bool _rootReplaced;
        private int _replaceCount;
        private int _setPropertyCount;
        private int _setBindingCount;
        private int _clearPropertyCount;
        private int _addChildCount;
        private int _removeChildCount;
        private int _moveChildCount;
        private int _attachEventCount;
        private int _detachEventCount;

        internal Executor(ElementNode root)
        {
            _root = root;
            _rootInstance = root.AdoptedInstance;
        }

        internal void Apply(PatchOp op)
        {
            switch (op.Kind)
            {
                case PatchOpKind.ReplaceSubtree:
                    ReplaceSubtree(op.Path, op.Node ?? throw new InvalidOperationException("ReplaceSubtree requires payload."));
                    _replaceCount++;
                    break;

                case PatchOpKind.SetProperty:
                    ApplyProperty(op, isBinding: false);
                    _setPropertyCount++;
                    break;

                case PatchOpKind.SetBinding:
                    ApplyProperty(op, isBinding: true);
                    _setBindingCount++;
                    break;

                case PatchOpKind.ClearProperty:
                    ClearProperty(op);
                    _clearPropertyCount++;
                    break;

                case PatchOpKind.AddChild:
                    AddChild(op);
                    _addChildCount++;
                    break;

                case PatchOpKind.RemoveChild:
                    RemoveChild(op);
                    _removeChildCount++;
                    break;

                case PatchOpKind.MoveChild:
                    MoveChild(op);
                    _moveChildCount++;
                    break;

                case PatchOpKind.AttachEvent:
                    AttachEvent(op);
                    _attachEventCount++;
                    break;

                case PatchOpKind.DetachEvent:
                    DetachEvent(op);
                    _detachEventCount++;
                    break;
            }
        }

        internal TreePatchResult ToResult()
        {
            return new TreePatchResult(
                _rootInstance,
                _rootReplaced,
                _replaceCount,
                _setPropertyCount,
                _setBindingCount,
                _clearPropertyCount,
                _addChildCount,
                _removeChildCount,
                _moveChildCount,
                _attachEventCount,
                _detachEventCount);
        }

        private void ReplaceSubtree(NodePath path, ElementNode node)
        {
            if (path.Segments.Length == 0)
            {
                _rootInstance = NodeRenderer.Instance.Build(node);
                _rootReplaced = true;
                return;
            }

            var (parentNode, segment) = ResolveParent(_root, path);
            var parentInstance = RequireInstance(parentNode);

            var slot = node.ParentSlot;
            RemoveChildCore(parentInstance, segment.Index, slot);
            var replacement = EnsureNodeInstance(node);
            AttachChildCore(parentInstance, segment.Index, replacement, slot);
        }

        private void ApplyProperty(PatchOp op, bool isBinding)
        {
            var targetNode = ResolveNode(_root, op.Path);
            var instance = RequireInstance(targetNode);
            op.Property?.Apply(instance);

            if (!isBinding && op.Property is null)
            {
                throw new InvalidOperationException("Property payload missing for SetProperty operation.");
            }
        }

        private void ClearProperty(PatchOp op)
        {
            var targetNode = ResolveNode(_root, op.Path);
            var instance = RequireInstance(targetNode);
            if (op.AvaloniaProperty is null)
            {
                throw new InvalidOperationException("ClearProperty operation missing AvaloniaProperty payload.");
            }

            instance.ClearValue(op.AvaloniaProperty);
        }

        private void AddChild(PatchOp op)
        {
            if (op.Node is null)
            {
                throw new InvalidOperationException("AddChild requires a node payload.");
            }

            var parentNode = ResolveNode(_root, op.Path);
            var parentInstance = RequireInstance(parentNode);
            var childInstance = EnsureNodeInstance(op.Node);
            var slot = op.Node.ParentSlot;
            AttachChildCore(parentInstance, op.Index, childInstance, slot);
        }

        private void RemoveChild(PatchOp op)
        {
            var parentNode = ResolveNode(_root, op.Path);
            var parentInstance = RequireInstance(parentNode);
            var childSlot = TryGetChildSlot(parentNode, op.Index);
            RemoveChildCore(parentInstance, op.Index, childSlot);
        }

        private void MoveChild(PatchOp op)
        {
            var parentNode = ResolveNode(_root, op.Path);
            var parentInstance = RequireInstance(parentNode);
            var childSlot = TryGetChildSlot(parentNode, op.Index);
            MoveChildCore(parentInstance, op.Index, op.ToIndex, childSlot);
        }

        private void AttachEvent(PatchOp op)
        {
            if (op.Event is null)
            {
                return;
            }

            var targetNode = ResolveNode(_root, op.Path);
            var instance = RequireInstance(targetNode);
            op.Event.Attach(instance);
        }

        private void DetachEvent(PatchOp op)
        {
            if (op.Event is null)
            {
                return;
            }

            var targetNode = ResolveNode(_root, op.Path);
            var instance = RequireInstance(targetNode);
            op.Event.Detach(instance);
        }

        private static ElementNode ResolveNode(ElementNode root, NodePath path)
        {
            var current = root;
            foreach (var segment in path.Segments)
            {
                var children = current.Children;
                if ((uint)segment.Index >= (uint)children.Count)
                {
                    throw new InvalidOperationException($"NodePath segment index '{segment.Index}' is out of range for '{current.ControlType}'.");
                }

                current = children[segment.Index];
            }

            return current;
        }

        private static (ElementNode ParentNode, NodePathSegment Segment) ResolveParent(ElementNode root, NodePath path)
        {
            var segments = path.Segments;
            if (segments.Length == 0)
            {
                throw new InvalidOperationException("Cannot resolve the parent for the root node.");
            }

            var current = root;
            for (var i = 0; i < segments.Length - 1; i++)
            {
                var index = segments[i].Index;
                var children = current.Children;
                if ((uint)index >= (uint)children.Count)
                {
                    throw new InvalidOperationException($"Parent resolution failed. Segment '{index}' exceeded child bounds for '{current.ControlType}'.");
                }

                current = children[index];
            }

            return (current, segments[^1]);
        }

        private static AvaloniaObject RequireInstance(ElementNode node)
        {
            var instance = node.AdoptedInstance;
            return instance ?? throw new InvalidOperationException($"Node '{node.ControlType}' has not been materialized yet.");
        }

        private static AvaloniaObject EnsureNodeInstance(ElementNode node)
        {
            if (node.AdoptedInstance is { } existing)
            {
                node.SetMaterializedInstance(existing);
                return existing;
            }

            return NodeRenderer.Instance.Build(node);
        }

        private static void AttachChildCore(AvaloniaObject parent, int index, AvaloniaObject child, ChildSlot slot)
        {
            if (TryAttachBySlot(parent, index, child, slot))
            {
                return;
            }

            switch (parent)
            {
                case ContentControl contentControl:
                    contentControl.Content = child;
                    break;

                case Decorator decorator when child is Control controlChild:
                    decorator.Child = controlChild;
                    break;

                case Panel panel when child is Control panelChild:
                    index = Math.Clamp(index, 0, panel.Children.Count);
                    panel.Children.Insert(index, panelChild);
                    break;

                case ItemsControl itemsControl:
                    var items = EnsureItemList(itemsControl);
                    index = Math.Clamp(index, 0, items.Count);
                    items.Insert(index, child);
                    break;

                default:
                    throw new InvalidOperationException($"Child attachment for parent type '{parent.GetType().FullName}' is not supported yet.");
            }
        }

        private static void RemoveChildCore(AvaloniaObject parent, int index, ChildSlot slot)
        {
            if (TryRemoveBySlot(parent, index, slot))
            {
                return;
            }

            switch (parent)
            {
                case ContentControl contentControl:
                    contentControl.Content = null;
                    break;

                case Decorator decorator:
                    decorator.Child = null;
                    break;

                case Panel panel:
                    if (panel.Children.Count == 0)
                    {
                        return;
                    }

                    index = Math.Clamp(index, 0, panel.Children.Count - 1);
                    panel.Children.RemoveAt(index);
                    break;

                case ItemsControl itemsControl:
                    var items = EnsureItemList(itemsControl);
                    if (items.Count == 0)
                    {
                        return;
                    }

                    index = Math.Clamp(index, 0, items.Count - 1);
                    items.RemoveAt(index);
                    break;

                default:
                    throw new InvalidOperationException($"Child removal for parent type '{parent.GetType().FullName}' is not supported yet.");
            }
        }

        private static void MoveChildCore(AvaloniaObject parent, int fromIndex, int toIndex, ChildSlot slot)
        {
            if (TryMoveBySlot(parent, fromIndex, toIndex, slot))
            {
                return;
            }

            switch (parent)
            {
                case Panel panel:
                    if (panel.Children.Count == 0)
                    {
                        return;
                    }

                    fromIndex = Math.Clamp(fromIndex, 0, panel.Children.Count - 1);
                    toIndex = Math.Clamp(toIndex, 0, panel.Children.Count - 1);

                    if (fromIndex == toIndex)
                    {
                        return;
                    }

                    var child = panel.Children[fromIndex];
                    panel.Children.RemoveAt(fromIndex);
                    panel.Children.Insert(toIndex, child);
                    break;

                case ItemsControl itemsControl:
                    var items = EnsureItemList(itemsControl);
                    if (items.Count == 0)
                    {
                        return;
                    }

                    fromIndex = Math.Clamp(fromIndex, 0, items.Count - 1);
                    toIndex = Math.Clamp(toIndex, 0, items.Count - 1);

                    if (fromIndex == toIndex)
                    {
                        return;
                    }

                    var value = items[fromIndex];
                    items.RemoveAt(fromIndex);
                    items.Insert(toIndex, value);
                    break;

                default:
                    throw new InvalidOperationException($"Child move for parent type '{parent.GetType().FullName}' is not supported yet.");
            }
        }

        private static ChildSlot TryGetChildSlot(ElementNode parent, int index)
        {
            var children = parent.Children;
            if ((uint)index >= (uint)children.Count)
            {
                return ChildSlot.Unknown;
            }

            return children[index].ParentSlot;
        }

        private static bool TryAttachBySlot(AvaloniaObject parent, int index, AvaloniaObject child, ChildSlot slot)
        {
            switch (slot)
            {
                case ChildSlot.Content:
                    if (parent is ContentControl contentControl)
                    {
                        contentControl.Content = child;
                        return true;
                    }

                    if (parent is ContentPresenter contentPresenter)
                    {
                        contentPresenter.Content = child;
                        return true;
                    }

                    if (parent is Decorator decorator && child is Control controlChild)
                    {
                        decorator.Child = controlChild;
                        return true;
                    }

                    break;

                case ChildSlot.Visual:
                    if (parent is Panel panel && child is Control control)
                    {
                        index = Math.Clamp(index, 0, panel.Children.Count);
                        panel.Children.Insert(index, control);
                        return true;
                    }

                    break;

                case ChildSlot.Items:
                    if (parent is ItemsControl itemsControl)
                    {
                        var items = EnsureItemList(itemsControl);
                        index = Math.Clamp(index, 0, items.Count);
                        items.Insert(index, child);
                        return true;
                    }

                    break;

                case ChildSlot.Template:
                    // Future template hosts can hook in here.
                    break;
            }

            return false;
        }

        private static bool TryRemoveBySlot(AvaloniaObject parent, int index, ChildSlot slot)
        {
            switch (slot)
            {
                case ChildSlot.Content:
                    if (parent is ContentControl contentControl)
                    {
                        contentControl.Content = null;
                        return true;
                    }

                    if (parent is ContentPresenter contentPresenter)
                    {
                        contentPresenter.Content = null;
                        return true;
                    }

                    if (parent is Decorator decorator)
                    {
                        decorator.Child = null;
                        return true;
                    }

                    break;

                case ChildSlot.Visual:
                    if (parent is Panel panel)
                    {
                        if (panel.Children.Count == 0)
                        {
                            return true;
                        }

                        index = Math.Clamp(index, 0, panel.Children.Count - 1);
                        panel.Children.RemoveAt(index);
                        return true;
                    }

                    break;

                case ChildSlot.Items:
                    if (parent is ItemsControl itemsControl)
                    {
                        var items = EnsureItemList(itemsControl);
                        if (items.Count == 0)
                        {
                            return true;
                        }

                        index = Math.Clamp(index, 0, items.Count - 1);
                        items.RemoveAt(index);
                        return true;
                    }

                    break;

                case ChildSlot.Template:
                    break;
            }

            return false;
        }

        private static bool TryMoveBySlot(AvaloniaObject parent, int fromIndex, int toIndex, ChildSlot slot)
        {
            switch (slot)
            {
                case ChildSlot.Visual:
                    if (parent is Panel panel)
                    {
                        if (panel.Children.Count == 0)
                        {
                            return true;
                        }

                        fromIndex = Math.Clamp(fromIndex, 0, panel.Children.Count - 1);
                        toIndex = Math.Clamp(toIndex, 0, panel.Children.Count - 1);

                        if (fromIndex == toIndex)
                        {
                            return true;
                        }

                        var child = panel.Children[fromIndex];
                        panel.Children.RemoveAt(fromIndex);
                        panel.Children.Insert(toIndex, child);
                        return true;
                    }

                    break;

                case ChildSlot.Items:
                    if (parent is ItemsControl itemsControl)
                    {
                        var items = EnsureItemList(itemsControl);
                        if (items.Count == 0)
                        {
                            return true;
                        }

                        fromIndex = Math.Clamp(fromIndex, 0, items.Count - 1);
                        toIndex = Math.Clamp(toIndex, 0, items.Count - 1);

                        if (fromIndex == toIndex)
                        {
                            return true;
                        }

                        var value = items[fromIndex];
                        items.RemoveAt(fromIndex);
                        items.Insert(toIndex, value);
                        return true;
                    }

                    break;
            }

            return false;
        }

        private static IList EnsureItemList(ItemsControl itemsControl)
        {
            if (itemsControl.ItemsSource is IList source && !source.IsReadOnly)
            {
                return source;
            }

            if (itemsControl.Items is IList items && !items.IsReadOnly)
            {
                return items;
            }

            var replacement = new AvaloniaList<object>();
            itemsControl.ItemsSource = replacement;
            return replacement;
        }
    }
}

/// <summary>
/// Aggregates patch execution results.
/// </summary>
internal readonly record struct TreePatchResult(
    AvaloniaObject? RootInstance,
    bool ReplacedRoot,
    int ReplaceSubtreeCount,
    int SetPropertyCount,
    int SetBindingCount,
    int ClearPropertyCount,
    int AddChildCount,
    int RemoveChildCount,
    int MoveChildCount,
    int AttachEventCount,
    int DetachEventCount)
{
    internal static TreePatchResult FromRoot(AvaloniaObject? root)
    {
        return new TreePatchResult(root, false, 0, 0, 0, 0, 0, 0, 0, 0, 0);
    }
}
