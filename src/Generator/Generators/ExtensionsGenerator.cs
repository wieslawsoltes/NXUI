using System.Text;
using Reflectonia;
using Reflectonia.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

public partial class ExtensionsGenerator
{
    public ExtensionsGenerator(ReflectoniaFactory reflectoniaFactory, IReflectoniaLog log)
    {
        ReflectoniaFactory = reflectoniaFactory;
        Log = log;
    }

    private ReflectoniaFactory ReflectoniaFactory { get; }

    private IReflectoniaLog Log { get; }

    public void Generate(string outputPath, List<Class> classes)
    {
        foreach (var c in classes)
        {
            if (c.Properties.Length <= 0 && c.Events.Length <= 0)
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"{c.Name}.Extensions.g.cs");
            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.FileHeaderTemplate);

            fileHeaderBuilder.Replace("%Namespace%", "");

            WriteLine(fileHeaderBuilder.ToString());

            var classHeaderBuilder = new StringBuilder(Templates.ClassExtensionsHeaderTemplate);
            classHeaderBuilder.Replace("%ClassName%", c.Name);
            classHeaderBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
            WriteLine(classHeaderBuilder.ToString());

            var addedProperties = new HashSet<string>();
            var addedRoutedEvents = new HashSet<string>();
            var addedClrEvents = new HashSet<string>();

            (string BuilderType, string BuilderGeneric, string BuilderConstraint, string HandlerType, string HandlerInvocation) GetBuilderMetadata(Type ownerType)
            {
                var ownerTypeName = ReflectoniaFactory.ToString(ownerType);

                if (ownerType.IsSealed)
                {
                    return ($"ElementBuilder<{ownerTypeName}>", string.Empty, string.Empty, ownerTypeName, "typed");
                }

                return ($"ElementBuilder<T>", "<T>", $" where T : {ownerTypeName}", "T", "(T)typed");
            }

