using DocumentationTools.BLL.Implementation;
using DocumentationTools.BLL.Interfaces;
using DocumentationTools.Data.Domain;
using DocumentationTools.Data.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocumentationTools.UI
{
    internal class Application
    {
        public void Start()
        {
 
            Services.GetDoc(typeof(AlphabetsAndValues));
            Services.GetDoc(typeof(EncryptAndDecryptServices));
            Services.GetDoc(typeof(Numbers));
            Services.GetDoc(typeof(IEncryptAndDecryptServices));

           
           /* TextFormat.ConvertToText(typeof(AlphabetsAndValues));
            TextFormat.ConvertToText(typeof(EncryptAndDecryptServices));
            TextFormat.ConvertToText(typeof(Numbers));
            TextFormat.ConvertToText(typeof(IEncryptAndDecryptServices));*/
            //string jsonString = JsonSerializer.Serialize(DocumentationServices.GetDoc(typeof(AlphabetsAndValues)));

            

        }
    }
}
