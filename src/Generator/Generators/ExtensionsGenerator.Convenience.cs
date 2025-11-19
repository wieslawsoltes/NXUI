using System;
using System.Text;
using Reflectonia.Model;

namespace Generator;

public partial class ExtensionsGenerator
{
    private static readonly (string Parameters, string Arguments, string Summary)[] ThicknessConvenienceOverloads =
        new[]
        {
            ("double uniformLength", "uniformLength", "a uniform length"),
            ("double horizontal, double vertical", "horizontal, vertical", "horizontal and vertical lengths"),
            ("double left, double top, double right, double bottom", "left, top, right, bottom", "individual edge lengths")
        };

    private static readonly (string Parameters, string Arguments, string Summary)[] CornerRadiusConvenienceOverloads =
        new[]
        {
            ("double uniformRadius", "uniformRadius", "a uniform radius"),
            ("double top, double bottom", "top, bottom", "top and bottom radii"),
            ("double topLeft, double topRight, double bottomRight, double bottomLeft", "topLeft, topRight, bottomRight, bottomLeft", "per-corner radii")
        };

    private static readonly (string Parameters, string Arguments, string Summary)[] GridLengthConvenienceOverloads =
        new[]
        {
            ("double value", "value", "a pixel value"),
            ("double value, Avalonia.Controls.GridUnitType unitType", "value, unitType", "the specified grid unit type")
        };

    private void EmitConvenienceOverloads(
        Class c,
        Property property,
        (string BuilderType, string BuilderGeneric, string BuilderConstraint, string HandlerType, string HandlerInvocation) builderMeta,
        Action<string> writeLine)
    {
        var valueTypeName = ReflectoniaFactory.ToString(property.ValueType);
        (string Parameters, string Arguments, string Summary)[]? overloads = valueTypeName switch
        {
            "Avalonia.Thickness" => ThicknessConvenienceOverloads,
            "Avalonia.CornerRadius" => CornerRadiusConvenienceOverloads,
            "Avalonia.Controls.GridLength" => GridLengthConvenienceOverloads,
            _ => null
        };

        if (overloads is null)
        {
            return;
        }

        var builderBlock = BuildConvenienceBuilderBlock(c, property, builderMeta, valueTypeName, overloads);
        if (!string.IsNullOrWhiteSpace(builderBlock))
        {
            writeLine(builderBlock);
        }

        var objectBlock = BuildConvenienceObjectBlock(c, property, valueTypeName, overloads);
        if (!string.IsNullOrWhiteSpace(objectBlock))
        {
            writeLine(objectBlock);
        }
    }

    private string BuildConvenienceBuilderBlock(
        Class c,
        Property property,
        (string BuilderType, string BuilderGeneric, string BuilderConstraint, string HandlerType, string HandlerInvocation) builderMeta,
        string valueTypeName,
        (string Parameters, string Arguments, string Summary)[] overloads)
    {
        if (string.IsNullOrEmpty(builderMeta.BuilderType))
        {
            return string.Empty;
        }

        var classTypeName = ReflectoniaFactory.ToString(c.Type);
        var methodName = property.Name;

        var sb = new StringBuilder();

        foreach (var (parameters, arguments, summary) in overloads)
        {
            sb.AppendLine("    /// <summary>");
            sb.AppendLine($"    /// Records a <see cref=\"{classTypeName}.{methodName}Property\"/> literal value using {summary} for hot reload builds.");
            sb.AppendLine("    /// </summary>");
            sb.AppendLine($"    public static {builderMeta.BuilderType} {methodName}{builderMeta.BuilderGeneric}(this {builderMeta.BuilderType} builder, {parameters}){builderMeta.BuilderConstraint}");
            sb.AppendLine("    {");
            sb.AppendLine($"        return builder.{methodName}(new {valueTypeName}({arguments}));");
            sb.AppendLine("    }");
            sb.AppendLine("");
        }

        return sb.ToString();
    }

    private string BuildConvenienceObjectBlock(
        Class c,
        Property property,
        string valueTypeName,
        (string Parameters, string Arguments, string Summary)[] overloads)
    {
        var ownerTypeName = ReflectoniaFactory.ToString(property.OwnerType);
        var classTypeName = ReflectoniaFactory.ToString(c.Type);
        var methodName = property.Name;

        var sb = new StringBuilder();

        foreach (var (parameters, arguments, summary) in overloads)
        {
            sb.AppendLine("    /// <summary>");
            sb.AppendLine($"    /// Sets a <see cref=\"{classTypeName}.{methodName}Property\"/> value using {summary}.");
            sb.AppendLine("    /// </summary>");
            if (c.IsSealed)
            {
                sb.AppendLine($"    public static {ownerTypeName} {methodName}(this {ownerTypeName} obj, {parameters})");
            }
            else
            {
                sb.AppendLine($"    public static T {methodName}<T>(this T obj, {parameters}) where T : {ownerTypeName}");
            }

            sb.AppendLine("    {");
            sb.AppendLine($"        return obj.{methodName}(new {valueTypeName}({arguments}));");
            sb.AppendLine("    }");
            sb.AppendLine("");
        }

        return sb.ToString();
    }

}
