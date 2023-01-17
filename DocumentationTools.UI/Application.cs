using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentationTools.BLL.Implementation;

namespace DocumentationTools.UI
{
    internal class Application
    {
        public void Start()
        {
            DocumentationServices doc = new DocumentationServices();

            /*string typeName = "";
            do
            {
                Console.WriteLine("\nEnter a type name to evaluate");
                Console.Write("or enter Q to quit: ");
                // Get name of type.
                typeName = Console.ReadLine();

                // Does user want to quit?
                if (typeName.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                // Try to display type.
                try
                {
                    Type t = Type.GetType(typeName);
                    Console.WriteLine("");*/
                    doc.ReflectAttributesUsingLateBinding();
                /*}
                catch
                {
                    Console.WriteLine("Sorry, can't find type");
                }
            } while (true);
*/
        }
    }
}
