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
    public partial class TaskEditorForm : Form
    {
        public TaskEditorForm()
        {
            InitializeComponent();
        }

        private void rbAttackType_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "rbStraight":
                        gbIncrementMode.Enabled = false;
                        gbCharsets.Enabled = false;
                        lblRightSource.Enabled = false;
                        cmbRightSource.Enabled = false;
                        lblLeftSource.Text = "Dictionary:";

                        break;

                    case "rbCombination":
                        gbIncrementMode.Enabled = false;
                        gbCharsets.Enabled = false;
                        lblRightSource.Enabled = true;
                        cmbRightSource.Enabled = true;
                        lblLeftSource.Text = "Left Dictionary:";
                        lblRightSource.Text = "Right Dictionary:";

                        break;

                    case "rbBruteforce":
                        gbIncrementMode.Enabled = true;
                        gbCharsets.Enabled = true;
                        lblRightSource.Enabled = false;
                        cmbRightSource.Enabled = false;
                        lblLeftSource.Text = "Mask:";

                        break;

                    case "rbDictMask":
                        gbIncrementMode.Enabled = true;
                        gbCharsets.Enabled = true;
                        lblRightSource.Enabled = true;
                        cmbRightSource.Enabled = true;
                        lblLeftSource.Text = "Left Dictionary:";
                        lblRightSource.Text = "Right Mask:";

                        break;

                    case "rbMaskDict":
                        gbIncrementMode.Enabled = true;
                        gbCharsets.Enabled = true;
                        lblRightSource.Enabled = true;
                        cmbRightSource.Enabled = true;
                        lblLeftSource.Text = "Left Mask:";
                        lblRightSource.Text = "Right Dictionary:";

                        break;
                }
            }
        }
    }
}
