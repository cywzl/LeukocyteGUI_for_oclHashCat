//  Copyright (C) 2015  Igor Kotlerman <igor.kotlerman@gmail.com>

//  This file is part of LeukocyteGUI_for_oclHashCat.

//  LeukocyteGUI_for_oclHashCat is free software: you can
//  redistribute it and/or modify it under the terms of the
//  GNU General Public License as published by the
//  Free Software Foundation, either version 3
//  of the License, or (at your option) any later version.

//  LeukocyteGUI_for_oclHashCat is distributed in the hope
//  that it will be useful, but WITHOUT ANY WARRANTY;
//  without even the implied warranty of MERCHANTABILITY or
//  FITNESS FOR A PARTICULAR PURPOSE.  
//  See the GNU General Public License for more details.

//  You should have received a copy of the
//  GNU General Public License along with
//  LeukocyteGUI_for_oclHashCat. 
//  If not, see <http://www.gnu.org/licenses/>.

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
            newMask.EnableIncrement = checkBoxEnableIncrement.Checked;
            newMask.IncrementMin = (byte)numericUpDownIncrementMin.Value;
            newMask.IncrementMax = (byte)numericUpDownIncrementMax.Value;

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
            checkBoxEnableIncrement.Checked = maskManager.Masks[changingMaskId].EnableIncrement;
            numericUpDownIncrementMin.Value = maskManager.Masks[changingMaskId].IncrementMin;
            numericUpDownIncrementMax.Value = maskManager.Masks[changingMaskId].IncrementMax;
        }
    }
}