            for (var i = 0; i < c.Properties.Length; i++)
            {
                var p = c.Properties[i];
                if (p.AlreadyExists)
                {
                    continue;
                }

                if (addedProperties.Contains(p.Name))
                {
                    Log.Error($"Property {c.Name}.{p.Name} extensions have been already added.");
                    continue;
                }
                addedProperties.Add(p.Name);

                var propertyConstName = MetadataNameUtility.GetPropertyConstName(c.Name, p.Name);
                var builderMeta = (BuilderType: string.Empty, BuilderGeneric: string.Empty, BuilderConstraint: string.Empty, HandlerType: string.Empty, HandlerInvocation: string.Empty);
                var template = p.IsReadOnly
                    ? Templates.PropertyMethodsTemplateReadOnly
                    : c.IsSealed
                        ? Templates.PropertyMethodsTemplateSealed
                        : Templates.PropertyMethodsTemplate;

                var propertyBuilder = new StringBuilder(template);

                var valueTypeName = ReflectoniaFactory.ToString(p.ValueType);
                var valueTypeSignature = FormatTypeWithNullability(p.ValueType, p.ValueNullability);

                if (!p.IsReadOnly)
                {
                    var hotReloadBuilder = new StringBuilder(Templates.PropertyMethodsHotReloadTemplate);
                    builderMeta = GetBuilderMetadata(p.OwnerType);
                    hotReloadBuilder.Replace("%BuilderType%", builderMeta.BuilderType);
                    hotReloadBuilder.Replace("%BuilderGeneric%", builderMeta.BuilderGeneric);
                    hotReloadBuilder.Replace("%BuilderConstraint%", builderMeta.BuilderConstraint);
                    hotReloadBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                    hotReloadBuilder.Replace("%MethodName%", p.Name);
                    hotReloadBuilder.Replace("%Name%", p.Name);
                    hotReloadBuilder.Replace("%OwnerType%", ReflectoniaFactory.ToString(p.OwnerType));
                    hotReloadBuilder.Replace("%ValueType%", valueTypeName);
                    hotReloadBuilder.Replace("%ValueTypeSignature%", valueTypeSignature);
                    hotReloadBuilder.Replace("%PropertyId%", propertyConstName);
                    WriteLine(hotReloadBuilder.ToString());
                }

                propertyBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                propertyBuilder.Replace("%MethodName%", p.Name);
                propertyBuilder.Replace("%Name%", p.Name);
                propertyBuilder.Replace("%OwnerType%", ReflectoniaFactory.ToString(p.OwnerType));
                propertyBuilder.Replace("%ValueType%", valueTypeName);
                propertyBuilder.Replace("%ValueTypeSignature%", valueTypeSignature);

                WriteLine(propertyBuilder.ToString());

                if (!p.IsReadOnly)
                {
                    EmitConvenienceOverloads(c, p, builderMeta, WriteLine);
                }

                if (p.IsEnum && !p.IsReadOnly && p.EnumNames is { })
                {
                    foreach (var enumName in p.EnumNames)
                    {
                        var templateEnum = c.IsSealed
                            ? Templates.PropertyMethodEnumSealedTemplate
                            : Templates.PropertyMethodEnumTemplate;

                        var propertyEnumBuilder = new StringBuilder(templateEnum);

                        var enumHotReloadBuilder = new StringBuilder(Templates.PropertyMethodEnumHotReloadTemplate);
                        var enumBuilderMeta = GetBuilderMetadata(p.OwnerType);
                        enumHotReloadBuilder.Replace("%BuilderType%", enumBuilderMeta.BuilderType);
                        enumHotReloadBuilder.Replace("%BuilderGeneric%", enumBuilderMeta.BuilderGeneric);
                        enumHotReloadBuilder.Replace("%BuilderConstraint%", enumBuilderMeta.BuilderConstraint);
                        enumHotReloadBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                        enumHotReloadBuilder.Replace("%Name%", p.Name);
                        enumHotReloadBuilder.Replace("%OwnerType%", ReflectoniaFactory.ToString(p.OwnerType));
                        enumHotReloadBuilder.Replace("%ValueType%", ReflectoniaFactory.ToString(p.ValueType));
                        enumHotReloadBuilder.Replace("%EnumValue%", enumName);
                        enumHotReloadBuilder.Replace("%PropertyId%", propertyConstName);
                        WriteLine(enumHotReloadBuilder.ToString());

                        propertyEnumBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                        propertyEnumBuilder.Replace("%Name%", p.Name);
                        propertyEnumBuilder.Replace("%OwnerType%", ReflectoniaFactory.ToString(p.OwnerType));
                        propertyEnumBuilder.Replace("%ValueType%", ReflectoniaFactory.ToString(p.ValueType));
                        propertyEnumBuilder.Replace("%EnumValue%", enumName);

                        WriteLine(propertyEnumBuilder.ToString());
                    }
                }

                if (i < c.Properties.Length - 1 || c.Events.Length > 0)
                {
                    WriteLine("");
                }
            }

            var routedEvents = c.Events.Where(x => x.RoutingStrategies is not null).ToArray();
            var clrEvents = c.Events.Where(x => x.RoutingStrategies is null).ToArray();

            for (var i = 0; i < routedEvents.Length; i++)
            {
                var e = routedEvents[i];

                if (addedRoutedEvents.Contains(e.Name))
                {
                    Log.Error($"Routed event {c.Name}.{e.Name} extensions have been already added.");
                    continue;
                }
                addedRoutedEvents.Add(e.Name);

                if (e.RoutingStrategies is null)
                    continue;

                var usesGenericHandler = e.EventType?.IsGenericType == true;

                var template = c.IsSealed
                    ? (usesGenericHandler
                        ? Templates.RoutedEventMethodsTemplateSealed
                        : Templates.RoutedEventMethodsTemplateSealedNonGeneric)
                    : (usesGenericHandler
                        ? Templates.RoutedEventMethodsTemplate
                        : Templates.RoutedEventMethodsTemplateNonGeneric);

                var routes = e.RoutingStrategies!.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var routingStrategiesBuilder = new StringBuilder();
                for (var j = 0; j < routes.Length; j++)
                {
                    if (j > 0)
                    {
                        routingStrategiesBuilder.Append(" | ");
                    }

                    routingStrategiesBuilder.Append("Avalonia.Interactivity.RoutingStrategies.");
                    routingStrategiesBuilder.Append(routes[j]);
                }

                var eventBuilder = new StringBuilder(template);
                eventBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                eventBuilder.Replace("%Name%", e.Name);
                eventBuilder.Replace("%OwnerType%", ReflectoniaFactory.ToString(e.OwnerType));
                eventBuilder.Replace("%ArgsType%", ReflectoniaFactory.ToString(e.ArgsType));
                eventBuilder.Replace("%RoutingStrategies%", routingStrategiesBuilder.ToString());

                WriteLine(eventBuilder.ToString());

                var hotReloadTemplate = usesGenericHandler
                    ? Templates.RoutedEventMethodsHotReloadTemplate
                    : Templates.RoutedEventMethodsHotReloadTemplateNonGeneric;

                var routedHotReloadBuilder = new StringBuilder(hotReloadTemplate);
                var routedBuilderMeta = GetBuilderMetadata(e.OwnerType);
                routedHotReloadBuilder.Replace("%BuilderType%", routedBuilderMeta.BuilderType);
                routedHotReloadBuilder.Replace("%BuilderGeneric%", routedBuilderMeta.BuilderGeneric);
                routedHotReloadBuilder.Replace("%BuilderConstraint%", routedBuilderMeta.BuilderConstraint);
                routedHotReloadBuilder.Replace("%HandlerType%", routedBuilderMeta.HandlerType);
                routedHotReloadBuilder.Replace("%HandlerInvocation%", routedBuilderMeta.HandlerInvocation);
                routedHotReloadBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                routedHotReloadBuilder.Replace("%Name%", e.Name);
                routedHotReloadBuilder.Replace("%OwnerType%", ReflectoniaFactory.ToString(e.OwnerType));
                routedHotReloadBuilder.Replace("%ArgsType%", ReflectoniaFactory.ToString(e.ArgsType));
                routedHotReloadBuilder.Replace("%RoutingStrategies%", routingStrategiesBuilder.ToString());
                WriteLine(routedHotReloadBuilder.ToString());

                if (i < routedEvents.Length - 1 || clrEvents.Length > 0)
                {
                    WriteLine("");
                }
            }

