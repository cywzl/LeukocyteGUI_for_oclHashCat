namespace LeukocyteGUI_for_oclHashcat.Forms
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
            this.tpSettingsHashTypes = new System.Windows.Forms.TabPage();
            this.btnEditHashType = new System.Windows.Forms.Button();
            this.btnRemoveHashType = new System.Windows.Forms.Button();
            this.btnAddHashType = new System.Windows.Forms.Button();
            this.lvHashTypes = new System.Windows.Forms.ListView();
            this.chHashTypeNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHashTypeCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHashTypeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHashTypeDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcSettings.SuspendLayout();
            this.tpSettingsPredefined.SuspendLayout();
            this.tpSettingsHashTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSettings
            // 
            this.tcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcSettings.Controls.Add(this.tpSettingsMain);
            this.tcSettings.Controls.Add(this.tpSettingsPredefined);
            this.tcSettings.Controls.Add(this.tpSettingsHashTypes);
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
            this.btnEditPredefined.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_edit;
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
            this.btnRemovePredefined.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_delete;
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
            this.btnAddPredefined.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_plus;
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
            // tpSettingsHashTypes
            // 
            this.tpSettingsHashTypes.Controls.Add(this.btnEditHashType);
            this.tpSettingsHashTypes.Controls.Add(this.btnRemoveHashType);
            this.tpSettingsHashTypes.Controls.Add(this.btnAddHashType);
            this.tpSettingsHashTypes.Controls.Add(this.lvHashTypes);
            this.tpSettingsHashTypes.Location = new System.Drawing.Point(4, 22);
            this.tpSettingsHashTypes.Name = "tpSettingsHashTypes";
            this.tpSettingsHashTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettingsHashTypes.Size = new System.Drawing.Size(494, 316);
            this.tpSettingsHashTypes.TabIndex = 2;
            this.tpSettingsHashTypes.Text = "HashTypes";
            this.tpSettingsHashTypes.UseVisualStyleBackColor = true;
            // 
            // btnEditHashType
            // 
            this.btnEditHashType.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditHashType.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditHashType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditHashType.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_edit;
            this.btnEditHashType.Location = new System.Drawing.Point(88, 8);
            this.btnEditHashType.Name = "btnEditHashType";
            this.btnEditHashType.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnEditHashType.Size = new System.Drawing.Size(32, 32);
            this.btnEditHashType.TabIndex = 10;
            this.btnEditHashType.UseVisualStyleBackColor = true;
            this.btnEditHashType.Click += new System.EventHandler(this.btnEditHashType_Click);
            // 
            // btnRemoveHashType
            // 
            this.btnRemoveHashType.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemoveHashType.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRemoveHashType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveHashType.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_delete;
            this.btnRemoveHashType.Location = new System.Drawing.Point(52, 8);
            this.btnRemoveHashType.Name = "btnRemoveHashType";
            this.btnRemoveHashType.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnRemoveHashType.Size = new System.Drawing.Size(32, 32);
            this.btnRemoveHashType.TabIndex = 9;
            this.btnRemoveHashType.UseVisualStyleBackColor = true;
            this.btnRemoveHashType.Click += new System.EventHandler(this.btnRemoveHashType_Click);
            // 
            // btnAddHashType
            // 
            this.btnAddHashType.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddHashType.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddHashType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHashType.Image = global::LeukocyteGUI_for_oclHashcat.Properties.Resources.glyph_plus;
            this.btnAddHashType.Location = new System.Drawing.Point(16, 8);
            this.btnAddHashType.Name = "btnAddHashType";
            this.btnAddHashType.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnAddHashType.Size = new System.Drawing.Size(32, 32);
            this.btnAddHashType.TabIndex = 8;
            this.btnAddHashType.UseVisualStyleBackColor = true;
            this.btnAddHashType.Click += new System.EventHandler(this.btnAddHashType_Click);
            // 
            // lvHashTypes
            // 
            this.lvHashTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chHashTypeNumber,
            this.chHashTypeCode,
            this.chHashTypeName,
            this.chHashTypeDescription});
            this.lvHashTypes.FullRowSelect = true;
            this.lvHashTypes.Location = new System.Drawing.Point(16, 46);
            this.lvHashTypes.Name = "lvHashTypes";
            this.lvHashTypes.Size = new System.Drawing.Size(460, 252);
            this.lvHashTypes.TabIndex = 7;
            this.lvHashTypes.UseCompatibleStateImageBehavior = false;
            this.lvHashTypes.View = System.Windows.Forms.View.Details;
            this.lvHashTypes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvHashTypes_ColumnClick);
            // 
            // chHashTypeNumber
            // 
            this.chHashTypeNumber.Text = "#";
            this.chHashTypeNumber.Width = 40;
            // 
            // chHashTypeCode
            // 
            this.chHashTypeCode.Text = "Code";
            // 
            // chHashTypeName
            // 
            this.chHashTypeName.Text = "Name";
            this.chHashTypeName.Width = 68;
            // 
            // chHashTypeDescription
            // 
            this.chHashTypeDescription.Text = "Description";
            this.chHashTypeDescription.Width = 259;
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
            this.tpSettingsHashTypes.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tpSettingsHashTypes;
        private System.Windows.Forms.Button btnEditHashType;
        private System.Windows.Forms.Button btnRemoveHashType;
        private System.Windows.Forms.Button btnAddHashType;
        private System.Windows.Forms.ListView lvHashTypes;
        private System.Windows.Forms.ColumnHeader chHashTypeNumber;
        private System.Windows.Forms.ColumnHeader chHashTypeCode;
        private System.Windows.Forms.ColumnHeader chHashTypeName;
        private System.Windows.Forms.ColumnHeader chHashTypeDescription;
    }
}