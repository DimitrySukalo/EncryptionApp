using EncryptionApp.Models.Models.Ciphers;
using System;
using Xunit;

namespace EncryptionApp.Tests.Tests
{
    public class AtbashTests
    {
        [Fact]
        private void EncryptMethodReturnsMessage()
        {
            //Arrange
            var atbashCipher = new AtbashCipher();
            var message = "test";

            //Act
            var encryptredMessage = atbashCipher.EncryptText(message);

            //Assert
            Assert.NotNull(encryptredMessage);
        }

        [Fact]
        private void DecryptMethodReturnsMessage()
        {
            //Arrange
            var atbashCipher = new AtbashCipher();
            var message = "test";

            //Act
            var encryptredMessage = atbashCipher.DecryptText(message);

            //Assert
            Assert.NotNull(encryptredMessage);
        }

        [Fact]
        private void MessagesAreEqual()
        {
            //Arrange
            var atbashCipher = new AtbashCipher();
            var message = "test";

            //Act
            var encryptredMessage = atbashCipher.EncryptText(message.ToLower());
            var decryptedMessage = atbashCipher.DecryptText(encryptredMessage.ToLower());

            //Assert
            Assert.NotNull(encryptredMessage);
            Assert.NotNull(decryptedMessage);
            Assert.Equal(message.ToLower(), decryptedMessage.ToLower());
        }
    }
}
