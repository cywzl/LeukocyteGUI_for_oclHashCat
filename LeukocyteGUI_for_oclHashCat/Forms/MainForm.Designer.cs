namespace LeukocyteGUI_for_oclHashcat.Forms
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
            this.lvCrackTasks = new System.Windows.Forms.ListView();
            this.chNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHashType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTarget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPlain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeEstimated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDictMask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeStarted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeFinished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSession = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnCrack = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.pbSpeed = new System.Windows.Forms.PictureBox();
            this.lblNumbersSpeed = new System.Windows.Forms.Label();
            this.lblSpeed0 = new System.Windows.Forms.Label();
            this.lblSpeed1 = new System.Windows.Forms.Label();
            this.lblSpeed2 = new System.Windows.Forms.Label();
            this.lblSpeed3 = new System.Windows.Forms.Label();
            this.lblNumbersGPU = new System.Windows.Forms.Label();
            this.pbGPU = new System.Windows.Forms.PictureBox();
            this.lblFanUsage3 = new System.Windows.Forms.Label();
            this.lblFanUsage2 = new System.Windows.Forms.Label();
            this.lblFanUsage1 = new System.Windows.Forms.Label();
            this.lblFanUsage0 = new System.Windows.Forms.Label();
            this.lblNumbersFan = new System.Windows.Forms.Label();
            this.pbFan = new System.Windows.Forms.PictureBox();
            this.lblTemp3 = new System.Windows.Forms.Label();
            this.lblTemp2 = new System.Windows.Forms.Label();
            this.lblTemp1 = new System.Windows.Forms.Label();
            this.lblTemp0 = new System.Windows.Forms.Label();
            this.lblNumbersTemp = new System.Windows.Forms.Label();
            this.pbTemp = new System.Windows.Forms.PictureBox();
            this.lblGPUUsage3 = new System.Windows.Forms.Label();
            this.lblGPUUsage2 = new System.Windows.Forms.Label();
            this.lblGPUUsage1 = new System.Windows.Forms.Label();
            this.lblGPUUsage0 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // lvCrackTasks
            // 
            this.lvCrackTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCrackTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNumber,
            this.chHashType,
            this.chTarget,
            this.chPlain,
            this.chLength,
            this.chProgress,
            this.chTimeEstimated,
            this.chDictMask,
            this.chTimeStarted,
            this.chTimeFinished,
            this.chSession});
            this.lvCrackTasks.FullRowSelect = true;
            this.lvCrackTasks.Location = new System.Drawing.Point(12, 75);
            this.lvCrackTasks.Name = "lvCrackTasks";
            this.lvCrackTasks.Size = new System.Drawing.Size(840, 370);
            this.lvCrackTasks.TabIndex = 0;
            this.lvCrackTasks.UseCompatibleStateImageBehavior = false;
            this.lvCrackTasks.View = System.Windows.Forms.View.Details;
            // 
            // chNumber
            // 
            this.chNumber.Text = "#";
            this.chNumber.Width = 33;
            // 
            // chHashType
            // 
            this.chHashType.Text = "Hash Type";
            this.chHashType.Width = 64;
            // 
            // chTarget
            // 
            this.chTarget.Text = "Target";
            this.chTarget.Width = 92;
            // 
            // chPlain
            // 
            this.chPlain.Text = "Plain";
            this.chPlain.Width = 65;
            // 
            // chLength
            // 
            this.chLength.Text = "Length";
            this.chLength.Width = 46;
            // 
            // chProgress
            // 
            this.chProgress.Text = "Progress";
            this.chProgress.Width = 107;
            // 
            // chTimeEstimated
            // 
            this.chTimeEstimated.Text = "Estimated";
            this.chTimeEstimated.Width = 58;
            // 
            // chDictMask
            // 
            this.chDictMask.Text = "Dict/Mask";
            this.chDictMask.Width = 70;
            // 
            // chTimeStarted
            // 
            this.chTimeStarted.Text = "Started";
            // 
            // chTimeFinished
            // 
            this.chTimeFinished.Text = "Finished";
            // 
            // chSession
            // 
            this.chSession.Text = "Session";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(864, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnAddTask
            // 
            this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_plus;
            this.btnAddTask.Location = new System.Drawing.Point(12, 33);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnAddTask.Size = new System.Drawing.Size(36, 36);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRemoveTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTask.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_delete;
            this.btnRemoveTask.Location = new System.Drawing.Point(48, 33);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnRemoveTask.Size = new System.Drawing.Size(36, 36);
            this.btnRemoveTask.TabIndex = 3;
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEditTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTask.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_edit;
            this.btnEditTask.Location = new System.Drawing.Point(84, 33);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnEditTask.Size = new System.Drawing.Size(36, 36);
            this.btnEditTask.TabIndex = 4;
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnCrack
            // 
            this.btnCrack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCrack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrack.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_play;
            this.btnCrack.Location = new System.Drawing.Point(252, 33);
            this.btnCrack.Name = "btnCrack";
            this.btnCrack.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnCrack.Size = new System.Drawing.Size(36, 36);
            this.btnCrack.TabIndex = 5;
            this.btnCrack.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_stop;
            this.btnStop.Location = new System.Drawing.Point(288, 33);
            this.btnStop.Name = "btnStop";
            this.btnStop.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnStop.Size = new System.Drawing.Size(36, 36);
            this.btnStop.TabIndex = 6;
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_task_update;
            this.btnReset.Location = new System.Drawing.Point(120, 33);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnReset.Size = new System.Drawing.Size(36, 36);
            this.btnReset.TabIndex = 7;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnMoveUp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveUp.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_up;
            this.btnMoveUp.Location = new System.Drawing.Point(168, 33);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnMoveUp.Size = new System.Drawing.Size(36, 36);
            this.btnMoveUp.TabIndex = 8;
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnMoveDown.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveDown.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_down;
            this.btnMoveDown.Location = new System.Drawing.Point(204, 33);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnMoveDown.Size = new System.Drawing.Size(36, 36);
            this.btnMoveDown.TabIndex = 9;
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // pbSpeed
            // 
            this.pbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSpeed.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_speed;
            this.pbSpeed.Location = new System.Drawing.Point(736, 13);
            this.pbSpeed.Name = "pbSpeed";
            this.pbSpeed.Size = new System.Drawing.Size(26, 26);
            this.pbSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSpeed.TabIndex = 10;
            this.pbSpeed.TabStop = false;
            // 
            // lblNumbersSpeed
            // 
            this.lblNumbersSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumbersSpeed.AutoSize = true;
            this.lblNumbersSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumbersSpeed.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblNumbersSpeed.Location = new System.Drawing.Point(768, 10);
            this.lblNumbersSpeed.Name = "lblNumbersSpeed";
            this.lblNumbersSpeed.Size = new System.Drawing.Size(19, 60);
            this.lblNumbersSpeed.TabIndex = 11;
            this.lblNumbersSpeed.Text = "0:\r\n1:\r\n2:\r\n3:";
            // 
            // lblSpeed0
            // 
            this.lblSpeed0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeed0.Location = new System.Drawing.Point(782, 10);
            this.lblSpeed0.Name = "lblSpeed0";
            this.lblSpeed0.Size = new System.Drawing.Size(70, 23);
            this.lblSpeed0.TabIndex = 12;
            this.lblSpeed0.Text = "0 h/s";
            this.lblSpeed0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSpeed1
            // 
            this.lblSpeed1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeed1.Location = new System.Drawing.Point(782, 25);
            this.lblSpeed1.Name = "lblSpeed1";
            this.lblSpeed1.Size = new System.Drawing.Size(70, 15);
            this.lblSpeed1.TabIndex = 13;
            this.lblSpeed1.Text = "0 h/s";
            this.lblSpeed1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSpeed2
            // 
            this.lblSpeed2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeed2.Location = new System.Drawing.Point(782, 40);
            this.lblSpeed2.Name = "lblSpeed2";
            this.lblSpeed2.Size = new System.Drawing.Size(70, 15);
            this.lblSpeed2.TabIndex = 14;
            this.lblSpeed2.Text = "0 h/s";
            this.lblSpeed2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSpeed3
            // 
            this.lblSpeed3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeed3.Location = new System.Drawing.Point(782, 55);
            this.lblSpeed3.Name = "lblSpeed3";
            this.lblSpeed3.Size = new System.Drawing.Size(70, 15);
            this.lblSpeed3.TabIndex = 15;
            this.lblSpeed3.Text = "0 h/s";
            this.lblSpeed3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNumbersGPU
            // 
            this.lblNumbersGPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumbersGPU.AutoSize = true;
            this.lblNumbersGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumbersGPU.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblNumbersGPU.Location = new System.Drawing.Point(446, 9);
            this.lblNumbersGPU.Name = "lblNumbersGPU";
            this.lblNumbersGPU.Size = new System.Drawing.Size(19, 60);
            this.lblNumbersGPU.TabIndex = 17;
            this.lblNumbersGPU.Text = "0:\r\n1:\r\n2:\r\n3:";
            // 
            // pbGPU
            // 
            this.pbGPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGPU.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_videocard;
            this.pbGPU.Location = new System.Drawing.Point(414, 12);
            this.pbGPU.Name = "pbGPU";
            this.pbGPU.Size = new System.Drawing.Size(26, 26);
            this.pbGPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbGPU.TabIndex = 16;
            this.pbGPU.TabStop = false;
            // 
            // lblFanUsage3
            // 
            this.lblFanUsage3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFanUsage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFanUsage3.Location = new System.Drawing.Point(567, 54);
            this.lblFanUsage3.Name = "lblFanUsage3";
            this.lblFanUsage3.Size = new System.Drawing.Size(41, 15);
            this.lblFanUsage3.TabIndex = 27;
            this.lblFanUsage3.Text = "0%";
            this.lblFanUsage3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFanUsage2
            // 
            this.lblFanUsage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFanUsage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFanUsage2.Location = new System.Drawing.Point(567, 39);
            this.lblFanUsage2.Name = "lblFanUsage2";
            this.lblFanUsage2.Size = new System.Drawing.Size(41, 15);
            this.lblFanUsage2.TabIndex = 26;
            this.lblFanUsage2.Text = "0%";
            this.lblFanUsage2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFanUsage1
            // 
            this.lblFanUsage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFanUsage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFanUsage1.Location = new System.Drawing.Point(567, 24);
            this.lblFanUsage1.Name = "lblFanUsage1";
            this.lblFanUsage1.Size = new System.Drawing.Size(41, 15);
            this.lblFanUsage1.TabIndex = 25;
            this.lblFanUsage1.Text = "0%";
            this.lblFanUsage1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFanUsage0
            // 
            this.lblFanUsage0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFanUsage0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFanUsage0.Location = new System.Drawing.Point(567, 9);
            this.lblFanUsage0.Name = "lblFanUsage0";
            this.lblFanUsage0.Size = new System.Drawing.Size(41, 15);
            this.lblFanUsage0.TabIndex = 24;
            this.lblFanUsage0.Text = "0%";
            this.lblFanUsage0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNumbersFan
            // 
            this.lblNumbersFan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumbersFan.AutoSize = true;
            this.lblNumbersFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumbersFan.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblNumbersFan.Location = new System.Drawing.Point(552, 9);
            this.lblNumbersFan.Name = "lblNumbersFan";
            this.lblNumbersFan.Size = new System.Drawing.Size(19, 60);
            this.lblNumbersFan.TabIndex = 23;
            this.lblNumbersFan.Text = "0:\r\n1:\r\n2:\r\n3:";
            // 
            // pbFan
            // 
            this.pbFan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFan.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_fan;
            this.pbFan.Location = new System.Drawing.Point(520, 12);
            this.pbFan.Name = "pbFan";
            this.pbFan.Size = new System.Drawing.Size(26, 26);
            this.pbFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFan.TabIndex = 22;
            this.pbFan.TabStop = false;
            // 
            // lblTemp3
            // 
            this.lblTemp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTemp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemp3.Location = new System.Drawing.Point(672, 54);
            this.lblTemp3.Name = "lblTemp3";
            this.lblTemp3.Size = new System.Drawing.Size(48, 15);
            this.lblTemp3.TabIndex = 33;
            this.lblTemp3.Text = "0 °C";
            this.lblTemp3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTemp2
            // 
            this.lblTemp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTemp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemp2.Location = new System.Drawing.Point(672, 39);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(48, 15);
            this.lblTemp2.TabIndex = 32;
            this.lblTemp2.Text = "0 °C";
            this.lblTemp2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTemp1
            // 
            this.lblTemp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemp1.Location = new System.Drawing.Point(672, 24);
            this.lblTemp1.Name = "lblTemp1";
            this.lblTemp1.Size = new System.Drawing.Size(48, 15);
            this.lblTemp1.TabIndex = 31;
            this.lblTemp1.Text = "0 °C";
            this.lblTemp1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTemp0
            // 
            this.lblTemp0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTemp0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemp0.Location = new System.Drawing.Point(672, 9);
            this.lblTemp0.Name = "lblTemp0";
            this.lblTemp0.Size = new System.Drawing.Size(48, 15);
            this.lblTemp0.TabIndex = 30;
            this.lblTemp0.Text = "0 °C";
            this.lblTemp0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNumbersTemp
            // 
            this.lblNumbersTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumbersTemp.AutoSize = true;
            this.lblNumbersTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumbersTemp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblNumbersTemp.Location = new System.Drawing.Point(657, 9);
            this.lblNumbersTemp.Name = "lblNumbersTemp";
            this.lblNumbersTemp.Size = new System.Drawing.Size(19, 60);
            this.lblNumbersTemp.TabIndex = 29;
            this.lblNumbersTemp.Text = "0:\r\n1:\r\n2:\r\n3:";
            // 
            // pbTemp
            // 
            this.pbTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTemp.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_temperature;
            this.pbTemp.Location = new System.Drawing.Point(625, 12);
            this.pbTemp.Name = "pbTemp";
            this.pbTemp.Size = new System.Drawing.Size(26, 26);
            this.pbTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbTemp.TabIndex = 28;
            this.pbTemp.TabStop = false;
            // 
            // lblGPUUsage3
            // 
            this.lblGPUUsage3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGPUUsage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGPUUsage3.Location = new System.Drawing.Point(461, 54);
            this.lblGPUUsage3.Name = "lblGPUUsage3";
            this.lblGPUUsage3.Size = new System.Drawing.Size(41, 15);
            this.lblGPUUsage3.TabIndex = 37;
            this.lblGPUUsage3.Text = "0%";
            this.lblGPUUsage3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGPUUsage2
            // 
            this.lblGPUUsage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGPUUsage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGPUUsage2.Location = new System.Drawing.Point(461, 39);
            this.lblGPUUsage2.Name = "lblGPUUsage2";
            this.lblGPUUsage2.Size = new System.Drawing.Size(41, 15);
            this.lblGPUUsage2.TabIndex = 36;
            this.lblGPUUsage2.Text = "0%";
            this.lblGPUUsage2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGPUUsage1
            // 
            this.lblGPUUsage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGPUUsage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGPUUsage1.Location = new System.Drawing.Point(461, 24);
            this.lblGPUUsage1.Name = "lblGPUUsage1";
            this.lblGPUUsage1.Size = new System.Drawing.Size(41, 15);
            this.lblGPUUsage1.TabIndex = 35;
            this.lblGPUUsage1.Text = "0%";
            this.lblGPUUsage1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGPUUsage0
            // 
            this.lblGPUUsage0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGPUUsage0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGPUUsage0.Location = new System.Drawing.Point(461, 9);
            this.lblGPUUsage0.Name = "lblGPUUsage0";
            this.lblGPUUsage0.Size = new System.Drawing.Size(41, 15);
            this.lblGPUUsage0.TabIndex = 34;
            this.lblGPUUsage0.Text = "0%";
            this.lblGPUUsage0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Location = new System.Drawing.Point(508, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(2, 64);
            this.label21.TabIndex = 38;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(613, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(2, 64);
            this.label22.TabIndex = 39;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(725, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(2, 64);
            this.label23.TabIndex = 40;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_settings;
            this.btnSettings.Location = new System.Drawing.Point(336, 33);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnSettings.Size = new System.Drawing.Size(36, 36);
            this.btnSettings.TabIndex = 41;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 482);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblGPUUsage3);
            this.Controls.Add(this.lblGPUUsage2);
            this.Controls.Add(this.lblGPUUsage1);
            this.Controls.Add(this.lblGPUUsage0);
            this.Controls.Add(this.lblTemp3);
            this.Controls.Add(this.lblTemp2);
            this.Controls.Add(this.lblTemp1);
            this.Controls.Add(this.lblTemp0);
            this.Controls.Add(this.lblNumbersTemp);
            this.Controls.Add(this.pbTemp);
            this.Controls.Add(this.lblFanUsage3);
            this.Controls.Add(this.lblFanUsage2);
            this.Controls.Add(this.lblFanUsage1);
            this.Controls.Add(this.lblFanUsage0);
            this.Controls.Add(this.lblNumbersFan);
            this.Controls.Add(this.pbFan);
            this.Controls.Add(this.lblNumbersGPU);
            this.Controls.Add(this.pbGPU);
            this.Controls.Add(this.lblSpeed3);
            this.Controls.Add(this.lblSpeed2);
            this.Controls.Add(this.lblSpeed1);
            this.Controls.Add(this.lblSpeed0);
            this.Controls.Add(this.lblNumbersSpeed);
            this.Controls.Add(this.pbSpeed);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCrack);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lvCrackTasks);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCrackTasks;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.ColumnHeader chNumber;
        private System.Windows.Forms.ColumnHeader chHashType;
        private System.Windows.Forms.ColumnHeader chTarget;
        private System.Windows.Forms.ColumnHeader chPlain;
        private System.Windows.Forms.ColumnHeader chLength;
        private System.Windows.Forms.ColumnHeader chProgress;
        private System.Windows.Forms.ColumnHeader chTimeEstimated;
        private System.Windows.Forms.ColumnHeader chDictMask;
        private System.Windows.Forms.ColumnHeader chTimeStarted;
        private System.Windows.Forms.ColumnHeader chTimeFinished;
        private System.Windows.Forms.ColumnHeader chSession;
        private System.Windows.Forms.Button btnCrack;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.PictureBox pbSpeed;
        private System.Windows.Forms.Label lblNumbersSpeed;
        private System.Windows.Forms.Label lblSpeed0;
        private System.Windows.Forms.Label lblSpeed1;
        private System.Windows.Forms.Label lblSpeed2;
        private System.Windows.Forms.Label lblSpeed3;
        private System.Windows.Forms.Label lblNumbersGPU;
        private System.Windows.Forms.PictureBox pbGPU;
        private System.Windows.Forms.Label lblFanUsage3;
        private System.Windows.Forms.Label lblFanUsage2;
        private System.Windows.Forms.Label lblFanUsage1;
        private System.Windows.Forms.Label lblFanUsage0;
        private System.Windows.Forms.Label lblNumbersFan;
        private System.Windows.Forms.PictureBox pbFan;
        private System.Windows.Forms.Label lblTemp3;
        private System.Windows.Forms.Label lblTemp2;
        private System.Windows.Forms.Label lblTemp1;
        private System.Windows.Forms.Label lblTemp0;
        private System.Windows.Forms.Label lblNumbersTemp;
        private System.Windows.Forms.PictureBox pbTemp;
        private System.Windows.Forms.Label lblGPUUsage3;
        private System.Windows.Forms.Label lblGPUUsage2;
        private System.Windows.Forms.Label lblGPUUsage1;
        private System.Windows.Forms.Label lblGPUUsage0;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnSettings;
    }
}