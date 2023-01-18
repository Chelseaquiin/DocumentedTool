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

            var attributes = t.GetCustomAttributes(true).ToArray();

            foreach (var attribute in attributes)
            {
                switch (attribute)
                {
                    case DocumentAttribute _doc:
                        Console.WriteLine($"\nDescription:{_doc.Description}");
                        break;
                }
            }
        }
        public void ViewProperties(Type t)
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
                            Console.WriteLine($"\nProperties: {properties[i].Name}\nDescription:\n\t{docAttribute.Description}");
                            break;
                    }
                }
            }
        }

        public void ViewConstructors(Type t)
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
                            Console.WriteLine($"\nConstructor: {constInfo[i].Name}\nDescription:\n\t{docAttribute.Description}");
                            break;
                    }
                }
            }
        }

        public void ViewMethods(Type t)
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
                            Console.WriteLine($"\nMethod Name: {methodInfo[i].Name}\nDescription: {_doc.Description}\nInput: {_doc.Input}\nOutput: {_doc.Output}");
                            break;
                    }
                }
            }
        }

        public void ViewFields(Type t)
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
                            Console.WriteLine($"\nFieldName: {fieldInfo[i].Name}\n Description: {_doc.Description}");
                            break;
                    }
                }
            }
        }
        public void ViewStats(Type t)
        {
            Console.WriteLine($"\nBase class: {t.BaseType}\nIs type enum? {t.IsEnum}\nIs type interface? {t.IsInterface}\nIs type class? {t.IsClass} ");
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
