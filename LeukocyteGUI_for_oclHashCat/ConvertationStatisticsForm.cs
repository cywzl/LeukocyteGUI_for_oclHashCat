//  Copyright (C) 2015  Igor Kotlerman

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
    public partial class ConvertationStatisticsForm : Form
    {
        private int count = 0;
        private int converted = 0;

        public int ConvertCount
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
                labelConvertingStatus.Text = "0 / " + value.ToString();
            }
        }
        public int Converted
        {
            get
            {
                return converted;
            }

            set
            {
                converted = value;
                labelConvertingStatus.Text = value.ToString() + " / "
                    + count.ToString();
            }
        }

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
            count = ConvertCount;
        }

        public void buttonConfirmSuccess_Click(object sender, EventArgs e)
        {
            Close();
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
        public void ConversionEnd()
        {
            buttonConfirmSuccess.Enabled = true;
        }
    }
}
