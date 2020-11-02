using System;

namespace EncryptionApp.Models.Models
{
    public class LogMessage
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public string Message { get; set; }

        public LogMessage(DateTime time, string message)
        {
            if(time == null)
            {
                throw new ArgumentNullException(nameof(time), " was null.");
            }

            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentNullException(nameof(message), " was null.");
            }

            Time = time;
            Message = message;
        }

        public override string ToString()
        {
            return $"{Time}: {Message}";
        }
    }
}
