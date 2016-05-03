using LeukocyteCore_for_oclHashcat.Classes;
using LeukocyteCore_for_oclHashcat.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashcat.Forms
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
        private void VisualizeCrackSources(IEnumerable<ICrackDataSource> sourcesList)
        {
            foreach (var source in sourcesList)
            {
                VisualizeCrackSource(source);
            }
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            VisualizeCrackSources(DataManager.CrackDataSources);
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
