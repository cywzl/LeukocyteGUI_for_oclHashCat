namespace LeukocyteGUI_for_oclHashCat.Forms
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
            this.tcEditor = new System.Windows.Forms.TabControl();
            this.tpDictionary = new System.Windows.Forms.TabPage();
            this.tpMask = new System.Windows.Forms.TabPage();
            this.rbDictionary = new System.Windows.Forms.RadioButton();
            this.rbMask = new System.Windows.Forms.RadioButton();
            this.gbCrackDataSourceType = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tcEditor.SuspendLayout();
            this.gbCrackDataSourceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcEditor
            // 
            this.tcEditor.Controls.Add(this.tpDictionary);
            this.tcEditor.Controls.Add(this.tpMask);
            this.tcEditor.Location = new System.Drawing.Point(12, 77);
            this.tcEditor.Name = "tcEditor";
            this.tcEditor.SelectedIndex = 0;
            this.tcEditor.Size = new System.Drawing.Size(487, 253);
            this.tcEditor.TabIndex = 0;
            this.tcEditor.SelectedIndexChanged += new System.EventHandler(this.tcEditor_SelectedIndexChanged);
            // 
            // tpDictionary
            // 
            this.tpDictionary.Location = new System.Drawing.Point(4, 22);
            this.tpDictionary.Name = "tpDictionary";
            this.tpDictionary.Padding = new System.Windows.Forms.Padding(3);
            this.tpDictionary.Size = new System.Drawing.Size(479, 227);
            this.tpDictionary.TabIndex = 0;
            this.tpDictionary.Text = "Dictionary";
            this.tpDictionary.UseVisualStyleBackColor = true;
            // 
            // tpMask
            // 
            this.tpMask.Location = new System.Drawing.Point(4, 22);
            this.tpMask.Name = "tpMask";
            this.tpMask.Padding = new System.Windows.Forms.Padding(3);
            this.tpMask.Size = new System.Drawing.Size(479, 238);
            this.tpMask.TabIndex = 1;
            this.tpMask.Text = "Mask";
            this.tpMask.UseVisualStyleBackColor = true;
            // 
            // rbDictionary
            // 
            this.rbDictionary.AutoSize = true;
            this.rbDictionary.Checked = true;
            this.rbDictionary.Location = new System.Drawing.Point(15, 19);
            this.rbDictionary.Name = "rbDictionary";
            this.rbDictionary.Size = new System.Drawing.Size(72, 17);
            this.rbDictionary.TabIndex = 1;
            this.rbDictionary.TabStop = true;
            this.rbDictionary.Text = "Dictionary";
            this.rbDictionary.UseVisualStyleBackColor = true;
            this.rbDictionary.CheckedChanged += new System.EventHandler(this.rbCrackSource_CheckedChanged);
            // 
            // rbMask
            // 
            this.rbMask.AutoSize = true;
            this.rbMask.Location = new System.Drawing.Point(15, 42);
            this.rbMask.Name = "rbMask";
            this.rbMask.Size = new System.Drawing.Size(51, 17);
            this.rbMask.TabIndex = 2;
            this.rbMask.Text = "Mask";
            this.rbMask.UseVisualStyleBackColor = true;
            this.rbMask.CheckedChanged += new System.EventHandler(this.rbCrackSource_CheckedChanged);
            // 
            // gbCrackDataSourceType
            // 
            this.gbCrackDataSourceType.Controls.Add(this.rbDictionary);
            this.gbCrackDataSourceType.Controls.Add(this.rbMask);
            this.gbCrackDataSourceType.Location = new System.Drawing.Point(299, 12);
            this.gbCrackDataSourceType.Name = "gbCrackDataSourceType";
            this.gbCrackDataSourceType.Size = new System.Drawing.Size(196, 73);
            this.gbCrackDataSourceType.TabIndex = 3;
            this.gbCrackDataSourceType.TabStop = false;
            this.gbCrackDataSourceType.Text = "Source type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_cancel;
            this.btnCancel.Location = new System.Drawing.Point(459, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnCancel.Size = new System.Drawing.Size(36, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_ok;
            this.btnOK.Location = new System.Drawing.Point(417, 336);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnOK.Size = new System.Drawing.Size(36, 36);
            this.btnOK.TabIndex = 10;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // CrackDataSourceEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 384);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbCrackDataSourceType);
            this.Controls.Add(this.tcEditor);
            this.Name = "CrackDataSourceEditorForm";
            this.Text = "CrackDataSourceEditorForm";
            this.tcEditor.ResumeLayout(false);
            this.gbCrackDataSourceType.ResumeLayout(false);
            this.gbCrackDataSourceType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcEditor;
        private System.Windows.Forms.TabPage tpDictionary;
        private System.Windows.Forms.TabPage tpMask;
        private System.Windows.Forms.RadioButton rbDictionary;
        private System.Windows.Forms.RadioButton rbMask;
        private System.Windows.Forms.GroupBox gbCrackDataSourceType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}