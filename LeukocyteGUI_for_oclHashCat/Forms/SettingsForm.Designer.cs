namespace LeukocyteGUI_for_oclHashCat.Forms
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
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpSettingsMain = new System.Windows.Forms.TabPage();
            this.tpSettingsPredefined = new System.Windows.Forms.TabPage();
            this.btnEditPredefined = new System.Windows.Forms.Button();
            this.btnRemovePredefined = new System.Windows.Forms.Button();
            this.btnAddPredefined = new System.Windows.Forms.Button();
            this.lvPredefined = new System.Windows.Forms.ListView();
            this.chPredefinedNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPredefinedType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPredefinedName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPredefinedDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcSettings.SuspendLayout();
            this.tpSettingsPredefined.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSettings
            // 
            this.tcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcSettings.Controls.Add(this.tpSettingsMain);
            this.tcSettings.Controls.Add(this.tpSettingsPredefined);
            this.tcSettings.Location = new System.Drawing.Point(12, 12);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(502, 342);
            this.tcSettings.TabIndex = 0;
            // 
            // tpSettingsMain
            // 
            this.tpSettingsMain.Location = new System.Drawing.Point(4, 22);
            this.tpSettingsMain.Name = "tpSettingsMain";
            this.tpSettingsMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettingsMain.Size = new System.Drawing.Size(494, 316);
            this.tpSettingsMain.TabIndex = 0;
            this.tpSettingsMain.Text = "Main";
            this.tpSettingsMain.UseVisualStyleBackColor = true;
            // 
            // tpSettingsPredefined
            // 
            this.tpSettingsPredefined.Controls.Add(this.btnEditPredefined);
            this.tpSettingsPredefined.Controls.Add(this.btnRemovePredefined);
            this.tpSettingsPredefined.Controls.Add(this.btnAddPredefined);
            this.tpSettingsPredefined.Controls.Add(this.lvPredefined);
            this.tpSettingsPredefined.Location = new System.Drawing.Point(4, 22);
            this.tpSettingsPredefined.Name = "tpSettingsPredefined";
            this.tpSettingsPredefined.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettingsPredefined.Size = new System.Drawing.Size(494, 316);
            this.tpSettingsPredefined.TabIndex = 1;
            this.tpSettingsPredefined.Text = "Predefined";
            this.tpSettingsPredefined.UseVisualStyleBackColor = true;
            // 
            // btnEditPredefined
            // 
            this.btnEditPredefined.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditPredefined.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditPredefined.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPredefined.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_edit;
            this.btnEditPredefined.Location = new System.Drawing.Point(88, 8);
            this.btnEditPredefined.Name = "btnEditPredefined";
            this.btnEditPredefined.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnEditPredefined.Size = new System.Drawing.Size(32, 32);
            this.btnEditPredefined.TabIndex = 6;
            this.btnEditPredefined.UseVisualStyleBackColor = true;
            this.btnEditPredefined.Click += new System.EventHandler(this.btnEditPredefined_Click);
            // 
            // btnRemovePredefined
            // 
            this.btnRemovePredefined.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemovePredefined.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRemovePredefined.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePredefined.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_delete;
            this.btnRemovePredefined.Location = new System.Drawing.Point(52, 8);
            this.btnRemovePredefined.Name = "btnRemovePredefined";
            this.btnRemovePredefined.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnRemovePredefined.Size = new System.Drawing.Size(32, 32);
            this.btnRemovePredefined.TabIndex = 5;
            this.btnRemovePredefined.UseVisualStyleBackColor = true;
            // 
            // btnAddPredefined
            // 
            this.btnAddPredefined.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddPredefined.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddPredefined.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPredefined.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_plus;
            this.btnAddPredefined.Location = new System.Drawing.Point(16, 8);
            this.btnAddPredefined.Name = "btnAddPredefined";
            this.btnAddPredefined.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnAddPredefined.Size = new System.Drawing.Size(32, 32);
            this.btnAddPredefined.TabIndex = 3;
            this.btnAddPredefined.UseVisualStyleBackColor = true;
            this.btnAddPredefined.Click += new System.EventHandler(this.btnAddPredefined_Click);
            // 
            // lvPredefined
            // 
            this.lvPredefined.CheckBoxes = true;
            this.lvPredefined.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPredefinedNumber,
            this.chPredefinedType,
            this.chPredefinedName,
            this.chPredefinedDescription});
            this.lvPredefined.FullRowSelect = true;
            this.lvPredefined.Location = new System.Drawing.Point(16, 46);
            this.lvPredefined.Name = "lvPredefined";
            this.lvPredefined.Size = new System.Drawing.Size(460, 252);
            this.lvPredefined.TabIndex = 1;
            this.lvPredefined.UseCompatibleStateImageBehavior = false;
            this.lvPredefined.View = System.Windows.Forms.View.Details;
            // 
            // chPredefinedNumber
            // 
            this.chPredefinedNumber.Text = "#";
            this.chPredefinedNumber.Width = 40;
            // 
            // chPredefinedType
            // 
            this.chPredefinedType.Text = "Type";
            // 
            // chPredefinedName
            // 
            this.chPredefinedName.Text = "Name";
            this.chPredefinedName.Width = 68;
            // 
            // chPredefinedDescription
            // 
            this.chPredefinedDescription.Text = "Description";
            this.chPredefinedDescription.Width = 259;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 366);
            this.Controls.Add(this.tcSettings);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.tcSettings.ResumeLayout(false);
            this.tpSettingsPredefined.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpSettingsMain;
        private System.Windows.Forms.TabPage tpSettingsPredefined;
        private System.Windows.Forms.ListView lvPredefined;
        private System.Windows.Forms.ColumnHeader chPredefinedNumber;
        private System.Windows.Forms.ColumnHeader chPredefinedType;
        private System.Windows.Forms.ColumnHeader chPredefinedName;
        private System.Windows.Forms.ColumnHeader chPredefinedDescription;
        private System.Windows.Forms.Button btnAddPredefined;
        private System.Windows.Forms.Button btnEditPredefined;
        private System.Windows.Forms.Button btnRemovePredefined;
    }
}