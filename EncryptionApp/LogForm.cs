using EncryptionApp.Models.DB;
using EncryptionApp.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EncryptionApp.UI
{
    public partial class LogForm : Form
    {
        private readonly DatabaseContext db;

        public LogForm(DatabaseContext context)
        {
            db = context ?? throw new ArgumentNullException(nameof(context), " was null.");

            InitializeComponent();

            GetLogs(db);
        }

        private async void GetLogs(DatabaseContext db)
        {
            IEnumerable<LogMessage> logMessages = await db.LogMessages.ToListAsync();

            foreach(var log in logMessages)
            {
                LogList.Items.Add(log);
            }
        }

        private async void DeleteLogButton_Click(object sender, EventArgs e)
        {
            IEnumerable<LogMessage> logMessages = await db.LogMessages.ToListAsync();

            db.LogMessages.RemoveRange(logMessages);
            await db.SaveChangesAsync();

            MessageBox.Show("Logs have been removed successfully! Restart your log icon, please");
        }
    }
}
