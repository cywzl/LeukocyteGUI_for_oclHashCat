using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LeukocyteGUI_for_oclHashCat
{
    public partial class MainForm : Form
    {
        const string crackTasksFile = "CrackTasks.bin";

        CrackTaskManager tskManager;
        public string DateTimeFormat;

        public MainForm()
        {
            InitializeComponent();

            DateTimeFormat = "dd-MM-yyyy HH:mm:ss";

            if (File.Exists(crackTasksFile))
            {
                Stream deserializerStream = File.OpenRead(crackTasksFile);
                BinaryFormatter deserializer = new BinaryFormatter();
                CrackTaskManager.CrackTask[] crackTasks
                    = (CrackTaskManager.CrackTask[]) deserializer.Deserialize(deserializerStream);
                deserializerStream.Close();
                tskManager = new CrackTaskManager(crackTasks);
            }
            else
            {
                tskManager = new CrackTaskManager();
            }

            tskManager.Cracker.SynchronizingObject = this;
            tskManager.TaskAdded += tskManager_TaskAdded;
            tskManager.TaskDeleted += tskManager_TaskDeleted;
            tskManager.TaskMovedToEnd += tskManager_TaskMovedToEnd;
            tskManager.TaskMovedToStart += tskManager_TaskMovedToStart;
            tskManager.TaskUpdated += tskManager_TaskUpdated;
            tskManager.TasksAllDeleted += tskManager_TasksAllDeleted;

            tskManager.Cracker.BeforeStart += Cracker_BeforeStart;
            tskManager.Cracker.OnStart += Cracker_OnStart;
            tskManager.Cracker.OnCracking += Cracker_OnCracking;
            tskManager.Cracker.OnStop += Cracker_OnStop;

            typeof(Control).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty
                | System.Reflection.BindingFlags.Instance
                | System.Reflection.BindingFlags.NonPublic,
                null, listViewTasks, new object[] { true });

            VisualizeTasks();
            CheckButtons();
        }

        private void Cracker_BeforeStart(object sender, int TaskId)
        {
            string logFile = Properties.Settings.Default.WorkingDirectory + "\\"
                + tskManager.CrackTasks[TaskId].SessionId + ".log";
            string potFile = Properties.Settings.Default.WorkingDirectory + "\\"
                + tskManager.CrackTasks[TaskId].SessionId + ".pot";

            if (File.Exists(logFile))
            {
                File.Delete(logFile);
            }

            if (File.Exists(potFile))
            {
                File.Delete(potFile);
            }
        }

        public CrackTaskManager MainCrackTaskManager
        {
            get
            {
                return tskManager;
            }

            set
            {
                tskManager = value;
            }
        }

        private void Cracker_OnStop(object sender, int TaskId)
        {
            labelGPUSpeed.Text = "0 H/s";
            labelGPUTemp.Text = "0 °C";
            labelGPUUtil.Text = "0 %";
            labelFanSpeed.Text = "0 %";

            if (TaskId != -1)
            {
                listViewTasks.Items[TaskId].BackColor = SystemColors.Window;
                listViewTasks.Items[TaskId].ForeColor = SystemColors.WindowText;
                listViewTasks.Items[TaskId].Checked = false;
                VisualizeTask(TaskId);
            }

            CheckButtons();

            if ((checkBoxAllChecked.Checked) && (!checkBoxPauseCracking.Checked))
            {
                for (int index = 0; index < listViewTasks.Items.Count; index++)
                {
                    if (listViewTasks.Items[index].Checked)
                    {
                        tskManager.Cracker.Crack(index);
                        break;
                    }
                }
            }
        }

        private void Cracker_OnCracking(object sender, int TaskId)
        {
            VisualizeTask(TaskId);

            labelGPUSpeed.Text = MainCrackTaskManager.Cracker.Speed;
            labelGPUTemp.Text = MainCrackTaskManager.Cracker.Temp.ToString() + " °C";
            labelGPUUtil.Text = MainCrackTaskManager.Cracker.Util.ToString() + " %";
            labelFanSpeed.Text = MainCrackTaskManager.Cracker.Fan.ToString() + " %";
        }

        private void Cracker_OnStart(object sender, int TaskId)
        {
            listViewTasks.Items[TaskId].BackColor = Color.FromArgb(100, 100, 100);
            listViewTasks.Items[TaskId].ForeColor = Color.White;

            CheckButtons();
            VisualizeTask(TaskId);
        }

        private void tskManager_TaskAdded(object sender, int TaskId)
        {
            VisualizeNewTask();
        }

        private void tskManager_TaskDeleted(object sender, int TaskId)
        {
            VisualizeTasks();
            CheckButtons();
        }

        private void tskManager_TaskMovedToEnd(object sender, int OriginalId, int NewId)
        {
            VisualizeTask(OriginalId);
            VisualizeTask(NewId);
        }

        private void tskManager_TaskMovedToStart(object sender, int OriginalId, int NewId)
        {
            VisualizeTask(OriginalId);
            VisualizeTask(NewId);
        }

        private void tskManager_TaskUpdated(object sender, int TaskId)
        {
            VisualizeTask(TaskId);
        }

        private void tskManager_TasksAllDeleted(object sender)
        {
            VisualizeTasks();
            CheckButtons();
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            TaskEditorForm TaskEditor = new TaskEditorForm();
            TaskEditor.Owner = this;

            if (TaskEditor.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                listViewTasks.Items[listViewTasks.Items.Count - 1].Selected = true;
            }

            listViewTasks.Focus();
            CheckButtons();
        }

        private void buttonOpenConverter_Click(object sender, EventArgs e)
        {
            ConverterForm Converter = new ConverterForm();
            Converter.ShowDialog(this);
        }

        private void buttonChangeTask_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedIndices.Count > 0)
            {
                int index = listViewTasks.SelectedIndices[0];
                TaskEditorForm TaskEditor = new TaskEditorForm(listViewTasks.SelectedIndices[0]);
                TaskEditor.Owner = this;
                TaskEditor.ShowDialog(this);
                listViewTasks.Focus();
                listViewTasks.Items[index].Focused = true;
                listViewTasks.Items[index].Selected = true;
            }
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedIndices.Count > 0)
            {
                int index = listViewTasks.SelectedIndices[0];

                MainCrackTaskManager.DeleteTask(index);
                VisualizeTasks();

                if (index > 0)
                {
                    listViewTasks.Items[index - 1].Focused = true;
                    listViewTasks.Items[index - 1].Selected = true;
                }
                else if (listViewTasks.Items.Count > 0)
                {
                    listViewTasks.Items[index].Focused = true;
                    listViewTasks.Items[index].Selected = true;
                }
            }

            CheckButtons();
        }

        private void buttonClearTask_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All tasks will be deleted. Are you sure?", "Warning",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                MainCrackTaskManager.DeleteAllTasks();
                VisualizeTasks();
            }

            CheckButtons();
        }

        private void buttonUpTask_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedIndices.Count > 0)
            {
                int index1 = listViewTasks.SelectedIndices[0];
                int index2 = MainCrackTaskManager.TaskMoveToStart(index1);

                VisualizeTask(index1);
                VisualizeTask(index2);
                listViewTasks.Items[index2].Focused = true;
                listViewTasks.Items[index2].Selected = true;
            }
        }

        private void buttonDownTask_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedIndices.Count > 0)
            {
                int index1 = listViewTasks.SelectedIndices[0];
                int index2 = MainCrackTaskManager.TaskMoveToEnd(index1);

                VisualizeTask(index1);
                VisualizeTask(index2);
                listViewTasks.Items[index2].Focused = true;
                listViewTasks.Items[index2].Selected = true;
            }
        }

        private void CheckButtons()
        {
            if (MainCrackTaskManager.Cracker.IsCracking)
            {
                buttonPauseTask.Enabled = true;
                toolStripMenuItemPause.Enabled = true;

                buttonStopTask.Enabled = true;
                toolStripMenuItemStop.Enabled = true;
            }
            else
            {
                buttonPauseTask.Enabled = false;
                toolStripMenuItemPause.Enabled = false;

                buttonStopTask.Enabled = false;
                toolStripMenuItemStop.Enabled = false;
            }

            if ((listViewTasks.Items.Count > 0) && (!MainCrackTaskManager.Cracker.IsCracking))
            {
                buttonClearTask.Enabled = true;
                toolStripMenuItemRemoveAll.Enabled = true;
            }
            else
            {
                buttonClearTask.Enabled = false;
                toolStripMenuItemRemoveAll.Enabled = false;
            }

            if (listViewTasks.SelectedIndices.Count == 1)
            {
                if (MainCrackTaskManager.Cracker.CrackingTaskId != listViewTasks.SelectedIndices[0])
                {
                    buttonDeleteTask.Enabled = true;
                    toolStripMenuItemRemove.Enabled = true;

                    buttonChangeTask.Enabled = true;
                    toolStripMenuItemChange.Enabled = true;
                }
                else
                {
                    buttonDeleteTask.Enabled = false;
                    toolStripMenuItemRemove.Enabled = false;

                    buttonChangeTask.Enabled = false;
                    toolStripMenuItemChange.Enabled = false;
                }

                if (MainCrackTaskManager.CrackTasks[listViewTasks.SelectedIndices[0]].Restore == true)
                {
                    buttonStopTask.Enabled = true;
                    toolStripMenuItemStop.Enabled = true;
                }
                else
                {
                    buttonStopTask.Enabled = false;
                    toolStripMenuItemStop.Enabled = false;
                }

                if (listViewTasks.SelectedIndices[0] > 0)
                {
                    buttonUpTask.Enabled = true;
                    toolStripMenuItemMoveUp.Enabled = true;
                }
                else
                {
                    buttonUpTask.Enabled = false;
                    toolStripMenuItemMoveUp.Enabled = false;
                }

                if (listViewTasks.SelectedIndices[0] < listViewTasks.Items.Count - 1)
                {
                    buttonDownTask.Enabled = true;
                    toolStripMenuItemMoveDown.Enabled = true;
                }
                else
                {
                    buttonDownTask.Enabled = false;
                    toolStripMenuItemMoveDown.Enabled = false;
                }

                if (MainCrackTaskManager.Cracker.IsCracking
                    || MainCrackTaskManager.Cracker.IsCalculatingKeyspace
                    || MainCrackTaskManager.CrackTasks[listViewTasks.SelectedIndices[0]].Status == "Cracked")
                {
                    buttonStartTask.Enabled = false;
                    toolStripMenuItemStart.Enabled = false;
                }
                else
                {
                    buttonStartTask.Enabled = true;
                    toolStripMenuItemStart.Enabled = true;
                }
            }
            else
            {
                buttonUpTask.Enabled = false;
                toolStripMenuItemMoveUp.Enabled = false;

                buttonDownTask.Enabled = false;
                toolStripMenuItemMoveDown.Enabled = false;

                buttonDeleteTask.Enabled = false;
                toolStripMenuItemRemove.Enabled = false;

                buttonChangeTask.Enabled = false;
                toolStripMenuItemChange.Enabled = false;

                buttonStartTask.Enabled = false;
                toolStripMenuItemStart.Enabled = false;

                if (MainCrackTaskManager.Cracker.IsCracking)
                {
                    buttonStopTask.Enabled = true;
                    toolStripMenuItemStop.Enabled = true;
                }
                else
                {
                    buttonStopTask.Enabled = false;
                    toolStripMenuItemStop.Enabled = false;
                }
            }

            listViewTasks.Focus();
        }

        private void listViewTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        public void VisualizeTask(int TaskId)
        {
            string[] values = new string[listViewTasks.Columns.Count];
            CrackTaskManager.CrackTask curTask = tskManager.CrackTasks[TaskId];

            values[0] = (TaskId + 1).ToString();
            values[1] = curTask.HashTypeName;
            values[2] = curTask.Hash;
            values[3] = curTask.Plain;
            values[4] = curTask.CurrentLength.ToString() + "/"
                + curTask.MaxLength.ToString();
            //values[5] = curTask.Progress.ToString("F") + " %";
            values[5] = "";
            values[6] = curTask.RecoveredDigests.ToString() + "/"
                + curTask.Digests;
            values[7] = curTask.RecoveredSalts.ToString() + "/"
                + curTask.Salts;
            values[8] = curTask.Status;
            values[9] = curTask.Estimated;
            values[10] = curTask.OutputFileName;

            switch (curTask.AttackType)
            {
                case 0:
                    values[11] = curTask.Dictionary;
                    break;
                case 3:
                    values[11] = curTask.BruteforceMask;
                    break;
            }

            values[12] = curTask.Started.ToString(DateTimeFormat);
            values[13] = curTask.Finished.ToString(DateTimeFormat);
            values[14] = curTask.SessionId;

            if (listViewTasks.Items[TaskId].SubItems.Count > 1)
            {
                for (byte i = 0; i < values.Length; i++)
                {
                    listViewTasks.Items[TaskId].SubItems[i].Text = values[i];
                }
            }
            else
            {
                listViewTasks.Items[TaskId] = new ListViewItem(values);
            }
        }

        public void VisualizeTasks()
        {
            listViewTasks.Items.Clear();

            for (int i = 0; i < tskManager.CrackTasks.Length; i++)
            {
                listViewTasks.Items.Add("");
                VisualizeTask(i);
            }
        }

        public void VisualizeNewTask()
        {
            string[] subItems = new string[listViewTasks.Columns.Count];
            ListViewItem lvItem = new ListViewItem(subItems);
            listViewTasks.Items.Add(lvItem);
            VisualizeTask(tskManager.CrackTasks.Length - 1);
        }

        private void buttonStartTask_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedIndices.Count > 0)
            {
                if (tskManager.Cracker.SetHashcat(Properties.Settings.Default.Hashcat, true))
                {
                    tskManager.Cracker.SetWorkingDirectory(Properties.Settings.Default.WorkingDirectory);
                    tskManager.Cracker.Crack(listViewTasks.SelectedIndices[0]);
                }

                checkBoxPauseCracking.Checked = false;
            }
        }

        private void buttonPauseTask_Click(object sender, EventArgs e)
        {
            tskManager.Cracker.PauseCracking();
        }

        private void buttonStopTask_Click(object sender, EventArgs e)
        {
           if (listViewTasks.SelectedIndices.Count > 0)
            {
                tskManager.Cracker.StopCracking(listViewTasks.SelectedIndices[0]);

                if (!tskManager.Cracker.IsCracking)
                {
                    CheckButtons();
                    VisualizeTask(listViewTasks.SelectedIndices[0]);
                }
            }
            else if (tskManager.Cracker.IsCracking)
            {
                tskManager.Cracker.StopCracking();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tskManager.Cracker.IsCracking)
            {
                tskManager.Cracker.PauseCracking();
            }

            Stream crackTasksStream = File.Create(crackTasksFile);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(crackTasksStream, tskManager.CrackTasks);
            crackTasksStream.Close();

            Properties.Settings.Default.CrackAllChecked = checkBoxAllChecked.Checked;
            Properties.Settings.Default.Save();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            (new SettingsForm()).ShowDialog(this);
        }

        private void checkBoxAppearanceUpdate(CheckBox sender)
        {
            if (sender.Checked)
            {
                sender.ImageIndex = 1;
                sender.ForeColor = Color.Black;
            }
            else
            {
                sender.ImageIndex = 0;
                sender.ForeColor = Color.Gray;
            }
        }

        private void checkBoxAllChecked_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAppearanceUpdate(checkBoxAllChecked);
        }

        private void checkBoxPauseCracking_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAppearanceUpdate(checkBoxPauseCracking);

            if (checkBoxPauseCracking.Checked)
            {
                tskManager.Cracker.PauseCracking();
            }
            else
            {
                if ((tskManager.Cracker.LastCrackingTaskId != -1)
                    && (!tskManager.Cracker.IsCracking))
                {
                    tskManager.Cracker.Crack(tskManager.Cracker.LastCrackingTaskId);
                }
            }
        }

        private void listViewTasks_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listViewTasks_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ColumnIndex == 5)
            { 
                int progress = (int)tskManager.CrackTasks[e.ItemIndex].Progress;
                string status = tskManager.CrackTasks[e.ItemIndex].Status;
                Color foreColor;

                switch (status)
                {
                    case "Stopped":
                    case "Paused":
                        foreColor = SimpleProgressBar.Colors.ForeColors.Stopped;
                        break;
                    case "Cracked":
                        foreColor = SimpleProgressBar.Colors.ForeColors.Complete;
                        break;
                    case "Running":
                        foreColor = SimpleProgressBar.Colors.ForeColors.Processing;
                        break;
                    default:
                        foreColor = SimpleProgressBar.Colors.ForeColors.Stopped;
                        break;
                }

                SimpleProgressBar.Render(e.Graphics, e.Bounds, progress,
                    status + " (" + progress.ToString() + " %)",
                    SimpleProgressBar.Colors.BackColors.Default,
                    foreColor);
            }
            else
            {
                e.DrawDefault = true;
            }
        }
    }
}