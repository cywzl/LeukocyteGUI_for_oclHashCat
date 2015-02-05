namespace LeukocyteGUI_for_oclHashCat
{
    partial class ConvertationStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertationStatistics));
            this.labelConverting = new System.Windows.Forms.Label();
            this.labelConvertingStatus = new System.Windows.Forms.Label();
            this.listViewConvertSuccess = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListConvertStatus = new System.Windows.Forms.ImageList(this.components);
            this.buttonConfirmSuccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelConverting
            // 
            this.labelConverting.AutoSize = true;
            this.labelConverting.Location = new System.Drawing.Point(10, 18);
            this.labelConverting.Name = "labelConverting";
            this.labelConverting.Size = new System.Drawing.Size(61, 13);
            this.labelConverting.TabIndex = 1;
            this.labelConverting.Text = "Converting:";
            // 
            // labelConvertingStatus
            // 
            this.labelConvertingStatus.Location = new System.Drawing.Point(237, 18);
            this.labelConvertingStatus.Name = "labelConvertingStatus";
            this.labelConvertingStatus.Size = new System.Drawing.Size(61, 13);
            this.labelConvertingStatus.TabIndex = 2;
            this.labelConvertingStatus.Text = "0 / 0";
            this.labelConvertingStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listViewConvertSuccess
            // 
            this.listViewConvertSuccess.BackColor = System.Drawing.SystemColors.Control;
            this.listViewConvertSuccess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewConvertSuccess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewConvertSuccess.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewConvertSuccess.Location = new System.Drawing.Point(12, 45);
            this.listViewConvertSuccess.Name = "listViewConvertSuccess";
            this.listViewConvertSuccess.Size = new System.Drawing.Size(283, 161);
            this.listViewConvertSuccess.SmallImageList = this.imageListConvertStatus;
            this.listViewConvertSuccess.TabIndex = 4;
            this.listViewConvertSuccess.UseCompatibleStateImageBehavior = false;
            this.listViewConvertSuccess.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 1;
            // 
            // imageListConvertStatus
            // 
            this.imageListConvertStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListConvertStatus.ImageStream")));
            this.imageListConvertStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListConvertStatus.Images.SetKeyName(0, "glyph_delete.png");
            this.imageListConvertStatus.Images.SetKeyName(1, "glyph_task_ok.png");
            this.imageListConvertStatus.Images.SetKeyName(2, "button_cancel_5732.png");
            this.imageListConvertStatus.Images.SetKeyName(3, "button_ok_4174.png");
            // 
            // buttonConfirmSuccess
            // 
            this.buttonConfirmSuccess.Enabled = false;
            this.buttonConfirmSuccess.FlatAppearance.BorderSize = 0;
            this.buttonConfirmSuccess.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonConfirmSuccess.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonConfirmSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmSuccess.Image = global::LeukocyteGUI_for_oclHashCat.Properties.Resources.glyph_task_ok;
            this.buttonConfirmSuccess.Location = new System.Drawing.Point(133, 216);
            this.buttonConfirmSuccess.Name = "buttonConfirmSuccess";
            this.buttonConfirmSuccess.Size = new System.Drawing.Size(44, 39);
            this.buttonConfirmSuccess.TabIndex = 5;
            this.buttonConfirmSuccess.UseVisualStyleBackColor = true;
            this.buttonConfirmSuccess.Click += new System.EventHandler(this.buttonConfirmSuccess_Click);
            // 
            // ConvertationStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 267);
            this.Controls.Add(this.buttonConfirmSuccess);
            this.Controls.Add(this.listViewConvertSuccess);
            this.Controls.Add(this.labelConvertingStatus);
            this.Controls.Add(this.labelConverting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConvertationStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Converting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConverting;
        private System.Windows.Forms.Label labelConvertingStatus;
        private System.Windows.Forms.ListView listViewConvertSuccess;
        private System.Windows.Forms.ImageList imageListConvertStatus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonConfirmSuccess;
    }
}