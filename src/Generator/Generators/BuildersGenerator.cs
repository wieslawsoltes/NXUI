using System.Text;
using Generator.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

internal static class BuildersGenerator
{
    public static void Generate(string outputPath, List<Class> classes)
    {
        var outputFile = Path.Combine(outputPath, $"Builders.g.cs");

        using var file = File.CreateText(outputFile);
        void WriteLine(string x) => file.WriteLine(x);

        var fileHeaderBuilder = new StringBuilder(Templates.BuildersHeaderTemplate);
        WriteLine(fileHeaderBuilder.ToString());

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

            var buildersBuilder = new StringBuilder(Templates.BuildersTemplate);
            buildersBuilder.Replace("%ClassName%", c.Name);
            buildersBuilder.Replace("%ClassType%", c.Type);
            WriteLine(buildersBuilder.ToString());

            if (i < classes.Count - 1)
            {
                WriteLine("");
            }
        }

        var classFooterBuilder = new StringBuilder(Templates.BuildersFooterTemplate);
        WriteLine(classFooterBuilder.ToString());
    }
}
