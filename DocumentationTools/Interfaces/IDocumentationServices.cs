using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationTools.BLL.Interfaces
{
    public interface IDocumentationServices
    {
        public void ListMethods(Type t);
        public void ListProperties(Type t);
        public void ListConstructors(Type t);
        


    }
}
