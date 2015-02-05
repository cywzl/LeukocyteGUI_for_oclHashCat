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
    public partial class ConvertationStatisticsForm : Form
    {
        int cCount = 0, cConverted = 0;

        public ConvertationStatisticsForm()
        {
            InitializeComponent();
            listViewConvertSuccess.ShowItemToolTips = true;
            typeof(Control).InvokeMember(
                "DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty
                | System.Reflection.BindingFlags.Instance
                | System.Reflection.BindingFlags.NonPublic,
                null,
                listViewConvertSuccess,
                new object[] { true }
            );
        }

        public ConvertationStatisticsForm(int ConvertCount)
            : this()
        {
            cCount = ConvertCount;
        }

        public int ConvertCount
        {
            get
            {
                return cCount;
            }

            set
            {
                cCount = value;
                labelConvertingStatus.Text = "0 / " + value.ToString();
            }
        }

        public int Converted
        {
            get
            {
                return cConverted;
            }

            set
            {
                cConverted = value;
                labelConvertingStatus.Text = value.ToString() + " / "
                    + cCount.ToString();
            }
        }

        public void listViewConvertSuccessChange(int Index, bool Success)
        {
            listViewConvertSuccess.Items[Index].Font = new Font(listViewConvertSuccess.Font,
                FontStyle.Regular);

            if (Success)
            {
                listViewConvertSuccess.Items[Index].ImageIndex = 1;
            }
            else
            {
                listViewConvertSuccess.Items[Index].ImageIndex = 0;
            }

            if (Index + 1 < listViewConvertSuccess.Items.Count)
            {
                listViewConvertSuccess.Items[Index + 1].Font = new Font(listViewConvertSuccess.Font,
                    FontStyle.Bold);
                listViewConvertSuccess.Items[Index + 1].EnsureVisible();
            }
        }

        public void listViewConvertSuccessAddItems(string[] Items)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                listViewConvertSuccess.Items.Add(Items[i], -1);
            }

            if (listViewConvertSuccess.Items.Count > 0)
            {
                listViewConvertSuccess.Items[0].Font = new Font(listViewConvertSuccess.Font,
                FontStyle.Bold);
            }
        }

        public void listViewConvertSuccessAddItems(ListBox.ObjectCollection ListBoxItems)
        {
            string[] Items = new string[ListBoxItems.Count];

            for (int i = 0; i < Items.Length; i++)
            {
                Items[i] = (string)ListBoxItems[i];
            }

            listViewConvertSuccessAddItems(Items);
        }

        private void buttonConfirmSuccess_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ConversionEnd()
        {
            buttonConfirmSuccess.Enabled = true;
        }
    }
}
