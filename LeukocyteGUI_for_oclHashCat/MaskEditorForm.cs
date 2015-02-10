using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashCat
{
    public partial class MaskEditorForm : Form
    {
        private MaskManager maskManager;
        private int changingMaskId;

        public MaskEditorForm(MaskManager maskManager,
            int changingMaskId = -1)
        {
            InitializeComponent();
            this.maskManager = maskManager;
            this.changingMaskId = changingMaskId;

            if (changingMaskId > -1)
            {
                FillFormWithData();
            }
        }

        private void buttonSettingsOK_Click(object sender, EventArgs e)
        {
            MaskManager.Mask newMask = new MaskManager.Mask();

            newMask.BruteMask = textBoxMask.Text;
            newMask.Description = textBoxDescription.Text;
            newMask.Charset1 = textBoxCharset1.Text;
            newMask.Charset2 = textBoxCharset2.Text;
            newMask.Charset3 = textBoxCharset3.Text;
            newMask.Charset4 = textBoxCharset4.Text;
            newMask.UseCharset1 = checkBoxCharset1.Checked;
            newMask.UseCharset2 = checkBoxCharset2.Checked;
            newMask.UseCharset3 = checkBoxCharset3.Checked;
            newMask.UseCharset4 = checkBoxCharset4.Checked;

            if (changingMaskId == -1)
            {
                maskManager.AddMask(newMask);
                (Owner as SettingsForm).VisualizeNewMask();
            }
            else
            {
                maskManager.UpdateMask(changingMaskId, newMask);
                (Owner as SettingsForm).VisualizeMask(changingMaskId);
            }

            Close();
        }

        private void FillFormWithData()
        {
            textBoxMask.Text = maskManager.Masks[changingMaskId].BruteMask;
            textBoxDescription.Text = maskManager.Masks[changingMaskId].Description;
            textBoxCharset1.Text = maskManager.Masks[changingMaskId].Charset1;
            textBoxCharset2.Text = maskManager.Masks[changingMaskId].Charset2;
            textBoxCharset3.Text = maskManager.Masks[changingMaskId].Charset3;
            textBoxCharset4.Text = maskManager.Masks[changingMaskId].Charset4;
            checkBoxCharset1.Checked = maskManager.Masks[changingMaskId].UseCharset1;
            checkBoxCharset2.Checked = maskManager.Masks[changingMaskId].UseCharset2;
            checkBoxCharset3.Checked = maskManager.Masks[changingMaskId].UseCharset3;
            checkBoxCharset4.Checked = maskManager.Masks[changingMaskId].UseCharset4;
        }
    }
}
