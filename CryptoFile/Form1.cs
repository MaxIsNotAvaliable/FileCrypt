using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace CryptoFile
{
    public partial class Form1 : Form
    {
        string currentKey = "";
        string backupFolder = "";

        public Form1()
        {
            InitializeComponent();
            UpdateDiskList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbUseHwid.Text = "Use HWID (select disk below)";

            CenterPlacer.PlaceInCenter(panelLogin);

            panelKeyConfirm.Dock = DockStyle.Fill;
            CenterPlacer.PlaceInCenterX(labelYourKey);
            CenterPlacer.PlaceInCenterX(labelSelectedKey);

            panelBg.Dock = DockStyle.Fill;

            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AllowUserToResizeRows = false;

            panelFileList.Controls.Add(dataGridView1);

            DataGridViewTextBoxColumn tbEncryptState = new DataGridViewTextBoxColumn();
            tbEncryptState.HeaderText = "Encrypted";
            tbEncryptState.Width = 70;
            tbEncryptState.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tbEncryptState.ReadOnly = true;
            tbEncryptState.Name = "tbEncryptState";
            dataGridView1.Columns.Add(tbEncryptState);


            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Use";
            checkBoxColumn.Width = 35;
            checkBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkBoxColumn.Resizable = DataGridViewTriState.False;
            checkBoxColumn.Name = "checkBoxColumn";
            dataGridView1.Columns.Add(checkBoxColumn);


            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn.HeaderText = "Filenames";
            textColumn.Name = "textColumn";
            dataGridView1.Columns.Add(textColumn);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbUseHwid_CheckedChanged(object sender, EventArgs e)
        {
            tbLogin.Enabled = !cbUseHwid.Checked;
            btnKeyGen.Enabled = !cbUseHwid.Checked;
            btnKeyOpen.Enabled = !cbUseHwid.Checked;
            panelRbHwid.Enabled = cbUseHwid.Checked;

            btnLogin.Text = cbUseHwid.Checked ? "Use HWID" : "Use key";

            tbLogin.PasswordChar = '*';

            labelKeyLen.Text = cbUseHwid.Checked ? "16/16" : $"{tbLogin.Text.Length}/16";
            labelKeyLen.ForeColor = cbUseHwid.Checked || tbLogin.Text.Length == 16 ? Color.Gray : Color.Red;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string selectedDiskName = GetSelectedDiskName();
            if (selectedDiskName == "None" && cbUseHwid.Checked)
            {
                MessageBox.Show("Can not find disk!", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string keyTest = cbUseHwid.Checked ? Hardware.GetKey(selectedDiskName) : tbLogin.Text;

            if (!Encrypt.IsValidKey(keyTest))
            {
                MessageBox.Show("Key size must match 16 symbols", "Wrong key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btnConfirmKey.Focus();

            btnCopyKey.Enabled = !cbUseHwid.Checked;
            btnSaveKey.Enabled = !cbUseHwid.Checked;
            labelConfirmWarn.Enabled = !cbUseHwid.Checked;

            string printKey = cbUseHwid.Checked ? $"HWID of {Hardware.GetDiskFullName(selectedDiskName)}" : $"{keyTest[0]}***{keyTest[keyTest.Length - 1]}";

            labelYourKey.Text = $"Your key";
            labelSelectedKey.Text = printKey;
            panelLogin.Visible = false;
            panelKeyConfirm.Visible = true;

            currentKey = keyTest;
        }

        private void btnKeyOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogKey.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(openFileDialogKey.FileName))
                    {
                        tbLogin.Text = sr.ReadLine();
                    }
                }

            }
            catch (Exception)
            {
            }
        }

        private void btnKeyGen_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()_+-=abcdefghijklmnopqrstuvwxyz0123456789";

            int keyLen = 16;
            tbLogin.Text = new string(Enumerable.Repeat(chars, keyLen).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            labelKeyLen.Text = $"{tbLogin.Text.Length}/16";
            labelKeyLen.ForeColor = tbLogin.Text.Length == 16 ? Color.Gray : Color.Red;
        }

        private void btnBackToKey_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelKeyConfirm.Visible = false;
        }

        private void btnConfirmKey_Click(object sender, EventArgs e)
        {
            tbLogin.Text = "";
            panelLogin.Visible = false;
            panelKeyConfirm.Visible = false;
            panelBg.Visible = true;
            timerCblListUpd.Stop();
        }

        private void btnCopyKey_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbLogin.Text);
            labelTempCpy.Visible = true;
            timerLast3s.Start();
        }

        private void btnSaveKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfdKeyToFile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(sfdKeyToFile.FileName))
                    {
                        writer.WriteLine(tbLogin.Text);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void timerLast3s_Tick(object sender, EventArgs e)
        {
            labelTempCpy.Visible = false;
            timerLast3s.Stop();
        }

        private void labelHideKeyTb_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbUseHwid.Checked) return;
            tbLogin.PasswordChar = tbLogin.PasswordChar == '*' ? '\0' : '*';
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            int totalFiles = 0;
            int decrypted = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.Cells["checkBoxColumn"].Value.Equals(true)) continue;
                totalFiles++;
                string filename = row.Cells["textColumn"].Value.ToString();
                if (Encrypt.DecryptFile(currentKey, filename))
                {
                    row.Cells["tbEncryptState"].Value = Encrypt.StateToString(Encrypt.FileEncryptionState.None);
                    row.ErrorText = "";
                    decrypted++;
                }
                else
                {
                    row.ErrorText = "Unable to decrypt!";
                }
            }

            MessageBox.Show(
               $"{decrypted} / {totalFiles} files were decrypted.",
               "Encryption",
               MessageBoxButtons.OK,
               decrypted == totalFiles ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        public void CopyFile(string sourceFilePath, string destinationFilePath)
        {
            string fileName = Path.GetFileName(sourceFilePath);

            int count = 1;
            while (File.Exists(destinationFilePath))
            {
                string newFileName = $"{Path.GetFileNameWithoutExtension(fileName)} ({count}){Path.GetExtension(fileName)}";
                destinationFilePath = destinationFilePath.Replace(fileName, newFileName);
                count++;
            }

            File.Copy(sourceFilePath, destinationFilePath);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int totalFiles = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["checkBoxColumn"].Value.Equals(true)) totalFiles++;
            }

            if (cbCreateBackup.Checked && backupFolder.Length < 1)
            {
                if (MessageBox.Show(
                    $"You chose to create a backup but did not specify a path, continue encrypting anyway?",
                    "Confirm encryption",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) != DialogResult.Yes)
                    return;
            }

            DialogResult dialog = MessageBox.Show(
                $"{totalFiles} files will be encrypted.\nIf you lose your key, you can not recover files, continue?",
                "Confirm encryption",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (dialog != DialogResult.Yes) return;

            DateTime now = DateTime.Now;
            string formattedDateTime = now.Ticks.ToString();

            int encrypted = 0;
            int notChanged = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool selected = row.Cells["checkBoxColumn"].Value.Equals(true);
                if (!selected) continue;

                string filename = row.Cells["textColumn"].Value.ToString();
                if (!File.Exists(filename))
                {
                    MessageBox.Show($"File \"{filename}\" does not exists!", "File not found", MessageBoxButtons.OK);
                    continue;
                }

                row.Cells["tbEncryptState"].Value = Encrypt.StateToString(Encrypt.FileEncryptionState.Encrypted);

                if (Encrypt.GetFileEncryptionState(currentKey, filename) == Encrypt.FileEncryptionState.Encrypted)
                {
                    notChanged++;
                    continue;
                }

                if (cbCreateBackup.Checked)
                {
                    string path = $"{backupFolder}\\fc_backup_{formattedDateTime}";
                    string backupFilename = $"{path}\\{Path.GetFileName(filename)}";

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    CopyFile(filename, backupFilename);
                }

                if (Encrypt.EncryptFile(currentKey, filename))
                {
                    encrypted++;
                    row.ErrorText = "";
                }
                else
                {
                    row.ErrorText = "Unable to encrypt!";
                }
            }

            string messageBody = notChanged < 1 ?
               $"{encrypted} / {totalFiles} files were encrypted." :
               $"{encrypted} / {totalFiles} files were encrypted\n({notChanged} files have already been encrypted).";

            MessageBox.Show(
               messageBody,
               "Encryption",
               MessageBoxButtons.OK,
               encrypted == totalFiles ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }
        void AddFileToGrid(string filename)
        {
            bool contain = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (contain) break;

                string cellValue = row.Cells["textColumn"].Value.ToString();
                if (cellValue == filename)
                {
                    contain = true;
                    row.Cells["checkBoxColumn"].Value = true;

                    break;
                }
            }
            if (!contain)
            {
                //bool isEncrypted = Encrypt.IsFileEncrypted(currentKey, filename);
                //bool isEncrypted = Encrypt.IsFileEncrypted(filename);
                Encrypt.FileEncryptionState state = Encrypt.GetFileEncryptionState(currentKey, filename);
                string encrypted = Encrypt.StateToString(state);
                dataGridView1.Rows.Add(encrypted, true, filename);
            }
        }
        void AddFolderToGrid(string path)
        {
            string[] files = Directory.GetFiles(path);
            DialogResult result = DialogResult.Yes;
            if (files.Length > 50)
            {
                result = MessageBox.Show(
                    $"The path contains more than 50 files ({files.Length}), are you sure you want to add all the files?",
                    "Too many files",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);
            }
            if (result == DialogResult.Yes)
            {
                foreach (string file in files)
                {
                    AddFileToGrid(file);
                }
            }
        }
        private void btnFileAdd_Click(object sender, EventArgs e)
        {
            if (ofdAddFiles.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < ofdAddFiles.FileNames.Length; i++)
                {
                    AddFileToGrid(ofdAddFiles.FileNames[i]);
                }
            }
        }

        private void btnFolderAdd_Click(object sender, EventArgs e)
        {
            if (fbdAddFolder.ShowDialog() == DialogResult.OK)
            {
                AddFolderToGrid(fbdAddFolder.SelectedPath);
            }
        }

        private void cbCreateBackup_CheckedChanged(object sender, EventArgs e)
        {
            btnBackupFolder.Enabled = cbCreateBackup.Checked;
        }

        private void btnBackupFolder_Click(object sender, EventArgs e)
        {
            if (fbdBackup.ShowDialog() == DialogResult.OK)
            {
                backupFolder = fbdBackup.SelectedPath;
            }
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string path in files)
            {
                if (File.Exists(path))
                    AddFileToGrid(path);
                else
                    AddFolderToGrid(path);
            }
        }

        private void timerCblListUpd_Tick(object sender, EventArgs e)
        {
            UpdateDiskList();
        }

        private void UpdateDiskList()
        {
            List<string> diskList = new List<string>();

            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string rootPath = Path.GetPathRoot(path);

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (!d.IsReady) continue;

                string diskName = d.VolumeLabel.Length < 1 ? $"{d.Name}" : $"{d.Name} - {d.VolumeLabel}";
                string driveType = $"{d.DriveType}" != "Fixed" ? $" [{d.DriveType}]" : "";

                diskList.Add($"{diskName}{driveType}");
            }

            bool remove = true;
            List<string> currentRbList = new List<string>();
            while (remove)
            {
                remove = false;
                foreach (RadioButton rb in panelRbHwid.Controls.OfType<RadioButton>())
                {
                    if (!diskList.Contains(rb.Text))
                    {
                        panelRbHwid.Controls.Remove(rb);
                        remove = true;
                        break;
                    }
                    currentRbList.Add(rb.Text);
                }
            }

            foreach (string diskName in diskList)
            {
                if (currentRbList.Contains(diskName)) continue;
                RadioButton rb = new RadioButton();
                rb.Dock = DockStyle.Top;
                rb.Text = diskName;
                panelRbHwid.Controls.Add(rb);
                rb.BringToFront();
            }

            bool selected = false;
            int current = 0;
            var rbList = panelRbHwid.Controls.OfType<RadioButton>().ToArray();
            for (int i = 0; i < rbList.Length; i++)
            {
                RadioButton rb = rbList[i];
                if (rb.Checked)
                {
                    selected = true;
                }
                string name = rb.Text.Substring(0, 3);
                if (name == rootPath)
                {
                    current = i;
                }
            }
            if (!selected)
            {
                RadioButton rb = rbList[current];
                rb.Checked = true;
            }
        }

        public string GetSelectedDiskName()
        {
            var rbList = panelRbHwid.Controls.OfType<RadioButton>().ToArray();
            for (int i = 0; i < rbList.Length; i++)
            {
                RadioButton rb = rbList[i];
                if (rb.Checked) return rb.Text.Substring(0, 3);
            }
            return "None";
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            panelBg.Visible = false;
        }

        private void btnBackFromHelp_Click(object sender, EventArgs e)
        {
            panelBg.Visible = true;
        }
    }

    class CenterPlacer
    {
        public static Point GetCenterPos(Control value)
        {
            Size parentSize = value.Parent.Size;
            Size thisSize = value.Size;
            return new Point((parentSize.Width - thisSize.Width) / 2, (parentSize.Height - thisSize.Height) / 2);
        }
        public static void PlaceInCenter(Control value)
        {
            value.Location = GetCenterPos(value);
        }
        public static void PlaceInCenterX(Control value)
        {
            Point p = GetCenterPos(value);
            value.Location = new Point(p.X, value.Location.Y);
        }
        public static void PlaceInCenterY(Control value)
        {
            Point p = GetCenterPos(value);
            value.Location = new Point(value.Location.X, p.Y);
        }
    }
}
