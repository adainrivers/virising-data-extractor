using System.IO;
using VRising.JsonToCsharp.CodeWriters;

namespace VRising.JsonToCsharp
{
    public static class JsonToCsharpConverter
    {
        public static string ToCsharp(string className, string nameSpaceSuffix, string json)
        {
            var generator = new JsonClassGenerator
            {
                Example = json,
                InternalVisibility = false,
                CodeWriter = new CSharpCodeWriter(),
                ExplicitDeserialization = false,
                Namespace = $"{nameSpaceSuffix}",
                NoHelperClass = true,
                SecondaryNamespace = null,
                UseProperties = true,
                MainClass = className,
                UsePascalCase = true,
                UseNestedClasses = false,
                ApplyObfuscationAttributes = false,
                SingleFile = true,
                ExamplesInDocumentation = false,
                TargetFolder = null,
            };

            using var sw = new StringWriter();
            generator.OutputStream = sw;
            generator.GenerateClasses();
            sw.Flush();
            return sw.ToString();
        }
    }
}
