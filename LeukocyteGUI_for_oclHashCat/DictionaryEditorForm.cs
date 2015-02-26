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
    public partial class DictionaryEditorForm : Form
    {
        private DictionaryManager dictionaryManager;
        private int changingDictId;

        public DictionaryEditorForm(DictionaryManager dictionaryManager,
            int changingDictId = -1)
        {
            InitializeComponent();
            this.dictionaryManager = dictionaryManager;
            this.changingDictId = changingDictId;

            if (changingDictId > -1)
            {
                FillFormWithData();
            }
        }

        private void buttonChooseDictionary_Click(object sender, EventArgs e)
        {
            openFileDialogDictionary.ShowDialog();
        }
        private void buttonSettingsOK_Click(object sender, EventArgs e)
        {
            DictionaryManager.Dictionary newDict = new DictionaryManager.Dictionary(
                textBoxDictionary.Text);
            newDict.Description = textBoxDescription.Text;

            if (changingDictId == -1)
            {
                dictionaryManager.AddDictionary(newDict);
                (Owner as SettingsForm).VisualizeNewDictionary();
            }
            else
            {
                dictionaryManager.UpdateDictionary(changingDictId, newDict);
                (Owner as SettingsForm).VisualizeDictionary(changingDictId);
            }

            Close();
        }
        private void openFileDialogDictionary_FileOk(object sender, CancelEventArgs e)
        {
            textBoxDictionary.Text = openFileDialogDictionary.FileName;
        }

        private void FillFormWithData()
        {
            textBoxDictionary.Text = dictionaryManager.Dictionaries[changingDictId].FileName;
            textBoxDescription.Text = dictionaryManager.Dictionaries[changingDictId].Description;
        }
    }
}
