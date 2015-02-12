namespace LeukocyteGUI_for_oclHashCat
{
    partial class TaskEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskEditorForm));
            this.textBoxHashFileName = new System.Windows.Forms.TextBox();
            this.radioButtonAttackTypeBrute = new System.Windows.Forms.RadioButton();
            this.radioButtonAttackTypeDictionary = new System.Windows.Forms.RadioButton();
            this.groupBoxAttackType = new System.Windows.Forms.GroupBox();
            this.labelMasks = new System.Windows.Forms.Label();
            this.labelDictionaries = new System.Windows.Forms.Label();
            this.radioButtonAttackTypeMulti = new System.Windows.Forms.RadioButton();
            this.checkedListBoxMask = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxDictionary = new System.Windows.Forms.CheckedListBox();
            this.buttonChooseDictionaryFile = new System.Windows.Forms.Button();
            this.checkBoxCharset4 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset4 = new System.Windows.Forms.TextBox();
            this.checkBoxCharset3 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset3 = new System.Windows.Forms.TextBox();
            this.checkBoxCharset2 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset2 = new System.Windows.Forms.TextBox();
            this.checkBoxCharset1 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset1 = new System.Windows.Forms.TextBox();
            this.textBoxDictionary = new System.Windows.Forms.TextBox();
            this.textBoxBruteforceMask = new System.Windows.Forms.TextBox();
            this.groupBoxHash = new System.Windows.Forms.GroupBox();
            this.buttonChooseHashFile = new System.Windows.Forms.Button();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.textBoxSeparator = new System.Windows.Forms.TextBox();
            this.comboBoxHashType = new System.Windows.Forms.ComboBox();
            this.labelHashType = new System.Windows.Forms.Label();
            this.labelHashFile = new System.Windows.Forms.Label();
            this.groupBoxIncrement = new System.Windows.Forms.GroupBox();
            this.numericUpDownIncrementMax = new System.Windows.Forms.NumericUpDown();
            this.labelIncrementMax = new System.Windows.Forms.Label();
            this.numericUpDownIncrementMin = new System.Windows.Forms.NumericUpDown();
            this.labelIncrementMin = new System.Windows.Forms.Label();
            this.checkBoxEnableIncrement = new System.Windows.Forms.CheckBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.textBoxSessionId = new System.Windows.Forms.TextBox();
            this.labelSessionId = new System.Windows.Forms.Label();
            this.checkBoxDisableLog = new System.Windows.Forms.CheckBox();
            this.checkBoxDisablePot = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoveCracked = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnoreUsernames = new System.Windows.Forms.CheckBox();
            this.checkBoxLoopback = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnoreWarnings = new System.Windows.Forms.CheckBox();
            this.checkBoxSaltIsInHex = new System.Windows.Forms.CheckBox();
            this.checkBoxCharsetIsInHex = new System.Windows.Forms.CheckBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.buttonChooseOutputFile = new System.Windows.Forms.Button();
            this.checkBoxOutputToFile = new System.Windows.Forms.CheckBox();
            this.comboBoxOutputFormat = new System.Windows.Forms.ComboBox();
            this.labelOutputFormat = new System.Windows.Forms.Label();
            this.labelOutputFile = new System.Windows.Forms.Label();
            this.textBoxOutputFile = new System.Windows.Forms.TextBox();
            this.groupBoxGPUResources = new System.Windows.Forms.GroupBox();
            this.checkBoxDisablePowertune = new System.Windows.Forms.CheckBox();
            this.numericUpDownTempRetain = new System.Windows.Forms.NumericUpDown();
            this.labelCelsiusAMD = new System.Windows.Forms.Label();
            this.checkBoxTempRetain = new System.Windows.Forms.CheckBox();
            this.numericUpDownTempAbort = new System.Windows.Forms.NumericUpDown();
            this.labelCelsius = new System.Windows.Forms.Label();
            this.checkBoxTempAbort = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableTemp = new System.Windows.Forms.CheckBox();
            this.numericUpDownWorkloadFineTuning = new System.Windows.Forms.NumericUpDown();
            this.checkBoxWorkloadFineTuning = new System.Windows.Forms.CheckBox();
            this.comboBoxWorkloadTuning = new System.Windows.Forms.ComboBox();
            this.checkBoxWorkloadTuning = new System.Windows.Forms.CheckBox();
            this.comboBoxWorkloadProfile = new System.Windows.Forms.ComboBox();
            this.checkBoxSpecificWorkloadProfile = new System.Windows.Forms.CheckBox();
            this.checkBoxGPUAsync = new System.Windows.Forms.CheckBox();
            this.buttonCancelTask = new System.Windows.Forms.Button();
            this.buttonSubmitTask = new System.Windows.Forms.Button();
            this.buttonClearTask = new System.Windows.Forms.Button();
            this.openFileDialogHash = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogDictionary = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogOutput = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxAttackType.SuspendLayout();
            this.groupBoxHash.SuspendLayout();
            this.groupBoxIncrement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrementMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrementMin)).BeginInit();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxGPUResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempRetain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempAbort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkloadFineTuning)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxHashFileName
            // 
            this.textBoxHashFileName.Location = new System.Drawing.Point(78, 19);
            this.textBoxHashFileName.Name = "textBoxHashFileName";
            this.textBoxHashFileName.Size = new System.Drawing.Size(365, 20);
            this.textBoxHashFileName.TabIndex = 0;
            // 
            // radioButtonAttackTypeBrute
            // 
            this.radioButtonAttackTypeBrute.AutoSize = true;
            this.radioButtonAttackTypeBrute.Checked = true;
            this.radioButtonAttackTypeBrute.Location = new System.Drawing.Point(16, 74);
            this.radioButtonAttackTypeBrute.Name = "radioButtonAttackTypeBrute";
            this.radioButtonAttackTypeBrute.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAttackTypeBrute.TabIndex = 3;
            this.radioButtonAttackTypeBrute.TabStop = true;
            this.radioButtonAttackTypeBrute.Text = "Mask:";
            this.radioButtonAttackTypeBrute.UseVisualStyleBackColor = true;
            // 
            // radioButtonAttackTypeDictionary
            // 
            this.radioButtonAttackTypeDictionary.AutoSize = true;
            this.radioButtonAttackTypeDictionary.Location = new System.Drawing.Point(16, 24);
            this.radioButtonAttackTypeDictionary.Name = "radioButtonAttackTypeDictionary";
            this.radioButtonAttackTypeDictionary.Size = new System.Drawing.Size(75, 17);
            this.radioButtonAttackTypeDictionary.TabIndex = 13;
            this.radioButtonAttackTypeDictionary.Text = "Dictionary:";
            this.radioButtonAttackTypeDictionary.UseVisualStyleBackColor = true;
            // 
            // groupBoxAttackType
            // 
            this.groupBoxAttackType.Controls.Add(this.labelMasks);
            this.groupBoxAttackType.Controls.Add(this.labelDictionaries);
            this.groupBoxAttackType.Controls.Add(this.radioButtonAttackTypeMulti);
            this.groupBoxAttackType.Controls.Add(this.checkedListBoxMask);
            this.groupBoxAttackType.Controls.Add(this.checkedListBoxDictionary);
            this.groupBoxAttackType.Controls.Add(this.buttonChooseDictionaryFile);
            this.groupBoxAttackType.Controls.Add(this.checkBoxCharset4);
            this.groupBoxAttackType.Controls.Add(this.textBoxCharset4);
            this.groupBoxAttackType.Controls.Add(this.checkBoxCharset3);
            this.groupBoxAttackType.Controls.Add(this.textBoxCharset3);
            this.groupBoxAttackType.Controls.Add(this.checkBoxCharset2);
            this.groupBoxAttackType.Controls.Add(this.textBoxCharset2);
            this.groupBoxAttackType.Controls.Add(this.checkBoxCharset1);
            this.groupBoxAttackType.Controls.Add(this.textBoxCharset1);
            this.groupBoxAttackType.Controls.Add(this.textBoxDictionary);
            this.groupBoxAttackType.Controls.Add(this.textBoxBruteforceMask);
            this.groupBoxAttackType.Controls.Add(this.radioButtonAttackTypeBrute);
            this.groupBoxAttackType.Controls.Add(this.radioButtonAttackTypeDictionary);
            this.groupBoxAttackType.Location = new System.Drawing.Point(13, 97);
            this.groupBoxAttackType.Name = "groupBoxAttackType";
            this.groupBoxAttackType.Size = new System.Drawing.Size(503, 266);
            this.groupBoxAttackType.TabIndex = 1;
            this.groupBoxAttackType.TabStop = false;
            this.groupBoxAttackType.Text = "Attack type";
            // 
            // labelMasks
            // 
            this.labelMasks.AutoSize = true;
            this.labelMasks.Location = new System.Drawing.Point(287, 155);
            this.labelMasks.Name = "labelMasks";
            this.labelMasks.Size = new System.Drawing.Size(41, 13);
            this.labelMasks.TabIndex = 53;
            this.labelMasks.Text = "Masks:";
            // 
            // labelDictionaries
            // 
            this.labelDictionaries.AutoSize = true;
            this.labelDictionaries.Location = new System.Drawing.Point(287, 48);
            this.labelDictionaries.Name = "labelDictionaries";
            this.labelDictionaries.Size = new System.Drawing.Size(65, 13);
            this.labelDictionaries.TabIndex = 52;
            this.labelDictionaries.Text = "Dictionaries:";
            // 
            // radioButtonAttackTypeMulti
            // 
            this.radioButtonAttackTypeMulti.AutoSize = true;
            this.radioButtonAttackTypeMulti.Location = new System.Drawing.Point(284, 24);
            this.radioButtonAttackTypeMulti.Name = "radioButtonAttackTypeMulti";
            this.radioButtonAttackTypeMulti.Size = new System.Drawing.Size(102, 17);
            this.radioButtonAttackTypeMulti.TabIndex = 51;
            this.radioButtonAttackTypeMulti.Text = "Multiple attacks:";
            this.radioButtonAttackTypeMulti.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxMask
            // 
            this.checkedListBoxMask.CheckOnClick = true;
            this.checkedListBoxMask.FormattingEnabled = true;
            this.checkedListBoxMask.Location = new System.Drawing.Point(290, 171);
            this.checkedListBoxMask.Name = "checkedListBoxMask";
            this.checkedListBoxMask.Size = new System.Drawing.Size(195, 79);
            this.checkedListBoxMask.TabIndex = 50;
            // 
            // checkedListBoxDictionary
            // 
            this.checkedListBoxDictionary.CheckOnClick = true;
            this.checkedListBoxDictionary.FormattingEnabled = true;
            this.checkedListBoxDictionary.Location = new System.Drawing.Point(290, 64);
            this.checkedListBoxDictionary.Name = "checkedListBoxDictionary";
            this.checkedListBoxDictionary.Size = new System.Drawing.Size(195, 79);
            this.checkedListBoxDictionary.TabIndex = 49;
            // 
            // buttonChooseDictionaryFile
            // 
            this.buttonChooseDictionaryFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChooseDictionaryFile.FlatAppearance.BorderSize = 0;
            this.buttonChooseDictionaryFile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseDictionaryFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseDictionaryFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseDictionaryFile.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe16;
            this.buttonChooseDictionaryFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseDictionaryFile.Location = new System.Drawing.Point(228, 45);
            this.buttonChooseDictionaryFile.Name = "buttonChooseDictionaryFile";
            this.buttonChooseDictionaryFile.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseDictionaryFile.TabIndex = 48;
            this.buttonChooseDictionaryFile.UseVisualStyleBackColor = true;
            this.buttonChooseDictionaryFile.Click += new System.EventHandler(this.buttonChooseDictionaryFile_Click);
            // 
            // checkBoxCharset4
            // 
            this.checkBoxCharset4.AutoSize = true;
            this.checkBoxCharset4.Location = new System.Drawing.Point(25, 213);
            this.checkBoxCharset4.Name = "checkBoxCharset4";
            this.checkBoxCharset4.Size = new System.Drawing.Size(74, 17);
            this.checkBoxCharset4.TabIndex = 11;
            this.checkBoxCharset4.Text = "Charset 4:";
            this.checkBoxCharset4.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset4
            // 
            this.textBoxCharset4.Location = new System.Drawing.Point(105, 211);
            this.textBoxCharset4.Name = "textBoxCharset4";
            this.textBoxCharset4.Size = new System.Drawing.Size(139, 20);
            this.textBoxCharset4.TabIndex = 12;
            // 
            // checkBoxCharset3
            // 
            this.checkBoxCharset3.AutoSize = true;
            this.checkBoxCharset3.Location = new System.Drawing.Point(25, 184);
            this.checkBoxCharset3.Name = "checkBoxCharset3";
            this.checkBoxCharset3.Size = new System.Drawing.Size(74, 17);
            this.checkBoxCharset3.TabIndex = 9;
            this.checkBoxCharset3.Text = "Charset 3:";
            this.checkBoxCharset3.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset3
            // 
            this.textBoxCharset3.Location = new System.Drawing.Point(105, 182);
            this.textBoxCharset3.Name = "textBoxCharset3";
            this.textBoxCharset3.Size = new System.Drawing.Size(139, 20);
            this.textBoxCharset3.TabIndex = 10;
            // 
            // checkBoxCharset2
            // 
            this.checkBoxCharset2.AutoSize = true;
            this.checkBoxCharset2.Location = new System.Drawing.Point(25, 155);
            this.checkBoxCharset2.Name = "checkBoxCharset2";
            this.checkBoxCharset2.Size = new System.Drawing.Size(74, 17);
            this.checkBoxCharset2.TabIndex = 7;
            this.checkBoxCharset2.Text = "Charset 2:";
            this.checkBoxCharset2.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset2
            // 
            this.textBoxCharset2.Location = new System.Drawing.Point(105, 153);
            this.textBoxCharset2.Name = "textBoxCharset2";
            this.textBoxCharset2.Size = new System.Drawing.Size(139, 20);
            this.textBoxCharset2.TabIndex = 8;
            // 
            // checkBoxCharset1
            // 
            this.checkBoxCharset1.AutoSize = true;
            this.checkBoxCharset1.Location = new System.Drawing.Point(25, 126);
            this.checkBoxCharset1.Name = "checkBoxCharset1";
            this.checkBoxCharset1.Size = new System.Drawing.Size(74, 17);
            this.checkBoxCharset1.TabIndex = 5;
            this.checkBoxCharset1.Text = "Charset 1:";
            this.checkBoxCharset1.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset1
            // 
            this.textBoxCharset1.Location = new System.Drawing.Point(105, 124);
            this.textBoxCharset1.Name = "textBoxCharset1";
            this.textBoxCharset1.Size = new System.Drawing.Size(139, 20);
            this.textBoxCharset1.TabIndex = 6;
            // 
            // textBoxDictionary
            // 
            this.textBoxDictionary.Location = new System.Drawing.Point(25, 45);
            this.textBoxDictionary.Name = "textBoxDictionary";
            this.textBoxDictionary.Size = new System.Drawing.Size(197, 20);
            this.textBoxDictionary.TabIndex = 14;
            // 
            // textBoxBruteforceMask
            // 
            this.textBoxBruteforceMask.Location = new System.Drawing.Point(25, 93);
            this.textBoxBruteforceMask.Name = "textBoxBruteforceMask";
            this.textBoxBruteforceMask.Size = new System.Drawing.Size(219, 20);
            this.textBoxBruteforceMask.TabIndex = 4;
            // 
            // groupBoxHash
            // 
            this.groupBoxHash.Controls.Add(this.buttonChooseHashFile);
            this.groupBoxHash.Controls.Add(this.labelSeparator);
            this.groupBoxHash.Controls.Add(this.textBoxSeparator);
            this.groupBoxHash.Controls.Add(this.comboBoxHashType);
            this.groupBoxHash.Controls.Add(this.labelHashType);
            this.groupBoxHash.Controls.Add(this.labelHashFile);
            this.groupBoxHash.Controls.Add(this.textBoxHashFileName);
            this.groupBoxHash.Location = new System.Drawing.Point(13, 12);
            this.groupBoxHash.Name = "groupBoxHash";
            this.groupBoxHash.Size = new System.Drawing.Size(503, 79);
            this.groupBoxHash.TabIndex = 0;
            this.groupBoxHash.TabStop = false;
            this.groupBoxHash.Text = "Hash";
            // 
            // buttonChooseHashFile
            // 
            this.buttonChooseHashFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChooseHashFile.FlatAppearance.BorderSize = 0;
            this.buttonChooseHashFile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseHashFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseHashFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseHashFile.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe16;
            this.buttonChooseHashFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseHashFile.Location = new System.Drawing.Point(451, 17);
            this.buttonChooseHashFile.Name = "buttonChooseHashFile";
            this.buttonChooseHashFile.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseHashFile.TabIndex = 47;
            this.buttonChooseHashFile.UseVisualStyleBackColor = true;
            this.buttonChooseHashFile.Click += new System.EventHandler(this.buttonChooseHashFile_Click);
            // 
            // labelSeparator
            // 
            this.labelSeparator.AutoSize = true;
            this.labelSeparator.Location = new System.Drawing.Point(387, 49);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(56, 13);
            this.labelSeparator.TabIndex = 15;
            this.labelSeparator.Text = "Separator:";
            // 
            // textBoxSeparator
            // 
            this.textBoxSeparator.Location = new System.Drawing.Point(449, 46);
            this.textBoxSeparator.Name = "textBoxSeparator";
            this.textBoxSeparator.Size = new System.Drawing.Size(36, 20);
            this.textBoxSeparator.TabIndex = 1;
            this.textBoxSeparator.Text = ":";
            this.textBoxSeparator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxHashType
            // 
            this.comboBoxHashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHashType.Items.AddRange(new object[] {
            "0 = MD5",
            "10 = md5($pass.$salt)",
            "20 = md5($salt.$pass)",
            "30 = md5(unicode($pass).$salt)",
            "40 = md5($salt.unicode($pass))",
            "50 = HMAC-MD5 (key = $pass)",
            "60 = HMAC-MD5 (key = $salt)",
            "100 = SHA1",
            "110 = sha1($pass.$salt)",
            "120 = sha1($salt.$pass)",
            "130 = sha1(unicode($pass).$salt)",
            "140 = sha1($salt.unicode($pass))",
            "150 = HMAC-SHA1 (key = $pass)",
            "160 = HMAC-SHA1 (key = $salt)",
            "190 = sha1(LinkedIn)",
            "200 = MySQL323",
            "300 = MySQL4.1/MySQL5",
            "400 = phpass, MD5(Wordpress), MD5(phpBB3), MD5(Joomla)",
            "500 = md5crypt, MD5(Unix), FreeBSD MD5, Cisco-IOS MD5",
            "900 = MD4",
            "1000 = NTLM",
            "1100 = Domain Cached Credentials, mscash",
            "1400 = SHA256",
            "1410 = sha256($pass.$salt)",
            "1420 = sha256($salt.$pass)",
            "1430 = sha256(unicode($pass).$salt)",
            "1440 = sha256($salt.unicode($pass))",
            "1450 = HMAC-SHA256 (key = $pass)",
            "1460 = HMAC-SHA256 (key = $salt)",
            "1500 = descrypt, DES(Unix), Traditional DES",
            "1600 = md5apr1, MD5(APR), Apache MD5",
            "1700 = SHA512",
            "1710 = sha512($pass.$salt)",
            "1720 = sha512($salt.$pass)",
            "1730 = sha512(unicode($pass).$salt)",
            "1740 = sha512($salt.unicode($pass))",
            "1750 = HMAC-SHA512 (key = $pass)",
            "1760 = HMAC-SHA512 (key = $salt)",
            "1800 = sha512crypt, SHA512(Unix)",
            "2100 = Domain Cached Credentials2, mscash2",
            "2400 = Cisco-PIX MD5",
            "2410 = Cisco-ASA MD5",
            "2500 = WPA/WPA2",
            "2600 = Double MD5",
            "3000 = LM",
            "3100 = Oracle 7-10g, DES(Oracle)",
            "3200 = bcrypt, Blowfish(OpenBSD)",
            "3710 = md5($salt.md5($pass))",
            "4400 = md5(sha1($pass))",
            "4500 = Double SHA1",
            "4700 = sha1(md5($pass))",
            "4800 = MD5(Chap), iSCSI CHAP authentication",
            "5000 = SHA-3(Keccak)",
            "5100 = Half MD5",
            "5200 = Password Safe v3",
            "5300 = IKE-PSK MD5",
            "5400 = IKE-PSK SHA1",
            "5500 = NetNTLMv1-VANILLA / NetNTLMv1+ESS",
            "5600 = NetNTLMv2",
            "5700 = Cisco-IOS SHA256",
            "5800 = Android PIN",
            "6000 = RipeMD160",
            "6100 = Whirlpool",
            "6300 = AIX {smd5}",
            "6400 = AIX {ssha256}",
            "6500 = AIX {ssha512}",
            "6600 = 1Password, agilekeychain",
            "6700 = AIX {ssha1}",
            "6800 = Lastpass",
            "6900 = GOST R 34.11-94",
            "7100 = OSX v10.8 / v10.9",
            "7200 = GRUB 2",
            "7300 = IPMI2 RAKP HMAC-SHA1",
            "7400 = sha256crypt, SHA256(Unix)",
            "7500 = Kerberos 5 AS-REQ Pre-Auth etype 23",
            "7700 = SAP CODVN B (BCODE)",
            "7800 = SAP CODVN F/G (PASSCODE)",
            "7900 = Drupal7",
            "8000 = Sybase ASE",
            "8100 = Citrix Netscaler",
            "8200 = 1Password, cloudkeychain",
            "8300 = DNSSEC (NSEC3)",
            "8400 = WBB3, Woltlab Burning Board 3",
            "8500 = RACF",
            "8600 = Lotus Notes/Domino 5",
            "8700 = Lotus Notes/Domino 6",
            "8800 = Android FDE",
            "8900 = scrypt",
            "9000 = Password Safe v2",
            "9100 = Lotus Notes/Domino 8",
            "11 = Joomla < 2.5.18",
            "12 = PostgreSQL",
            "21 = osCommerce, xt:Commerce",
            "22 = Juniper Netscreen/SSG (ScreenOS)",
            "23 = Skype",
            "101 = nsldap, SHA-1(Base64), Netscape LDAP SHA",
            "111 = nsldaps, SSHA-1(Base64), Netscape LDAP SSHA",
            "112 = Oracle 11g/12c",
            "121 = SMF > v1.1",
            "122 = OSX v10.4, v10.5, v10.6",
            "131 = MSSQL(2000)",
            "132 = MSSQL(2005)",
            "133 = PeopleSoft",
            "141 = EPiServer 6.x < v4",
            "1421 = hMailServer",
            "1441 = EPiServer 6.x > v4",
            "1711 = SSHA-512(Base64), LDAP {SSHA512}",
            "1722 = OSX v10.7",
            "1731 = MSSQL(2012), MSSQL(2014)",
            "2611 = vBulletin < v3.8.5",
            "2612 = PHPS",
            "2711 = vBulletin > v3.8.5",
            "2811 = IPB2+, MyBB1.2+",
            "3711 = Mediawiki B type"});
            this.comboBoxHashType.Location = new System.Drawing.Point(78, 46);
            this.comboBoxHashType.Name = "comboBoxHashType";
            this.comboBoxHashType.Size = new System.Drawing.Size(294, 21);
            this.comboBoxHashType.TabIndex = 2;
            // 
            // labelHashType
            // 
            this.labelHashType.AutoSize = true;
            this.labelHashType.Location = new System.Drawing.Point(13, 49);
            this.labelHashType.Name = "labelHashType";
            this.labelHashType.Size = new System.Drawing.Size(58, 13);
            this.labelHashType.TabIndex = 12;
            this.labelHashType.Text = "Hash type:";
            // 
            // labelHashFile
            // 
            this.labelHashFile.AutoSize = true;
            this.labelHashFile.Location = new System.Drawing.Point(13, 22);
            this.labelHashFile.Name = "labelHashFile";
            this.labelHashFile.Size = new System.Drawing.Size(59, 13);
            this.labelHashFile.TabIndex = 11;
            this.labelHashFile.Text = "Hash / file:";
            // 
            // groupBoxIncrement
            // 
            this.groupBoxIncrement.Controls.Add(this.numericUpDownIncrementMax);
            this.groupBoxIncrement.Controls.Add(this.labelIncrementMax);
            this.groupBoxIncrement.Controls.Add(this.numericUpDownIncrementMin);
            this.groupBoxIncrement.Controls.Add(this.labelIncrementMin);
            this.groupBoxIncrement.Controls.Add(this.checkBoxEnableIncrement);
            this.groupBoxIncrement.Location = new System.Drawing.Point(522, 127);
            this.groupBoxIncrement.Name = "groupBoxIncrement";
            this.groupBoxIncrement.Size = new System.Drawing.Size(274, 81);
            this.groupBoxIncrement.TabIndex = 2;
            this.groupBoxIncrement.TabStop = false;
            this.groupBoxIncrement.Text = "Password length";
            // 
            // numericUpDownIncrementMax
            // 
            this.numericUpDownIncrementMax.Location = new System.Drawing.Point(207, 49);
            this.numericUpDownIncrementMax.Name = "numericUpDownIncrementMax";
            this.numericUpDownIncrementMax.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownIncrementMax.TabIndex = 39;
            // 
            // labelIncrementMax
            // 
            this.labelIncrementMax.AutoSize = true;
            this.labelIncrementMax.Location = new System.Drawing.Point(139, 51);
            this.labelIncrementMax.Name = "labelIncrementMax";
            this.labelIncrementMax.Size = new System.Drawing.Size(62, 13);
            this.labelIncrementMax.TabIndex = 17;
            this.labelIncrementMax.Text = "Max length:";
            // 
            // numericUpDownIncrementMin
            // 
            this.numericUpDownIncrementMin.Location = new System.Drawing.Point(84, 49);
            this.numericUpDownIncrementMin.Name = "numericUpDownIncrementMin";
            this.numericUpDownIncrementMin.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownIncrementMin.TabIndex = 38;
            // 
            // labelIncrementMin
            // 
            this.labelIncrementMin.AutoSize = true;
            this.labelIncrementMin.Location = new System.Drawing.Point(14, 51);
            this.labelIncrementMin.Name = "labelIncrementMin";
            this.labelIncrementMin.Size = new System.Drawing.Size(64, 13);
            this.labelIncrementMin.TabIndex = 13;
            this.labelIncrementMin.Text = "Start length:";
            // 
            // checkBoxEnableIncrement
            // 
            this.checkBoxEnableIncrement.AutoSize = true;
            this.checkBoxEnableIncrement.Location = new System.Drawing.Point(15, 21);
            this.checkBoxEnableIncrement.Name = "checkBoxEnableIncrement";
            this.checkBoxEnableIncrement.Size = new System.Drawing.Size(139, 17);
            this.checkBoxEnableIncrement.TabIndex = 37;
            this.checkBoxEnableIncrement.Text = "Enable Increment Mode";
            this.checkBoxEnableIncrement.UseVisualStyleBackColor = true;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.textBoxSessionId);
            this.groupBoxOptions.Controls.Add(this.labelSessionId);
            this.groupBoxOptions.Controls.Add(this.checkBoxDisableLog);
            this.groupBoxOptions.Controls.Add(this.checkBoxDisablePot);
            this.groupBoxOptions.Controls.Add(this.checkBoxRemoveCracked);
            this.groupBoxOptions.Controls.Add(this.checkBoxIgnoreUsernames);
            this.groupBoxOptions.Controls.Add(this.checkBoxLoopback);
            this.groupBoxOptions.Controls.Add(this.checkBoxIgnoreWarnings);
            this.groupBoxOptions.Controls.Add(this.checkBoxSaltIsInHex);
            this.groupBoxOptions.Controls.Add(this.checkBoxCharsetIsInHex);
            this.groupBoxOptions.Location = new System.Drawing.Point(522, 214);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(274, 246);
            this.groupBoxOptions.TabIndex = 5;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // textBoxSessionId
            // 
            this.textBoxSessionId.Location = new System.Drawing.Point(73, 21);
            this.textBoxSessionId.Name = "textBoxSessionId";
            this.textBoxSessionId.Size = new System.Drawing.Size(182, 20);
            this.textBoxSessionId.TabIndex = 28;
            // 
            // labelSessionId
            // 
            this.labelSessionId.AutoSize = true;
            this.labelSessionId.Location = new System.Drawing.Point(9, 24);
            this.labelSessionId.Name = "labelSessionId";
            this.labelSessionId.Size = new System.Drawing.Size(58, 13);
            this.labelSessionId.TabIndex = 8;
            this.labelSessionId.Text = "Session id:";
            // 
            // checkBoxDisableLog
            // 
            this.checkBoxDisableLog.AutoSize = true;
            this.checkBoxDisableLog.Location = new System.Drawing.Point(16, 216);
            this.checkBoxDisableLog.Name = "checkBoxDisableLog";
            this.checkBoxDisableLog.Size = new System.Drawing.Size(109, 17);
            this.checkBoxDisableLog.TabIndex = 36;
            this.checkBoxDisableLog.Text = "Disable the logfile";
            this.checkBoxDisableLog.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisablePot
            // 
            this.checkBoxDisablePot.AutoSize = true;
            this.checkBoxDisablePot.Location = new System.Drawing.Point(16, 193);
            this.checkBoxDisablePot.Name = "checkBoxDisablePot";
            this.checkBoxDisablePot.Size = new System.Drawing.Size(114, 17);
            this.checkBoxDisablePot.TabIndex = 35;
            this.checkBoxDisablePot.Text = "Do not write potfile";
            this.checkBoxDisablePot.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemoveCracked
            // 
            this.checkBoxRemoveCracked.AutoSize = true;
            this.checkBoxRemoveCracked.Location = new System.Drawing.Point(16, 169);
            this.checkBoxRemoveCracked.Name = "checkBoxRemoveCracked";
            this.checkBoxRemoveCracked.Size = new System.Drawing.Size(179, 17);
            this.checkBoxRemoveCracked.TabIndex = 34;
            this.checkBoxRemoveCracked.Text = "Remove hash once it is cracked";
            this.checkBoxRemoveCracked.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnoreUsernames
            // 
            this.checkBoxIgnoreUsernames.AutoSize = true;
            this.checkBoxIgnoreUsernames.Location = new System.Drawing.Point(16, 146);
            this.checkBoxIgnoreUsernames.Name = "checkBoxIgnoreUsernames";
            this.checkBoxIgnoreUsernames.Size = new System.Drawing.Size(160, 17);
            this.checkBoxIgnoreUsernames.TabIndex = 33;
            this.checkBoxIgnoreUsernames.Text = "Ignore usernames in hashfile";
            this.checkBoxIgnoreUsernames.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoopback
            // 
            this.checkBoxLoopback.AutoSize = true;
            this.checkBoxLoopback.Location = new System.Drawing.Point(16, 123);
            this.checkBoxLoopback.Name = "checkBoxLoopback";
            this.checkBoxLoopback.Size = new System.Drawing.Size(185, 17);
            this.checkBoxLoopback.TabIndex = 32;
            this.checkBoxLoopback.Text = "Add new plains to induct directory";
            this.checkBoxLoopback.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnoreWarnings
            // 
            this.checkBoxIgnoreWarnings.AutoSize = true;
            this.checkBoxIgnoreWarnings.Location = new System.Drawing.Point(16, 100);
            this.checkBoxIgnoreWarnings.Name = "checkBoxIgnoreWarnings";
            this.checkBoxIgnoreWarnings.Size = new System.Drawing.Size(101, 17);
            this.checkBoxIgnoreWarnings.TabIndex = 31;
            this.checkBoxIgnoreWarnings.Text = "Ignore warnings";
            this.checkBoxIgnoreWarnings.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaltIsInHex
            // 
            this.checkBoxSaltIsInHex.AutoSize = true;
            this.checkBoxSaltIsInHex.Location = new System.Drawing.Point(16, 77);
            this.checkBoxSaltIsInHex.Name = "checkBoxSaltIsInHex";
            this.checkBoxSaltIsInHex.Size = new System.Drawing.Size(152, 17);
            this.checkBoxSaltIsInHex.TabIndex = 30;
            this.checkBoxSaltIsInHex.Text = "Assume salt is given in hex";
            this.checkBoxSaltIsInHex.UseVisualStyleBackColor = true;
            // 
            // checkBoxCharsetIsInHex
            // 
            this.checkBoxCharsetIsInHex.AutoSize = true;
            this.checkBoxCharsetIsInHex.Location = new System.Drawing.Point(16, 54);
            this.checkBoxCharsetIsInHex.Name = "checkBoxCharsetIsInHex";
            this.checkBoxCharsetIsInHex.Size = new System.Drawing.Size(171, 17);
            this.checkBoxCharsetIsInHex.TabIndex = 29;
            this.checkBoxCharsetIsInHex.Text = "Assume charset is given in hex";
            this.checkBoxCharsetIsInHex.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.buttonChooseOutputFile);
            this.groupBoxOutput.Controls.Add(this.checkBoxOutputToFile);
            this.groupBoxOutput.Controls.Add(this.comboBoxOutputFormat);
            this.groupBoxOutput.Controls.Add(this.labelOutputFormat);
            this.groupBoxOutput.Controls.Add(this.labelOutputFile);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputFile);
            this.groupBoxOutput.Location = new System.Drawing.Point(522, 12);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(274, 109);
            this.groupBoxOutput.TabIndex = 3;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "File Output";
            // 
            // buttonChooseOutputFile
            // 
            this.buttonChooseOutputFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChooseOutputFile.FlatAppearance.BorderSize = 0;
            this.buttonChooseOutputFile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseOutputFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseOutputFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseOutputFile.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe16;
            this.buttonChooseOutputFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseOutputFile.Location = new System.Drawing.Point(222, 45);
            this.buttonChooseOutputFile.Name = "buttonChooseOutputFile";
            this.buttonChooseOutputFile.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseOutputFile.TabIndex = 48;
            this.buttonChooseOutputFile.UseVisualStyleBackColor = true;
            this.buttonChooseOutputFile.Click += new System.EventHandler(this.buttonChooseOutputFile_Click);
            // 
            // checkBoxOutputToFile
            // 
            this.checkBoxOutputToFile.AutoSize = true;
            this.checkBoxOutputToFile.Location = new System.Drawing.Point(15, 21);
            this.checkBoxOutputToFile.Name = "checkBoxOutputToFile";
            this.checkBoxOutputToFile.Size = new System.Drawing.Size(86, 17);
            this.checkBoxOutputToFile.TabIndex = 42;
            this.checkBoxOutputToFile.Text = "Output to file";
            this.checkBoxOutputToFile.UseVisualStyleBackColor = true;
            // 
            // comboBoxOutputFormat
            // 
            this.comboBoxOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutputFormat.Items.AddRange(new object[] {
            "1 = hash[:salt]",
            "2 = plain",
            "3 = hash[:salt]:plain",
            "4 = hex_plain",
            "5 = hash[:salt]:hex_plain",
            "6 = plain:hex_plain",
            "7 = hash[:salt]:plain:hex_plain",
            "8 = crackpos",
            "9 = hash[:salt]:crackpos",
            "10 = plain:crackpos",
            "11 = hash[:salt]:plain:crackpos",
            "12 = hex_plain:crackpos",
            "13 = hash[:salt]:hex_plain:crackpos",
            "14 = plain:hex_plain:crackpos",
            "15 = hash[:salt]:plain:hex_plain:crackpos"});
            this.comboBoxOutputFormat.Location = new System.Drawing.Point(62, 74);
            this.comboBoxOutputFormat.Name = "comboBoxOutputFormat";
            this.comboBoxOutputFormat.Size = new System.Drawing.Size(194, 21);
            this.comboBoxOutputFormat.TabIndex = 41;
            // 
            // labelOutputFormat
            // 
            this.labelOutputFormat.AutoSize = true;
            this.labelOutputFormat.Location = new System.Drawing.Point(14, 77);
            this.labelOutputFormat.Name = "labelOutputFormat";
            this.labelOutputFormat.Size = new System.Drawing.Size(42, 13);
            this.labelOutputFormat.TabIndex = 16;
            this.labelOutputFormat.Text = "Format:";
            // 
            // labelOutputFile
            // 
            this.labelOutputFile.AutoSize = true;
            this.labelOutputFile.Location = new System.Drawing.Point(14, 50);
            this.labelOutputFile.Name = "labelOutputFile";
            this.labelOutputFile.Size = new System.Drawing.Size(26, 13);
            this.labelOutputFile.TabIndex = 15;
            this.labelOutputFile.Text = "File:";
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.Location = new System.Drawing.Point(62, 47);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.Size = new System.Drawing.Size(154, 20);
            this.textBoxOutputFile.TabIndex = 40;
            // 
            // groupBoxGPUResources
            // 
            this.groupBoxGPUResources.Controls.Add(this.checkBoxDisablePowertune);
            this.groupBoxGPUResources.Controls.Add(this.numericUpDownTempRetain);
            this.groupBoxGPUResources.Controls.Add(this.labelCelsiusAMD);
            this.groupBoxGPUResources.Controls.Add(this.checkBoxTempRetain);
            this.groupBoxGPUResources.Controls.Add(this.numericUpDownTempAbort);
            this.groupBoxGPUResources.Controls.Add(this.labelCelsius);
            this.groupBoxGPUResources.Controls.Add(this.checkBoxTempAbort);
            this.groupBoxGPUResources.Controls.Add(this.checkBoxDisableTemp);
            this.groupBoxGPUResources.Controls.Add(this.numericUpDownWorkloadFineTuning);
            this.groupBoxGPUResources.Controls.Add(this.checkBoxWorkloadFineTuning);
            this.groupBoxGPUResources.Controls.Add(this.comboBoxWorkloadTuning);
            this.groupBoxGPUResources.Controls.Add(this.checkBoxWorkloadTuning);
            this.groupBoxGPUResources.Controls.Add(this.comboBoxWorkloadProfile);
            this.groupBoxGPUResources.Controls.Add(this.checkBoxSpecificWorkloadProfile);
            this.groupBoxGPUResources.Controls.Add(this.checkBoxGPUAsync);
            this.groupBoxGPUResources.Location = new System.Drawing.Point(13, 369);
            this.groupBoxGPUResources.Name = "groupBoxGPUResources";
            this.groupBoxGPUResources.Size = new System.Drawing.Size(503, 163);
            this.groupBoxGPUResources.TabIndex = 4;
            this.groupBoxGPUResources.TabStop = false;
            this.groupBoxGPUResources.Text = "GPU / Resources";
            // 
            // checkBoxDisablePowertune
            // 
            this.checkBoxDisablePowertune.AutoSize = true;
            this.checkBoxDisablePowertune.Location = new System.Drawing.Point(16, 135);
            this.checkBoxDisablePowertune.Name = "checkBoxDisablePowertune";
            this.checkBoxDisablePowertune.Size = new System.Drawing.Size(321, 17);
            this.checkBoxDisablePowertune.TabIndex = 27;
            this.checkBoxDisablePowertune.Text = "Disable automatic power tuning option (AMD OverDrive 6 only)";
            this.checkBoxDisablePowertune.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTempRetain
            // 
            this.numericUpDownTempRetain.Location = new System.Drawing.Point(174, 65);
            this.numericUpDownTempRetain.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownTempRetain.Name = "numericUpDownTempRetain";
            this.numericUpDownTempRetain.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownTempRetain.TabIndex = 26;
            // 
            // labelCelsiusAMD
            // 
            this.labelCelsiusAMD.AutoSize = true;
            this.labelCelsiusAMD.Location = new System.Drawing.Point(237, 67);
            this.labelCelsiusAMD.Name = "labelCelsiusAMD";
            this.labelCelsiusAMD.Size = new System.Drawing.Size(73, 13);
            this.labelCelsiusAMD.TabIndex = 28;
            this.labelCelsiusAMD.Text = "°C (AMD only)";
            // 
            // checkBoxTempRetain
            // 
            this.checkBoxTempRetain.AutoSize = true;
            this.checkBoxTempRetain.Location = new System.Drawing.Point(16, 66);
            this.checkBoxTempRetain.Name = "checkBoxTempRetain";
            this.checkBoxTempRetain.Size = new System.Drawing.Size(146, 17);
            this.checkBoxTempRetain.TabIndex = 25;
            this.checkBoxTempRetain.Text = "Try to retain GPU temp at";
            this.checkBoxTempRetain.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTempAbort
            // 
            this.numericUpDownTempAbort.Location = new System.Drawing.Point(174, 42);
            this.numericUpDownTempAbort.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownTempAbort.Name = "numericUpDownTempAbort";
            this.numericUpDownTempAbort.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownTempAbort.TabIndex = 24;
            // 
            // labelCelsius
            // 
            this.labelCelsius.AutoSize = true;
            this.labelCelsius.Location = new System.Drawing.Point(237, 44);
            this.labelCelsius.Name = "labelCelsius";
            this.labelCelsius.Size = new System.Drawing.Size(18, 13);
            this.labelCelsius.TabIndex = 25;
            this.labelCelsius.Text = "°C";
            // 
            // checkBoxTempAbort
            // 
            this.checkBoxTempAbort.AutoSize = true;
            this.checkBoxTempAbort.Location = new System.Drawing.Point(16, 43);
            this.checkBoxTempAbort.Name = "checkBoxTempAbort";
            this.checkBoxTempAbort.Size = new System.Drawing.Size(152, 17);
            this.checkBoxTempAbort.TabIndex = 23;
            this.checkBoxTempAbort.Text = "Abort if GPU temp reaches";
            this.checkBoxTempAbort.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisableTemp
            // 
            this.checkBoxDisableTemp.AutoSize = true;
            this.checkBoxDisableTemp.Location = new System.Drawing.Point(16, 112);
            this.checkBoxDisableTemp.Name = "checkBoxDisableTemp";
            this.checkBoxDisableTemp.Size = new System.Drawing.Size(289, 17);
            this.checkBoxDisableTemp.TabIndex = 22;
            this.checkBoxDisableTemp.Text = "Disable temperature and fanspeed readings and triggers";
            this.checkBoxDisableTemp.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWorkloadFineTuning
            // 
            this.numericUpDownWorkloadFineTuning.Location = new System.Drawing.Point(415, 42);
            this.numericUpDownWorkloadFineTuning.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDownWorkloadFineTuning.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownWorkloadFineTuning.Name = "numericUpDownWorkloadFineTuning";
            this.numericUpDownWorkloadFineTuning.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownWorkloadFineTuning.TabIndex = 21;
            this.numericUpDownWorkloadFineTuning.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // checkBoxWorkloadFineTuning
            // 
            this.checkBoxWorkloadFineTuning.AutoSize = true;
            this.checkBoxWorkloadFineTuning.Location = new System.Drawing.Point(290, 43);
            this.checkBoxWorkloadFineTuning.Name = "checkBoxWorkloadFineTuning";
            this.checkBoxWorkloadFineTuning.Size = new System.Drawing.Size(127, 17);
            this.checkBoxWorkloadFineTuning.TabIndex = 20;
            this.checkBoxWorkloadFineTuning.Text = "Workload fine-tuning:";
            this.checkBoxWorkloadFineTuning.UseVisualStyleBackColor = true;
            // 
            // comboBoxWorkloadTuning
            // 
            this.comboBoxWorkloadTuning.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkloadTuning.Items.AddRange(new object[] {
            "1",
            "8",
            "40",
            "80",
            "160"});
            this.comboBoxWorkloadTuning.Location = new System.Drawing.Point(415, 17);
            this.comboBoxWorkloadTuning.Name = "comboBoxWorkloadTuning";
            this.comboBoxWorkloadTuning.Size = new System.Drawing.Size(73, 21);
            this.comboBoxWorkloadTuning.TabIndex = 19;
            // 
            // checkBoxWorkloadTuning
            // 
            this.checkBoxWorkloadTuning.AutoSize = true;
            this.checkBoxWorkloadTuning.Location = new System.Drawing.Point(290, 19);
            this.checkBoxWorkloadTuning.Name = "checkBoxWorkloadTuning";
            this.checkBoxWorkloadTuning.Size = new System.Drawing.Size(107, 17);
            this.checkBoxWorkloadTuning.TabIndex = 18;
            this.checkBoxWorkloadTuning.Text = "Workload tuning:";
            this.checkBoxWorkloadTuning.UseVisualStyleBackColor = true;
            // 
            // comboBoxWorkloadProfile
            // 
            this.comboBoxWorkloadProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkloadProfile.Items.AddRange(new object[] {
            "1 = Reduced performance",
            "2 = Default performance",
            "3 = Tuned performance"});
            this.comboBoxWorkloadProfile.Location = new System.Drawing.Point(174, 87);
            this.comboBoxWorkloadProfile.Name = "comboBoxWorkloadProfile";
            this.comboBoxWorkloadProfile.Size = new System.Drawing.Size(158, 21);
            this.comboBoxWorkloadProfile.TabIndex = 17;
            // 
            // checkBoxSpecificWorkloadProfile
            // 
            this.checkBoxSpecificWorkloadProfile.AutoSize = true;
            this.checkBoxSpecificWorkloadProfile.Location = new System.Drawing.Point(16, 89);
            this.checkBoxSpecificWorkloadProfile.Name = "checkBoxSpecificWorkloadProfile";
            this.checkBoxSpecificWorkloadProfile.Size = new System.Drawing.Size(144, 17);
            this.checkBoxSpecificWorkloadProfile.TabIndex = 16;
            this.checkBoxSpecificWorkloadProfile.Text = "Specific workload profile:";
            this.checkBoxSpecificWorkloadProfile.UseVisualStyleBackColor = true;
            // 
            // checkBoxGPUAsync
            // 
            this.checkBoxGPUAsync.AutoSize = true;
            this.checkBoxGPUAsync.Location = new System.Drawing.Point(16, 19);
            this.checkBoxGPUAsync.Name = "checkBoxGPUAsync";
            this.checkBoxGPUAsync.Size = new System.Drawing.Size(210, 17);
            this.checkBoxGPUAsync.TabIndex = 15;
            this.checkBoxGPUAsync.Text = "Use non-blocking async calls (NV only)";
            this.checkBoxGPUAsync.UseVisualStyleBackColor = true;
            // 
            // buttonCancelTask
            // 
            this.buttonCancelTask.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancelTask.FlatAppearance.BorderSize = 0;
            this.buttonCancelTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCancelTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_cancel;
            this.buttonCancelTask.Location = new System.Drawing.Point(756, 492);
            this.buttonCancelTask.Name = "buttonCancelTask";
            this.buttonCancelTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonCancelTask.Size = new System.Drawing.Size(40, 40);
            this.buttonCancelTask.TabIndex = 44;
            this.buttonCancelTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelTask.UseVisualStyleBackColor = true;
            this.buttonCancelTask.Click += new System.EventHandler(this.buttonCancelTask_Click);
            // 
            // buttonSubmitTask
            // 
            this.buttonSubmitTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonSubmitTask.FlatAppearance.BorderSize = 0;
            this.buttonSubmitTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSubmitTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmitTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_ok;
            this.buttonSubmitTask.Location = new System.Drawing.Point(710, 492);
            this.buttonSubmitTask.Name = "buttonSubmitTask";
            this.buttonSubmitTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonSubmitTask.Size = new System.Drawing.Size(40, 40);
            this.buttonSubmitTask.TabIndex = 42;
            this.buttonSubmitTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubmitTask.UseVisualStyleBackColor = true;
            this.buttonSubmitTask.Click += new System.EventHandler(this.buttonSubmitTask_Click);
            // 
            // buttonClearTask
            // 
            this.buttonClearTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonClearTask.FlatAppearance.BorderSize = 0;
            this.buttonClearTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClearTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_update;
            this.buttonClearTask.Location = new System.Drawing.Point(522, 492);
            this.buttonClearTask.Name = "buttonClearTask";
            this.buttonClearTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonClearTask.Size = new System.Drawing.Size(40, 40);
            this.buttonClearTask.TabIndex = 43;
            this.buttonClearTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearTask.UseVisualStyleBackColor = true;
            this.buttonClearTask.Click += new System.EventHandler(this.buttonClearTask_Click);
            // 
            // openFileDialogHash
            // 
            this.openFileDialogHash.FileName = "hashfile";
            this.openFileDialogHash.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogHash_FileOk);
            // 
            // openFileDialogDictionary
            // 
            this.openFileDialogDictionary.FileName = "dictionary";
            this.openFileDialogDictionary.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogDictionary_FileOk);
            // 
            // saveFileDialogOutput
            // 
            this.saveFileDialogOutput.Filter = "Text files (*.txt)|*.txt|Any files (*.*)|*.*";
            this.saveFileDialogOutput.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogOutput_FileOk);
            // 
            // TaskEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelTask;
            this.ClientSize = new System.Drawing.Size(806, 541);
            this.Controls.Add(this.buttonCancelTask);
            this.Controls.Add(this.buttonClearTask);
            this.Controls.Add(this.buttonSubmitTask);
            this.Controls.Add(this.groupBoxGPUResources);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxIncrement);
            this.Controls.Add(this.groupBoxHash);
            this.Controls.Add(this.groupBoxAttackType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TaskEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LeukocyteGUI for oclHashCat - Task Editor";
            this.Load += new System.EventHandler(this.TaskEditorForm_Load);
            this.groupBoxAttackType.ResumeLayout(false);
            this.groupBoxAttackType.PerformLayout();
            this.groupBoxHash.ResumeLayout(false);
            this.groupBoxHash.PerformLayout();
            this.groupBoxIncrement.ResumeLayout(false);
            this.groupBoxIncrement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrementMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrementMin)).EndInit();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.groupBoxGPUResources.ResumeLayout(false);
            this.groupBoxGPUResources.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempRetain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempAbort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkloadFineTuning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHashFileName;
        private System.Windows.Forms.RadioButton radioButtonAttackTypeBrute;
        private System.Windows.Forms.RadioButton radioButtonAttackTypeDictionary;
        private System.Windows.Forms.GroupBox groupBoxAttackType;
        private System.Windows.Forms.TextBox textBoxDictionary;
        private System.Windows.Forms.TextBox textBoxBruteforceMask;
        private System.Windows.Forms.CheckBox checkBoxCharset4;
        private System.Windows.Forms.TextBox textBoxCharset4;
        private System.Windows.Forms.CheckBox checkBoxCharset3;
        private System.Windows.Forms.TextBox textBoxCharset3;
        private System.Windows.Forms.CheckBox checkBoxCharset2;
        private System.Windows.Forms.TextBox textBoxCharset2;
        private System.Windows.Forms.CheckBox checkBoxCharset1;
        private System.Windows.Forms.TextBox textBoxCharset1;
        private System.Windows.Forms.GroupBox groupBoxHash;
        private System.Windows.Forms.ComboBox comboBoxHashType;
        private System.Windows.Forms.Label labelHashType;
        private System.Windows.Forms.Label labelHashFile;
        private System.Windows.Forms.GroupBox groupBoxIncrement;
        private System.Windows.Forms.Label labelIncrementMin;
        private System.Windows.Forms.CheckBox checkBoxEnableIncrement;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.TextBox textBoxSeparator;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.CheckBox checkBoxDisablePot;
        private System.Windows.Forms.CheckBox checkBoxRemoveCracked;
        private System.Windows.Forms.CheckBox checkBoxIgnoreUsernames;
        private System.Windows.Forms.CheckBox checkBoxLoopback;
        private System.Windows.Forms.CheckBox checkBoxIgnoreWarnings;
        private System.Windows.Forms.CheckBox checkBoxSaltIsInHex;
        private System.Windows.Forms.CheckBox checkBoxCharsetIsInHex;
        private System.Windows.Forms.CheckBox checkBoxDisableLog;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.ComboBox comboBoxOutputFormat;
        private System.Windows.Forms.Label labelOutputFormat;
        private System.Windows.Forms.Label labelOutputFile;
        private System.Windows.Forms.TextBox textBoxOutputFile;
        private System.Windows.Forms.GroupBox groupBoxGPUResources;
        private System.Windows.Forms.ComboBox comboBoxWorkloadProfile;
        private System.Windows.Forms.CheckBox checkBoxSpecificWorkloadProfile;
        private System.Windows.Forms.CheckBox checkBoxGPUAsync;
        private System.Windows.Forms.NumericUpDown numericUpDownIncrementMax;
        private System.Windows.Forms.Label labelIncrementMax;
        private System.Windows.Forms.NumericUpDown numericUpDownIncrementMin;
        private System.Windows.Forms.ComboBox comboBoxWorkloadTuning;
        private System.Windows.Forms.CheckBox checkBoxWorkloadTuning;
        private System.Windows.Forms.NumericUpDown numericUpDownTempAbort;
        private System.Windows.Forms.Label labelCelsius;
        private System.Windows.Forms.CheckBox checkBoxTempAbort;
        private System.Windows.Forms.CheckBox checkBoxDisableTemp;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkloadFineTuning;
        private System.Windows.Forms.CheckBox checkBoxWorkloadFineTuning;
        private System.Windows.Forms.CheckBox checkBoxDisablePowertune;
        private System.Windows.Forms.NumericUpDown numericUpDownTempRetain;
        private System.Windows.Forms.Label labelCelsiusAMD;
        private System.Windows.Forms.CheckBox checkBoxTempRetain;
        private System.Windows.Forms.TextBox textBoxSessionId;
        private System.Windows.Forms.Label labelSessionId;
        private System.Windows.Forms.Button buttonCancelTask;
        private System.Windows.Forms.Button buttonSubmitTask;
        private System.Windows.Forms.Button buttonClearTask;
        private System.Windows.Forms.CheckBox checkBoxOutputToFile;
        private System.Windows.Forms.Button buttonChooseHashFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogHash;
        private System.Windows.Forms.Button buttonChooseDictionaryFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogDictionary;
        private System.Windows.Forms.Button buttonChooseOutputFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutput;
        private System.Windows.Forms.Label labelMasks;
        private System.Windows.Forms.Label labelDictionaries;
        private System.Windows.Forms.RadioButton radioButtonAttackTypeMulti;
        private System.Windows.Forms.CheckedListBox checkedListBoxMask;
        private System.Windows.Forms.CheckedListBox checkedListBoxDictionary;
    }
}