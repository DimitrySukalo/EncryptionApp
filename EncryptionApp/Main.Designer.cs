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
            this.ActionTitle = new System.Windows.Forms.Label();
            this.Key = new System.Windows.Forms.Label();
            this.EncDecKey = new System.Windows.Forms.TextBox();
            this.QuestionText = new System.Windows.Forms.Label();
            this.YesRadioButton = new System.Windows.Forms.RadioButton();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.Methods = new System.Windows.Forms.GroupBox();
            this.ScietaleMethod = new System.Windows.Forms.RadioButton();
            this.VigenereMethod = new System.Windows.Forms.RadioButton();
            this.PolybiusSquareMethod = new System.Windows.Forms.RadioButton();
            this.BASE64Method = new System.Windows.Forms.RadioButton();
            this.XORMethod = new System.Windows.Forms.RadioButton();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgressTitle = new System.Windows.Forms.Label();
            this.FileInfoBox = new System.Windows.Forms.GroupBox();
            this.createOfFile = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.nameOfFile = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.pathOfFile = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.sizeOfFile = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ToolBar.SuspendLayout();
            this.Methods.SuspendLayout();
            this.FileInfoBox.SuspendLayout();
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
            // ActionTitle
            // 
            this.ActionTitle.AutoSize = true;
            this.ActionTitle.Location = new System.Drawing.Point(320, 28);
            this.ActionTitle.Name = "ActionTitle";
            this.ActionTitle.Size = new System.Drawing.Size(93, 15);
            this.ActionTitle.TabIndex = 4;
            this.ActionTitle.Text = "Main operations";
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Location = new System.Drawing.Point(321, 67);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(26, 15);
            this.Key.TabIndex = 5;
            this.Key.Text = "Key";
            // 
            // EncDecKey
            // 
            this.EncDecKey.Location = new System.Drawing.Point(353, 64);
            this.EncDecKey.Name = "EncDecKey";
            this.EncDecKey.Size = new System.Drawing.Size(217, 23);
            this.EncDecKey.TabIndex = 6;
            // 
            // QuestionText
            // 
            this.QuestionText.AutoSize = true;
            this.QuestionText.Location = new System.Drawing.Point(321, 274);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(112, 15);
            this.QuestionText.TabIndex = 14;
            this.QuestionText.Text = "Make a copy of file?";
            // 
            // YesRadioButton
            // 
            this.YesRadioButton.AutoSize = true;
            this.YesRadioButton.Location = new System.Drawing.Point(321, 292);
            this.YesRadioButton.Name = "YesRadioButton";
            this.YesRadioButton.Size = new System.Drawing.Size(42, 19);
            this.YesRadioButton.TabIndex = 15;
            this.YesRadioButton.TabStop = true;
            this.YesRadioButton.Text = "Yes";
            this.YesRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Location = new System.Drawing.Point(369, 292);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(41, 19);
            this.NoRadioButton.TabIndex = 16;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Text = "No";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // Methods
            // 
            this.Methods.Controls.Add(this.ScietaleMethod);
            this.Methods.Controls.Add(this.VigenereMethod);
            this.Methods.Controls.Add(this.PolybiusSquareMethod);
            this.Methods.Controls.Add(this.BASE64Method);
            this.Methods.Controls.Add(this.XORMethod);
            this.Methods.Location = new System.Drawing.Point(321, 103);
            this.Methods.Name = "Methods";
            this.Methods.Size = new System.Drawing.Size(249, 168);
            this.Methods.TabIndex = 17;
            this.Methods.TabStop = false;
            this.Methods.Text = "Methods";
            // 
            // ScietaleMethod
            // 
            this.ScietaleMethod.AutoSize = true;
            this.ScietaleMethod.Location = new System.Drawing.Point(6, 122);
            this.ScietaleMethod.Name = "ScietaleMethod";
            this.ScietaleMethod.Size = new System.Drawing.Size(65, 19);
            this.ScietaleMethod.TabIndex = 0;
            this.ScietaleMethod.TabStop = true;
            this.ScietaleMethod.Text = "Scietale";
            this.ScietaleMethod.UseVisualStyleBackColor = true;
            // 
            // VigenereMethod
            // 
            this.VigenereMethod.AutoSize = true;
            this.VigenereMethod.Location = new System.Drawing.Point(6, 97);
            this.VigenereMethod.Name = "VigenereMethod";
            this.VigenereMethod.Size = new System.Drawing.Size(71, 19);
            this.VigenereMethod.TabIndex = 0;
            this.VigenereMethod.TabStop = true;
            this.VigenereMethod.Text = "Vigenere";
            this.VigenereMethod.UseVisualStyleBackColor = true;
            // 
            // PolybiusSquareMethod
            // 
            this.PolybiusSquareMethod.AutoSize = true;
            this.PolybiusSquareMethod.Location = new System.Drawing.Point(6, 72);
            this.PolybiusSquareMethod.Name = "PolybiusSquareMethod";
            this.PolybiusSquareMethod.Size = new System.Drawing.Size(109, 19);
            this.PolybiusSquareMethod.TabIndex = 0;
            this.PolybiusSquareMethod.TabStop = true;
            this.PolybiusSquareMethod.Text = "Polybius Square";
            this.PolybiusSquareMethod.UseVisualStyleBackColor = true;
            // 
            // BASE64Method
            // 
            this.BASE64Method.AutoSize = true;
            this.BASE64Method.Location = new System.Drawing.Point(6, 47);
            this.BASE64Method.Name = "BASE64Method";
            this.BASE64Method.Size = new System.Drawing.Size(64, 19);
            this.BASE64Method.TabIndex = 0;
            this.BASE64Method.TabStop = true;
            this.BASE64Method.Text = "BASE64";
            this.BASE64Method.UseVisualStyleBackColor = true;
            // 
            // XORMethod
            // 
            this.XORMethod.AutoSize = true;
            this.XORMethod.Location = new System.Drawing.Point(6, 22);
            this.XORMethod.Name = "XORMethod";
            this.XORMethod.Size = new System.Drawing.Size(48, 19);
            this.XORMethod.TabIndex = 0;
            this.XORMethod.TabStop = true;
            this.XORMethod.Text = "XOR";
            this.XORMethod.UseVisualStyleBackColor = true;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(321, 347);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(112, 23);
            this.EncryptButton.TabIndex = 18;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(458, 347);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(112, 23);
            this.DecryptButton.TabIndex = 18;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(320, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // ProgressTitle
            // 
            this.ProgressTitle.AutoSize = true;
            this.ProgressTitle.Location = new System.Drawing.Point(379, 397);
            this.ProgressTitle.Name = "ProgressTitle";
            this.ProgressTitle.Size = new System.Drawing.Size(126, 15);
            this.ProgressTitle.TabIndex = 20;
            this.ProgressTitle.Text = "Progress of processing";
            // 
            // FileInfoBox
            // 
            this.FileInfoBox.Controls.Add(this.createOfFile);
            this.FileInfoBox.Controls.Add(this.CreatedLabel);
            this.FileInfoBox.Controls.Add(this.nameOfFile);
            this.FileInfoBox.Controls.Add(this.NameLabel);
            this.FileInfoBox.Controls.Add(this.pathOfFile);
            this.FileInfoBox.Controls.Add(this.PathLabel);
            this.FileInfoBox.Controls.Add(this.sizeOfFile);
            this.FileInfoBox.Controls.Add(this.SizeLabel);
            this.FileInfoBox.Location = new System.Drawing.Point(619, 28);
            this.FileInfoBox.Name = "FileInfoBox";
            this.FileInfoBox.Size = new System.Drawing.Size(480, 141);
            this.FileInfoBox.TabIndex = 21;
            this.FileInfoBox.TabStop = false;
            this.FileInfoBox.Text = "File Info";
            // 
            // createOfFile
            // 
            this.createOfFile.AutoSize = true;
            this.createOfFile.Location = new System.Drawing.Point(57, 113);
            this.createOfFile.Name = "createOfFile";
            this.createOfFile.Size = new System.Drawing.Size(98, 15);
            this.createOfFile.TabIndex = 7;
            this.createOfFile.Text = "file is not opened";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(7, 113);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(48, 15);
            this.CreatedLabel.TabIndex = 6;
            this.CreatedLabel.Text = "Created";
            // 
            // nameOfFile
            // 
            this.nameOfFile.AutoSize = true;
            this.nameOfFile.Location = new System.Drawing.Point(57, 88);
            this.nameOfFile.Name = "nameOfFile";
            this.nameOfFile.Size = new System.Drawing.Size(98, 15);
            this.nameOfFile.TabIndex = 5;
            this.nameOfFile.Text = "file is not opened";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 88);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // pathOfFile
            // 
            this.pathOfFile.AutoSize = true;
            this.pathOfFile.Location = new System.Drawing.Point(57, 63);
            this.pathOfFile.Name = "pathOfFile";
            this.pathOfFile.Size = new System.Drawing.Size(98, 15);
            this.pathOfFile.TabIndex = 3;
            this.pathOfFile.Text = "file is not opened";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(6, 63);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(31, 15);
            this.PathLabel.TabIndex = 2;
            this.PathLabel.Text = "Path";
            // 
            // sizeOfFile
            // 
            this.sizeOfFile.AutoSize = true;
            this.sizeOfFile.Location = new System.Drawing.Point(57, 36);
            this.sizeOfFile.Name = "sizeOfFile";
            this.sizeOfFile.Size = new System.Drawing.Size(98, 15);
            this.sizeOfFile.TabIndex = 1;
            this.sizeOfFile.Text = "file is not opened";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(6, 36);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(27, 15);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "Size";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 551);
            this.Controls.Add(this.FileInfoBox);
            this.Controls.Add(this.ProgressTitle);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.Methods);
            this.Controls.Add(this.NoRadioButton);
            this.Controls.Add(this.YesRadioButton);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.EncDecKey);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.ActionTitle);
            this.Controls.Add(this.LogInfo);
            this.Controls.Add(this.FileExplorer);
            this.Controls.Add(this.ToolBar);
            this.Name = "Main";
            this.Text = "EncryptionApp";
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.Methods.ResumeLayout(false);
            this.Methods.PerformLayout();
            this.FileInfoBox.ResumeLayout(false);
            this.FileInfoBox.PerformLayout();
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
        private System.Windows.Forms.Label ActionTitle;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.TextBox EncDecKey;
        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.RadioButton YesRadioButton;
        private System.Windows.Forms.RadioButton NoRadioButton;
        private System.Windows.Forms.GroupBox Methods;
        private System.Windows.Forms.RadioButton ScietaleMethod;
        private System.Windows.Forms.RadioButton VigenereMethod;
        private System.Windows.Forms.RadioButton PolybiusSquareMethod;
        private System.Windows.Forms.RadioButton BASE64Method;
        private System.Windows.Forms.RadioButton XORMethod;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ProgressTitle;
        private System.Windows.Forms.GroupBox FileInfoBox;
        private System.Windows.Forms.Label createOfFile;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label nameOfFile;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label pathOfFile;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label sizeOfFile;
        private System.Windows.Forms.Label SizeLabel;
    }
}