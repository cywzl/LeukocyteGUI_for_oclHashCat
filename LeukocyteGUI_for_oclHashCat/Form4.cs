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

            if (!CrackTask.SetHash(textBoxHashFileName.Text))
            {
                return;
            }

            CrackTask.SetSeparator(textBoxSeparator.Text);
            Data = comboBoxHashType.Text.Split('=');
            CrackTask.SetHashTypeCode(int.Parse(Data[0].Trim()));
            CrackTask.SetHashTypeName(Data[1].Trim());
            CrackTask.SetBruteforceMask(textBoxBruteforceMask.Text);
            CrackTask.SetDictionary(textBoxDictionary.Text);
            CrackTask.SetCharset1(textBoxCharset1.Text);
            CrackTask.SetCharset2(textBoxCharset2.Text);
            CrackTask.SetCharset3(textBoxCharset3.Text);
            CrackTask.SetCharset4(textBoxCharset4.Text);
            CrackTask.UseCharset1 = checkBoxCharset1.Checked;
            CrackTask.UseCharset2 = checkBoxCharset2.Checked;
            CrackTask.UseCharset3 = checkBoxCharset3.Checked;
            CrackTask.UseCharset4 = checkBoxCharset4.Checked;

            if (checkBoxEnableIncrement.Checked)
            {
                CrackTask.EnableIncrementMode = true;
                CrackTask.SetStartLength((byte)numericUpDownIncrementMin.Value);
                CrackTask.SetMaxLength((byte)numericUpDownIncrementMax.Value);
            }
            else
            {
                CrackTask.SetMaxLength((byte)textBoxBruteforceMask.Text.Replace("?", "").Length);
            }

            if (radioButtonAttackTypeBrute.Checked)
            {
                CrackTask.SetAttackType(3);
            }
            else
            {
                CrackTask.SetAttackType(0);
            }

            CrackTask.EnableGPUAsync = checkBoxGPUAsync.Checked;

            CrackTask.EnableSpecificWorkloadProfile = checkBoxSpecificWorkloadProfile.Checked;
            Data = comboBoxWorkloadProfile.Text.Split('=');
            CrackTask.SetWorkloadProfileCode(byte.Parse(Data[0].Trim()));
            CrackTask.SetWorkloadProfileName(Data[1].Trim());

            CrackTask.EnableWorkloadTuning = checkBoxWorkloadTuning.Checked;
            CrackTask.SetWorkloadTuning(byte.Parse(comboBoxWorkloadTuning.Text));

            CrackTask.EnableWorkloadFineTuning = checkBoxWorkloadFineTuning.Checked;
            CrackTask.SetWorkloadFineTuning((int)numericUpDownWorkloadFineTuning.Value);

            CrackTask.DisableTempReading = checkBoxDisableTemp.Checked;

            CrackTask.AbortSessionIfReachesMaxTemp = checkBoxTempAbort.Checked;
            CrackTask.SetAbortTemp((byte)numericUpDownTempAbort.Value);

            CrackTask.TryToRetain = checkBoxTempRetain.Checked;
            CrackTask.SetRetainTemp((byte)numericUpDownTempRetain.Value);

            CrackTask.DisableAutoPowertuning = checkBoxDisablePowertune.Checked;

            if (checkBoxOutputToFile.Checked)
            {
                CrackTask.OutputToFile = true;

                if (!CrackTask.SetOutputFileName(textBoxOutputFile.Text, true))
                {
                    return;
                }
            }
            else
            {
                CrackTask.SetOutputFileName(textBoxOutputFile.Text);
            }

            Data = comboBoxOutputFormat.Text.Split('=');
            CrackTask.SetOutputFormatCode(byte.Parse(Data[0].Trim()));
            CrackTask.SetOutputFormatName(Data[1].Trim());

            CrackTask.SetSessionId(textBoxSessionId.Text);
            CrackTask.CharsetIsInHex = checkBoxCharsetIsInHex.Checked;
            CrackTask.SaltIsInHex = checkBoxSaltIsInHex.Checked;
            CrackTask.IgnoreWarnings = checkBoxIgnoreWarnings.Checked;
            CrackTask.EnableLoopback = checkBoxLoopback.Checked;
            CrackTask.IgnoreUsernames = checkBoxIgnoreUsernames.Checked;
            CrackTask.RemoveCrackedHashes = checkBoxRemoveCracked.Checked;
            CrackTask.DisablePotfile = checkBoxDisablePot.Checked;
            CrackTask.DisableLogfile = checkBoxDisableLog.Checked;

            if (ChangingTaskId > -1)
            {
                MainCrackTaskManager.UpdateTask(ChangingTaskId, CrackTask);
            }
            else
            {
                MainCrackTaskManager.AddTask(CrackTask);
            }

            this.DialogResult = DialogResult.OK;
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
