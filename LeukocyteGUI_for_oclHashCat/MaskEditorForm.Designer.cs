//  Copyright (C) 2015  Igor Kotlerman <igor.kotlerman@gmail.com>

//  This file is part of LeukocyteGUI_for_oclHashCat.

//  LeukocyteGUI_for_oclHashCat is free software: you can
//  redistribute it and/or modify it under the terms of the
//  GNU General Public License as published by the
//  Free Software Foundation, either version 3
//  of the License, or (at your option) any later version.

//  LeukocyteGUI_for_oclHashCat is distributed in the hope
//  that it will be useful, but WITHOUT ANY WARRANTY;
//  without even the implied warranty of MERCHANTABILITY or
//  FITNESS FOR A PARTICULAR PURPOSE.  
//  See the GNU General Public License for more details.

//  You should have received a copy of the
//  GNU General Public License along with
//  LeukocyteGUI_for_oclHashCat. 
//  If not, see <http://www.gnu.org/licenses/>.

namespace LeukocyteGUI_for_oclHashCat
{
    partial class MaskEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaskEditorForm));
            this.textBoxMask = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelMask = new System.Windows.Forms.Label();
            this.buttonCancelTask = new System.Windows.Forms.Button();
            this.buttonSettingsOK = new System.Windows.Forms.Button();
            this.groupBoxCharsets = new System.Windows.Forms.GroupBox();
            this.buttonChooseCharsetFile4 = new System.Windows.Forms.Button();
            this.buttonChooseCharsetFile3 = new System.Windows.Forms.Button();
            this.buttonChooseCharsetFile2 = new System.Windows.Forms.Button();
            this.buttonChooseCharsetFile1 = new System.Windows.Forms.Button();
            this.checkBoxCharset4 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset4 = new System.Windows.Forms.TextBox();
            this.checkBoxCharset3 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset3 = new System.Windows.Forms.TextBox();
            this.checkBoxCharset2 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset2 = new System.Windows.Forms.TextBox();
            this.checkBoxCharset1 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset1 = new System.Windows.Forms.TextBox();
            this.groupBoxIncrement = new System.Windows.Forms.GroupBox();
            this.numericUpDownIncrementMax = new System.Windows.Forms.NumericUpDown();
            this.labelIncrementMax = new System.Windows.Forms.Label();
            this.numericUpDownIncrementMin = new System.Windows.Forms.NumericUpDown();
            this.labelIncrementMin = new System.Windows.Forms.Label();
            this.checkBoxEnableIncrement = new System.Windows.Forms.CheckBox();
            this.openFileDialogCharset1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogCharset2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogCharset3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogCharset4 = new System.Windows.Forms.OpenFileDialog();
            this.buttonChooseMaskFile = new System.Windows.Forms.Button();
            this.openFileDialogMask = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxDescAutofilling = new System.Windows.Forms.CheckBox();
            this.groupBoxCharsets.SuspendLayout();
            this.groupBoxIncrement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrementMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrementMin)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMask
            // 
            this.textBoxMask.Location = new System.Drawing.Point(81, 16);
            this.textBoxMask.Name = "textBoxMask";
            this.textBoxMask.Size = new System.Drawing.Size(119, 20);
            this.textBoxMask.TabIndex = 7;
            this.textBoxMask.TextChanged += new System.EventHandler(this.textBoxMask_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(81, 42);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(159, 20);
            this.textBoxDescription.TabIndex = 10;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 45);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Description:";
            // 
            // labelMask
            // 
            this.labelMask.AutoSize = true;
            this.labelMask.Location = new System.Drawing.Point(12, 19);
            this.labelMask.Name = "labelMask";
            this.labelMask.Size = new System.Drawing.Size(36, 13);
            this.labelMask.TabIndex = 6;
            this.labelMask.Text = "Mask:";
            // 
            // buttonCancelTask
            // 
            this.buttonCancelTask.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancelTask.FlatAppearance.BorderSize = 0;
            this.buttonCancelTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCancelTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_cancel;
            this.buttonCancelTask.Location = new System.Drawing.Point(454, 177);
            this.buttonCancelTask.Name = "buttonCancelTask";
            this.buttonCancelTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonCancelTask.Size = new System.Drawing.Size(40, 40);
            this.buttonCancelTask.TabIndex = 12;
            this.buttonCancelTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelTask.UseVisualStyleBackColor = true;
            // 
            // buttonSettingsOK
            // 
            this.buttonSettingsOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonSettingsOK.FlatAppearance.BorderSize = 0;
            this.buttonSettingsOK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSettingsOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettingsOK.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_ok;
            this.buttonSettingsOK.Location = new System.Drawing.Point(408, 177);
            this.buttonSettingsOK.Name = "buttonSettingsOK";
            this.buttonSettingsOK.Padding = new System.Windows.Forms.Padding(3);
            this.buttonSettingsOK.Size = new System.Drawing.Size(40, 40);
            this.buttonSettingsOK.TabIndex = 11;
            this.buttonSettingsOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettingsOK.UseVisualStyleBackColor = true;
            this.buttonSettingsOK.Click += new System.EventHandler(this.buttonSettingsOK_Click);
            // 
            // groupBoxCharsets
            // 
            this.groupBoxCharsets.Controls.Add(this.buttonChooseCharsetFile4);
            this.groupBoxCharsets.Controls.Add(this.buttonChooseCharsetFile3);
            this.groupBoxCharsets.Controls.Add(this.buttonChooseCharsetFile2);
            this.groupBoxCharsets.Controls.Add(this.buttonChooseCharsetFile1);
            this.groupBoxCharsets.Controls.Add(this.checkBoxCharset4);
            this.groupBoxCharsets.Controls.Add(this.textBoxCharset4);
            this.groupBoxCharsets.Controls.Add(this.checkBoxCharset3);
            this.groupBoxCharsets.Controls.Add(this.textBoxCharset3);
            this.groupBoxCharsets.Controls.Add(this.checkBoxCharset2);
            this.groupBoxCharsets.Controls.Add(this.textBoxCharset2);
            this.groupBoxCharsets.Controls.Add(this.checkBoxCharset1);
            this.groupBoxCharsets.Controls.Add(this.textBoxCharset1);
            this.groupBoxCharsets.Location = new System.Drawing.Point(257, 12);
            this.groupBoxCharsets.Name = "groupBoxCharsets";
            this.groupBoxCharsets.Size = new System.Drawing.Size(237, 159);
            this.groupBoxCharsets.TabIndex = 13;
            this.groupBoxCharsets.TabStop = false;
            this.groupBoxCharsets.Text = "Charsets";
            // 
            // buttonChooseCharsetFile4
            // 
            this.buttonChooseCharsetFile4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChooseCharsetFile4.FlatAppearance.BorderSize = 0;
            this.buttonChooseCharsetFile4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseCharsetFile4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseCharsetFile4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseCharsetFile4.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe16;
            this.buttonChooseCharsetFile4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseCharsetFile4.Location = new System.Drawing.Point(192, 107);
            this.buttonChooseCharsetFile4.Name = "buttonChooseCharsetFile4";
            this.buttonChooseCharsetFile4.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseCharsetFile4.TabIndex = 58;
            this.buttonChooseCharsetFile4.UseVisualStyleBackColor = true;
            this.buttonChooseCharsetFile4.Click += new System.EventHandler(this.buttonChooseCharsetFile4_Click);
            // 
            // buttonChooseCharsetFile3
            // 
            this.buttonChooseCharsetFile3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChooseCharsetFile3.FlatAppearance.BorderSize = 0;
            this.buttonChooseCharsetFile3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseCharsetFile3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseCharsetFile3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseCharsetFile3.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe16;
            this.buttonChooseCharsetFile3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseCharsetFile3.Location = new System.Drawing.Point(192, 78);
            this.buttonChooseCharsetFile3.Name = "buttonChooseCharsetFile3";
            this.buttonChooseCharsetFile3.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseCharsetFile3.TabIndex = 57;
            this.buttonChooseCharsetFile3.UseVisualStyleBackColor = true;
            this.buttonChooseCharsetFile3.Click += new System.EventHandler(this.buttonChooseCharsetFile3_Click);
            // 
            // buttonChooseCharsetFile2
            // 
            this.buttonChooseCharsetFile2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChooseCharsetFile2.FlatAppearance.BorderSize = 0;
            this.buttonChooseCharsetFile2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseCharsetFile2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseCharsetFile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseCharsetFile2.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe16;
            this.buttonChooseCharsetFile2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseCharsetFile2.Location = new System.Drawing.Point(192, 49);
            this.buttonChooseCharsetFile2.Name = "buttonChooseCharsetFile2";
            this.buttonChooseCharsetFile2.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseCharsetFile2.TabIndex = 56;
            this.buttonChooseCharsetFile2.UseVisualStyleBackColor = true;
            this.buttonChooseCharsetFile2.Click += new System.EventHandler(this.buttonChooseCharsetFile2_Click);
            // 
            // buttonChooseCharsetFile1
            // 
            this.buttonChooseCharsetFile1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChooseCharsetFile1.FlatAppearance.BorderSize = 0;
            this.buttonChooseCharsetFile1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseCharsetFile1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseCharsetFile1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseCharsetFile1.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe16;
            this.buttonChooseCharsetFile1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseCharsetFile1.Location = new System.Drawing.Point(192, 19);
            this.buttonChooseCharsetFile1.Name = "buttonChooseCharsetFile1";
            this.buttonChooseCharsetFile1.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseCharsetFile1.TabIndex = 55;
            this.buttonChooseCharsetFile1.UseVisualStyleBackColor = true;
            this.buttonChooseCharsetFile1.Click += new System.EventHandler(this.buttonChooseCharsetFile1_Click);
            // 
            // checkBoxCharset4
            // 
            this.checkBoxCharset4.AutoSize = true;
            this.checkBoxCharset4.Location = new System.Drawing.Point(17, 110);
            this.checkBoxCharset4.Name = "checkBoxCharset4";
            this.checkBoxCharset4.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCharset4.TabIndex = 19;
            this.checkBoxCharset4.Text = "4:";
            this.checkBoxCharset4.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset4
            // 
            this.textBoxCharset4.Location = new System.Drawing.Point(58, 109);
            this.textBoxCharset4.Name = "textBoxCharset4";
            this.textBoxCharset4.Size = new System.Drawing.Size(128, 20);
            this.textBoxCharset4.TabIndex = 20;
            // 
            // checkBoxCharset3
            // 
            this.checkBoxCharset3.AutoSize = true;
            this.checkBoxCharset3.Location = new System.Drawing.Point(17, 81);
            this.checkBoxCharset3.Name = "checkBoxCharset3";
            this.checkBoxCharset3.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCharset3.TabIndex = 17;
            this.checkBoxCharset3.Text = "3:";
            this.checkBoxCharset3.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset3
            // 
            this.textBoxCharset3.Location = new System.Drawing.Point(58, 80);
            this.textBoxCharset3.Name = "textBoxCharset3";
            this.textBoxCharset3.Size = new System.Drawing.Size(128, 20);
            this.textBoxCharset3.TabIndex = 18;
            // 
            // checkBoxCharset2
            // 
            this.checkBoxCharset2.AutoSize = true;
            this.checkBoxCharset2.Location = new System.Drawing.Point(17, 52);
            this.checkBoxCharset2.Name = "checkBoxCharset2";
            this.checkBoxCharset2.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCharset2.TabIndex = 15;
            this.checkBoxCharset2.Text = "2:";
            this.checkBoxCharset2.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset2
            // 
            this.textBoxCharset2.Location = new System.Drawing.Point(58, 50);
            this.textBoxCharset2.Name = "textBoxCharset2";
            this.textBoxCharset2.Size = new System.Drawing.Size(128, 20);
            this.textBoxCharset2.TabIndex = 16;
            // 
            // checkBoxCharset1
            // 
            this.checkBoxCharset1.AutoSize = true;
            this.checkBoxCharset1.Location = new System.Drawing.Point(17, 23);
            this.checkBoxCharset1.Name = "checkBoxCharset1";
            this.checkBoxCharset1.Size = new System.Drawing.Size(35, 17);
            this.checkBoxCharset1.TabIndex = 13;
            this.checkBoxCharset1.Text = "1:";
            this.checkBoxCharset1.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset1
            // 
            this.textBoxCharset1.Location = new System.Drawing.Point(58, 21);
            this.textBoxCharset1.Name = "textBoxCharset1";
            this.textBoxCharset1.Size = new System.Drawing.Size(128, 20);
            this.textBoxCharset1.TabIndex = 14;
            // 
            // groupBoxIncrement
            // 
            this.groupBoxIncrement.Controls.Add(this.numericUpDownIncrementMax);
            this.groupBoxIncrement.Controls.Add(this.labelIncrementMax);
            this.groupBoxIncrement.Controls.Add(this.numericUpDownIncrementMin);
            this.groupBoxIncrement.Controls.Add(this.labelIncrementMin);
            this.groupBoxIncrement.Controls.Add(this.checkBoxEnableIncrement);
            this.groupBoxIncrement.Location = new System.Drawing.Point(15, 90);
            this.groupBoxIncrement.Name = "groupBoxIncrement";
            this.groupBoxIncrement.Size = new System.Drawing.Size(225, 81);
            this.groupBoxIncrement.TabIndex = 14;
            this.groupBoxIncrement.TabStop = false;
            this.groupBoxIncrement.Text = "Increment Mode";
            // 
            // numericUpDownIncrementMax
            // 
            this.numericUpDownIncrementMax.Location = new System.Drawing.Point(160, 49);
            this.numericUpDownIncrementMax.Name = "numericUpDownIncrementMax";
            this.numericUpDownIncrementMax.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownIncrementMax.TabIndex = 39;
            this.numericUpDownIncrementMax.ValueChanged += new System.EventHandler(this.numericUpDownIncrementMax_ValueChanged);
            // 
            // labelIncrementMax
            // 
            this.labelIncrementMax.AutoSize = true;
            this.labelIncrementMax.Location = new System.Drawing.Point(124, 51);
            this.labelIncrementMax.Name = "labelIncrementMax";
            this.labelIncrementMax.Size = new System.Drawing.Size(30, 13);
            this.labelIncrementMax.TabIndex = 17;
            this.labelIncrementMax.Text = "Max:";
            // 
            // numericUpDownIncrementMin
            // 
            this.numericUpDownIncrementMin.Location = new System.Drawing.Point(47, 49);
            this.numericUpDownIncrementMin.Name = "numericUpDownIncrementMin";
            this.numericUpDownIncrementMin.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownIncrementMin.TabIndex = 38;
            this.numericUpDownIncrementMin.ValueChanged += new System.EventHandler(this.numericUpDownIncrementMin_ValueChanged);
            // 
            // labelIncrementMin
            // 
            this.labelIncrementMin.AutoSize = true;
            this.labelIncrementMin.Location = new System.Drawing.Point(14, 51);
            this.labelIncrementMin.Name = "labelIncrementMin";
            this.labelIncrementMin.Size = new System.Drawing.Size(27, 13);
            this.labelIncrementMin.TabIndex = 13;
            this.labelIncrementMin.Text = "Min:";
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
            this.checkBoxEnableIncrement.CheckedChanged += new System.EventHandler(this.checkBoxEnableIncrement_CheckedChanged);
            // 
            // openFileDialogCharset1
            // 
            this.openFileDialogCharset1.FileName = "charset1";
            this.openFileDialogCharset1.Filter = "Hashcat charset files (*.hcchr)|*.hcchr|Any files (*.*)|*.*";
            this.openFileDialogCharset1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogCharset1_FileOk);
            // 
            // openFileDialogCharset2
            // 
            this.openFileDialogCharset2.FileName = "charset2";
            this.openFileDialogCharset2.Filter = "Hashcat charset files (*.hcchr)|*.hcchr|Any files (*.*)|*.*";
            this.openFileDialogCharset2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogCharset2_FileOk);
            // 
            // openFileDialogCharset3
            // 
            this.openFileDialogCharset3.FileName = "charset3";
            this.openFileDialogCharset3.Filter = "Hashcat charset files (*.hcchr)|*.hcchr|Any files (*.*)|*.*";
            this.openFileDialogCharset3.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogCharset3_FileOk);
            // 
            // openFileDialogCharset4
            // 
            this.openFileDialogCharset4.FileName = "charset4";
            this.openFileDialogCharset4.Filter = "Hashcat charset files (*.hcchr)|*.hcchr|Any files (*.*)|*.*";
            this.openFileDialogCharset4.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogCharset4_FileOk);
            // 
            // buttonChooseMaskFile
            // 
            this.buttonChooseMaskFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChooseMaskFile.FlatAppearance.BorderSize = 0;
            this.buttonChooseMaskFile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseMaskFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseMaskFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseMaskFile.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe16;
            this.buttonChooseMaskFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseMaskFile.Location = new System.Drawing.Point(206, 15);
            this.buttonChooseMaskFile.Name = "buttonChooseMaskFile";
            this.buttonChooseMaskFile.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseMaskFile.TabIndex = 59;
            this.buttonChooseMaskFile.UseVisualStyleBackColor = true;
            this.buttonChooseMaskFile.Click += new System.EventHandler(this.buttonChooseMaskFile_Click);
            // 
            // openFileDialogMask
            // 
            this.openFileDialogMask.FileName = "mask";
            this.openFileDialogMask.Filter = "Hashcat mask files (*.hcmask)|*.hcmask|Any files (*.*)|*.*";
            this.openFileDialogMask.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogMask_FileOk);
            // 
            // checkBoxDescAutofilling
            // 
            this.checkBoxDescAutofilling.AutoSize = true;
            this.checkBoxDescAutofilling.Checked = global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default.MaskDescAutofilling;
            this.checkBoxDescAutofilling.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDescAutofilling.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default, "MaskDescAutofilling", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxDescAutofilling.Location = new System.Drawing.Point(81, 66);
            this.checkBoxDescAutofilling.Name = "checkBoxDescAutofilling";
            this.checkBoxDescAutofilling.Size = new System.Drawing.Size(126, 17);
            this.checkBoxDescAutofilling.TabIndex = 60;
            this.checkBoxDescAutofilling.Text = "Description autofilling";
            this.checkBoxDescAutofilling.UseVisualStyleBackColor = true;
            // 
            // MaskEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 226);
            this.Controls.Add(this.checkBoxDescAutofilling);
            this.Controls.Add(this.buttonChooseMaskFile);
            this.Controls.Add(this.groupBoxIncrement);
            this.Controls.Add(this.groupBoxCharsets);
            this.Controls.Add(this.buttonCancelTask);
            this.Controls.Add(this.buttonSettingsOK);
            this.Controls.Add(this.textBoxMask);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelMask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaskEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mask Editor";
            this.groupBoxCharsets.ResumeLayout(false);
            this.groupBoxCharsets.PerformLayout();
            this.groupBoxIncrement.ResumeLayout(false);
            this.groupBoxIncrement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrementMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrementMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelTask;
        private System.Windows.Forms.Button buttonSettingsOK;
        private System.Windows.Forms.TextBox textBoxMask;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelMask;
        private System.Windows.Forms.GroupBox groupBoxCharsets;
        private System.Windows.Forms.CheckBox checkBoxCharset4;
        private System.Windows.Forms.TextBox textBoxCharset4;
        private System.Windows.Forms.CheckBox checkBoxCharset3;
        private System.Windows.Forms.TextBox textBoxCharset3;
        private System.Windows.Forms.CheckBox checkBoxCharset2;
        private System.Windows.Forms.TextBox textBoxCharset2;
        private System.Windows.Forms.CheckBox checkBoxCharset1;
        private System.Windows.Forms.TextBox textBoxCharset1;
        private System.Windows.Forms.GroupBox groupBoxIncrement;
        private System.Windows.Forms.NumericUpDown numericUpDownIncrementMax;
        private System.Windows.Forms.Label labelIncrementMax;
        private System.Windows.Forms.NumericUpDown numericUpDownIncrementMin;
        private System.Windows.Forms.Label labelIncrementMin;
        private System.Windows.Forms.CheckBox checkBoxEnableIncrement;
        private System.Windows.Forms.Button buttonChooseCharsetFile4;
        private System.Windows.Forms.Button buttonChooseCharsetFile3;
        private System.Windows.Forms.Button buttonChooseCharsetFile2;
        private System.Windows.Forms.Button buttonChooseCharsetFile1;
        private System.Windows.Forms.OpenFileDialog openFileDialogCharset1;
        private System.Windows.Forms.OpenFileDialog openFileDialogCharset2;
        private System.Windows.Forms.OpenFileDialog openFileDialogCharset3;
        private System.Windows.Forms.OpenFileDialog openFileDialogCharset4;
        private System.Windows.Forms.Button buttonChooseMaskFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogMask;
        private System.Windows.Forms.CheckBox checkBoxDescAutofilling;

    }
}