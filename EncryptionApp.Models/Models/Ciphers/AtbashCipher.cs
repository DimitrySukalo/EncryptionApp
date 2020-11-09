using System.Linq;

namespace EncryptionApp.Models.Models.Ciphers
{
    public class AtbashCipher
    {
        const string englishAlphabet = "abcdefghijklmnopqrstuvwxyz";
        const string russingAlfabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        string alfabet;

        //метод для переворачивания строки
        private string Reverse(string inputText)
        {
            //переменная для хранения результата
            var reversedText = string.Empty;
            foreach (var s in inputText)
            {
                //добавляем символ в начало строки
                reversedText = s + reversedText;
            }

            return reversedText;
        }

        //метод шифрования/дешифрования
        private string EncryptDecrypt(string text, string symbols, string cipher)
        {
            //переводим текст в нижний регистр
            text = text.ToLower();

            var outputText = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                //поиск позиции символа в строке алфавита
                var index = symbols.IndexOf(text[i]);
                if (index >= 0)
                {
                    //замена символа на шифр
                    outputText += cipher[index].ToString();
                }
            }

            return outputText;
        }

        //шифрование текста
        public string EncryptText(string plainText, string key = "")
        {
            alfabet = CheckAlfabet(plainText);
            return EncryptDecrypt(plainText, alfabet, Reverse(alfabet));
        }

        //расшифровка текста
        public string DecryptText(string encryptedText, string key = "")
        {
            alfabet = CheckAlfabet(encryptedText);
            return EncryptDecrypt(encryptedText, Reverse(alfabet), alfabet);
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
    }
}
