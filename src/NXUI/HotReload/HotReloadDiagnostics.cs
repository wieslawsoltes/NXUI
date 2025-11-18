namespace NXUI.HotReload;

using System;
using System.Diagnostics;
#if NXUI_HOTRELOAD
using System.Text;
using NXUI.HotReload.Diffing;
using NXUI.HotReload.Nodes;
#endif

/// <summary>
/// Centralized diagnostics helper gated behind the NXUI_HOTRELOAD_DIAGNOSTICS environment switch.
/// </summary>
internal static class HotReloadDiagnostics
{
    private const string Category = "NXUI.HotReload";
    private const string DiagnosticsEnvVariable = "NXUI_HOTRELOAD_DIAGNOSTICS";
    private const string SnapshotEnvVariable = "NXUI_HOTRELOAD_SNAPSHOT";
#if NXUI_HOTRELOAD
    private static readonly bool s_enabled = IsFlagEnabled(DiagnosticsEnvVariable);
    private static readonly bool s_emitSnapshots = IsFlagEnabled(SnapshotEnvVariable);
#else
    private const bool s_enabled = false;
    private const bool s_emitSnapshots = false;
#endif

    internal static bool IsEnabled => s_enabled;

    public static void Trace(string message)
    {
#if NXUI_HOTRELOAD
        if (!s_enabled)
        {
            return;
        }

        WriteDebug(message);
#else
        _ = message;
#endif
    }

#if NXUI_HOTRELOAD
    internal static void TracePatchStart(ElementNode previous, ElementNode next)
    {
        if (!s_enabled)
        {
            return;
        }

        var builder = new StringBuilder();
        builder.Append("[HotReload] reconcile start: prev=")
            .Append(DescribeNode(previous))
            .Append(" next=")
            .Append(DescribeNode(next));

        WriteDebug(builder.ToString());
    }

    internal static void TracePatchOp(in PatchOp op)
    {
        if (!s_enabled)
        {
            return;
        }

        var builder = new StringBuilder();
        builder.Append("[HotReload] op=")
            .Append(op.Kind)
            .Append(" path=")
            .Append(op.Path.ToString());

        var payload = DescribePatchPayload(op);
        if (payload.Length > 0)
        {
            builder.Append(' ').Append(payload);
        }

        WriteDebug(builder.ToString());
    }

    internal static void TracePatchSummary(ReconcileResult result, ElementNode rootNode)
    {
        HotReloadEventSource.Log.PatchSummary(result, DescribeNode(rootNode));
        if (s_emitSnapshots)
        {
            EmitSnapshot(rootNode);
        }

        if (!s_enabled)
        {
            return;
        }

        var summary =
            $"[HotReload] reconcile summary ({DescribeNode(rootNode)}): replace={result.ReplaceSubtreeCount}, set={result.SetPropertyCount}, bind={result.SetBindingCount}, clear={result.ClearPropertyCount}, add={result.AddChildCount}, remove={result.RemoveChildCount}, move={result.MoveChildCount}, attachEvt={result.AttachEventCount}, detachEvt={result.DetachEventCount}, rootReplaced={result.ReplacedRoot}";

        WriteDebug(summary);
    }

    internal static void TraceBoundaryShortCircuit(ElementNode node, NodePath path, string reason)
    {
        var pathText = path.ToString();
        var nodeDescription = DescribeNode(node);
        HotReloadEventSource.Log.BoundaryShortCircuit(pathText, nodeDescription, reason ?? string.Empty);

        if (!s_enabled)
        {
            return;
        }

        var builder = new StringBuilder();
        builder.Append("[HotReload] boundary short-circuit path=")
            .Append(pathText)
            .Append(" node=")
            .Append(nodeDescription)
            .Append(" reason=")
            .Append(string.IsNullOrWhiteSpace(reason) ? "Unknown" : reason);

        WriteDebug(builder.ToString());
    }

    private static string DescribePatchPayload(in PatchOp op)
    {
        return op.Kind switch
        {
            PatchOpKind.ReplaceSubtree => $"node={DescribeNode(op.Node)}",
            PatchOpKind.SetProperty or PatchOpKind.SetBinding
                => $"propertyId={op.PropertyId} property={DescribeProperty(op.Property)}",
            PatchOpKind.ClearProperty
                => $"propertyId={op.PropertyId} property={op.AvaloniaProperty?.Name ?? "unknown"}",
            PatchOpKind.AddChild
                => $"index={op.Index} key={op.Key ?? "<none>"} node={DescribeNode(op.Node)}",
            PatchOpKind.RemoveChild
                => $"index={op.Index} key={op.Key ?? "<none>"}",
            PatchOpKind.MoveChild
                => $"from={op.Index} to={op.ToIndex} key={op.Key ?? "<none>"}",
            PatchOpKind.AttachEvent
                => $"event={DescribeEvent(op.Event)}",
            PatchOpKind.DetachEvent
                => $"event={DescribeEvent(op.Event)}",
            _ => string.Empty,
        };
    }

    private static string DescribeNode(ElementNode? node)
    {
        if (node is null)
        {
            return "<null>";
        }

        var typeName = node.ControlType?.Name ?? node.ControlType?.FullName ?? "Unknown";
        return string.IsNullOrEmpty(node.Key) ? typeName : $"{typeName} (key:{node.Key})";
    }

    private static string DescribeProperty(PropertyMutation? mutation)
    {
        if (mutation is null)
        {
            return "unknown";
        }

        if (mutation.Property is { } property)
        {
            return property.Name;
        }

        if (mutation.Descriptor.HasValue)
        {
            return mutation.Descriptor.Value.Property.Name;
        }

        return "unknown";
    }

    private static string DescribeEvent(EventMutation? mutation)
    {
        if (mutation is null)
        {
            return "unknown";
        }

        var fingerprint = mutation.Fingerprint;
        if (fingerprint.IsUnknown)
        {
            return "unknown";
        }

        var owner = fingerprint.OwnerType?.Name ?? fingerprint.OwnerType?.FullName ?? "UnknownOwner";
        var handler = fingerprint.HandlerMethod?.Name ?? "UnknownHandler";
        var eventName = fingerprint.EventName ?? "UnknownEvent";
        return $"{owner}.{eventName} -> {handler}";
    }

    private static void EmitSnapshot(ElementNode rootNode)
    {
        var json = ElementNodeSerializer.Serialize(rootNode);
        HotReloadEventSource.Log.NodeSnapshot(json);
    }

    private static void WriteDebug(string message)
    {
        Debug.WriteLine(message, Category);
        Console.WriteLine(message);
    }

    internal static void TraceStateTransfer(Type adapterType, Type sourceType, Type targetType)
    {
        if (!s_enabled)
        {
            return;
        }

        var adapterName = adapterType?.Name ?? adapterType?.FullName ?? "UnknownAdapter";
        var sourceName = sourceType?.Name ?? sourceType?.FullName ?? "UnknownSource";
        var targetName = targetType?.Name ?? targetType?.FullName ?? "UnknownTarget";

        WriteDebug($"[HotReload] state transfer adapter={adapterName} source={sourceName} target={targetName}");
    }

    private static bool IsFlagEnabled(string variable)
    {
        var value = Environment.GetEnvironmentVariable(variable);
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        value = value.Trim();
        return value.Equals("1", StringComparison.OrdinalIgnoreCase)
            || value.Equals("true", StringComparison.OrdinalIgnoreCase)
            || value.Equals("yes", StringComparison.OrdinalIgnoreCase)
            || value.Equals("on", StringComparison.OrdinalIgnoreCase);
    }
#endif
}
