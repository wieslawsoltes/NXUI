namespace NXUI.HotReload;

using System.Buffers;
using System.Text;
using System.Text.Json;
using NXUI.HotReload.Nodes;

/// <summary>
/// Serializes <see cref="ElementNode"/> trees for diagnostics tooling.
/// </summary>
internal static class ElementNodeSerializer
{
    internal static string Serialize(ElementNode root)
    {
        var buffer = new ArrayBufferWriter<byte>();
        using var writer = new Utf8JsonWriter(buffer, new JsonWriterOptions
        {
            Indented = true,
        });

        WriteNode(writer, root);
        writer.Flush();
        return Encoding.UTF8.GetString(buffer.WrittenSpan);
    }

    private static void WriteNode(Utf8JsonWriter writer, ElementNode node)
    {
        writer.WriteStartObject();
        writer.WriteString("type", node.ControlType?.FullName ?? "Unknown");

        if (!string.IsNullOrEmpty(node.Key))
        {
            writer.WriteString("key", node.Key);
        }

        if (node.IsBoundary)
        {
            writer.WriteBoolean("boundary", true);
        }

        writer.WriteStartArray("children");
        var children = node.Children;
        for (var i = 0; i < children.Count; i++)
        {
            WriteNode(writer, children[i]);
        }

        writer.WriteEndArray();
        writer.WriteEndObject();
    }
}
