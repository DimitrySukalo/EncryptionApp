using System;
using System.Text;

namespace EncryptionApp.Models.Models.Ciphers
{
    public class Base64Cipher
    {
        public string Encrypt(string message, string key = "")
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                var byteArray = Encoding.ASCII.GetBytes(message);
                var encryptedMessage = Convert.ToBase64String(byteArray);

                return encryptedMessage;
            }

            return string.Empty;
        }

        public string Decrypt(string message, string key = "")
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                var decodedBytes = Convert.FromBase64String(message);
                var decodedMessage = Encoding.ASCII.GetString(decodedBytes);

                return decodedMessage;
            }

            return string.Empty;
        }
    }
}
