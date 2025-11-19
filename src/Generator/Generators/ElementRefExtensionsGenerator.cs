using System.Text;
using Reflectonia;
using Reflectonia.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

public class ElementRefExtensionsGenerator
{
    public ElementRefExtensionsGenerator(ReflectoniaFactory reflectoniaFactory, IReflectoniaLog log)
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

            if (c.Properties.Length == 0)
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"ElementRef.{c.Name}.Extensions.g.cs");
            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var header = new StringBuilder(Templates.ElementRefExtensionsHeader);
            header.Replace("%ClassName%", c.Name);
            header.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
            WriteLine(header.ToString());

            var added = new HashSet<string>();

            for (var j = 0; j < c.Properties.Length; j++)
            {
                var p = c.Properties[j];
                if (p.AlreadyExists)
                {
                    continue;
                }

                if (!added.Add(p.Name))
                {
                    Log.Error($"ElementRef property {c.Name}.{p.Name} already generated.");
                    continue;
                }

                var ownerTypeName = ReflectoniaFactory.ToString(p.OwnerType);
                var isOwnerSealed = p.OwnerType.IsSealed;
                var elementRefType = isOwnerSealed
                    ? $"ElementRef<{ownerTypeName}>"
                    : "ElementRef<TControl>";
                var genericSuffix = isOwnerSealed ? string.Empty : "<TControl>";
                var constraint = isOwnerSealed ? string.Empty : $" where TControl : {ownerTypeName}";

                var method = new StringBuilder(Templates.ElementRefExtensionsMethod);
                method.Replace("%OwnerType%", ReflectoniaFactory.ToString(p.OwnerType));
                method.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                method.Replace("%Name%", p.Name);
                method.Replace("%ValueTypeSignature%", TypeFormatter.Format(p.ValueType, p.ValueNullability));
                method.Replace("%ElementRefType%", elementRefType);
                method.Replace("%GenericSuffix%", genericSuffix);
                method.Replace("%Constraint%", constraint);
                WriteLine(method.ToString());
            }

            var footer = new StringBuilder(Templates.ElementRefExtensionsFooter);
            WriteLine(footer.ToString());
        }
    }
}
