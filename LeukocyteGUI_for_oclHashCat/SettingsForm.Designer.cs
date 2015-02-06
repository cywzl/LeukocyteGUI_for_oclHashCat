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
            this.labelOclHashcat = new System.Windows.Forms.Label();
            this.checkBoxAutoWorkingDirectory = new System.Windows.Forms.CheckBox();
            this.openFileDialogHashCat = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogWorkingDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonChooseWorkingDirectory = new System.Windows.Forms.Button();
            this.buttonChooseHashCat = new System.Windows.Forms.Button();
            this.buttonSettingsOK = new System.Windows.Forms.Button();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.checkBoxLoadOnStart = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveOnExit = new System.Windows.Forms.CheckBox();
            this.textBoxHashcat = new System.Windows.Forms.TextBox();
            this.textBoxWorkingDirectory = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonCancelTask = new System.Windows.Forms.Button();
            this.tabControlSettings.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWorkingDirectory
            // 
            this.labelWorkingDirectory.AutoSize = true;
            this.labelWorkingDirectory.Location = new System.Drawing.Point(6, 43);
            this.labelWorkingDirectory.Name = "labelWorkingDirectory";
            this.labelWorkingDirectory.Size = new System.Drawing.Size(93, 13);
            this.labelWorkingDirectory.TabIndex = 34;
            this.labelWorkingDirectory.Text = "Working directory:";
            // 
            // labelOclHashcat
            // 
            this.labelOclHashcat.AutoSize = true;
            this.labelOclHashcat.Location = new System.Drawing.Point(6, 13);
            this.labelOclHashcat.Name = "labelOclHashcat";
            this.labelOclHashcat.Size = new System.Drawing.Size(64, 13);
            this.labelOclHashcat.TabIndex = 32;
            this.labelOclHashcat.Text = "oclHashcat:";
            // 
            // checkBoxAutoWorkingDirectory
            // 
            this.checkBoxAutoWorkingDirectory.AutoSize = true;
            this.checkBoxAutoWorkingDirectory.Checked = true;
            this.checkBoxAutoWorkingDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoWorkingDirectory.Location = new System.Drawing.Point(105, 62);
            this.checkBoxAutoWorkingDirectory.Name = "checkBoxAutoWorkingDirectory";
            this.checkBoxAutoWorkingDirectory.Size = new System.Drawing.Size(120, 17);
            this.checkBoxAutoWorkingDirectory.TabIndex = 37;
            this.checkBoxAutoWorkingDirectory.Text = "Automatic detection";
            this.checkBoxAutoWorkingDirectory.UseVisualStyleBackColor = true;
            this.checkBoxAutoWorkingDirectory.CheckedChanged += new System.EventHandler(this.checkBoxAutoWorkingDirectory_CheckedChanged);
            // 
            // openFileDialogHashCat
            // 
            this.openFileDialogHashCat.FileName = "oclHashcat64.exe";
            this.openFileDialogHashCat.Filter = "oclHashcat executable (*.exe)|*.exe";
            this.openFileDialogHashCat.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogHashCat_FileOk);
            // 
            // buttonChooseWorkingDirectory
            // 
            this.buttonChooseWorkingDirectory.Enabled = false;
            this.buttonChooseWorkingDirectory.FlatAppearance.BorderSize = 0;
            this.buttonChooseWorkingDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseWorkingDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseWorkingDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseWorkingDirectory.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_add_folder16;
            this.buttonChooseWorkingDirectory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseWorkingDirectory.Location = new System.Drawing.Point(422, 39);
            this.buttonChooseWorkingDirectory.Name = "buttonChooseWorkingDirectory";
            this.buttonChooseWorkingDirectory.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseWorkingDirectory.TabIndex = 47;
            this.buttonChooseWorkingDirectory.UseVisualStyleBackColor = true;
            this.buttonChooseWorkingDirectory.Click += new System.EventHandler(this.buttonChooseWorkingDirectory_Click);
            // 
            // buttonChooseHashCat
            // 
            this.buttonChooseHashCat.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChooseHashCat.FlatAppearance.BorderSize = 0;
            this.buttonChooseHashCat.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseHashCat.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseHashCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseHashCat.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe16;
            this.buttonChooseHashCat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseHashCat.Location = new System.Drawing.Point(422, 9);
            this.buttonChooseHashCat.Name = "buttonChooseHashCat";
            this.buttonChooseHashCat.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseHashCat.TabIndex = 46;
            this.buttonChooseHashCat.UseVisualStyleBackColor = true;
            this.buttonChooseHashCat.Click += new System.EventHandler(this.buttonChooseHashCat_Click);
            // 
            // buttonSettingsOK
            // 
            this.buttonSettingsOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonSettingsOK.FlatAppearance.BorderSize = 0;
            this.buttonSettingsOK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSettingsOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettingsOK.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_ok;
            this.buttonSettingsOK.Location = new System.Drawing.Point(392, 243);
            this.buttonSettingsOK.Name = "buttonSettingsOK";
            this.buttonSettingsOK.Padding = new System.Windows.Forms.Padding(3);
            this.buttonSettingsOK.Size = new System.Drawing.Size(40, 40);
            this.buttonSettingsOK.TabIndex = 43;
            this.buttonSettingsOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettingsOK.UseVisualStyleBackColor = true;
            this.buttonSettingsOK.Click += new System.EventHandler(this.buttonSettingsOK_Click);
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageMain);
            this.tabControlSettings.Controls.Add(this.tabPage2);
            this.tabControlSettings.Location = new System.Drawing.Point(12, 12);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(470, 225);
            this.tabControlSettings.TabIndex = 48;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.checkBoxLoadOnStart);
            this.tabPageMain.Controls.Add(this.checkBoxSaveOnExit);
            this.tabPageMain.Controls.Add(this.labelOclHashcat);
            this.tabPageMain.Controls.Add(this.buttonChooseWorkingDirectory);
            this.tabPageMain.Controls.Add(this.textBoxHashcat);
            this.tabPageMain.Controls.Add(this.buttonChooseHashCat);
            this.tabPageMain.Controls.Add(this.textBoxWorkingDirectory);
            this.tabPageMain.Controls.Add(this.labelWorkingDirectory);
            this.tabPageMain.Controls.Add(this.checkBoxAutoWorkingDirectory);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(462, 199);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoadOnStart
            // 
            this.checkBoxLoadOnStart.AutoSize = true;
            this.checkBoxLoadOnStart.Checked = true;
            this.checkBoxLoadOnStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLoadOnStart.Location = new System.Drawing.Point(21, 118);
            this.checkBoxLoadOnStart.Name = "checkBoxLoadOnStart";
            this.checkBoxLoadOnStart.Size = new System.Drawing.Size(227, 17);
            this.checkBoxLoadOnStart.TabIndex = 49;
            this.checkBoxLoadOnStart.Text = "Load the last CrackingTasks file on startup";
            this.checkBoxLoadOnStart.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveOnExit
            // 
            this.checkBoxSaveOnExit.AutoSize = true;
            this.checkBoxSaveOnExit.Checked = true;
            this.checkBoxSaveOnExit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveOnExit.Location = new System.Drawing.Point(21, 95);
            this.checkBoxSaveOnExit.Name = "checkBoxSaveOnExit";
            this.checkBoxSaveOnExit.Size = new System.Drawing.Size(204, 17);
            this.checkBoxSaveOnExit.TabIndex = 48;
            this.checkBoxSaveOnExit.Text = "Save tasks before exiting the program";
            this.checkBoxSaveOnExit.UseVisualStyleBackColor = true;
            // 
            // textBoxHashcat
            // 
            this.textBoxHashcat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default, "Hashcat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxHashcat.Location = new System.Drawing.Point(105, 10);
            this.textBoxHashcat.Name = "textBoxHashcat";
            this.textBoxHashcat.Size = new System.Drawing.Size(311, 20);
            this.textBoxHashcat.TabIndex = 31;
            this.textBoxHashcat.Text = global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default.Hashcat;
            this.textBoxHashcat.TextChanged += new System.EventHandler(this.textBoxHashcat_TextChanged);
            // 
            // textBoxWorkingDirectory
            // 
            this.textBoxWorkingDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default, "WorkingDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxWorkingDirectory.Enabled = false;
            this.textBoxWorkingDirectory.Location = new System.Drawing.Point(105, 40);
            this.textBoxWorkingDirectory.Name = "textBoxWorkingDirectory";
            this.textBoxWorkingDirectory.Size = new System.Drawing.Size(311, 20);
            this.textBoxWorkingDirectory.TabIndex = 33;
            this.textBoxWorkingDirectory.Text = global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default.WorkingDirectory;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 199);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonCancelTask
            // 
            this.buttonCancelTask.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancelTask.FlatAppearance.BorderSize = 0;
            this.buttonCancelTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCancelTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_cancel;
            this.buttonCancelTask.Location = new System.Drawing.Point(438, 243);
            this.buttonCancelTask.Name = "buttonCancelTask";
            this.buttonCancelTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonCancelTask.Size = new System.Drawing.Size(40, 40);
            this.buttonCancelTask.TabIndex = 45;
            this.buttonCancelTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelTask.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 295);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.buttonCancelTask);
            this.Controls.Add(this.buttonSettingsOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LeukocyteGUI for oclHashCat - Settings";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWorkingDirectory;
        private System.Windows.Forms.TextBox textBoxWorkingDirectory;
        private System.Windows.Forms.Label labelOclHashcat;
        private System.Windows.Forms.TextBox textBoxHashcat;
        private System.Windows.Forms.CheckBox checkBoxAutoWorkingDirectory;
        private System.Windows.Forms.Button buttonSettingsOK;
        private System.Windows.Forms.Button buttonChooseHashCat;
        private System.Windows.Forms.Button buttonChooseWorkingDirectory;
        private System.Windows.Forms.OpenFileDialog openFileDialogHashCat;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogWorkingDirectory;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxLoadOnStart;
        private System.Windows.Forms.CheckBox checkBoxSaveOnExit;
        private System.Windows.Forms.Button buttonCancelTask;
    }
}