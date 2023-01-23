using DocumentationTools.Data.Domain;
using DocumentationTools.Data.Enums;
using System.Reflection;

namespace DocumentationTools.UI
{
    internal class Services
    {
        static string output;
        public static void ViewClasses(Type t)
        {

            Console.WriteLine($"\nAssembly: {Assembly.GetAssembly(t).FullName}\nClass: {t.Name}");

            var attributes = t.GetCustomAttributes(true).ToArray();

            foreach (var attribute in attributes)
            {
                switch (attribute)
                {
                    case DocumentAttribute _doc:
                        output = $"\nDescription:{_doc.Description}";
                        break;
                }
            }
        }
        public static void ViewProperties(Type t)
        {
            PropertyInfo[] properties = t.GetProperties();
            for (int i = (int)Numbers.Number; i < properties.Length; i++)
            {
                object[] propAttr = properties[i].GetCustomAttributes(true).ToArray();

                foreach (Attribute attr in propAttr)
                {
                    switch (attr)
                    {
                        case DocumentAttribute docAttribute:
                            output += $"\nProperties: {properties[i].Name}\n\tDescription: {docAttribute.Description}";
                            break;
                    }
                }
            }
        }

        public static void ViewConstructors(Type t)
        {

            ConstructorInfo[] constInfo = t.GetConstructors();
            for (int i = (int)Numbers.Number; i < constInfo.Length; i++)
            {
                object[] propAttr = constInfo[i].GetCustomAttributes(true).ToArray();

                foreach (Attribute attr in propAttr)
                {
                    switch (attr)
                    {
                        case DocumentAttribute docAttribute:
                            output += $"\nConstructor: {constInfo[i].Name}\n\tDescription: {docAttribute.Description}";
                            break;
                    }
                }
            }
        }

        public static void ViewMethods(Type t)
        {

            MethodInfo[] methodInfo = t.GetMethods();

            for (int i = (int)Numbers.Number; i < methodInfo.Length; i++)
            {
                var methods = methodInfo[i].GetCustomAttributes(true).ToArray();

                foreach (var method in methods)
                {
                    switch (method)
                    {
                        case DocumentAttribute doc:
                            output += $"\nMethod Name: {methodInfo[i].Name}\n\tDescription: {doc.Description}\n\tInput: {doc.Input}\n\tOutput: {doc.Output}";
                            break;
                    }
                }
            }
        }

        public static void ViewFields(Type t)
        {

            FieldInfo[] fieldInfo = t.GetFields();

            for (int i = (int)Numbers.Number; i < fieldInfo.Length; i++)
            {
                var fields = fieldInfo[i].GetCustomAttributes(true).ToArray();

                foreach (var field in fields)
                {
                    switch (field)
                    {
                        case DocumentAttribute _doc:

                            output += $"\nFieldName: {fieldInfo[i].Name}\n\t Description: {_doc.Description}";
                            break;
                    }
                }
            }
        }
        public static void ViewStats(Type t)
        {
            output += $"\nBase class: {t.BaseType}\n\tIs type enum? {t.IsEnum}\n\tIs type interface? {t.IsInterface}\n\tIs type class? {t.IsClass} ";

        }

        public static void GetDoc(Type t)
        {
            if (t.IsClass)
            {
                ViewClasses(t);
                ViewConstructors(t);
                ViewFields(t);
                ViewMethods(t);
                ViewProperties(t);
                ViewStats(t);

                
            }
            if (t.IsEnum)
            {
                Console.WriteLine($"\nEnum: {t.Name}");
                string[] names = t.GetEnumNames();
                foreach (string name in names)
                {
                    Console.WriteLine(name);

                }
                Console.WriteLine();

                ViewStats(t);
            } 
            
            
            if(t.IsInterface)
            {
                Console.WriteLine($"Interface: {t.Name}");
                ViewMethods(t);
            }

            TextFormat.ConvertToText(output);
            TextFormat.ConvertToJson(output);
            TextFormat.ReadAllString();
            
        }
        
       
    }
     
        
}
