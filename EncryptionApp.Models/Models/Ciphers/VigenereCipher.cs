using System;
using System.Linq;

namespace EncryptionApp.Models.Models
{
    public class VigenereCipher
    {
        const string englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string russingAlfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        string letters;

        public VigenereCipher(string alphabet = null)
        {
            letters = string.IsNullOrEmpty(alphabet) ? englishAlphabet : alphabet;
        }

        private string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }

            return p.Substring(0, n);
        }

        private string Vigenere(string text, string password, bool encrypting = true)
        {
            letters = CheckAlfabet(text);

            if (!string.IsNullOrWhiteSpace(letters))
            {
                var gamma = GetRepeatKey(password, text.Length);
                var retValue = "";
                var q = letters.Length;

                for (int i = 0; i < text.Length; i++)
                {
                    var letterIndex = letters.IndexOf(text[i]);
                    var codeIndex = letters.IndexOf(gamma[i]);
                    if (letterIndex < 0)
                    {
                        retValue += text[i].ToString();
                    }
                    else
                    {
                        retValue += letters[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                    }
                }

                return retValue;
            }
            else
            {
                throw new ArgumentNullException(nameof(text), " is unrecognized language.");
            }
        }

        private string CheckAlfabet(string text)
        {
            var letters = text.ToLower().ToCharArray().ToList();

            foreach(var letter in letters)
            {
                if(russingAlfabet.ToLower().Contains(letter))
                {
                    return russingAlfabet;
                }
            }

            foreach(var letter in letters)
            {
                if(englishAlphabet.ToLower().Contains(letter))
                {
                    return englishAlphabet;
                }
            }

            return null;

        }

        public string Encrypt(string plainMessage, string password)
            => Vigenere(plainMessage, password);

        public string Decrypt(string encryptedMessage, string password)
            => Vigenere(encryptedMessage, password, false);
    }
}
