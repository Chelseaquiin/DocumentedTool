using DocumentationTools.BLL.Implementation;

namespace DocumentationTools.UI
{
    internal class Application
    {
        public void Start()
        {
            DocumentationServices doc = new DocumentationServices();

            string typeName = "";
            do
            {
                Console.WriteLine("\nEnter a type name to evaluate");
                Console.Write("or enter Q to quit: ");
          
                typeName = Console.ReadLine();

                if (typeName.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                try
                {
                    Type t = Type.GetType(typeName);
                    Console.WriteLine("");
                    doc.GetDoc(t);
                }
                catch
                {
                    Console.WriteLine("Sorry, can't find type");
                }
            } while (true);

        }
    }
}
