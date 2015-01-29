namespace LeukocyteGUI_for_oclHashCat
{
    partial class ConverterForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConverterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseOutputDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listBoxFilenames = new System.Windows.Forms.ListBox();
            this.chooseConverterDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxConverter = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChooseOutput = new System.Windows.Forms.Button();
            this.buttonChooseConverter = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // chooseFilesDialog
            // 
            resources.ApplyResources(this.chooseFilesDialog, "chooseFilesDialog");
            this.chooseFilesDialog.Multiselect = true;
            // 
            // listBoxFilenames
            // 
            this.listBoxFilenames.AllowDrop = true;
            this.listBoxFilenames.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxFilenames, "listBoxFilenames");
            this.listBoxFilenames.Name = "listBoxFilenames";
            this.listBoxFilenames.SelectedIndexChanged += new System.EventHandler(this.listBoxFilenames_SelectedIndexChanged);
            this.listBoxFilenames.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxFilenames_DragDrop);
            this.listBoxFilenames.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxFilenames_DragEnter);
            // 
            // chooseConverterDialog
            // 
            this.chooseConverterDialog.FileName = "aircrack-ng.exe";
            resources.ApplyResources(this.chooseConverterDialog, "chooseConverterDialog");
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default, "hccapOutputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.textBoxOutput, "textBoxOutput");
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Text = global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default.hccapOutputPath;
            // 
            // textBoxConverter
            // 
            this.textBoxConverter.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default, "capConverter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.textBoxConverter, "textBoxConverter");
            this.textBoxConverter.Name = "textBoxConverter";
            this.textBoxConverter.Text = global::LeukocyteGUI_for_oclHashCat.Properties.Settings.Default.capConverter;
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClear.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_clear;
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_plus;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMoveDown
            // 
            resources.ApplyResources(this.buttonMoveDown, "buttonMoveDown");
            this.buttonMoveDown.FlatAppearance.BorderSize = 0;
            this.buttonMoveDown.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMoveDown.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMoveDown.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_down;
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveUpDown_Click);
            // 
            // buttonMoveUp
            // 
            resources.ApplyResources(this.buttonMoveUp, "buttonMoveUp");
            this.buttonMoveUp.FlatAppearance.BorderSize = 0;
            this.buttonMoveUp.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMoveUp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMoveUp.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_up;
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUpDown_Click);
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDelete.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_delete;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChooseOutput
            // 
            this.buttonChooseOutput.FlatAppearance.BorderSize = 0;
            this.buttonChooseOutput.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseOutput.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.buttonChooseOutput, "buttonChooseOutput");
            this.buttonChooseOutput.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_add_folder;
            this.buttonChooseOutput.Name = "buttonChooseOutput";
            this.buttonChooseOutput.UseVisualStyleBackColor = true;
            this.buttonChooseOutput.Click += new System.EventHandler(this.buttonChooseOutput_Click);
            // 
            // buttonChooseConverter
            // 
            this.buttonChooseConverter.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonChooseConverter.FlatAppearance.BorderSize = 0;
            this.buttonChooseConverter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChooseConverter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.buttonChooseConverter, "buttonChooseConverter");
            this.buttonChooseConverter.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_open_exe;
            this.buttonChooseConverter.Name = "buttonChooseConverter";
            this.buttonChooseConverter.UseVisualStyleBackColor = true;
            this.buttonChooseConverter.Click += new System.EventHandler(this.buttonChooseConverter_Click);
            // 
            // buttonConvert
            // 
            resources.ApplyResources(this.buttonConvert, "buttonConvert");
            this.buttonConvert.FlatAppearance.BorderSize = 0;
            this.buttonConvert.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonConvert.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonConvert.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_convert_cap;
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // ConverterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxFilenames);
            this.Controls.Add(this.buttonChooseOutput);
            this.Controls.Add(this.buttonChooseConverter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConverter);
            this.Controls.Add(this.buttonConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConverterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConverterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox textBoxConverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.OpenFileDialog chooseFilesDialog;
        private System.Windows.Forms.Button buttonChooseConverter;
        private System.Windows.Forms.Button buttonChooseOutput;
        private System.Windows.Forms.FolderBrowserDialog chooseOutputDialog;
        private System.Windows.Forms.ListBox listBoxFilenames;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.OpenFileDialog chooseConverterDialog;
        private System.Windows.Forms.Button buttonClear;



    }
}

