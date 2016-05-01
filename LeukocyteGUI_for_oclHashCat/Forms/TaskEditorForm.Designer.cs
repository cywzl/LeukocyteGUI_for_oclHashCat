namespace LeukocyteGUI_for_oclHashcat
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
            this.tcTaskOptions = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.gbIncrementMode = new System.Windows.Forms.GroupBox();
            this.nudIncrementMax = new System.Windows.Forms.NumericUpDown();
            this.nudIncrementMin = new System.Windows.Forms.NumericUpDown();
            this.lblIncrementMax = new System.Windows.Forms.Label();
            this.lblIncrementMin = new System.Windows.Forms.Label();
            this.cbIncrementMode = new System.Windows.Forms.CheckBox();
            this.gbCharsets = new System.Windows.Forms.GroupBox();
            this.cmbCharset4 = new System.Windows.Forms.ComboBox();
            this.cmbCharset3 = new System.Windows.Forms.ComboBox();
            this.cmbCharset2 = new System.Windows.Forms.ComboBox();
            this.cmbCharset1 = new System.Windows.Forms.ComboBox();
            this.cbCharset4 = new System.Windows.Forms.CheckBox();
            this.cbCharset3 = new System.Windows.Forms.CheckBox();
            this.cbCharset2 = new System.Windows.Forms.CheckBox();
            this.cbCharset1 = new System.Windows.Forms.CheckBox();
            this.gbAttackSource = new System.Windows.Forms.GroupBox();
            this.cmbRightSource = new System.Windows.Forms.ComboBox();
            this.cmbLeftSource = new System.Windows.Forms.ComboBox();
            this.lblRightSource = new System.Windows.Forms.Label();
            this.lblLeftSource = new System.Windows.Forms.Label();
            this.gbAttackType = new System.Windows.Forms.GroupBox();
            this.rbMaskDict = new System.Windows.Forms.RadioButton();
            this.rbDictMask = new System.Windows.Forms.RadioButton();
            this.rbBruteforce = new System.Windows.Forms.RadioButton();
            this.rbCombination = new System.Windows.Forms.RadioButton();
            this.rbStraight = new System.Windows.Forms.RadioButton();
            this.tpPredefined = new System.Windows.Forms.TabPage();
            this.lvPredefined = new System.Windows.Forms.ListView();
            this.chPredefinedNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPredefinedType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPredefinedName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPredefinedDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lblMarkovHcstat = new System.Windows.Forms.Label();
            this.cbMarkovHcstat = new System.Windows.Forms.CheckBox();
            this.tpSession = new System.Windows.Forms.TabPage();
            this.cbRestoreDisable = new System.Windows.Forms.CheckBox();
            this.tbSession = new System.Windows.Forms.TextBox();
            this.lblSession = new System.Windows.Forms.Label();
            this.cbSession = new System.Windows.Forms.CheckBox();
            this.nudRuntime = new System.Windows.Forms.NumericUpDown();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.cbRuntime = new System.Windows.Forms.CheckBox();
            this.tpFiles = new System.Windows.Forms.TabPage();
            this.tbTruecryptKeyfiles = new System.Windows.Forms.TextBox();
            this.lblTruecryptKeyfiles = new System.Windows.Forms.Label();
            this.cbTruecryptKeyfiles = new System.Windows.Forms.CheckBox();
            this.cbLogfileDisable = new System.Windows.Forms.CheckBox();
            this.tbOutfileCheckDir = new System.Windows.Forms.TextBox();
            this.lblOutfileCheckDir = new System.Windows.Forms.Label();
            this.cbOutfileCheckDir = new System.Windows.Forms.CheckBox();
            this.tbInductionDir = new System.Windows.Forms.TextBox();
            this.lblInductionDir = new System.Windows.Forms.Label();
            this.cbInductionDir = new System.Windows.Forms.CheckBox();
            this.tbDebugFile = new System.Windows.Forms.TextBox();
            this.lblDebugFile = new System.Windows.Forms.Label();
            this.cbDebugFile = new System.Windows.Forms.CheckBox();
            this.nudDebugMode = new System.Windows.Forms.NumericUpDown();
            this.lblDebugMode = new System.Windows.Forms.Label();
            this.cbDebugMode = new System.Windows.Forms.CheckBox();
            this.cbPotfileDisable = new System.Windows.Forms.CheckBox();
            this.nudRemoveTimer = new System.Windows.Forms.NumericUpDown();
            this.lblRemoveTimer = new System.Windows.Forms.Label();
            this.cbRemoveTimer = new System.Windows.Forms.CheckBox();
            this.cbRemoveCracked = new System.Windows.Forms.CheckBox();
            this.cbIgnoreUsernames = new System.Windows.Forms.CheckBox();
            this.cbShowUncracked = new System.Windows.Forms.CheckBox();
            this.cbShowCracked = new System.Windows.Forms.CheckBox();
            this.tbSeparator = new System.Windows.Forms.TextBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.cbSeparator = new System.Windows.Forms.CheckBox();
            this.nudOutfileCheckTimer = new System.Windows.Forms.NumericUpDown();
            this.lblOutfileCheckTimer = new System.Windows.Forms.Label();
            this.cbOutfileCheckTimer = new System.Windows.Forms.CheckBox();
            this.cbOutfileAutohexDisable = new System.Windows.Forms.CheckBox();
            this.tbOutfile = new System.Windows.Forms.TextBox();
            this.lblOutfile = new System.Windows.Forms.Label();
            this.cbOutfile = new System.Windows.Forms.CheckBox();
            this.nudOutfileFormat = new System.Windows.Forms.NumericUpDown();
            this.lblOutfileFormat = new System.Windows.Forms.Label();
            this.cbOutfileFormat = new System.Windows.Forms.CheckBox();
            this.tpResources = new System.Windows.Forms.TabPage();
            this.nudScryptTmto = new System.Windows.Forms.NumericUpDown();
            this.lblScryptTmto = new System.Windows.Forms.Label();
            this.cbScryptTmto = new System.Windows.Forms.CheckBox();
            this.cbPowertuneEnable = new System.Windows.Forms.CheckBox();
            this.nudGpuTempRetain = new System.Windows.Forms.NumericUpDown();
            this.lblGpuTempRetain = new System.Windows.Forms.Label();
            this.cbGpuTempRetain = new System.Windows.Forms.CheckBox();
            this.nudGpuTempAbort = new System.Windows.Forms.NumericUpDown();
            this.lblGpuTempAbort = new System.Windows.Forms.Label();
            this.cbGpuTempAbort = new System.Windows.Forms.CheckBox();
            this.cbGpuTempDisable = new System.Windows.Forms.CheckBox();
            this.nudGpuLoops = new System.Windows.Forms.NumericUpDown();
            this.lblGpuLoops = new System.Windows.Forms.Label();
            this.cbGpuLoops = new System.Windows.Forms.CheckBox();
            this.nudGpuAccel = new System.Windows.Forms.NumericUpDown();
            this.lblGpuAccel = new System.Windows.Forms.Label();
            this.cbGpuAccel = new System.Windows.Forms.CheckBox();
            this.nudWorkloadProfile = new System.Windows.Forms.NumericUpDown();
            this.lblWorkloadProfile = new System.Windows.Forms.Label();
            this.cbWorkloadProfile = new System.Windows.Forms.CheckBox();
            this.tbGpuDevices = new System.Windows.Forms.TextBox();
            this.lblGpuDevices = new System.Windows.Forms.Label();
            this.cbGpuDevices = new System.Windows.Forms.CheckBox();
            this.cbGpuAsync = new System.Windows.Forms.CheckBox();
            this.tbCpuAffinity = new System.Windows.Forms.TextBox();
            this.lblCpuAffinity = new System.Windows.Forms.Label();
            this.cbCpuAffinity = new System.Windows.Forms.CheckBox();
            this.nudBitmapMax = new System.Windows.Forms.NumericUpDown();
            this.lblBitmapMax = new System.Windows.Forms.Label();
            this.cbBitmapMax = new System.Windows.Forms.CheckBox();
            this.nudBitmapMin = new System.Windows.Forms.NumericUpDown();
            this.lblBitmapMin = new System.Windows.Forms.Label();
            this.cbBitmapMin = new System.Windows.Forms.CheckBox();
            this.nudSegmentSize = new System.Windows.Forms.NumericUpDown();
            this.lblSegmentSize = new System.Windows.Forms.Label();
            this.cbSegmentSize = new System.Windows.Forms.CheckBox();
            this.tpDistributed = new System.Windows.Forms.TabPage();
            this.nudLimit = new System.Windows.Forms.NumericUpDown();
            this.lblLimit = new System.Windows.Forms.Label();
            this.cbLimit = new System.Windows.Forms.CheckBox();
            this.nudSkip = new System.Windows.Forms.NumericUpDown();
            this.lblSkip = new System.Windows.Forms.Label();
            this.cbSkip = new System.Windows.Forms.CheckBox();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.nudGenerateRulesSeed = new System.Windows.Forms.NumericUpDown();
            this.lblGenerateRulesSeed = new System.Windows.Forms.Label();
            this.cbGenerateRulesSeed = new System.Windows.Forms.CheckBox();
            this.nudGenerateRulesFuncMax = new System.Windows.Forms.NumericUpDown();
            this.lblGenerateRulesFuncMax = new System.Windows.Forms.Label();
            this.cbGenerateRulesFuncMax = new System.Windows.Forms.CheckBox();
            this.nudGenerateRulesFuncMin = new System.Windows.Forms.NumericUpDown();
            this.lblGenerateRulesFuncMin = new System.Windows.Forms.Label();
            this.cbGenerateRulesFuncMin = new System.Windows.Forms.CheckBox();
            this.nudGenerateRules = new System.Windows.Forms.NumericUpDown();
            this.lblGenerateRules = new System.Windows.Forms.Label();
            this.cbGenerateRules = new System.Windows.Forms.CheckBox();
            this.tbRulesFiles = new System.Windows.Forms.TextBox();
            this.lblRulesFiles = new System.Windows.Forms.Label();
            this.cbRulesFiles = new System.Windows.Forms.CheckBox();
            this.tbRuleRight = new System.Windows.Forms.TextBox();
            this.lblRuleRight = new System.Windows.Forms.Label();
            this.cbRuleRight = new System.Windows.Forms.CheckBox();
            this.tbRuleLeft = new System.Windows.Forms.TextBox();
            this.lblRuleLeft = new System.Windows.Forms.Label();
            this.cbRuleLeft = new System.Windows.Forms.CheckBox();
            this.lblHashType = new System.Windows.Forms.Label();
            this.cmbHashType = new System.Windows.Forms.ComboBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.cmbTarget = new System.Windows.Forms.ComboBox();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.cmbTemplate = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tcTaskOptions.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.gbIncrementMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncrementMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncrementMin)).BeginInit();
            this.gbCharsets.SuspendLayout();
            this.gbAttackSource.SuspendLayout();
            this.gbAttackType.SuspendLayout();
            this.tpPredefined.SuspendLayout();
            this.tpMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeakHashThreshold)).BeginInit();
            this.tpMarkov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkovThreshold)).BeginInit();
            this.tpSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRuntime)).BeginInit();
            this.tpFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDebugMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutfileCheckTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutfileFormat)).BeginInit();
            this.tpResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScryptTmto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGpuTempRetain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGpuTempAbort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGpuLoops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGpuAccel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorkloadProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBitmapMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBitmapMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegmentSize)).BeginInit();
            this.tpDistributed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkip)).BeginInit();
            this.tpRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenerateRulesSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenerateRulesFuncMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenerateRulesFuncMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenerateRules)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTaskOptions
            // 
            this.tcTaskOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTaskOptions.Controls.Add(this.tpMain);
            this.tcTaskOptions.Controls.Add(this.tpPredefined);
            this.tcTaskOptions.Controls.Add(this.tpMisc);
            this.tcTaskOptions.Controls.Add(this.tpMarkov);
            this.tcTaskOptions.Controls.Add(this.tpSession);
            this.tcTaskOptions.Controls.Add(this.tpFiles);
            this.tcTaskOptions.Controls.Add(this.tpResources);
            this.tcTaskOptions.Controls.Add(this.tpDistributed);
            this.tcTaskOptions.Controls.Add(this.tpRules);
            this.tcTaskOptions.Location = new System.Drawing.Point(12, 102);
            this.tcTaskOptions.Name = "tcTaskOptions";
            this.tcTaskOptions.SelectedIndex = 0;
            this.tcTaskOptions.Size = new System.Drawing.Size(555, 319);
            this.tcTaskOptions.TabIndex = 0;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.gbIncrementMode);
            this.tpMain.Controls.Add(this.gbCharsets);
            this.tpMain.Controls.Add(this.gbAttackSource);
            this.tpMain.Controls.Add(this.gbAttackType);
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(547, 293);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Main";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // gbIncrementMode
            // 
            this.gbIncrementMode.Controls.Add(this.nudIncrementMax);
            this.gbIncrementMode.Controls.Add(this.nudIncrementMin);
            this.gbIncrementMode.Controls.Add(this.lblIncrementMax);
            this.gbIncrementMode.Controls.Add(this.lblIncrementMin);
            this.gbIncrementMode.Controls.Add(this.cbIncrementMode);
            this.gbIncrementMode.Enabled = false;
            this.gbIncrementMode.Location = new System.Drawing.Point(18, 142);
            this.gbIncrementMode.Name = "gbIncrementMode";
            this.gbIncrementMode.Size = new System.Drawing.Size(208, 138);
            this.gbIncrementMode.TabIndex = 3;
            this.gbIncrementMode.TabStop = false;
            this.gbIncrementMode.Text = "Increment mode";
            // 
            // nudIncrementMax
            // 
            this.nudIncrementMax.Location = new System.Drawing.Point(150, 102);
            this.nudIncrementMax.Maximum = new decimal(new int[] {
            54,
            0,
            0,
            0});
            this.nudIncrementMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIncrementMax.Name = "nudIncrementMax";
            this.nudIncrementMax.Size = new System.Drawing.Size(44, 20);
            this.nudIncrementMax.TabIndex = 10;
            this.nudIncrementMax.Value = new decimal(new int[] {
            54,
            0,
            0,
            0});
            // 
            // nudIncrementMin
            // 
            this.nudIncrementMin.Location = new System.Drawing.Point(150, 65);
            this.nudIncrementMin.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.nudIncrementMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIncrementMin.Name = "nudIncrementMin";
            this.nudIncrementMin.Size = new System.Drawing.Size(44, 20);
            this.nudIncrementMin.TabIndex = 9;
            this.nudIncrementMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblIncrementMax
            // 
            this.lblIncrementMax.AutoSize = true;
            this.lblIncrementMax.Location = new System.Drawing.Point(12, 98);
            this.lblIncrementMax.Name = "lblIncrementMax";
            this.lblIncrementMax.Size = new System.Drawing.Size(132, 26);
            this.lblIncrementMax.TabIndex = 2;
            this.lblIncrementMax.Text = "Stop incrementing at NUM\r\n( --increment-max=NUM ):";
            // 
            // lblIncrementMin
            // 
            this.lblIncrementMin.AutoSize = true;
            this.lblIncrementMin.Location = new System.Drawing.Point(12, 61);
            this.lblIncrementMin.Name = "lblIncrementMin";
            this.lblIncrementMin.Size = new System.Drawing.Size(132, 26);
            this.lblIncrementMin.TabIndex = 1;
            this.lblIncrementMin.Text = "Start incrementing at NUM\r\n( --increment-min=NUM ):";
            // 
            // cbIncrementMode
            // 
            this.cbIncrementMode.AutoSize = true;
            this.cbIncrementMode.Location = new System.Drawing.Point(15, 19);
            this.cbIncrementMode.Name = "cbIncrementMode";
            this.cbIncrementMode.Size = new System.Drawing.Size(137, 30);
            this.cbIncrementMode.TabIndex = 0;
            this.cbIncrementMode.Text = "Enable increment mode\r\n( -i,  --increment )";
            this.cbIncrementMode.UseVisualStyleBackColor = true;
            // 
            // gbCharsets
            // 
            this.gbCharsets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCharsets.Controls.Add(this.cmbCharset4);
            this.gbCharsets.Controls.Add(this.cmbCharset3);
            this.gbCharsets.Controls.Add(this.cmbCharset2);
            this.gbCharsets.Controls.Add(this.cmbCharset1);
            this.gbCharsets.Controls.Add(this.cbCharset4);
            this.gbCharsets.Controls.Add(this.cbCharset3);
            this.gbCharsets.Controls.Add(this.cbCharset2);
            this.gbCharsets.Controls.Add(this.cbCharset1);
            this.gbCharsets.Enabled = false;
            this.gbCharsets.Location = new System.Drawing.Point(241, 142);
            this.gbCharsets.Name = "gbCharsets";
            this.gbCharsets.Size = new System.Drawing.Size(286, 138);
            this.gbCharsets.TabIndex = 2;
            this.gbCharsets.TabStop = false;
            this.gbCharsets.Text = "Charsets";
            // 
            // cmbCharset4
            // 
            this.cmbCharset4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCharset4.FormattingEnabled = true;
            this.cmbCharset4.Location = new System.Drawing.Point(60, 102);
            this.cmbCharset4.Name = "cmbCharset4";
            this.cmbCharset4.Size = new System.Drawing.Size(204, 21);
            this.cmbCharset4.TabIndex = 14;
            // 
            // cmbCharset3
            // 
            this.cmbCharset3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCharset3.FormattingEnabled = true;
            this.cmbCharset3.Location = new System.Drawing.Point(60, 75);
            this.cmbCharset3.Name = "cmbCharset3";
            this.cmbCharset3.Size = new System.Drawing.Size(204, 21);
            this.cmbCharset3.TabIndex = 13;
            // 
            // cmbCharset2
            // 
            this.cmbCharset2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCharset2.FormattingEnabled = true;
            this.cmbCharset2.Location = new System.Drawing.Point(60, 48);
            this.cmbCharset2.Name = "cmbCharset2";
            this.cmbCharset2.Size = new System.Drawing.Size(204, 21);
            this.cmbCharset2.TabIndex = 12;
            // 
            // cmbCharset1
            // 
            this.cmbCharset1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCharset1.FormattingEnabled = true;
            this.cmbCharset1.Location = new System.Drawing.Point(60, 21);
            this.cmbCharset1.Name = "cmbCharset1";
            this.cmbCharset1.Size = new System.Drawing.Size(204, 21);
            this.cmbCharset1.TabIndex = 11;
            // 
            // cbCharset4
            // 
            this.cbCharset4.AutoSize = true;
            this.cbCharset4.Location = new System.Drawing.Point(19, 104);
            this.cbCharset4.Name = "cbCharset4";
            this.cbCharset4.Size = new System.Drawing.Size(35, 17);
            this.cbCharset4.TabIndex = 9;
            this.cbCharset4.Text = "-4";
            this.cbCharset4.UseVisualStyleBackColor = true;
            // 
            // cbCharset3
            // 
            this.cbCharset3.AutoSize = true;
            this.cbCharset3.Location = new System.Drawing.Point(19, 77);
            this.cbCharset3.Name = "cbCharset3";
            this.cbCharset3.Size = new System.Drawing.Size(35, 17);
            this.cbCharset3.TabIndex = 7;
            this.cbCharset3.Text = "-3";
            this.cbCharset3.UseVisualStyleBackColor = true;
            // 
            // cbCharset2
            // 
            this.cbCharset2.AutoSize = true;
            this.cbCharset2.Location = new System.Drawing.Point(19, 50);
            this.cbCharset2.Name = "cbCharset2";
            this.cbCharset2.Size = new System.Drawing.Size(35, 17);
            this.cbCharset2.TabIndex = 5;
            this.cbCharset2.Text = "-2";
            this.cbCharset2.UseVisualStyleBackColor = true;
            // 
            // cbCharset1
            // 
            this.cbCharset1.AutoSize = true;
            this.cbCharset1.Location = new System.Drawing.Point(19, 23);
            this.cbCharset1.Name = "cbCharset1";
            this.cbCharset1.Size = new System.Drawing.Size(35, 17);
            this.cbCharset1.TabIndex = 0;
            this.cbCharset1.Text = "-1";
            this.cbCharset1.UseVisualStyleBackColor = true;
            // 
            // gbAttackSource
            // 
            this.gbAttackSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAttackSource.Controls.Add(this.cmbRightSource);
            this.gbAttackSource.Controls.Add(this.cmbLeftSource);
            this.gbAttackSource.Controls.Add(this.lblRightSource);
            this.gbAttackSource.Controls.Add(this.lblLeftSource);
            this.gbAttackSource.Location = new System.Drawing.Point(241, 14);
            this.gbAttackSource.Name = "gbAttackSource";
            this.gbAttackSource.Size = new System.Drawing.Size(286, 122);
            this.gbAttackSource.TabIndex = 1;
            this.gbAttackSource.TabStop = false;
            this.gbAttackSource.Text = "Attack Source";
            // 
            // cmbRightSource
            // 
            this.cmbRightSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRightSource.Enabled = false;
            this.cmbRightSource.FormattingEnabled = true;
            this.cmbRightSource.Location = new System.Drawing.Point(39, 85);
            this.cmbRightSource.Name = "cmbRightSource";
            this.cmbRightSource.Size = new System.Drawing.Size(225, 21);
            this.cmbRightSource.TabIndex = 7;
            // 
            // cmbLeftSource
            // 
            this.cmbLeftSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLeftSource.FormattingEnabled = true;
            this.cmbLeftSource.Location = new System.Drawing.Point(39, 41);
            this.cmbLeftSource.Name = "cmbLeftSource";
            this.cmbLeftSource.Size = new System.Drawing.Size(225, 21);
            this.cmbLeftSource.TabIndex = 6;
            // 
            // lblRightSource
            // 
            this.lblRightSource.AutoSize = true;
            this.lblRightSource.Enabled = false;
            this.lblRightSource.Location = new System.Drawing.Point(16, 66);
            this.lblRightSource.Name = "lblRightSource";
            this.lblRightSource.Size = new System.Drawing.Size(85, 13);
            this.lblRightSource.TabIndex = 2;
            this.lblRightSource.Text = "Right Dictionary:";
            // 
            // lblLeftSource
            // 
            this.lblLeftSource.AutoSize = true;
            this.lblLeftSource.Location = new System.Drawing.Point(16, 22);
            this.lblLeftSource.Name = "lblLeftSource";
            this.lblLeftSource.Size = new System.Drawing.Size(57, 13);
            this.lblLeftSource.TabIndex = 0;
            this.lblLeftSource.Text = "Dictionary:";
            // 
            // gbAttackType
            // 
            this.gbAttackType.Controls.Add(this.rbMaskDict);
            this.gbAttackType.Controls.Add(this.rbDictMask);
            this.gbAttackType.Controls.Add(this.rbBruteforce);
            this.gbAttackType.Controls.Add(this.rbCombination);
            this.gbAttackType.Controls.Add(this.rbStraight);
            this.gbAttackType.Location = new System.Drawing.Point(18, 14);
            this.gbAttackType.Name = "gbAttackType";
            this.gbAttackType.Size = new System.Drawing.Size(208, 122);
            this.gbAttackType.TabIndex = 0;
            this.gbAttackType.TabStop = false;
            this.gbAttackType.Text = "Attack type ( -a,  --attack-mode )";
            // 
            // rbMaskDict
            // 
            this.rbMaskDict.AutoSize = true;
            this.rbMaskDict.Location = new System.Drawing.Point(15, 95);
            this.rbMaskDict.Name = "rbMaskDict";
            this.rbMaskDict.Size = new System.Drawing.Size(127, 17);
            this.rbMaskDict.TabIndex = 4;
            this.rbMaskDict.Text = "(7) Hybrid mask + dict";
            this.rbMaskDict.UseVisualStyleBackColor = true;
            this.rbMaskDict.CheckedChanged += new System.EventHandler(this.rbAttackType_CheckedChanged);
            // 
            // rbDictMask
            // 
            this.rbDictMask.AutoSize = true;
            this.rbDictMask.Location = new System.Drawing.Point(15, 76);
            this.rbDictMask.Name = "rbDictMask";
            this.rbDictMask.Size = new System.Drawing.Size(127, 17);
            this.rbDictMask.TabIndex = 3;
            this.rbDictMask.Text = "(6) Hybrid dict + mask";
            this.rbDictMask.UseVisualStyleBackColor = true;
            this.rbDictMask.CheckedChanged += new System.EventHandler(this.rbAttackType_CheckedChanged);
            // 
            // rbBruteforce
            // 
            this.rbBruteforce.AutoSize = true;
            this.rbBruteforce.Location = new System.Drawing.Point(15, 57);
            this.rbBruteforce.Name = "rbBruteforce";
            this.rbBruteforce.Size = new System.Drawing.Size(92, 17);
            this.rbBruteforce.TabIndex = 2;
            this.rbBruteforce.Text = "(3) Brute-force";
            this.rbBruteforce.UseVisualStyleBackColor = true;
            this.rbBruteforce.CheckedChanged += new System.EventHandler(this.rbAttackType_CheckedChanged);
            // 
            // rbCombination
            // 
            this.rbCombination.AutoSize = true;
            this.rbCombination.Location = new System.Drawing.Point(15, 38);
            this.rbCombination.Name = "rbCombination";
            this.rbCombination.Size = new System.Drawing.Size(98, 17);
            this.rbCombination.TabIndex = 1;
            this.rbCombination.Text = "(1) Combination";
            this.rbCombination.UseVisualStyleBackColor = true;
            this.rbCombination.CheckedChanged += new System.EventHandler(this.rbAttackType_CheckedChanged);
            // 
            // rbStraight
            // 
            this.rbStraight.AutoSize = true;
            this.rbStraight.Checked = true;
            this.rbStraight.Location = new System.Drawing.Point(15, 19);
            this.rbStraight.Name = "rbStraight";
            this.rbStraight.Size = new System.Drawing.Size(76, 17);
            this.rbStraight.TabIndex = 0;
            this.rbStraight.TabStop = true;
            this.rbStraight.Text = "(0) Straight";
            this.rbStraight.UseVisualStyleBackColor = true;
            this.rbStraight.CheckedChanged += new System.EventHandler(this.rbAttackType_CheckedChanged);
            // 
            // tpPredefined
            // 
            this.tpPredefined.Controls.Add(this.lvPredefined);
            this.tpPredefined.Location = new System.Drawing.Point(4, 22);
            this.tpPredefined.Name = "tpPredefined";
            this.tpPredefined.Padding = new System.Windows.Forms.Padding(3);
            this.tpPredefined.Size = new System.Drawing.Size(547, 293);
            this.tpPredefined.TabIndex = 8;
            this.tpPredefined.Text = "Predefined";
            this.tpPredefined.UseVisualStyleBackColor = true;
            // 
            // lvPredefined
            // 
            this.lvPredefined.CheckBoxes = true;
            this.lvPredefined.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPredefinedNumber,
            this.chPredefinedType,
            this.chPredefinedName,
            this.chPredefinedDescription});
            this.lvPredefined.FullRowSelect = true;
            this.lvPredefined.Location = new System.Drawing.Point(16, 15);
            this.lvPredefined.Name = "lvPredefined";
            this.lvPredefined.Size = new System.Drawing.Size(510, 260);
            this.lvPredefined.TabIndex = 0;
            this.lvPredefined.UseCompatibleStateImageBehavior = false;
            this.lvPredefined.View = System.Windows.Forms.View.Details;
            // 
            // chPredefinedNumber
            // 
            this.chPredefinedNumber.Text = "#";
            this.chPredefinedNumber.Width = 40;
            // 
            // chPredefinedType
            // 
            this.chPredefinedType.Text = "Type";
            // 
            // chPredefinedName
            // 
            this.chPredefinedName.Text = "Name";
            this.chPredefinedName.Width = 68;
            // 
            // chPredefinedDescription
            // 
            this.chPredefinedDescription.Text = "Description";
            this.chPredefinedDescription.Width = 316;
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
            this.tpMisc.Size = new System.Drawing.Size(547, 293);
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
            this.tpMarkov.Controls.Add(this.lblMarkovHcstat);
            this.tpMarkov.Controls.Add(this.cbMarkovHcstat);
            this.tpMarkov.Location = new System.Drawing.Point(4, 22);
            this.tpMarkov.Name = "tpMarkov";
            this.tpMarkov.Size = new System.Drawing.Size(547, 293);
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
            // lblMarkovHcstat
            // 
            this.lblMarkovHcstat.AutoSize = true;
            this.lblMarkovHcstat.Location = new System.Drawing.Point(45, 44);
            this.lblMarkovHcstat.Name = "lblMarkovHcstat";
            this.lblMarkovHcstat.Size = new System.Drawing.Size(38, 13);
            this.lblMarkovHcstat.TabIndex = 1;
            this.lblMarkovHcstat.Text = "FILE =";
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
            this.tpSession.Size = new System.Drawing.Size(547, 293);
            this.tpSession.TabIndex = 3;
            this.tpSession.Text = "Session";
            this.tpSession.UseVisualStyleBackColor = true;
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
            this.tpFiles.Size = new System.Drawing.Size(547, 293);
            this.tpFiles.TabIndex = 4;
            this.tpFiles.Text = "Files";
            this.tpFiles.UseVisualStyleBackColor = true;
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
            // tpResources
            // 
            this.tpResources.AutoScroll = true;
            this.tpResources.AutoScrollMargin = new System.Drawing.Size(0, 18);
            this.tpResources.Controls.Add(this.nudScryptTmto);
            this.tpResources.Controls.Add(this.lblScryptTmto);
            this.tpResources.Controls.Add(this.cbScryptTmto);
            this.tpResources.Controls.Add(this.cbPowertuneEnable);
            this.tpResources.Controls.Add(this.nudGpuTempRetain);
            this.tpResources.Controls.Add(this.lblGpuTempRetain);
            this.tpResources.Controls.Add(this.cbGpuTempRetain);
            this.tpResources.Controls.Add(this.nudGpuTempAbort);
            this.tpResources.Controls.Add(this.lblGpuTempAbort);
            this.tpResources.Controls.Add(this.cbGpuTempAbort);
            this.tpResources.Controls.Add(this.cbGpuTempDisable);
            this.tpResources.Controls.Add(this.nudGpuLoops);
            this.tpResources.Controls.Add(this.lblGpuLoops);
            this.tpResources.Controls.Add(this.cbGpuLoops);
            this.tpResources.Controls.Add(this.nudGpuAccel);
            this.tpResources.Controls.Add(this.lblGpuAccel);
            this.tpResources.Controls.Add(this.cbGpuAccel);
            this.tpResources.Controls.Add(this.nudWorkloadProfile);
            this.tpResources.Controls.Add(this.lblWorkloadProfile);
            this.tpResources.Controls.Add(this.cbWorkloadProfile);
            this.tpResources.Controls.Add(this.tbGpuDevices);
            this.tpResources.Controls.Add(this.lblGpuDevices);
            this.tpResources.Controls.Add(this.cbGpuDevices);
            this.tpResources.Controls.Add(this.cbGpuAsync);
            this.tpResources.Controls.Add(this.tbCpuAffinity);
            this.tpResources.Controls.Add(this.lblCpuAffinity);
            this.tpResources.Controls.Add(this.cbCpuAffinity);
            this.tpResources.Controls.Add(this.nudBitmapMax);
            this.tpResources.Controls.Add(this.lblBitmapMax);
            this.tpResources.Controls.Add(this.cbBitmapMax);
            this.tpResources.Controls.Add(this.nudBitmapMin);
            this.tpResources.Controls.Add(this.lblBitmapMin);
            this.tpResources.Controls.Add(this.cbBitmapMin);
            this.tpResources.Controls.Add(this.nudSegmentSize);
            this.tpResources.Controls.Add(this.lblSegmentSize);
            this.tpResources.Controls.Add(this.cbSegmentSize);
            this.tpResources.Location = new System.Drawing.Point(4, 22);
            this.tpResources.Name = "tpResources";
            this.tpResources.Size = new System.Drawing.Size(547, 293);
            this.tpResources.TabIndex = 5;
            this.tpResources.Text = "Resources";
            this.tpResources.UseVisualStyleBackColor = true;
            // 
            // nudScryptTmto
            // 
            this.nudScryptTmto.Location = new System.Drawing.Point(94, 600);
            this.nudScryptTmto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudScryptTmto.Name = "nudScryptTmto";
            this.nudScryptTmto.Size = new System.Drawing.Size(90, 20);
            this.nudScryptTmto.TabIndex = 53;
            // 
            // lblScryptTmto
            // 
            this.lblScryptTmto.AutoSize = true;
            this.lblScryptTmto.Location = new System.Drawing.Point(45, 602);
            this.lblScryptTmto.Name = "lblScryptTmto";
            this.lblScryptTmto.Size = new System.Drawing.Size(41, 13);
            this.lblScryptTmto.TabIndex = 52;
            this.lblScryptTmto.Text = "NUM =";
            // 
            // cbScryptTmto
            // 
            this.cbScryptTmto.AutoSize = true;
            this.cbScryptTmto.Location = new System.Drawing.Point(18, 577);
            this.cbScryptTmto.Name = "cbScryptTmto";
            this.cbScryptTmto.Size = new System.Drawing.Size(440, 17);
            this.cbScryptTmto.TabIndex = 51;
            this.cbScryptTmto.Text = "Manually override automatically calculated TMTO value for scrypt ( --scrypt-tmto=" +
    "NUM ):";
            this.cbScryptTmto.UseVisualStyleBackColor = true;
            // 
            // cbPowertuneEnable
            // 
            this.cbPowertuneEnable.AutoSize = true;
            this.cbPowertuneEnable.Location = new System.Drawing.Point(18, 554);
            this.cbPowertuneEnable.Name = "cbPowertuneEnable";
            this.cbPowertuneEnable.Size = new System.Drawing.Size(425, 17);
            this.cbPowertuneEnable.TabIndex = 50;
            this.cbPowertuneEnable.Text = "Enable automatic power tuning option, AMD OverDrive 6 only ( --powertune-enable )" +
    ":";
            this.cbPowertuneEnable.UseVisualStyleBackColor = true;
            // 
            // nudGpuTempRetain
            // 
            this.nudGpuTempRetain.Location = new System.Drawing.Point(94, 528);
            this.nudGpuTempRetain.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudGpuTempRetain.Name = "nudGpuTempRetain";
            this.nudGpuTempRetain.Size = new System.Drawing.Size(90, 20);
            this.nudGpuTempRetain.TabIndex = 49;
            this.nudGpuTempRetain.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // lblGpuTempRetain
            // 
            this.lblGpuTempRetain.AutoSize = true;
            this.lblGpuTempRetain.Location = new System.Drawing.Point(45, 530);
            this.lblGpuTempRetain.Name = "lblGpuTempRetain";
            this.lblGpuTempRetain.Size = new System.Drawing.Size(41, 13);
            this.lblGpuTempRetain.TabIndex = 48;
            this.lblGpuTempRetain.Text = "NUM =";
            // 
            // cbGpuTempRetain
            // 
            this.cbGpuTempRetain.AutoSize = true;
            this.cbGpuTempRetain.Location = new System.Drawing.Point(18, 505);
            this.cbGpuTempRetain.Name = "cbGpuTempRetain";
            this.cbGpuTempRetain.Size = new System.Drawing.Size(463, 17);
            this.cbGpuTempRetain.TabIndex = 47;
            this.cbGpuTempRetain.Text = "Try to retain GPU temperature at NUM degrees celsius, AMD only ( --gpu-temp-retai" +
    "n=NUM ):";
            this.cbGpuTempRetain.UseVisualStyleBackColor = true;
            // 
            // nudGpuTempAbort
            // 
            this.nudGpuTempAbort.Location = new System.Drawing.Point(94, 479);
            this.nudGpuTempAbort.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudGpuTempAbort.Name = "nudGpuTempAbort";
            this.nudGpuTempAbort.Size = new System.Drawing.Size(90, 20);
            this.nudGpuTempAbort.TabIndex = 46;
            this.nudGpuTempAbort.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // lblGpuTempAbort
            // 
            this.lblGpuTempAbort.AutoSize = true;
            this.lblGpuTempAbort.Location = new System.Drawing.Point(45, 481);
            this.lblGpuTempAbort.Name = "lblGpuTempAbort";
            this.lblGpuTempAbort.Size = new System.Drawing.Size(41, 13);
            this.lblGpuTempAbort.TabIndex = 45;
            this.lblGpuTempAbort.Text = "NUM =";
            // 
            // cbGpuTempAbort
            // 
            this.cbGpuTempAbort.AutoSize = true;
            this.cbGpuTempAbort.Location = new System.Drawing.Point(18, 456);
            this.cbGpuTempAbort.Name = "cbGpuTempAbort";
            this.cbGpuTempAbort.Size = new System.Drawing.Size(453, 17);
            this.cbGpuTempAbort.TabIndex = 44;
            this.cbGpuTempAbort.Text = "Abort session if GPU temperature reaches NUM degrees celsius ( --gpu-temp-abort=N" +
    "UM ):";
            this.cbGpuTempAbort.UseVisualStyleBackColor = true;
            // 
            // cbGpuTempDisable
            // 
            this.cbGpuTempDisable.AutoSize = true;
            this.cbGpuTempDisable.Location = new System.Drawing.Point(18, 433);
            this.cbGpuTempDisable.Name = "cbGpuTempDisable";
            this.cbGpuTempDisable.Size = new System.Drawing.Size(390, 17);
            this.cbGpuTempDisable.TabIndex = 43;
            this.cbGpuTempDisable.Text = "Disable temperature and fanspeed readings and triggers ( --gpu-temp-disable )";
            this.cbGpuTempDisable.UseVisualStyleBackColor = true;
            // 
            // nudGpuLoops
            // 
            this.nudGpuLoops.Location = new System.Drawing.Point(94, 407);
            this.nudGpuLoops.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudGpuLoops.Name = "nudGpuLoops";
            this.nudGpuLoops.Size = new System.Drawing.Size(90, 20);
            this.nudGpuLoops.TabIndex = 42;
            // 
            // lblGpuLoops
            // 
            this.lblGpuLoops.AutoSize = true;
            this.lblGpuLoops.Location = new System.Drawing.Point(45, 409);
            this.lblGpuLoops.Name = "lblGpuLoops";
            this.lblGpuLoops.Size = new System.Drawing.Size(41, 13);
            this.lblGpuLoops.TabIndex = 41;
            this.lblGpuLoops.Text = "NUM =";
            // 
            // cbGpuLoops
            // 
            this.cbGpuLoops.AutoSize = true;
            this.cbGpuLoops.Location = new System.Drawing.Point(18, 384);
            this.cbGpuLoops.Name = "cbGpuLoops";
            this.cbGpuLoops.Size = new System.Drawing.Size(243, 17);
            this.cbGpuLoops.TabIndex = 40;
            this.cbGpuLoops.Text = "Workload fine-tuning ( -u,  --gpu-loops=NUM ):";
            this.cbGpuLoops.UseVisualStyleBackColor = true;
            // 
            // nudGpuAccel
            // 
            this.nudGpuAccel.Location = new System.Drawing.Point(94, 358);
            this.nudGpuAccel.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudGpuAccel.Name = "nudGpuAccel";
            this.nudGpuAccel.Size = new System.Drawing.Size(90, 20);
            this.nudGpuAccel.TabIndex = 39;
            // 
            // lblGpuAccel
            // 
            this.lblGpuAccel.AutoSize = true;
            this.lblGpuAccel.Location = new System.Drawing.Point(45, 360);
            this.lblGpuAccel.Name = "lblGpuAccel";
            this.lblGpuAccel.Size = new System.Drawing.Size(41, 13);
            this.lblGpuAccel.TabIndex = 38;
            this.lblGpuAccel.Text = "NUM =";
            // 
            // cbGpuAccel
            // 
            this.cbGpuAccel.AutoSize = true;
            this.cbGpuAccel.Location = new System.Drawing.Point(18, 335);
            this.cbGpuAccel.Name = "cbGpuAccel";
            this.cbGpuAccel.Size = new System.Drawing.Size(224, 17);
            this.cbGpuAccel.TabIndex = 37;
            this.cbGpuAccel.Text = "Workload tuning ( -n,  --gpu-accel=NUM ):";
            this.cbGpuAccel.UseVisualStyleBackColor = true;
            // 
            // nudWorkloadProfile
            // 
            this.nudWorkloadProfile.Location = new System.Drawing.Point(94, 309);
            this.nudWorkloadProfile.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudWorkloadProfile.Name = "nudWorkloadProfile";
            this.nudWorkloadProfile.Size = new System.Drawing.Size(90, 20);
            this.nudWorkloadProfile.TabIndex = 36;
            this.nudWorkloadProfile.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblWorkloadProfile
            // 
            this.lblWorkloadProfile.AutoSize = true;
            this.lblWorkloadProfile.Location = new System.Drawing.Point(45, 311);
            this.lblWorkloadProfile.Name = "lblWorkloadProfile";
            this.lblWorkloadProfile.Size = new System.Drawing.Size(41, 13);
            this.lblWorkloadProfile.TabIndex = 35;
            this.lblWorkloadProfile.Text = "NUM =";
            // 
            // cbWorkloadProfile
            // 
            this.cbWorkloadProfile.AutoSize = true;
            this.cbWorkloadProfile.Location = new System.Drawing.Point(18, 286);
            this.cbWorkloadProfile.Name = "cbWorkloadProfile";
            this.cbWorkloadProfile.Size = new System.Drawing.Size(333, 17);
            this.cbWorkloadProfile.TabIndex = 34;
            this.cbWorkloadProfile.Text = "Enable a specific workload profile ( -w,  --workload-profile=NUM ):";
            this.cbWorkloadProfile.UseVisualStyleBackColor = true;
            // 
            // tbGpuDevices
            // 
            this.tbGpuDevices.Location = new System.Drawing.Point(94, 260);
            this.tbGpuDevices.Name = "tbGpuDevices";
            this.tbGpuDevices.Size = new System.Drawing.Size(255, 20);
            this.tbGpuDevices.TabIndex = 33;
            // 
            // lblGpuDevices
            // 
            this.lblGpuDevices.AutoSize = true;
            this.lblGpuDevices.Location = new System.Drawing.Point(45, 263);
            this.lblGpuDevices.Name = "lblGpuDevices";
            this.lblGpuDevices.Size = new System.Drawing.Size(38, 13);
            this.lblGpuDevices.TabIndex = 32;
            this.lblGpuDevices.Text = "STR =";
            // 
            // cbGpuDevices
            // 
            this.cbGpuDevices.AutoSize = true;
            this.cbGpuDevices.Location = new System.Drawing.Point(18, 237);
            this.cbGpuDevices.Name = "cbGpuDevices";
            this.cbGpuDevices.Size = new System.Drawing.Size(331, 17);
            this.cbGpuDevices.TabIndex = 31;
            this.cbGpuDevices.Text = "Devices to use, separate with comma ( -d,  --gpu-devices=STR ):";
            this.cbGpuDevices.UseVisualStyleBackColor = true;
            // 
            // cbGpuAsync
            // 
            this.cbGpuAsync.AutoSize = true;
            this.cbGpuAsync.Location = new System.Drawing.Point(18, 214);
            this.cbGpuAsync.Name = "cbGpuAsync";
            this.cbGpuAsync.Size = new System.Drawing.Size(277, 17);
            this.cbGpuAsync.TabIndex = 30;
            this.cbGpuAsync.Text = "Use non-blocking async calls, NV only ( --gpu-async )";
            this.cbGpuAsync.UseVisualStyleBackColor = true;
            // 
            // tbCpuAffinity
            // 
            this.tbCpuAffinity.Location = new System.Drawing.Point(94, 188);
            this.tbCpuAffinity.Name = "tbCpuAffinity";
            this.tbCpuAffinity.Size = new System.Drawing.Size(255, 20);
            this.tbCpuAffinity.TabIndex = 29;
            // 
            // lblCpuAffinity
            // 
            this.lblCpuAffinity.AutoSize = true;
            this.lblCpuAffinity.Location = new System.Drawing.Point(45, 191);
            this.lblCpuAffinity.Name = "lblCpuAffinity";
            this.lblCpuAffinity.Size = new System.Drawing.Size(38, 13);
            this.lblCpuAffinity.TabIndex = 28;
            this.lblCpuAffinity.Text = "STR =";
            // 
            // cbCpuAffinity
            // 
            this.cbCpuAffinity.AutoSize = true;
            this.cbCpuAffinity.Location = new System.Drawing.Point(18, 165);
            this.cbCpuAffinity.Name = "cbCpuAffinity";
            this.cbCpuAffinity.Size = new System.Drawing.Size(341, 17);
            this.cbCpuAffinity.TabIndex = 27;
            this.cbCpuAffinity.Text = "Locks to CPU devices, seperate with comma ( --cpu-affinity=STR ):";
            this.cbCpuAffinity.UseVisualStyleBackColor = true;
            // 
            // nudBitmapMax
            // 
            this.nudBitmapMax.Location = new System.Drawing.Point(94, 139);
            this.nudBitmapMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBitmapMax.Name = "nudBitmapMax";
            this.nudBitmapMax.Size = new System.Drawing.Size(90, 20);
            this.nudBitmapMax.TabIndex = 26;
            // 
            // lblBitmapMax
            // 
            this.lblBitmapMax.AutoSize = true;
            this.lblBitmapMax.Location = new System.Drawing.Point(45, 141);
            this.lblBitmapMax.Name = "lblBitmapMax";
            this.lblBitmapMax.Size = new System.Drawing.Size(41, 13);
            this.lblBitmapMax.TabIndex = 25;
            this.lblBitmapMax.Text = "NUM =";
            // 
            // cbBitmapMax
            // 
            this.cbBitmapMax.AutoSize = true;
            this.cbBitmapMax.Location = new System.Drawing.Point(18, 116);
            this.cbBitmapMax.Name = "cbBitmapMax";
            this.cbBitmapMax.Size = new System.Drawing.Size(340, 17);
            this.cbBitmapMax.TabIndex = 24;
            this.cbBitmapMax.Text = "Maximum number of bits allowed for bitmaps ( --bitmap-max=NUM ):";
            this.cbBitmapMax.UseVisualStyleBackColor = true;
            // 
            // nudBitmapMin
            // 
            this.nudBitmapMin.Location = new System.Drawing.Point(94, 90);
            this.nudBitmapMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBitmapMin.Name = "nudBitmapMin";
            this.nudBitmapMin.Size = new System.Drawing.Size(90, 20);
            this.nudBitmapMin.TabIndex = 23;
            // 
            // lblBitmapMin
            // 
            this.lblBitmapMin.AutoSize = true;
            this.lblBitmapMin.Location = new System.Drawing.Point(45, 92);
            this.lblBitmapMin.Name = "lblBitmapMin";
            this.lblBitmapMin.Size = new System.Drawing.Size(41, 13);
            this.lblBitmapMin.TabIndex = 22;
            this.lblBitmapMin.Text = "NUM =";
            // 
            // cbBitmapMin
            // 
            this.cbBitmapMin.AutoSize = true;
            this.cbBitmapMin.Location = new System.Drawing.Point(18, 67);
            this.cbBitmapMin.Name = "cbBitmapMin";
            this.cbBitmapMin.Size = new System.Drawing.Size(334, 17);
            this.cbBitmapMin.TabIndex = 21;
            this.cbBitmapMin.Text = "Minimum number of bits allowed for bitmaps ( --bitmap-min=NUM ):";
            this.cbBitmapMin.UseVisualStyleBackColor = true;
            // 
            // nudSegmentSize
            // 
            this.nudSegmentSize.Location = new System.Drawing.Point(94, 41);
            this.nudSegmentSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSegmentSize.Name = "nudSegmentSize";
            this.nudSegmentSize.Size = new System.Drawing.Size(90, 20);
            this.nudSegmentSize.TabIndex = 20;
            this.nudSegmentSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSegmentSize
            // 
            this.lblSegmentSize.AutoSize = true;
            this.lblSegmentSize.Location = new System.Drawing.Point(45, 43);
            this.lblSegmentSize.Name = "lblSegmentSize";
            this.lblSegmentSize.Size = new System.Drawing.Size(41, 13);
            this.lblSegmentSize.TabIndex = 19;
            this.lblSegmentSize.Text = "NUM =";
            // 
            // cbSegmentSize
            // 
            this.cbSegmentSize.AutoSize = true;
            this.cbSegmentSize.Location = new System.Drawing.Point(18, 18);
            this.cbSegmentSize.Name = "cbSegmentSize";
            this.cbSegmentSize.Size = new System.Drawing.Size(335, 17);
            this.cbSegmentSize.TabIndex = 18;
            this.cbSegmentSize.Text = "Size in MB to cache from the wordfile ( -c,  --segment-size=NUM ):";
            this.cbSegmentSize.UseVisualStyleBackColor = true;
            // 
            // tpDistributed
            // 
            this.tpDistributed.Controls.Add(this.nudLimit);
            this.tpDistributed.Controls.Add(this.lblLimit);
            this.tpDistributed.Controls.Add(this.cbLimit);
            this.tpDistributed.Controls.Add(this.nudSkip);
            this.tpDistributed.Controls.Add(this.lblSkip);
            this.tpDistributed.Controls.Add(this.cbSkip);
            this.tpDistributed.Location = new System.Drawing.Point(4, 22);
            this.tpDistributed.Name = "tpDistributed";
            this.tpDistributed.Size = new System.Drawing.Size(547, 293);
            this.tpDistributed.TabIndex = 6;
            this.tpDistributed.Text = "Distributed";
            this.tpDistributed.UseVisualStyleBackColor = true;
            // 
            // nudLimit
            // 
            this.nudLimit.Location = new System.Drawing.Point(94, 90);
            this.nudLimit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(90, 20);
            this.nudLimit.TabIndex = 45;
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(45, 92);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(41, 13);
            this.lblLimit.TabIndex = 44;
            this.lblLimit.Text = "NUM =";
            // 
            // cbLimit
            // 
            this.cbLimit.AutoSize = true;
            this.cbLimit.Location = new System.Drawing.Point(18, 67);
            this.cbLimit.Name = "cbLimit";
            this.cbLimit.Size = new System.Drawing.Size(214, 17);
            this.cbLimit.TabIndex = 43;
            this.cbLimit.Text = "Limit number of words ( -l,  --limit=NUM ):";
            this.cbLimit.UseVisualStyleBackColor = true;
            // 
            // nudSkip
            // 
            this.nudSkip.Location = new System.Drawing.Point(94, 41);
            this.nudSkip.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSkip.Name = "nudSkip";
            this.nudSkip.Size = new System.Drawing.Size(90, 20);
            this.nudSkip.TabIndex = 42;
            // 
            // lblSkip
            // 
            this.lblSkip.AutoSize = true;
            this.lblSkip.Location = new System.Drawing.Point(45, 43);
            this.lblSkip.Name = "lblSkip";
            this.lblSkip.Size = new System.Drawing.Size(41, 13);
            this.lblSkip.TabIndex = 41;
            this.lblSkip.Text = "NUM =";
            // 
            // cbSkip
            // 
            this.cbSkip.AutoSize = true;
            this.cbSkip.Location = new System.Drawing.Point(18, 18);
            this.cbSkip.Name = "cbSkip";
            this.cbSkip.Size = new System.Drawing.Size(219, 17);
            this.cbSkip.TabIndex = 40;
            this.cbSkip.Text = "Skip number of words ( -s,  --skip=NUM ):";
            this.cbSkip.UseVisualStyleBackColor = true;
            // 
            // tpRules
            // 
            this.tpRules.AutoScroll = true;
            this.tpRules.AutoScrollMargin = new System.Drawing.Size(0, 18);
            this.tpRules.Controls.Add(this.nudGenerateRulesSeed);
            this.tpRules.Controls.Add(this.lblGenerateRulesSeed);
            this.tpRules.Controls.Add(this.cbGenerateRulesSeed);
            this.tpRules.Controls.Add(this.nudGenerateRulesFuncMax);
            this.tpRules.Controls.Add(this.lblGenerateRulesFuncMax);
            this.tpRules.Controls.Add(this.cbGenerateRulesFuncMax);
            this.tpRules.Controls.Add(this.nudGenerateRulesFuncMin);
            this.tpRules.Controls.Add(this.lblGenerateRulesFuncMin);
            this.tpRules.Controls.Add(this.cbGenerateRulesFuncMin);
            this.tpRules.Controls.Add(this.nudGenerateRules);
            this.tpRules.Controls.Add(this.lblGenerateRules);
            this.tpRules.Controls.Add(this.cbGenerateRules);
            this.tpRules.Controls.Add(this.tbRulesFiles);
            this.tpRules.Controls.Add(this.lblRulesFiles);
            this.tpRules.Controls.Add(this.cbRulesFiles);
            this.tpRules.Controls.Add(this.tbRuleRight);
            this.tpRules.Controls.Add(this.lblRuleRight);
            this.tpRules.Controls.Add(this.cbRuleRight);
            this.tpRules.Controls.Add(this.tbRuleLeft);
            this.tpRules.Controls.Add(this.lblRuleLeft);
            this.tpRules.Controls.Add(this.cbRuleLeft);
            this.tpRules.Location = new System.Drawing.Point(4, 22);
            this.tpRules.Name = "tpRules";
            this.tpRules.Size = new System.Drawing.Size(547, 293);
            this.tpRules.TabIndex = 7;
            this.tpRules.Text = "Rules";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // nudGenerateRulesSeed
            // 
            this.nudGenerateRulesSeed.Location = new System.Drawing.Point(94, 335);
            this.nudGenerateRulesSeed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudGenerateRulesSeed.Name = "nudGenerateRulesSeed";
            this.nudGenerateRulesSeed.Size = new System.Drawing.Size(90, 20);
            this.nudGenerateRulesSeed.TabIndex = 62;
            // 
            // lblGenerateRulesSeed
            // 
            this.lblGenerateRulesSeed.AutoSize = true;
            this.lblGenerateRulesSeed.Location = new System.Drawing.Point(45, 337);
            this.lblGenerateRulesSeed.Name = "lblGenerateRulesSeed";
            this.lblGenerateRulesSeed.Size = new System.Drawing.Size(41, 13);
            this.lblGenerateRulesSeed.TabIndex = 61;
            this.lblGenerateRulesSeed.Text = "NUM =";
            // 
            // cbGenerateRulesSeed
            // 
            this.cbGenerateRulesSeed.AutoSize = true;
            this.cbGenerateRulesSeed.Location = new System.Drawing.Point(18, 312);
            this.cbGenerateRulesSeed.Name = "cbGenerateRulesSeed";
            this.cbGenerateRulesSeed.Size = new System.Drawing.Size(294, 17);
            this.cbGenerateRulesSeed.TabIndex = 60;
            this.cbGenerateRulesSeed.Text = "Force RNG seed to NUM ( --generate-rules-seed=NUM ):";
            this.cbGenerateRulesSeed.UseVisualStyleBackColor = true;
            // 
            // nudGenerateRulesFuncMax
            // 
            this.nudGenerateRulesFuncMax.Location = new System.Drawing.Point(94, 286);
            this.nudGenerateRulesFuncMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudGenerateRulesFuncMax.Name = "nudGenerateRulesFuncMax";
            this.nudGenerateRulesFuncMax.Size = new System.Drawing.Size(90, 20);
            this.nudGenerateRulesFuncMax.TabIndex = 59;
            // 
            // lblGenerateRulesFuncMax
            // 
            this.lblGenerateRulesFuncMax.AutoSize = true;
            this.lblGenerateRulesFuncMax.Location = new System.Drawing.Point(45, 288);
            this.lblGenerateRulesFuncMax.Name = "lblGenerateRulesFuncMax";
            this.lblGenerateRulesFuncMax.Size = new System.Drawing.Size(41, 13);
            this.lblGenerateRulesFuncMax.TabIndex = 58;
            this.lblGenerateRulesFuncMax.Text = "NUM =";
            // 
            // cbGenerateRulesFuncMax
            // 
            this.cbGenerateRulesFuncMax.AutoSize = true;
            this.cbGenerateRulesFuncMax.Location = new System.Drawing.Point(18, 263);
            this.cbGenerateRulesFuncMax.Name = "cbGenerateRulesFuncMax";
            this.cbGenerateRulesFuncMax.Size = new System.Drawing.Size(393, 17);
            this.cbGenerateRulesFuncMax.TabIndex = 57;
            this.cbGenerateRulesFuncMax.Text = "Force NUM functions per random rule max ( --generate-rules-func-max=NUM ):";
            this.cbGenerateRulesFuncMax.UseVisualStyleBackColor = true;
            // 
            // nudGenerateRulesFuncMin
            // 
            this.nudGenerateRulesFuncMin.Location = new System.Drawing.Point(94, 237);
            this.nudGenerateRulesFuncMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudGenerateRulesFuncMin.Name = "nudGenerateRulesFuncMin";
            this.nudGenerateRulesFuncMin.Size = new System.Drawing.Size(90, 20);
            this.nudGenerateRulesFuncMin.TabIndex = 56;
            // 
            // lblGenerateRulesFuncMin
            // 
            this.lblGenerateRulesFuncMin.AutoSize = true;
            this.lblGenerateRulesFuncMin.Location = new System.Drawing.Point(45, 239);
            this.lblGenerateRulesFuncMin.Name = "lblGenerateRulesFuncMin";
            this.lblGenerateRulesFuncMin.Size = new System.Drawing.Size(41, 13);
            this.lblGenerateRulesFuncMin.TabIndex = 55;
            this.lblGenerateRulesFuncMin.Text = "NUM =";
            // 
            // cbGenerateRulesFuncMin
            // 
            this.cbGenerateRulesFuncMin.AutoSize = true;
            this.cbGenerateRulesFuncMin.Location = new System.Drawing.Point(18, 214);
            this.cbGenerateRulesFuncMin.Name = "cbGenerateRulesFuncMin";
            this.cbGenerateRulesFuncMin.Size = new System.Drawing.Size(387, 17);
            this.cbGenerateRulesFuncMin.TabIndex = 54;
            this.cbGenerateRulesFuncMin.Text = "Force NUM functions per random rule min ( --generate-rules-func-min=NUM ):";
            this.cbGenerateRulesFuncMin.UseVisualStyleBackColor = true;
            // 
            // nudGenerateRules
            // 
            this.nudGenerateRules.Location = new System.Drawing.Point(94, 188);
            this.nudGenerateRules.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudGenerateRules.Name = "nudGenerateRules";
            this.nudGenerateRules.Size = new System.Drawing.Size(90, 20);
            this.nudGenerateRules.TabIndex = 53;
            // 
            // lblGenerateRules
            // 
            this.lblGenerateRules.AutoSize = true;
            this.lblGenerateRules.Location = new System.Drawing.Point(45, 190);
            this.lblGenerateRules.Name = "lblGenerateRules";
            this.lblGenerateRules.Size = new System.Drawing.Size(41, 13);
            this.lblGenerateRules.TabIndex = 52;
            this.lblGenerateRules.Text = "NUM =";
            // 
            // cbGenerateRules
            // 
            this.cbGenerateRules.AutoSize = true;
            this.cbGenerateRules.Location = new System.Drawing.Point(18, 165);
            this.cbGenerateRules.Name = "cbGenerateRules";
            this.cbGenerateRules.Size = new System.Drawing.Size(301, 17);
            this.cbGenerateRules.TabIndex = 51;
            this.cbGenerateRules.Text = "Generate NUM random rules ( -g,  --generate-rules=NUM ):";
            this.cbGenerateRules.UseVisualStyleBackColor = true;
            // 
            // tbRulesFiles
            // 
            this.tbRulesFiles.Location = new System.Drawing.Point(94, 139);
            this.tbRulesFiles.Name = "tbRulesFiles";
            this.tbRulesFiles.Size = new System.Drawing.Size(255, 20);
            this.tbRulesFiles.TabIndex = 50;
            // 
            // lblRulesFiles
            // 
            this.lblRulesFiles.AutoSize = true;
            this.lblRulesFiles.Location = new System.Drawing.Point(45, 142);
            this.lblRulesFiles.Name = "lblRulesFiles";
            this.lblRulesFiles.Size = new System.Drawing.Size(38, 13);
            this.lblRulesFiles.TabIndex = 49;
            this.lblRulesFiles.Text = "FILE =";
            // 
            // cbRulesFiles
            // 
            this.cbRulesFiles.AutoSize = true;
            this.cbRulesFiles.Location = new System.Drawing.Point(18, 116);
            this.cbRulesFiles.Name = "cbRulesFiles";
            this.cbRulesFiles.Size = new System.Drawing.Size(285, 17);
            this.cbRulesFiles.TabIndex = 48;
            this.cbRulesFiles.Text = "Rules-files, separate with comma ( -r,  --rules-file=FILE ):";
            this.cbRulesFiles.UseVisualStyleBackColor = true;
            // 
            // tbRuleRight
            // 
            this.tbRuleRight.Location = new System.Drawing.Point(94, 90);
            this.tbRuleRight.Name = "tbRuleRight";
            this.tbRuleRight.Size = new System.Drawing.Size(255, 20);
            this.tbRuleRight.TabIndex = 47;
            // 
            // lblRuleRight
            // 
            this.lblRuleRight.AutoSize = true;
            this.lblRuleRight.Location = new System.Drawing.Point(45, 93);
            this.lblRuleRight.Name = "lblRuleRight";
            this.lblRuleRight.Size = new System.Drawing.Size(45, 13);
            this.lblRuleRight.TabIndex = 46;
            this.lblRuleRight.Text = "RULE =";
            // 
            // cbRuleRight
            // 
            this.cbRuleRight.AutoSize = true;
            this.cbRuleRight.Location = new System.Drawing.Point(18, 67);
            this.cbRuleRight.Name = "cbRuleRight";
            this.cbRuleRight.Size = new System.Drawing.Size(360, 17);
            this.cbRuleRight.TabIndex = 45;
            this.cbRuleRight.Text = "Single rule applied to each word from right dict ( -k,  --rule-right=RULE ):";
            this.cbRuleRight.UseVisualStyleBackColor = true;
            // 
            // tbRuleLeft
            // 
            this.tbRuleLeft.Location = new System.Drawing.Point(94, 41);
            this.tbRuleLeft.Name = "tbRuleLeft";
            this.tbRuleLeft.Size = new System.Drawing.Size(255, 20);
            this.tbRuleLeft.TabIndex = 44;
            // 
            // lblRuleLeft
            // 
            this.lblRuleLeft.AutoSize = true;
            this.lblRuleLeft.Location = new System.Drawing.Point(45, 44);
            this.lblRuleLeft.Name = "lblRuleLeft";
            this.lblRuleLeft.Size = new System.Drawing.Size(45, 13);
            this.lblRuleLeft.TabIndex = 43;
            this.lblRuleLeft.Text = "RULE =";
            // 
            // cbRuleLeft
            // 
            this.cbRuleLeft.AutoSize = true;
            this.cbRuleLeft.Location = new System.Drawing.Point(18, 18);
            this.cbRuleLeft.Name = "cbRuleLeft";
            this.cbRuleLeft.Size = new System.Drawing.Size(344, 17);
            this.cbRuleLeft.TabIndex = 42;
            this.cbRuleLeft.Text = "Single rule applied to each word from left dict ( -j,  --rule-left=RULE ):";
            this.cbRuleLeft.UseVisualStyleBackColor = true;
            // 
            // lblHashType
            // 
            this.lblHashType.AutoSize = true;
            this.lblHashType.Location = new System.Drawing.Point(13, 69);
            this.lblHashType.Name = "lblHashType";
            this.lblHashType.Size = new System.Drawing.Size(58, 13);
            this.lblHashType.TabIndex = 5;
            this.lblHashType.Text = "Hash type:";
            // 
            // cmbHashType
            // 
            this.cmbHashType.FormattingEnabled = true;
            this.cmbHashType.Location = new System.Drawing.Point(73, 66);
            this.cmbHashType.Name = "cmbHashType";
            this.cmbHashType.Size = new System.Drawing.Size(201, 21);
            this.cmbHashType.TabIndex = 4;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(13, 42);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(41, 13);
            this.lblTarget.TabIndex = 3;
            this.lblTarget.Text = "Target:";
            // 
            // cmbTarget
            // 
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Location = new System.Drawing.Point(73, 39);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(201, 21);
            this.cmbTarget.TabIndex = 2;
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(13, 15);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(54, 13);
            this.lblTemplate.TabIndex = 1;
            this.lblTemplate.Text = "Template:";
            // 
            // cmbTemplate
            // 
            this.cmbTemplate.FormattingEnabled = true;
            this.cmbTemplate.Location = new System.Drawing.Point(73, 12);
            this.cmbTemplate.Name = "cmbTemplate";
            this.cmbTemplate.Size = new System.Drawing.Size(201, 21);
            this.cmbTemplate.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(317, 12);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(246, 75);
            this.textBox4.TabIndex = 6;
            // 
            // TaskEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 433);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblHashType);
            this.Controls.Add(this.tcTaskOptions);
            this.Controls.Add(this.cmbHashType);
            this.Controls.Add(this.lblTemplate);
            this.Controls.Add(this.cmbTarget);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.cmbTemplate);
            this.Name = "TaskEditorForm";
            this.Text = "TaskEditorForm";
            this.tcTaskOptions.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.gbIncrementMode.ResumeLayout(false);
            this.gbIncrementMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncrementMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncrementMin)).EndInit();
            this.gbCharsets.ResumeLayout(false);
            this.gbCharsets.PerformLayout();
            this.gbAttackSource.ResumeLayout(false);
            this.gbAttackSource.PerformLayout();
            this.gbAttackType.ResumeLayout(false);
            this.gbAttackType.PerformLayout();
            this.tpPredefined.ResumeLayout(false);
            this.tpMisc.ResumeLayout(false);
            this.tpMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeakHashThreshold)).EndInit();
            this.tpMarkov.ResumeLayout(false);
            this.tpMarkov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkovThreshold)).EndInit();
            this.tpSession.ResumeLayout(false);
            this.tpSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRuntime)).EndInit();
            this.tpFiles.ResumeLayout(false);
            this.tpFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDebugMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutfileCheckTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutfileFormat)).EndInit();
            this.tpResources.ResumeLayout(false);
            this.tpResources.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScryptTmto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGpuTempRetain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGpuTempAbort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGpuLoops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGpuAccel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorkloadProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBitmapMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBitmapMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegmentSize)).EndInit();
            this.tpDistributed.ResumeLayout(false);
            this.tpDistributed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkip)).EndInit();
            this.tpRules.ResumeLayout(false);
            this.tpRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenerateRulesSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenerateRulesFuncMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenerateRulesFuncMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenerateRules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcTaskOptions;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tpMisc;
        private System.Windows.Forms.Label lblHashType;
        private System.Windows.Forms.ComboBox cmbHashType;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.ComboBox cmbTarget;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.ComboBox cmbTemplate;
        private System.Windows.Forms.TabPage tpMarkov;
        private System.Windows.Forms.TabPage tpSession;
        private System.Windows.Forms.TabPage tpFiles;
        private System.Windows.Forms.TabPage tpResources;
        private System.Windows.Forms.TabPage tpDistributed;
        private System.Windows.Forms.TabPage tpRules;
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
        private System.Windows.Forms.Label lblMarkovHcstat;
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
        private System.Windows.Forms.NumericUpDown nudScryptTmto;
        private System.Windows.Forms.Label lblScryptTmto;
        private System.Windows.Forms.CheckBox cbScryptTmto;
        private System.Windows.Forms.CheckBox cbPowertuneEnable;
        private System.Windows.Forms.NumericUpDown nudGpuTempRetain;
        private System.Windows.Forms.Label lblGpuTempRetain;
        private System.Windows.Forms.CheckBox cbGpuTempRetain;
        private System.Windows.Forms.NumericUpDown nudGpuTempAbort;
        private System.Windows.Forms.Label lblGpuTempAbort;
        private System.Windows.Forms.CheckBox cbGpuTempAbort;
        private System.Windows.Forms.CheckBox cbGpuTempDisable;
        private System.Windows.Forms.NumericUpDown nudGpuLoops;
        private System.Windows.Forms.Label lblGpuLoops;
        private System.Windows.Forms.CheckBox cbGpuLoops;
        private System.Windows.Forms.NumericUpDown nudGpuAccel;
        private System.Windows.Forms.Label lblGpuAccel;
        private System.Windows.Forms.CheckBox cbGpuAccel;
        private System.Windows.Forms.NumericUpDown nudWorkloadProfile;
        private System.Windows.Forms.Label lblWorkloadProfile;
        private System.Windows.Forms.CheckBox cbWorkloadProfile;
        private System.Windows.Forms.TextBox tbGpuDevices;
        private System.Windows.Forms.Label lblGpuDevices;
        private System.Windows.Forms.CheckBox cbGpuDevices;
        private System.Windows.Forms.CheckBox cbGpuAsync;
        private System.Windows.Forms.TextBox tbCpuAffinity;
        private System.Windows.Forms.Label lblCpuAffinity;
        private System.Windows.Forms.CheckBox cbCpuAffinity;
        private System.Windows.Forms.NumericUpDown nudBitmapMax;
        private System.Windows.Forms.Label lblBitmapMax;
        private System.Windows.Forms.CheckBox cbBitmapMax;
        private System.Windows.Forms.NumericUpDown nudBitmapMin;
        private System.Windows.Forms.Label lblBitmapMin;
        private System.Windows.Forms.CheckBox cbBitmapMin;
        private System.Windows.Forms.NumericUpDown nudSegmentSize;
        private System.Windows.Forms.Label lblSegmentSize;
        private System.Windows.Forms.CheckBox cbSegmentSize;
        private System.Windows.Forms.NumericUpDown nudLimit;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.CheckBox cbLimit;
        private System.Windows.Forms.NumericUpDown nudSkip;
        private System.Windows.Forms.Label lblSkip;
        private System.Windows.Forms.CheckBox cbSkip;
        private System.Windows.Forms.NumericUpDown nudGenerateRulesSeed;
        private System.Windows.Forms.Label lblGenerateRulesSeed;
        private System.Windows.Forms.CheckBox cbGenerateRulesSeed;
        private System.Windows.Forms.NumericUpDown nudGenerateRulesFuncMax;
        private System.Windows.Forms.Label lblGenerateRulesFuncMax;
        private System.Windows.Forms.CheckBox cbGenerateRulesFuncMax;
        private System.Windows.Forms.NumericUpDown nudGenerateRulesFuncMin;
        private System.Windows.Forms.Label lblGenerateRulesFuncMin;
        private System.Windows.Forms.CheckBox cbGenerateRulesFuncMin;
        private System.Windows.Forms.NumericUpDown nudGenerateRules;
        private System.Windows.Forms.Label lblGenerateRules;
        private System.Windows.Forms.CheckBox cbGenerateRules;
        private System.Windows.Forms.TextBox tbRulesFiles;
        private System.Windows.Forms.Label lblRulesFiles;
        private System.Windows.Forms.CheckBox cbRulesFiles;
        private System.Windows.Forms.TextBox tbRuleRight;
        private System.Windows.Forms.Label lblRuleRight;
        private System.Windows.Forms.CheckBox cbRuleRight;
        private System.Windows.Forms.TextBox tbRuleLeft;
        private System.Windows.Forms.Label lblRuleLeft;
        private System.Windows.Forms.CheckBox cbRuleLeft;
        private System.Windows.Forms.GroupBox gbAttackType;
        private System.Windows.Forms.RadioButton rbMaskDict;
        private System.Windows.Forms.RadioButton rbDictMask;
        private System.Windows.Forms.RadioButton rbBruteforce;
        private System.Windows.Forms.RadioButton rbCombination;
        private System.Windows.Forms.RadioButton rbStraight;
        private System.Windows.Forms.GroupBox gbAttackSource;
        private System.Windows.Forms.GroupBox gbIncrementMode;
        private System.Windows.Forms.NumericUpDown nudIncrementMax;
        private System.Windows.Forms.NumericUpDown nudIncrementMin;
        private System.Windows.Forms.Label lblIncrementMax;
        private System.Windows.Forms.Label lblIncrementMin;
        private System.Windows.Forms.CheckBox cbIncrementMode;
        private System.Windows.Forms.GroupBox gbCharsets;
        private System.Windows.Forms.CheckBox cbCharset4;
        private System.Windows.Forms.CheckBox cbCharset3;
        private System.Windows.Forms.CheckBox cbCharset2;
        private System.Windows.Forms.CheckBox cbCharset1;
        private System.Windows.Forms.Label lblRightSource;
        private System.Windows.Forms.Label lblLeftSource;
        private System.Windows.Forms.ComboBox cmbCharset2;
        private System.Windows.Forms.ComboBox cmbCharset1;
        private System.Windows.Forms.ComboBox cmbRightSource;
        private System.Windows.Forms.ComboBox cmbLeftSource;
        private System.Windows.Forms.ComboBox cmbCharset4;
        private System.Windows.Forms.ComboBox cmbCharset3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage tpPredefined;
        private System.Windows.Forms.ListView lvPredefined;
        private System.Windows.Forms.ColumnHeader chPredefinedNumber;
        private System.Windows.Forms.ColumnHeader chPredefinedType;
        private System.Windows.Forms.ColumnHeader chPredefinedName;
        private System.Windows.Forms.ColumnHeader chPredefinedDescription;
    }
}