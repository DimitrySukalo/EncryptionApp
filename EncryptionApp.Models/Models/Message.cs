using System;

namespace EncryptionApp.Models.Models
{
    public class Message
    {
        public delegate void NotifyDelegate(string message); 
        public event NotifyDelegate _showMessage;

        private string Text { get; }

        public Message(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException(nameof(text), " was null.");

            Text = text;
        }

        public void ShowMessage()
        {
            _showMessage.Invoke(Text);
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
