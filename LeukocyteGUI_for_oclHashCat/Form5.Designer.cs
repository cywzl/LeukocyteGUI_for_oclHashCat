namespace LeukocyteGUI_for_oclHashCat
{
    partial class SettingsForm
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
            this.labelWorkingDirectory = new System.Windows.Forms.Label();
            this.textBoxWorkingDirectory = new System.Windows.Forms.TextBox();
            this.labelOclHashcat = new System.Windows.Forms.Label();
            this.textBoxHashcat = new System.Windows.Forms.TextBox();
            this.buttonSettingsCancel = new System.Windows.Forms.Button();
            this.buttonSettingsOK = new System.Windows.Forms.Button();
            this.checkBoxAutoWorkingDirectory = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelWorkingDirectory
            // 
            this.labelWorkingDirectory.AutoSize = true;
            this.labelWorkingDirectory.Location = new System.Drawing.Point(11, 48);
            this.labelWorkingDirectory.Name = "labelWorkingDirectory";
            this.labelWorkingDirectory.Size = new System.Drawing.Size(93, 13);
            this.labelWorkingDirectory.TabIndex = 34;
            this.labelWorkingDirectory.Text = "Working directory:";
            // 
            // textBoxWorkingDirectory
            // 
            this.textBoxWorkingDirectory.Enabled = false;
            this.textBoxWorkingDirectory.Location = new System.Drawing.Point(110, 45);
            this.textBoxWorkingDirectory.Name = "textBoxWorkingDirectory";
            this.textBoxWorkingDirectory.Size = new System.Drawing.Size(351, 20);
            this.textBoxWorkingDirectory.TabIndex = 33;
            // 
            // labelOclHashcat
            // 
            this.labelOclHashcat.AutoSize = true;
            this.labelOclHashcat.Location = new System.Drawing.Point(11, 18);
            this.labelOclHashcat.Name = "labelOclHashcat";
            this.labelOclHashcat.Size = new System.Drawing.Size(64, 13);
            this.labelOclHashcat.TabIndex = 32;
            this.labelOclHashcat.Text = "oclHashcat:";
            // 
            // textBoxHashcat
            // 
            this.textBoxHashcat.Location = new System.Drawing.Point(110, 15);
            this.textBoxHashcat.Name = "textBoxHashcat";
            this.textBoxHashcat.Size = new System.Drawing.Size(351, 20);
            this.textBoxHashcat.TabIndex = 31;
            this.textBoxHashcat.Text = "oclHashcat64.exe";
            this.textBoxHashcat.TextChanged += new System.EventHandler(this.textBoxHashcat_TextChanged);
            // 
            // buttonSettingsCancel
            // 
            this.buttonSettingsCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSettingsCancel.Location = new System.Drawing.Point(386, 106);
            this.buttonSettingsCancel.Name = "buttonSettingsCancel";
            this.buttonSettingsCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonSettingsCancel.TabIndex = 36;
            this.buttonSettingsCancel.Text = "Cancel";
            this.buttonSettingsCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSettingsOK
            // 
            this.buttonSettingsOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSettingsOK.Location = new System.Drawing.Point(305, 106);
            this.buttonSettingsOK.Name = "buttonSettingsOK";
            this.buttonSettingsOK.Size = new System.Drawing.Size(75, 23);
            this.buttonSettingsOK.TabIndex = 35;
            this.buttonSettingsOK.Text = "OK";
            this.buttonSettingsOK.UseVisualStyleBackColor = true;
            this.buttonSettingsOK.Click += new System.EventHandler(this.buttonSettingsOK_Click);
            // 
            // checkBoxAutoWorkingDirectory
            // 
            this.checkBoxAutoWorkingDirectory.AutoSize = true;
            this.checkBoxAutoWorkingDirectory.Checked = true;
            this.checkBoxAutoWorkingDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoWorkingDirectory.Location = new System.Drawing.Point(122, 71);
            this.checkBoxAutoWorkingDirectory.Name = "checkBoxAutoWorkingDirectory";
            this.checkBoxAutoWorkingDirectory.Size = new System.Drawing.Size(120, 17);
            this.checkBoxAutoWorkingDirectory.TabIndex = 37;
            this.checkBoxAutoWorkingDirectory.Text = "Automatic detection";
            this.checkBoxAutoWorkingDirectory.UseVisualStyleBackColor = true;
            this.checkBoxAutoWorkingDirectory.CheckedChanged += new System.EventHandler(this.checkBoxAutoWorkingDirectory_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 143);
            this.Controls.Add(this.checkBoxAutoWorkingDirectory);
            this.Controls.Add(this.buttonSettingsCancel);
            this.Controls.Add(this.buttonSettingsOK);
            this.Controls.Add(this.labelWorkingDirectory);
            this.Controls.Add(this.textBoxWorkingDirectory);
            this.Controls.Add(this.labelOclHashcat);
            this.Controls.Add(this.textBoxHashcat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LeukocyteGUI for oclHashCat - Settings";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWorkingDirectory;
        private System.Windows.Forms.TextBox textBoxWorkingDirectory;
        private System.Windows.Forms.Label labelOclHashcat;
        private System.Windows.Forms.TextBox textBoxHashcat;
        private System.Windows.Forms.Button buttonSettingsCancel;
        private System.Windows.Forms.Button buttonSettingsOK;
        private System.Windows.Forms.CheckBox checkBoxAutoWorkingDirectory;
    }
}