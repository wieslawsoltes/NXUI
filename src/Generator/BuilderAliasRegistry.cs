using System;
using System.Collections.Generic;
using System.Linq;
using Reflectonia;
using Reflectonia.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

internal static class BuilderAliasRegistry
{
    private static readonly Dictionary<string, AliasInfo> Aliases = new();
    private static ReflectoniaFactory? _factory;

    private sealed record AliasInfo(string Alias, string TypeName);

    public static void Initialize(IEnumerable<Class> classes, ReflectoniaFactory factory)
    {
        _factory = factory;
        Aliases.Clear();

        foreach (var c in classes)
        {
            if (!c.PublicCtor || c.IsAbstract)
            {
                continue;
            }

            var typeName = factory.ToString(c.Type);
            var alias = $"{c.Name}Builder";
            Aliases[typeName] = new AliasInfo(alias, typeName);
        }
    }

    public static bool TryGetAlias(Type type, out string alias)
    {
        var key = _factory?.ToString(type) ?? type.FullName ?? type.Name;
        if (key is not null && Aliases.TryGetValue(key, out var info))
        {
            alias = info.Alias;
            return true;
        }

        alias = default!;
        return false;
    }

    public static string FormatBuilderType(Type type)
    {
        if (TryGetAlias(type, out var alias))
        {
            return alias;
        }

        var fallback = _factory?.ToString(type) ?? type.FullName;
        return $"ElementBuilder<{fallback}>";
    }

    public static string FormatBuilderType(Class c)
    {
        return FormatBuilderType(c.Type);
    }

    public static IEnumerable<(string Alias, string TypeName)> GetAliasEntries()
    {
        return Aliases
            .OrderBy(entry => entry.Value.Alias, StringComparer.Ordinal)
            .Select(entry => (entry.Value.Alias, entry.Value.TypeName));
    }
}
