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
            EncryptAndDecryptServices ead = new EncryptAndDecryptServices();
            AlphabetsAndValues av = new AlphabetsAndValues();

            SerializeAndDeserialize.SaveAsJsonFormat(ead, "EADMethods.Json" );
            SerializeAndDeserialize.SaveAsJsonFormat(av, "AlphabetsAndValues.Json");

            DocumentationServices.GetDoc(typeof(AlphabetsAndValues));
            DocumentationServices.GetDoc(typeof(EncryptAndDecryptServices));
            DocumentationServices.GetDoc(typeof(Numbers));
            DocumentationServices.GetDoc(typeof(IEncryptAndDecryptServices));


        }
    }
}
