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
            this.lvCrackTasks = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnCrack = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
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
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
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
            this.lvCrackTasks.Location = new System.Drawing.Point(12, 75);
            this.lvCrackTasks.Name = "lvCrackTasks";
            this.lvCrackTasks.Size = new System.Drawing.Size(689, 326);
            this.lvCrackTasks.TabIndex = 0;
            this.lvCrackTasks.UseCompatibleStateImageBehavior = false;
            this.lvCrackTasks.View = System.Windows.Forms.View.Details;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(713, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnAddTask
            // 
            this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_plus;
            this.btnAddTask.Location = new System.Drawing.Point(12, 33);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnAddTask.Size = new System.Drawing.Size(36, 36);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRemoveTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_delete;
            this.btnRemoveTask.Location = new System.Drawing.Point(48, 33);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnRemoveTask.Size = new System.Drawing.Size(36, 36);
            this.btnRemoveTask.TabIndex = 3;
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            // 
            // btnEditTask
            // 
            this.btnEditTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEditTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_edit;
            this.btnEditTask.Location = new System.Drawing.Point(84, 33);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnEditTask.Size = new System.Drawing.Size(36, 36);
            this.btnEditTask.TabIndex = 4;
            this.btnEditTask.UseVisualStyleBackColor = true;
            // 
            // btnCrack
            // 
            this.btnCrack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCrack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrack.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_play;
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
            this.btnStop.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_stop;
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
            this.btnReset.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_update;
            this.btnReset.Location = new System.Drawing.Point(120, 33);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnReset.Size = new System.Drawing.Size(36, 36);
            this.btnReset.TabIndex = 7;
            this.btnReset.UseVisualStyleBackColor = true;
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
            // btnMoveUp
            // 
            this.btnMoveUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnMoveUp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveUp.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_up;
            this.btnMoveUp.Location = new System.Drawing.Point(168, 33);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnMoveUp.Size = new System.Drawing.Size(36, 36);
            this.btnMoveUp.TabIndex = 8;
            this.btnMoveUp.UseVisualStyleBackColor = true;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnMoveDown.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveDown.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_down;
            this.btnMoveDown.Location = new System.Drawing.Point(204, 33);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnMoveDown.Size = new System.Drawing.Size(36, 36);
            this.btnMoveDown.TabIndex = 9;
            this.btnMoveDown.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 438);
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
    }
}