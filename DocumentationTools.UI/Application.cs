using DocumentationTools.BLL.Implementation;
using DocumentationTools.BLL.Interfaces;
using DocumentationTools.Data.Domain;
using DocumentationTools.Data.Enums;

namespace DocumentationTools.UI
{
    internal class Application
    {
        public void Start()
        {
            DocumentationServices doc = new DocumentationServices();
                    
            doc.GetDoc(typeof(AlphabetsAndValues));
            doc.GetDoc(typeof(EncryptAndDecryptServices));
            doc.GetDoc(typeof(Numbers));
            doc.GetDoc(typeof(IEncryptAndDecryptServices));


        }
    }
}
