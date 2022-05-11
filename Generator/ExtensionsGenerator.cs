using System.Text;
using Avalonia;

namespace Generator;

internal record Property(string Name, string OwnerType, string ValueType, string PropertyType, bool IsReadOnly = false);

internal record Class(string Name, string Type, Property[] Properties, bool IsSealed = false);

internal static class ExtensionsGenerator
{ 
    public static void Generate(Action<string> writeLine) 
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        var types = (
            from domainAssembly in assemblies
            where domainAssembly?.FullName is not null && domainAssembly.FullName.StartsWith("Avalonia") 
            from assemblyType in domainAssembly.GetTypes()
            where assemblyType is not null 
                  && assemblyType.IsSubclassOf(typeof(AvaloniaObject))
                  &&! assemblyType.IsAbstract
            select assemblyType).ToArray();

        var classes = new List<Class>();

        foreach (var type in types)
        {
            var avaloniaProperties = AvaloniaPropertyRegistry.Instance.GetRegistered(type);
            if (avaloniaProperties.Count <= 0)
                continue;

            var properties = new List<Property>();

            string FixType(string t)
            {
                return t
                    .Replace("`1[", "<")
                    .Replace("`2[", "<")
                    .Replace("`3[", "<")
                    .Replace("]", ">")
                    .Replace("+", ".");
            }

            foreach (var property in avaloniaProperties)
            {
                if (!(type.GetField($"{property.Name}Property")?.IsPublic ?? false))
                    continue;

                if (property.OwnerType != type || !property.PropertyType.IsPublic)
                    continue;

                var p = new Property(
                    property.Name, 
                    FixType(property.OwnerType.ToString()), 
                    FixType(property.PropertyType.ToString()), 
                    FixType(property.GetType().ToString()), 
                    property.IsReadOnly);

                properties.Add(p);
            }

            var c = new Class(type.Name, FixType(type.ToString()), properties.ToArray(), type.IsSealed);
            classes.Add(c);
        }

        var propertyMethodsTemplate = @"    //
    // %Name%Property
    //

    public static T %Name%<T>(this T obj, %ValueType% value) where T : %OwnerType%
    {
        obj[%ClassType%.%Name%Property] = value;
        return obj;
    }

    public static T %Name%<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : %OwnerType%
    {
        obj[%ClassType%.%Name%Property.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding %Name%(this %OwnerType% obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[%ClassType%.%Name%Property.Bind().WithMode(mode)];
    }";

        var propertyMethodsTemplateSealed = @"    //
    // %Name%Property
    //

    public static %OwnerType% %Name%(this %OwnerType% obj, %ValueType% value)
    {
        obj[%ClassType%.%Name%Property] = value;
        return obj;
    }

    public static %OwnerType% %Name%(this %OwnerType% obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[%ClassType%.%Name%Property.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding %Name%(this %OwnerType% obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[%ClassType%.%Name%Property.Bind().WithMode(mode)];
    }";

        var propertyMethodsTemplateReadOnly = @"    //
    // %Name%Property
    //

    public static Avalonia.Data.IBinding %Name%(this %OwnerType% obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[%ClassType%.%Name%Property.Bind().WithMode(mode)];
    }";

        var classExtensionsHeaderTemplate = @"
    public static partial class %ClassName%Extensions
    {";

        var classExtensionsFooterTemplate = @"}";

        writeLine("namespace MinimalAvalonia.Extensions;");

        foreach (var c in classes)
        {
            var classHeaderBuilder = new StringBuilder(classExtensionsHeaderTemplate);
            classHeaderBuilder.Replace("%ClassName%", c.Name);
            writeLine(classHeaderBuilder.ToString());

            // Properties

            if (c.Properties.Length > 0)
            {
                writeLine("    //");
                writeLine("    // Properties");
                writeLine("    //");
                writeLine("");

                for (var i = 0; i < c.Properties.Length; i++)
                {
                    var p = c.Properties[i];
                    writeLine($"    public static {p.PropertyType} {c.Name}{p.Name} => {c.Type}.{p.Name}Property;");
                }

                writeLine("");
            }

            // Methods
            
            for (var i = 0; i < c.Properties.Length; i++)
            {
                var p = c.Properties[i];
                var template = p.IsReadOnly 
                    ? propertyMethodsTemplateReadOnly 
                    : c.IsSealed 
                        ? propertyMethodsTemplateSealed 
                        : propertyMethodsTemplate;

                var propertyBuilder = new StringBuilder(template);

                propertyBuilder.Replace("%ClassType%", c.Type);
                propertyBuilder.Replace("%Name%", p.Name);
                propertyBuilder.Replace("%OwnerType%", p.OwnerType);
                propertyBuilder.Replace("%ValueType%", p.ValueType);

                writeLine(propertyBuilder.ToString());

                if (i < c.Properties.Length - 1)
                {
                    writeLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(classExtensionsFooterTemplate);
            writeLine(classFooterBuilder.ToString());
        }
    }
}
