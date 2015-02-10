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
        CrackTaskManager tskManager;
        DictionaryManager dictManager;
        MaskManager maskManager;
        int changingTaskId = -1;

        public TaskEditorForm()
        {
            InitializeComponent();
        }
        public TaskEditorForm(int ChangingTaskId)
            : this()
        {
            this.changingTaskId = ChangingTaskId;
        }

        private void TaskEditorForm_Load(object sender, EventArgs e)
        {
            tskManager = (this.Owner as MainForm).MainCrackTaskManager;
            dictManager = (this.Owner as MainForm).DictionaryManager;
            maskManager = (this.Owner as MainForm).MaskManager;
            FillFormWithTaskData();

            for (int index = 0; index < dictManager.Dictionaries.Length; index++)
            {
                checkedListBoxDictionary.Items.Add(dictManager.Dictionaries[index].Description);
            }

            for (int index = 0; index < maskManager.Masks.Length; index++)
            {
                checkedListBoxMask.Items.Add(maskManager.Masks[index].Description);
            }
        }
        private void buttonSubmitTask_Click(object sender, EventArgs e)
        {
            string[] Data;
            CrackTaskManager.CrackTask CrackTask;

            if (changingTaskId > -1)
            {
                CrackTask = tskManager.CrackTasks[changingTaskId].DeepCopy();
            }
            else
            {
                CrackTask = new CrackTaskManager.CrackTask();
            }

            if (!CrackTask.SetHash(textBoxHashFileName.Text, true))
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
            CrackTask.Status = "Paused";

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

            if (changingTaskId > -1)
            {
                tskManager.UpdateTask(changingTaskId, CrackTask);
            }
            else
            {
                tskManager.AddTask(CrackTask);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void buttonClearTask_Click(object sender, EventArgs e)
        {
            FillFormWithTaskData();
        }
        private void buttonCancelTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonChooseHashFile_Click(object sender, EventArgs e)
        {
            openFileDialogHash.ShowDialog();
        }
        private void buttonChooseDictionaryFile_Click(object sender, EventArgs e)
        {
            openFileDialogDictionary.ShowDialog();
        }
        private void buttonChooseOutputFile_Click(object sender, EventArgs e)
        {
            saveFileDialogOutput.ShowDialog();
        }
        private void openFileDialogHash_FileOk(object sender, CancelEventArgs e)
        {
            textBoxHashFileName.Text = openFileDialogHash.FileName;
        }
        private void openFileDialogDictionary_FileOk(object sender, CancelEventArgs e)
        {
            textBoxDictionary.Text = openFileDialogDictionary.FileName;
        }
        private void saveFileDialogOutput_FileOk(object sender, CancelEventArgs e)
        {
            textBoxOutputFile.Text = saveFileDialogOutput.FileName;
        }

        private void FillFormWithTaskData()
        {
            if (changingTaskId == -1)
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
                CrackTaskManager.CrackTask CrackTask = tskManager.CrackTasks[changingTaskId];

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
    }
}
