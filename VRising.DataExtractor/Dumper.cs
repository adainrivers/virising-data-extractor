using System.IO;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace VRising.DataExtractor
{
    public static class Dumper
    {

        public static void WriteSerialized(string path, object data)
        {
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true, IncludeFields = true});
            File.WriteAllText(path, json);
        }
    }
}
