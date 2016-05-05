namespace LeukocyteGUI_for_oclHashcat.Forms
{
    partial class CrackDataSourceEditorForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
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
            this.gbCrackDataSourceType = new System.Windows.Forms.GroupBox();
            this.rbMaskDict = new System.Windows.Forms.RadioButton();
            this.rbDictMask = new System.Windows.Forms.RadioButton();
            this.rbMask = new System.Windows.Forms.RadioButton();
            this.rbCombination = new System.Windows.Forms.RadioButton();
            this.rbDictionary = new System.Windows.Forms.RadioButton();
            this.gbMain.SuspendLayout();
            this.gbIncrementMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncrementMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncrementMin)).BeginInit();
            this.gbCharsets.SuspendLayout();
            this.gbAttackSource.SuspendLayout();
            this.gbCrackDataSourceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(82, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(177, 20);
            this.tbName.TabIndex = 4;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(82, 45);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(177, 20);
            this.tbDescription.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_task_cancel;
            this.btnCancel.Location = new System.Drawing.Point(478, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnCancel.Size = new System.Drawing.Size(36, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_task_ok;
            this.btnOK.Location = new System.Drawing.Point(436, 328);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnOK.Size = new System.Drawing.Size(36, 36);
            this.btnOK.TabIndex = 10;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gbMain
            // 
            this.gbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMain.Controls.Add(this.tbName);
            this.gbMain.Controls.Add(this.tbDescription);
            this.gbMain.Controls.Add(this.lblName);
            this.gbMain.Controls.Add(this.lblDescription);
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(281, 80);
            this.gbMain.TabIndex = 13;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Main";
            // 
            // gbIncrementMode
            // 
            this.gbIncrementMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbIncrementMode.Controls.Add(this.nudIncrementMax);
            this.gbIncrementMode.Controls.Add(this.nudIncrementMin);
            this.gbIncrementMode.Controls.Add(this.lblIncrementMax);
            this.gbIncrementMode.Controls.Add(this.lblIncrementMin);
            this.gbIncrementMode.Controls.Add(this.cbIncrementMode);
            this.gbIncrementMode.Enabled = false;
            this.gbIncrementMode.Location = new System.Drawing.Point(306, 140);
            this.gbIncrementMode.Name = "gbIncrementMode";
            this.gbIncrementMode.Size = new System.Drawing.Size(208, 138);
            this.gbIncrementMode.TabIndex = 15;
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
            this.gbCharsets.Location = new System.Drawing.Point(12, 226);
            this.gbCharsets.Name = "gbCharsets";
            this.gbCharsets.Size = new System.Drawing.Size(281, 138);
            this.gbCharsets.TabIndex = 14;
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
            this.cmbCharset4.Size = new System.Drawing.Size(199, 21);
            this.cmbCharset4.TabIndex = 14;
            // 
            // cmbCharset3
            // 
            this.cmbCharset3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCharset3.FormattingEnabled = true;
            this.cmbCharset3.Location = new System.Drawing.Point(60, 75);
            this.cmbCharset3.Name = "cmbCharset3";
            this.cmbCharset3.Size = new System.Drawing.Size(199, 21);
            this.cmbCharset3.TabIndex = 13;
            // 
            // cmbCharset2
            // 
            this.cmbCharset2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCharset2.FormattingEnabled = true;
            this.cmbCharset2.Location = new System.Drawing.Point(60, 48);
            this.cmbCharset2.Name = "cmbCharset2";
            this.cmbCharset2.Size = new System.Drawing.Size(199, 21);
            this.cmbCharset2.TabIndex = 12;
            // 
            // cmbCharset1
            // 
            this.cmbCharset1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCharset1.FormattingEnabled = true;
            this.cmbCharset1.Location = new System.Drawing.Point(60, 21);
            this.cmbCharset1.Name = "cmbCharset1";
            this.cmbCharset1.Size = new System.Drawing.Size(199, 21);
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
            this.gbAttackSource.Location = new System.Drawing.Point(12, 98);
            this.gbAttackSource.Name = "gbAttackSource";
            this.gbAttackSource.Size = new System.Drawing.Size(281, 122);
            this.gbAttackSource.TabIndex = 17;
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
            this.cmbRightSource.Size = new System.Drawing.Size(220, 21);
            this.cmbRightSource.TabIndex = 7;
            // 
            // cmbLeftSource
            // 
            this.cmbLeftSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLeftSource.FormattingEnabled = true;
            this.cmbLeftSource.Location = new System.Drawing.Point(39, 41);
            this.cmbLeftSource.Name = "cmbLeftSource";
            this.cmbLeftSource.Size = new System.Drawing.Size(220, 21);
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
            // gbCrackDataSourceType
            // 
            this.gbCrackDataSourceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCrackDataSourceType.Controls.Add(this.rbMaskDict);
            this.gbCrackDataSourceType.Controls.Add(this.rbDictMask);
            this.gbCrackDataSourceType.Controls.Add(this.rbMask);
            this.gbCrackDataSourceType.Controls.Add(this.rbCombination);
            this.gbCrackDataSourceType.Controls.Add(this.rbDictionary);
            this.gbCrackDataSourceType.Location = new System.Drawing.Point(306, 12);
            this.gbCrackDataSourceType.Name = "gbCrackDataSourceType";
            this.gbCrackDataSourceType.Size = new System.Drawing.Size(208, 122);
            this.gbCrackDataSourceType.TabIndex = 16;
            this.gbCrackDataSourceType.TabStop = false;
            this.gbCrackDataSourceType.Text = "Source type";
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
            this.rbMaskDict.CheckedChanged += new System.EventHandler(this.rbCrackSource_CheckedChanged);
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
            this.rbDictMask.CheckedChanged += new System.EventHandler(this.rbCrackSource_CheckedChanged);
            // 
            // rbMask
            // 
            this.rbMask.AutoSize = true;
            this.rbMask.Location = new System.Drawing.Point(15, 57);
            this.rbMask.Name = "rbMask";
            this.rbMask.Size = new System.Drawing.Size(66, 17);
            this.rbMask.TabIndex = 2;
            this.rbMask.Text = "(3) Mask";
            this.rbMask.UseVisualStyleBackColor = true;
            this.rbMask.CheckedChanged += new System.EventHandler(this.rbCrackSource_CheckedChanged);
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
            this.rbCombination.CheckedChanged += new System.EventHandler(this.rbCrackSource_CheckedChanged);
            // 
            // rbDictionary
            // 
            this.rbDictionary.AutoSize = true;
            this.rbDictionary.Checked = true;
            this.rbDictionary.Location = new System.Drawing.Point(15, 19);
            this.rbDictionary.Name = "rbDictionary";
            this.rbDictionary.Size = new System.Drawing.Size(87, 17);
            this.rbDictionary.TabIndex = 0;
            this.rbDictionary.TabStop = true;
            this.rbDictionary.Text = "(0) Dictionary";
            this.rbDictionary.UseVisualStyleBackColor = true;
            this.rbDictionary.CheckedChanged += new System.EventHandler(this.rbCrackSource_CheckedChanged);
            // 
            // CrackDataSourceEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 375);
            this.Controls.Add(this.gbAttackSource);
            this.Controls.Add(this.gbCrackDataSourceType);
            this.Controls.Add(this.gbIncrementMode);
            this.Controls.Add(this.gbCharsets);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Name = "CrackDataSourceEditorForm";
            this.Text = "CrackDataSourceEditorForm";
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbIncrementMode.ResumeLayout(false);
            this.gbIncrementMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncrementMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncrementMin)).EndInit();
            this.gbCharsets.ResumeLayout(false);
            this.gbCharsets.PerformLayout();
            this.gbAttackSource.ResumeLayout(false);
            this.gbAttackSource.PerformLayout();
            this.gbCrackDataSourceType.ResumeLayout(false);
            this.gbCrackDataSourceType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.GroupBox gbIncrementMode;
        private System.Windows.Forms.NumericUpDown nudIncrementMax;
        private System.Windows.Forms.NumericUpDown nudIncrementMin;
        private System.Windows.Forms.Label lblIncrementMax;
        private System.Windows.Forms.Label lblIncrementMin;
        private System.Windows.Forms.CheckBox cbIncrementMode;
        private System.Windows.Forms.GroupBox gbCharsets;
        private System.Windows.Forms.ComboBox cmbCharset4;
        private System.Windows.Forms.ComboBox cmbCharset3;
        private System.Windows.Forms.ComboBox cmbCharset2;
        private System.Windows.Forms.ComboBox cmbCharset1;
        private System.Windows.Forms.CheckBox cbCharset4;
        private System.Windows.Forms.CheckBox cbCharset3;
        private System.Windows.Forms.CheckBox cbCharset2;
        private System.Windows.Forms.CheckBox cbCharset1;
        private System.Windows.Forms.GroupBox gbAttackSource;
        private System.Windows.Forms.ComboBox cmbRightSource;
        private System.Windows.Forms.ComboBox cmbLeftSource;
        private System.Windows.Forms.Label lblRightSource;
        private System.Windows.Forms.Label lblLeftSource;
        private System.Windows.Forms.GroupBox gbCrackDataSourceType;
        private System.Windows.Forms.RadioButton rbMaskDict;
        private System.Windows.Forms.RadioButton rbDictMask;
        private System.Windows.Forms.RadioButton rbMask;
        private System.Windows.Forms.RadioButton rbCombination;
        private System.Windows.Forms.RadioButton rbDictionary;
    }
}