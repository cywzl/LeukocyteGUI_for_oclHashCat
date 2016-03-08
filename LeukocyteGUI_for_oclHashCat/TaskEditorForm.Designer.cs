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
            this.cbLoopback = new System.Windows.Forms.CheckBox();
            this.cbForce = new System.Windows.Forms.CheckBox();
            this.cbHexWordlist = new System.Windows.Forms.CheckBox();
            this.cbHexSalt = new System.Windows.Forms.CheckBox();
            this.cbHexCharset = new System.Windows.Forms.CheckBox();
            this.tpMarkov = new System.Windows.Forms.TabPage();
            this.tpSession = new System.Windows.Forms.TabPage();
            this.tpFiles = new System.Windows.Forms.TabPage();
            this.tpResources = new System.Windows.Forms.TabPage();
            this.tpDistributed = new System.Windows.Forms.TabPage();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.tpCharsetsIncrement = new System.Windows.Forms.TabPage();
            this.cbWeakHashThreshold = new System.Windows.Forms.CheckBox();
            this.lblWeakHashThreshold = new System.Windows.Forms.Label();
            this.cbMarkovHcstat = new System.Windows.Forms.CheckBox();
            this.nudWeakHashThreshold = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMarkovHcstat = new System.Windows.Forms.TextBox();
            this.cbMarkovDisable = new System.Windows.Forms.CheckBox();
            this.cbMarkovClassic = new System.Windows.Forms.CheckBox();
            this.nudMarkovThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblMarkovThreshold = new System.Windows.Forms.Label();
            this.cbMarkovThreshold = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tpMisc.SuspendLayout();
            this.tpMarkov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeakHashThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkovThreshold)).BeginInit();
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
            // tpSession
            // 
            this.tpSession.Location = new System.Drawing.Point(4, 22);
            this.tpSession.Name = "tpSession";
            this.tpSession.Size = new System.Drawing.Size(545, 311);
            this.tpSession.TabIndex = 3;
            this.tpSession.Text = "Session";
            this.tpSession.UseVisualStyleBackColor = true;
            // 
            // tpFiles
            // 
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
            // lblWeakHashThreshold
            // 
            this.lblWeakHashThreshold.AutoSize = true;
            this.lblWeakHashThreshold.Location = new System.Drawing.Point(44, 158);
            this.lblWeakHashThreshold.Name = "lblWeakHashThreshold";
            this.lblWeakHashThreshold.Size = new System.Drawing.Size(41, 13);
            this.lblWeakHashThreshold.TabIndex = 7;
            this.lblWeakHashThreshold.Text = "NUM =";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FILE =";
            // 
            // tbMarkovHcstat
            // 
            this.tbMarkovHcstat.Location = new System.Drawing.Point(89, 41);
            this.tbMarkovHcstat.Name = "tbMarkovHcstat";
            this.tbMarkovHcstat.Size = new System.Drawing.Size(255, 20);
            this.tbMarkovHcstat.TabIndex = 2;
            this.tbMarkovHcstat.Text = "hashcat.hcstat";
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
            this.cbMarkovThreshold.Size = new System.Drawing.Size(427, 17);
            this.cbMarkovThreshold.TabIndex = 9;
            this.cbMarkovThreshold.Text = "Threshold when to stop accepting new markov-chains ( -t, --markov-threshold=NUM )" +
    "";
            this.cbMarkovThreshold.UseVisualStyleBackColor = true;
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
            this.tpMarkov.ResumeLayout(false);
            this.tpMarkov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeakHashThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkovThreshold)).EndInit();
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
    }
}