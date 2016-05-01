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
            switch ((sender as RadioButton).Name)
            {
                case "rbDictionary":
                    if (tcEditor.SelectedIndex != 0)
                    {
                        tcEditor.SelectedIndex = 0;
                    }
                    break;
                case "rbMask":
                    if (tcEditor.SelectedIndex != 1)
                    {
                        tcEditor.SelectedIndex = 1;
                    }
                    break;
            }
        }

        private void tcEditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcEditor.SelectedIndex)
            {
                case 0:
                    if (!rbDictionary.Checked)
                    {
                        rbDictionary.Checked = true;
                    }
                    break;
                case 1:
                    if (!rbMask.Checked)
                    {
                        rbMask.Checked = true;
                    }
                    break;
            }
        }
    }
}
