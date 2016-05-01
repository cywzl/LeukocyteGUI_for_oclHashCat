using LeukocyteCore_for_oclHashcat;
using LeukocyteCore_for_oclHashcat.Interfaces;
using System;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashcat.Forms
{
    public partial class CrackDataSourceEditorForm : Form
    {
        bool editMode = false;
        DataTypes sourceType = DataTypes.Masks;
        ICrackDataSource source;

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
        public CrackDataSourceEditorForm(ICrackDataSource source) : this()
        {
            editMode = true;

            gbCrackDataSourceType.Enabled = false;

            tbName.Text = source.Name;
            tbDescription.Text = source.Description;
            tbSource.Text = source.Source;

            switch (source.GetType().ToString().Split('.')[1])
            {
                case "Dictionary":
                    rbDictionary.Checked = true;
                    break;

                case "Mask":
                    rbMask.Checked = true;

                    Mask mask = (Mask)source;
                    cbIncrementMode.Checked = mask.IncrementSettings.Increment;
                    nudIncrementMin.Value = mask.IncrementSettings.IncrementMin;
                    nudIncrementMax.Value = mask.IncrementSettings.IncrementMax;
                    cbCharset1.Checked = mask.CharsetsSettings.UseCharset1;
                    cbCharset2.Checked = mask.CharsetsSettings.UseCharset2;
                    cbCharset3.Checked = mask.CharsetsSettings.UseCharset3;
                    cbCharset4.Checked = mask.CharsetsSettings.UseCharset4;
                    cmbCharset1.Text = mask.CharsetsSettings.Charset1;
                    cmbCharset2.Text = mask.CharsetsSettings.Charset2;
                    cmbCharset3.Text = mask.CharsetsSettings.Charset3;
                    cmbCharset4.Text = mask.CharsetsSettings.Charset4;

                    break;
            }

            this.source = source;
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

                if (editMode)
                {
                    mask = (Mask)source;
                }
                else
                {
                    if (tbSource.Text.EndsWith(".hcmask"))
                    {
                        mask = Mask.CreateFromHcmask(tbSource.Text, tbName.Text);
                    }
                    else
                    {
                        mask = Mask.CreateFromString(tbSource.Text, tbName.Text);
                    }
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
                if (editMode)
                {
                    source.Name = tbName.Text;
                    source.Source = tbSource.Text;
                }
                else
                {
                    source = new Dictionary(tbSource.Text, tbName.Text);
                }

                sourceType = DataTypes.Dictionaries;
            }

            source.Description = tbDescription.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
