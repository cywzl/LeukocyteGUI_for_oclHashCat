using System;
using LeukocyteCore_for_oclHashcat.Classes;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashcat.Forms
{
    public partial class HashTypeEditorForm : Form
    {
        HashType hashType;

        public HashType HashType
        {
            get
            {
                return hashType;
            }
        }

        public HashTypeEditorForm()
        {
            InitializeComponent();
            hashType = new HashType("", 0);
        }
        public HashTypeEditorForm(HashType hashType)
        {
            InitializeComponent();

            this.hashType = hashType;

            tbName.Text = hashType.Name;
            tbDescription.Text = hashType.Description;
            nudCode.Value = hashType.Code;
        }

        private void UpdateHashType()
        {
            hashType.Name = tbName.Text;
            hashType.Description = tbDescription.Text;
            hashType.Code = (int)nudCode.Value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UpdateHashType();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
