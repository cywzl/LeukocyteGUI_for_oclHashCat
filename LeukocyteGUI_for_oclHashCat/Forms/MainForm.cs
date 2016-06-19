using LeukocyteCore_for_oclHashcat.Classes;
using LeukocyteGUI_for_oclHashcat.Classes;
using System;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashcat.Forms
{
    public partial class MainForm : Form
    {
        private Cracker cracker;

        public MainForm()
        {
            InitializeComponent();

            DataManager.DataLoaded += DataManager_DataLoaded;

            DataManager.CrackTasks.CrackTaskAdded += CrackTasksList_CrackTaskAdded;
            DataManager.CrackTasks.CrackTaskChanged += CrackTasksList_CrackTaskChanged;
            DataManager.CrackTasks.CrackTaskMoved += CrackTasksList_CrackTaskMoved;
            DataManager.CrackTasks.CrackTaskRemoved += CrackTasksList_CrackTaskRemoved;
            DataManager.CrackTasks.CrackTasksCleared += CrackTasksList_CrackTasksCleared;

            cracker = new Cracker(
                @"E:\Program Files (x86)\oclHashcat\oclHashcat64.exe"
            );
            cracker.ProgressChanged += Cracker_ProgressChanged;
            cracker.CrackTasks = DataManager.CrackTasks;
        }

        private void VisualizeCrackTask(CrackTask crackTask, int listViewItemId)
        {
            lvCrackTasks.Items[listViewItemId] = crackTask.ToListViewItem(listViewItemId);
        }
        private void VisualizeCrackTask(CrackTask crackTask)
        {
            lvCrackTasks.Items.Add(crackTask.ToListViewItem(lvCrackTasks.Items.Count));
        }
        private void Revisualize(int listViewItemId)
        {
            lvCrackTasks.Items[listViewItemId] = ((CrackTask)lvCrackTasks.Items[listViewItemId].Tag).ToListViewItem(listViewItemId);
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            using (var taskEditor = new TaskEditorForm())
            {
                if (taskEditor.ShowDialog() == DialogResult.OK)
                {
                    foreach (var crackTask in taskEditor.CrackTasks)
                    {
                        DataManager.CrackTasks.Add(crackTask);
                    }
                }
            }
        }
        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (lvCrackTasks.SelectedIndices.Count > 0)
            {
                // We need to track how many items have been removed before current,
                // beacause every removal causes shift of the following items
                // (and changes their indexes)
                int shift = 0;

                foreach (int index in lvCrackTasks.SelectedIndices)
                {
                    DataManager.CrackTasks.RemoveAt(index - shift);
                    shift++;
                }
            }
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }
        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (lvCrackTasks.SelectedItems.Count == 1)
            {
                new TaskEditorForm((CrackTask)lvCrackTasks.SelectedItems[0].Tag).ShowDialog();
                Revisualize(lvCrackTasks.SelectedIndices[0]);
            }
        }
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (lvCrackTasks.SelectedIndices.Count == 1)
            {
                int indexUpper = lvCrackTasks.SelectedIndices[0] - 1;
                int indexLower = lvCrackTasks.SelectedIndices[0];

                if (DataManager.CrackTasks.TrySwapTasks(indexUpper, indexLower))
                {
                    lvCrackTasks.Items[indexUpper].Selected = true;
                    lvCrackTasks.Items[indexUpper].Focused = true;
                }
            }

            lvCrackTasks.Select();
        }
        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (lvCrackTasks.SelectedIndices.Count == 1)
            {
                int indexUpper = lvCrackTasks.SelectedIndices[0];
                int indexLower = lvCrackTasks.SelectedIndices[0] + 1;

                if (DataManager.CrackTasks.TrySwapTasks(indexUpper, indexLower))
                {
                    lvCrackTasks.Items[indexLower].Selected = true;
                    lvCrackTasks.Items[indexLower].Focused = true;
                }
            }

            lvCrackTasks.Select();
        }
        private void btnCrack_Click(object sender, EventArgs e)
        {
            if (lvCrackTasks.SelectedIndices.Count > 0)
            {
                cracker.Crack(lvCrackTasks.SelectedIndices[0]);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataManager.SaveAllData();
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            DataManager.LoadAllAvailableData();
        }

        private void DataManager_DataLoaded(DataLoadedSavedEventArgs e)
        {
            if (e.DataType == DataTypes.CrackTasks)
            {
                lvCrackTasks.Items.Clear();

                for (int i = 0; i < DataManager.CrackTasks.Count; i++)
                {
                    VisualizeCrackTask(DataManager.CrackTasks[i]);
                }
            }
        }

        private void CrackTasksList_CrackTasksCleared(object sender, EventArgs e)
        {
            lvCrackTasks.Items.Clear();
        }
        private void CrackTasksList_CrackTaskRemoved(object sender, CrackTasksListTaskChangedEventArgs e)
        {
            lvCrackTasks.Items.RemoveAt(e.CrackTaskId);
        }
        private void CrackTasksList_CrackTaskMoved(object sender, CrackTasksListTaskMovedEventArgs e)
        {
            VisualizeCrackTask(e.CrackTask, e.CrackTaskNewId);
        }
        private void CrackTasksList_CrackTaskChanged(object sender, CrackTasksListTaskChangedEventArgs e)
        {
            VisualizeCrackTask(e.CrackTask, e.CrackTaskId);
        }
        private void CrackTasksList_CrackTaskAdded(object sender, CrackTasksListTaskChangedEventArgs e)
        {
            lvCrackTasks.Items.Add("");
            VisualizeCrackTask(e.CrackTask, e.CrackTaskId);
        }

        private void Cracker_ProgressChanged(object sender, CrackerEventArgs e)
        {
            Revisualize(e.CrackTaskId);
        }
    }
}
