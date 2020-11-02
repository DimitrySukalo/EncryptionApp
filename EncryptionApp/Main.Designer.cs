namespace EncryptionApp.UI
{
    partial class Main
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
            this.ToolBar = new System.Windows.Forms.MenuStrip();
            this.LogsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SiteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExplorer = new System.Windows.Forms.TreeView();
            this.LogInfo = new System.Windows.Forms.ListBox();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogsItem,
            this.SiteItem,
            this.HelpItem});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(157, 24);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Text = "TopMenu";
            // 
            // LogsItem
            // 
            this.LogsItem.Name = "LogsItem";
            this.LogsItem.Size = new System.Drawing.Size(44, 20);
            this.LogsItem.Text = "Logs";
            this.LogsItem.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // SiteItem
            // 
            this.SiteItem.Name = "SiteItem";
            this.SiteItem.Size = new System.Drawing.Size(61, 20);
            this.SiteItem.Text = "Our Site";
            // 
            // HelpItem
            // 
            this.HelpItem.Name = "HelpItem";
            this.HelpItem.Size = new System.Drawing.Size(44, 20);
            this.HelpItem.Text = "Help";
            // 
            // FileExplorer
            // 
            this.FileExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FileExplorer.Location = new System.Drawing.Point(13, 28);
            this.FileExplorer.Name = "FileExplorer";
            this.FileExplorer.Size = new System.Drawing.Size(301, 511);
            this.FileExplorer.TabIndex = 2;
            // 
            // LogInfo
            // 
            this.LogInfo.FormattingEnabled = true;
            this.LogInfo.ItemHeight = 15;
            this.LogInfo.Location = new System.Drawing.Point(320, 473);
            this.LogInfo.Name = "LogInfo";
            this.LogInfo.Size = new System.Drawing.Size(779, 64);
            this.LogInfo.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 551);
            this.Controls.Add(this.LogInfo);
            this.Controls.Add(this.FileExplorer);
            this.Controls.Add(this.ToolBar);
            this.Name = "Main";
            this.Text = "EncryptionApp";
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip ToolBar;
        private System.Windows.Forms.ToolStripMenuItem LogsItem;
        private System.Windows.Forms.ToolStripMenuItem SiteItem;
        private System.Windows.Forms.ToolStripMenuItem HelpItem;
        private System.Windows.Forms.TreeView FileExplorer;
        private System.Windows.Forms.ListBox LogInfo;
    }
}