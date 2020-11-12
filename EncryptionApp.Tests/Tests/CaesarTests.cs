using EncryptionApp.Models.Models.Ciphers;
using System;
using Xunit;

namespace EncryptionApp.Tests.Tests
{
    public class CaesarTests
    {
        [Fact]
        private void EncryptMethodReturnsMessage()
        {
            //Arrange
            var caesarCipher = new CaesarCipher();
            var message = Guid.NewGuid().ToString();

            var key = new Random().Next(1, 100);

            //Act
            var encryptredMessage = caesarCipher.Encrypt(message, key);

            //Assert
            Assert.NotNull(encryptredMessage);
        }

        [Fact]
        private void DecryptMethodReturnsMessage()
        {
            //Arrange
            var caesarCipher = new CaesarCipher();
            var message = Guid.NewGuid().ToString();

            var key = new Random().Next(1, 100);

            //Act
            var encryptredMessage = caesarCipher.Decrypt(message, key);

            //Assert
            Assert.NotNull(encryptredMessage);
        }

        [Fact]
        private void MessagesAreEqual()
        {
            //Arrange
            var caesarCipher = new CaesarCipher();
            var message = Guid.NewGuid().ToString();

            var key = new Random().Next(1, 100);

            //Act
            var encryptredMessage = caesarCipher.Encrypt(message, key);
            var decryptedMessage = caesarCipher.Decrypt(encryptredMessage, key);

            //Assert
            Assert.NotNull(encryptredMessage);
            Assert.NotNull(decryptedMessage);
            Assert.Equal(message.ToLower(), decryptedMessage.ToLower());
        }
    }
}
