using System.Text;
using Reflectonia;
using Reflectonia.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

public class SettersGenerator
{
    public SettersGenerator(ReflectoniaFactory reflectoniaFactory, IReflectoniaLog log)
    {
        ReflectoniaFactory = reflectoniaFactory;
        Log = log;
    }
    
    private ReflectoniaFactory ReflectoniaFactory { get; }

    private IReflectoniaLog Log { get; }

    public void Generate(string outputPath, List<Class> classes, bool genFSharp = false)
    {
        foreach (var c in classes)
        {
            if (c.Properties.Length <= 0 )
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"{c.Name}.Setters.g.cs");
            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.FileHeaderTemplate);

            if (genFSharp)
            {
                fileHeaderBuilder.Replace("%Namespace%", ".FSharp");
            }
            else
            {
                fileHeaderBuilder.Replace("%Namespace%", "");
            }

            WriteLine(fileHeaderBuilder.ToString());

            var classHeaderBuilder = new StringBuilder(Templates.PropertySettersHeaderTemplate);
            classHeaderBuilder.Replace("%ClassName%", c.Name);
            classHeaderBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
            WriteLine(classHeaderBuilder.ToString());

            var addedProperties = new HashSet<string>();

            for (var i = 0; i < c.Properties.Length; i++)
            {
                var p = c.Properties[i];
                if (p.AlreadyExists)
                {
                    continue;
                }

                if (p.IsReadOnly)
                {
                    continue;
                }

                if (addedProperties.Contains(p.Name))
                {
                    Log.Error($"Property {c.Name}.{p.Name} setters have been already added.");
                    continue;
                }
                addedProperties.Add(p.Name);

                // value
                
                var valueBuilder = new StringBuilder(Templates.PropertySettersValueTemplate);

                valueBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                valueBuilder.Replace("%ClassName%", c.Name);
                valueBuilder.Replace("%Name%", p.Name);
                valueBuilder.Replace("%ValueType%", ReflectoniaFactory.ToString(p.ValueType));

                WriteLine(valueBuilder.ToString());

                // observable

                var observableBuilder = new StringBuilder(Templates.PropertySettersObservableTemplate);

                observableBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                observableBuilder.Replace("%ClassName%", c.Name);
                observableBuilder.Replace("%Name%", p.Name);
                observableBuilder.Replace("%ValueType%", ReflectoniaFactory.ToString(p.ValueType));

                WriteLine(observableBuilder.ToString());

                // binding

                if (p.ValueType != typeof(Avalonia.Data.IBinding))
                {
                    var bindingBuilder = new StringBuilder(Templates.PropertySettersBindingTemplate);

                    bindingBuilder.Replace("%ClassType%", ReflectoniaFactory.ToString(c.Type));
                    bindingBuilder.Replace("%ClassName%", c.Name);
                    bindingBuilder.Replace("%Name%", p.Name);
                    bindingBuilder.Replace("%ValueType%", ReflectoniaFactory.ToString(p.ValueType));

                    WriteLine(bindingBuilder.ToString());
                }

                if (i < c.Properties.Length - 1 || c.Events.Length > 0)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.PropertySettersFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }
}
