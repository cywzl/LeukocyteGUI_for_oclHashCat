using LeukocyteCore_for_oclHashcat;
using LeukocyteCore_for_oclHashcat.Classes;
using System;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashcat.Forms
{
    public partial class MainForm : Form
    {
        CrackTasksList crackTasksList = new CrackTasksList();

        public MainForm()
        {
            InitializeComponent();

            DataManager.DataLoaded += DataManager_DataLoaded;

            crackTasksList.CrackTaskAdded += CrackTasksList_CrackTaskAdded;
            crackTasksList.CrackTaskChanged += CrackTasksList_CrackTaskChanged;
            crackTasksList.CrackTaskMoved += CrackTasksList_CrackTaskMoved;
            crackTasksList.CrackTaskRemoved += CrackTasksList_CrackTaskRemoved;
            crackTasksList.CrackTasksCleared += CrackTasksList_CrackTasksCleared;
        }

        private void VisualizeCrackTask(CrackTask crackTask, int listViewItemId)
        {
            string[] values = new string[]
            {
                /* #         */ (listViewItemId + 1).ToString(),
                /* HashType  */ crackTask.HashType.Name,
                /* Target    */ crackTask.CrackTarget,
                /* Plain     */ crackTask.Plain,
                /* Length    */ crackTask.CurrentLength.ToString(),
                /* Progress  */ crackTask.Progress.ToString(),
                /* Estimated */ crackTask.TimeEstimated,
                /* Mask/Dict */ crackTask.CrackDataSourceLeft +
                                    (!string.IsNullOrEmpty(crackTask.CrackDataSourceRight)
                                        ? " + " + crackTask.CrackDataSourceRight : ""),
                /* Started   */ crackTask.Started.ToString(),
                /* Finished  */ crackTask.Finished.ToString(),
                /* Session   */ crackTask.SessionSettings.Session
            };

            lvCrackTasks.Items[listViewItemId] = new ListViewItem(values);
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            new TaskEditorForm().ShowDialog();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
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
                crackTasksList.Clear();

                foreach (var crackTask in DataManager.CrackTasks)
                {
                    crackTasksList.Add(crackTask);
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
