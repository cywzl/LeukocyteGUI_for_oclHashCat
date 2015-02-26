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
    public partial class SettingsForm : Form
    {
        MainForm mainForm;
        DictionaryManager dictionaryManager;
        MaskManager maskManager;

        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            dictionaryManager = mainForm.DictionaryManager;
            maskManager = mainForm.MaskManager;

            VisualizeAllDictionaries();
            VisualizeAllMasks();
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            textBoxHashcat.Text = Properties.Settings.Default.Hashcat;
            textBoxWorkingDirectory.Text = Properties.Settings.Default.WorkingDirectory;
            checkBoxSaveOnExit.Checked = Properties.Settings.Default.SaveBeforeExit;
            checkBoxLoadOnStart.Checked = Properties.Settings.Default.LoadOnStartup;
            checkBoxDeleteSameWhenCracked.Checked = Properties.Settings.Default.DeleteRelatedTasksWhenCracked;
            checkBoxMinimizeToTray.Checked = Properties.Settings.Default.MinimizeToTray;
        }

        private void buttonSettingsOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Hashcat = textBoxHashcat.Text;
            Properties.Settings.Default.WorkingDirectory = textBoxWorkingDirectory.Text;
            Properties.Settings.Default.SaveBeforeExit = checkBoxSaveOnExit.Checked;
            Properties.Settings.Default.LoadOnStartup = checkBoxLoadOnStart.Checked;
            Properties.Settings.Default.DeleteRelatedTasksWhenCracked = checkBoxDeleteSameWhenCracked.Checked;
            Properties.Settings.Default.MinimizeToTray = checkBoxMinimizeToTray.Checked;
            Properties.Settings.Default.Save();

            Close();
        }
        private void buttonChooseHashCat_Click(object sender, EventArgs e)
        {
            openFileDialogHashCat.ShowDialog();
        }
        private void buttonChooseWorkingDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogWorkingDirectory.ShowDialog() == DialogResult.OK)
            {
                textBoxWorkingDirectory.Text = folderBrowserDialogWorkingDirectory.SelectedPath + "\\";
            }
        }

        private void buttonAddDictionary_Click(object sender, EventArgs e)
        {
            (new DictionaryEditorForm(dictionaryManager)).ShowDialog(this);

            if (listViewDictionaries.Items.Count > 0)
            {
                SelectDictionaryItem(listViewDictionaries.Items.Count - 1);
            }
            
            CheckDictionaryButtons();
        }
        private void buttonDeleteDictionary_Click(object sender, EventArgs e)
        {
            dictionaryManager.DeleteDictionary(listViewDictionaries.SelectedIndices[0]);
            VisualizeAllDictionaries();
            CheckDictionaryButtons();
        }
        private void buttonChangeDictionary_Click(object sender, EventArgs e)
        {
            int index = listViewDictionaries.SelectedIndices[0];

            (new DictionaryEditorForm(dictionaryManager, index)).ShowDialog(this);
            SelectDictionaryItem(index);
        }
        private void buttonClearDictionary_Click(object sender, EventArgs e)
        {
            listViewDictionaries.Items.Clear();
            CheckDictionaryButtons();
        }
        private void buttonUpDictionary_Click(object sender, EventArgs e)
        {
            int index1 = listViewDictionaries.SelectedIndices[0];
            int index2 = dictionaryManager.DictionaryMoveToStart(index1);

            VisualizeDictionary(index1);
            VisualizeDictionary(index2);

            SelectDictionaryItem(index2);
        }
        private void buttonDownDictionary_Click(object sender, EventArgs e)
        {
            int index1 = listViewDictionaries.SelectedIndices[0];
            int index2 = dictionaryManager.DictionaryMoveToEnd(index1);

            VisualizeDictionary(index1);
            VisualizeDictionary(index2);

            SelectDictionaryItem(index2);
        }

        private void buttonAddMask_Click(object sender, EventArgs e)
        {
            (new MaskEditorForm(maskManager)).ShowDialog(this);

            if (listViewMasks.Items.Count > 0)
            {
                SelectMaskItem(listViewMasks.Items.Count - 1);
            }

            CheckMaskButtons();
        }
        private void buttonDeleteMask_Click(object sender, EventArgs e)
        {
            maskManager.DeleteMask(listViewMasks.SelectedIndices[0]);
            VisualizeAllMasks();
            CheckMaskButtons();
        }
        private void buttonChangeMask_Click(object sender, EventArgs e)
        {
            int index = listViewMasks.SelectedIndices[0];

            (new MaskEditorForm(maskManager, index)).ShowDialog(this);
            SelectMaskItem(index);
        }
        private void buttonClearMask_Click(object sender, EventArgs e)
        {
            listViewMasks.Items.Clear();
            CheckMaskButtons();
        }
        private void buttonUpMask_Click(object sender, EventArgs e)
        {
            int index1 = listViewMasks.SelectedIndices[0];
            int index2 = maskManager.MaskMoveToStart(index1);

            VisualizeMask(index1);
            VisualizeMask(index2);

            SelectMaskItem(index2);
        }
        private void buttonDownMask_Click(object sender, EventArgs e)
        {
            int index1 = listViewMasks.SelectedIndices[0];
            int index2 = maskManager.MaskMoveToEnd(index1);

            VisualizeMask(index1);
            VisualizeMask(index2);

            SelectMaskItem(index2);
        }

        private void textBoxHashcat_TextChanged(object sender, EventArgs e)
        {
            TryAutoDetectWorkingDirectory();
        }
        private void listViewDictionaries_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckDictionaryButtons();
        }
        private void listViewMasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckMaskButtons();
        }
        private void checkBoxAutoWorkingDirectory_CheckedChanged(object sender, EventArgs e)
        {
            TryAutoDetectWorkingDirectory();
        }
        private void openFileDialogHashCat_FileOk(object sender, CancelEventArgs e)
        {
            textBoxHashcat.Text = openFileDialogHashCat.FileName;
        }

        private void TryAutoDetectWorkingDirectory()
        {
            if (checkBoxAutoWorkingDirectory.Checked)
            {
                try
                {
                    textBoxWorkingDirectory.Text = System.IO.Path.GetDirectoryName(textBoxHashcat.Text);
                }
                catch (Exception)
                {
                    textBoxWorkingDirectory.Text = "";
                }
            }

            textBoxWorkingDirectory.Enabled = !checkBoxAutoWorkingDirectory.Checked;
            buttonChooseWorkingDirectory.Enabled = !checkBoxAutoWorkingDirectory.Checked;
        }

        public void VisualizeDictionary(int DictionaryId)
        {
            if ((DictionaryId > -1)
                && (DictionaryId < listViewDictionaries.Items.Count)
                && (DictionaryId < dictionaryManager.Dictionaries.Length))
            {
                string[] values = new string[listViewDictionaries.Columns.Count];

                values[0] = (DictionaryId + 1).ToString();
                values[1] = dictionaryManager.Dictionaries[DictionaryId].Description;
                values[2] = dictionaryManager.Dictionaries[DictionaryId].FormattedSize;
                values[3] = dictionaryManager.Dictionaries[DictionaryId].FileName;

                listViewDictionaries.Items[DictionaryId] = new ListViewItem(values);
            }
        }
        public void VisualizeNewDictionary()
        {
            listViewDictionaries.Items.Add("");
            VisualizeDictionary(listViewDictionaries.Items.Count - 1);
        }
        public void VisualizeAllDictionaries()
        {
            listViewDictionaries.Items.Clear();

            for (int index = 0; index < dictionaryManager.Dictionaries.Length; index++)
            {
                VisualizeNewDictionary();
            }
        }
        public void CheckDictionaryButtons()
        {
            if (listViewDictionaries.SelectedIndices.Count == 0)
            {
                buttonDeleteDictionary.Enabled = false;
                buttonChangeDictionary.Enabled = false;
                buttonUpDictionary.Enabled = false;
                buttonDownDictionary.Enabled = false;
            }
            else
            {
                int index = listViewDictionaries.SelectedIndices[0];

                buttonDeleteDictionary.Enabled = true;
                buttonChangeDictionary.Enabled = true;

                if (index > 0)
                {
                    buttonUpDictionary.Enabled = true;
                }
                else
                {
                    buttonUpDictionary.Enabled = false;
                }

                if (index < listViewDictionaries.Items.Count - 1)
                {
                    buttonDownDictionary.Enabled = true;
                }
                else
                {
                    buttonDownDictionary.Enabled = false;
                }
            }

            if (listViewDictionaries.Items.Count > 0)
            {
                buttonClearDictionary.Enabled = true;
            }
            else
            {
                buttonClearDictionary.Enabled = false;
            }
        }
        public void SelectDictionaryItem(int Index)
        {
            listViewDictionaries.Items[Index].Selected = true;
            listViewDictionaries.Items[Index].Focused = true;
            listViewDictionaries.Focus();
        }

        public void VisualizeMask(int MaskId)
        {
            if ((MaskId > -1)
                && (MaskId < listViewMasks.Items.Count)
                && (MaskId < maskManager.Masks.Length))
            {
                string[] values = new string[listViewMasks.Columns.Count];

                values[0] = (MaskId + 1).ToString();
                values[1] = maskManager.Masks[MaskId].Description;
                values[2] = maskManager.Masks[MaskId].BruteMask;
                values[3] = maskManager.Masks[MaskId].CharsetString;

                listViewMasks.Items[MaskId] = new ListViewItem(values);
            }
        }
        public void VisualizeNewMask()
        {
            listViewMasks.Items.Add("");
            VisualizeMask(listViewMasks.Items.Count - 1);
        }
        public void VisualizeAllMasks()
        {
            listViewMasks.Items.Clear();

            for (int index = 0; index < maskManager.Masks.Length; index++)
            {
                VisualizeNewMask();
            }
        }
        public void CheckMaskButtons()
        {
            if (listViewMasks.SelectedIndices.Count == 0)
            {
                buttonDeleteMask.Enabled = false;
                buttonChangeMask.Enabled = false;
                buttonUpMask.Enabled = false;
                buttonDownMask.Enabled = false;
            }
            else
            {
                int index = listViewMasks.SelectedIndices[0];

                buttonDeleteMask.Enabled = true;
                buttonChangeMask.Enabled = true;

                if (index > 0)
                {
                    buttonUpMask.Enabled = true;
                }
                else
                {
                    buttonUpMask.Enabled = false;
                }

                if (index < listViewMasks.Items.Count - 1)
                {
                    buttonDownMask.Enabled = true;
                }
                else
                {
                    buttonDownMask.Enabled = false;
                }
            }

            if (listViewMasks.Items.Count > 0)
            {
                buttonClearMask.Enabled = true;
            }
            else
            {
                buttonClearMask.Enabled = false;
            }
        }
        public void SelectMaskItem(int Index)
        {
            listViewMasks.Items[Index].Selected = true;
            listViewMasks.Items[Index].Focused = true;
            listViewMasks.Focus();
        }
    }
}
