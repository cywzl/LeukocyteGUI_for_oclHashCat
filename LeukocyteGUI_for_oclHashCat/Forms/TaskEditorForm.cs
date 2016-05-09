using LeukocyteCore_for_oclHashcat.Classes;
using LeukocyteGUI_for_oclHashcat.Classes;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashcat.Forms
{
    public partial class TaskEditorForm : Form
    {
        List<CrackTask> crackTasks = new List<CrackTask>();
        CrackTask sourceCrackTask;

        public List<CrackTask> CrackTasks
        {
            get
            {
                return crackTasks;
            }
        }

        public TaskEditorForm()
        {
            InitializeComponent();
            sourceCrackTask = new CrackTask();
        }
        public TaskEditorForm(CrackTask source)
        {
            InitializeComponent();
            sourceCrackTask = (CrackTask)source.Clone();
        }

        private void rbAttackType_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                FillAttackSources();

                switch (rb.Name)
                {
                    case "rbStraight":
                        gbIncrementMode.Enabled = false;
                        gbCharsets.Enabled = false;
                        lblRightSource.Enabled = false;
                        cmbRightSource.Enabled = false;
                        lblLeftSource.Text = "Dictionary:";

                        break;

                    case "rbCombination":
                        gbIncrementMode.Enabled = false;
                        gbCharsets.Enabled = false;
                        lblRightSource.Enabled = true;
                        cmbRightSource.Enabled = true;
                        lblLeftSource.Text = "Left Dictionary:";
                        lblRightSource.Text = "Right Dictionary:";

                        break;

                    case "rbBruteforce":
                        gbIncrementMode.Enabled = true;
                        gbCharsets.Enabled = true;
                        lblRightSource.Enabled = false;
                        cmbRightSource.Enabled = false;
                        lblLeftSource.Text = "Mask:";

                        break;

                    case "rbDictMask":
                        gbIncrementMode.Enabled = true;
                        gbCharsets.Enabled = true;
                        lblRightSource.Enabled = true;
                        cmbRightSource.Enabled = true;
                        lblLeftSource.Text = "Left Dictionary:";
                        lblRightSource.Text = "Right Mask:";

                        break;

                    case "rbMaskDict":
                        gbIncrementMode.Enabled = true;
                        gbCharsets.Enabled = true;
                        lblRightSource.Enabled = true;
                        cmbRightSource.Enabled = true;
                        lblLeftSource.Text = "Left Mask:";
                        lblRightSource.Text = "Right Dictionary:";

                        break;
                }
            }
        }

        private void FillForm()
        {
            if (crackTasks.Count == 0)
            {
                return;
            }

            CrackTask crackTask = crackTasks[0];

            // Main

            switch (crackTask.AttackMode)
            {
                case AttackModes.BruteForce:
                    rbBruteforce.Checked = true;
                    break;
                case AttackModes.Combination:
                    rbCombination.Checked = true;
                    break;
                case AttackModes.DictPlusMask:
                    rbDictMask.Checked = true;
                    break;
                case AttackModes.MaskPlusDict:
                    rbMaskDict.Checked = true;
                    break;
                case AttackModes.Straight:
                    rbStraight.Checked = true;
                    break;
            }

            cbIncrementMode.Checked = crackTask.IncrementSettings.Increment;
            nudIncrementMin.Value = crackTask.IncrementSettings.IncrementMin;
            nudIncrementMax.Value = crackTask.IncrementSettings.IncrementMax;

            cmbLeftSource.Text = crackTask.CrackDataSourceLeft;
            cmbRightSource.Text = crackTask.CrackDataSourceRight;

            cbCharset1.Checked = crackTask.CustomCharsetsSettings.UseCharset1;
            cbCharset2.Checked = crackTask.CustomCharsetsSettings.UseCharset2;
            cbCharset3.Checked = crackTask.CustomCharsetsSettings.UseCharset3;
            cbCharset4.Checked = crackTask.CustomCharsetsSettings.UseCharset4;
            cmbCharset1.Text = crackTask.CustomCharsetsSettings.Charset1;
            cmbCharset2.Text = crackTask.CustomCharsetsSettings.Charset2;
            cmbCharset3.Text = crackTask.CustomCharsetsSettings.Charset3;
            cmbCharset4.Text = crackTask.CustomCharsetsSettings.Charset4;

            // Misc

            cbHexCharset.Checked = crackTask.MiscSettings.HexCharset;
            cbHexSalt.Checked = crackTask.MiscSettings.HexSalt;
            cbHexWordlist.Checked = crackTask.MiscSettings.HexWordlist;
            cbForce.Checked = crackTask.MiscSettings.Force;
            cbLoopback.Checked = crackTask.MiscSettings.Loopback;

            if (crackTask.MiscSettings.WeakHashThreshold == -1)
            {
                cbWeakHashThreshold.Checked = false;
            }
            else
            {
                cbWeakHashThreshold.Checked = true;
                nudWeakHashThreshold.Value = crackTask.MiscSettings.WeakHashThreshold;
            }

            // Markov

            if (string.IsNullOrEmpty(crackTask.MarkovSettings.MarkovHcstat))
            {
                cbMarkovHcstat.Checked = false;
            }
            else
            {
                cbMarkovHcstat.Checked = true;
                tbMarkovHcstat.Text = crackTask.MarkovSettings.MarkovHcstat;
            }

            cbMarkovDisable.Checked = crackTask.MarkovSettings.MarkovDisable;
            cbMarkovClassic.Checked = crackTask.MarkovSettings.MarkovClassic;

            if (crackTask.MarkovSettings.MarkovThreshold == -1)
            {
                cbMarkovThreshold.Checked = false;
            }
            else
            {
                cbMarkovThreshold.Checked = true;
                nudMarkovThreshold.Value = crackTask.MarkovSettings.MarkovThreshold;
            }

            // Session

            if (crackTask.SessionSettings.RunTime == -1)
            {
                cbRuntime.Checked = false;
            }
            else
            {
                cbRuntime.Checked = true;
                nudRuntime.Value = crackTask.SessionSettings.RunTime;
            }

            if (string.IsNullOrEmpty(crackTask.SessionSettings.Session))
            {
                cbSession.Checked = false;
            }
            else
            {
                cbSession.Checked = true;
                tbSession.Text = crackTask.SessionSettings.Session;
            }

            cbRestoreDisable.Checked = crackTask.SessionSettings.RestoreDisable;

            // Files

            if (string.IsNullOrEmpty(crackTask.FilesSettings.OutFile))
            {
                cbOutfile.Checked = false;
            }
            else
            {
                cbOutfile.Checked = true;
                tbOutfile.Text = crackTask.FilesSettings.OutFile;
            }

            if (crackTask.FilesSettings.OutFileFormat == -1)
            {
                cbOutfileFormat.Checked = false;
            }
            else
            {
                cbOutfileFormat.Checked = true;
                nudOutfileFormat.Value = crackTask.FilesSettings.OutFileFormat;
            }

            cbOutfileAutohexDisable.Checked = crackTask.FilesSettings.OutFileAutoHexDisable;

            if (crackTask.FilesSettings.OutFileCheckTimer == -1)
            {
                cbOutfileCheckTimer.Checked = false;
            }
            else
            {
                cbOutfileCheckTimer.Checked = true;
                nudOutfileCheckTimer.Value = crackTask.FilesSettings.OutFileCheckTimer;
            }

            if (crackTask.FilesSettings.Separator == '\0')
            {
                cbSeparator.Checked = false;
            }
            else
            {
                cbSeparator.Checked = true;
                tbSeparator.Text = crackTask.FilesSettings.Separator.ToString();
            }

            cbShowCracked.Checked = crackTask.FilesSettings.ShowCrackedPasswordsOnly;
            cbShowUncracked.Checked = crackTask.FilesSettings.ShowUncrackedPasswordsOnly;
            cbIgnoreUsernames.Checked = crackTask.FilesSettings.EnableIgnoringUsernames;
            cbRemoveCracked.Checked = crackTask.FilesSettings.RemoveCrackedHashes;

            if (crackTask.FilesSettings.RemoveTimer == -1)
            {
                cbRemoveTimer.Checked = false;
            }
            else
            {
                cbRemoveTimer.Checked = true;
                nudRemoveTimer.Value = crackTask.FilesSettings.RemoveTimer;
            }

            cbPotfileDisable.Checked = crackTask.FilesSettings.PotfileDisable;

            if (crackTask.FilesSettings.DebugMode == DebugModes.NoDebug)
            {
                cbDebugMode.Checked = false;
            }
            else
            {
                cbDebugMode.Checked = true;
                nudDebugMode.Value = (int)crackTask.FilesSettings.DebugMode;
            }

            if (string.IsNullOrEmpty(crackTask.FilesSettings.DebugFile))
            {
                cbDebugFile.Checked = false;
            }
            else
            {
                cbDebugFile.Checked = true;
                tbDebugFile.Text = crackTask.FilesSettings.DebugFile;
            }

            if (string.IsNullOrEmpty(crackTask.FilesSettings.InductionDir))
            {
                cbInductionDir.Checked = false;
            }
            else
            {
                cbInductionDir.Checked = true;
                tbInductionDir.Text = crackTask.FilesSettings.InductionDir;
            }

            if (string.IsNullOrEmpty(crackTask.FilesSettings.OutFileCheckDir))
            {
                cbOutfileCheckDir.Checked = false;
            }
            else
            {
                cbOutfileCheckDir.Checked = true;
                tbOutfileCheckDir.Text = crackTask.FilesSettings.OutFileCheckDir;
            }

            cbLogfileDisable.Checked = crackTask.FilesSettings.LogFileDisable;

            if (crackTask.FilesSettings.TrueCryptKeyFiles.Count == 0)
            {
                cbTruecryptKeyfiles.Checked = false;
            }
            else
            {
                cbTruecryptKeyfiles.Checked = true;
                tbTruecryptKeyfiles.Text = string.Join(",", crackTask.FilesSettings.TrueCryptKeyFiles);
            }

            // Resources

            if (crackTask.ResourcesSettings.SegmentSize == -1)
            {
                cbSegmentSize.Checked = false;
            }
            else
            {
                cbSegmentSize.Checked = true;
                nudSegmentSize.Value = crackTask.ResourcesSettings.SegmentSize;
            }

            if (crackTask.ResourcesSettings.BitmapMin == -1)
            {
                cbBitmapMin.Checked = false;
            }
            else
            {
                cbBitmapMin.Checked = true;
                nudBitmapMin.Value = crackTask.ResourcesSettings.BitmapMin;
            }

            if (crackTask.ResourcesSettings.BitmapMax == -1)
            {
                cbBitmapMax.Checked = false;
            }
            else
            {
                cbBitmapMax.Checked = true;
                nudBitmapMax.Value = crackTask.ResourcesSettings.BitmapMax;
            }

            if (crackTask.ResourcesSettings.CpuAffinity.Count == 0)
            {
                cbCpuAffinity.Checked = false;
            }
            else
            {
                cbCpuAffinity.Checked = true;
                tbCpuAffinity.Text = string.Join(",", crackTask.ResourcesSettings.CpuAffinity);
            }

            cbGpuAsync.Checked = crackTask.ResourcesSettings.GpuAsync;

            if (crackTask.ResourcesSettings.GpuDevices.Count == 0)
            {
                cbGpuDevices.Checked = false;
            }
            else
            {
                cbGpuDevices.Checked = true;
                tbGpuDevices.Text = string.Join(",", crackTask.ResourcesSettings.GpuDevices);
            }

            if (crackTask.ResourcesSettings.WorkloadProfile == WorkloadProfiles.Default)
            {
                cbWorkloadProfile.Checked = false;
            }
            else
            {
                cbWorkloadProfile.Checked = true;
                nudWorkloadProfile.Value = (int)crackTask.ResourcesSettings.WorkloadProfile;
            }

            if (crackTask.ResourcesSettings.GpuAcceleration == -1)
            {
                cbGpuAccel.Checked = false;
            }
            else
            {
                cbGpuAccel.Checked = true;
                nudGpuAccel.Value = crackTask.ResourcesSettings.GpuAcceleration;
            }

            if (crackTask.ResourcesSettings.GpuLoops == -1)
            {
                cbGpuLoops.Checked = false;
            }
            else
            {
                cbGpuLoops.Checked = true;
                nudGpuLoops.Value = crackTask.ResourcesSettings.GpuLoops;
            }

            cbGpuTempDisable.Checked = crackTask.ResourcesSettings.GpuTempDisable;

            if (crackTask.ResourcesSettings.GpuTempAbort == -1)
            {
                cbGpuTempAbort.Checked = false;
            }
            else
            {
                cbGpuTempAbort.Checked = true;
                nudGpuTempAbort.Value = crackTask.ResourcesSettings.GpuTempAbort;
            }

            if (crackTask.ResourcesSettings.GpuTempRetain == -1)
            {
                cbGpuTempRetain.Checked = false;
            }
            else
            {
                cbGpuTempRetain.Checked = true;
                nudGpuTempRetain.Value = crackTask.ResourcesSettings.GpuTempRetain;
            }

            cbPowertuneEnable.Checked = crackTask.ResourcesSettings.PowertuneEnable;

            if (crackTask.ResourcesSettings.ScriptTMTO == -1)
            {
                cbScryptTmto.Checked = false;
            }
            else
            {
                cbScryptTmto.Checked = true;
                nudScryptTmto.Value = crackTask.ResourcesSettings.ScriptTMTO;
            }

            // Distributed

            if (crackTask.DistributedSettings.Skip == -1)
            {
                cbSkip.Checked = false;
            }
            else
            {
                cbSkip.Checked = true;
                nudSkip.Value = crackTask.DistributedSettings.Skip;
            }

            if (crackTask.DistributedSettings.Limit == -1)
            {
                cbLimit.Checked = false;
            }
            else
            {
                cbLimit.Checked = true;
                nudLimit.Value = crackTask.DistributedSettings.Limit;
            }

            // Rules

            if (string.IsNullOrEmpty(crackTask.RulesSettings.RuleLeft))
            {
                cbRuleLeft.Checked = false;
            }
            else
            {
                cbRuleLeft.Checked = true;
                tbRuleLeft.Text = crackTask.RulesSettings.RuleLeft;
            }

            if (string.IsNullOrEmpty(crackTask.RulesSettings.RuleRight))
            {
                cbRuleRight.Checked = false;
            }
            else
            {
                cbRuleRight.Checked = true;
                tbRuleRight.Text = crackTask.RulesSettings.RuleRight;
            }

            if (crackTask.RulesSettings.RulesFiles.Count == 0)
            {
                cbRulesFiles.Checked = false;
            }
            else
            {
                cbRulesFiles.Checked = true;
                tbRulesFiles.Text = string.Join(",", crackTask.RulesSettings.RulesFiles);
            }

            if (crackTask.RulesSettings.GenerateRules == -1)
            {
                cbGenerateRules.Checked = false;
            }
            else
            {
                cbGenerateRules.Checked = true;
                nudGenerateRules.Value = crackTask.RulesSettings.GenerateRules;
            }

            if (crackTask.RulesSettings.GenerateRulesFuncMin == -1)
            {
                cbGenerateRulesFuncMin.Checked = false;
            }
            else
            {
                cbGenerateRulesFuncMin.Checked = true;
                nudGenerateRulesFuncMin.Value = crackTask.RulesSettings.GenerateRulesFuncMin;
            }

            if (crackTask.RulesSettings.GenerateRulesFuncMax == -1)
            {
                cbGenerateRulesFuncMax.Checked = false;
            }
            else
            {
                cbGenerateRulesFuncMax.Checked = true;
                nudGenerateRulesFuncMax.Value = crackTask.RulesSettings.GenerateRulesFuncMax;
            }

            if (crackTask.RulesSettings.GenerateRulesSeed == -1)
            {
                cbGenerateRulesSeed.Checked = false;
            }
            else
            {
                cbGenerateRulesSeed.Checked = true;
                nudGenerateRulesSeed.Value = crackTask.RulesSettings.GenerateRulesSeed;
            }
        }
        private void FillPredefined()
        {
            foreach (var source in DataManager.CrackDataSources)
            {
                lvPredefined.Items.Add(source.ToListViewItem(lvPredefined.Items.Count + 1));
            }
        }
        private void FillAttackSources()
        {
            cmbLeftSource.Items.Clear();
            cmbRightSource.Items.Clear();

            if ((rbStraight.Checked) || (rbCombination.Checked) || (rbDictMask.Checked))
            {
                foreach (var dictionary in DataManager.Dictionaries)
                {
                    cmbLeftSource.Items.Add(dictionary);
                }

                if (rbDictMask.Checked)
                {
                    foreach (var mask in DataManager.Masks)
                    {
                        cmbRightSource.Items.Add(mask);
                    }
                }
            }
            if ((rbCombination.Checked) || (rbMaskDict.Checked))
            {
                foreach (var dictionary in DataManager.Dictionaries)
                {
                    cmbRightSource.Items.Add(dictionary);
                }
            }
            if ((rbMaskDict.Checked) || (rbBruteforce.Checked))
            {
                foreach (var mask in DataManager.Masks)
                {
                    cmbLeftSource.Items.Add(mask);
                }
            }
        }

        private void TaskEditorForm_Shown(object sender, EventArgs e)
        {
            FillPredefined();
            FillAttackSources();
        }
    }
}
