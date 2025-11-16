#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Diffing;

using System;
using System.Collections.Generic;
using NXUI.HotReload.Metadata;
using NXUI.HotReload.Nodes;

/// <summary>
/// Computes patch operations between two recorded node trees.
/// </summary>
internal static class TreeDiffer
{
    /// <summary>
    /// Diffs two node trees and appends patch operations to <paramref name="buffer"/>.
    /// </summary>
    /// <param name="previous">The previous node snapshot.</param>
    /// <param name="next">The next node snapshot.</param>
    /// <param name="buffer">Buffer receiving emitted patch operations.</param>
    public static void Compare(ElementNode previous, ElementNode next, List<PatchOp> buffer)
    {
        ArgumentNullException.ThrowIfNull(previous);
        ArgumentNullException.ThrowIfNull(next);
        ArgumentNullException.ThrowIfNull(buffer);

        CompareCore(previous, next, NodePath.Root, buffer);
    }

    private static void CompareCore(ElementNode previous, ElementNode next, NodePath path, List<PatchOp> buffer)
    {
        if (!CanReuse(previous, next))
        {
            buffer.Add(PatchOp.ReplaceSubtree(path, next));
            return;
        }

        next.AdoptInstanceFrom(previous);

        DiffProperties(previous, next, path, buffer);
        DiffEvents(previous, next, path, buffer);
        DiffChildren(previous, next, path, buffer);
    }

    private static bool CanReuse(ElementNode previous, ElementNode next)
    {
        if (!string.Equals(previous.Key, next.Key, StringComparison.Ordinal))
        {
            return false;
        }

        if (previous.TypeId > TypeMetadata.InvalidTypeId
            && next.TypeId > TypeMetadata.InvalidTypeId
            && previous.TypeId != next.TypeId)
        {
            return false;
        }

        if (previous.TypeId == TypeMetadata.InvalidTypeId
            || next.TypeId == TypeMetadata.InvalidTypeId)
        {
            return previous.ControlType == next.ControlType;
        }

        return true;
    }

    private static void DiffProperties(ElementNode previous, ElementNode next, NodePath path, List<PatchOp> buffer)
    {
        var previousMap = BuildPropertyMap(previous.Properties);
        var nextMap = BuildPropertyMap(next.Properties);

        foreach (var (propertyId, nextMutation) in nextMap)
        {
            if (!previousMap.TryGetValue(propertyId, out var previousMutation))
            {
                buffer.Add(PatchOp.ForProperty(path, nextMutation));
                continue;
            }

            if (!PropertyMutationsEqual(previousMutation, nextMutation))
            {
                buffer.Add(PatchOp.ForProperty(path, nextMutation));
            }
        }

        foreach (var (propertyId, previousMutation) in previousMap)
        {
            if (nextMap.ContainsKey(propertyId))
            {
                continue;
            }

            var property = previousMutation.Property ?? previousMutation.Descriptor?.Property;
            if (property is null)
            {
                continue;
            }

            buffer.Add(PatchOp.ClearProperty(path, propertyId, property));
        }
    }

    private static Dictionary<int, PropertyMutation> BuildPropertyMap(IReadOnlyList<PropertyMutation> mutations)
    {
        var map = new Dictionary<int, PropertyMutation>();
        for (var i = 0; i < mutations.Count; i++)
        {
            var mutation = mutations[i];
            if (mutation.PropertyId <= PropertyMetadata.InvalidPropertyId)
            {
                continue;
            }

            map[mutation.PropertyId] = mutation;
        }

        return map;
    }

    private static bool PropertyMutationsEqual(PropertyMutation left, PropertyMutation right)
    {
        if (left.Kind != right.Kind)
        {
            return false;
        }

        if (left.Kind == PropertyMutationKind.SetBinding)
        {
            var leftDescriptor = left.Descriptor;
            var rightDescriptor = right.Descriptor;

            if (leftDescriptor.HasValue != rightDescriptor.HasValue)
            {
                return false;
            }

            if (leftDescriptor.HasValue
                && rightDescriptor.HasValue
                && !leftDescriptor.Value.Equals(rightDescriptor.Value))
            {
                return false;
            }

            return Equals(left.Value, right.Value);
        }

        return Equals(left.Value, right.Value);
    }

