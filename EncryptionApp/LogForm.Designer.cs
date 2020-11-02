namespace EncryptionApp.UI
{
    partial class LogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogList = new System.Windows.Forms.ListBox();
            this.ClearLogsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogList
            // 
            this.LogList.FormattingEnabled = true;
            this.LogList.ItemHeight = 15;
            this.LogList.Location = new System.Drawing.Point(13, 13);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(739, 334);
            this.LogList.TabIndex = 0;
            // 
            // ClearLogsButton
            // 
            this.ClearLogsButton.BackColor = System.Drawing.Color.DarkGray;
            this.ClearLogsButton.Location = new System.Drawing.Point(326, 367);
            this.ClearLogsButton.Name = "ClearLogsButton";
            this.ClearLogsButton.Size = new System.Drawing.Size(112, 26);
            this.ClearLogsButton.TabIndex = 1;
            this.ClearLogsButton.Text = "Delete logs";
            this.ClearLogsButton.UseVisualStyleBackColor = false;
            this.ClearLogsButton.Click += new System.EventHandler(this.DeleteLogButton_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 405);
            this.Controls.Add(this.ClearLogsButton);
            this.Controls.Add(this.LogList);
            this.Name = "LogForm";
            this.Text = "Logs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LogList;
        private System.Windows.Forms.Button ClearLogsButton;
    }
}