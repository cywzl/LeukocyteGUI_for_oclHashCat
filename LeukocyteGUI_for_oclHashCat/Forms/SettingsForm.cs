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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void VisualizeCrackSource(ICrackDataSource crackSource, int listViewId)
        {
            ListViewItem item = new ListViewItem(new string[]
                {
                    listViewId.ToString(),
                    crackSource.GetType().ToString().Split('.')[1],
                    crackSource.Name,
                    crackSource.Description
                })
            {
                Tag = crackSource
            };

            if (listViewId < lvPredefined.Items.Count)
            {
                lvPredefined.Items[listViewId] = item;
            }
            else
            {
                lvPredefined.Items.Add(item);
            }
        }
        private void VisualizeCrackSource(ICrackDataSource crackSource)
        {
            VisualizeCrackSource(crackSource, lvPredefined.Items.Count);
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            foreach (var dictionary in DataManager.Dictionaries)
            {
                VisualizeCrackSource(dictionary);
            }
            foreach (var mask in DataManager.Masks)
            {
                VisualizeCrackSource(mask);
            }
        }

        private void btnAddPredefined_Click(object sender, EventArgs e)
        {
            using (CrackDataSourceEditorForm editor = new CrackDataSourceEditorForm())
            {
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    DataManager.AddData(editor.SourceType, editor.Source);
                    VisualizeCrackSource(editor.Source);
                }
            }
        }
        private void btnEditPredefined_Click(object sender, EventArgs e)
        {
            if (lvPredefined.SelectedItems.Count > 0)
            {
                ICrackDataSource selectedSource = (ICrackDataSource)lvPredefined.SelectedItems[0].Tag;
                int selectedIndex = lvPredefined.SelectedIndices[0];

                using (CrackDataSourceEditorForm editor = new CrackDataSourceEditorForm(selectedSource))
                {
                    if (editor.ShowDialog() == DialogResult.OK)
                    {
                        selectedSource = editor.Source;
                        VisualizeCrackSource(editor.Source, selectedIndex);
                    }
                }
            }
        }
    }
}
