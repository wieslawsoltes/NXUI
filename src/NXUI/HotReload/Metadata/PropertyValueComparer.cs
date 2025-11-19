namespace NXUI.HotReload.Metadata;

/// <summary>
/// Delegate used to compare property values for equality.
/// </summary>
/// <param name="left">The previous value.</param>
/// <param name="right">The next value.</param>
/// <returns>True when the values are considered equal.</returns>
internal delegate bool PropertyValueComparer(object? left, object? right);
