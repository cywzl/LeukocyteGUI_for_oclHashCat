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
            this.textBoxMask = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelMask = new System.Windows.Forms.Label();
            this.buttonCancelTask = new System.Windows.Forms.Button();
            this.buttonSettingsOK = new System.Windows.Forms.Button();
            this.groupBoxCharsets = new System.Windows.Forms.GroupBox();
            this.checkBoxCharset4 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset4 = new System.Windows.Forms.TextBox();
            this.checkBoxCharset3 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset3 = new System.Windows.Forms.TextBox();
            this.checkBoxCharset2 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset2 = new System.Windows.Forms.TextBox();
            this.checkBoxCharset1 = new System.Windows.Forms.CheckBox();
            this.textBoxCharset1 = new System.Windows.Forms.TextBox();
            this.groupBoxCharsets.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMask
            // 
            this.textBoxMask.Location = new System.Drawing.Point(81, 16);
            this.textBoxMask.Name = "textBoxMask";
            this.textBoxMask.Size = new System.Drawing.Size(237, 20);
            this.textBoxMask.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(81, 42);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(237, 20);
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
            this.buttonCancelTask.Location = new System.Drawing.Point(278, 230);
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
            this.buttonSettingsOK.Location = new System.Drawing.Point(232, 230);
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
            this.groupBoxCharsets.Controls.Add(this.checkBoxCharset4);
            this.groupBoxCharsets.Controls.Add(this.textBoxCharset4);
            this.groupBoxCharsets.Controls.Add(this.checkBoxCharset3);
            this.groupBoxCharsets.Controls.Add(this.textBoxCharset3);
            this.groupBoxCharsets.Controls.Add(this.checkBoxCharset2);
            this.groupBoxCharsets.Controls.Add(this.textBoxCharset2);
            this.groupBoxCharsets.Controls.Add(this.checkBoxCharset1);
            this.groupBoxCharsets.Controls.Add(this.textBoxCharset1);
            this.groupBoxCharsets.Location = new System.Drawing.Point(15, 68);
            this.groupBoxCharsets.Name = "groupBoxCharsets";
            this.groupBoxCharsets.Size = new System.Drawing.Size(303, 142);
            this.groupBoxCharsets.TabIndex = 13;
            this.groupBoxCharsets.TabStop = false;
            this.groupBoxCharsets.Text = "Charsets";
            // 
            // checkBoxCharset4
            // 
            this.checkBoxCharset4.AutoSize = true;
            this.checkBoxCharset4.Location = new System.Drawing.Point(17, 110);
            this.checkBoxCharset4.Name = "checkBoxCharset4";
            this.checkBoxCharset4.Size = new System.Drawing.Size(74, 17);
            this.checkBoxCharset4.TabIndex = 19;
            this.checkBoxCharset4.Text = "Charset 4:";
            this.checkBoxCharset4.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset4
            // 
            this.textBoxCharset4.Location = new System.Drawing.Point(97, 108);
            this.textBoxCharset4.Name = "textBoxCharset4";
            this.textBoxCharset4.Size = new System.Drawing.Size(186, 20);
            this.textBoxCharset4.TabIndex = 20;
            // 
            // checkBoxCharset3
            // 
            this.checkBoxCharset3.AutoSize = true;
            this.checkBoxCharset3.Location = new System.Drawing.Point(17, 81);
            this.checkBoxCharset3.Name = "checkBoxCharset3";
            this.checkBoxCharset3.Size = new System.Drawing.Size(74, 17);
            this.checkBoxCharset3.TabIndex = 17;
            this.checkBoxCharset3.Text = "Charset 3:";
            this.checkBoxCharset3.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset3
            // 
            this.textBoxCharset3.Location = new System.Drawing.Point(97, 79);
            this.textBoxCharset3.Name = "textBoxCharset3";
            this.textBoxCharset3.Size = new System.Drawing.Size(186, 20);
            this.textBoxCharset3.TabIndex = 18;
            // 
            // checkBoxCharset2
            // 
            this.checkBoxCharset2.AutoSize = true;
            this.checkBoxCharset2.Location = new System.Drawing.Point(17, 52);
            this.checkBoxCharset2.Name = "checkBoxCharset2";
            this.checkBoxCharset2.Size = new System.Drawing.Size(74, 17);
            this.checkBoxCharset2.TabIndex = 15;
            this.checkBoxCharset2.Text = "Charset 2:";
            this.checkBoxCharset2.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset2
            // 
            this.textBoxCharset2.Location = new System.Drawing.Point(97, 50);
            this.textBoxCharset2.Name = "textBoxCharset2";
            this.textBoxCharset2.Size = new System.Drawing.Size(186, 20);
            this.textBoxCharset2.TabIndex = 16;
            // 
            // checkBoxCharset1
            // 
            this.checkBoxCharset1.AutoSize = true;
            this.checkBoxCharset1.Location = new System.Drawing.Point(17, 23);
            this.checkBoxCharset1.Name = "checkBoxCharset1";
            this.checkBoxCharset1.Size = new System.Drawing.Size(74, 17);
            this.checkBoxCharset1.TabIndex = 13;
            this.checkBoxCharset1.Text = "Charset 1:";
            this.checkBoxCharset1.UseVisualStyleBackColor = true;
            // 
            // textBoxCharset1
            // 
            this.textBoxCharset1.Location = new System.Drawing.Point(97, 21);
            this.textBoxCharset1.Name = "textBoxCharset1";
            this.textBoxCharset1.Size = new System.Drawing.Size(186, 20);
            this.textBoxCharset1.TabIndex = 14;
            // 
            // MaskEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 282);
            this.Controls.Add(this.groupBoxCharsets);
            this.Controls.Add(this.buttonCancelTask);
            this.Controls.Add(this.buttonSettingsOK);
            this.Controls.Add(this.textBoxMask);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelMask);
            this.Name = "MaskEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mask Editor";
            this.groupBoxCharsets.ResumeLayout(false);
            this.groupBoxCharsets.PerformLayout();
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

    }
}