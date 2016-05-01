using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashCat.Forms
{
    public partial class CrackDataSourceEditorForm : Form
    {
        DataTypes sourceType = DataTypes.Masks;
        ICrackDataSource source = Mask.CreateFromString("", "");

        public DataTypes SourceType
        {
            get
            {
                return sourceType;
            }
        }
        public ICrackDataSource Source
        {
            get
            {
                return source;
            }
        }

        public CrackDataSourceEditorForm()
        {
            InitializeComponent();
        }

        private void rbCrackSource_CheckedChanged(object sender, EventArgs e)
        {
            gbCharsets.Enabled = rbMask.Checked;
            gbIncrementMode.Enabled = rbMask.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbMask.Checked)
            {
                Mask mask;

                if (tbSource.Text.EndsWith(".hcmask"))
                {
                    mask = Mask.CreateFromHcmask(tbSource.Text, tbName.Text);
                }
                else
                {
                    mask = Mask.CreateFromString(tbSource.Text, tbName.Text);
                }

                mask.CharsetsSettings = new CustomCharsetsSettings()
                {
                    Charset1 = cmbCharset1.Text,
                    Charset2 = cmbCharset2.Text,
                    Charset3 = cmbCharset3.Text,
                    Charset4 = cmbCharset4.Text,
                    UseCharset1 = cbCharset1.Checked,
                    UseCharset2 = cbCharset2.Checked,
                    UseCharset3 = cbCharset3.Checked,
                    UseCharset4 = cbCharset4.Checked,
                };
                mask.IncrementSettings = new IncrementSettings()
                {
                    Increment = cbIncrementMode.Checked,
                    IncrementMin = (int)nudIncrementMin.Value,
                    IncrementMax = (int)nudIncrementMax.Value
                };

                source = mask;
                sourceType = DataTypes.Masks;
            }
            else
            {
                source = new Dictionary(tbSource.Text, tbName.Text);
                sourceType = DataTypes.Dictionaries;
            }

            source.Description = tbDescription.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
