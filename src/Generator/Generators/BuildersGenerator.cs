using System.Reflection;
using System.Text;
using Reflectonia;
using Reflectonia.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

public class BuildersGenerator
{
    public BuildersGenerator(ReflectoniaFactory reflectoniaFactory, IReflectoniaLog log)
    {
        ReflectoniaFactory = reflectoniaFactory;
        Log = log;
    }

    private ReflectoniaFactory ReflectoniaFactory { get; }

    private IReflectoniaLog Log { get; }

    public void Generate(string outputPath, List<Class> classes)
    {
        for (var i = 0; i < classes.Count; i++)
        {
            var c = classes[i];

            if (!c.PublicCtor)
            {
                continue;
            }

            if (c.IsAbstract)
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"{c.Name}.Builders.g.cs");

            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.BuildersHeaderTemplate);

            fileHeaderBuilder.Replace("%Namespace%", "");

            WriteLine(fileHeaderBuilder.ToString());

            var builders = GetBuilders(c.Type);
            WriteLine(builders);

            /*
            var buildersBuilder = new StringBuilder(Templates.BuildersTemplate);
            buildersBuilder.Replace("%ClassName%", c.Name);
            buildersBuilder.Replace("%ClassType%", Factory.ToString(c.Type));
            WriteLine(buildersBuilder.ToString());
            */

            var classFooterBuilder = new StringBuilder(Templates.BuildersFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }

    private string GetBuilders(Type type)
    {
        var sb = new StringBuilder();
        var constructors = type.GetConstructors();

        for (var i = 0; i < constructors.Length; i++)
        {
            var constructor = constructors[i];

            AddBuilder(type, constructor, includeRefParam: false, sb);

            sb.AppendLine();
            sb.AppendLine();

            AddBuilder(type, constructor, includeRefParam: true, sb);

            if (i < constructors.Length - 1)
            {
                sb.AppendLine();
                sb.AppendLine();
            }
        }

        return sb.ToString();
    }

    private void AddBuilder(Type type, ConstructorInfo constructor, bool includeRefParam, StringBuilder sb)
    {
        var parameters = constructor.GetParameters();
        var controlTypeName = ReflectoniaFactory.FixType(type.ToString());
        var methodName = ReflectoniaFactory.FixClassNameType(type.Name);
        var typeConstName = MetadataNameUtility.GetTypeConstName(controlTypeName);

        if (!includeRefParam)
        {
            sb.AppendLine("#if NXUI_HOTRELOAD");
            AppendDocComment(sb, controlTypeName, parameters, includeRefParam: false);
            AppendMethodSignature(sb, $"ElementBuilder<{controlTypeName}>", methodName, parameters, includeRefParam: false, controlTypeName);
            sb.AppendLine();
            sb.AppendLine($"        => ElementBuilder.Create<{controlTypeName}>(TypeMetadata.{typeConstName}, () => {BuildConstructorExpression(controlTypeName, parameters)});");
            sb.AppendLine("#else");

            AppendDocComment(sb, controlTypeName, parameters, includeRefParam: false);
            AppendMethodSignature(sb, controlTypeName, methodName, parameters, includeRefParam: false, controlTypeName);
            sb.AppendLine();
            sb.Append("        => ");
            sb.Append(BuildConstructorExpression(controlTypeName, parameters));
            sb.Append(";");
            sb.AppendLine();
            sb.AppendLine("#endif");
            return;
        }

        AppendDocComment(sb, controlTypeName, parameters, includeRefParam: true);
        AppendMethodSignature(sb, controlTypeName, methodName, parameters, includeRefParam: true, controlTypeName);
        sb.AppendLine();
        sb.Append("        => @ref = ");
        sb.Append(BuildConstructorExpression(controlTypeName, parameters));
        sb.Append(";");
        sb.AppendLine();
    }

    private static void AppendDocComment(StringBuilder sb, string controlTypeName, ParameterInfo[] parameters, bool includeRefParam)
    {
        sb.AppendLine("    /// <summary>");
        sb.AppendLine($"    /// Creates a new instance of the <see cref=\"{controlTypeName}\"/> class.");
        sb.AppendLine("    /// </summary>");

        if (includeRefParam)
        {
            sb.AppendLine($"    /// <param name=\"ref\">The reference of the <see cref=\"{controlTypeName}\"/> instantiated class.</param>");
        }

        for (var j = 0; j < parameters.Length; j++)
        {
            sb.AppendLine($"    /// <param name=\"{parameters[j].Name}\">The {parameters[j].Name} value.</param>");
        }

        sb.AppendLine($"    /// <returns>The new instance of the <see cref=\"{controlTypeName}\"/> class.</returns>");
    }

    private void AppendMethodSignature(
        StringBuilder sb,
        string returnType,
        string methodName,
        ParameterInfo[] parameters,
        bool includeRefParam,
        string controlTypeName)
    {
        sb.Append($"    public static {returnType} {methodName}(");

        if (includeRefParam)
        {
            sb.Append($"out {controlTypeName} @ref");

            if (parameters.Length > 0)
            {
                sb.Append(", ");
            }
        }

        for (var j = 0; j < parameters.Length; j++)
        {
            sb.Append($"{ReflectoniaFactory.FixType(parameters[j].ParameterType.ToString())} {parameters[j].Name}");

            if (parameters[j].HasDefaultValue)
            {
                if (parameters[j].DefaultValue is { })
                {
                    if (parameters[j].ParameterType.IsEnum)
                    {
                        sb.Append($" = {ReflectoniaFactory.FixType(parameters[j].ParameterType.ToString())}.{parameters[j].DefaultValue}");
                    }
                    else
                    {
                        sb.Append($" = {parameters[j].DefaultValue}");
                    }
                }
                else
                {
                    sb.Append(" = default");
                }
            }

            if (j < parameters.Length - 1)
            {
                sb.Append(", ");
            }
        }

        sb.Append(")");
    }

    private static string BuildConstructorExpression(string controlTypeName, ParameterInfo[] parameters)
    {
        var sb = new StringBuilder();
        sb.Append($"new {controlTypeName}(");

        for (var j = 0; j < parameters.Length; j++)
        {
            sb.Append(parameters[j].Name);
            if (j < parameters.Length - 1)
            {
                sb.Append(", ");
            }
        }

        sb.Append(")");
        return sb.ToString();
    }
}
