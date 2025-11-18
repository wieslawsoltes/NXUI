using System;
using System.Reflection;

namespace Generator;

internal static class TypeFormatter
{
    public static string Format(Type type, NullabilityInfo? nullability)
    {
        if (type.IsArray)
        {
            var elementType = type.GetElementType()!;
            var elementNullability = nullability?.ElementType;
            return $"{Format(elementType, elementNullability)}[]";
        }

        string result;

        if (type.IsGenericType)
        {
            var genericTypeDefinition = type.GetGenericTypeDefinition();
            var baseName = GetNonGenericTypeName(genericTypeDefinition);
            var arguments = type.GetGenericArguments();
            var nullabilities = nullability?.GenericTypeArguments;

            var formattedArgs = new string[arguments.Length];
            for (var i = 0; i < arguments.Length; i++)
            {
                var argNullability = nullabilities != null && i < nullabilities.Length ? nullabilities[i] : null;
                formattedArgs[i] = Format(arguments[i], argNullability);
            }

            result = $"{baseName}<{string.Join(", ", formattedArgs)}>";
        }
        else
        {
            result = GetNonGenericTypeName(type);
        }

        if (IsNullableReference(type, nullability))
        {
            result += "?";
        }

        return result;
    }

    private static string GetNonGenericTypeName(Type type)
    {
        var name = type.FullName ?? type.Name;
        var tickIndex = name.IndexOf('`');
        if (tickIndex >= 0)
        {
            name = name.Substring(0, tickIndex);
        }

        return name.Replace("+", ".");
    }

    private static bool IsNullableReference(Type type, NullabilityInfo? nullability)
    {
        return !type.IsValueType && nullability is { ReadState: NullabilityState.Nullable };
    }
}
