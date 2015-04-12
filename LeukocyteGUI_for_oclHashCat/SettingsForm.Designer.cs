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
            this.tabPagePathes = new System.Windows.Forms.TabPage();
            this.groupBoxSystem = new System.Windows.Forms.GroupBox();
            this.buttonChooseLogFilesPath = new System.Windows.Forms.Button();
            this.labelLogFilesPath = new System.Windows.Forms.Label();
            this.textBoxLogFilesPath = new System.Windows.Forms.TextBox();
            this.groupBoxConverter = new System.Windows.Forms.GroupBox();
            this.buttonChooseAircrack = new System.Windows.Forms.Button();
            this.buttonChooseConverterOutput = new System.Windows.Forms.Button();
            this.labelAircrack = new System.Windows.Forms.Label();
            this.textBoxAircrack = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConverterOutput = new System.Windows.Forms.TextBox();
            this.groupBoxHashcat = new System.Windows.Forms.GroupBox();
            this.textBoxWorkingDirectory = new System.Windows.Forms.TextBox();
            this.textBoxHashcat = new System.Windows.Forms.TextBox();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.panelCheckboxSettings = new System.Windows.Forms.Panel();
            this.checkBoxUseSavedSizes = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveFormsSizes = new System.Windows.Forms.CheckBox();
            this.checkBoxDebugMode = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveOnExit = new System.Windows.Forms.CheckBox();
            this.checkBoxShowToolTips = new System.Windows.Forms.CheckBox();
            this.checkBoxLoadOnStart = new System.Windows.Forms.CheckBox();
            this.checkBoxMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteSameWhenCracked = new System.Windows.Forms.CheckBox();
            this.checkBoxShowNotifications = new System.Windows.Forms.CheckBox();
            this.tabPageSizes = new System.Windows.Forms.TabPage();
            this.groupBoxMaskEditorSizes = new System.Windows.Forms.GroupBox();
            this.numericUpDownMaskEditorHeight = new System.Windows.Forms.NumericUpDown();
            this.labelMaskEditorHeight = new System.Windows.Forms.Label();
            this.numericUpDownMaskEditorWidth = new System.Windows.Forms.NumericUpDown();
            this.labelMaskEditorWidth = new System.Windows.Forms.Label();
            this.groupBoxDictionaryEditorSizes = new System.Windows.Forms.GroupBox();
            this.numericUpDownDictionaryEditorHeight = new System.Windows.Forms.NumericUpDown();
            this.labelDictionaryEditorHeight = new System.Windows.Forms.Label();
            this.numericUpDownDictionaryEditorWidth = new System.Windows.Forms.NumericUpDown();
            this.labelDictionaryEditorWidth = new System.Windows.Forms.Label();
            this.groupBoxConverterSizes = new System.Windows.Forms.GroupBox();
            this.numericUpDownConverterHeight = new System.Windows.Forms.NumericUpDown();
            this.labelConverterHeight = new System.Windows.Forms.Label();
            this.numericUpDownConverterWidth = new System.Windows.Forms.NumericUpDown();
            this.labelConverterWidth = new System.Windows.Forms.Label();
            this.groupBoxSettingsSizes = new System.Windows.Forms.GroupBox();
            this.numericUpDownSettingsHeight = new System.Windows.Forms.NumericUpDown();
            this.labelSettingsHeight = new System.Windows.Forms.Label();
            this.numericUpDownSettingsWidth = new System.Windows.Forms.NumericUpDown();
            this.labelSettingsWidth = new System.Windows.Forms.Label();
            this.groupBoxTaskEditorSizes = new System.Windows.Forms.GroupBox();
            this.numericUpDownTaskEditorHeight = new System.Windows.Forms.NumericUpDown();
            this.labelTaskEditorHeight = new System.Windows.Forms.Label();
            this.numericUpDownTaskEditorWidth = new System.Windows.Forms.NumericUpDown();
            this.labelTaskEditorWidth = new System.Windows.Forms.Label();
            this.groupBoxMainSizes = new System.Windows.Forms.GroupBox();
            this.numericUpDownMainHeight = new System.Windows.Forms.NumericUpDown();
            this.labelMainHeight = new System.Windows.Forms.Label();
            this.numericUpDownMainWidth = new System.Windows.Forms.NumericUpDown();
            this.labelMainWidth = new System.Windows.Forms.Label();
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
            this.folderBrowserDialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogConverter = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogLogFiles = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControlSettings.SuspendLayout();
            this.tabPagePathes.SuspendLayout();
            this.groupBoxSystem.SuspendLayout();
            this.groupBoxConverter.SuspendLayout();
            this.groupBoxHashcat.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.panelCheckboxSettings.SuspendLayout();
            this.tabPageSizes.SuspendLayout();
            this.groupBoxMaskEditorSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaskEditorHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaskEditorWidth)).BeginInit();
            this.groupBoxDictionaryEditorSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDictionaryEditorHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDictionaryEditorWidth)).BeginInit();
            this.groupBoxConverterSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConverterHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConverterWidth)).BeginInit();
            this.groupBoxSettingsSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSettingsHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSettingsWidth)).BeginInit();
            this.groupBoxTaskEditorSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaskEditorHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaskEditorWidth)).BeginInit();
            this.groupBoxMainSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMainHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMainWidth)).BeginInit();
            this.tabPageDictionaries.SuspendLayout();
            this.tabPageMasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWorkingDirectory
            // 
            this.labelWorkingDirectory.AutoSize = true;
            this.labelWorkingDirectory.Location = new System.Drawing.Point(16, 51);
            this.labelWorkingDirectory.Name = "labelWorkingDirectory";
            this.labelWorkingDirectory.Size = new System.Drawing.Size(93, 13);
            this.labelWorkingDirectory.TabIndex = 34;
            this.labelWorkingDirectory.Text = "Working directory:";
            // 
            // labelOclHashcat
            // 
            this.labelOclHashcat.AutoSize = true;
            this.labelOclHashcat.Location = new System.Drawing.Point(16, 21);
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
            this.checkBoxAutoWorkingDirectory.Location = new System.Drawing.Point(115, 70);
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
            this.buttonChooseWorkingDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseWorkingDirectory.Enabled = false;
            this.buttonChooseWorkingDirectory.FlatAppearance.BorderSize = 0;
            this.buttonChooseWorkingDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseWorkingDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseWorkingDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseWorkingDirectory.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_add_folder16;
            this.buttonChooseWorkingDirectory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseWorkingDirectory.Location = new System.Drawing.Point(413, 47);
            this.buttonChooseWorkingDirectory.Name = "buttonChooseWorkingDirectory";
            this.buttonChooseWorkingDirectory.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseWorkingDirectory.TabIndex = 47;
            this.buttonChooseWorkingDirectory.UseVisualStyleBackColor = true;
            this.buttonChooseWorkingDirectory.Click += new System.EventHandler(this.buttonChooseWorkingDirectory_Click);
            // 
            // buttonChooseHashCat
            // 
            this.buttonChooseHashCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseHashCat.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChooseHashCat.FlatAppearance.BorderSize = 0;
            this.buttonChooseHashCat.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseHashCat.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseHashCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseHashCat.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe16;
            this.buttonChooseHashCat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseHashCat.Location = new System.Drawing.Point(413, 17);
            this.buttonChooseHashCat.Name = "buttonChooseHashCat";
            this.buttonChooseHashCat.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseHashCat.TabIndex = 46;
            this.buttonChooseHashCat.UseVisualStyleBackColor = true;
            this.buttonChooseHashCat.Click += new System.EventHandler(this.buttonChooseHashCat_Click);
            // 
            // buttonSettingsOK
            // 
            this.buttonSettingsOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettingsOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonSettingsOK.FlatAppearance.BorderSize = 0;
            this.buttonSettingsOK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSettingsOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettingsOK.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_ok;
            this.buttonSettingsOK.Location = new System.Drawing.Point(397, 295);
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
            this.tabControlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSettings.Controls.Add(this.tabPagePathes);
            this.tabControlSettings.Controls.Add(this.tabPageOptions);
            this.tabControlSettings.Controls.Add(this.tabPageSizes);
            this.tabControlSettings.Controls.Add(this.tabPageDictionaries);
            this.tabControlSettings.Controls.Add(this.tabPageMasks);
            this.tabControlSettings.Location = new System.Drawing.Point(12, 12);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(474, 277);
            this.tabControlSettings.TabIndex = 48;
            // 
            // tabPagePathes
            // 
            this.tabPagePathes.Controls.Add(this.groupBoxSystem);
            this.tabPagePathes.Controls.Add(this.groupBoxConverter);
            this.tabPagePathes.Controls.Add(this.groupBoxHashcat);
            this.tabPagePathes.Location = new System.Drawing.Point(4, 22);
            this.tabPagePathes.Name = "tabPagePathes";
            this.tabPagePathes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePathes.Size = new System.Drawing.Size(466, 251);
            this.tabPagePathes.TabIndex = 0;
            this.tabPagePathes.Text = "Pathes";
            this.tabPagePathes.UseVisualStyleBackColor = true;
            // 
            // groupBoxSystem
            // 
            this.groupBoxSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSystem.Controls.Add(this.buttonChooseLogFilesPath);
            this.groupBoxSystem.Controls.Add(this.labelLogFilesPath);
            this.groupBoxSystem.Controls.Add(this.textBoxLogFilesPath);
            this.groupBoxSystem.Location = new System.Drawing.Point(6, 193);
            this.groupBoxSystem.Name = "groupBoxSystem";
            this.groupBoxSystem.Size = new System.Drawing.Size(453, 51);
            this.groupBoxSystem.TabIndex = 56;
            this.groupBoxSystem.TabStop = false;
            this.groupBoxSystem.Text = "System";
            // 
            // buttonChooseLogFilesPath
            // 
            this.buttonChooseLogFilesPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseLogFilesPath.FlatAppearance.BorderSize = 0;
            this.buttonChooseLogFilesPath.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseLogFilesPath.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseLogFilesPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseLogFilesPath.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_add_folder16;
            this.buttonChooseLogFilesPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseLogFilesPath.Location = new System.Drawing.Point(413, 17);
            this.buttonChooseLogFilesPath.Name = "buttonChooseLogFilesPath";
            this.buttonChooseLogFilesPath.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseLogFilesPath.TabIndex = 56;
            this.buttonChooseLogFilesPath.UseVisualStyleBackColor = true;
            this.buttonChooseLogFilesPath.Click += new System.EventHandler(this.buttonChooseLogFilesPath_Click);
            // 
            // labelLogFilesPath
            // 
            this.labelLogFilesPath.AutoSize = true;
            this.labelLogFilesPath.Location = new System.Drawing.Point(16, 21);
            this.labelLogFilesPath.Name = "labelLogFilesPath";
            this.labelLogFilesPath.Size = new System.Drawing.Size(73, 13);
            this.labelLogFilesPath.TabIndex = 49;
            this.labelLogFilesPath.Text = "Log files path:";
            // 
            // textBoxLogFilesPath
            // 
            this.textBoxLogFilesPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogFilesPath.Location = new System.Drawing.Point(115, 18);
            this.textBoxLogFilesPath.Name = "textBoxLogFilesPath";
            this.textBoxLogFilesPath.Size = new System.Drawing.Size(292, 20);
            this.textBoxLogFilesPath.TabIndex = 48;
            // 
            // groupBoxConverter
            // 
            this.groupBoxConverter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConverter.Controls.Add(this.buttonChooseAircrack);
            this.groupBoxConverter.Controls.Add(this.buttonChooseConverterOutput);
            this.groupBoxConverter.Controls.Add(this.labelAircrack);
            this.groupBoxConverter.Controls.Add(this.textBoxAircrack);
            this.groupBoxConverter.Controls.Add(this.label2);
            this.groupBoxConverter.Controls.Add(this.textBoxConverterOutput);
            this.groupBoxConverter.Location = new System.Drawing.Point(6, 107);
            this.groupBoxConverter.Name = "groupBoxConverter";
            this.groupBoxConverter.Size = new System.Drawing.Size(453, 80);
            this.groupBoxConverter.TabIndex = 55;
            this.groupBoxConverter.TabStop = false;
            this.groupBoxConverter.Text = "Converter";
            // 
            // buttonChooseAircrack
            // 
            this.buttonChooseAircrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseAircrack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChooseAircrack.FlatAppearance.BorderSize = 0;
            this.buttonChooseAircrack.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseAircrack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseAircrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseAircrack.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe16;
            this.buttonChooseAircrack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseAircrack.Location = new System.Drawing.Point(413, 17);
            this.buttonChooseAircrack.Name = "buttonChooseAircrack";
            this.buttonChooseAircrack.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseAircrack.TabIndex = 54;
            this.buttonChooseAircrack.UseVisualStyleBackColor = true;
            this.buttonChooseAircrack.Click += new System.EventHandler(this.buttonChooseAircrack_Click);
            // 
            // buttonChooseConverterOutput
            // 
            this.buttonChooseConverterOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseConverterOutput.FlatAppearance.BorderSize = 0;
            this.buttonChooseConverterOutput.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseConverterOutput.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseConverterOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseConverterOutput.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_add_folder16;
            this.buttonChooseConverterOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseConverterOutput.Location = new System.Drawing.Point(413, 47);
            this.buttonChooseConverterOutput.Name = "buttonChooseConverterOutput";
            this.buttonChooseConverterOutput.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseConverterOutput.TabIndex = 55;
            this.buttonChooseConverterOutput.UseVisualStyleBackColor = true;
            this.buttonChooseConverterOutput.Click += new System.EventHandler(this.buttonChooseConverterOutput_Click);
            // 
            // labelAircrack
            // 
            this.labelAircrack.AutoSize = true;
            this.labelAircrack.Location = new System.Drawing.Point(16, 21);
            this.labelAircrack.Name = "labelAircrack";
            this.labelAircrack.Size = new System.Drawing.Size(83, 13);
            this.labelAircrack.TabIndex = 51;
            this.labelAircrack.Text = "aircrack-ng.exe:";
            // 
            // textBoxAircrack
            // 
            this.textBoxAircrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircrack.Location = new System.Drawing.Point(115, 18);
            this.textBoxAircrack.Name = "textBoxAircrack";
            this.textBoxAircrack.Size = new System.Drawing.Size(292, 20);
            this.textBoxAircrack.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Output path:";
            // 
            // textBoxConverterOutput
            // 
            this.textBoxConverterOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConverterOutput.Location = new System.Drawing.Point(115, 48);
            this.textBoxConverterOutput.Name = "textBoxConverterOutput";
            this.textBoxConverterOutput.Size = new System.Drawing.Size(292, 20);
            this.textBoxConverterOutput.TabIndex = 52;
            // 
            // groupBoxHashcat
            // 
            this.groupBoxHashcat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHashcat.Controls.Add(this.labelOclHashcat);
            this.groupBoxHashcat.Controls.Add(this.checkBoxAutoWorkingDirectory);
            this.groupBoxHashcat.Controls.Add(this.labelWorkingDirectory);
            this.groupBoxHashcat.Controls.Add(this.textBoxWorkingDirectory);
            this.groupBoxHashcat.Controls.Add(this.buttonChooseHashCat);
            this.groupBoxHashcat.Controls.Add(this.textBoxHashcat);
            this.groupBoxHashcat.Controls.Add(this.buttonChooseWorkingDirectory);
            this.groupBoxHashcat.Location = new System.Drawing.Point(6, 6);
            this.groupBoxHashcat.Name = "groupBoxHashcat";
            this.groupBoxHashcat.Size = new System.Drawing.Size(453, 95);
            this.groupBoxHashcat.TabIndex = 54;
            this.groupBoxHashcat.TabStop = false;
            this.groupBoxHashcat.Text = "Hashcat";
            // 
            // textBoxWorkingDirectory
            // 
            this.textBoxWorkingDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWorkingDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default, "WorkingDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxWorkingDirectory.Enabled = false;
            this.textBoxWorkingDirectory.Location = new System.Drawing.Point(115, 48);
            this.textBoxWorkingDirectory.Name = "textBoxWorkingDirectory";
            this.textBoxWorkingDirectory.Size = new System.Drawing.Size(292, 20);
            this.textBoxWorkingDirectory.TabIndex = 33;
            this.textBoxWorkingDirectory.Text = global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default.WorkingDirectory;
            // 
            // textBoxHashcat
            // 
            this.textBoxHashcat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHashcat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default, "Hashcat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxHashcat.Location = new System.Drawing.Point(115, 18);
            this.textBoxHashcat.Name = "textBoxHashcat";
            this.textBoxHashcat.Size = new System.Drawing.Size(292, 20);
            this.textBoxHashcat.TabIndex = 31;
            this.textBoxHashcat.Text = global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default.Hashcat;
            this.textBoxHashcat.TextChanged += new System.EventHandler(this.textBoxHashcat_TextChanged);
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.panelCheckboxSettings);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptions.Size = new System.Drawing.Size(466, 251);
            this.tabPageOptions.TabIndex = 3;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // panelCheckboxSettings
            // 
            this.panelCheckboxSettings.AutoScroll = true;
            this.panelCheckboxSettings.Controls.Add(this.checkBoxUseSavedSizes);
            this.panelCheckboxSettings.Controls.Add(this.checkBoxSaveFormsSizes);
            this.panelCheckboxSettings.Controls.Add(this.checkBoxDebugMode);
            this.panelCheckboxSettings.Controls.Add(this.checkBoxSaveOnExit);
            this.panelCheckboxSettings.Controls.Add(this.checkBoxShowToolTips);
            this.panelCheckboxSettings.Controls.Add(this.checkBoxLoadOnStart);
            this.panelCheckboxSettings.Controls.Add(this.checkBoxMinimizeToTray);
            this.panelCheckboxSettings.Controls.Add(this.checkBoxDeleteSameWhenCracked);
            this.panelCheckboxSettings.Controls.Add(this.checkBoxShowNotifications);
            this.panelCheckboxSettings.Location = new System.Drawing.Point(0, 3);
            this.panelCheckboxSettings.Name = "panelCheckboxSettings";
            this.panelCheckboxSettings.Size = new System.Drawing.Size(456, 225);
            this.panelCheckboxSettings.TabIndex = 55;
            // 
            // checkBoxUseSavedSizes
            // 
            this.checkBoxUseSavedSizes.AutoSize = true;
            this.checkBoxUseSavedSizes.Location = new System.Drawing.Point(15, 197);
            this.checkBoxUseSavedSizes.Name = "checkBoxUseSavedSizes";
            this.checkBoxUseSavedSizes.Size = new System.Drawing.Size(103, 17);
            this.checkBoxUseSavedSizes.TabIndex = 56;
            this.checkBoxUseSavedSizes.Text = "Use saved sizes";
            this.checkBoxUseSavedSizes.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveFormsSizes
            // 
            this.checkBoxSaveFormsSizes.AutoSize = true;
            this.checkBoxSaveFormsSizes.Location = new System.Drawing.Point(15, 174);
            this.checkBoxSaveFormsSizes.Name = "checkBoxSaveFormsSizes";
            this.checkBoxSaveFormsSizes.Size = new System.Drawing.Size(191, 17);
            this.checkBoxSaveFormsSizes.TabIndex = 55;
            this.checkBoxSaveFormsSizes.Text = "Save form size when form is closed";
            this.checkBoxSaveFormsSizes.UseVisualStyleBackColor = true;
            // 
            // checkBoxDebugMode
            // 
            this.checkBoxDebugMode.AutoSize = true;
            this.checkBoxDebugMode.Location = new System.Drawing.Point(15, 151);
            this.checkBoxDebugMode.Name = "checkBoxDebugMode";
            this.checkBoxDebugMode.Size = new System.Drawing.Size(124, 17);
            this.checkBoxDebugMode.TabIndex = 54;
            this.checkBoxDebugMode.Text = "Enable Debug Mode";
            this.checkBoxDebugMode.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveOnExit
            // 
            this.checkBoxSaveOnExit.AutoSize = true;
            this.checkBoxSaveOnExit.Checked = true;
            this.checkBoxSaveOnExit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveOnExit.Location = new System.Drawing.Point(15, 12);
            this.checkBoxSaveOnExit.Name = "checkBoxSaveOnExit";
            this.checkBoxSaveOnExit.Size = new System.Drawing.Size(204, 17);
            this.checkBoxSaveOnExit.TabIndex = 48;
            this.checkBoxSaveOnExit.Text = "Save tasks before exiting the program";
            this.checkBoxSaveOnExit.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowToolTips
            // 
            this.checkBoxShowToolTips.AutoSize = true;
            this.checkBoxShowToolTips.Location = new System.Drawing.Point(15, 128);
            this.checkBoxShowToolTips.Name = "checkBoxShowToolTips";
            this.checkBoxShowToolTips.Size = new System.Drawing.Size(92, 17);
            this.checkBoxShowToolTips.TabIndex = 53;
            this.checkBoxShowToolTips.Text = "Show tool tips";
            this.checkBoxShowToolTips.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoadOnStart
            // 
            this.checkBoxLoadOnStart.AutoSize = true;
            this.checkBoxLoadOnStart.Checked = true;
            this.checkBoxLoadOnStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLoadOnStart.Location = new System.Drawing.Point(15, 36);
            this.checkBoxLoadOnStart.Name = "checkBoxLoadOnStart";
            this.checkBoxLoadOnStart.Size = new System.Drawing.Size(227, 17);
            this.checkBoxLoadOnStart.TabIndex = 49;
            this.checkBoxLoadOnStart.Text = "Load the last CrackingTasks file on startup";
            this.checkBoxLoadOnStart.UseVisualStyleBackColor = true;
            // 
            // checkBoxMinimizeToTray
            // 
            this.checkBoxMinimizeToTray.AutoSize = true;
            this.checkBoxMinimizeToTray.Checked = true;
            this.checkBoxMinimizeToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMinimizeToTray.Location = new System.Drawing.Point(15, 105);
            this.checkBoxMinimizeToTray.Name = "checkBoxMinimizeToTray";
            this.checkBoxMinimizeToTray.Size = new System.Drawing.Size(98, 17);
            this.checkBoxMinimizeToTray.TabIndex = 52;
            this.checkBoxMinimizeToTray.Text = "Minimize to tray";
            this.checkBoxMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleteSameWhenCracked
            // 
            this.checkBoxDeleteSameWhenCracked.AutoSize = true;
            this.checkBoxDeleteSameWhenCracked.Location = new System.Drawing.Point(15, 59);
            this.checkBoxDeleteSameWhenCracked.Name = "checkBoxDeleteSameWhenCracked";
            this.checkBoxDeleteSameWhenCracked.Size = new System.Drawing.Size(314, 17);
            this.checkBoxDeleteSameWhenCracked.TabIndex = 50;
            this.checkBoxDeleteSameWhenCracked.Text = "When task is cracked, delete other tasks with the same hash";
            this.checkBoxDeleteSameWhenCracked.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowNotifications
            // 
            this.checkBoxShowNotifications.AutoSize = true;
            this.checkBoxShowNotifications.Checked = global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default.ShowNotifications;
            this.checkBoxShowNotifications.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowNotifications.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default, "ShowNotifications", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxShowNotifications.Location = new System.Drawing.Point(15, 82);
            this.checkBoxShowNotifications.Name = "checkBoxShowNotifications";
            this.checkBoxShowNotifications.Size = new System.Drawing.Size(189, 17);
            this.checkBoxShowNotifications.TabIndex = 51;
            this.checkBoxShowNotifications.Text = "Show cracking results notifications";
            this.checkBoxShowNotifications.UseVisualStyleBackColor = true;
            // 
            // tabPageSizes
            // 
            this.tabPageSizes.Controls.Add(this.groupBoxMaskEditorSizes);
            this.tabPageSizes.Controls.Add(this.groupBoxDictionaryEditorSizes);
            this.tabPageSizes.Controls.Add(this.groupBoxConverterSizes);
            this.tabPageSizes.Controls.Add(this.groupBoxSettingsSizes);
            this.tabPageSizes.Controls.Add(this.groupBoxTaskEditorSizes);
            this.tabPageSizes.Controls.Add(this.groupBoxMainSizes);
            this.tabPageSizes.Location = new System.Drawing.Point(4, 22);
            this.tabPageSizes.Name = "tabPageSizes";
            this.tabPageSizes.Size = new System.Drawing.Size(466, 251);
            this.tabPageSizes.TabIndex = 4;
            this.tabPageSizes.Text = "Sizes";
            this.tabPageSizes.UseVisualStyleBackColor = true;
            // 
            // groupBoxMaskEditorSizes
            // 
            this.groupBoxMaskEditorSizes.Controls.Add(this.numericUpDownMaskEditorHeight);
            this.groupBoxMaskEditorSizes.Controls.Add(this.labelMaskEditorHeight);
            this.groupBoxMaskEditorSizes.Controls.Add(this.numericUpDownMaskEditorWidth);
            this.groupBoxMaskEditorSizes.Controls.Add(this.labelMaskEditorWidth);
            this.groupBoxMaskEditorSizes.Location = new System.Drawing.Point(302, 102);
            this.groupBoxMaskEditorSizes.Name = "groupBoxMaskEditorSizes";
            this.groupBoxMaskEditorSizes.Size = new System.Drawing.Size(139, 84);
            this.groupBoxMaskEditorSizes.TabIndex = 5;
            this.groupBoxMaskEditorSizes.TabStop = false;
            this.groupBoxMaskEditorSizes.Text = "Mask Editor Form";
            // 
            // numericUpDownMaskEditorHeight
            // 
            this.numericUpDownMaskEditorHeight.Location = new System.Drawing.Point(62, 47);
            this.numericUpDownMaskEditorHeight.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.numericUpDownMaskEditorHeight.Name = "numericUpDownMaskEditorHeight";
            this.numericUpDownMaskEditorHeight.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownMaskEditorHeight.TabIndex = 3;
            // 
            // labelMaskEditorHeight
            // 
            this.labelMaskEditorHeight.AutoSize = true;
            this.labelMaskEditorHeight.Location = new System.Drawing.Point(15, 49);
            this.labelMaskEditorHeight.Name = "labelMaskEditorHeight";
            this.labelMaskEditorHeight.Size = new System.Drawing.Size(41, 13);
            this.labelMaskEditorHeight.TabIndex = 2;
            this.labelMaskEditorHeight.Text = "Height:";
            // 
            // numericUpDownMaskEditorWidth
            // 
            this.numericUpDownMaskEditorWidth.Location = new System.Drawing.Point(62, 21);
            this.numericUpDownMaskEditorWidth.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDownMaskEditorWidth.Name = "numericUpDownMaskEditorWidth";
            this.numericUpDownMaskEditorWidth.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownMaskEditorWidth.TabIndex = 1;
            // 
            // labelMaskEditorWidth
            // 
            this.labelMaskEditorWidth.AutoSize = true;
            this.labelMaskEditorWidth.Location = new System.Drawing.Point(15, 23);
            this.labelMaskEditorWidth.Name = "labelMaskEditorWidth";
            this.labelMaskEditorWidth.Size = new System.Drawing.Size(38, 13);
            this.labelMaskEditorWidth.TabIndex = 0;
            this.labelMaskEditorWidth.Text = "Width:";
            // 
            // groupBoxDictionaryEditorSizes
            // 
            this.groupBoxDictionaryEditorSizes.Controls.Add(this.numericUpDownDictionaryEditorHeight);
            this.groupBoxDictionaryEditorSizes.Controls.Add(this.labelDictionaryEditorHeight);
            this.groupBoxDictionaryEditorSizes.Controls.Add(this.numericUpDownDictionaryEditorWidth);
            this.groupBoxDictionaryEditorSizes.Controls.Add(this.labelDictionaryEditorWidth);
            this.groupBoxDictionaryEditorSizes.Location = new System.Drawing.Point(157, 102);
            this.groupBoxDictionaryEditorSizes.Name = "groupBoxDictionaryEditorSizes";
            this.groupBoxDictionaryEditorSizes.Size = new System.Drawing.Size(139, 84);
            this.groupBoxDictionaryEditorSizes.TabIndex = 4;
            this.groupBoxDictionaryEditorSizes.TabStop = false;
            this.groupBoxDictionaryEditorSizes.Text = "Dictionary Editor Form";
            // 
            // numericUpDownDictionaryEditorHeight
            // 
            this.numericUpDownDictionaryEditorHeight.Location = new System.Drawing.Point(62, 47);
            this.numericUpDownDictionaryEditorHeight.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.numericUpDownDictionaryEditorHeight.Name = "numericUpDownDictionaryEditorHeight";
            this.numericUpDownDictionaryEditorHeight.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownDictionaryEditorHeight.TabIndex = 3;
            // 
            // labelDictionaryEditorHeight
            // 
            this.labelDictionaryEditorHeight.AutoSize = true;
            this.labelDictionaryEditorHeight.Location = new System.Drawing.Point(15, 49);
            this.labelDictionaryEditorHeight.Name = "labelDictionaryEditorHeight";
            this.labelDictionaryEditorHeight.Size = new System.Drawing.Size(41, 13);
            this.labelDictionaryEditorHeight.TabIndex = 2;
            this.labelDictionaryEditorHeight.Text = "Height:";
            // 
            // numericUpDownDictionaryEditorWidth
            // 
            this.numericUpDownDictionaryEditorWidth.Location = new System.Drawing.Point(62, 21);
            this.numericUpDownDictionaryEditorWidth.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDownDictionaryEditorWidth.Name = "numericUpDownDictionaryEditorWidth";
            this.numericUpDownDictionaryEditorWidth.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownDictionaryEditorWidth.TabIndex = 1;
            // 
            // labelDictionaryEditorWidth
            // 
            this.labelDictionaryEditorWidth.AutoSize = true;
            this.labelDictionaryEditorWidth.Location = new System.Drawing.Point(15, 23);
            this.labelDictionaryEditorWidth.Name = "labelDictionaryEditorWidth";
            this.labelDictionaryEditorWidth.Size = new System.Drawing.Size(38, 13);
            this.labelDictionaryEditorWidth.TabIndex = 0;
            this.labelDictionaryEditorWidth.Text = "Width:";
            // 
            // groupBoxConverterSizes
            // 
            this.groupBoxConverterSizes.Controls.Add(this.numericUpDownConverterHeight);
            this.groupBoxConverterSizes.Controls.Add(this.labelConverterHeight);
            this.groupBoxConverterSizes.Controls.Add(this.numericUpDownConverterWidth);
            this.groupBoxConverterSizes.Controls.Add(this.labelConverterWidth);
            this.groupBoxConverterSizes.Location = new System.Drawing.Point(12, 102);
            this.groupBoxConverterSizes.Name = "groupBoxConverterSizes";
            this.groupBoxConverterSizes.Size = new System.Drawing.Size(139, 84);
            this.groupBoxConverterSizes.TabIndex = 3;
            this.groupBoxConverterSizes.TabStop = false;
            this.groupBoxConverterSizes.Text = "Converter Form";
            // 
            // numericUpDownConverterHeight
            // 
            this.numericUpDownConverterHeight.Location = new System.Drawing.Point(62, 47);
            this.numericUpDownConverterHeight.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.numericUpDownConverterHeight.Name = "numericUpDownConverterHeight";
            this.numericUpDownConverterHeight.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownConverterHeight.TabIndex = 3;
            // 
            // labelConverterHeight
            // 
            this.labelConverterHeight.AutoSize = true;
            this.labelConverterHeight.Location = new System.Drawing.Point(15, 49);
            this.labelConverterHeight.Name = "labelConverterHeight";
            this.labelConverterHeight.Size = new System.Drawing.Size(41, 13);
            this.labelConverterHeight.TabIndex = 2;
            this.labelConverterHeight.Text = "Height:";
            // 
            // numericUpDownConverterWidth
            // 
            this.numericUpDownConverterWidth.Location = new System.Drawing.Point(62, 21);
            this.numericUpDownConverterWidth.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDownConverterWidth.Name = "numericUpDownConverterWidth";
            this.numericUpDownConverterWidth.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownConverterWidth.TabIndex = 1;
            // 
            // labelConverterWidth
            // 
            this.labelConverterWidth.AutoSize = true;
            this.labelConverterWidth.Location = new System.Drawing.Point(15, 23);
            this.labelConverterWidth.Name = "labelConverterWidth";
            this.labelConverterWidth.Size = new System.Drawing.Size(38, 13);
            this.labelConverterWidth.TabIndex = 0;
            this.labelConverterWidth.Text = "Width:";
            // 
            // groupBoxSettingsSizes
            // 
            this.groupBoxSettingsSizes.Controls.Add(this.numericUpDownSettingsHeight);
            this.groupBoxSettingsSizes.Controls.Add(this.labelSettingsHeight);
            this.groupBoxSettingsSizes.Controls.Add(this.numericUpDownSettingsWidth);
            this.groupBoxSettingsSizes.Controls.Add(this.labelSettingsWidth);
            this.groupBoxSettingsSizes.Location = new System.Drawing.Point(302, 12);
            this.groupBoxSettingsSizes.Name = "groupBoxSettingsSizes";
            this.groupBoxSettingsSizes.Size = new System.Drawing.Size(139, 84);
            this.groupBoxSettingsSizes.TabIndex = 2;
            this.groupBoxSettingsSizes.TabStop = false;
            this.groupBoxSettingsSizes.Text = "Settings Form";
            // 
            // numericUpDownSettingsHeight
            // 
            this.numericUpDownSettingsHeight.Location = new System.Drawing.Point(62, 47);
            this.numericUpDownSettingsHeight.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.numericUpDownSettingsHeight.Name = "numericUpDownSettingsHeight";
            this.numericUpDownSettingsHeight.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownSettingsHeight.TabIndex = 3;
            // 
            // labelSettingsHeight
            // 
            this.labelSettingsHeight.AutoSize = true;
            this.labelSettingsHeight.Location = new System.Drawing.Point(15, 49);
            this.labelSettingsHeight.Name = "labelSettingsHeight";
            this.labelSettingsHeight.Size = new System.Drawing.Size(41, 13);
            this.labelSettingsHeight.TabIndex = 2;
            this.labelSettingsHeight.Text = "Height:";
            // 
            // numericUpDownSettingsWidth
            // 
            this.numericUpDownSettingsWidth.Location = new System.Drawing.Point(62, 21);
            this.numericUpDownSettingsWidth.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDownSettingsWidth.Name = "numericUpDownSettingsWidth";
            this.numericUpDownSettingsWidth.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownSettingsWidth.TabIndex = 1;
            // 
            // labelSettingsWidth
            // 
            this.labelSettingsWidth.AutoSize = true;
            this.labelSettingsWidth.Location = new System.Drawing.Point(15, 23);
            this.labelSettingsWidth.Name = "labelSettingsWidth";
            this.labelSettingsWidth.Size = new System.Drawing.Size(38, 13);
            this.labelSettingsWidth.TabIndex = 0;
            this.labelSettingsWidth.Text = "Width:";
            // 
            // groupBoxTaskEditorSizes
            // 
            this.groupBoxTaskEditorSizes.Controls.Add(this.numericUpDownTaskEditorHeight);
            this.groupBoxTaskEditorSizes.Controls.Add(this.labelTaskEditorHeight);
            this.groupBoxTaskEditorSizes.Controls.Add(this.numericUpDownTaskEditorWidth);
            this.groupBoxTaskEditorSizes.Controls.Add(this.labelTaskEditorWidth);
            this.groupBoxTaskEditorSizes.Location = new System.Drawing.Point(157, 12);
            this.groupBoxTaskEditorSizes.Name = "groupBoxTaskEditorSizes";
            this.groupBoxTaskEditorSizes.Size = new System.Drawing.Size(139, 84);
            this.groupBoxTaskEditorSizes.TabIndex = 1;
            this.groupBoxTaskEditorSizes.TabStop = false;
            this.groupBoxTaskEditorSizes.Text = "Task Editor Form";
            // 
            // numericUpDownTaskEditorHeight
            // 
            this.numericUpDownTaskEditorHeight.Location = new System.Drawing.Point(62, 47);
            this.numericUpDownTaskEditorHeight.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.numericUpDownTaskEditorHeight.Name = "numericUpDownTaskEditorHeight";
            this.numericUpDownTaskEditorHeight.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownTaskEditorHeight.TabIndex = 3;
            // 
            // labelTaskEditorHeight
            // 
            this.labelTaskEditorHeight.AutoSize = true;
            this.labelTaskEditorHeight.Location = new System.Drawing.Point(15, 49);
            this.labelTaskEditorHeight.Name = "labelTaskEditorHeight";
            this.labelTaskEditorHeight.Size = new System.Drawing.Size(41, 13);
            this.labelTaskEditorHeight.TabIndex = 2;
            this.labelTaskEditorHeight.Text = "Height:";
            // 
            // numericUpDownTaskEditorWidth
            // 
            this.numericUpDownTaskEditorWidth.Location = new System.Drawing.Point(62, 21);
            this.numericUpDownTaskEditorWidth.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDownTaskEditorWidth.Name = "numericUpDownTaskEditorWidth";
            this.numericUpDownTaskEditorWidth.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownTaskEditorWidth.TabIndex = 1;
            // 
            // labelTaskEditorWidth
            // 
            this.labelTaskEditorWidth.AutoSize = true;
            this.labelTaskEditorWidth.Location = new System.Drawing.Point(15, 23);
            this.labelTaskEditorWidth.Name = "labelTaskEditorWidth";
            this.labelTaskEditorWidth.Size = new System.Drawing.Size(38, 13);
            this.labelTaskEditorWidth.TabIndex = 0;
            this.labelTaskEditorWidth.Text = "Width:";
            // 
            // groupBoxMainSizes
            // 
            this.groupBoxMainSizes.Controls.Add(this.numericUpDownMainHeight);
            this.groupBoxMainSizes.Controls.Add(this.labelMainHeight);
            this.groupBoxMainSizes.Controls.Add(this.numericUpDownMainWidth);
            this.groupBoxMainSizes.Controls.Add(this.labelMainWidth);
            this.groupBoxMainSizes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMainSizes.Name = "groupBoxMainSizes";
            this.groupBoxMainSizes.Size = new System.Drawing.Size(139, 84);
            this.groupBoxMainSizes.TabIndex = 0;
            this.groupBoxMainSizes.TabStop = false;
            this.groupBoxMainSizes.Text = "Main Form";
            // 
            // numericUpDownMainHeight
            // 
            this.numericUpDownMainHeight.Location = new System.Drawing.Point(62, 47);
            this.numericUpDownMainHeight.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.numericUpDownMainHeight.Name = "numericUpDownMainHeight";
            this.numericUpDownMainHeight.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownMainHeight.TabIndex = 3;
            // 
            // labelMainHeight
            // 
            this.labelMainHeight.AutoSize = true;
            this.labelMainHeight.Location = new System.Drawing.Point(15, 49);
            this.labelMainHeight.Name = "labelMainHeight";
            this.labelMainHeight.Size = new System.Drawing.Size(41, 13);
            this.labelMainHeight.TabIndex = 2;
            this.labelMainHeight.Text = "Height:";
            // 
            // numericUpDownMainWidth
            // 
            this.numericUpDownMainWidth.Location = new System.Drawing.Point(62, 21);
            this.numericUpDownMainWidth.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDownMainWidth.Name = "numericUpDownMainWidth";
            this.numericUpDownMainWidth.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownMainWidth.TabIndex = 1;
            // 
            // labelMainWidth
            // 
            this.labelMainWidth.AutoSize = true;
            this.labelMainWidth.Location = new System.Drawing.Point(15, 23);
            this.labelMainWidth.Name = "labelMainWidth";
            this.labelMainWidth.Size = new System.Drawing.Size(38, 13);
            this.labelMainWidth.TabIndex = 0;
            this.labelMainWidth.Text = "Width:";
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
            this.tabPageDictionaries.Size = new System.Drawing.Size(466, 251);
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
            this.listViewDictionaries.AllowDrop = true;
            this.listViewDictionaries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.listViewDictionaries.Size = new System.Drawing.Size(451, 201);
            this.listViewDictionaries.TabIndex = 0;
            this.listViewDictionaries.UseCompatibleStateImageBehavior = false;
            this.listViewDictionaries.View = System.Windows.Forms.View.Details;
            this.listViewDictionaries.SelectedIndexChanged += new System.EventHandler(this.listViewDictionaries_SelectedIndexChanged);
            this.listViewDictionaries.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewDictionaries_DragDrop);
            this.listViewDictionaries.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewDictionaries_DragEnter);
            this.listViewDictionaries.DoubleClick += new System.EventHandler(this.listViewDictionaries_DoubleClick);
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
            this.tabPageMasks.Size = new System.Drawing.Size(466, 251);
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
            this.listViewMasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.listViewMasks.Size = new System.Drawing.Size(451, 201);
            this.listViewMasks.TabIndex = 24;
            this.listViewMasks.UseCompatibleStateImageBehavior = false;
            this.listViewMasks.View = System.Windows.Forms.View.Details;
            this.listViewMasks.SelectedIndexChanged += new System.EventHandler(this.listViewMasks_SelectedIndexChanged);
            this.listViewMasks.DoubleClick += new System.EventHandler(this.listViewMasks_DoubleClick);
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
            this.buttonCancelTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelTask.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancelTask.FlatAppearance.BorderSize = 0;
            this.buttonCancelTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCancelTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_cancel;
            this.buttonCancelTask.Location = new System.Drawing.Point(443, 295);
            this.buttonCancelTask.Name = "buttonCancelTask";
            this.buttonCancelTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonCancelTask.Size = new System.Drawing.Size(40, 40);
            this.buttonCancelTask.TabIndex = 45;
            this.buttonCancelTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelTask.UseVisualStyleBackColor = true;
            // 
            // openFileDialogConverter
            // 
            this.openFileDialogConverter.FileName = "aircrack-ng.exe";
            this.openFileDialogConverter.Filter = "Executable files|*.exe";
            this.openFileDialogConverter.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogConverter_FileOk);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 347);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.buttonCancelTask);
            this.Controls.Add(this.buttonSettingsOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 386);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LeukocyteGUI for oclHashCat - Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.tabControlSettings.ResumeLayout(false);
            this.tabPagePathes.ResumeLayout(false);
            this.groupBoxSystem.ResumeLayout(false);
            this.groupBoxSystem.PerformLayout();
            this.groupBoxConverter.ResumeLayout(false);
            this.groupBoxConverter.PerformLayout();
            this.groupBoxHashcat.ResumeLayout(false);
            this.groupBoxHashcat.PerformLayout();
            this.tabPageOptions.ResumeLayout(false);
            this.panelCheckboxSettings.ResumeLayout(false);
            this.panelCheckboxSettings.PerformLayout();
            this.tabPageSizes.ResumeLayout(false);
            this.groupBoxMaskEditorSizes.ResumeLayout(false);
            this.groupBoxMaskEditorSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaskEditorHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaskEditorWidth)).EndInit();
            this.groupBoxDictionaryEditorSizes.ResumeLayout(false);
            this.groupBoxDictionaryEditorSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDictionaryEditorHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDictionaryEditorWidth)).EndInit();
            this.groupBoxConverterSizes.ResumeLayout(false);
            this.groupBoxConverterSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConverterHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConverterWidth)).EndInit();
            this.groupBoxSettingsSizes.ResumeLayout(false);
            this.groupBoxSettingsSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSettingsHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSettingsWidth)).EndInit();
            this.groupBoxTaskEditorSizes.ResumeLayout(false);
            this.groupBoxTaskEditorSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaskEditorHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaskEditorWidth)).EndInit();
            this.groupBoxMainSizes.ResumeLayout(false);
            this.groupBoxMainSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMainHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMainWidth)).EndInit();
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
        private System.Windows.Forms.TabPage tabPagePathes;
        private System.Windows.Forms.TabPage tabPageDictionaries;
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
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.GroupBox groupBoxSystem;
        private System.Windows.Forms.Label labelLogFilesPath;
        private System.Windows.Forms.TextBox textBoxLogFilesPath;
        private System.Windows.Forms.GroupBox groupBoxConverter;
        private System.Windows.Forms.Label labelAircrack;
        private System.Windows.Forms.TextBox textBoxAircrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConverterOutput;
        private System.Windows.Forms.GroupBox groupBoxHashcat;
        private System.Windows.Forms.Panel panelCheckboxSettings;
        private System.Windows.Forms.CheckBox checkBoxDebugMode;
        private System.Windows.Forms.CheckBox checkBoxSaveOnExit;
        private System.Windows.Forms.CheckBox checkBoxShowToolTips;
        private System.Windows.Forms.CheckBox checkBoxLoadOnStart;
        private System.Windows.Forms.CheckBox checkBoxMinimizeToTray;
        private System.Windows.Forms.CheckBox checkBoxDeleteSameWhenCracked;
        private System.Windows.Forms.CheckBox checkBoxShowNotifications;
        private System.Windows.Forms.Button buttonChooseLogFilesPath;
        private System.Windows.Forms.Button buttonChooseAircrack;
        private System.Windows.Forms.Button buttonChooseConverterOutput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialogConverter;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogLogFiles;
        private System.Windows.Forms.CheckBox checkBoxSaveFormsSizes;
        private System.Windows.Forms.TabPage tabPageSizes;
        private System.Windows.Forms.GroupBox groupBoxTaskEditorSizes;
        private System.Windows.Forms.NumericUpDown numericUpDownTaskEditorHeight;
        private System.Windows.Forms.Label labelTaskEditorHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownTaskEditorWidth;
        private System.Windows.Forms.Label labelTaskEditorWidth;
        private System.Windows.Forms.GroupBox groupBoxMainSizes;
        private System.Windows.Forms.NumericUpDown numericUpDownMainHeight;
        private System.Windows.Forms.Label labelMainHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMainWidth;
        private System.Windows.Forms.Label labelMainWidth;
        private System.Windows.Forms.GroupBox groupBoxSettingsSizes;
        private System.Windows.Forms.NumericUpDown numericUpDownSettingsHeight;
        private System.Windows.Forms.Label labelSettingsHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSettingsWidth;
        private System.Windows.Forms.Label labelSettingsWidth;
        private System.Windows.Forms.CheckBox checkBoxUseSavedSizes;
        private System.Windows.Forms.GroupBox groupBoxMaskEditorSizes;
        private System.Windows.Forms.NumericUpDown numericUpDownMaskEditorHeight;
        private System.Windows.Forms.Label labelMaskEditorHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaskEditorWidth;
        private System.Windows.Forms.Label labelMaskEditorWidth;
        private System.Windows.Forms.GroupBox groupBoxDictionaryEditorSizes;
        private System.Windows.Forms.NumericUpDown numericUpDownDictionaryEditorHeight;
        private System.Windows.Forms.Label labelDictionaryEditorHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownDictionaryEditorWidth;
        private System.Windows.Forms.Label labelDictionaryEditorWidth;
        private System.Windows.Forms.GroupBox groupBoxConverterSizes;
        private System.Windows.Forms.NumericUpDown numericUpDownConverterHeight;
        private System.Windows.Forms.Label labelConverterHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownConverterWidth;
        private System.Windows.Forms.Label labelConverterWidth;
    }
}