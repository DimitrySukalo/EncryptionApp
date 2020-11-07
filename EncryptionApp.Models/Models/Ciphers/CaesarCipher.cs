using System.Linq;

namespace EncryptionApp.Models.Models.Ciphers
{
    public class CaesarCipher
    {
        const string englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string russingAlfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        string alfabet;

        private string CodeEncode(string text, int k)
        {
            alfabet = CheckAlfabet(text);

            var fullAlfabet = alfabet + alfabet.ToLower();
            var letterQty = fullAlfabet.Length;
            var retVal = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = fullAlfabet.IndexOf(c);
                if (index < 0)
                {
                    retVal += c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index + k) % letterQty;
                    retVal += fullAlfabet[codeIndex];
                }
            }

            return retVal;
        }

        private string CheckAlfabet(string text)
        {
            var letters = text.ToLower().ToCharArray().ToList();

            foreach (var letter in letters)
            {
                if (russingAlfabet.ToLower().Contains(letter))
                {
                    return russingAlfabet;
                }
            }

            foreach (var letter in letters)
            {
                if (englishAlphabet.ToLower().Contains(letter))
                {
                    return englishAlphabet;
                }
            }

            return null;

        }

        public string Encrypt(string plainMessage, int key)
        {
            return CodeEncode(plainMessage, key);
        }

        public string Decrypt(string encryptedMessage, int key)
        {
            return CodeEncode(encryptedMessage, -key);
        }
    }
}
