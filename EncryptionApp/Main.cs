using EncryptionApp.Models.DB;
using EncryptionApp.Models.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EncryptionApp.UI
{
    public partial class Main : Form
    {
        private readonly DatabaseContext _db;
        private TreeNode _fileNode;

        public Main()
        {
            _db = new DatabaseContext();
            InitializeComponent();

            FileExplorer.BeforeExpand += FileExplorer_BeforeExpand;
            FileExplorer.NodeMouseClick += FileExplorer_NodeMouseClick;
            SetLogicalDrivers();

            SaveAndShowLogAction(_db);
        }

        private void FileExplorer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                ToolStripMenuItem openMenuItem = new ToolStripMenuItem("Open");

                ContextMenuStrip contextMenu = new ContextMenuStrip();
                contextMenu.Items.Add(openMenuItem);

                FileExplorer.ContextMenuStrip = contextMenu;

                openMenuItem.Click += OpenMenuItem_Click;

                _fileNode = e.Node;
            }
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            var fullPath = _fileNode.FullPath;
            
            FileInfo fileInfo = new FileInfo(fullPath);
            if (fileInfo.Exists)
            {
                sizeOfFile.Text = fileInfo.Length.ToString() + " bytes";
                nameOfFile.Text = fileInfo.Name;
                pathOfFile.Text = fileInfo.FullName;
                createOfFile.Text = fileInfo.CreationTime.ToString();
            }
            else
            {
                MessageBox.Show("Choose file that to encrypt it!");
            }
        }

        private void SetLogicalDrivers()
        {
            foreach (var drive in Directory.GetLogicalDrives())
            {
                var item = new TreeNode()
                {
                    Text = drive,
                    Tag = drive
                };

                item.Nodes.Add("");

                FileExplorer.Nodes.Add(item);
            }
        }

        private async void SaveAndShowLogAction(DatabaseContext db)
        {
            LogInfo.Items.Clear();

            LogMessage log = new LogMessage(DateTime.Now, "Application is started!");

            await db.LogMessages.AddAsync(log);
            await db.SaveChangesAsync();

            LogInfo.Items.Add(log.ToString());
        }

        private void FileExplorer_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            List<string> dirs = new List<string>();

            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath).ToList();
                    if (dirs.Count != 0)
                    {
                        foreach (var dir in dirs)
                        {
                            TreeNode dirNode = new TreeNode()
                            {
                                Text = dir.Remove(0, dir.LastIndexOf("\\") + 1),
                                Tag = dir
                            };

                            dirNode.Nodes.Add("");
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }

                var filesInDir = Directory.GetFiles(e.Node.FullPath);

                if (filesInDir.Length > 0)
                {
                    foreach (var file in filesInDir)
                    {
                        TreeNode fileNode = new TreeNode()
                        {
                            Text = file.Remove(0, file.LastIndexOf("\\") + 1),
                            Tag = file
                        };

                        e.Node.Nodes.Add(fileNode);
                    }
                }
            }
            catch (Exception) { }
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            Form logForm = new LogForm(_db);
            logForm.Show();
        }
    }
}
