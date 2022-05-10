using System.Text;
using Avalonia;

namespace Generator;

internal record Property(string Name, string OwnerType, string ValueType, string PropertyType, bool IsReadOnly = false);
internal record Class(string Name, string Type, Property[] Properties);

internal class ExtensionsGenerator
{ 
public static void Generate() 
{
    var assemblies = AppDomain.CurrentDomain.GetAssemblies();
    var types = (
        from domainAssembly in assemblies
        where domainAssembly?.FullName is not null && domainAssembly.FullName.StartsWith("Avalonia") 
        from assemblyType in domainAssembly.GetTypes()
        where assemblyType is not null && assemblyType.IsSubclassOf(typeof(AvaloniaObject)) &&! assemblyType.IsAbstract
        select assemblyType).ToArray();

    var classes = new List<Class>();
    
    foreach (var type in types)
    {
        var properties = AvaloniaPropertyRegistry.Instance.GetRegistered(type);
        if (properties.Count <= 0)
            continue;

        //Console.WriteLine($"{type.Name}, {type}");
        var Properties = new List<Property>();

        string FixType(string t)
        {
            return t
                .Replace("`1[", "<")
                .Replace("`2[", "<")
                .Replace("`3[", "<")
                .Replace("]", ">");
        }

        foreach (var property in properties)
        {
            if (property.OwnerType == type)
            {
                //Console.WriteLine($"    {property.Name}, {property.OwnerType.Name}, {property.PropertyType.Name}, {property.GetType()}, {property.IsReadOnly}");
                var p = new Property(property.Name, property.OwnerType.Name, property.PropertyType.Name, FixType(property.GetType().ToString()), property.IsReadOnly);
                Properties.Add(p);
            }  
        }

        var c = new Class(type.Name, type.ToString(), Properties.ToArray());
        classes.Add(c);
    }

string propertyMethodsTemplate = @"    //
    // %Name%Property
    //

    public static T %Name%<T>(this T obj, %ValueType% value) where T : %OwnerType%
    {
        obj[%ClassType%.%Name%Property] = value;
        return obj;
    }

    public static T %Name%<T>(this T obj, IBinding binding, BindingMode mode = BindingMode.TwoWay) where T : %OwnerType%
    {
        obj[%ClassType%.%Name%Property.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static IBinding %Name%(this %OwnerType% obj, BindingMode mode = BindingMode.TwoWay)
    {
        return obj[%ClassType%.%Name%Property.Bind().WithMode(mode)];
    }";

string propertyMethodsTemplateReadOnly = @"    //
    // %Name%Property
    //

    public static IBinding %Name%(this %OwnerType% obj, BindingMode mode = BindingMode.OneWay)
    {
        return obj[%ClassType%.%Name%Property.Bind().WithMode(mode)];
    }";

var classExtensionsHeaderTemplate = @"
public static class %ClassName%Extensions
{";

var classExtensionsFooterTemplate = @"}";

Action<string> WriteLine = Console.WriteLine;

WriteLine("namespace MinimalAvalonia.Controls;");

foreach (var c in classes)
{
    var classHeaderBuilder = new StringBuilder(classExtensionsHeaderTemplate);
    classHeaderBuilder.Replace("%ClassName%", c.Name);
    WriteLine(classHeaderBuilder.ToString());

    // Properties

    if (c.Properties.Length > 0)
    {
        WriteLine("    //");
        WriteLine("    // Properties");
        WriteLine("    //");
        WriteLine("");

        for (var i = 0; i < c.Properties.Length; i++)
        {
            var p = c.Properties[i];
            WriteLine($"    public static {p.PropertyType} {c.Name}{p.Name} => {c.Type}.{p.Name}Property;");
        }

        WriteLine("");
    }

    // Methods
    
    for (var i = 0; i < c.Properties.Length; i++)
    {
        var p = c.Properties[i];
        var propertyBuilder = new StringBuilder(p.IsReadOnly ? propertyMethodsTemplateReadOnly : propertyMethodsTemplate);
        propertyBuilder.Replace("%ClassType%", c.Type);
        propertyBuilder.Replace("%Name%", p.Name);
        propertyBuilder.Replace("%OwnerType%", p.OwnerType);
        propertyBuilder.Replace("%ValueType%", p.ValueType);
        WriteLine(propertyBuilder.ToString());
        if (i < c.Properties.Length - 1)
            WriteLine("");
    }

    var classFooterBuilder = new StringBuilder(classExtensionsFooterTemplate);
    WriteLine(classFooterBuilder.ToString());
}
}
}
