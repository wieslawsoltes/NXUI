using System.Text;

// ReSharper disable once CheckNamespace
namespace Generator;

internal static class MetadataNameUtility
{
    public static string GetTypeConstName(string typeName)
    {
        return Sanitize(typeName);
    }

    public static string GetPropertyConstName(string ownerName, string propertyName)
    {
        return Sanitize($"{ownerName}_{propertyName}");
    }

    private static string Sanitize(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return "_";
        }

        var builder = new StringBuilder(value.Length);
        for (var i = 0; i < value.Length; i++)
        {
            var ch = value[i];
            if (char.IsLetterOrDigit(ch) || ch == '_')
            {
                builder.Append(ch);
                continue;
            }

            builder.Append('_');
        }

        if (builder.Length == 0)
        {
            builder.Append('_');
        }

        if (char.IsDigit(builder[0]))
        {
            builder.Insert(0, '_');
        }

        return builder.ToString();
    }
}
