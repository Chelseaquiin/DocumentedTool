using DocumentationTools.Data.Domain;

namespace DocumentationTools.BLL.Interfaces
{
    [Document(Description = "This is the IEncryptAndDecryptServices interface")]
    public interface IEncryptAndDecryptServices
    {
        [Document(Description = "This is an abstract Encrypt method. It's the method signature of an interface", Input = "It takes in a string", Output = "It returns a string")]
        public string Encrypt(string sentence);
        [Document(Description = "This is an abstract Decrypt method. It's the method signature of an interface", Input = "It takes in a string", Output = "It returns a string")]
        public string Decrypt(string sentence);
    }
}
