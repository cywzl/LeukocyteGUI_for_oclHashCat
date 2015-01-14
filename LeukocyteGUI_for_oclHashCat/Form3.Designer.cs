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
            this.textBoxHashcat = new System.Windows.Forms.TextBox();
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
            this.buttonOpenConverter = new System.Windows.Forms.Button();
            this.buttonClearTask = new System.Windows.Forms.Button();
            this.buttonStopTask = new System.Windows.Forms.Button();
            this.buttonPauseTask = new System.Windows.Forms.Button();
            this.buttonStartTask = new System.Windows.Forms.Button();
            this.buttonChangeTask = new System.Windows.Forms.Button();
            this.buttonDownTask = new System.Windows.Forms.Button();
            this.buttonUpTask = new System.Windows.Forms.Button();
            this.buttonDeleteTask = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.labelOclHashcat = new System.Windows.Forms.Label();
            this.groupBoxMainSettings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGPUSpeed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGPUTemp = new System.Windows.Forms.Label();
            this.labelGPUUtil = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFanSpeed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxGPUStatistics = new System.Windows.Forms.GroupBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.groupBoxMainSettings.SuspendLayout();
            this.groupBoxGPUStatistics.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxHashcat
            // 
            this.textBoxHashcat.Location = new System.Drawing.Point(82, 22);
            this.textBoxHashcat.Name = "textBoxHashcat";
            this.textBoxHashcat.Size = new System.Drawing.Size(418, 20);
            this.textBoxHashcat.TabIndex = 8;
            this.textBoxHashcat.Text = "oclHashcat64.exe";
            // 
            // listViewTasks
            // 
            this.listViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.listViewTasks.Location = new System.Drawing.Point(11, 144);
            this.listViewTasks.MultiSelect = false;
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(752, 318);
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
            // buttonOpenConverter
            // 
            this.buttonOpenConverter.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.message_reply_9020;
            this.buttonOpenConverter.Location = new System.Drawing.Point(312, 19);
            this.buttonOpenConverter.Name = "buttonOpenConverter";
            this.buttonOpenConverter.Padding = new System.Windows.Forms.Padding(3);
            this.buttonOpenConverter.Size = new System.Drawing.Size(40, 32);
            this.buttonOpenConverter.TabIndex = 18;
            this.buttonOpenConverter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenConverter.UseVisualStyleBackColor = true;
            this.buttonOpenConverter.Click += new System.EventHandler(this.buttonOpenConverter_Click);
            // 
            // buttonClearTask
            // 
            this.buttonClearTask.Enabled = false;
            this.buttonClearTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.old_view_refresh_4484;
            this.buttonClearTask.Location = new System.Drawing.Point(154, 19);
            this.buttonClearTask.Name = "buttonClearTask";
            this.buttonClearTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonClearTask.Size = new System.Drawing.Size(40, 32);
            this.buttonClearTask.TabIndex = 17;
            this.buttonClearTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearTask.UseVisualStyleBackColor = true;
            this.buttonClearTask.Click += new System.EventHandler(this.buttonClearTask_Click);
            // 
            // buttonStopTask
            // 
            this.buttonStopTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.gtk_media_stop_2295;
            this.buttonStopTask.Location = new System.Drawing.Point(460, 19);
            this.buttonStopTask.Name = "buttonStopTask";
            this.buttonStopTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonStopTask.Size = new System.Drawing.Size(40, 32);
            this.buttonStopTask.TabIndex = 16;
            this.buttonStopTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStopTask.UseVisualStyleBackColor = true;
            this.buttonStopTask.Click += new System.EventHandler(this.buttonStopTask_Click);
            // 
            // buttonPauseTask
            // 
            this.buttonPauseTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.gtk_media_pause_9393;
            this.buttonPauseTask.Location = new System.Drawing.Point(414, 19);
            this.buttonPauseTask.Name = "buttonPauseTask";
            this.buttonPauseTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonPauseTask.Size = new System.Drawing.Size(40, 32);
            this.buttonPauseTask.TabIndex = 15;
            this.buttonPauseTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPauseTask.UseVisualStyleBackColor = true;
            this.buttonPauseTask.Click += new System.EventHandler(this.buttonPauseTask_Click);
            // 
            // buttonStartTask
            // 
            this.buttonStartTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.gtk_media_play_ltr_9072;
            this.buttonStartTask.Location = new System.Drawing.Point(368, 19);
            this.buttonStartTask.Name = "buttonStartTask";
            this.buttonStartTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonStartTask.Size = new System.Drawing.Size(40, 32);
            this.buttonStartTask.TabIndex = 14;
            this.buttonStartTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartTask.UseVisualStyleBackColor = true;
            this.buttonStartTask.Click += new System.EventHandler(this.buttonStartTask_Click);
            // 
            // buttonChangeTask
            // 
            this.buttonChangeTask.Enabled = false;
            this.buttonChangeTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.configure_9863;
            this.buttonChangeTask.Location = new System.Drawing.Point(108, 19);
            this.buttonChangeTask.Name = "buttonChangeTask";
            this.buttonChangeTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonChangeTask.Size = new System.Drawing.Size(40, 32);
            this.buttonChangeTask.TabIndex = 13;
            this.buttonChangeTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeTask.UseVisualStyleBackColor = true;
            this.buttonChangeTask.Click += new System.EventHandler(this.buttonChangeTask_Click);
            // 
            // buttonDownTask
            // 
            this.buttonDownTask.Enabled = false;
            this.buttonDownTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources._1downarrow_9068;
            this.buttonDownTask.Location = new System.Drawing.Point(256, 19);
            this.buttonDownTask.Name = "buttonDownTask";
            this.buttonDownTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDownTask.Size = new System.Drawing.Size(40, 32);
            this.buttonDownTask.TabIndex = 12;
            this.buttonDownTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDownTask.UseVisualStyleBackColor = true;
            this.buttonDownTask.Click += new System.EventHandler(this.buttonDownTask_Click);
            // 
            // buttonUpTask
            // 
            this.buttonUpTask.Enabled = false;
            this.buttonUpTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources._1uparrow_2202;
            this.buttonUpTask.Location = new System.Drawing.Point(210, 19);
            this.buttonUpTask.Name = "buttonUpTask";
            this.buttonUpTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonUpTask.Size = new System.Drawing.Size(40, 32);
            this.buttonUpTask.TabIndex = 11;
            this.buttonUpTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpTask.UseVisualStyleBackColor = true;
            this.buttonUpTask.Click += new System.EventHandler(this.buttonUpTask_Click);
            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.Enabled = false;
            this.buttonDeleteTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.button_cancel_8125;
            this.buttonDeleteTask.Location = new System.Drawing.Point(62, 19);
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDeleteTask.Size = new System.Drawing.Size(40, 32);
            this.buttonDeleteTask.TabIndex = 10;
            this.buttonDeleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteTask.UseVisualStyleBackColor = true;
            this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.edit_add_7148;
            this.buttonAddTask.Location = new System.Drawing.Point(16, 19);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonAddTask.Size = new System.Drawing.Size(40, 32);
            this.buttonAddTask.TabIndex = 9;
            this.buttonAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // labelOclHashcat
            // 
            this.labelOclHashcat.AutoSize = true;
            this.labelOclHashcat.Location = new System.Drawing.Point(12, 25);
            this.labelOclHashcat.Name = "labelOclHashcat";
            this.labelOclHashcat.Size = new System.Drawing.Size(64, 13);
            this.labelOclHashcat.TabIndex = 19;
            this.labelOclHashcat.Text = "oclHashcat:";
            // 
            // groupBoxMainSettings
            // 
            this.groupBoxMainSettings.Controls.Add(this.labelOclHashcat);
            this.groupBoxMainSettings.Controls.Add(this.textBoxHashcat);
            this.groupBoxMainSettings.Location = new System.Drawing.Point(11, 12);
            this.groupBoxMainSettings.Name = "groupBoxMainSettings";
            this.groupBoxMainSettings.Size = new System.Drawing.Size(517, 57);
            this.groupBoxMainSettings.TabIndex = 20;
            this.groupBoxMainSettings.TabStop = false;
            this.groupBoxMainSettings.Text = "Main Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "GPU Speed:";
            // 
            // labelGPUSpeed
            // 
            this.labelGPUSpeed.AutoSize = true;
            this.labelGPUSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGPUSpeed.Location = new System.Drawing.Point(122, 23);
            this.labelGPUSpeed.Name = "labelGPUSpeed";
            this.labelGPUSpeed.Size = new System.Drawing.Size(16, 17);
            this.labelGPUSpeed.TabIndex = 22;
            this.labelGPUSpeed.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "GPU Temp:";
            // 
            // labelGPUTemp
            // 
            this.labelGPUTemp.AutoSize = true;
            this.labelGPUTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGPUTemp.Location = new System.Drawing.Point(122, 47);
            this.labelGPUTemp.Name = "labelGPUTemp";
            this.labelGPUTemp.Size = new System.Drawing.Size(16, 17);
            this.labelGPUTemp.TabIndex = 24;
            this.labelGPUTemp.Text = "0";
            // 
            // labelGPUUtil
            // 
            this.labelGPUUtil.AutoSize = true;
            this.labelGPUUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGPUUtil.Location = new System.Drawing.Point(122, 71);
            this.labelGPUUtil.Name = "labelGPUUtil";
            this.labelGPUUtil.Size = new System.Drawing.Size(16, 17);
            this.labelGPUUtil.TabIndex = 26;
            this.labelGPUUtil.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "GPU Util:";
            // 
            // labelFanSpeed
            // 
            this.labelFanSpeed.AutoSize = true;
            this.labelFanSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFanSpeed.Location = new System.Drawing.Point(122, 95);
            this.labelFanSpeed.Name = "labelFanSpeed";
            this.labelFanSpeed.Size = new System.Drawing.Size(16, 17);
            this.labelFanSpeed.TabIndex = 28;
            this.labelFanSpeed.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Fan Speed:";
            // 
            // groupBoxGPUStatistics
            // 
            this.groupBoxGPUStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGPUStatistics.Controls.Add(this.label8);
            this.groupBoxGPUStatistics.Controls.Add(this.labelFanSpeed);
            this.groupBoxGPUStatistics.Controls.Add(this.label6);
            this.groupBoxGPUStatistics.Controls.Add(this.labelGPUUtil);
            this.groupBoxGPUStatistics.Controls.Add(this.label3);
            this.groupBoxGPUStatistics.Controls.Add(this.labelGPUTemp);
            this.groupBoxGPUStatistics.Controls.Add(this.label1);
            this.groupBoxGPUStatistics.Controls.Add(this.labelGPUSpeed);
            this.groupBoxGPUStatistics.Location = new System.Drawing.Point(534, 12);
            this.groupBoxGPUStatistics.Name = "groupBoxGPUStatistics";
            this.groupBoxGPUStatistics.Size = new System.Drawing.Size(229, 126);
            this.groupBoxGPUStatistics.TabIndex = 29;
            this.groupBoxGPUStatistics.TabStop = false;
            this.groupBoxGPUStatistics.Text = "GPU Statistics";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonAddTask);
            this.groupBoxActions.Controls.Add(this.buttonDeleteTask);
            this.groupBoxActions.Controls.Add(this.buttonUpTask);
            this.groupBoxActions.Controls.Add(this.buttonOpenConverter);
            this.groupBoxActions.Controls.Add(this.buttonDownTask);
            this.groupBoxActions.Controls.Add(this.buttonClearTask);
            this.groupBoxActions.Controls.Add(this.buttonChangeTask);
            this.groupBoxActions.Controls.Add(this.buttonStopTask);
            this.groupBoxActions.Controls.Add(this.buttonStartTask);
            this.groupBoxActions.Controls.Add(this.buttonPauseTask);
            this.groupBoxActions.Location = new System.Drawing.Point(11, 75);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(517, 63);
            this.groupBoxActions.TabIndex = 30;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 474);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxGPUStatistics);
            this.Controls.Add(this.groupBoxMainSettings);
            this.Controls.Add(this.listViewTasks);
            this.Name = "MainForm";
            this.Text = "LeukocyteGUI for oclHashCat";
            this.groupBoxMainSettings.ResumeLayout(false);
            this.groupBoxMainSettings.PerformLayout();
            this.groupBoxGPUStatistics.ResumeLayout(false);
            this.groupBoxGPUStatistics.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHashcat;
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
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonDeleteTask;
        private System.Windows.Forms.Button buttonUpTask;
        private System.Windows.Forms.Button buttonDownTask;
        private System.Windows.Forms.Button buttonChangeTask;
        private System.Windows.Forms.Button buttonStartTask;
        private System.Windows.Forms.Button buttonPauseTask;
        private System.Windows.Forms.Button buttonStopTask;
        private System.Windows.Forms.Button buttonClearTask;
        private System.Windows.Forms.ColumnHeader columnHeaderDictionary;
        private System.Windows.Forms.Button buttonOpenConverter;
        private System.Windows.Forms.ColumnHeader columnHeaderOutput;
        private System.Windows.Forms.Label labelOclHashcat;
        private System.Windows.Forms.GroupBox groupBoxMainSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGPUSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGPUTemp;
        private System.Windows.Forms.Label labelGPUUtil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFanSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxGPUStatistics;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.ColumnHeader columnHeaderLength;
        private System.Windows.Forms.ColumnHeader columnHeaderDigests;
        private System.Windows.Forms.ColumnHeader columnHeaderSalts;
    }
}