namespace LeukocyteGUI_for_oclHashCat
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHashType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPlain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDigests = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSalts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEstimated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOutput = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDictionary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStarted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFinished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSession = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelGPUSpeed = new System.Windows.Forms.Label();
            this.labelGPUTemp = new System.Windows.Forms.Label();
            this.labelGPUUtil = new System.Windows.Forms.Label();
            this.labelFanSpeed = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.pictureBoxFan = new System.Windows.Forms.PictureBox();
            this.pictureBoxVideocard = new System.Windows.Forms.PictureBox();
            this.pictureBoxTemperature = new System.Windows.Forms.PictureBox();
            this.pictureBoxSpeed = new System.Windows.Forms.PictureBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonDeleteTask = new System.Windows.Forms.Button();
            this.buttonUpTask = new System.Windows.Forms.Button();
            this.buttonOpenConverter = new System.Windows.Forms.Button();
            this.buttonDownTask = new System.Windows.Forms.Button();
            this.buttonClearTask = new System.Windows.Forms.Button();
            this.buttonPauseTask = new System.Windows.Forms.Button();
            this.buttonChangeTask = new System.Windows.Forms.Button();
            this.buttonStartTask = new System.Windows.Forms.Button();
            this.buttonStopTask = new System.Windows.Forms.Button();
            this.imageListCheckBox = new System.Windows.Forms.ImageList(this.components);
            this.checkBoxAllChecked = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideocard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewTasks
            // 
            this.listViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTasks.CheckBoxes = true;
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumber,
            this.columnHeaderHashType,
            this.columnHeaderHash,
            this.columnHeaderPlain,
            this.columnHeaderLength,
            this.columnHeaderProgress,
            this.columnHeaderDigests,
            this.columnHeaderSalts,
            this.columnHeaderStatus,
            this.columnHeaderEstimated,
            this.columnHeaderOutput,
            this.columnHeaderDictionary,
            this.columnHeaderStarted,
            this.columnHeaderFinished,
            this.columnHeaderSession});
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Location = new System.Drawing.Point(11, 83);
            this.listViewTasks.MultiSelect = false;
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(752, 379);
            this.listViewTasks.TabIndex = 1;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            this.listViewTasks.SelectedIndexChanged += new System.EventHandler(this.listViewTasks_SelectedIndexChanged);
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "#";
            this.columnHeaderNumber.Width = 37;
            // 
            // columnHeaderHashType
            // 
            this.columnHeaderHashType.Text = "Hash Type";
            this.columnHeaderHashType.Width = 67;
            // 
            // columnHeaderHash
            // 
            this.columnHeaderHash.Text = "Hash";
            this.columnHeaderHash.Width = 142;
            // 
            // columnHeaderPlain
            // 
            this.columnHeaderPlain.Text = "Plain";
            this.columnHeaderPlain.Width = 143;
            // 
            // columnHeaderLength
            // 
            this.columnHeaderLength.Text = "Length";
            // 
            // columnHeaderProgress
            // 
            this.columnHeaderProgress.Text = "Progress";
            this.columnHeaderProgress.Width = 54;
            // 
            // columnHeaderDigests
            // 
            this.columnHeaderDigests.Text = "Digests";
            // 
            // columnHeaderSalts
            // 
            this.columnHeaderSalts.Text = "Salts";
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 56;
            // 
            // columnHeaderEstimated
            // 
            this.columnHeaderEstimated.Text = "Estimated";
            this.columnHeaderEstimated.Width = 68;
            // 
            // columnHeaderOutput
            // 
            this.columnHeaderOutput.Text = "Output File";
            this.columnHeaderOutput.Width = 116;
            // 
            // columnHeaderDictionary
            // 
            this.columnHeaderDictionary.Text = "Dictionary / Mask";
            this.columnHeaderDictionary.Width = 102;
            // 
            // columnHeaderStarted
            // 
            this.columnHeaderStarted.Text = "Started";
            this.columnHeaderStarted.Width = 105;
            // 
            // columnHeaderFinished
            // 
            this.columnHeaderFinished.Text = "Finished";
            this.columnHeaderFinished.Width = 109;
            // 
            // columnHeaderSession
            // 
            this.columnHeaderSession.Text = "Session";
            // 
            // labelGPUSpeed
            // 
            this.labelGPUSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGPUSpeed.AutoSize = true;
            this.labelGPUSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGPUSpeed.Location = new System.Drawing.Point(575, 18);
            this.labelGPUSpeed.Name = "labelGPUSpeed";
            this.labelGPUSpeed.Size = new System.Drawing.Size(39, 17);
            this.labelGPUSpeed.TabIndex = 22;
            this.labelGPUSpeed.Text = "0 h/s";
            // 
            // labelGPUTemp
            // 
            this.labelGPUTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGPUTemp.AutoSize = true;
            this.labelGPUTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGPUTemp.Location = new System.Drawing.Point(575, 49);
            this.labelGPUTemp.Name = "labelGPUTemp";
            this.labelGPUTemp.Size = new System.Drawing.Size(35, 17);
            this.labelGPUTemp.TabIndex = 24;
            this.labelGPUTemp.Text = "0 °C";
            // 
            // labelGPUUtil
            // 
            this.labelGPUUtil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGPUUtil.AutoSize = true;
            this.labelGPUUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGPUUtil.Location = new System.Drawing.Point(715, 18);
            this.labelGPUUtil.Name = "labelGPUUtil";
            this.labelGPUUtil.Size = new System.Drawing.Size(32, 17);
            this.labelGPUUtil.TabIndex = 26;
            this.labelGPUUtil.Text = "0 %";
            // 
            // labelFanSpeed
            // 
            this.labelFanSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFanSpeed.AutoSize = true;
            this.labelFanSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFanSpeed.Location = new System.Drawing.Point(715, 49);
            this.labelFanSpeed.Name = "labelFanSpeed";
            this.labelFanSpeed.Size = new System.Drawing.Size(32, 17);
            this.labelFanSpeed.TabIndex = 28;
            this.labelFanSpeed.Text = "0 %";
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_settings;
            this.buttonSettings.Location = new System.Drawing.Point(421, 45);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(3);
            this.buttonSettings.Size = new System.Drawing.Size(31, 32);
            this.buttonSettings.TabIndex = 35;
            this.buttonSettings.TabStop = false;
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // pictureBoxFan
            // 
            this.pictureBoxFan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFan.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.fan;
            this.pictureBoxFan.Location = new System.Drawing.Point(684, 45);
            this.pictureBoxFan.Name = "pictureBoxFan";
            this.pictureBoxFan.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFan.TabIndex = 34;
            this.pictureBoxFan.TabStop = false;
            // 
            // pictureBoxVideocard
            // 
            this.pictureBoxVideocard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxVideocard.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_videocard;
            this.pictureBoxVideocard.Location = new System.Drawing.Point(683, 15);
            this.pictureBoxVideocard.Name = "pictureBoxVideocard";
            this.pictureBoxVideocard.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxVideocard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxVideocard.TabIndex = 33;
            this.pictureBoxVideocard.TabStop = false;
            // 
            // pictureBoxTemperature
            // 
            this.pictureBoxTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTemperature.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_temperature;
            this.pictureBoxTemperature.Location = new System.Drawing.Point(544, 46);
            this.pictureBoxTemperature.Name = "pictureBoxTemperature";
            this.pictureBoxTemperature.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTemperature.TabIndex = 32;
            this.pictureBoxTemperature.TabStop = false;
            // 
            // pictureBoxSpeed
            // 
            this.pictureBoxSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSpeed.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_speed;
            this.pictureBoxSpeed.Location = new System.Drawing.Point(544, 15);
            this.pictureBoxSpeed.Name = "pictureBoxSpeed";
            this.pictureBoxSpeed.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSpeed.TabIndex = 31;
            this.pictureBoxSpeed.TabStop = false;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddTask.FlatAppearance.BorderSize = 0;
            this.buttonAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_plus;
            this.buttonAddTask.Location = new System.Drawing.Point(11, 45);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonAddTask.Size = new System.Drawing.Size(31, 32);
            this.buttonAddTask.TabIndex = 9;
            this.buttonAddTask.TabStop = false;
            this.buttonAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddTask.UseVisualStyleBackColor = false;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.Enabled = false;
            this.buttonDeleteTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonDeleteTask.FlatAppearance.BorderSize = 0;
            this.buttonDeleteTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_delete;
            this.buttonDeleteTask.Location = new System.Drawing.Point(48, 45);
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDeleteTask.Size = new System.Drawing.Size(31, 32);
            this.buttonDeleteTask.TabIndex = 10;
            this.buttonDeleteTask.TabStop = false;
            this.buttonDeleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteTask.UseVisualStyleBackColor = true;
            this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
            // 
            // buttonUpTask
            // 
            this.buttonUpTask.Enabled = false;
            this.buttonUpTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonUpTask.FlatAppearance.BorderSize = 0;
            this.buttonUpTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUpTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_up;
            this.buttonUpTask.Location = new System.Drawing.Point(169, 45);
            this.buttonUpTask.Name = "buttonUpTask";
            this.buttonUpTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonUpTask.Size = new System.Drawing.Size(31, 32);
            this.buttonUpTask.TabIndex = 11;
            this.buttonUpTask.TabStop = false;
            this.buttonUpTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpTask.UseVisualStyleBackColor = true;
            this.buttonUpTask.Click += new System.EventHandler(this.buttonUpTask_Click);
            // 
            // buttonOpenConverter
            // 
            this.buttonOpenConverter.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenConverter.FlatAppearance.BorderSize = 0;
            this.buttonOpenConverter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonOpenConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenConverter.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_convert;
            this.buttonOpenConverter.Location = new System.Drawing.Point(374, 45);
            this.buttonOpenConverter.Name = "buttonOpenConverter";
            this.buttonOpenConverter.Padding = new System.Windows.Forms.Padding(3);
            this.buttonOpenConverter.Size = new System.Drawing.Size(31, 32);
            this.buttonOpenConverter.TabIndex = 18;
            this.buttonOpenConverter.TabStop = false;
            this.buttonOpenConverter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenConverter.UseVisualStyleBackColor = true;
            this.buttonOpenConverter.Click += new System.EventHandler(this.buttonOpenConverter_Click);
            // 
            // buttonDownTask
            // 
            this.buttonDownTask.Enabled = false;
            this.buttonDownTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonDownTask.FlatAppearance.BorderSize = 0;
            this.buttonDownTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDownTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_down;
            this.buttonDownTask.Location = new System.Drawing.Point(206, 45);
            this.buttonDownTask.Name = "buttonDownTask";
            this.buttonDownTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDownTask.Size = new System.Drawing.Size(31, 32);
            this.buttonDownTask.TabIndex = 12;
            this.buttonDownTask.TabStop = false;
            this.buttonDownTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDownTask.UseVisualStyleBackColor = true;
            this.buttonDownTask.Click += new System.EventHandler(this.buttonDownTask_Click);
            // 
            // buttonClearTask
            // 
            this.buttonClearTask.Enabled = false;
            this.buttonClearTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonClearTask.FlatAppearance.BorderSize = 0;
            this.buttonClearTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClearTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_clear;
            this.buttonClearTask.Location = new System.Drawing.Point(122, 45);
            this.buttonClearTask.Name = "buttonClearTask";
            this.buttonClearTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonClearTask.Size = new System.Drawing.Size(31, 32);
            this.buttonClearTask.TabIndex = 17;
            this.buttonClearTask.TabStop = false;
            this.buttonClearTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearTask.UseVisualStyleBackColor = true;
            this.buttonClearTask.Click += new System.EventHandler(this.buttonClearTask_Click);
            // 
            // buttonPauseTask
            // 
            this.buttonPauseTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonPauseTask.FlatAppearance.BorderSize = 0;
            this.buttonPauseTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonPauseTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPauseTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_pause;
            this.buttonPauseTask.Location = new System.Drawing.Point(290, 45);
            this.buttonPauseTask.Name = "buttonPauseTask";
            this.buttonPauseTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonPauseTask.Size = new System.Drawing.Size(31, 32);
            this.buttonPauseTask.TabIndex = 15;
            this.buttonPauseTask.TabStop = false;
            this.buttonPauseTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPauseTask.UseVisualStyleBackColor = true;
            this.buttonPauseTask.Click += new System.EventHandler(this.buttonPauseTask_Click);
            // 
            // buttonChangeTask
            // 
            this.buttonChangeTask.Enabled = false;
            this.buttonChangeTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonChangeTask.FlatAppearance.BorderSize = 0;
            this.buttonChangeTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChangeTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_change;
            this.buttonChangeTask.Location = new System.Drawing.Point(85, 45);
            this.buttonChangeTask.Name = "buttonChangeTask";
            this.buttonChangeTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonChangeTask.Size = new System.Drawing.Size(31, 32);
            this.buttonChangeTask.TabIndex = 13;
            this.buttonChangeTask.TabStop = false;
            this.buttonChangeTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeTask.UseVisualStyleBackColor = true;
            this.buttonChangeTask.Click += new System.EventHandler(this.buttonChangeTask_Click);
            // 
            // buttonStartTask
            // 
            this.buttonStartTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonStartTask.FlatAppearance.BorderSize = 0;
            this.buttonStartTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonStartTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_play;
            this.buttonStartTask.Location = new System.Drawing.Point(253, 45);
            this.buttonStartTask.Name = "buttonStartTask";
            this.buttonStartTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonStartTask.Size = new System.Drawing.Size(31, 32);
            this.buttonStartTask.TabIndex = 14;
            this.buttonStartTask.TabStop = false;
            this.buttonStartTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartTask.UseVisualStyleBackColor = true;
            this.buttonStartTask.Click += new System.EventHandler(this.buttonStartTask_Click);
            // 
            // buttonStopTask
            // 
            this.buttonStopTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonStopTask.FlatAppearance.BorderSize = 0;
            this.buttonStopTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonStopTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_stop;
            this.buttonStopTask.Location = new System.Drawing.Point(327, 45);
            this.buttonStopTask.Name = "buttonStopTask";
            this.buttonStopTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonStopTask.Size = new System.Drawing.Size(31, 32);
            this.buttonStopTask.TabIndex = 16;
            this.buttonStopTask.TabStop = false;
            this.buttonStopTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStopTask.UseVisualStyleBackColor = true;
            this.buttonStopTask.Click += new System.EventHandler(this.buttonStopTask_Click);
            // 
            // imageListCheckBox
            // 
            this.imageListCheckBox.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCheckBox.ImageStream")));
            this.imageListCheckBox.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCheckBox.Images.SetKeyName(0, "glyph_switch_on.png");
            this.imageListCheckBox.Images.SetKeyName(1, "glyph_switch_off.png");
            // 
            // checkBoxAllChecked
            // 
            this.checkBoxAllChecked.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAllChecked.AutoSize = true;
            this.checkBoxAllChecked.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.checkBoxAllChecked.FlatAppearance.BorderSize = 0;
            this.checkBoxAllChecked.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.checkBoxAllChecked.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.checkBoxAllChecked.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.checkBoxAllChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAllChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAllChecked.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxAllChecked.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxAllChecked.ImageIndex = 0;
            this.checkBoxAllChecked.ImageList = this.imageListCheckBox;
            this.checkBoxAllChecked.Location = new System.Drawing.Point(11, 7);
            this.checkBoxAllChecked.Name = "checkBoxAllChecked";
            this.checkBoxAllChecked.Size = new System.Drawing.Size(154, 32);
            this.checkBoxAllChecked.TabIndex = 36;
            this.checkBoxAllChecked.Text = "  Crack all checked";
            this.checkBoxAllChecked.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBoxAllChecked.UseVisualStyleBackColor = true;
            this.checkBoxAllChecked.CheckedChanged += new System.EventHandler(this.checkBoxAllChecked_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 474);
            this.Controls.Add(this.checkBoxAllChecked);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.pictureBoxFan);
            this.Controls.Add(this.pictureBoxVideocard);
            this.Controls.Add(this.pictureBoxTemperature);
            this.Controls.Add(this.pictureBoxSpeed);
            this.Controls.Add(this.labelFanSpeed);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.labelGPUUtil);
            this.Controls.Add(this.buttonDeleteTask);
            this.Controls.Add(this.buttonUpTask);
            this.Controls.Add(this.labelGPUTemp);
            this.Controls.Add(this.labelGPUSpeed);
            this.Controls.Add(this.buttonOpenConverter);
            this.Controls.Add(this.buttonDownTask);
            this.Controls.Add(this.listViewTasks);
            this.Controls.Add(this.buttonClearTask);
            this.Controls.Add(this.buttonPauseTask);
            this.Controls.Add(this.buttonChangeTask);
            this.Controls.Add(this.buttonStartTask);
            this.Controls.Add(this.buttonStopTask);
            this.Name = "MainForm";
            this.Text = "LeukocyteGUI for oclHashCat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideocard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderHashType;
        private System.Windows.Forms.ColumnHeader columnHeaderProgress;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderHash;
        private System.Windows.Forms.ColumnHeader columnHeaderPlain;
        private System.Windows.Forms.ColumnHeader columnHeaderStarted;
        private System.Windows.Forms.ColumnHeader columnHeaderFinished;
        private System.Windows.Forms.ColumnHeader columnHeaderEstimated;
        private System.Windows.Forms.ColumnHeader columnHeaderSession;
        private System.Windows.Forms.ColumnHeader columnHeaderDictionary;
        private System.Windows.Forms.ColumnHeader columnHeaderOutput;
        private System.Windows.Forms.Label labelGPUSpeed;
        private System.Windows.Forms.Label labelGPUTemp;
        private System.Windows.Forms.Label labelGPUUtil;
        private System.Windows.Forms.Label labelFanSpeed;
        private System.Windows.Forms.ColumnHeader columnHeaderLength;
        private System.Windows.Forms.ColumnHeader columnHeaderDigests;
        private System.Windows.Forms.ColumnHeader columnHeaderSalts;
        private System.Windows.Forms.Button buttonDownTask;
        private System.Windows.Forms.Button buttonClearTask;
        private System.Windows.Forms.Button buttonOpenConverter;
        private System.Windows.Forms.Button buttonPauseTask;
        private System.Windows.Forms.Button buttonChangeTask;
        private System.Windows.Forms.Button buttonUpTask;
        private System.Windows.Forms.Button buttonStartTask;
        private System.Windows.Forms.Button buttonStopTask;
        private System.Windows.Forms.Button buttonDeleteTask;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.PictureBox pictureBoxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxTemperature;
        private System.Windows.Forms.PictureBox pictureBoxVideocard;
        private System.Windows.Forms.PictureBox pictureBoxFan;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ImageList imageListCheckBox;
        private System.Windows.Forms.CheckBox checkBoxAllChecked;
    }
}