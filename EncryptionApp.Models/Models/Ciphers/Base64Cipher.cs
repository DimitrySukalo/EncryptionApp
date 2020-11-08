using System;
using System.Text;

namespace EncryptionApp.Models.Models.Ciphers
{
    public class Base64Cipher
    {
        public string Encrypt(string message, string key = "")
        {
            var byteArray = Encoding.ASCII.GetBytes(message);
            var encryptedMessage = Convert.ToBase64String(byteArray);

            return encryptedMessage;
        }

        public string Decrypt(string message, string key = "")
        {
            var decodedBytes = Convert.FromBase64String(message);
            var decodedMessage = Encoding.ASCII.GetString(decodedBytes);

            return decodedMessage;
        }
    }
}
