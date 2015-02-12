namespace LeukocyteGUI_for_oclHashCat
{
    partial class DictionaryEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DictionaryEditorForm));
            this.labelDictionary = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxDictionary = new System.Windows.Forms.TextBox();
            this.buttonChooseDictionary = new System.Windows.Forms.Button();
            this.buttonCancelTask = new System.Windows.Forms.Button();
            this.buttonSettingsOK = new System.Windows.Forms.Button();
            this.openFileDialogDictionary = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelDictionary
            // 
            this.labelDictionary.AutoSize = true;
            this.labelDictionary.Location = new System.Drawing.Point(12, 19);
            this.labelDictionary.Name = "labelDictionary";
            this.labelDictionary.Size = new System.Drawing.Size(57, 13);
            this.labelDictionary.TabIndex = 0;
            this.labelDictionary.Text = "Dictionary:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 45);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(81, 42);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(237, 20);
            this.textBoxDescription.TabIndex = 3;
            // 
            // textBoxDictionary
            // 
            this.textBoxDictionary.Location = new System.Drawing.Point(81, 16);
            this.textBoxDictionary.Name = "textBoxDictionary";
            this.textBoxDictionary.Size = new System.Drawing.Size(197, 20);
            this.textBoxDictionary.TabIndex = 1;
            // 
            // buttonChooseDictionary
            // 
            this.buttonChooseDictionary.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChooseDictionary.FlatAppearance.BorderSize = 0;
            this.buttonChooseDictionary.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseDictionary.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseDictionary.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe16;
            this.buttonChooseDictionary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseDictionary.Location = new System.Drawing.Point(284, 15);
            this.buttonChooseDictionary.Name = "buttonChooseDictionary";
            this.buttonChooseDictionary.Size = new System.Drawing.Size(34, 22);
            this.buttonChooseDictionary.TabIndex = 2;
            this.buttonChooseDictionary.UseVisualStyleBackColor = true;
            this.buttonChooseDictionary.Click += new System.EventHandler(this.buttonChooseDictionary_Click);
            // 
            // buttonCancelTask
            // 
            this.buttonCancelTask.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelTask.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancelTask.FlatAppearance.BorderSize = 0;
            this.buttonCancelTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCancelTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelTask.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_cancel;
            this.buttonCancelTask.Location = new System.Drawing.Point(278, 77);
            this.buttonCancelTask.Name = "buttonCancelTask";
            this.buttonCancelTask.Padding = new System.Windows.Forms.Padding(3);
            this.buttonCancelTask.Size = new System.Drawing.Size(40, 40);
            this.buttonCancelTask.TabIndex = 5;
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
            this.buttonSettingsOK.Location = new System.Drawing.Point(232, 77);
            this.buttonSettingsOK.Name = "buttonSettingsOK";
            this.buttonSettingsOK.Padding = new System.Windows.Forms.Padding(3);
            this.buttonSettingsOK.Size = new System.Drawing.Size(40, 40);
            this.buttonSettingsOK.TabIndex = 4;
            this.buttonSettingsOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettingsOK.UseVisualStyleBackColor = true;
            this.buttonSettingsOK.Click += new System.EventHandler(this.buttonSettingsOK_Click);
            // 
            // openFileDialogDictionary
            // 
            this.openFileDialogDictionary.FileName = "dictionary";
            this.openFileDialogDictionary.Filter = "Text files (*.txt)|*.txt|Any files (*.*)|*.*";
            this.openFileDialogDictionary.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogDictionary_FileOk);
            // 
            // DictionaryEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 130);
            this.Controls.Add(this.buttonCancelTask);
            this.Controls.Add(this.buttonSettingsOK);
            this.Controls.Add(this.buttonChooseDictionary);
            this.Controls.Add(this.textBoxDictionary);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelDictionary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DictionaryEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dictionary Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDictionary;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxDictionary;
        private System.Windows.Forms.Button buttonChooseDictionary;
        private System.Windows.Forms.Button buttonCancelTask;
        private System.Windows.Forms.Button buttonSettingsOK;
        private System.Windows.Forms.OpenFileDialog openFileDialogDictionary;
    }
}