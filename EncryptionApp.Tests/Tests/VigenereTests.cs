using EncryptionApp.Models.Models;
using System;
using Xunit;

namespace EncryptionApp.Tests.Tests
{
    public class VigenereTests
    {
        [Fact]
        private void EncryptMethodReturnsMessage()
        {
            //Arrange
            var vigenereCipher = new VigenereCipher();
            var message = Guid.NewGuid().ToString();

            var key = Guid.NewGuid().ToString();

            //Act
            var encryptredMessage = vigenereCipher.Encrypt(message, key);

            //Assert
            Assert.NotNull(encryptredMessage);
        }

        [Fact]
        private void DecryptMethodReturnsMessage()
        {
            //Arrange
            var vigenereCipher = new VigenereCipher();
            var message = Guid.NewGuid().ToString();

            var key = Guid.NewGuid().ToString();

            //Act
            var encryptredMessage = vigenereCipher.Decrypt(message, key);

            //Assert
            Assert.NotNull(encryptredMessage);
        }

        [Fact]
        private void MessagesAreEqual()
        {
            //Arrange
            var vigenereCipher = new VigenereCipher();
            var message = Guid.NewGuid().ToString();

            var key = Guid.NewGuid().ToString();

            //Act
            var encryptredMessage = vigenereCipher.Encrypt(message, key);
            var decryptedMessage = vigenereCipher.Decrypt(encryptredMessage, key);

            //Assert
            Assert.NotNull(encryptredMessage);
            Assert.NotNull(decryptedMessage);
            Assert.Equal(message.ToLower(), decryptedMessage.ToLower());
        }
    }
}
