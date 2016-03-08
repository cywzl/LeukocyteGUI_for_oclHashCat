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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.lblHashType = new System.Windows.Forms.Label();
            this.cbHashType = new System.Windows.Forms.ComboBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.cbTarget = new System.Windows.Forms.ComboBox();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.cbTemplate = new System.Windows.Forms.ComboBox();
            this.tpMisc = new System.Windows.Forms.TabPage();
            this.nudWeakHashThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblWeakHashThreshold = new System.Windows.Forms.Label();
            this.cbWeakHashThreshold = new System.Windows.Forms.CheckBox();
            this.cbLoopback = new System.Windows.Forms.CheckBox();
            this.cbForce = new System.Windows.Forms.CheckBox();
            this.cbHexWordlist = new System.Windows.Forms.CheckBox();
            this.cbHexSalt = new System.Windows.Forms.CheckBox();
            this.cbHexCharset = new System.Windows.Forms.CheckBox();
            this.tpMarkov = new System.Windows.Forms.TabPage();
            this.nudMarkovThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblMarkovThreshold = new System.Windows.Forms.Label();
            this.cbMarkovThreshold = new System.Windows.Forms.CheckBox();
            this.cbMarkovClassic = new System.Windows.Forms.CheckBox();
            this.cbMarkovDisable = new System.Windows.Forms.CheckBox();
            this.tbMarkovHcstat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMarkovHcstat = new System.Windows.Forms.CheckBox();
            this.tpSession = new System.Windows.Forms.TabPage();
            this.tpFiles = new System.Windows.Forms.TabPage();
            this.tpResources = new System.Windows.Forms.TabPage();
            this.tpDistributed = new System.Windows.Forms.TabPage();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.tpCharsetsIncrement = new System.Windows.Forms.TabPage();
            this.nudRuntime = new System.Windows.Forms.NumericUpDown();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.cbRuntime = new System.Windows.Forms.CheckBox();
            this.tbSession = new System.Windows.Forms.TextBox();
            this.lblSession = new System.Windows.Forms.Label();
            this.cbSession = new System.Windows.Forms.CheckBox();
            this.cbRestoreDisable = new System.Windows.Forms.CheckBox();
            this.nudOutfileFormat = new System.Windows.Forms.NumericUpDown();
            this.lblOutfileFormat = new System.Windows.Forms.Label();
            this.cbOutfileFormat = new System.Windows.Forms.CheckBox();
            this.tbOutfile = new System.Windows.Forms.TextBox();
            this.lblOutfile = new System.Windows.Forms.Label();
            this.cbOutfile = new System.Windows.Forms.CheckBox();
            this.cbOutfileAutohexDisable = new System.Windows.Forms.CheckBox();
            this.nudOutfileCheckTimer = new System.Windows.Forms.NumericUpDown();
            this.lblOutfileCheckTimer = new System.Windows.Forms.Label();
            this.cbOutfileCheckTimer = new System.Windows.Forms.CheckBox();
            this.cbSeparator = new System.Windows.Forms.CheckBox();
            this.tbSeparator = new System.Windows.Forms.TextBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.cbShowCracked = new System.Windows.Forms.CheckBox();
            this.cbShowUncracked = new System.Windows.Forms.CheckBox();
            this.cbIgnoreUsernames = new System.Windows.Forms.CheckBox();
            this.cbRemoveCracked = new System.Windows.Forms.CheckBox();
            this.nudRemoveTimer = new System.Windows.Forms.NumericUpDown();
            this.lblRemoveTimer = new System.Windows.Forms.Label();
            this.cbRemoveTimer = new System.Windows.Forms.CheckBox();
            this.cbPotfileDisable = new System.Windows.Forms.CheckBox();
            this.nudDebugMode = new System.Windows.Forms.NumericUpDown();
            this.lblDebugMode = new System.Windows.Forms.Label();
            this.cbDebugMode = new System.Windows.Forms.CheckBox();
            this.tbDebugFile = new System.Windows.Forms.TextBox();
            this.lblDebugFile = new System.Windows.Forms.Label();
            this.cbDebugFile = new System.Windows.Forms.CheckBox();
            this.tbInductionDir = new System.Windows.Forms.TextBox();
            this.lblInductionDir = new System.Windows.Forms.Label();
            this.cbInductionDir = new System.Windows.Forms.CheckBox();
            this.tbOutfileCheckDir = new System.Windows.Forms.TextBox();
            this.lblOutfileCheckDir = new System.Windows.Forms.Label();
            this.cbOutfileCheckDir = new System.Windows.Forms.CheckBox();
            this.cbLogfileDisable = new System.Windows.Forms.CheckBox();
            this.tbTruecryptKeyfiles = new System.Windows.Forms.TextBox();
            this.lblTruecryptKeyfiles = new System.Windows.Forms.Label();
            this.cbTruecryptKeyfiles = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tpMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeakHashThreshold)).BeginInit();
            this.tpMarkov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkovThreshold)).BeginInit();
            this.tpSession.SuspendLayout();
            this.tpFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRuntime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutfileFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutfileCheckTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDebugMode)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMain);
            this.tabControl1.Controls.Add(this.tpMisc);
            this.tabControl1.Controls.Add(this.tpMarkov);
            this.tabControl1.Controls.Add(this.tpSession);
            this.tabControl1.Controls.Add(this.tpFiles);
            this.tabControl1.Controls.Add(this.tpResources);
            this.tabControl1.Controls.Add(this.tpDistributed);
            this.tabControl1.Controls.Add(this.tpRules);
            this.tabControl1.Controls.Add(this.tpCharsetsIncrement);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 337);
            this.tabControl1.TabIndex = 0;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.lblHashType);
            this.tpMain.Controls.Add(this.cbHashType);
            this.tpMain.Controls.Add(this.lblTarget);
            this.tpMain.Controls.Add(this.cbTarget);
            this.tpMain.Controls.Add(this.lblTemplate);
            this.tpMain.Controls.Add(this.cbTemplate);
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(545, 311);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Main";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // lblHashType
            // 
            this.lblHashType.AutoSize = true;
            this.lblHashType.Location = new System.Drawing.Point(6, 70);
            this.lblHashType.Name = "lblHashType";
            this.lblHashType.Size = new System.Drawing.Size(58, 13);
            this.lblHashType.TabIndex = 5;
            this.lblHashType.Text = "Hash type:";
            // 
            // cbHashType
            // 
            this.cbHashType.FormattingEnabled = true;
            this.cbHashType.Location = new System.Drawing.Point(76, 67);
            this.cbHashType.Name = "cbHashType";
            this.cbHashType.Size = new System.Drawing.Size(201, 21);
            this.cbHashType.TabIndex = 4;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(6, 43);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(41, 13);
            this.lblTarget.TabIndex = 3;
            this.lblTarget.Text = "Target:";
            // 
            // cbTarget
            // 
            this.cbTarget.FormattingEnabled = true;
            this.cbTarget.Location = new System.Drawing.Point(76, 40);
            this.cbTarget.Name = "cbTarget";
            this.cbTarget.Size = new System.Drawing.Size(201, 21);
            this.cbTarget.TabIndex = 2;
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(6, 16);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(54, 13);
            this.lblTemplate.TabIndex = 1;
            this.lblTemplate.Text = "Template:";
            // 
            // cbTemplate
            // 
            this.cbTemplate.FormattingEnabled = true;
            this.cbTemplate.Location = new System.Drawing.Point(76, 13);
            this.cbTemplate.Name = "cbTemplate";
            this.cbTemplate.Size = new System.Drawing.Size(201, 21);
            this.cbTemplate.TabIndex = 0;
            // 
            // tpMisc
            // 
            this.tpMisc.Controls.Add(this.nudWeakHashThreshold);
            this.tpMisc.Controls.Add(this.lblWeakHashThreshold);
            this.tpMisc.Controls.Add(this.cbWeakHashThreshold);
            this.tpMisc.Controls.Add(this.cbLoopback);
            this.tpMisc.Controls.Add(this.cbForce);
            this.tpMisc.Controls.Add(this.cbHexWordlist);
            this.tpMisc.Controls.Add(this.cbHexSalt);
            this.tpMisc.Controls.Add(this.cbHexCharset);
            this.tpMisc.Location = new System.Drawing.Point(4, 22);
            this.tpMisc.Name = "tpMisc";
            this.tpMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tpMisc.Size = new System.Drawing.Size(545, 311);
            this.tpMisc.TabIndex = 1;
            this.tpMisc.Text = "Misc";
            this.tpMisc.UseVisualStyleBackColor = true;
            // 
            // nudWeakHashThreshold
            // 
            this.nudWeakHashThreshold.Location = new System.Drawing.Point(91, 156);
            this.nudWeakHashThreshold.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudWeakHashThreshold.Name = "nudWeakHashThreshold";
            this.nudWeakHashThreshold.Size = new System.Drawing.Size(90, 20);
            this.nudWeakHashThreshold.TabIndex = 8;
            this.nudWeakHashThreshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblWeakHashThreshold
            // 
            this.lblWeakHashThreshold.AutoSize = true;
            this.lblWeakHashThreshold.Location = new System.Drawing.Point(44, 158);
            this.lblWeakHashThreshold.Name = "lblWeakHashThreshold";
            this.lblWeakHashThreshold.Size = new System.Drawing.Size(41, 13);
            this.lblWeakHashThreshold.TabIndex = 7;
            this.lblWeakHashThreshold.Text = "NUM =";
            // 
            // cbWeakHashThreshold
            // 
            this.cbWeakHashThreshold.AutoSize = true;
            this.cbWeakHashThreshold.Location = new System.Drawing.Point(18, 133);
            this.cbWeakHashThreshold.Name = "cbWeakHashThreshold";
            this.cbWeakHashThreshold.Size = new System.Drawing.Size(418, 17);
            this.cbWeakHashThreshold.TabIndex = 5;
            this.cbWeakHashThreshold.Text = "Threshold when to stop checking for weak hashes ( --weak-hash-threshold=NUM ):";
            this.cbWeakHashThreshold.UseVisualStyleBackColor = true;
            // 
            // cbLoopback
            // 
            this.cbLoopback.AutoSize = true;
            this.cbLoopback.Location = new System.Drawing.Point(18, 110);
            this.cbLoopback.Name = "cbLoopback";
            this.cbLoopback.Size = new System.Drawing.Size(250, 17);
            this.cbLoopback.TabIndex = 4;
            this.cbLoopback.Text = "Add new plains to induct directory ( --loopback )";
            this.cbLoopback.UseVisualStyleBackColor = true;
            // 
            // cbForce
            // 
            this.cbForce.AutoSize = true;
            this.cbForce.Location = new System.Drawing.Point(18, 87);
            this.cbForce.Name = "cbForce";
            this.cbForce.Size = new System.Drawing.Size(146, 17);
            this.cbForce.TabIndex = 3;
            this.cbForce.Text = "Ignore warnings ( --force )";
            this.cbForce.UseVisualStyleBackColor = true;
            // 
            // cbHexWordlist
            // 
            this.cbHexWordlist.AutoSize = true;
            this.cbHexWordlist.Location = new System.Drawing.Point(18, 64);
            this.cbHexWordlist.Name = "cbHexWordlist";
            this.cbHexWordlist.Size = new System.Drawing.Size(289, 17);
            this.cbHexWordlist.TabIndex = 2;
            this.cbHexWordlist.Text = "Assume words in wordlist is given in hex ( --hex-wordlist )";
            this.cbHexWordlist.UseVisualStyleBackColor = true;
            // 
            // cbHexSalt
            // 
            this.cbHexSalt.AutoSize = true;
            this.cbHexSalt.Location = new System.Drawing.Point(18, 41);
            this.cbHexSalt.Name = "cbHexSalt";
            this.cbHexSalt.Size = new System.Drawing.Size(209, 17);
            this.cbHexSalt.TabIndex = 1;
            this.cbHexSalt.Text = "Assume salt is given in hex ( --hex-salt )";
            this.cbHexSalt.UseVisualStyleBackColor = true;
            // 
            // cbHexCharset
            // 
            this.cbHexCharset.AutoSize = true;
            this.cbHexCharset.Location = new System.Drawing.Point(18, 18);
            this.cbHexCharset.Name = "cbHexCharset";
            this.cbHexCharset.Size = new System.Drawing.Size(247, 17);
            this.cbHexCharset.TabIndex = 0;
            this.cbHexCharset.Text = "Assume charset is given in hex ( --hex-charset )";
            this.cbHexCharset.UseVisualStyleBackColor = true;
            // 
            // tpMarkov
            // 
            this.tpMarkov.Controls.Add(this.nudMarkovThreshold);
            this.tpMarkov.Controls.Add(this.lblMarkovThreshold);
            this.tpMarkov.Controls.Add(this.cbMarkovThreshold);
            this.tpMarkov.Controls.Add(this.cbMarkovClassic);
            this.tpMarkov.Controls.Add(this.cbMarkovDisable);
            this.tpMarkov.Controls.Add(this.tbMarkovHcstat);
            this.tpMarkov.Controls.Add(this.label2);
            this.tpMarkov.Controls.Add(this.cbMarkovHcstat);
            this.tpMarkov.Location = new System.Drawing.Point(4, 22);
            this.tpMarkov.Name = "tpMarkov";
            this.tpMarkov.Size = new System.Drawing.Size(545, 311);
            this.tpMarkov.TabIndex = 2;
            this.tpMarkov.Text = "Markov";
            this.tpMarkov.UseVisualStyleBackColor = true;
            // 
            // nudMarkovThreshold
            // 
            this.nudMarkovThreshold.Location = new System.Drawing.Point(89, 136);
            this.nudMarkovThreshold.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMarkovThreshold.Name = "nudMarkovThreshold";
            this.nudMarkovThreshold.Size = new System.Drawing.Size(90, 20);
            this.nudMarkovThreshold.TabIndex = 11;
            // 
            // lblMarkovThreshold
            // 
            this.lblMarkovThreshold.AutoSize = true;
            this.lblMarkovThreshold.Location = new System.Drawing.Point(45, 138);
            this.lblMarkovThreshold.Name = "lblMarkovThreshold";
            this.lblMarkovThreshold.Size = new System.Drawing.Size(41, 13);
            this.lblMarkovThreshold.TabIndex = 10;
            this.lblMarkovThreshold.Text = "NUM =";
            // 
            // cbMarkovThreshold
            // 
            this.cbMarkovThreshold.AutoSize = true;
            this.cbMarkovThreshold.Location = new System.Drawing.Point(18, 113);
            this.cbMarkovThreshold.Name = "cbMarkovThreshold";
            this.cbMarkovThreshold.Size = new System.Drawing.Size(430, 17);
            this.cbMarkovThreshold.TabIndex = 9;
            this.cbMarkovThreshold.Text = "Threshold when to stop accepting new markov-chains ( -t, --markov-threshold=NUM )" +
    ":";
            this.cbMarkovThreshold.UseVisualStyleBackColor = true;
            // 
            // cbMarkovClassic
            // 
            this.cbMarkovClassic.AutoSize = true;
            this.cbMarkovClassic.Location = new System.Drawing.Point(18, 90);
            this.cbMarkovClassic.Name = "cbMarkovClassic";
            this.cbMarkovClassic.Size = new System.Drawing.Size(400, 17);
            this.cbMarkovClassic.TabIndex = 4;
            this.cbMarkovClassic.Text = "Enable classic markov-chains, no per-position enhancement ( --markov-classic )";
            this.cbMarkovClassic.UseVisualStyleBackColor = true;
            // 
            // cbMarkovDisable
            // 
            this.cbMarkovDisable.AutoSize = true;
            this.cbMarkovDisable.Location = new System.Drawing.Point(18, 67);
            this.cbMarkovDisable.Name = "cbMarkovDisable";
            this.cbMarkovDisable.Size = new System.Drawing.Size(362, 17);
            this.cbMarkovDisable.TabIndex = 3;
            this.cbMarkovDisable.Text = "Disable markov-chains, emulates classic brute-force ( --markov-disable )";
            this.cbMarkovDisable.UseVisualStyleBackColor = true;
            // 
            // tbMarkovHcstat
            // 
            this.tbMarkovHcstat.Location = new System.Drawing.Point(89, 41);
            this.tbMarkovHcstat.Name = "tbMarkovHcstat";
            this.tbMarkovHcstat.Size = new System.Drawing.Size(255, 20);
            this.tbMarkovHcstat.TabIndex = 2;
            this.tbMarkovHcstat.Text = "hashcat.hcstat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FILE =";
            // 
            // cbMarkovHcstat
            // 
            this.cbMarkovHcstat.AutoSize = true;
            this.cbMarkovHcstat.Location = new System.Drawing.Point(18, 18);
            this.cbMarkovHcstat.Name = "cbMarkovHcstat";
            this.cbMarkovHcstat.Size = new System.Drawing.Size(260, 17);
            this.cbMarkovHcstat.TabIndex = 0;
            this.cbMarkovHcstat.Text = "Specify hcstat file to use ( --markov-hcstat=FILE ):";
            this.cbMarkovHcstat.UseVisualStyleBackColor = true;
            // 
            // tpSession
            // 
            this.tpSession.Controls.Add(this.cbRestoreDisable);
            this.tpSession.Controls.Add(this.tbSession);
            this.tpSession.Controls.Add(this.lblSession);
            this.tpSession.Controls.Add(this.cbSession);
            this.tpSession.Controls.Add(this.nudRuntime);
            this.tpSession.Controls.Add(this.lblRuntime);
            this.tpSession.Controls.Add(this.cbRuntime);
            this.tpSession.Location = new System.Drawing.Point(4, 22);
            this.tpSession.Name = "tpSession";
            this.tpSession.Size = new System.Drawing.Size(545, 311);
            this.tpSession.TabIndex = 3;
            this.tpSession.Text = "Session";
            this.tpSession.UseVisualStyleBackColor = true;
            // 
            // tpFiles
            // 
            this.tpFiles.AutoScroll = true;
            this.tpFiles.AutoScrollMargin = new System.Drawing.Size(0, 18);
            this.tpFiles.Controls.Add(this.tbTruecryptKeyfiles);
            this.tpFiles.Controls.Add(this.lblTruecryptKeyfiles);
            this.tpFiles.Controls.Add(this.cbTruecryptKeyfiles);
            this.tpFiles.Controls.Add(this.cbLogfileDisable);
            this.tpFiles.Controls.Add(this.tbOutfileCheckDir);
            this.tpFiles.Controls.Add(this.lblOutfileCheckDir);
            this.tpFiles.Controls.Add(this.cbOutfileCheckDir);
            this.tpFiles.Controls.Add(this.tbInductionDir);
            this.tpFiles.Controls.Add(this.lblInductionDir);
            this.tpFiles.Controls.Add(this.cbInductionDir);
            this.tpFiles.Controls.Add(this.tbDebugFile);
            this.tpFiles.Controls.Add(this.lblDebugFile);
            this.tpFiles.Controls.Add(this.cbDebugFile);
            this.tpFiles.Controls.Add(this.nudDebugMode);
            this.tpFiles.Controls.Add(this.lblDebugMode);
            this.tpFiles.Controls.Add(this.cbDebugMode);
            this.tpFiles.Controls.Add(this.cbPotfileDisable);
            this.tpFiles.Controls.Add(this.nudRemoveTimer);
            this.tpFiles.Controls.Add(this.lblRemoveTimer);
            this.tpFiles.Controls.Add(this.cbRemoveTimer);
            this.tpFiles.Controls.Add(this.cbRemoveCracked);
            this.tpFiles.Controls.Add(this.cbIgnoreUsernames);
            this.tpFiles.Controls.Add(this.cbShowUncracked);
            this.tpFiles.Controls.Add(this.cbShowCracked);
            this.tpFiles.Controls.Add(this.tbSeparator);
            this.tpFiles.Controls.Add(this.lblSeparator);
            this.tpFiles.Controls.Add(this.cbSeparator);
            this.tpFiles.Controls.Add(this.nudOutfileCheckTimer);
            this.tpFiles.Controls.Add(this.lblOutfileCheckTimer);
            this.tpFiles.Controls.Add(this.cbOutfileCheckTimer);
            this.tpFiles.Controls.Add(this.cbOutfileAutohexDisable);
            this.tpFiles.Controls.Add(this.tbOutfile);
            this.tpFiles.Controls.Add(this.lblOutfile);
            this.tpFiles.Controls.Add(this.cbOutfile);
            this.tpFiles.Controls.Add(this.nudOutfileFormat);
            this.tpFiles.Controls.Add(this.lblOutfileFormat);
            this.tpFiles.Controls.Add(this.cbOutfileFormat);
            this.tpFiles.Location = new System.Drawing.Point(4, 22);
            this.tpFiles.Name = "tpFiles";
            this.tpFiles.Size = new System.Drawing.Size(545, 311);
            this.tpFiles.TabIndex = 4;
            this.tpFiles.Text = "Files";
            this.tpFiles.UseVisualStyleBackColor = true;
            // 
            // tpResources
            // 
            this.tpResources.Location = new System.Drawing.Point(4, 22);
            this.tpResources.Name = "tpResources";
            this.tpResources.Size = new System.Drawing.Size(545, 311);
            this.tpResources.TabIndex = 5;
            this.tpResources.Text = "Resources";
            this.tpResources.UseVisualStyleBackColor = true;
            // 
            // tpDistributed
            // 
            this.tpDistributed.Location = new System.Drawing.Point(4, 22);
            this.tpDistributed.Name = "tpDistributed";
            this.tpDistributed.Size = new System.Drawing.Size(545, 311);
            this.tpDistributed.TabIndex = 6;
            this.tpDistributed.Text = "Distributed";
            this.tpDistributed.UseVisualStyleBackColor = true;
            // 
            // tpRules
            // 
            this.tpRules.Location = new System.Drawing.Point(4, 22);
            this.tpRules.Name = "tpRules";
            this.tpRules.Size = new System.Drawing.Size(545, 311);
            this.tpRules.TabIndex = 7;
            this.tpRules.Text = "Rules";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // tpCharsetsIncrement
            // 
            this.tpCharsetsIncrement.Location = new System.Drawing.Point(4, 22);
            this.tpCharsetsIncrement.Name = "tpCharsetsIncrement";
            this.tpCharsetsIncrement.Padding = new System.Windows.Forms.Padding(3);
            this.tpCharsetsIncrement.Size = new System.Drawing.Size(545, 311);
            this.tpCharsetsIncrement.TabIndex = 8;
            this.tpCharsetsIncrement.Text = "Charsets & Increment";
            this.tpCharsetsIncrement.UseVisualStyleBackColor = true;
            // 
            // nudRuntime
            // 
            this.nudRuntime.Location = new System.Drawing.Point(89, 41);
            this.nudRuntime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudRuntime.Name = "nudRuntime";
            this.nudRuntime.Size = new System.Drawing.Size(90, 20);
            this.nudRuntime.TabIndex = 14;
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(45, 43);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(41, 13);
            this.lblRuntime.TabIndex = 13;
            this.lblRuntime.Text = "NUM =";
            // 
            // cbRuntime
            // 
            this.cbRuntime.AutoSize = true;
            this.cbRuntime.Location = new System.Drawing.Point(18, 18);
            this.cbRuntime.Name = "cbRuntime";
            this.cbRuntime.Size = new System.Drawing.Size(322, 17);
            this.cbRuntime.TabIndex = 12;
            this.cbRuntime.Text = "Abort session after NUM seconds of runtime ( --runtime=NUM ):";
            this.cbRuntime.UseVisualStyleBackColor = true;
            // 
            // tbSession
            // 
            this.tbSession.Location = new System.Drawing.Point(89, 90);
            this.tbSession.Name = "tbSession";
            this.tbSession.Size = new System.Drawing.Size(255, 20);
            this.tbSession.TabIndex = 17;
            this.tbSession.Text = "oclHashcat";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(45, 93);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(38, 13);
            this.lblSession.TabIndex = 16;
            this.lblSession.Text = "STR =";
            // 
            // cbSession
            // 
            this.cbSession.AutoSize = true;
            this.cbSession.Location = new System.Drawing.Point(18, 67);
            this.cbSession.Name = "cbSession";
            this.cbSession.Size = new System.Drawing.Size(250, 17);
            this.cbSession.TabIndex = 15;
            this.cbSession.Text = "Define specific session name ( --session=STR ):";
            this.cbSession.UseVisualStyleBackColor = true;
            // 
            // cbRestoreDisable
            // 
            this.cbRestoreDisable.AutoSize = true;
            this.cbRestoreDisable.Location = new System.Drawing.Point(18, 116);
            this.cbRestoreDisable.Name = "cbRestoreDisable";
            this.cbRestoreDisable.Size = new System.Drawing.Size(223, 17);
            this.cbRestoreDisable.TabIndex = 18;
            this.cbRestoreDisable.Text = "Do not write restore file ( --restore-disable )";
            this.cbRestoreDisable.UseVisualStyleBackColor = true;
            // 
            // nudOutfileFormat
            // 
            this.nudOutfileFormat.Location = new System.Drawing.Point(94, 90);
            this.nudOutfileFormat.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOutfileFormat.Name = "nudOutfileFormat";
            this.nudOutfileFormat.Size = new System.Drawing.Size(90, 20);
            this.nudOutfileFormat.TabIndex = 17;
            this.nudOutfileFormat.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblOutfileFormat
            // 
            this.lblOutfileFormat.AutoSize = true;
            this.lblOutfileFormat.Location = new System.Drawing.Point(45, 92);
            this.lblOutfileFormat.Name = "lblOutfileFormat";
            this.lblOutfileFormat.Size = new System.Drawing.Size(41, 13);
            this.lblOutfileFormat.TabIndex = 16;
            this.lblOutfileFormat.Text = "NUM =";
            // 
            // cbOutfileFormat
            // 
            this.cbOutfileFormat.AutoSize = true;
            this.cbOutfileFormat.Location = new System.Drawing.Point(18, 67);
            this.cbOutfileFormat.Name = "cbOutfileFormat";
            this.cbOutfileFormat.Size = new System.Drawing.Size(327, 17);
            this.cbOutfileFormat.TabIndex = 15;
            this.cbOutfileFormat.Text = "Define outfile-format for recovered hash ( --outfile-format=NUM ):";
            this.cbOutfileFormat.UseVisualStyleBackColor = true;
            // 
            // tbOutfile
            // 
            this.tbOutfile.Location = new System.Drawing.Point(94, 41);
            this.tbOutfile.Name = "tbOutfile";
            this.tbOutfile.Size = new System.Drawing.Size(255, 20);
            this.tbOutfile.TabIndex = 20;
            // 
            // lblOutfile
            // 
            this.lblOutfile.AutoSize = true;
            this.lblOutfile.Location = new System.Drawing.Point(45, 44);
            this.lblOutfile.Name = "lblOutfile";
            this.lblOutfile.Size = new System.Drawing.Size(38, 13);
            this.lblOutfile.TabIndex = 19;
            this.lblOutfile.Text = "FILE =";
            // 
            // cbOutfile
            // 
            this.cbOutfile.AutoSize = true;
            this.cbOutfile.Location = new System.Drawing.Point(18, 18);
            this.cbOutfile.Name = "cbOutfile";
            this.cbOutfile.Size = new System.Drawing.Size(278, 17);
            this.cbOutfile.TabIndex = 18;
            this.cbOutfile.Text = "Define outfile for recovered hash ( -o,  --outfile=FILE ):";
            this.cbOutfile.UseVisualStyleBackColor = true;
            // 
            // cbOutfileAutohexDisable
            // 
            this.cbOutfileAutohexDisable.AutoSize = true;
            this.cbOutfileAutohexDisable.Location = new System.Drawing.Point(18, 116);
            this.cbOutfileAutohexDisable.Name = "cbOutfileAutohexDisable";
            this.cbOutfileAutohexDisable.Size = new System.Drawing.Size(348, 17);
            this.cbOutfileAutohexDisable.TabIndex = 21;
            this.cbOutfileAutohexDisable.Text = "Disable the use of $HEX[] in output plains ( --outfile-autohex-disable )";
            this.cbOutfileAutohexDisable.UseVisualStyleBackColor = true;
            // 
            // nudOutfileCheckTimer
            // 
            this.nudOutfileCheckTimer.Location = new System.Drawing.Point(94, 162);
            this.nudOutfileCheckTimer.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOutfileCheckTimer.Name = "nudOutfileCheckTimer";
            this.nudOutfileCheckTimer.Size = new System.Drawing.Size(90, 20);
            this.nudOutfileCheckTimer.TabIndex = 24;
            // 
            // lblOutfileCheckTimer
            // 
            this.lblOutfileCheckTimer.AutoSize = true;
            this.lblOutfileCheckTimer.Location = new System.Drawing.Point(45, 164);
            this.lblOutfileCheckTimer.Name = "lblOutfileCheckTimer";
            this.lblOutfileCheckTimer.Size = new System.Drawing.Size(41, 13);
            this.lblOutfileCheckTimer.TabIndex = 23;
            this.lblOutfileCheckTimer.Text = "NUM =";
            // 
            // cbOutfileCheckTimer
            // 
            this.cbOutfileCheckTimer.AutoSize = true;
            this.cbOutfileCheckTimer.Location = new System.Drawing.Point(18, 139);
            this.cbOutfileCheckTimer.Name = "cbOutfileCheckTimer";
            this.cbOutfileCheckTimer.Size = new System.Drawing.Size(322, 17);
            this.cbOutfileCheckTimer.TabIndex = 22;
            this.cbOutfileCheckTimer.Text = "Seconds between outfile checks ( --outfile-check-timer=NUM ):";
            this.cbOutfileCheckTimer.UseVisualStyleBackColor = true;
            // 
            // cbSeparator
            // 
            this.cbSeparator.AutoSize = true;
            this.cbSeparator.Location = new System.Drawing.Point(18, 188);
            this.cbSeparator.Name = "cbSeparator";
            this.cbSeparator.Size = new System.Drawing.Size(328, 17);
            this.cbSeparator.TabIndex = 25;
            this.cbSeparator.Text = "Separator char for hashlists and outfile ( -p,  --separator=CHAR ):";
            this.cbSeparator.UseVisualStyleBackColor = true;
            // 
            // tbSeparator
            // 
            this.tbSeparator.Location = new System.Drawing.Point(94, 211);
            this.tbSeparator.Name = "tbSeparator";
            this.tbSeparator.Size = new System.Drawing.Size(90, 20);
            this.tbSeparator.TabIndex = 27;
            this.tbSeparator.Text = ":";
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(45, 214);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(46, 13);
            this.lblSeparator.TabIndex = 26;
            this.lblSeparator.Text = "CHAR =";
            // 
            // cbShowCracked
            // 
            this.cbShowCracked.AutoSize = true;
            this.cbShowCracked.Location = new System.Drawing.Point(18, 237);
            this.cbShowCracked.Name = "cbShowCracked";
            this.cbShowCracked.Size = new System.Drawing.Size(216, 17);
            this.cbShowCracked.TabIndex = 28;
            this.cbShowCracked.Text = "Show cracked passwords only ( --show )";
            this.cbShowCracked.UseVisualStyleBackColor = true;
            // 
            // cbShowUncracked
            // 
            this.cbShowUncracked.AutoSize = true;
            this.cbShowUncracked.Location = new System.Drawing.Point(18, 260);
            this.cbShowUncracked.Name = "cbShowUncracked";
            this.cbShowUncracked.Size = new System.Drawing.Size(220, 17);
            this.cbShowUncracked.TabIndex = 29;
            this.cbShowUncracked.Text = "Show un-cracked passwords only ( --left )";
            this.cbShowUncracked.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreUsernames
            // 
            this.cbIgnoreUsernames.AutoSize = true;
            this.cbIgnoreUsernames.Location = new System.Drawing.Point(18, 283);
            this.cbIgnoreUsernames.Name = "cbIgnoreUsernames";
            this.cbIgnoreUsernames.Size = new System.Drawing.Size(282, 17);
            this.cbIgnoreUsernames.TabIndex = 30;
            this.cbIgnoreUsernames.Text = "Enable ignoring of usernames in hashfile ( --username )";
            this.cbIgnoreUsernames.UseVisualStyleBackColor = true;
            // 
            // cbRemoveCracked
            // 
            this.cbRemoveCracked.AutoSize = true;
            this.cbRemoveCracked.Location = new System.Drawing.Point(18, 306);
            this.cbRemoveCracked.Name = "cbRemoveCracked";
            this.cbRemoveCracked.Size = new System.Drawing.Size(278, 17);
            this.cbRemoveCracked.TabIndex = 31;
            this.cbRemoveCracked.Text = "Enable remove of hash once it is cracked ( --remove )";
            this.cbRemoveCracked.UseVisualStyleBackColor = true;
            // 
            // nudRemoveTimer
            // 
            this.nudRemoveTimer.Location = new System.Drawing.Point(94, 352);
            this.nudRemoveTimer.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudRemoveTimer.Name = "nudRemoveTimer";
            this.nudRemoveTimer.Size = new System.Drawing.Size(90, 20);
            this.nudRemoveTimer.TabIndex = 34;
            // 
            // lblRemoveTimer
            // 
            this.lblRemoveTimer.AutoSize = true;
            this.lblRemoveTimer.Location = new System.Drawing.Point(45, 354);
            this.lblRemoveTimer.Name = "lblRemoveTimer";
            this.lblRemoveTimer.Size = new System.Drawing.Size(41, 13);
            this.lblRemoveTimer.TabIndex = 33;
            this.lblRemoveTimer.Text = "NUM =";
            // 
            // cbRemoveTimer
            // 
            this.cbRemoveTimer.AutoSize = true;
            this.cbRemoveTimer.Location = new System.Drawing.Point(18, 329);
            this.cbRemoveTimer.Name = "cbRemoveTimer";
            this.cbRemoveTimer.Size = new System.Drawing.Size(342, 17);
            this.cbRemoveTimer.TabIndex = 32;
            this.cbRemoveTimer.Text = "Update input hash file each NUM seconds ( --remove-timer=NUM ):";
            this.cbRemoveTimer.UseVisualStyleBackColor = true;
            // 
            // cbPotfileDisable
            // 
            this.cbPotfileDisable.AutoSize = true;
            this.cbPotfileDisable.Location = new System.Drawing.Point(18, 378);
            this.cbPotfileDisable.Name = "cbPotfileDisable";
            this.cbPotfileDisable.Size = new System.Drawing.Size(199, 17);
            this.cbPotfileDisable.TabIndex = 35;
            this.cbPotfileDisable.Text = "Do not write potfile ( --potfile-disable )";
            this.cbPotfileDisable.UseVisualStyleBackColor = true;
            // 
            // nudDebugMode
            // 
            this.nudDebugMode.Location = new System.Drawing.Point(94, 424);
            this.nudDebugMode.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDebugMode.Name = "nudDebugMode";
            this.nudDebugMode.Size = new System.Drawing.Size(90, 20);
            this.nudDebugMode.TabIndex = 38;
            // 
            // lblDebugMode
            // 
            this.lblDebugMode.AutoSize = true;
            this.lblDebugMode.Location = new System.Drawing.Point(45, 426);
            this.lblDebugMode.Name = "lblDebugMode";
            this.lblDebugMode.Size = new System.Drawing.Size(41, 13);
            this.lblDebugMode.TabIndex = 37;
            this.lblDebugMode.Text = "NUM =";
            // 
            // cbDebugMode
            // 
            this.cbDebugMode.AutoSize = true;
            this.cbDebugMode.Location = new System.Drawing.Point(18, 401);
            this.cbDebugMode.Name = "cbDebugMode";
            this.cbDebugMode.Size = new System.Drawing.Size(379, 17);
            this.cbDebugMode.TabIndex = 36;
            this.cbDebugMode.Text = "Defines the debug mode, hybrid only by using rules ( --debug-mode=NUM ):";
            this.cbDebugMode.UseVisualStyleBackColor = true;
            // 
            // tbDebugFile
            // 
            this.tbDebugFile.Location = new System.Drawing.Point(94, 473);
            this.tbDebugFile.Name = "tbDebugFile";
            this.tbDebugFile.Size = new System.Drawing.Size(255, 20);
            this.tbDebugFile.TabIndex = 41;
            // 
            // lblDebugFile
            // 
            this.lblDebugFile.AutoSize = true;
            this.lblDebugFile.Location = new System.Drawing.Point(45, 476);
            this.lblDebugFile.Name = "lblDebugFile";
            this.lblDebugFile.Size = new System.Drawing.Size(38, 13);
            this.lblDebugFile.TabIndex = 40;
            this.lblDebugFile.Text = "FILE =";
            // 
            // cbDebugFile
            // 
            this.cbDebugFile.AutoSize = true;
            this.cbDebugFile.Location = new System.Drawing.Point(18, 450);
            this.cbDebugFile.Name = "cbDebugFile";
            this.cbDebugFile.Size = new System.Drawing.Size(265, 17);
            this.cbDebugFile.TabIndex = 39;
            this.cbDebugFile.Text = "Output file for debugging rules ( --debug-file=FILE ):";
            this.cbDebugFile.UseVisualStyleBackColor = true;
            // 
            // tbInductionDir
            // 
            this.tbInductionDir.Location = new System.Drawing.Point(94, 522);
            this.tbInductionDir.Name = "tbInductionDir";
            this.tbInductionDir.Size = new System.Drawing.Size(255, 20);
            this.tbInductionDir.TabIndex = 44;
            // 
            // lblInductionDir
            // 
            this.lblInductionDir.AutoSize = true;
            this.lblInductionDir.Location = new System.Drawing.Point(45, 525);
            this.lblInductionDir.Name = "lblInductionDir";
            this.lblInductionDir.Size = new System.Drawing.Size(44, 13);
            this.lblInductionDir.TabIndex = 43;
            this.lblInductionDir.Text = "FOLD =";
            // 
            // cbInductionDir
            // 
            this.cbInductionDir.AutoSize = true;
            this.cbInductionDir.Location = new System.Drawing.Point(18, 499);
            this.cbInductionDir.Name = "cbInductionDir";
            this.cbInductionDir.Size = new System.Drawing.Size(297, 17);
            this.cbInductionDir.TabIndex = 42;
            this.cbInductionDir.Text = "Specify induction directory to use ( --induction-dir=FOLD ):";
            this.cbInductionDir.UseVisualStyleBackColor = true;
            // 
            // tbOutfileCheckDir
            // 
            this.tbOutfileCheckDir.Location = new System.Drawing.Point(94, 571);
            this.tbOutfileCheckDir.Name = "tbOutfileCheckDir";
            this.tbOutfileCheckDir.Size = new System.Drawing.Size(255, 20);
            this.tbOutfileCheckDir.TabIndex = 47;
            // 
            // lblOutfileCheckDir
            // 
            this.lblOutfileCheckDir.AutoSize = true;
            this.lblOutfileCheckDir.Location = new System.Drawing.Point(45, 574);
            this.lblOutfileCheckDir.Name = "lblOutfileCheckDir";
            this.lblOutfileCheckDir.Size = new System.Drawing.Size(44, 13);
            this.lblOutfileCheckDir.TabIndex = 46;
            this.lblOutfileCheckDir.Text = "FOLD =";
            // 
            // cbOutfileCheckDir
            // 
            this.cbOutfileCheckDir.AutoSize = true;
            this.cbOutfileCheckDir.Location = new System.Drawing.Point(18, 548);
            this.cbOutfileCheckDir.Name = "cbOutfileCheckDir";
            this.cbOutfileCheckDir.Size = new System.Drawing.Size(415, 17);
            this.cbOutfileCheckDir.TabIndex = 45;
            this.cbOutfileCheckDir.Text = "Specify the outfile directory which should be monitored ( --outfile-check-dir=FOL" +
    "D ):";
            this.cbOutfileCheckDir.UseVisualStyleBackColor = true;
            // 
            // cbLogfileDisable
            // 
            this.cbLogfileDisable.AutoSize = true;
            this.cbLogfileDisable.Location = new System.Drawing.Point(18, 597);
            this.cbLogfileDisable.Name = "cbLogfileDisable";
            this.cbLogfileDisable.Size = new System.Drawing.Size(193, 17);
            this.cbLogfileDisable.TabIndex = 48;
            this.cbLogfileDisable.Text = "Disable the logfile ( --logfile-disable )";
            this.cbLogfileDisable.UseVisualStyleBackColor = true;
            // 
            // tbTruecryptKeyfiles
            // 
            this.tbTruecryptKeyfiles.Location = new System.Drawing.Point(94, 643);
            this.tbTruecryptKeyfiles.Name = "tbTruecryptKeyfiles";
            this.tbTruecryptKeyfiles.Size = new System.Drawing.Size(255, 20);
            this.tbTruecryptKeyfiles.TabIndex = 51;
            // 
            // lblTruecryptKeyfiles
            // 
            this.lblTruecryptKeyfiles.AutoSize = true;
            this.lblTruecryptKeyfiles.Location = new System.Drawing.Point(45, 646);
            this.lblTruecryptKeyfiles.Name = "lblTruecryptKeyfiles";
            this.lblTruecryptKeyfiles.Size = new System.Drawing.Size(38, 13);
            this.lblTruecryptKeyfiles.TabIndex = 50;
            this.lblTruecryptKeyfiles.Text = "FILE =";
            // 
            // cbTruecryptKeyfiles
            // 
            this.cbTruecryptKeyfiles.AutoSize = true;
            this.cbTruecryptKeyfiles.Location = new System.Drawing.Point(18, 620);
            this.cbTruecryptKeyfiles.Name = "cbTruecryptKeyfiles";
            this.cbTruecryptKeyfiles.Size = new System.Drawing.Size(325, 17);
            this.cbTruecryptKeyfiles.TabIndex = 49;
            this.cbTruecryptKeyfiles.Text = "Keyfiles used, seperate with comma ( --truecrypt-keyfiles=FILE ):";
            this.cbTruecryptKeyfiles.UseVisualStyleBackColor = true;
            // 
            // TaskEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "TaskEditorForm";
            this.Text = "TaskEditorForm";
            this.tabControl1.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            this.tpMisc.ResumeLayout(false);
            this.tpMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeakHashThreshold)).EndInit();
            this.tpMarkov.ResumeLayout(false);
            this.tpMarkov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkovThreshold)).EndInit();
            this.tpSession.ResumeLayout(false);
            this.tpSession.PerformLayout();
            this.tpFiles.ResumeLayout(false);
            this.tpFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRuntime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutfileFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutfileCheckTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDebugMode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tpMisc;
        private System.Windows.Forms.Label lblHashType;
        private System.Windows.Forms.ComboBox cbHashType;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.ComboBox cbTarget;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.ComboBox cbTemplate;
        private System.Windows.Forms.TabPage tpMarkov;
        private System.Windows.Forms.TabPage tpSession;
        private System.Windows.Forms.TabPage tpFiles;
        private System.Windows.Forms.TabPage tpResources;
        private System.Windows.Forms.TabPage tpDistributed;
        private System.Windows.Forms.TabPage tpRules;
        private System.Windows.Forms.TabPage tpCharsetsIncrement;
        private System.Windows.Forms.CheckBox cbHexCharset;
        private System.Windows.Forms.CheckBox cbHexSalt;
        private System.Windows.Forms.CheckBox cbHexWordlist;
        private System.Windows.Forms.CheckBox cbForce;
        private System.Windows.Forms.CheckBox cbLoopback;
        private System.Windows.Forms.CheckBox cbWeakHashThreshold;
        private System.Windows.Forms.Label lblWeakHashThreshold;
        private System.Windows.Forms.NumericUpDown nudWeakHashThreshold;
        private System.Windows.Forms.CheckBox cbMarkovHcstat;
        private System.Windows.Forms.CheckBox cbMarkovDisable;
        private System.Windows.Forms.TextBox tbMarkovHcstat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbMarkovClassic;
        private System.Windows.Forms.NumericUpDown nudMarkovThreshold;
        private System.Windows.Forms.Label lblMarkovThreshold;
        private System.Windows.Forms.CheckBox cbMarkovThreshold;
        private System.Windows.Forms.CheckBox cbRestoreDisable;
        private System.Windows.Forms.TextBox tbSession;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.CheckBox cbSession;
        private System.Windows.Forms.NumericUpDown nudRuntime;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.CheckBox cbRuntime;
        private System.Windows.Forms.TextBox tbSeparator;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.CheckBox cbSeparator;
        private System.Windows.Forms.NumericUpDown nudOutfileCheckTimer;
        private System.Windows.Forms.Label lblOutfileCheckTimer;
        private System.Windows.Forms.CheckBox cbOutfileCheckTimer;
        private System.Windows.Forms.CheckBox cbOutfileAutohexDisable;
        private System.Windows.Forms.TextBox tbOutfile;
        private System.Windows.Forms.Label lblOutfile;
        private System.Windows.Forms.CheckBox cbOutfile;
        private System.Windows.Forms.NumericUpDown nudOutfileFormat;
        private System.Windows.Forms.Label lblOutfileFormat;
        private System.Windows.Forms.CheckBox cbOutfileFormat;
        private System.Windows.Forms.CheckBox cbRemoveCracked;
        private System.Windows.Forms.CheckBox cbIgnoreUsernames;
        private System.Windows.Forms.CheckBox cbShowUncracked;
        private System.Windows.Forms.CheckBox cbShowCracked;
        private System.Windows.Forms.TextBox tbTruecryptKeyfiles;
        private System.Windows.Forms.Label lblTruecryptKeyfiles;
        private System.Windows.Forms.CheckBox cbTruecryptKeyfiles;
        private System.Windows.Forms.CheckBox cbLogfileDisable;
        private System.Windows.Forms.TextBox tbOutfileCheckDir;
        private System.Windows.Forms.Label lblOutfileCheckDir;
        private System.Windows.Forms.CheckBox cbOutfileCheckDir;
        private System.Windows.Forms.TextBox tbInductionDir;
        private System.Windows.Forms.Label lblInductionDir;
        private System.Windows.Forms.CheckBox cbInductionDir;
        private System.Windows.Forms.TextBox tbDebugFile;
        private System.Windows.Forms.Label lblDebugFile;
        private System.Windows.Forms.CheckBox cbDebugFile;
        private System.Windows.Forms.NumericUpDown nudDebugMode;
        private System.Windows.Forms.Label lblDebugMode;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.CheckBox cbPotfileDisable;
        private System.Windows.Forms.NumericUpDown nudRemoveTimer;
        private System.Windows.Forms.Label lblRemoveTimer;
        private System.Windows.Forms.CheckBox cbRemoveTimer;
    }
}