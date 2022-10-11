using System.Diagnostics.CodeAnalysis;

// ReSharper disable once CheckNamespace
namespace Generator;

[SuppressMessage("ReSharper", "InconsistentNaming")]
internal static partial class Templates
{
    public static string PropertiesHeaderTemplate = @"namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage(""ReSharper"", ""InconsistentNaming"")]
[System.Diagnostics.CodeAnalysis.SuppressMessage(""ReSharper"", ""RedundantNameQualifier"")]
public static partial class MinimalAvaloniaProperties
{";

    public static string PropertyTemplate = @"    /// <summary>
    /// The <see cref=""%ClassType%.%PropertyName%Property""/> property defined in <see cref=""%ClassType%""/> class.
    /// </summary>
    public static %PropertyType% %ClassName%%PropertyName% => %ClassType%.%PropertyName%Property;";

    public static string PropertiesFooterTemplate = @"}";
}