        for (var i = 0; i < clrEvents.Length; i++)
        {
            var e = clrEvents[i];

            if (addedClrEvents.Contains(e.Name))
            {
                Log.Error($"Clr event {c.Name}.{e.Name} extensions have been already added.");
                continue;
            }
            addedClrEvents.Add(e.Name);

            if (e.RoutingStrategies is { })
                continue;

            var template = c.IsSealed
                ? Templates.EventMethodsTemplateSealed
                : Templates.EventMethodsTemplate;

            var eventBuilder = new StringBuilder(template);
            eventBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
            eventBuilder.Replace("%Name%", e.Name);
            eventBuilder.Replace("%OwnerType%", ReflectoniaFactory.ToString(e.OwnerType));

            var argsType = e.ArgsType ?? typeof(EventArgs);
            eventBuilder.Replace("%ArgsType%", ReflectoniaFactory.ToString(argsType));

            var eventHandler = e.EventType is { }
                ? ReflectoniaFactory.ToString(e.EventType)
                : (e.ArgsType is { }
                    ? $"EventHandler<{ReflectoniaFactory.ToString(argsType)}>"
                    : "EventHandler");
            eventBuilder.Replace("%EventHandler%", eventHandler);

            WriteLine(eventBuilder.ToString());

            var hotReloadBuilder = new StringBuilder(Templates.EventMethodsHotReloadTemplate);
            var eventBuilderMeta = GetBuilderMetadata(e.OwnerType);
            hotReloadBuilder.Replace("%BuilderType%", eventBuilderMeta.BuilderType);
            hotReloadBuilder.Replace("%BuilderGeneric%", eventBuilderMeta.BuilderGeneric);
            hotReloadBuilder.Replace("%BuilderConstraint%", eventBuilderMeta.BuilderConstraint);
            hotReloadBuilder.Replace("%HandlerType%", eventBuilderMeta.HandlerType);
            hotReloadBuilder.Replace("%HandlerInvocation%", eventBuilderMeta.HandlerInvocation);
            hotReloadBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
            hotReloadBuilder.Replace("%Name%", e.Name);
            hotReloadBuilder.Replace("%OwnerType%", ReflectoniaFactory.ToString(e.OwnerType));
            hotReloadBuilder.Replace("%ArgsType%", ReflectoniaFactory.ToString(argsType));
            hotReloadBuilder.Replace("%EventHandler%", eventHandler);
            WriteLine(hotReloadBuilder.ToString());

            if (i < clrEvents.Length - 1)
            {
                WriteLine("");
            }
        }

        var classFooterBuilder = new StringBuilder(Templates.ClassExtensionsFooterTemplate);
        WriteLine(classFooterBuilder.ToString());
    }

}
}
