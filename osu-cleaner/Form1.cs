/**
* osu-cleaner
* Version: 1.00
* Author: henntix
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
namespace osu_cleaner
{
    public partial class MainApp : Form
    {
        List<string> deletelist = new List<string>();
        List<string> replacelist = new List<string>();

        BackgroundWorker worker;
        private long filesSize = 0;
        private long forRemovalSize = 0;

        public MainApp()
        {
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            directoryPath.Text = getOsuPath();
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(findElements);
            worker.ProgressChanged += new ProgressChangedEventHandler(progressBar);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(findComplete);
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
        }

        private void directorySelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = false;
            folder.RootFolder = Environment.SpecialFolder.MyComputer;
            folder.Description = "Select an osu! root directory:";
            folder.SelectedPath = directoryPath.Text;
            DialogResult path = folder.ShowDialog();
            if (path == DialogResult.OK)
            {
                //check if osu!.exe is present
                if (!File.Exists(folder.SelectedPath + "\\osu!.exe"))
                {
                    MessageBox.Show("Not a valid osu! directory!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    directorySelectButton_Click(sender, e);
                    return;
                }
            }
            directoryPath.Text = folder.SelectedPath + "\\";
        }

        private bool MatchSuffix(string file, string suffix)
        {
            return Regex.IsMatch(file.ToLower(), suffix.ToLower()+"$");
        }

        private bool StringListContains(List<string> list, string file)
        {
            string match = list.FirstOrDefault(element => element.Equals(file, StringComparison.OrdinalIgnoreCase));
            if (match == null) return false;
            else return true;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (!directoryPath.Text.EndsWith("\\")) directoryPath.Text = directoryPath.Text + "\\";
            FindProgressBar.Visible = true;
            cancelButton.Visible = true;
            elementList.Items.Clear();
            filesSize = 0;
            filesSizeLabel.Text = "Found: " + Math.Round((double)(filesSize) / 1048576, 4) + " MB";
            forRemovalSize = 0;
            forRemovalSizeLabel.Text = "Selected for removal: " + Math.Round((double)(forRemovalSize) / 1048576, 4) + " MB";
            worker.RunWorkerAsync();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy)
                worker.CancelAsync();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            List<string> delete = new List<string>();
            foreach (string file in elementList.CheckedItems)//adding items to temporary collection to let me delete items from on-screen list
                delete.Add(file);
            if (moveCheckBox.Checked) Directory.CreateDirectory(directoryPath.Text + "Cleaned");

            // step1: remove files
            foreach (string file in delete)
            {
                try
                {
                    filesSize -= getFileSize(file);
                    if (DeletePermanentlyCheckbox.Checked) FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                    else if (moveCheckBox.Checked)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        string relativePath = fileInfo.Directory.FullName.Replace(directoryPath.Text + "Songs", directoryPath.Text + "Cleaned\\");
                        if (!Directory.Exists(relativePath))
                            Directory.CreateDirectory(relativePath);
                        File.Move(file, relativePath + "\\" + fileInfo.Name);
                    }
                    else FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
                catch (FileNotFoundException) { }
                catch (NotSupportedException) { }

                elementList.Items.Remove(file);
                filesSizeLabel.Text = "Found: " + Math.Round((double)(filesSize) / 1048576, 4) + " MB";
            }

            // step2: replace files
            if (backgroundReplaceCheckBox.Checked)
            {
                filesSizeLabel.Text = "Replacing...";
                string png = AppDomain.CurrentDomain.BaseDirectory + "replace\\bg.png";
                string bmp = AppDomain.CurrentDomain.BaseDirectory + "replace\\bg.bmp";
                string jpg = AppDomain.CurrentDomain.BaseDirectory + "replace\\bg.jpg";
                List<string> replace = new List<string>();
                foreach (string file in replacelist)
                {
                    if (delete.Contains(file))
                    {
                        replace.Add(file);
                    }
                }
                foreach (string file in replace)
                {
                    if (MatchSuffix(file, "png"))
                    {
                        File.Copy(png, file);
                    }
                    else if (MatchSuffix(file, "bmp"))
                    {
                        File.Copy(bmp, file);
                    }
                    else if (MatchSuffix(file, "jpg") || MatchSuffix(file, "jpeg"))
                    {
                        File.Copy(jpg, file);
                    }
                }
            }

            // step3: remove empty folder
            if (removeEmptyFolderCheckBox.Checked)
            {
                filesSizeLabel.Text = "Removing empty folders...";
                DirectoryInfo dir = new DirectoryInfo(directoryPath.Text + "Songs");
                DirectoryInfo[] subdirs = dir.GetDirectories("*.*", System.IO.SearchOption.AllDirectories);
                foreach (DirectoryInfo subdir in subdirs)
                {
                    FileSystemInfo[] subFiles = subdir.GetFileSystemInfos();
                    if (subFiles.Count() == 0)
                    {
                        subdir.Delete();
                    }
                }
            }

            filesSizeLabel.Text = "Work complete.";
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < elementList.Items.Count; i++)
                elementList.SetItemChecked(i, true);
            forRemovalSize = 0;
            foreach (string file in elementList.CheckedItems)
            {
                FileInfo sizeInfo = new FileInfo(file);
                forRemovalSize += sizeInfo.Length;
            }
            forRemovalSizeLabel.Text = "Selected for removal: " + Math.Round((double)(forRemovalSize) / 1048576, 4) + " MB";
        }

        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < elementList.Items.Count; i++)
                elementList.SetItemChecked(i, false);
            forRemovalSize = 0;
            forRemovalSizeLabel.Text = "Selected for removal: " + Math.Round((double)(forRemovalSize) / 1048576, 4) + " MB";
        }

        private void elementList_SelectedIndexChanged(object sender, EventArgs e)
        {
            forRemovalSize = 0;
            foreach (string file in elementList.CheckedItems)
            {
                FileInfo sizeInfo = new FileInfo(file);
                forRemovalSize += sizeInfo.Length;
            }
            forRemovalSizeLabel.Text = "Selected for removal: " + Math.Round((double)(forRemovalSize) / 1048576, 4) + " MB";
        }

        private void DeletePermanentlyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(DeletePermanentlyCheckbox.Checked) moveCheckBox.Checked = false;
        }

        private void moveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(moveCheckBox.Checked) DeletePermanentlyCheckbox.Checked = false;
            if (moveCheckBox.Checked) deleteButton.Text = "Move";
            else deleteButton.Text = "Delete";
        }

        private void addToDeletelist(string file)
        {
            long size = getFileSize(file);
            if (size != 0)
            {
                deletelist.Add(file);
                filesSize += size;
            }
        }

        private void findElements(object sender, DoWorkEventArgs e)
        {
            string[] songsfolders = Directory.GetDirectories(directoryPath.Text + "Songs");
            int folderCount = songsfolders.Length;
            Console.WriteLine(folderCount);
            int current = 0;
            bool isKeepBG = backgroundKeepCheckbox.Checked;
            bool isReplaceBG = backgroundReplaceCheckBox.Checked;
            bool isKeepWav = wavFileKeepCheckbox.Checked;
            foreach (string d in songsfolders)
            {
                // skip the tooooo looonngggg file path
                if (d.Length > 100) continue;
                // get audio and BG
                List<string> bgs = new List<string>();
                List<string> audios = new List<string>();
                foreach (string file in Directory.GetFiles(d))
                {
                    if (MatchSuffix(file, "osu"))
                    {
                        bgs.Add(d + getBGPath(file));
                        audios.Add(d + getAudioPath(file));
                    }
                }
                // add files to list
                foreach (string file in Directory.GetFiles(d, "*", System.IO.SearchOption.AllDirectories))
                {
                    if (MatchSuffix(file, "osu"))
                    {
                        continue;
                    }
                    if (StringListContains(audios,file))
                    {
                        continue;
                    }
                    if (isKeepWav && MatchSuffix(file, "wav"))
                    {
                        continue;
                    }
                    if (StringListContains(bgs,file))
                    {
                        if (isReplaceBG)
                        {
                            addToDeletelist(file);
                            replacelist.Add(file);
                            continue;
                        }
                        else if (isKeepBG)
                        {
                            continue;
                        }
                    }
                    addToDeletelist(file);
                }

                if (worker.CancellationPending) return;
                current++;
                worker.ReportProgress((int)((double)current / folderCount * 100));
            }
            worker.ReportProgress(100);
        }

        private void progressBar(object sender, ProgressChangedEventArgs e)
        {
            FindProgressBar.Value = e.ProgressPercentage;
            filesSizeLabel.Text = "Found: " + Math.Round((double)(filesSize) / 1048576, 4) + " MB";
        }

        private void findComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (string file in deletelist)
                elementList.Items.Add(file);
            filesSizeLabel.Text = "Found: " + Math.Round((double)(filesSize) / 1048576, 4) + " MB";
            deletelist.Clear();
            FindProgressBar.Visible = false;
            cancelButton.Visible = false;
            FindProgressBar.Value = 0;
        }

        private string getOsuPath()
        {
            using (RegistryKey osureg = Registry.ClassesRoot.OpenSubKey("osu\\DefaultIcon"))
            {
                if (osureg != null)
                {
                    string osukey = osureg.GetValue(null).ToString();
                    string osupath = osukey.Remove(0, 1);
                    osupath = osupath.Remove(osupath.Length - 11);
                    return osupath;
                }
                else return "";
            }
        }

        private string getBGPath(string path)
        {
            using (StreamReader file = File.OpenText(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (Regex.IsMatch(line, "^//Background and Video events"))
                    {
                        line = file.ReadLine();
                        string[] items = line.Split(',');
                        if (items[0] == "0")
                        {
                            string tmp = "\\" + items[2].Replace("\"", string.Empty);
                            return tmp;
                        }
                    }
                }
                return null;
            }
        }

        private string getAudioPath(string path)
        {
            using (StreamReader file = File.OpenText(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (Regex.IsMatch(line, "^AudioFilename:"))
                    {
                        string[] items = line.Split(':');
                        string tmp = "\\" + items[1].Trim();
                        return tmp;
                    }
                }
                return null;
            }
        }

        private long getFileSize(string path)
        {
            try
            {
                FileInfo sizeInfo = new FileInfo(path);
                return sizeInfo.Length;
            }
            catch (FileNotFoundException)
            {
                return 0;
            }
            catch (NotSupportedException)
            {
                return 0;
            }
        }
    }
}
