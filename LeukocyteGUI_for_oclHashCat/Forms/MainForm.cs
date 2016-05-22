using LeukocyteCore_for_oclHashcat.Classes;
using LeukocyteGUI_for_oclHashcat.Classes;
using System;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashcat.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DataManager.DataLoaded += DataManager_DataLoaded;

            DataManager.CrackTasks.CrackTaskAdded += CrackTasksList_CrackTaskAdded;
            DataManager.CrackTasks.CrackTaskChanged += CrackTasksList_CrackTaskChanged;
            DataManager.CrackTasks.CrackTaskMoved += CrackTasksList_CrackTaskMoved;
            DataManager.CrackTasks.CrackTaskRemoved += CrackTasksList_CrackTaskRemoved;
            DataManager.CrackTasks.CrackTasksCleared += CrackTasksList_CrackTasksCleared;
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
    }
}
