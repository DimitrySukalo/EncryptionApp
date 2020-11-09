using EncryptionApp.Models.Models.Ciphers;
using System;
using Xunit;

namespace EncryptionApp.Tests.Tests
{
    public class Base64CipherTests
    {
        [Fact]
        private void EncryptMethodReturnMessage()
        {
            //Arrange
            Base64Cipher base64Cipher = new Base64Cipher();
            var randomMessage = Guid.NewGuid().ToString();

            //Act
            var text = base64Cipher.Encrypt(randomMessage);

            //Assert
            Assert.NotNull(text);
        }

        [Fact]
        private void EncryptMethodReturnsEmptyMessage()
        {
            //Arrange
            Base64Cipher base64Cipher = new Base64Cipher();
            string message = null;

            //Act
            var text = base64Cipher.Encrypt(message);

            //Assert
            Assert.NotNull(text);
            Assert.Equal(text, string.Empty);
        }

        [Fact]
        private void MessagesAreEqual()
        {
            //Arrange
            Base64Cipher base64Cipher = new Base64Cipher();
            var randomMessage = Guid.NewGuid().ToString();

            //Act
            var encText = base64Cipher.Encrypt(randomMessage);
            var decText = base64Cipher.Decrypt(encText);

            //Assert
            Assert.NotNull(encText);
            Assert.NotNull(decText);
            Assert.Equal(randomMessage.ToLower(), decText.ToLower());
        }

        [Fact]
        private void DecryptMethodReturnsEmptyMessage()
        {
            //Arrange
            Base64Cipher base64Cipher = new Base64Cipher();
            string message = null;

            //Act
            var text = base64Cipher.Decrypt(message);

            //Assert
            Assert.NotNull(text);
            Assert.Equal(text, string.Empty);
        }
    }
}
