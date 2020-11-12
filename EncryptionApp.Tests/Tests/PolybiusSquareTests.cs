using EncryptionApp.Models.Models.Ciphers;
using System;
using Xunit;

namespace EncryptionApp.Tests.Tests
{
    public class PolybiusSquareTests
    {
        [Fact]
        private void EncryptMethodReturnsMessage()
        {
            //Arrange
            var polybiusSquare = new PolybiusSquareCipher();
            var message = "test";
            var key = "test";
            //Act
            var encryptredMessage = polybiusSquare.PolibiusEncrypt(message, key);

            //Assert
            Assert.NotNull(encryptredMessage);
        }

        [Fact]
        private void DecryptMethodReturnsMessage()
        {
            //Arrange
            var polybiusSquare = new PolybiusSquareCipher();
            var message = "test";
            var key = "test";

            //Act
            var encryptredMessage = polybiusSquare.PolybiusDecrypt(message, key);

            //Assert
            Assert.NotNull(encryptredMessage);
        }

        [Fact]
        private void MessagesAreEqual()
        {
            //Arrange
            var polybiusSquare = new PolybiusSquareCipher();
            var message = "test";
            var key = "test";

            //Act
            var encryptredMessage = polybiusSquare.PolibiusEncrypt(message.ToLower(), key);
            var decryptedMessage = polybiusSquare.PolybiusDecrypt(encryptredMessage.ToLower(), key);

            //Assert
            Assert.NotNull(encryptredMessage);
            Assert.NotNull(decryptedMessage);
            Assert.Equal(message.ToLower(), decryptedMessage.ToLower());
        }
    }
}
