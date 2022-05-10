using System.Text;

Action<string> WriteLine = Console.WriteLine;

var classes = new Class[]
{
    new ("TextBox", "Avalonia.Controls.TextBox", new Property[] 
    {
        new ("AcceptsReturn", "TextBox", "bool", "StyledProperty<bool>"),
        new ("AcceptsTab", "TextBox", "bool", "StyledProperty<bool>"),
        new ("CaretIndex", "TextBox", "int", "DirectProperty<TextBox, int>"),
        new ("IsReadOnly", "TextBox", "bool", "StyledProperty<bool>"),
        new ("PasswordChar", "TextBox", "char", "StyledProperty<char>"),
        new ("SelectionBrush", "TextBox", "IBrush", "StyledProperty<IBrush>"),
        new ("SelectionForegroundBrush", "TextBox", "IBrush", "StyledProperty<IBrush>"),
        new ("CaretBrush", "TextBox", "IBrush", "StyledProperty<IBrush>"),
        new ("SelectionStart", "TextBox", "int", "DirectProperty<TextBox, int>"),
        new ("SelectionEnd", "TextBox", "int", "DirectProperty<TextBox, int>"),
        new ("MaxLength", "TextBox", "int", "StyledProperty<int>"),
        new ("Text", "TextBox", "string", "DirectProperty<TextBox, string>"),
        new ("TextAlignment", "TextBox", "TextAlignment", "StyledProperty<TextAlignment>"),
        new ("HorizontalContentAlignment", "TextBox", "HorizontalAlignment", "StyledProperty<HorizontalAlignment>"),
        new ("VerticalContentAlignment", "TextBox", "VerticalAlignment", "StyledProperty<VerticalAlignment>"),
        new ("TextWrapping", "TextBox", "TextWrapping", "StyledProperty<TextWrapping>"),
        new ("Watermark", "TextBox", "string", "StyledProperty<string>"),
        new ("UseFloatingWatermark", "TextBox", "bool", "StyledProperty<bool>"),
        new ("NewLine", "TextBox", "string", "DirectProperty<TextBox, string>"),
        new ("InnerLeftContent", "TextBox", "object", "StyledProperty<object>"),
        new ("InnerRightContent", "TextBox", "object", "StyledProperty<object>"),
        new ("RevealPassword", "TextBox", "bool", "StyledProperty<bool>"),
        new ("CanCut", "TextBox", "bool", "DirectProperty<TextBox, bool>", true),
        new ("CanCopy", "TextBox", "bool", "DirectProperty<TextBox, bool>", true),
        new ("CanPaste", "TextBox", "bool", "DirectProperty<TextBox, bool>", true),
        new ("IsUndoEnabled", "TextBox", "bool", "StyledProperty<bool>"),
        new ("UndoLimit", "TextBox", "int", "DirectProperty<TextBox, int>"),
    }),
};

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

var classExtensionsHeaderTemplate = @"namespace MinimalAvalonia.Controls;

public static class %ClassName%Extensions
{";

var classExtensionsFooterTemplate = @"}";

foreach (var c in classes)
{
    var classHeaderBuilder = new StringBuilder(classExtensionsHeaderTemplate);
    classHeaderBuilder.Replace("%ClassName%", c.Name);
    WriteLine(classHeaderBuilder.ToString());

    // Properties

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

record Property(string Name, string OwnerType, string ValueType, string PropertyType, bool IsReadOnly = false);
record Class(string Name, string Type, Property[] Properties);

