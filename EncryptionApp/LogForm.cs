using EncryptionApp.Models.DB;
using EncryptionApp.Models.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EncryptionApp.UI
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();

            GetLogs();
        }

        private async void GetLogs()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                IEnumerable<LogMessage> logMessages = await db.LogMessages.ToListAsync();

                foreach(var log in logMessages)
                {
                    LogList.Items.Add(log);
                }
            }
        }
    }
}
