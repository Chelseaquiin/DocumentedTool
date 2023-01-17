using DocumentationTools.Data.Domain;

namespace DocumentationTools.BLL.Interfaces
{
    [Document(Description = "This is the IEncryptAndDecryptServices interface")]
    public interface IEncryptAndDecryptServices
    {
        public string Encrypt(string sentence);
        public string Decrypt(string sentence);
    }
}
