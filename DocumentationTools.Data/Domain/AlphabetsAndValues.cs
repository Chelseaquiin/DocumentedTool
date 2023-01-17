
namespace DocumentationTools.Data.Domain
{
    [Document(Description = "This is the AlphabetsAndValues class located in the DocumentationTools.Domain Namespace")]
    public class AlphabetsAndValues
    {
        [Document(Description = "This is a property in the AlphabetsAndValues class. It gets the letters in the English Alphabet")]
        public char[] Alphabets { get; } = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        [Document(Description = "This is a property in the AlphabetsAndValues class. It gets the DecryptionKeys Matched to the letters in the English Alphabet")]
        public char[] DecryptionKeys { get; } = { '£', '*', '%', '&', '>', '<', '!', ')', '"', '(', '@', '`', '~', '[', '|', ']', '{', '}', ':', ';', '+', ',', '.', '?', '/', '=' };

    }
}
