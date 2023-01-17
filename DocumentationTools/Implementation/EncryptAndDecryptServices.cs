using System;
using System.Collections.Generic;
using System.Linq;
using DocumentationTools.BLL.Interfaces;
using DocumentationTools.Data.Domain;
using DocumentationTools.Data.Enums;

namespace DocumentationTools.BLL.Implementation
{
    [Document(Description = "This is the EncryptAndDecryptServices and it implements the IEncryptAndDecryptServices interface")]
    public class EncryptAndDecryptServices: IEncryptAndDecryptServices
    {
        [Document(Description = "A private field and an instance of the AlphabetsAndValues class")]
        AlphabetsAndValues _kv = new AlphabetsAndValues();
        [Document(Description = "A private field and a dictionary for the encryptionKeys")]
        Dictionary<char, char> _encryptionKeys = new Dictionary<char, char>();
        [Document(Description = "A private field and a dictionary for the decryptionKeys")]
        Dictionary<char, char> _decryptionKeys = new Dictionary<char, char>();

        [Document(Description = "This is the Decrypt method", Input = "It takes in a string", Output = "It returns a string")]
        public string Decrypt(string sentence)
        {
            Init();
            string decryptedWord = sentence;
            foreach (string word in sentence.Split(' '))
            {

                for (int i = (int)Numbers.Number; i < word.Length; i++)
                {
                    char currentChar = word.ElementAt(i);
                    char replacementChar = _decryptionKeys.Keys.Contains(currentChar) != null ? _decryptionKeys.GetValueOrDefault(currentChar) : currentChar;

                    decryptedWord = decryptedWord.Replace(currentChar, replacementChar);
                }
            }

            return string.Join(" ", decryptedWord);
        }
        [Document(Description = "This is the Encrypt method", Input = "It takes in a string", Output = "It returns a string")]
        public string Encrypt(string sentence)
        {
            Init();
            string encryptedWord = sentence;

            foreach (string word in sentence.Split(' '))
            {
                for (int i = (int)Numbers.Number; i < word.Length; i++)
                {
                    char currentChar = word.ElementAt(i);
                    char replacementChar = _encryptionKeys.Keys.Contains(currentChar) != null ? _encryptionKeys.GetValueOrDefault(currentChar) : currentChar;

                    encryptedWord = encryptedWord.Replace(currentChar, replacementChar);
                }
            }
            return string.Join(" ", encryptedWord);
        }
        [Document(Description = "This is the private Init method")]
        private void Init()
        {
            for (int i = (int)Numbers.Number; i < (int)Numbers.LengthOfAlphabet; i++)
            {
                _encryptionKeys.Add(_kv.Alphabets[i], _kv.DecryptionKeys[i]);
            }

            for (int i = 0; i < (int)Numbers.LengthOfAlphabet; i++)
            {
                _decryptionKeys.Add(_kv.DecryptionKeys[i], _kv.Alphabets[i]);
            }
        }
    }
}
