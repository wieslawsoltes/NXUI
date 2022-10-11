using System.Diagnostics.CodeAnalysis;

// ReSharper disable once CheckNamespace
namespace Generator;

[SuppressMessage("ReSharper", "InconsistentNaming")]
internal static partial class Templates
{
    public static string EventsHeaderTemplate = @"namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage(""ReSharper"", ""InconsistentNaming"")]
[System.Diagnostics.CodeAnalysis.SuppressMessage(""ReSharper"", ""RedundantNameQualifier"")]
public static partial class MinimalAvaloniaEvents
{";

    public static string EventTemplate = @"    /// <summary>
    /// The <see cref=""%ClassType%.%EventName%Event""/> event defined in <see cref=""%ClassType%""/> class.
    /// </summary>
    public static %EventType% %ClassName%%EventName% => %ClassType%.%EventName%Event;";

    public static string EventsFooterTemplate = @"}";
}
