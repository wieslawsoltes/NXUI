﻿using System.Diagnostics;
using System.Text;
using Generator.Model;

// ReSharper disable once CheckNamespace
namespace Generator;

public static class PropertiesGenerator
{
    public static void Generate(string outputPath, List<Class> classes, bool genFSharp = false)
    {
        foreach (var c in classes)
        {
            if (c.Properties.Length <= 0)
            {
                continue;
            }

            var outputFile = Path.Combine(outputPath, $"{c.Name}.Properties.g.cs");

            using var file = File.CreateText(outputFile);
            void WriteLine(string x) => file.WriteLine(x);

            var fileHeaderBuilder = new StringBuilder(Templates.PropertiesHeaderTemplate);

            if (genFSharp)
            {
                fileHeaderBuilder.Replace("%Namespace%", ".FSharp");
            }
            else
            {
                fileHeaderBuilder.Replace("%Namespace%", "");
            }

            WriteLine(fileHeaderBuilder.ToString());

            var addedProperties = new HashSet<string>();

            for (var i = 0; i < c.Properties.Length; i++)
            {
                var p = c.Properties[i];

                if (addedProperties.Contains(p.Name))
                {
                    Log.Error($"Property {c.Name}.{p.Name} was already added.");
                    continue;
                }
                addedProperties.Add(p.Name);

                var propertyBuilder = new StringBuilder(Templates.PropertyTemplate);
                propertyBuilder.Replace("%ClassName%", c.Name);
                propertyBuilder.Replace("%ClassType%", Factory.ToString(c.Type));
                propertyBuilder.Replace("%PropertyName%", p.Name);
                propertyBuilder.Replace("%PropertyType%", Factory.ToString(p.PropertyType));
                WriteLine(propertyBuilder.ToString());

                if (i < c.Properties.Length - 1)
                {
                    WriteLine("");
                }
            }

            var classFooterBuilder = new StringBuilder(Templates.PropertiesFooterTemplate);
            WriteLine(classFooterBuilder.ToString());
        }
    }
}
