using System;

namespace DocumentationTools.BLL.Interfaces
{
    public interface IDocumentationServices
    {
        public void ViewMethods(Type t);
        public void ViewProperties(Type t);
        public void ViewConstructors(Type t);
        public void ViewClasses(Type t);
        public void ViewFields(Type t);
        public void ViewStats(Type t);




    }
}
