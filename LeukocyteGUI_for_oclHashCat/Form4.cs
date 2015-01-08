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
    public partial class TaskEditorForm : Form
    {
        CrackTaskManager MainCrackTaskManager;
        int ChangingTaskId = -1;

        public TaskEditorForm()
        {
            InitializeComponent();
        }

        public TaskEditorForm(int ChangingTaskId)
            : this()
        {
            this.ChangingTaskId = ChangingTaskId;
        }

        private void buttonSubmitTask_Click(object sender, EventArgs e)
        {
            int TaskId;
            string[] Data;
            CrackTaskManager.CrackTask CrackTask;

            if (ChangingTaskId > -1)
            {
                CrackTask = MainCrackTaskManager.CrackTasks[ChangingTaskId].DeepCopy();
            }
            else
            {
                CrackTask = new CrackTaskManager.CrackTask();
            }

            CrackTask.SetHash(textBoxHashFileName.Text);
            CrackTask.SetSeparator(textBoxSeparator.Text);
            Data = comboBoxHashType.Text.Split('=');
            CrackTask.SetHashTypeCode(int.Parse(Data[0].Trim()));
            CrackTask.SetHashTypeName(Data[1].Trim());

            if (radioButtonAttackTypeBrute.Checked)
            {
                CrackTask.SetAttackType(3);
                CrackTask.SetBruteforceMask(textBoxBruteforceMask.Text);
            }
            else
            {
                CrackTask.SetAttackType(0);
                CrackTask.SetDictionary(textBoxDictionary.Text);
            }

            if (checkBoxCharset1.Checked)
            {
                CrackTask.UseCharset1 = true;
                CrackTask.SetCharset1(textBoxCharset1.Text);
            }

            if (checkBoxCharset2.Checked)
            {
                CrackTask.UseCharset2 = true;
                CrackTask.SetCharset2(textBoxCharset2.Text);
            }

            if (checkBoxCharset3.Checked)
            {
                CrackTask.UseCharset3 = true;
                CrackTask.SetCharset3(textBoxCharset3.Text);
            }

            if (checkBoxCharset4.Checked)
            {
                CrackTask.UseCharset4 = true;
                CrackTask.SetCharset4(textBoxCharset4.Text);
            }

            CrackTask.EnableGPUAsync = checkBoxGPUAsync.Checked;

            if (checkBoxSpecificWorkloadProfile.Checked)
            {
                CrackTask.EnableSpecificWorkloadProfile = true;
                Data = comboBoxWorkloadProfile.Text.Split('=');
                CrackTask.SetWorkloadProfileCode(byte.Parse(Data[0].Trim()));
                CrackTask.SetWorkloadProfileName(Data[1].Trim());
            }

            if (checkBoxWorkloadTuning.Checked)
            {
                CrackTask.EnableWorkloadTuning = true;
                CrackTask.SetWorkloadTuning(byte.Parse(comboBoxWorkloadTuning.Text));
            }

            if (checkBoxWorkloadFineTuning.Checked)
            {
                CrackTask.EnableWorkloadFineTuning = true;
                CrackTask.SetWorkloadFineTuning((int)numericUpDownWorkloadFineTuning.Value);
            }

            if (checkBoxTempAbort.Checked)
            {
                CrackTask.AbortSessionIfReachesMaxTemp = true;
                CrackTask.SetAbortTemp((byte)numericUpDownTempAbort.Value);
            }

            if (checkBoxTempRetain.Checked)
            {
                CrackTask.TryToRetain = true;
                CrackTask.SetRetainTemp((byte)numericUpDownTempRetain.Value);
            }

            CrackTask.DisableAutoPowertuning = checkBoxDisablePowertune.Checked;

            if (checkBoxEnableIncrement.Checked)
            {
                CrackTask.EnableIncrementMode = true;
                CrackTask.SetStartLength((byte)numericUpDownIncrementMin.Value);
                CrackTask.SetMaxLength((byte)numericUpDownIncrementMax.Value);
            }

            if (checkBoxOutputToFile.Checked)
            {
                CrackTask.OutputToFile = true;

                if (!CrackTask.SetOutputFileName(textBoxOutputFile.Text, true))
                {
                    return;
                }

                Data = comboBoxOutputFormat.Text.Split('=');
                CrackTask.SetOutputFormatCode(byte.Parse(Data[0].Trim()));
                CrackTask.SetOutputFormatName(Data[1].Trim());
            }

            CrackTask.SetSessionId(textBoxSessionId.Text);
            CrackTask.CharsetIsInHex = checkBoxCharsetIsInHex.Enabled;
            CrackTask.SaltIsInHex = checkBoxSaltIsInHex.Enabled;
            CrackTask.IgnoreWarnings = checkBoxIgnoreWarnings.Enabled;
            CrackTask.EnableLoopback = checkBoxLoopback.Enabled;
            CrackTask.IgnoreUsernames = checkBoxIgnoreUsernames.Enabled;
            CrackTask.RemoveCrackedHashes = checkBoxRemoveCracked.Enabled;
            CrackTask.DisablePotfile = checkBoxDisablePot.Enabled;
            CrackTask.DisableLogfile = checkBoxDisableLog.Enabled;

            if (ChangingTaskId > -1)
            {
                MainCrackTaskManager.CrackTasks[ChangingTaskId] = CrackTask;
                MainCrackTaskManager.Visualizer.VisualizeTask(ChangingTaskId);
            }
            else
            {
                MainCrackTaskManager.AddTask(CrackTask);
                MainCrackTaskManager.Visualizer.VisualizeNewTask();
            }

            this.Close();
        }

        private void FillFormWithTaskData()
        {
            if (ChangingTaskId == -1)
            {
                comboBoxHashType.SelectedIndex = 0;
                comboBoxOutputFormat.SelectedIndex = 0;
                comboBoxWorkloadProfile.SelectedIndex = 0;
                comboBoxWorkloadTuning.SelectedIndex = 0;
                textBoxSessionId.Text = DateTime.Now.ToString("yyyyMMddHHmmss");

                textBoxHashFileName.Text = "";
                textBoxSeparator.Text = ":";
                radioButtonAttackTypeBrute.Checked = true;

                textBoxBruteforceMask.Text = "";
                textBoxDictionary.Text = "";
                textBoxCharset1.Text = "";
                textBoxCharset2.Text = "";
                textBoxCharset3.Text = "";
                textBoxCharset4.Text = "";
                checkBoxCharset1.Checked = false;
                checkBoxCharset2.Checked = false;
                checkBoxCharset3.Checked = false;
                checkBoxCharset4.Checked = false;

                checkBoxGPUAsync.Checked = false;
                checkBoxSpecificWorkloadProfile.Checked = false;
                checkBoxWorkloadTuning.Checked = false;
                checkBoxWorkloadFineTuning.Checked = false;
                checkBoxDisableTemp.Checked = false;
                checkBoxTempAbort.Checked = false;
                checkBoxTempRetain.Checked = false;
                checkBoxDisablePowertune.Checked = false;
                numericUpDownWorkloadFineTuning.Value = 8;
                numericUpDownTempAbort.Value = 0;
                numericUpDownTempRetain.Value = 0;

                checkBoxEnableIncrement.Checked = false;
                numericUpDownIncrementMin.Value = 0;
                numericUpDownIncrementMax.Value = 0;

                checkBoxOutputToFile.Checked = false;
                textBoxOutputFile.Text = "";

                checkBoxCharsetIsInHex.Checked = false;
                checkBoxSaltIsInHex.Checked = false;
                checkBoxIgnoreWarnings.Checked = false;
                checkBoxLoopback.Checked = false;
                checkBoxIgnoreUsernames.Checked = false;
                checkBoxRemoveCracked.Checked = false;
                checkBoxDisablePot.Checked = false;
                checkBoxDisableLog.Checked = false;
            }
            else
            {
                CrackTaskManager.CrackTask CrackTask = MainCrackTaskManager.CrackTasks[ChangingTaskId];

                textBoxHashFileName.Text = CrackTask.Hash;
                textBoxSeparator.Text = CrackTask.Separator;
                comboBoxHashType.SelectedIndex
                    = comboBoxHashType.FindString(CrackTask.HashTypeCode.ToString());

                switch (CrackTask.AttackType)
                {
                    case 0:
                        radioButtonAttackTypeDictionary.Checked = true;
                        break;
                    case 3:
                        radioButtonAttackTypeBrute.Checked = true;
                        break;
                }

                textBoxBruteforceMask.Text = CrackTask.BruteforceMask;
                textBoxDictionary.Text = CrackTask.Dictionary;
                textBoxCharset1.Text = CrackTask.Charset1;
                textBoxCharset2.Text = CrackTask.Charset2;
                textBoxCharset3.Text = CrackTask.Charset3;
                textBoxCharset4.Text = CrackTask.Charset4;
                checkBoxCharset1.Checked = CrackTask.UseCharset1;
                checkBoxCharset2.Checked = CrackTask.UseCharset2;
                checkBoxCharset3.Checked = CrackTask.UseCharset3;
                checkBoxCharset4.Checked = CrackTask.UseCharset4;

                checkBoxGPUAsync.Checked = CrackTask.EnableGPUAsync;
                checkBoxSpecificWorkloadProfile.Checked = CrackTask.EnableSpecificWorkloadProfile;
                checkBoxWorkloadTuning.Checked = CrackTask.EnableWorkloadTuning;
                checkBoxWorkloadFineTuning.Checked = CrackTask.EnableWorkloadFineTuning;
                checkBoxDisableTemp.Checked = CrackTask.DisableTempReading;
                checkBoxTempAbort.Checked = CrackTask.AbortSessionIfReachesMaxTemp;
                checkBoxTempRetain.Checked = CrackTask.TryToRetain;
                checkBoxDisablePowertune.Checked = CrackTask.DisableAutoPowertuning;
                comboBoxWorkloadProfile.SelectedIndex
                    = comboBoxWorkloadProfile.FindString(CrackTask.WorkloadProfileCode.ToString());
                comboBoxWorkloadTuning.SelectedIndex
                    = comboBoxWorkloadTuning.FindString(CrackTask.WorkloadTuning.ToString());
                numericUpDownWorkloadFineTuning.Value = CrackTask.WorkloadFineTuning;
                numericUpDownTempAbort.Value = CrackTask.AbortTemp;
                numericUpDownTempRetain.Value = CrackTask.RetainTemp;

                checkBoxEnableIncrement.Checked = CrackTask.EnableIncrementMode;
                numericUpDownIncrementMin.Value = CrackTask.StartLength;
                numericUpDownIncrementMax.Value = CrackTask.MaxLength;

                checkBoxOutputToFile.Checked = CrackTask.OutputToFile;
                textBoxOutputFile.Text = CrackTask.OutputFileName;
                comboBoxOutputFormat.SelectedIndex
                    = comboBoxOutputFormat.FindString(CrackTask.OutputFormatCode.ToString());

                textBoxSessionId.Text = CrackTask.SessionId;
                checkBoxCharsetIsInHex.Checked = CrackTask.CharsetIsInHex;
                checkBoxSaltIsInHex.Checked = CrackTask.SaltIsInHex;
                checkBoxIgnoreWarnings.Checked = CrackTask.IgnoreWarnings;
                checkBoxLoopback.Checked = CrackTask.EnableLoopback;
                checkBoxIgnoreUsernames.Checked = CrackTask.IgnoreUsernames;
                checkBoxRemoveCracked.Checked = CrackTask.RemoveCrackedHashes;
                checkBoxDisablePot.Checked = CrackTask.DisablePotfile;
                checkBoxDisableLog.Checked = CrackTask.DisableLogfile;
            }
        }

        private void TaskEditorForm_Load(object sender, EventArgs e)
        {
            MainCrackTaskManager = (this.Owner as MainForm).MainCrackTaskManager;
            FillFormWithTaskData();
        }

        private void buttonCancelTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClearTask_Click(object sender, EventArgs e)
        {
            FillFormWithTaskData();
        }
    }
}
