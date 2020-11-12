using System;
using System.Linq;

namespace EncryptionApp.Models.Models.Ciphers
{
    public class PolybiusSquareCipher
    {
        char[,] square;
        string alphabet; 
        const string englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string russingAlfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        //возвращает квадрат Полибия
        char[,] GetSquare(string key)
        {
            var newAlphabet = alphabet;
            //удаляем из алфавита все символы которые содержит ключ
            for (int i = 0; i < key.Length; i++)
            {
                newAlphabet = newAlphabet.Replace(key[i].ToString(), "");
            }

            //добавляем пароль в начало алфавита, а в конец дополнительные знаки
            //для того чтобы избежать пустых ячеек
            newAlphabet = key + newAlphabet + "0123456789!@#$%^&*)_+-=<>?,.-";

            //получаем размер стороны квадрата
            //округлением квадратного корня в сторону большего целого числа
            var n = (int)Math.Ceiling(Math.Sqrt(alphabet.Length));

            //создаем и заполняем массив
            square = new char[n, n];
            var index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (index < newAlphabet.Length)
                    {
                        square[i, j] = newAlphabet[index];
                        index++;
                    }
                }
            }

            return square;
        }

        //поиск символа в двухмерном массиве
        bool FindSymbol(char[,] symbolsTable, char symbol, out int column, out int row)
        {
            var l = symbolsTable.GetUpperBound(0) + 1;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (symbolsTable[i, j] == symbol)
                    {
                        //значение найдено
                        row = i;
                        column = j;
                        return true;
                    }
                }
            }

            //если ничего не нашли
            row = -1;
            column = -1;
            return false;
        }

        public string PolibiusEncrypt(string text, string password)
        {
            alphabet = CheckAlfabet(text); 
                text = text.ToUpper();
            password = password.ToUpper();

            var outputText = "";
            var square = GetSquare(password);

            var m = text.Length;
            var coordinates = new int[m * 2];
            for (int i = 0; i < m; i++)
            {
                if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                {
                    coordinates[i] = columnIndex;
                    coordinates[i + m] = rowIndex;
                }
            }

            for (int i = 0; i < m * 2; i += 2)
            {
                outputText += square[coordinates[i + 1], coordinates[i]];
            }

            return outputText;
        }

        public string PolybiusDecrypt(string text, string password)
        {
            alphabet = CheckAlfabet(text);
            text = text.ToUpper();
            password = password.ToUpper();

            var outputText = "";
            var square = GetSquare(password);
            var m = text.Length;

            var coordinates = new int[m * 2];
            var j = 0;
            for (int i = 0; i < m; i++)
            {
                if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                {
                    coordinates[j] = columnIndex;
                    coordinates[j + 1] = rowIndex;
                    j += 2;
                }
            }

            for (int i = 0; i < m; i++)
            {
                outputText += square[coordinates[i + m], coordinates[i]];
            }

            return outputText;
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
