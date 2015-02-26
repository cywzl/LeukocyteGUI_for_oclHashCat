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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace LeukocyteGUI_for_oclHashCat
{
    public partial class MainForm : Form
    {
        CrackTaskManager tskManager;
        DictionaryManager dictManager;
        MaskManager maskManager;
        ListViewSubItemTip subItemTip;

        public string DateTimeFormat { get; set; }
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
        public DictionaryManager DictionaryManager
        {
            get { return dictManager; }
            set { dictManager = value; }
        }
        public MaskManager MaskManager
        {
            get { return maskManager; }
            set { maskManager = value; }
        }

        public MainForm()
        {
            InitializeComponent();

            DateTimeFormat = "dd-MM-yyyy HH:mm:ss";

            subItemTip = new ListViewSubItemTip(listViewTasks);

            tskManager = new CrackTaskManager();
            tskManager.TaskAdded += tskManager_TaskAdded;
            tskManager.TaskDeleted += tskManager_TaskDeleted;
            tskManager.TaskMovedToEnd += tskManager_TaskMovedToEnd;
            tskManager.TaskMovedToStart += tskManager_TaskMovedToStart;
            tskManager.TaskUpdated += tskManager_TaskUpdated;
            tskManager.TasksAllDeleted += tskManager_TasksAllDeleted;
            tskManager.Cracker.SynchronizingObject = this;
            tskManager.Cracker.BeforeStart += Cracker_BeforeStart;
            tskManager.Cracker.OnStart += Cracker_OnStart;
            tskManager.Cracker.OnCracking += Cracker_OnCracking;
            tskManager.Cracker.OnStop += Cracker_OnStop;

            if (Properties.Settings.Default.LoadOnStartup)
            {
                LoadTasks();
            }

            dictManager = new DictionaryManager();
            LoadDictionaries();

            maskManager = new MaskManager();
            LoadMasks();

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
        private void Cracker_OnStop(object sender, int TaskId)
        {
            labelGPUSpeed.Text = "0 H/s";
            labelGPUTemp.Text = "0 °C";
            labelGPUUtil.Text = "0 %";
            labelFanSpeed.Text = "0 %";

            if (TaskId != -1)
            {
                listViewTasks.Items[TaskId].Checked = false;
                VisualizeTask(TaskId);
                SaveTasks();
            }

            string status = tskManager.CrackTasks[TaskId].Status;

            if (status == "Cracked")
            {
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);

                string hash = tskManager.CrackTasks[TaskId].Hash;

                if (Properties.Settings.Default.DeleteRelatedTasksWhenCracked)
                {
                    int maxIndex = tskManager.CrackTasks.Length - 1;
                    int actualTaskId = TaskId;

                    for (int index = 0; index <= maxIndex; index++)
                    {
                        if ((tskManager.CrackTasks[index].Hash == hash)
                            && (index != actualTaskId))
                        {
                            tskManager.DeleteTask(index);

                            if (index < actualTaskId)
                            {
                                actualTaskId--;
                            }

                            maxIndex--;
                            index--;
                        }
                    }
                }
                else
                {
                    for (int index = 0; index < tskManager.CrackTasks.Length; index++)
                    {
                        if ((tskManager.CrackTasks[index].Hash == hash)
                            && (index != TaskId))
                        {
                            tskManager.CrackTasks[index].Restore = true;
                            tskManager.CrackTasks[index].Status = status;
                            tskManager.CrackTasks[index].Digests
                                = tskManager.CrackTasks[TaskId].Digests;
                            tskManager.CrackTasks[index].RecoveredDigests
                                = tskManager.CrackTasks[TaskId].RecoveredDigests;
                            tskManager.CrackTasks[index].Salts
                                = tskManager.CrackTasks[TaskId].Salts;
                            tskManager.CrackTasks[index].RecoveredSalts
                                = tskManager.CrackTasks[TaskId].RecoveredSalts;
                            tskManager.CrackTasks[index].Plain
                                = tskManager.CrackTasks[TaskId].Plain;

                            VisualizeTask(index);
                        }
                    }
                }

                if (Properties.Settings.Default.ShowNotifications)
                {
                    notifyMessage.Show("Cracking process has finished"
                        + "\r\nAll " + tskManager.CrackTasks[TaskId].RecoveredDigests.ToString()
                        + "/" + tskManager.CrackTasks[TaskId].Digests.ToString()
                        + " digests have been cracked",
                    "(" + (TaskId + 1).ToString() + ") " + tskManager.CrackTasks[TaskId].Hash,
                    Properties.Resources.glyph_task_ok);
                }
            }
            else
            {
                if (tskManager.CrackTasks[TaskId].Status == "Paused")
                {
                    TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Paused);
                }
                else
                {
                    if (Properties.Settings.Default.ShowNotifications)
                    {
                        notifyMessage.Show("Cracking process has finished"
                                + "\r\n" + tskManager.CrackTasks[TaskId].RecoveredDigests.ToString()
                                + "/" + tskManager.CrackTasks[TaskId].Digests.ToString()
                                + " digests have been cracked",
                            "(" + (TaskId + 1).ToString() + ") " + tskManager.CrackTasks[TaskId].Hash,
                            Properties.Resources.glyph_task_cancel);
                    }
                }
            }

            CheckButtons();

            if ((checkBoxAllChecked.Checked) && (!checkBoxPauseCracking.Checked))
            {
                for (int index = 0; index < listViewTasks.Items.Count; index++)
                {
                    if ((listViewTasks.Items[index].Checked)
                        && (tskManager.CrackTasks[index].Status != "Cracked"))
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

            labelGPUSpeed.Text = tskManager.Cracker.Speed;
            labelGPUTemp.Text = tskManager.Cracker.Temp.ToString() + " °C";
            labelGPUUtil.Text = tskManager.Cracker.Util.ToString() + " %";
            labelFanSpeed.Text = tskManager.Cracker.Fan.ToString() + " %";

            TaskbarManager.Instance.SetProgressValue((int)tskManager.CrackTasks[TaskId].Progress, 100);
        }
        private void Cracker_OnStart(object sender, int TaskId)
        {
            CheckButtons();
            VisualizeTask(TaskId);
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
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

        private void buttonOpenCrackTasksFile_Click(object sender, EventArgs e)
        {
            openFileDialogCrackTasks.ShowDialog();
        }
        private void buttonSaveCrackTasksFile_Click(object sender, EventArgs e)
        {
            SaveTasks();
        }
        private void buttonSaveCrackTasksFileAs_Click(object sender, EventArgs e)
        {
            saveFileDialogCrackTasks.ShowDialog();
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

                tskManager.DeleteTask(index);
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
                tskManager.DeleteAllTasks();
                VisualizeTasks();
            }

            CheckButtons();
        }
        private void buttonUpTask_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedIndices.Count > 0)
            {
                int index1 = listViewTasks.SelectedIndices[0];
                int index2 = tskManager.TaskMoveToStart(index1);

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
                int index2 = tskManager.TaskMoveToEnd(index1);

                VisualizeTask(index1);
                VisualizeTask(index2);
                listViewTasks.Items[index2].Focused = true;
                listViewTasks.Items[index2].Selected = true;
            }
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
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            (new SettingsForm(this)).ShowDialog(this);
        }
        private void listViewTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }
        private void listViewTasks_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }
        private void listViewTasks_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                CrackTaskManager.CrackTask crackTask = tskManager.CrackTasks[e.ItemIndex];
                int progress = (int)crackTask.Progress;
                string status = crackTask.Status;
                Color foreColor, backColor;

                switch (status)
                {
                    case "Stopped":
                    case "Paused":
                        foreColor = SimpleProgressBar.Colors.ForeColors.Stopped;
                        backColor = SimpleProgressBar.Colors.BackColors.Default;
                        break;
                    case "Cracked":
                    case "Exhausted":
                        foreColor = SimpleProgressBar.Colors.ForeColors.CompleteLight;
                        backColor = SimpleProgressBar.Colors.ForeColors.Failure;

                        if (crackTask.Digests > 0)
                        {
                            progress = (int)(((float)crackTask.RecoveredDigests) / crackTask.Digests * 100);
                        }

                        break;
                    case "Running":
                        foreColor = SimpleProgressBar.Colors.ForeColors.Processing;
                        backColor = SimpleProgressBar.Colors.BackColors.Default;
                        break;
                    default:
                        foreColor = SimpleProgressBar.Colors.ForeColors.Stopped;
                        backColor = SimpleProgressBar.Colors.BackColors.Default;
                        break;
                }

                SimpleProgressBar.Render(e.Graphics, e.Bounds, progress,
                    status + " (" + progress.ToString() + " %)",
                    backColor, foreColor);
            }
            else
            {
                e.DrawDefault = true;
            }
        }
        private void listViewTasks_MouseMove(object sender, MouseEventArgs e)
        {
            subItemTip.ShowSubItemTip(e.Location);
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
                toolStripMenuItemPauseCracking.Enabled = false;
                toolStripMenuItemResumeCracking.Enabled = true;
                tskManager.Cracker.PauseCracking();
            }
            else
            {
                toolStripMenuItemPauseCracking.Enabled = true;
                toolStripMenuItemResumeCracking.Enabled = false;

                if ((tskManager.Cracker.LastCrackingTaskId != -1)
                    && (!tskManager.Cracker.IsCracking))
                {
                    tskManager.Cracker.Crack(tskManager.Cracker.LastCrackingTaskId);
                }
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tskManager.Cracker.IsCracking)
            {
                tskManager.Cracker.PauseCracking();
            }

            if (Properties.Settings.Default.SaveBeforeExit)
            {
                SaveTasks();
            }

            SaveDictionaries();
            SaveMasks();

            Properties.Settings.Default.CrackAllChecked = checkBoxAllChecked.Checked;
            Properties.Settings.Default.Save();
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MinimizeToTray)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    if (ShowInTaskbar)
                    {
                        ShowInTaskbar = false;
                    }
                }
                else
                {
                    if (!ShowInTaskbar)
                    {
                        ShowInTaskbar = true;
                    }
                }
            }
        }
        private void openFileDialogCrackTasks_FileOk(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.CrackTasksFile = openFileDialogCrackTasks.FileName;
            LoadTasks();
        }
        private void saveFileDialogCrackTasks_FileOk(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.CrackTasksFile = saveFileDialogCrackTasks.FileName;
            SaveTasks();
        }
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void toolStripMenuItemShow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void toolStripMenuItemPauseCracking_Click(object sender, EventArgs e)
        {
            checkBoxPauseCracking.Checked = true;
        }
        private void toolStripMenuItemResumeCracking_Click(object sender, EventArgs e)
        {
            checkBoxPauseCracking.Checked = false;
        }
        private void toolStripMenuItemInfo_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedIndices.Count == 0)
            {
                return;
            }

            CrackTaskManager.CrackTask crackTask = tskManager.CrackTasks[listViewTasks.SelectedIndices[0]];
            string clipboardText = "";

            switch ((sender as ToolStripMenuItem).Name)
            {
                case "toolStripMenuItemFullInfo":
                    clipboardText = (listViewTasks.SelectedIndices[0] + 1).ToString()
                        + ";" + crackTask.HashTypeName
                        + ";" + crackTask.Hash
                        + ";" + crackTask.Plain;

                    switch (crackTask.AttackType)
                    {
                        case 0:
                            clipboardText += ";" + crackTask.Dictionary + ";";
                            break;
                        case 3:
                            clipboardText += ";" + crackTask.BruteforceMask + ";";
                            break;
                    }

                    if (crackTask.OutputToFile)
                    {
                        clipboardText += crackTask.OutputFileName;
                    }

                    clipboardText += ";" + crackTask.SessionId
                        + ";" + crackTask.Estimated
                        + ";" + crackTask.Started
                        + ";" + crackTask.Finished;

                    break;

                case "toolStripMenuItemHashType":
                    clipboardText = crackTask.HashTypeName;
                    break;

                case "toolStripMenuItemHashTargetName":
                    clipboardText = crackTask.Hash.Substring(crackTask.Hash.LastIndexOf("\\") + 1);
                    break;

                case "toolStripMenuItemHashTargetPath":
                    clipboardText = crackTask.Hash;
                    break;

                case "toolStripMenuItemPlain":
                    clipboardText = crackTask.Plain;
                    break;

                case "toolStripMenuItemTimeEstimated":
                    clipboardText = crackTask.Estimated;
                    break;

                case "toolStripMenuItemTimeStarted":
                    clipboardText = crackTask.Started.ToString(DateTimeFormat);
                    break;

                case "toolStripMenuItemTimeFinished":
                    clipboardText = crackTask.Finished.ToString(DateTimeFormat);
                    break;

                case "toolStripMenuItemOutputFileName":
                    if (crackTask.OutputToFile)
                    {
                        clipboardText = crackTask.OutputFileName.Substring(crackTask.OutputFileName.LastIndexOf("\\") + 1);
                    }
                    
                    break;

                case "toolStripMenuItemOutputFilePath":
                    if (crackTask.OutputToFile)
                    {
                        clipboardText = crackTask.OutputFileName;
                    }
                    
                    break;

                case "toolStripMenuItemMaskDictionaryName":
                    switch (crackTask.AttackType)
                    {
                        case 0:
                            clipboardText = crackTask.Dictionary.Substring(crackTask.Dictionary.LastIndexOf("\\") + 1);
                            break;
                        case 3:
                            clipboardText = crackTask.BruteforceMask.Substring(crackTask.BruteforceMask.LastIndexOf("\\") + 1);
                            break;
                    }

                    break;

                case "toolStripMenuItemMaskDictionaryPath":
                    switch (crackTask.AttackType)
                    {
                        case 0:
                            clipboardText = crackTask.Dictionary;
                            break;
                        case 3:
                            clipboardText = crackTask.BruteforceMask;
                            break;
                    }
                    break;

                case "toolStripMenuItemSession":
                    clipboardText = crackTask.SessionId;
                    break;
            }

            if ((clipboardText != null) && (clipboardText != ""))
            {
                Clipboard.SetText(clipboardText);
            }
        }
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        public void CheckButtons()
        {
            if (tskManager.Cracker.IsCracking)
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

            if ((listViewTasks.Items.Count > 0) && (!tskManager.Cracker.IsCracking))
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
                int index = listViewTasks.SelectedIndices[0];

                toolStripMenuItemCopyTaskInfo.Enabled = true;

                if (tskManager.Cracker.CrackingTaskId != index)
                {
                    buttonDeleteTask.Enabled = true;
                    toolStripMenuItemRemove.Enabled = true;

                    if (tskManager.CrackTasks[index].Status != "Exhasted"
                        && tskManager.CrackTasks[index].Status != "Cracked")
                    {
                        buttonChangeTask.Enabled = true;
                        toolStripMenuItemChange.Enabled = true;
                    }
                    else
                    {
                        buttonChangeTask.Enabled = false;
                        toolStripMenuItemChange.Enabled = false;
                    }
                }
                else
                {
                    buttonDeleteTask.Enabled = false;
                    toolStripMenuItemRemove.Enabled = false;

                    buttonChangeTask.Enabled = false;
                    toolStripMenuItemChange.Enabled = false;
                }

                if (tskManager.CrackTasks[index].Restore == true)
                {
                    buttonStopTask.Enabled = true;
                    toolStripMenuItemStop.Enabled = true;
                }
                else
                {
                    buttonStopTask.Enabled = false;
                    toolStripMenuItemStop.Enabled = false;
                }

                if (index > 0)
                {
                    buttonUpTask.Enabled = true;
                    toolStripMenuItemMoveUp.Enabled = true;
                }
                else
                {
                    buttonUpTask.Enabled = false;
                    toolStripMenuItemMoveUp.Enabled = false;
                }

                if (index < listViewTasks.Items.Count - 1)
                {
                    buttonDownTask.Enabled = true;
                    toolStripMenuItemMoveDown.Enabled = true;
                }
                else
                {
                    buttonDownTask.Enabled = false;
                    toolStripMenuItemMoveDown.Enabled = false;
                }

                if (tskManager.Cracker.IsCracking
                    || tskManager.Cracker.IsCalculatingKeyspace
                    || tskManager.CrackTasks[index].Status == "Cracked")
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
                toolStripMenuItemCopyTaskInfo.Enabled = false;

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

                if (tskManager.Cracker.IsCracking)
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
            values[5] = "";
            values[6] = curTask.RecoveredDigests.ToString() + "/"
                + curTask.Digests;
            values[7] = curTask.RecoveredSalts.ToString() + "/"
                + curTask.Salts;
            values[8] = curTask.Estimated;
            values[9] = curTask.OutputFileName;

            switch (curTask.AttackType)
            {
                case 0:
                    values[10] = curTask.Dictionary;
                    break;
                case 3:
                    values[10] = curTask.BruteforceMask;
                    break;
            }

            values[11] = curTask.Started.ToString(DateTimeFormat);
            values[12] = curTask.Finished.ToString(DateTimeFormat);
            values[13] = curTask.SessionId;

            if (listViewTasks.Items[TaskId].SubItems.Count > 1)
            {
                for (byte i = 0; i < values.Length; i++)
                {
                    switch (i)
                    {
                        case 2:
                        case 9:
                        case 10:
                            if (values[i] != null)
                            {
                                listViewTasks.Items[TaskId].SubItems[i].Text =
                                    values[i].Substring(values[i].LastIndexOf("\\") + 1);
                                listViewTasks.Items[TaskId].SubItems[i].Tag = values[i];
                            }
                            break;
                        default:
                            listViewTasks.Items[TaskId].SubItems[i].Text = values[i];
                            break;
                    }
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
                string[] subItems = new string[listViewTasks.Columns.Count];
                ListViewItem lvItem = new ListViewItem(subItems);
                listViewTasks.Items.Add(lvItem);
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
        public void LoadTasks(bool ReplaceMode = true)
        {
            if (ReplaceMode)
            {
                tskManager.DeleteAllTasks();
            }

            if (File.Exists(Properties.Settings.Default.CrackTasksFile))
            {
                Stream deserializerStream = File.OpenRead(Properties.Settings.Default.CrackTasksFile);
                BinaryFormatter deserializer = new BinaryFormatter();
                CrackTaskManager.CrackTask[] crackTasks
                    = (CrackTaskManager.CrackTask[])deserializer.Deserialize(deserializerStream);
                deserializerStream.Close();
                tskManager.AddTasks(crackTasks);
            }

            tsslCrackTasksFile.Text = Properties.Settings.Default.CrackTasksFile;
        }
        public void SaveTasks()
        {
            Stream crackTasksStream = File.Create(Properties.Settings.Default.CrackTasksFile);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(crackTasksStream, tskManager.CrackTasks);
            crackTasksStream.Close();
            tsslCrackTasksFile.Text = Properties.Settings.Default.CrackTasksFile;
        }
        public void LoadDictionaries()
        {
            if (File.Exists("Dictionaries.bin"))
            {
                Stream deserializerStream = File.OpenRead("Dictionaries.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                DictionaryManager.Dictionary[] dictionaries
                    = (DictionaryManager.Dictionary[])deserializer.Deserialize(deserializerStream);
                deserializerStream.Close();
                dictManager.AddDictionaries(dictionaries);
            }
        }
        public void SaveDictionaries()
        {
            Stream dictionariesStream = File.Create("Dictionaries.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(dictionariesStream, dictManager.Dictionaries);
            dictionariesStream.Close();
        }
        public void LoadMasks()
        {
            if (File.Exists("Masks.bin"))
            {
                Stream deserializerStream = File.OpenRead("Masks.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                MaskManager.Mask[] masks
                    = (MaskManager.Mask[])deserializer.Deserialize(deserializerStream);
                deserializerStream.Close();
                maskManager.AddMasks(masks);
            }
        }
        public void SaveMasks()
        {
            Stream masksStream = File.Create("Masks.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(masksStream, maskManager.Masks);
            masksStream.Close();
        }
    }
}