using System.Text.Json;

namespace DocumentationTools.UI
{
    internal class SerializeAndDeserialize
    {
        public static void SaveAsJsonFormat<T>(T objGraph, string fileName)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                IncludeFields= true,
            };

            File.WriteAllText(fileName, System.Text.Json.JsonSerializer.Serialize(objGraph, options));
        }

        static T ReadAsJsonFormat<T>(string fileName)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                IncludeFields = true,
                PropertyNameCaseInsensitive= true,
            };

            return System.Text.Json.JsonSerializer.Deserialize<T>(File.ReadAllText(fileName), options);

        }
        
    }
}
