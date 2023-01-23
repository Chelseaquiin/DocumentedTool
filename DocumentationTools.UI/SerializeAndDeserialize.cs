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
        /*internal class Operation
        {
            public static void WriteToTxt()
            {
                TraineeDocumentation documentation = new();
                var docs = Services.GetDocs();

                try
                {
                    File.WriteAllText("traineeTxt.txt", docs);

                    Console.WriteLine("\n\t Txt file created successfully!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\t An error occurred while writing to the Txt file: " + e.Message);
                }
            }

            public static void ReadFromTxt()
            {
                try
                {
                    var txtText = File.ReadAllText("traineeTxt.txt");

                    Console.WriteLine(txtText);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\t An error occurred while writing to the Txt file: " + e.Message);
                }
            }

            public static void WriteToJson()
            {
                TraineeDocumentation documentation = new();
                var docs = documentation.GetDocs();

                try
                {
                    var options = new JsonSerializerOptions
                    {
                        IncludeFields = true,
                        WriteIndented = true
                    };

                    string jsonText = JsonSerializer.Serialize(docs, options);
                    File.WriteAllText("traineeJson.json", jsonText);

                    Console.WriteLine("\n\t JSON file created successfully!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\t An error occurred while writing to the JSON file: " + e.Message);
                }
            }


            public static void ReadFromJson()
            {
                try
                {
                    string json = File.ReadAllText("traineeJson.json");

                    var docs = JsonSerializer.Deserialize<string>(json);
                    Console.WriteLine(docs);

                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\t An error occurred while reading from the JSON file: " + e.Message);
                }
            }

            public static void WriteToPdf()
            {
                TraineeDocumentation documentation = new();
                var docs = documentation.GetDocs();

                try
                {
                    var Renderer = new ChromePdfRenderer();
                    var pdf = Renderer.RenderHtmlAsPdf(docs);
                    pdf.SaveAs("traineePDF.pdf");

                    Console.WriteLine("\n\t PDF file created successfully!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\t An error occurred while writing to the PDF file: " + e.Message);
                }
            }
        }*/

    }
}