    private static void DiffEvents(ElementNode previous, ElementNode next, NodePath path, List<PatchOp> buffer)
    {
        var previousEvents = previous.Events;
        var nextEvents = next.Events;

        if (previousEvents.Count == 0 && nextEvents.Count == 0)
        {
            return;
        }

        var previousLookup = BuildEventLookup(previousEvents);
        var matched = previousEvents.Count == 0 ? Array.Empty<bool>() : new bool[previousEvents.Count];

        for (var i = 0; i < nextEvents.Count; i++)
        {
            var nextEvent = nextEvents[i];
            if (TryMatchEvent(nextEvent, previousLookup, matched, out _))
            {
                continue;
            }

            buffer.Add(PatchOp.AttachEvent(path, nextEvent));
        }

        for (var i = 0; i < matched.Length; i++)
        {
            if (!matched[i])
            {
                buffer.Add(PatchOp.DetachEvent(path, previousEvents[i]));
            }
        }
    }

    private static Dictionary<EventFingerprint, Queue<int>> BuildEventLookup(IReadOnlyList<EventMutation> events)
    {
        var lookup = new Dictionary<EventFingerprint, Queue<int>>();
        for (var i = 0; i < events.Count; i++)
        {
            var fingerprint = events[i].Fingerprint;
            if (fingerprint.IsUnknown)
            {
                continue;
            }

            if (!lookup.TryGetValue(fingerprint, out var queue))
            {
                queue = new Queue<int>();
                lookup[fingerprint] = queue;
            }

            queue.Enqueue(i);
        }

        return lookup;
    }

    private static bool TryMatchEvent(EventMutation mutation, Dictionary<EventFingerprint, Queue<int>> lookup, bool[] matched, out int matchedIndex)
    {
        matchedIndex = -1;
        var fingerprint = mutation.Fingerprint;
        if (fingerprint.IsUnknown)
        {
            return false;
        }

        if (!lookup.TryGetValue(fingerprint, out var queue) || queue.Count == 0)
        {
            return false;
        }

        matchedIndex = queue.Dequeue();
        if (matched.Length > matchedIndex)
        {
            matched[matchedIndex] = true;
        }

        return true;
    }

    private static void DiffChildren(ElementNode previous, ElementNode next, NodePath path, List<PatchOp> buffer)
    {
        var previousChildren = previous.Children;
        var nextChildren = next.Children;

        if (previousChildren.Count == 0 && nextChildren.Count == 0)
        {
            return;
        }

        var matched = previousChildren.Count == 0 ? Array.Empty<bool>() : new bool[previousChildren.Count];
        var previousKeyLookup = BuildKeyLookup(previousChildren);

        for (var i = 0; i < nextChildren.Count; i++)
        {
            var nextChild = nextChildren[i];
            var childPath = path.Append(i, nextChild.Key);
            ElementNode? previousChild = null;
            var matchedIndex = -1;

            if (!string.IsNullOrEmpty(nextChild.Key)
                && previousKeyLookup.TryGetValue(nextChild.Key, out matchedIndex))
            {
                previousChild = previousChildren[matchedIndex];
                matched[matchedIndex] = true;

                if (matchedIndex != i)
                {
                    buffer.Add(PatchOp.MoveChild(path, matchedIndex, i, nextChild.Key));
                }
            }
            else if (i < previousChildren.Count
                && !matched[i]
                && string.IsNullOrEmpty(previousChildren[i].Key))
            {
                previousChild = previousChildren[i];
                matched[i] = true;
            }

            if (previousChild is null)
            {
                buffer.Add(PatchOp.AddChild(path, i, nextChild));
                continue;
            }

            CompareCore(previousChild, nextChild, childPath, buffer);
        }

        for (var i = 0; i < matched.Length; i++)
        {
            if (!matched[i])
            {
                var child = previousChildren[i];
                buffer.Add(PatchOp.RemoveChild(path, i, child.Key));
            }
        }
    }

    private static Dictionary<string, int> BuildKeyLookup(IReadOnlyList<ElementNode> nodes)
    {
        var lookup = new Dictionary<string, int>(StringComparer.Ordinal);
        for (var i = 0; i < nodes.Count; i++)
        {
            var key = nodes[i].Key;
            if (string.IsNullOrEmpty(key))
            {
                continue;
            }

            if (!lookup.ContainsKey(key))
            {
                lookup[key] = i;
            }
        }

        return lookup;
    }
}
#endif
