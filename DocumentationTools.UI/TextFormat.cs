namespace DocumentationTools.UI
{
    internal class TextFormat
    {
        /*DocumentationServices _services = new DocumentationServices();*/
        public static void ConvertToText(string textToWrite)
        {

            // string directory = Path.Combine("wwwroot", "GetDoc.txt");
            string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Documentation");

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);

            }
            string filePath = Path.Combine(directory, "GetDoc.txt");
            File.WriteAllText(filePath, textToWrite);



        }
        public static void ReadAllString()
        {

            // string directory = Path.Combine("wwwroot", "GetDoc.txt");
            string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Documentation");

            if (!Directory.Exists(directory))
            {
                Console.WriteLine("File does not exist");
                return;
            }
            string filePath = Path.Combine(directory, "GetDoc.txt");
            string text = File.ReadAllText(filePath);
            Console.WriteLine(text);

        }

        public static void ConvertToJson(string textToWrite)
        {

            // string directory = Path.Combine("wwwroot", "GetDoc.txt");
            string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Documentation");

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);

            }
            string filePath = Path.Combine(directory, "GetDoc.json");
            File.WriteAllText(filePath, textToWrite);

        }


    }
}
