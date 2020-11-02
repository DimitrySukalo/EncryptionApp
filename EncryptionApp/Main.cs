using EncryptionApp.Models.DB;
using EncryptionApp.Models.Models;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace EncryptionApp.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            FileExplorer.BeforeSelect += FileExplorer_BeforeSelect;
            FileExplorer.BeforeExpand += FileExplorer_BeforeExpand;

            FillDriveNodes();
            SaveAndShowLogAction();
        }

        private async void SaveAndShowLogAction()
        {
            LogInfo.Items.Clear();

            LogMessage log = new LogMessage(DateTime.Now, "Application is started!");

            using(DatabaseContext db = new DatabaseContext())
            {
                await db.LogMessages.AddAsync(log);
                await db.SaveChangesAsync();
            }

            LogInfo.Items.Add(log.ToString());
        }

        private void FileExplorer_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception) { }
        }
        private void FileExplorer_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;

            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode node = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(node, dirs[i]);
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                if (driveNode != null && !string.IsNullOrWhiteSpace(path))
                {
                    string[] dirs = Directory.GetDirectories(path);
                    foreach (var dir in dirs)
                    {
                        TreeNode dirNode = new TreeNode();
                        dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);

                        driveNode.Nodes.Add(dirNode);
                    }
                }
            }
            catch (Exception) { }
        }

        private void FillDriveNodes()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode { Text = drive.Name };
                    FillTreeNode(driveNode, drive.Name);
                    FileExplorer.Nodes.Add(driveNode);
                }
            }
            catch (Exception) { }
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            Form logForm = new LogForm();
            logForm.Show();
        }
    }
}
