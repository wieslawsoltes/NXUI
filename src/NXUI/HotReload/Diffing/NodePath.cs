#if NXUI_HOTRELOAD
namespace NXUI.HotReload.Diffing;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

/// <summary>
/// Represents the position of a node within the logical tree so patch operations can reference targets deterministically.
/// </summary>
public readonly struct NodePath : IEquatable<NodePath>
{
    private static readonly NodePathSegment[] s_empty = Array.Empty<NodePathSegment>();
    private readonly NodePathSegment[]? _segments;

    private NodePath(NodePathSegment[]? segments)
    {
        _segments = segments;
    }

    /// <summary>
    /// Gets the root path.
    /// </summary>
    public static NodePath Root { get; } = new(null);

    /// <summary>
    /// Gets the recorded segments for this path.
    /// </summary>
    public ReadOnlySpan<NodePathSegment> Segments => _segments ?? s_empty;

    /// <summary>
    /// Appends a new segment.
    /// </summary>
    public NodePath Append(int childIndex, string? key = null)
    {
        return Append(new NodePathSegment(childIndex, key));
    }

    /// <summary>
    /// Appends a new segment.
    /// </summary>
    public NodePath Append(NodePathSegment segment)
    {
        var length = _segments?.Length ?? 0;
        var next = new NodePathSegment[length + 1];
        if (length > 0)
        {
            Array.Copy(_segments!, next, length);
        }

        next[length] = segment;
        return new NodePath(next);
    }

    /// <inheritdoc/>
    public bool Equals(NodePath other)
    {
        if ((_segments?.Length ?? 0) != (other._segments?.Length ?? 0))
        {
            return false;
        }

        if (_segments is null && other._segments is null)
        {
            return true;
        }

        return _segments!.SequenceEqual(other._segments!);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is NodePath other && Equals(other);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        if (_segments is not null)
        {
            for (var i = 0; i < _segments.Length; i++)
            {
                hash.Add(_segments[i]);
            }
        }

        return hash.ToHashCode();
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        if (_segments is null || _segments.Length == 0)
        {
            return "/";
        }

        var builder = new StringBuilder();
        builder.Append('/');

        for (var i = 0; i < _segments.Length; i++)
        {
            if (i > 0)
            {
                builder.Append('/');
            }

            builder.Append(_segments[i].ToString());
        }

        return builder.ToString();
    }
}

/// <summary>
/// Describes a segment of a <see cref="NodePath"/>.
/// </summary>
public readonly struct NodePathSegment : IEquatable<NodePathSegment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NodePathSegment"/> struct.
    /// </summary>
    public NodePathSegment(int index, string? key = null)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        Index = index;
        Key = key;
    }

    /// <summary>
    /// Gets the child index at this level.
    /// </summary>
    public int Index { get; }

    /// <summary>
    /// Gets the optional key associated with the node.
    /// </summary>
    public string? Key { get; }

    /// <inheritdoc/>
    public bool Equals(NodePathSegment other)
    {
        return Index == other.Index
            && string.Equals(Key, other.Key, StringComparison.Ordinal);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is NodePathSegment other && Equals(other);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return HashCode.Combine(Index, Key);
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        var index = Index.ToString(CultureInfo.InvariantCulture);
        return Key is null ? index : $"{index}:{Key}";
    }
}
#endif
