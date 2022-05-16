using System.Diagnostics.CodeAnalysis;

// ReSharper disable once CheckNamespace
namespace Generator;

[SuppressMessage("ReSharper", "InconsistentNaming")]
internal static partial class Templates
{
    public static string ClassExtensionsHeaderTemplate = @"
public static partial class %ClassName%Extensions
{";

    public static string ClassExtensionsFooterTemplate = @"}";
}
