using DocumentationTools.BLL.Interfaces;
using DocumentationTools.Data.Domain;
using DocumentationTools.Data.Enums;
using System;
using System.Linq;
using System.Reflection;

namespace DocumentationTools.BLL.Implementation
{

    public class DocumentationServices : IDocumentationServices
    {
        public static void ViewClasses(Type t)
        {

            Console.WriteLine($"Assembly: {Assembly.GetExecutingAssembly().FullName}\nClass: {t.Name}");

            var attributes = t.GetCustomAttributes(true)
                             .Where(a => a is DocumentAttribute);


            foreach (var attribute in attributes)
            {
                DocumentAttribute doc = new DocumentAttribute();
                Console.WriteLine($"Description:{doc.Description}");

            }
        }
        public static void ViewProperties(Type t)
        {

            PropertyInfo[] propertyInfo = t.GetProperties();

            for (int i = (int)Numbers.Number; i < propertyInfo.GetLength(0); i++)
            {
                var properties = propertyInfo[i].GetCustomAttributes(true)
                                 .Where(a => a is DocumentAttribute);

                foreach (var property in properties)
                {
                    DocumentAttribute doc = new DocumentAttribute();
                    Console.WriteLine($"Description:{doc.Description}");
                }
            }
        }

        public void ViewConstructors(Type t)
        {

            ConstructorInfo[] constInfo = t.GetConstructors();

            for (int i = (int)Numbers.Number; i < constInfo.GetLength(0); i++)
            {
                var constructors = constInfo[i].GetCustomAttributes(true)
                                 .Where(a => a is DocumentAttribute);

                foreach (var constructor in constructors)
                {
                    DocumentAttribute doc = new DocumentAttribute();
                    Console.WriteLine($"Description:{doc.Description}");
                }
            }
        }

            public void ListMethods(Type t)
        {

            MethodInfo[] methodInfo = t.GetMethods();

            for (int i = (int)Numbers.Number; i < methodInfo.GetLength(0); i++)
            {
                var methods = methodInfo[i].GetCustomAttributes(true)
                                 .Where(a => a is DocumentAttribute);

                foreach (var method in methods)
                {
                    DocumentAttribute doc = new DocumentAttribute();
                    Console.WriteLine($"Description:{doc.Description}, Input: {doc.Input}, Output: {doc.Output}");
                }
            }
        }

        public void ListProperties(Type t)
        {
            Console.WriteLine("Property Details");

            PropertyInfo[] properties = t.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"Name: {property.Name}, Attributes: {property.Attributes}");
            }
        }
        public void ListFields(Type t)
        {

            FieldInfo[] fieldInfo = t.GetFields();

            for (int i = (int)Numbers.Number; i < fieldInfo.GetLength(0); i++)
            {
                var fields = fieldInfo[i].GetCustomAttributes(true)
                                 .Where(a => a is DocumentAttribute);

                foreach (var property in fields)
                {
                    DocumentAttribute doc = new DocumentAttribute();
                    Console.WriteLine($"Description:{doc.Description}");
                }
            }
        }
        public void ListStats(Type t)
        {
            Console.WriteLine($"Base class: {t.BaseType}\nIs type enum? {t.IsEnum}\nIs type interface? {t.IsInterface}\nIs type class? {t.IsClass} ");
        }
        
        public void GetDoc(Type t)
        {
            ListConstructors(t);
            ListFields(t);
            ListMethods(t);
            ListProperties(t);
            ListStats(t);

        }
    }
}
