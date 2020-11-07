using EncryptionApp.Models.DB;
using EncryptionApp.Models.Models;
using EncryptionApp.Models.Models.Ciphers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = EncryptionApp.Models.Models.Message;

namespace EncryptionApp.UI
{
    public partial class Main : Form
    {
        private readonly DatabaseContext _db;
        private TreeNode _fileNode;
        private delegate string ProcessFile<T>(string text, T password);


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

        private async void OpenMenuItem_Click(object sender, EventArgs e)
        {
            var fullPath = _fileNode.FullPath;
            
            FileInfo fileInfo = new FileInfo(fullPath);
            if (fileInfo.Exists)
            {
                sizeOfFile.Text = fileInfo.Length.ToString() + " bytes";
                nameOfFile.Text = fileInfo.Name;
                pathOfFile.Text = fileInfo.FullName;
                createOfFile.Text = fileInfo.CreationTime.ToString();

                await CreateLog($"File is opened: {fileInfo.Name}");


                await Task.Run(async () =>
                {
                    using (StreamReader sr = new StreamReader(fullPath, Encoding.UTF8))
                    {
                        string line = "";
                        int counter = 0;

                        contentOfFile.Invoke((Action)delegate
                        {
                            contentOfFile.Text = "";
                        });

                        while ((line = await sr.ReadLineAsync()) != null)
                        {
                            if (counter != 200)
                            {
                                contentOfFile.Invoke((Action)delegate
                                {
                                    contentOfFile.Text += line;
                                });

                                counter++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        sr.Close();
                    }
                });

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

            await CreateLog("Application is started!");
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

        /// <summary>
        /// Show logs for users
        /// </summary>
        private void LogButton_Click(object sender, EventArgs e)
        {
            Form logForm = new LogForm(_db);
            logForm.Show();
        }

        /// <summary>
        /// Enctypr file button
        /// </summary>
        private async void EncryptButton_Click(object sender, EventArgs e)
        {
            var key = EncDecKey.Text;
            bool resultOfEncrypting = false;

            if (XORMethod.Checked)
            {
                XORCipher xor = new XORCipher();
                ProcessFile<string> xorEnc = xor.Encrypt;

                resultOfEncrypting = await ProccessOfDecryptionOrEnctyprionWithKey(xorEnc, key, true);
            }
            if(VigenereMethod.Checked)
            {
                VigenereCipher vigenereCipher = new VigenereCipher();
                ProcessFile<string> vigenereEnc = vigenereCipher.Encrypt;

                resultOfEncrypting = await ProccessOfDecryptionOrEnctyprionWithKey(vigenereEnc, key, true);
            }
            if (Caesar.Checked)
            {
                var resultOfChecking = CheckKeyForNumber();
                if (resultOfChecking.isNumber)
                {
                    CaesarCipher caesarCipher = new CaesarCipher();
                    ProcessFile<int> caesarEnc = caesarCipher.Encrypt;

                    resultOfEncrypting = await ProccessOfDecryptionOrEnctyprionWithKey(caesarEnc, (int)resultOfChecking.key, false);
                }
            }

            if (resultOfEncrypting)
            {
                ShowProccesMessage("File is encrypted");
                ClearScreenInfo();
            }
        }

        /// <summary>
        /// Decrypt file button
        /// </summary>
        private async void DecryptButton_Click(object sender, EventArgs e)
        {
            var key = EncDecKey.Text;
            bool resultOfDecrypting = false;

            if (XORMethod.Checked)
            {
                XORCipher xor = new XORCipher();
                ProcessFile<string> xorDec = xor.Decrypt;

                resultOfDecrypting = await ProccessOfDecryptionOrEnctyprionWithKey(xorDec, key, false);
            }

            if (VigenereMethod.Checked)
            {
                VigenereCipher vigenereCipher = new VigenereCipher();
                ProcessFile<string> vigenereDec = vigenereCipher.Decrypt;

                resultOfDecrypting = await ProccessOfDecryptionOrEnctyprionWithKey(vigenereDec, key, false);
            }
            if(Caesar.Checked)
            {
                var resultOfChecking = CheckKeyForNumber();
                if (resultOfChecking.isNumber)
                {
                    CaesarCipher caesarCipher = new CaesarCipher();
                    ProcessFile<int> caesarDec = caesarCipher.Decrypt;

                    resultOfDecrypting = await ProccessOfDecryptionOrEnctyprionWithKey(caesarDec, (int)resultOfChecking.key, false);
                }
            }

            if (resultOfDecrypting)
            {
                ShowProccesMessage("File is decrypted");
                ClearScreenInfo();
            }
        }

        /// <summary>
        /// Clearing data of file
        /// </summary>
        private void ClearScreenInfo()
        {
            EncDecKey.Text = "";
            _fileNode = null;
            sizeOfFile.Text = "file is not opened";
            pathOfFile.Text = "file is not opened";
            nameOfFile.Text = "file is not opened";
            createOfFile.Text = "file is not opened";
            progressBar1.Value = 0;
        }

        /// <summary>
        /// Proccess of showing message 
        /// </summary>
        /// <param name="text">Text of message</param>
        private void ShowProccesMessage(string text)
        {
            Message message = new Message(text);
            message._showMessage += ShowMessageBox;

            message.ShowMessage();
        }

        /// <summary>
        /// Show message for user
        /// </summary>
        /// <param name="text"></param>
        private void ShowMessageBox(string text)
        {
            MessageBox.Show(text);
        }

        /// <summary>
        /// Processing of checking of inputed files and after this file is enctyps or decrypts
        /// </summary>
        /// <param name="processFile">What to do with file</param>
        /// <returns></returns>
        private async Task<bool> ProccessOfDecryptionOrEnctyprionWithKey<T>(ProcessFile<T> processFile, T key, bool addEnc)
        {
            Timer timer = new Timer();
            timer.Tick += Timer_Tick;

            if (key != null)
            {
                if (_fileNode != null)
                {
                    if (YesRadioButton.Checked)
                    {
                        timer.Start();

                        var path = _fileNode.FullPath;

                        FileInfo file = new FileInfo(path);

                        if (file.Exists)
                        {
                            string pathOfNewFile = "";

                            if (addEnc)
                            {
                                pathOfNewFile = file.FullName + ".enc";
                            }
                            else
                            {
                                pathOfNewFile = file.FullName.Trim(".enc".ToCharArray()) + ".dec";
                            }

                            FileInfo newFile = new FileInfo(pathOfNewFile);

                            if (!newFile.Exists)
                            {
                                newFile.Create().Close();
                            }

                            await ProccesFile(key, path, pathOfNewFile, processFile);

                            string logText = $"File {_fileNode.Name} is processed.New file is {newFile.Name }. Key: {key}";

                            await CreateLog(logText);

                            timer.Stop();
                            progressBar1.Maximum = timer.Interval;
                            progressBar1.Value = timer.Interval;

                            return true;
                        }

                    }
                    else if (NoRadioButton.Checked)
                    {
                        timer.Start();

                        var path = _fileNode.FullPath;

                        await ProccesFile(key, path, path, processFile);

                        string logText = $"File {_fileNode.Name} is processed. Key: {key}";
                        await CreateLog(logText);

                        timer.Stop();
                        progressBar1.Maximum = timer.Interval;
                        progressBar1.Value = timer.Interval;

                        return true;
                    }
                    else if (!YesRadioButton.Checked && !NoRadioButton.Checked)
                    {
                        MessageBox.Show("Choose create new file or no");

                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("File is not choosed!");

                    return false;
                }

                return false;
            }
            else
            {
                MessageBox.Show("Key is not inputed!");

                return false;
            }
        }

        /// <summary>
        /// Timer of proccesing
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        /// <summary>
        /// Creating log of user action
        /// </summary>
        /// <param name="text">Text of log</param>
        /// <returns></returns>
        private async Task CreateLog(string text)
        {
            LogMessage log = new LogMessage(DateTime.Now, text);

            await _db.AddAsync(log);
            await _db.SaveChangesAsync();

            LogInfo.Items.Add(log.ToString());
        }


        /// <summary>
        /// Encrypting of decription file order to different methods
        /// </summary>
        /// <param name="key">Key of encryption or decryption</param>
        /// <param name="path">Path of old file</param>
        /// <param name="pathOfNewFile">Path of new file</param>
        /// <param name="processFile">What to do with file, namely: encrypt or decrypt</param>
        /// <returns></returns>
        private static async Task ProccesFile<T>(T key, string path, string pathOfNewFile, ProcessFile<T> processFile)
        {
            string processedText = "";

            using (StreamReader sr = new StreamReader(path))
            {
                var textOfFile = await sr.ReadToEndAsync();

                processedText = processFile?.Invoke(textOfFile, key);
                sr.Close();
            }

            using (StreamWriter sw = new StreamWriter(pathOfNewFile))
            {
                await sw.WriteAsync(processedText);
                sw.Close();
            }
        }

        private void VigenereMethod_Click(object sender, EventArgs e)
        {
            SetWarningText("For the Vigenere cipher text of the file should be only on english or russian language!");
        }

        private void XORMethod_Click(object sender, EventArgs e)
        {
            SetWarningText();
        }



        private void SetWarningText(string text = "")
        {
            warningText.Text = text;
        }

        private void BASE64Method_Click(object sender, EventArgs e)
        {
            SetWarningText();
        }

        private void PolybiusSquareMethod_Click(object sender, EventArgs e)
        {
            SetWarningText();
        }

        private void ScietaleMethod_Click(object sender, EventArgs e)
        {
            SetWarningText();
        }

        private void Caesar_Click(object sender, EventArgs e)
        {
            SetWarningText("Key should be only number");
            CheckKeyForNumber();
        }

        private (bool isNumber, int? key) CheckKeyForNumber()
        {
            int result = 0;
            var key = EncDecKey.Text;
            if (!Int32.TryParse(key, out result))
            {
                EncDecKey.Text = "";
                MessageBox.Show("Key shoult be only number!");

                return (false, null);
            }

            return (true, result);
        }
    }
}
