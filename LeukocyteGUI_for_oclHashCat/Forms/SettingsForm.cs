using LeukocyteCore_for_oclHashcat.Classes;
using LeukocyteCore_for_oclHashcat.Interfaces;
using LeukocyteGUI_for_oclHashcat.Classes;
using System;
using System.Linq;
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
            ListViewItem item = crackSource.ToListViewItem(listViewId + 1);

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

        private void VisualizeHashType(HashType hashType, int listViewId)
        {
            ListViewItem item = new ListViewItem(new string[]
                {
                    listViewId.ToString(),
                    hashType.Code.ToString(),
                    hashType.Name,
                    hashType.Description
                })
            {
                Tag = hashType
            };

            if (listViewId < lvHashTypes.Items.Count)
            {
                lvHashTypes.Items[listViewId] = item;
            }
            else
            {
                lvHashTypes.Items.Add(item);
            }
        }
        private void VisualizeHashType(HashType hashType)
        {
            VisualizeHashType(hashType, lvHashTypes.Items.Count);
        }
        private void VisualizeHashTypes(IEnumerable<HashType> hashTypesList)
        {
            foreach (var hashType in hashTypesList)
            {
                VisualizeHashType(hashType);
            }
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            VisualizeCrackSources(DataManager.CrackDataSources);
            VisualizeHashTypes(DataManager.HashTypes);
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
                        VisualizeCrackSource(editor.Source, selectedIndex);
                    }
                }
            }
        }

        private void btnAddHashType_Click(object sender, EventArgs e)
        {
            using (HashTypeEditorForm editor = new HashTypeEditorForm())
            {
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    DataManager.AddData(DataTypes.HashTypes, editor.HashType);
                    VisualizeHashType(editor.HashType);
                }
            }
        }
        private void btnEditHashType_Click(object sender, EventArgs e)
        {
            if (lvHashTypes.SelectedItems.Count > 0)
            {
                HashType selectedHashType = (HashType)lvHashTypes.SelectedItems[0].Tag;
                int selectedIndex = lvHashTypes.SelectedIndices[0];

                using (HashTypeEditorForm editor = new HashTypeEditorForm(selectedHashType))
                {
                    if (editor.ShowDialog() == DialogResult.OK)
                    {
                        VisualizeHashType(editor.HashType, selectedIndex);
                    }
                }
            }
        }
    }
}
