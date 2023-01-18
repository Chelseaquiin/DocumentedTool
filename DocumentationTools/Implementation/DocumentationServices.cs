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
        DocumentAttribute _doc = new DocumentAttribute();
        public void ViewClasses(Type t)
        {

            Console.WriteLine($"Assembly: {Assembly.GetExecutingAssembly().FullName}\nClass: {t.Name}");

            var attributes = t.GetCustomAttributes(true)
                             .Where(a => a is DocumentAttribute);


            foreach (var attribute in attributes)
            {
               
                Console.WriteLine($"Description:{_doc.Description}");

            }
        }
        public void ViewProperties(Type t)
        {

            PropertyInfo[] propertyInfo = t.GetProperties();

            for (int i = (int)Numbers.Number; i < propertyInfo.Length; i++)
            {
                var properties = propertyInfo[i].GetCustomAttributes(true)
                                 .Where(a => a is DocumentAttribute);

                foreach (var property in properties)
                {
                    Console.WriteLine($"Method Name: {propertyInfo[i].Name}\nDescription:{_doc.Description}");
                }
            }
        }

        public void ViewConstructors(Type t)
        {

            ConstructorInfo[] constInfo = t.GetConstructors();

            for (int i = (int)Numbers.Number; i < constInfo.Length; i++)
            {
                var constructors = constInfo[i].GetCustomAttributes(true)
                                 .Where(a => a is DocumentAttribute);

                foreach (var constructor in constructors)
                {
                    Console.WriteLine($"Method Name: {constInfo[i].Name}\nDescription:{_doc.Description}");
                }
            }
        }

        public void ViewMethods(Type t)
        {

            MethodInfo[] methodInfo = t.GetMethods();

            for (int i = (int)Numbers.Number; i < methodInfo.Length; i++)
            {
                var methods = methodInfo[i].GetCustomAttributes(true)
                                 .Where(a => a is DocumentAttribute);

                foreach (var method in methods)
                {
                    Console.WriteLine($"Method Name: {methodInfo[i].Name}\nDescription: {_doc.Description}\nInput: {_doc.Input}\nOutput: {_doc.Output}");
                }
            }
        }

        public void ViewFields(Type t)
        {

            FieldInfo[] fieldInfo = t.GetFields();

            for (int i = (int)Numbers.Number; i < fieldInfo.Length; i++)
            {
                var fields = fieldInfo[i].GetCustomAttributes(true)
                                 .Where(a => a is DocumentAttribute);

                foreach (var f in fields)
                {
                    Console.WriteLine($"FieldName: {fieldInfo[i].Name}\n Description: {_doc.Description}");
                }
            }
        }
        public void ViewStats(Type t)
        {
            Console.WriteLine($"Base class: {t.BaseType}\nIs type enum? {t.IsEnum}\nIs type interface? {t.IsInterface}\nIs type class? {t.IsClass} ");
        }

        public void GetDoc(Type t)
        {
            ViewClasses(t);
            ViewConstructors(t);
            ViewFields(t);
            ViewMethods(t);
            ViewProperties(t);
            ViewStats(t);

        }
    } 
}
