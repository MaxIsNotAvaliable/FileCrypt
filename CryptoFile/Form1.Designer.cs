namespace CryptoFile
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelRbHwid = new System.Windows.Forms.Panel();
            this.labelKeyLen = new System.Windows.Forms.Label();
            this.cbUseHwid = new System.Windows.Forms.CheckBox();
            this.labelHideKeyTb = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnKeyGen = new System.Windows.Forms.Button();
            this.btnKeyOpen = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelKeyConfirm = new System.Windows.Forms.Panel();
            this.labelTempCpy = new System.Windows.Forms.Label();
            this.btnCopyKey = new System.Windows.Forms.Button();
            this.btnSaveKey = new System.Windows.Forms.Button();
            this.btnBackToKey = new System.Windows.Forms.Button();
            this.btnConfirmKey = new System.Windows.Forms.Button();
            this.labelConfirmWarn = new System.Windows.Forms.Label();
            this.labelSelectedKey = new System.Windows.Forms.Label();
            this.labelYourKey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogKey = new System.Windows.Forms.OpenFileDialog();
            this.timerLast3s = new System.Windows.Forms.Timer(this.components);
            this.sfdKeyToFile = new System.Windows.Forms.SaveFileDialog();
            this.panelBg = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.panelFileList = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackupFolder = new System.Windows.Forms.Button();
            this.cbCreateBackup = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFolderAdd = new System.Windows.Forms.Button();
            this.btnFileAdd = new System.Windows.Forms.Button();
            this.ofdAddFiles = new System.Windows.Forms.OpenFileDialog();
            this.fbdBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdAddFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.timerCblListUpd = new System.Windows.Forms.Timer(this.components);
            this.panelLogin.SuspendLayout();
            this.panelKeyConfirm.SuspendLayout();
            this.panelBg.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFileList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.Controls.Add(this.panelRbHwid);
            this.panelLogin.Controls.Add(this.labelKeyLen);
            this.panelLogin.Controls.Add(this.cbUseHwid);
            this.panelLogin.Controls.Add(this.labelHideKeyTb);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.btnKeyGen);
            this.panelLogin.Controls.Add(this.btnKeyOpen);
            this.panelLogin.Controls.Add(this.tbLogin);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Location = new System.Drawing.Point(521, 57);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(483, 221);
            this.panelLogin.TabIndex = 0;
            // 
            // panelRbHwid
            // 
            this.panelRbHwid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRbHwid.AutoScroll = true;
            this.panelRbHwid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelRbHwid.Enabled = false;
            this.panelRbHwid.Location = new System.Drawing.Point(41, 64);
            this.panelRbHwid.Name = "panelRbHwid";
            this.panelRbHwid.Size = new System.Drawing.Size(401, 75);
            this.panelRbHwid.TabIndex = 8;
            // 
            // labelKeyLen
            // 
            this.labelKeyLen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKeyLen.ForeColor = System.Drawing.Color.Gray;
            this.labelKeyLen.Location = new System.Drawing.Point(-3, 152);
            this.labelKeyLen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKeyLen.Name = "labelKeyLen";
            this.labelKeyLen.Size = new System.Drawing.Size(41, 20);
            this.labelKeyLen.TabIndex = 7;
            this.labelKeyLen.Text = "0/16";
            this.labelKeyLen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbUseHwid
            // 
            this.cbUseHwid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUseHwid.AutoSize = true;
            this.cbUseHwid.Location = new System.Drawing.Point(41, 39);
            this.cbUseHwid.Name = "cbUseHwid";
            this.cbUseHwid.Size = new System.Drawing.Size(79, 19);
            this.cbUseHwid.TabIndex = 6;
            this.cbUseHwid.Text = "Use HWID";
            this.cbUseHwid.UseVisualStyleBackColor = true;
            this.cbUseHwid.CheckedChanged += new System.EventHandler(this.cbUseHwid_CheckedChanged);
            // 
            // labelHideKeyTb
            // 
            this.labelHideKeyTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHideKeyTb.AutoSize = true;
            this.labelHideKeyTb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelHideKeyTb.Location = new System.Drawing.Point(445, 150);
            this.labelHideKeyTb.Name = "labelHideKeyTb";
            this.labelHideKeyTb.Size = new System.Drawing.Size(32, 21);
            this.labelHideKeyTb.TabIndex = 5;
            this.labelHideKeyTb.Text = "👁";
            this.labelHideKeyTb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelHideKeyTb_MouseClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(352, 183);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 27);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Use key";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnKeyGen
            // 
            this.btnKeyGen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKeyGen.Location = new System.Drawing.Point(137, 183);
            this.btnKeyGen.Name = "btnKeyGen";
            this.btnKeyGen.Size = new System.Drawing.Size(90, 27);
            this.btnKeyGen.TabIndex = 3;
            this.btnKeyGen.Text = "Generate key";
            this.btnKeyGen.UseVisualStyleBackColor = true;
            this.btnKeyGen.Click += new System.EventHandler(this.btnKeyGen_Click);
            // 
            // btnKeyOpen
            // 
            this.btnKeyOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKeyOpen.Location = new System.Drawing.Point(41, 183);
            this.btnKeyOpen.Name = "btnKeyOpen";
            this.btnKeyOpen.Size = new System.Drawing.Size(90, 27);
            this.btnKeyOpen.TabIndex = 2;
            this.btnKeyOpen.Text = "Open key";
            this.btnKeyOpen.UseVisualStyleBackColor = true;
            this.btnKeyOpen.Click += new System.EventHandler(this.btnKeyOpen_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbLogin.Location = new System.Drawing.Point(41, 145);
            this.tbLogin.MaxLength = 32;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PasswordChar = '*';
            this.tbLogin.Size = new System.Drawing.Size(401, 32);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.AutoSize = true;
            this.labelLogin.ForeColor = System.Drawing.Color.Gray;
            this.labelLogin.Location = new System.Drawing.Point(38, 16);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(118, 15);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Please enter your key";
            // 
            // panelKeyConfirm
            // 
            this.panelKeyConfirm.Controls.Add(this.labelTempCpy);
            this.panelKeyConfirm.Controls.Add(this.btnCopyKey);
            this.panelKeyConfirm.Controls.Add(this.btnSaveKey);
            this.panelKeyConfirm.Controls.Add(this.btnBackToKey);
            this.panelKeyConfirm.Controls.Add(this.btnConfirmKey);
            this.panelKeyConfirm.Controls.Add(this.labelConfirmWarn);
            this.panelKeyConfirm.Controls.Add(this.labelSelectedKey);
            this.panelKeyConfirm.Controls.Add(this.labelYourKey);
            this.panelKeyConfirm.Controls.Add(this.label1);
            this.panelKeyConfirm.Location = new System.Drawing.Point(547, 348);
            this.panelKeyConfirm.Name = "panelKeyConfirm";
            this.panelKeyConfirm.Size = new System.Drawing.Size(389, 235);
            this.panelKeyConfirm.TabIndex = 1;
            this.panelKeyConfirm.Visible = false;
            // 
            // labelTempCpy
            // 
            this.labelTempCpy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTempCpy.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelTempCpy.Location = new System.Drawing.Point(3, 176);
            this.labelTempCpy.Name = "labelTempCpy";
            this.labelTempCpy.Size = new System.Drawing.Size(383, 26);
            this.labelTempCpy.TabIndex = 9;
            this.labelTempCpy.Text = "Copied!";
            this.labelTempCpy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTempCpy.Visible = false;
            // 
            // btnCopyKey
            // 
            this.btnCopyKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopyKey.FlatAppearance.BorderSize = 3;
            this.btnCopyKey.Location = new System.Drawing.Point(104, 146);
            this.btnCopyKey.Name = "btnCopyKey";
            this.btnCopyKey.Size = new System.Drawing.Size(90, 27);
            this.btnCopyKey.TabIndex = 8;
            this.btnCopyKey.Text = "Copy";
            this.btnCopyKey.UseVisualStyleBackColor = true;
            this.btnCopyKey.Click += new System.EventHandler(this.btnCopyKey_Click);
            // 
            // btnSaveKey
            // 
            this.btnSaveKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveKey.FlatAppearance.BorderSize = 3;
            this.btnSaveKey.Location = new System.Drawing.Point(200, 146);
            this.btnSaveKey.Name = "btnSaveKey";
            this.btnSaveKey.Size = new System.Drawing.Size(90, 27);
            this.btnSaveKey.TabIndex = 7;
            this.btnSaveKey.Text = "Save to file";
            this.btnSaveKey.UseVisualStyleBackColor = true;
            this.btnSaveKey.Click += new System.EventHandler(this.btnSaveKey_Click);
            // 
            // btnBackToKey
            // 
            this.btnBackToKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToKey.FlatAppearance.BorderSize = 3;
            this.btnBackToKey.Location = new System.Drawing.Point(200, 205);
            this.btnBackToKey.Name = "btnBackToKey";
            this.btnBackToKey.Size = new System.Drawing.Size(90, 27);
            this.btnBackToKey.TabIndex = 6;
            this.btnBackToKey.Text = "Back";
            this.btnBackToKey.UseVisualStyleBackColor = true;
            this.btnBackToKey.Click += new System.EventHandler(this.btnBackToKey_Click);
            // 
            // btnConfirmKey
            // 
            this.btnConfirmKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmKey.FlatAppearance.BorderSize = 3;
            this.btnConfirmKey.Location = new System.Drawing.Point(296, 205);
            this.btnConfirmKey.Name = "btnConfirmKey";
            this.btnConfirmKey.Size = new System.Drawing.Size(90, 27);
            this.btnConfirmKey.TabIndex = 5;
            this.btnConfirmKey.Text = "Confirm";
            this.btnConfirmKey.UseVisualStyleBackColor = true;
            this.btnConfirmKey.Click += new System.EventHandler(this.btnConfirmKey_Click);
            // 
            // labelConfirmWarn
            // 
            this.labelConfirmWarn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfirmWarn.AutoSize = true;
            this.labelConfirmWarn.Location = new System.Drawing.Point(-29, 119);
            this.labelConfirmWarn.Name = "labelConfirmWarn";
            this.labelConfirmWarn.Size = new System.Drawing.Size(439, 15);
            this.labelConfirmWarn.TabIndex = 4;
            this.labelConfirmWarn.Text = "Once confirmed, the key will be encrypted and you will no longer be able to see i" +
    "t!";
            this.labelConfirmWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSelectedKey
            // 
            this.labelSelectedKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSelectedKey.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectedKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.labelSelectedKey.Location = new System.Drawing.Point(4, 78);
            this.labelSelectedKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectedKey.Name = "labelSelectedKey";
            this.labelSelectedKey.Size = new System.Drawing.Size(381, 25);
            this.labelSelectedKey.TabIndex = 3;
            this.labelSelectedKey.Text = "Confirm your key";
            this.labelSelectedKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYourKey
            // 
            this.labelYourKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelYourKey.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelYourKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.labelYourKey.Location = new System.Drawing.Point(4, 53);
            this.labelYourKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYourKey.Name = "labelYourKey";
            this.labelYourKey.Size = new System.Drawing.Size(382, 25);
            this.labelYourKey.TabIndex = 2;
            this.labelYourKey.Text = "Your key";
            this.labelYourKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Confirm your key";
            // 
            // openFileDialogKey
            // 
            this.openFileDialogKey.FileName = "openFileDialogKey";
            this.openFileDialogKey.Filter = "Text Files (*.txt)|*.txt";
            // 
            // timerLast3s
            // 
            this.timerLast3s.Interval = 3000;
            this.timerLast3s.Tick += new System.EventHandler(this.timerLast3s_Tick);
            // 
            // sfdKeyToFile
            // 
            this.sfdKeyToFile.FileName = "FileCryptKey.txt";
            this.sfdKeyToFile.Filter = "Text Files (*.txt)|*.txt";
            // 
            // panelBg
            // 
            this.panelBg.Controls.Add(this.panel2);
            this.panelBg.Controls.Add(this.panel1);
            this.panelBg.Location = new System.Drawing.Point(24, 12);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(507, 337);
            this.panelBg.TabIndex = 2;
            this.panelBg.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEncrypt);
            this.panel2.Controls.Add(this.btnDecrypt);
            this.panel2.Controls.Add(this.panelFileList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 337);
            this.panel2.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncrypt.Location = new System.Drawing.Point(168, 309);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(136, 25);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecrypt.Location = new System.Drawing.Point(26, 309);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(136, 25);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // panelFileList
            // 
            this.panelFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFileList.Controls.Add(this.dataGridView1);
            this.panelFileList.Location = new System.Drawing.Point(6, 3);
            this.panelFileList.Name = "panelFileList";
            this.panelFileList.Size = new System.Drawing.Size(298, 300);
            this.panelFileList.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnBackupFolder);
            this.panel1.Controls.Add(this.cbCreateBackup);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnFolderAdd);
            this.panel1.Controls.Add(this.btnFileAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 337);
            this.panel1.TabIndex = 0;
            // 
            // btnBackupFolder
            // 
            this.btnBackupFolder.Enabled = false;
            this.btnBackupFolder.Location = new System.Drawing.Point(3, 95);
            this.btnBackupFolder.Name = "btnBackupFolder";
            this.btnBackupFolder.Size = new System.Drawing.Size(194, 25);
            this.btnBackupFolder.TabIndex = 4;
            this.btnBackupFolder.Text = "Select backup folder";
            this.btnBackupFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackupFolder.UseVisualStyleBackColor = true;
            this.btnBackupFolder.Click += new System.EventHandler(this.btnBackupFolder_Click);
            // 
            // cbCreateBackup
            // 
            this.cbCreateBackup.AutoSize = true;
            this.cbCreateBackup.Location = new System.Drawing.Point(3, 70);
            this.cbCreateBackup.Name = "cbCreateBackup";
            this.cbCreateBackup.Size = new System.Drawing.Size(102, 19);
            this.cbCreateBackup.TabIndex = 3;
            this.cbCreateBackup.Text = "Create backup";
            this.cbCreateBackup.UseVisualStyleBackColor = true;
            this.cbCreateBackup.CheckedChanged += new System.EventHandler(this.cbCreateBackup_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.panel3.Location = new System.Drawing.Point(3, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 2);
            this.panel3.TabIndex = 2;
            // 
            // btnFolderAdd
            // 
            this.btnFolderAdd.Location = new System.Drawing.Point(3, 31);
            this.btnFolderAdd.Name = "btnFolderAdd";
            this.btnFolderAdd.Size = new System.Drawing.Size(194, 25);
            this.btnFolderAdd.TabIndex = 1;
            this.btnFolderAdd.Text = "Add folder";
            this.btnFolderAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFolderAdd.UseVisualStyleBackColor = true;
            this.btnFolderAdd.Click += new System.EventHandler(this.btnFolderAdd_Click);
            // 
            // btnFileAdd
            // 
            this.btnFileAdd.Location = new System.Drawing.Point(3, 3);
            this.btnFileAdd.Name = "btnFileAdd";
            this.btnFileAdd.Size = new System.Drawing.Size(194, 25);
            this.btnFileAdd.TabIndex = 0;
            this.btnFileAdd.Text = "Add files";
            this.btnFileAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileAdd.UseVisualStyleBackColor = true;
            this.btnFileAdd.Click += new System.EventHandler(this.btnFileAdd_Click);
            // 
            // ofdAddFiles
            // 
            this.ofdAddFiles.FileName = "ofdAddFiles";
            this.ofdAddFiles.Multiselect = true;
            // 
            // timerCblListUpd
            // 
            this.timerCblListUpd.Enabled = true;
            this.timerCblListUpd.Interval = 500;
            this.timerCblListUpd.Tick += new System.EventHandler(this.timerCblListUpd_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 361);
            this.Controls.Add(this.panelBg);
            this.Controls.Add(this.panelKeyConfirm);
            this.Controls.Add(this.panelLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(570, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileCrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelKeyConfirm.ResumeLayout(false);
            this.panelKeyConfirm.PerformLayout();
            this.panelBg.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelFileList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnKeyGen;
        private System.Windows.Forms.Button btnKeyOpen;
        private System.Windows.Forms.Label labelHideKeyTb;
        private System.Windows.Forms.CheckBox cbUseHwid;
        private System.Windows.Forms.Panel panelKeyConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelYourKey;
        private System.Windows.Forms.Label labelSelectedKey;
        private System.Windows.Forms.Label labelConfirmWarn;
        private System.Windows.Forms.Button btnConfirmKey;
        private System.Windows.Forms.Button btnBackToKey;
        private System.Windows.Forms.Button btnCopyKey;
        private System.Windows.Forms.Button btnSaveKey;
        private System.Windows.Forms.Label labelKeyLen;
        private System.Windows.Forms.OpenFileDialog openFileDialogKey;
        private System.Windows.Forms.Label labelTempCpy;
        private System.Windows.Forms.Timer timerLast3s;
        private System.Windows.Forms.SaveFileDialog sfdKeyToFile;
        private System.Windows.Forms.Panel panelBg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFileAdd;
        private System.Windows.Forms.Button btnFolderAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelFileList;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog ofdAddFiles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbCreateBackup;
        private System.Windows.Forms.Button btnBackupFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdBackup;
        private System.Windows.Forms.FolderBrowserDialog fbdAddFolder;
        private System.Windows.Forms.Timer timerCblListUpd;
        private System.Windows.Forms.Panel panelRbHwid;
    }
}

