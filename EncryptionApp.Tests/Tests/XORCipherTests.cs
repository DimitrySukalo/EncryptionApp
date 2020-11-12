using EncryptionApp.Models.Models;
using System;
using Xunit;

namespace EncryptionApp.Tests.Tests
{
    public class XORCipherTests
    {
        [Fact]
        private void EncryptMethodReturnsMessage()
        {
            //Arrange
            var xorCipher = new XORCipher();
            var message = Guid.NewGuid().ToString();

            var key = Guid.NewGuid().ToString();

            //Act
            var encryptredMessage = xorCipher.Encrypt(message, key);

            //Assert
            Assert.NotNull(encryptredMessage);
        }

        [Fact]
        private void DecryptMethodReturnsMessage()
        {
            //Arrange
            var xorCipher = new XORCipher();
            var message = Guid.NewGuid().ToString();

            var key = Guid.NewGuid().ToString();

            //Act
            var encryptredMessage = xorCipher.Decrypt(message, key);

            //Assert
            Assert.NotNull(encryptredMessage);
        }

        [Fact]
        private void MessagesAreEqual()
        {
            //Arrange
            var xorCipher = new XORCipher();
            var message = Guid.NewGuid().ToString();

            var key = Guid.NewGuid().ToString();

            //Act
            var encryptredMessage = xorCipher.Encrypt(message, key);
            var decryptedMessage = xorCipher.Decrypt(encryptredMessage, key);

            //Assert
            Assert.NotNull(encryptredMessage);
            Assert.NotNull(decryptedMessage);
            Assert.Equal(message.ToLower(), decryptedMessage.ToLower());
        }
    }
}
