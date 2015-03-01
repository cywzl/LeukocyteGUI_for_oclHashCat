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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
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
            this.checkBoxMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.checkBoxShowNotifications = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteSameWhenCracked = new System.Windows.Forms.CheckBox();
            this.checkBoxLoadOnStart = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveOnExit = new System.Windows.Forms.CheckBox();
            this.textBoxHashcat = new System.Windows.Forms.TextBox();
            this.textBoxWorkingDirectory = new System.Windows.Forms.TextBox();
            this.tabPageDictionaries = new System.Windows.Forms.TabPage();
            this.buttonAddDictionary = new System.Windows.Forms.Button();
            this.buttonDeleteDictionary = new System.Windows.Forms.Button();
            this.buttonUpDictionary = new System.Windows.Forms.Button();
            this.buttonDownDictionary = new System.Windows.Forms.Button();
            this.buttonClearDictionary = new System.Windows.Forms.Button();
            this.buttonChangeDictionary = new System.Windows.Forms.Button();
            this.listViewDictionaries = new System.Windows.Forms.ListView();
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageMasks = new System.Windows.Forms.TabPage();
            this.buttonAddMask = new System.Windows.Forms.Button();
            this.buttonDeleteMask = new System.Windows.Forms.Button();
            this.buttonUpMask = new System.Windows.Forms.Button();
            this.buttonDownMask = new System.Windows.Forms.Button();
            this.buttonClearMask = new System.Windows.Forms.Button();
            this.buttonChangeMask = new System.Windows.Forms.Button();
            this.listViewMasks = new System.Windows.Forms.ListView();
            this.columnHeaderMaskNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaskDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCharsets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCancelTask = new System.Windows.Forms.Button();
            this.checkBoxShowToolTips = new System.Windows.Forms.CheckBox();
            this.tabControlSettings.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageDictionaries.SuspendLayout();
            this.tabPageMasks.SuspendLayout();
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
            this.buttonSettingsOK.Location = new System.Drawing.Point(393, 275);
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
            this.tabControlSettings.Controls.Add(this.tabPageDictionaries);
            this.tabControlSettings.Controls.Add(this.tabPageMasks);
            this.tabControlSettings.Location = new System.Drawing.Point(12, 12);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(470, 257);
            this.tabControlSettings.TabIndex = 48;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.checkBoxShowToolTips);
            this.tabPageMain.Controls.Add(this.checkBoxMinimizeToTray);
            this.tabPageMain.Controls.Add(this.checkBoxShowNotifications);
            this.tabPageMain.Controls.Add(this.checkBoxDeleteSameWhenCracked);
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
            this.tabPageMain.Size = new System.Drawing.Size(462, 231);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // checkBoxMinimizeToTray
            // 
            this.checkBoxMinimizeToTray.AutoSize = true;
            this.checkBoxMinimizeToTray.Checked = true;
            this.checkBoxMinimizeToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMinimizeToTray.Location = new System.Drawing.Point(21, 187);
            this.checkBoxMinimizeToTray.Name = "checkBoxMinimizeToTray";
            this.checkBoxMinimizeToTray.Size = new System.Drawing.Size(98, 17);
            this.checkBoxMinimizeToTray.TabIndex = 52;
            this.checkBoxMinimizeToTray.Text = "Minimize to tray";
            this.checkBoxMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowNotifications
            // 
            this.checkBoxShowNotifications.AutoSize = true;
            this.checkBoxShowNotifications.Checked = global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default.ShowNotifications;
            this.checkBoxShowNotifications.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowNotifications.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default, "ShowNotifications", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxShowNotifications.Location = new System.Drawing.Point(21, 164);
            this.checkBoxShowNotifications.Name = "checkBoxShowNotifications";
            this.checkBoxShowNotifications.Size = new System.Drawing.Size(189, 17);
            this.checkBoxShowNotifications.TabIndex = 51;
            this.checkBoxShowNotifications.Text = "Show cracking results notifications";
            this.checkBoxShowNotifications.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleteSameWhenCracked
            // 
            this.checkBoxDeleteSameWhenCracked.AutoSize = true;
            this.checkBoxDeleteSameWhenCracked.Location = new System.Drawing.Point(21, 141);
            this.checkBoxDeleteSameWhenCracked.Name = "checkBoxDeleteSameWhenCracked";
            this.checkBoxDeleteSameWhenCracked.Size = new System.Drawing.Size(314, 17);
            this.checkBoxDeleteSameWhenCracked.TabIndex = 50;
            this.checkBoxDeleteSameWhenCracked.Text = "When task is cracked, delete other tasks with the same hash";
            this.checkBoxDeleteSameWhenCracked.UseVisualStyleBackColor = true;
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
            // tabPageDictionaries
            // 
            this.tabPageDictionaries.Controls.Add(this.buttonAddDictionary);
            this.tabPageDictionaries.Controls.Add(this.buttonDeleteDictionary);
            this.tabPageDictionaries.Controls.Add(this.buttonUpDictionary);
            this.tabPageDictionaries.Controls.Add(this.buttonDownDictionary);
            this.tabPageDictionaries.Controls.Add(this.buttonClearDictionary);
            this.tabPageDictionaries.Controls.Add(this.buttonChangeDictionary);
            this.tabPageDictionaries.Controls.Add(this.listViewDictionaries);
            this.tabPageDictionaries.Location = new System.Drawing.Point(4, 22);
            this.tabPageDictionaries.Name = "tabPageDictionaries";
            this.tabPageDictionaries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDictionaries.Size = new System.Drawing.Size(462, 231);
            this.tabPageDictionaries.TabIndex = 1;
            this.tabPageDictionaries.Text = "Dictionaries";
            this.tabPageDictionaries.UseVisualStyleBackColor = true;
            // 
            // buttonAddDictionary
            // 
            this.buttonAddDictionary.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddDictionary.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddDictionary.FlatAppearance.BorderSize = 0;
            this.buttonAddDictionary.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAddDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDictionary.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_plus;
            this.buttonAddDictionary.Location = new System.Drawing.Point(6, 6);
            this.buttonAddDictionary.Name = "buttonAddDictionary";
            this.buttonAddDictionary.Padding = new System.Windows.Forms.Padding(3);
            this.buttonAddDictionary.Size = new System.Drawing.Size(31, 32);
            this.buttonAddDictionary.TabIndex = 18;
            this.buttonAddDictionary.TabStop = false;
            this.buttonAddDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddDictionary.UseVisualStyleBackColor = false;
            this.buttonAddDictionary.Click += new System.EventHandler(this.buttonAddDictionary_Click);
            // 
            // buttonDeleteDictionary
            // 
            this.buttonDeleteDictionary.Enabled = false;
            this.buttonDeleteDictionary.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonDeleteDictionary.FlatAppearance.BorderSize = 0;
            this.buttonDeleteDictionary.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDeleteDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDictionary.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_delete;
            this.buttonDeleteDictionary.Location = new System.Drawing.Point(43, 6);
            this.buttonDeleteDictionary.Name = "buttonDeleteDictionary";
            this.buttonDeleteDictionary.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDeleteDictionary.Size = new System.Drawing.Size(31, 32);
            this.buttonDeleteDictionary.TabIndex = 19;
            this.buttonDeleteDictionary.TabStop = false;
            this.buttonDeleteDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteDictionary.UseVisualStyleBackColor = true;
            this.buttonDeleteDictionary.Click += new System.EventHandler(this.buttonDeleteDictionary_Click);
            // 
            // buttonUpDictionary
            // 
            this.buttonUpDictionary.Enabled = false;
            this.buttonUpDictionary.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonUpDictionary.FlatAppearance.BorderSize = 0;
            this.buttonUpDictionary.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUpDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpDictionary.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_up;
            this.buttonUpDictionary.Location = new System.Drawing.Point(174, 6);
            this.buttonUpDictionary.Name = "buttonUpDictionary";
            this.buttonUpDictionary.Padding = new System.Windows.Forms.Padding(3);
            this.buttonUpDictionary.Size = new System.Drawing.Size(31, 32);
            this.buttonUpDictionary.TabIndex = 20;
            this.buttonUpDictionary.TabStop = false;
            this.buttonUpDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpDictionary.UseVisualStyleBackColor = true;
            this.buttonUpDictionary.Click += new System.EventHandler(this.buttonUpDictionary_Click);
            // 
            // buttonDownDictionary
            // 
            this.buttonDownDictionary.Enabled = false;
            this.buttonDownDictionary.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonDownDictionary.FlatAppearance.BorderSize = 0;
            this.buttonDownDictionary.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDownDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownDictionary.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_down;
            this.buttonDownDictionary.Location = new System.Drawing.Point(211, 6);
            this.buttonDownDictionary.Name = "buttonDownDictionary";
            this.buttonDownDictionary.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDownDictionary.Size = new System.Drawing.Size(31, 32);
            this.buttonDownDictionary.TabIndex = 21;
            this.buttonDownDictionary.TabStop = false;
            this.buttonDownDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDownDictionary.UseVisualStyleBackColor = true;
            this.buttonDownDictionary.Click += new System.EventHandler(this.buttonDownDictionary_Click);
            // 
            // buttonClearDictionary
            // 
            this.buttonClearDictionary.Enabled = false;
            this.buttonClearDictionary.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonClearDictionary.FlatAppearance.BorderSize = 0;
            this.buttonClearDictionary.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClearDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearDictionary.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_clear;
            this.buttonClearDictionary.Location = new System.Drawing.Point(127, 6);
            this.buttonClearDictionary.Name = "buttonClearDictionary";
            this.buttonClearDictionary.Padding = new System.Windows.Forms.Padding(3);
            this.buttonClearDictionary.Size = new System.Drawing.Size(31, 32);
            this.buttonClearDictionary.TabIndex = 23;
            this.buttonClearDictionary.TabStop = false;
            this.buttonClearDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearDictionary.UseVisualStyleBackColor = true;
            this.buttonClearDictionary.Click += new System.EventHandler(this.buttonClearDictionary_Click);
            // 
            // buttonChangeDictionary
            // 
            this.buttonChangeDictionary.Enabled = false;
            this.buttonChangeDictionary.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonChangeDictionary.FlatAppearance.BorderSize = 0;
            this.buttonChangeDictionary.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChangeDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeDictionary.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_edit;
            this.buttonChangeDictionary.Location = new System.Drawing.Point(80, 6);
            this.buttonChangeDictionary.Name = "buttonChangeDictionary";
            this.buttonChangeDictionary.Padding = new System.Windows.Forms.Padding(3);
            this.buttonChangeDictionary.Size = new System.Drawing.Size(31, 32);
            this.buttonChangeDictionary.TabIndex = 22;
            this.buttonChangeDictionary.TabStop = false;
            this.buttonChangeDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeDictionary.UseVisualStyleBackColor = true;
            this.buttonChangeDictionary.Click += new System.EventHandler(this.buttonChangeDictionary_Click);
            // 
            // listViewDictionaries
            // 
            this.listViewDictionaries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumber,
            this.columnHeaderDescription,
            this.columnHeaderSize,
            this.columnHeaderPath});
            this.listViewDictionaries.FullRowSelect = true;
            this.listViewDictionaries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDictionaries.Location = new System.Drawing.Point(6, 44);
            this.listViewDictionaries.MultiSelect = false;
            this.listViewDictionaries.Name = "listViewDictionaries";
            this.listViewDictionaries.Size = new System.Drawing.Size(450, 181);
            this.listViewDictionaries.TabIndex = 0;
            this.listViewDictionaries.UseCompatibleStateImageBehavior = false;
            this.listViewDictionaries.View = System.Windows.Forms.View.Details;
            this.listViewDictionaries.SelectedIndexChanged += new System.EventHandler(this.listViewDictionaries_SelectedIndexChanged);
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "#";
            this.columnHeaderNumber.Width = 30;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 148;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Path";
            this.columnHeaderPath.Width = 203;
            // 
            // tabPageMasks
            // 
            this.tabPageMasks.Controls.Add(this.buttonAddMask);
            this.tabPageMasks.Controls.Add(this.buttonDeleteMask);
            this.tabPageMasks.Controls.Add(this.buttonUpMask);
            this.tabPageMasks.Controls.Add(this.buttonDownMask);
            this.tabPageMasks.Controls.Add(this.buttonClearMask);
            this.tabPageMasks.Controls.Add(this.buttonChangeMask);
            this.tabPageMasks.Controls.Add(this.listViewMasks);
            this.tabPageMasks.Location = new System.Drawing.Point(4, 22);
            this.tabPageMasks.Name = "tabPageMasks";
            this.tabPageMasks.Size = new System.Drawing.Size(462, 231);
            this.tabPageMasks.TabIndex = 2;
            this.tabPageMasks.Text = "Masks";
            this.tabPageMasks.UseVisualStyleBackColor = true;
            // 
            // buttonAddMask
            // 
            this.buttonAddMask.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddMask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddMask.FlatAppearance.BorderSize = 0;
            this.buttonAddMask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAddMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_plus;
            this.buttonAddMask.Location = new System.Drawing.Point(6, 6);
            this.buttonAddMask.Name = "buttonAddMask";
            this.buttonAddMask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonAddMask.Size = new System.Drawing.Size(31, 32);
            this.buttonAddMask.TabIndex = 25;
            this.buttonAddMask.TabStop = false;
            this.buttonAddMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddMask.UseVisualStyleBackColor = false;
            this.buttonAddMask.Click += new System.EventHandler(this.buttonAddMask_Click);
            // 
            // buttonDeleteMask
            // 
            this.buttonDeleteMask.Enabled = false;
            this.buttonDeleteMask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonDeleteMask.FlatAppearance.BorderSize = 0;
            this.buttonDeleteMask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDeleteMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteMask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_delete;
            this.buttonDeleteMask.Location = new System.Drawing.Point(43, 6);
            this.buttonDeleteMask.Name = "buttonDeleteMask";
            this.buttonDeleteMask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDeleteMask.Size = new System.Drawing.Size(31, 32);
            this.buttonDeleteMask.TabIndex = 26;
            this.buttonDeleteMask.TabStop = false;
            this.buttonDeleteMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteMask.UseVisualStyleBackColor = true;
            this.buttonDeleteMask.Click += new System.EventHandler(this.buttonDeleteMask_Click);
            // 
            // buttonUpMask
            // 
            this.buttonUpMask.Enabled = false;
            this.buttonUpMask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonUpMask.FlatAppearance.BorderSize = 0;
            this.buttonUpMask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUpMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpMask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_up;
            this.buttonUpMask.Location = new System.Drawing.Point(174, 6);
            this.buttonUpMask.Name = "buttonUpMask";
            this.buttonUpMask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonUpMask.Size = new System.Drawing.Size(31, 32);
            this.buttonUpMask.TabIndex = 27;
            this.buttonUpMask.TabStop = false;
            this.buttonUpMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpMask.UseVisualStyleBackColor = true;
            this.buttonUpMask.Click += new System.EventHandler(this.buttonUpMask_Click);
            // 
            // buttonDownMask
            // 
            this.buttonDownMask.Enabled = false;
            this.buttonDownMask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonDownMask.FlatAppearance.BorderSize = 0;
            this.buttonDownMask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDownMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownMask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_down;
            this.buttonDownMask.Location = new System.Drawing.Point(211, 6);
            this.buttonDownMask.Name = "buttonDownMask";
            this.buttonDownMask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDownMask.Size = new System.Drawing.Size(31, 32);
            this.buttonDownMask.TabIndex = 28;
            this.buttonDownMask.TabStop = false;
            this.buttonDownMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDownMask.UseVisualStyleBackColor = true;
            this.buttonDownMask.Click += new System.EventHandler(this.buttonDownMask_Click);
            // 
            // buttonClearMask
            // 
            this.buttonClearMask.Enabled = false;
            this.buttonClearMask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonClearMask.FlatAppearance.BorderSize = 0;
            this.buttonClearMask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClearMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearMask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_clear;
            this.buttonClearMask.Location = new System.Drawing.Point(127, 6);
            this.buttonClearMask.Name = "buttonClearMask";
            this.buttonClearMask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonClearMask.Size = new System.Drawing.Size(31, 32);
            this.buttonClearMask.TabIndex = 30;
            this.buttonClearMask.TabStop = false;
            this.buttonClearMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearMask.UseVisualStyleBackColor = true;
            this.buttonClearMask.Click += new System.EventHandler(this.buttonClearMask_Click);
            // 
            // buttonChangeMask
            // 
            this.buttonChangeMask.Enabled = false;
            this.buttonChangeMask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonChangeMask.FlatAppearance.BorderSize = 0;
            this.buttonChangeMask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChangeMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeMask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_edit;
            this.buttonChangeMask.Location = new System.Drawing.Point(80, 6);
            this.buttonChangeMask.Name = "buttonChangeMask";
            this.buttonChangeMask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonChangeMask.Size = new System.Drawing.Size(31, 32);
            this.buttonChangeMask.TabIndex = 29;
            this.buttonChangeMask.TabStop = false;
            this.buttonChangeMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeMask.UseVisualStyleBackColor = true;
            this.buttonChangeMask.Click += new System.EventHandler(this.buttonChangeMask_Click);
            // 
            // listViewMasks
            // 
            this.listViewMasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMaskNumber,
            this.columnHeaderMaskDescription,
            this.columnHeaderMask,
            this.columnHeaderCharsets});
            this.listViewMasks.FullRowSelect = true;
            this.listViewMasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMasks.Location = new System.Drawing.Point(6, 44);
            this.listViewMasks.MultiSelect = false;
            this.listViewMasks.Name = "listViewMasks";
            this.listViewMasks.Size = new System.Drawing.Size(450, 181);
            this.listViewMasks.TabIndex = 24;
            this.listViewMasks.UseCompatibleStateImageBehavior = false;
            this.listViewMasks.View = System.Windows.Forms.View.Details;
            this.listViewMasks.SelectedIndexChanged += new System.EventHandler(this.listViewMasks_SelectedIndexChanged);
            // 
            // columnHeaderMaskNumber
            // 
            this.columnHeaderMaskNumber.Text = "#";
            this.columnHeaderMaskNumber.Width = 30;
            // 
            // columnHeaderMaskDescription
            // 
            this.columnHeaderMaskDescription.Text = "Description";
            this.columnHeaderMaskDescription.Width = 121;
            // 
            // columnHeaderMask
            // 
            this.columnHeaderMask.Text = "Mask";
            this.columnHeaderMask.Width = 143;
            // 
            // columnHeaderCharsets
            // 
            this.columnHeaderCharsets.Text = "Charsets";
            this.columnHeaderCharsets.Width = 147;
            // 
            // buttonCancelTask
            // 
            this.buttonCancelTask.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancelTask.FlatAppearance.BorderSize = 0;
            this.buttonCancelTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCancelTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_cancel;
            this.buttonCancelTask.Location = new System.Drawing.Point(439, 275);
            this.buttonCancelTask.Name = "buttonCancelTask";
            this.buttonCancelTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonCancelTask.Size = new System.Drawing.Size(40, 40);
            this.buttonCancelTask.TabIndex = 45;
            this.buttonCancelTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelTask.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowToolTips
            // 
            this.checkBoxShowToolTips.AutoSize = true;
            this.checkBoxShowToolTips.Location = new System.Drawing.Point(21, 210);
            this.checkBoxShowToolTips.Name = "checkBoxShowToolTips";
            this.checkBoxShowToolTips.Size = new System.Drawing.Size(92, 17);
            this.checkBoxShowToolTips.TabIndex = 53;
            this.checkBoxShowToolTips.Text = "Show tool tips";
            this.checkBoxShowToolTips.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 327);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.buttonCancelTask);
            this.Controls.Add(this.buttonSettingsOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LeukocyteGUI for oclHashCat - Settings";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageDictionaries.ResumeLayout(false);
            this.tabPageMasks.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPageDictionaries;
        private System.Windows.Forms.CheckBox checkBoxLoadOnStart;
        private System.Windows.Forms.CheckBox checkBoxSaveOnExit;
        private System.Windows.Forms.Button buttonCancelTask;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.Button buttonAddDictionary;
        private System.Windows.Forms.Button buttonDeleteDictionary;
        private System.Windows.Forms.Button buttonUpDictionary;
        private System.Windows.Forms.Button buttonDownDictionary;
        private System.Windows.Forms.Button buttonClearDictionary;
        private System.Windows.Forms.Button buttonChangeDictionary;
        public System.Windows.Forms.ListView listViewDictionaries;
        private System.Windows.Forms.TabPage tabPageMasks;
        private System.Windows.Forms.Button buttonAddMask;
        private System.Windows.Forms.Button buttonDeleteMask;
        private System.Windows.Forms.Button buttonUpMask;
        private System.Windows.Forms.Button buttonDownMask;
        private System.Windows.Forms.Button buttonClearMask;
        private System.Windows.Forms.Button buttonChangeMask;
        public System.Windows.Forms.ListView listViewMasks;
        private System.Windows.Forms.ColumnHeader columnHeaderMaskNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderMaskDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderMask;
        private System.Windows.Forms.ColumnHeader columnHeaderCharsets;
        private System.Windows.Forms.CheckBox checkBoxDeleteSameWhenCracked;
        private System.Windows.Forms.CheckBox checkBoxShowNotifications;
        private System.Windows.Forms.CheckBox checkBoxMinimizeToTray;
        private System.Windows.Forms.CheckBox checkBoxShowToolTips;
    }
}