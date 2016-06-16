using LeukocyteCore_for_oclHashcat.Classes;
using LeukocyteCore_for_oclHashcat.Interfaces;
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
        CrackTask crackTask;

        public List<CrackTask> CrackTasks
        {
            get
            {
                return crackTasks;
            }
        }

        public CustomCharsetsSettings Charsets
        {
            get
            {
                return new CustomCharsetsSettings
                {
                    Charset1 = cmbCharset1.Text,
                    Charset2 = cmbCharset2.Text,
                    Charset3 = cmbCharset3.Text,
                    Charset4 = cmbCharset4.Text,
                    UseCharset1 = cbCharset1.Checked,
                    UseCharset2 = cbCharset2.Checked,
                    UseCharset3 = cbCharset3.Checked,
                    UseCharset4 = cbCharset4.Checked,
                };
            }
            set
            {
                cbCharset1.Checked = value.UseCharset1;
                cbCharset2.Checked = value.UseCharset2;
                cbCharset3.Checked = value.UseCharset3;
                cbCharset4.Checked = value.UseCharset4;
                cmbCharset1.Text = value.Charset1;
                cmbCharset2.Text = value.Charset2;
                cmbCharset3.Text = value.Charset3;
                cmbCharset4.Text = value.Charset4;
            }
        }
        public IncrementSettings Increment
        {
            get
            {
                return new IncrementSettings
                {
                    Increment = cbIncrementMode.Checked,
                    IncrementMin = (int)nudIncrementMin.Value,
                    IncrementMax = (int)nudIncrementMax.Value
                };
            }
            set
            {
                cbIncrementMode.Checked = value.Increment;
                nudIncrementMin.Value = value.IncrementMin;
                nudIncrementMax.Value = value.IncrementMax;
            }
        }
        public MiscSettings Misc
        {
            get
            {
                return new MiscSettings
                {
                    HexCharset = cbHexCharset.Checked,
                    HexSalt = cbHexSalt.Checked,
                    HexWordlist = cbHexWordlist.Checked,
                    Force = cbForce.Checked,
                    Loopback = cbLoopback.Checked,
                    WeakHashThreshold = cbWeakHashThreshold.Checked ? (int)nudWeakHashThreshold.Value : -1
                };
            }
            set
            {
                cbHexCharset.Checked = value.HexCharset;
                cbHexSalt.Checked = value.HexSalt;
                cbHexWordlist.Checked = value.HexWordlist;
                cbForce.Checked = value.Force;
                cbLoopback.Checked = value.Loopback;

                if (value.WeakHashThreshold == -1)
                {
                    cbWeakHashThreshold.Checked = false;
                }
                else
                {
                    cbWeakHashThreshold.Checked = true;
                    nudWeakHashThreshold.Value = value.WeakHashThreshold;
                }
            }
        }
        public MarkovSettings Markov
        {
            get
            {
                return new MarkovSettings
                {
                    MarkovHcstat = cbMarkovHcstat.Checked ? tbMarkovHcstat.Text : "",
                    MarkovThreshold = cbMarkovThreshold.Checked ? (int)nudMarkovThreshold.Value : -1,
                    MarkovDisable = cbMarkovDisable.Checked,
                    MarkovClassic = cbMarkovClassic.Checked
                };
            }
            set
            {
                if (string.IsNullOrEmpty(value.MarkovHcstat))
                {
                    cbMarkovHcstat.Checked = false;
                }
                else
                {
                    cbMarkovHcstat.Checked = true;
                    tbMarkovHcstat.Text = value.MarkovHcstat;
                }

                cbMarkovDisable.Checked = value.MarkovDisable;
                cbMarkovClassic.Checked = value.MarkovClassic;

                if (value.MarkovThreshold == -1)
                {
                    cbMarkovThreshold.Checked = false;
                }
                else
                {
                    cbMarkovThreshold.Checked = true;
                    nudMarkovThreshold.Value = value.MarkovThreshold;
                }
            }
        }
        public SessionSettings Sessions
        {
            get
            {
                return new SessionSettings
                {
                    RunTime = cbRuntime.Checked ? (int)nudRuntime.Value : -1,
                    Session = cbSession.Checked ? tbSession.Text : "",
                    RestoreDisable = cbRestoreDisable.Checked
                };
            }
            set
            {
                if (value.RunTime == -1)
                {
                    cbRuntime.Checked = false;
                }
                else
                {
                    cbRuntime.Checked = true;
                    nudRuntime.Value = value.RunTime;
                }

                if (string.IsNullOrEmpty(value.Session))
                {
                    cbSession.Checked = false;
                }
                else
                {
                    cbSession.Checked = true;
                    tbSession.Text = value.Session;
                }

                cbRestoreDisable.Checked = value.RestoreDisable;
            }
        }
        public FilesSettings Files
        {
            get
            {
                return new FilesSettings
                {
                    OutFile = cbOutfile.Checked ? tbOutfile.Text : "",
                    OutFileFormat = cbOutfileFormat.Checked ? (int)nudOutfileFormat.Value : -1,
                    OutFileAutoHexDisable = cbOutfileAutohexDisable.Checked,
                    OutFileCheckTimer = cbOutfileCheckTimer.Checked ? (int)nudOutfileCheckTimer.Value : -1,
                    Separator = cbSeparator.Checked ? tbSeparator.Text[0] : '\0',
                    ShowCrackedPasswordsOnly = cbShowCracked.Checked,
                    ShowUncrackedPasswordsOnly = cbShowUncracked.Checked,
                    EnableIgnoringUsernames = cbIgnoreUsernames.Checked,
                    RemoveCrackedHashes = cbRemoveCracked.Checked,
                    RemoveTimer = cbRemoveTimer.Checked ? (int)nudRemoveTimer.Value : -1,
                    PotfileDisable = cbPotfileDisable.Checked,
                    DebugMode = cbDebugMode.Checked ? (DebugModes)nudDebugMode.Value : DebugModes.NoDebug,
                    DebugFile = cbDebugFile.Checked ? tbDebugFile.Text : "",
                    InductionDir = cbInductionDir.Checked ? tbInductionDir.Text : "",
                    OutFileCheckDir = cbOutfileCheckDir.Checked ? tbOutfileCheckDir.Text : "",
                    LogFileDisable = cbLogfileDisable.Checked,
                    TrueCryptKeyFiles = cbTruecryptKeyfiles.Checked ? new List<string>(tbTruecryptKeyfiles.Text.Split(','))
                                                : new List<string>()
                };
            }
            set
            {
                if (string.IsNullOrEmpty(value.OutFile))
                {
                    cbOutfile.Checked = false;
                }
                else
                {
                    cbOutfile.Checked = true;
                    tbOutfile.Text = value.OutFile;
                }

                if (value.OutFileFormat == -1)
                {
                    cbOutfileFormat.Checked = false;
                }
                else
                {
                    cbOutfileFormat.Checked = true;
                    nudOutfileFormat.Value = value.OutFileFormat;
                }

                cbOutfileAutohexDisable.Checked = value.OutFileAutoHexDisable;

                if (value.OutFileCheckTimer == -1)
                {
                    cbOutfileCheckTimer.Checked = false;
                }
                else
                {
                    cbOutfileCheckTimer.Checked = true;
                    nudOutfileCheckTimer.Value = value.OutFileCheckTimer;
                }

                if (value.Separator == '\0')
                {
                    cbSeparator.Checked = false;
                }
                else
                {
                    cbSeparator.Checked = true;
                    tbSeparator.Text = value.Separator.ToString();
                }

                cbShowCracked.Checked = value.ShowCrackedPasswordsOnly;
                cbShowUncracked.Checked = value.ShowUncrackedPasswordsOnly;
                cbIgnoreUsernames.Checked = value.EnableIgnoringUsernames;
                cbRemoveCracked.Checked = value.RemoveCrackedHashes;

                if (value.RemoveTimer == -1)
                {
                    cbRemoveTimer.Checked = false;
                }
                else
                {
                    cbRemoveTimer.Checked = true;
                    nudRemoveTimer.Value = value.RemoveTimer;
                }

                cbPotfileDisable.Checked = value.PotfileDisable;

                if (value.DebugMode == DebugModes.NoDebug)
                {
                    cbDebugMode.Checked = false;
                }
                else
                {
                    cbDebugMode.Checked = true;
                    nudDebugMode.Value = (int)value.DebugMode;
                }

                if (string.IsNullOrEmpty(value.DebugFile))
                {
                    cbDebugFile.Checked = false;
                }
                else
                {
                    cbDebugFile.Checked = true;
                    tbDebugFile.Text = value.DebugFile;
                }

                if (string.IsNullOrEmpty(value.InductionDir))
                {
                    cbInductionDir.Checked = false;
                }
                else
                {
                    cbInductionDir.Checked = true;
                    tbInductionDir.Text = value.InductionDir;
                }

                if (string.IsNullOrEmpty(value.OutFileCheckDir))
                {
                    cbOutfileCheckDir.Checked = false;
                }
                else
                {
                    cbOutfileCheckDir.Checked = true;
                    tbOutfileCheckDir.Text = value.OutFileCheckDir;
                }

                cbLogfileDisable.Checked = value.LogFileDisable;

                if (value.TrueCryptKeyFiles.Count == 0)
                {
                    cbTruecryptKeyfiles.Checked = false;
                }
                else
                {
                    cbTruecryptKeyfiles.Checked = true;
                    tbTruecryptKeyfiles.Text = string.Join(",", value.TrueCryptKeyFiles);
                }
            }
        }
        public ResourcesSettings Resources
        {
            get
            {
                return new ResourcesSettings
                {
                    SegmentSize = cbSegmentSize.Checked ? (int)nudSegmentSize.Value : -1,
                    BitmapMin = cbBitmapMin.Checked ? (int)nudBitmapMin.Value : -1,
                    BitmapMax = cbBitmapMax.Checked ? (int)nudBitmapMax.Value : -1,
                    CpuAffinity = cbCpuAffinity.Checked ? new List<string>(tbCpuAffinity.Text.Split(','))
                                                                : new List<string>(),
                    GpuAsync = cbGpuAsync.Checked,
                    GpuDevices = cbGpuDevices.Checked ? new List<string>(tbGpuDevices.Text.Split(','))
                                                                : new List<string>(),
                    WorkloadProfile = cbWorkloadProfile.Checked ? (WorkloadProfiles)nudWorkloadProfile.Value
                                                                : WorkloadProfiles.Default,
                    GpuAcceleration = cbGpuAccel.Checked ? (int)nudGpuAccel.Value : -1,
                    GpuLoops = cbGpuLoops.Checked ? (int)nudGpuLoops.Value : -1,
                    GpuTempDisable = cbGpuTempDisable.Checked,
                    GpuTempAbort = cbGpuTempAbort.Checked ? (int)nudGpuTempAbort.Value : -1,
                    GpuTempRetain = cbGpuTempRetain.Checked ? (int)nudGpuTempRetain.Value : -1,
                    PowertuneEnable = cbPowertuneEnable.Checked,
                    ScriptTMTO = cbScryptTmto.Checked ? (int)nudScryptTmto.Value : -1
                };
            }
            set
            {
                if (value.SegmentSize == -1)
                {
                    cbSegmentSize.Checked = false;
                }
                else
                {
                    cbSegmentSize.Checked = true;
                    nudSegmentSize.Value = value.SegmentSize;
                }

                if (value.BitmapMin == -1)
                {
                    cbBitmapMin.Checked = false;
                }
                else
                {
                    cbBitmapMin.Checked = true;
                    nudBitmapMin.Value = value.BitmapMin;
                }

                if (value.BitmapMax == -1)
                {
                    cbBitmapMax.Checked = false;
                }
                else
                {
                    cbBitmapMax.Checked = true;
                    nudBitmapMax.Value = value.BitmapMax;
                }

                if (value.CpuAffinity.Count == 0)
                {
                    cbCpuAffinity.Checked = false;
                }
                else
                {
                    cbCpuAffinity.Checked = true;
                    tbCpuAffinity.Text = string.Join(",", value.CpuAffinity);
                }

                cbGpuAsync.Checked = value.GpuAsync;

                if (value.GpuDevices.Count == 0)
                {
                    cbGpuDevices.Checked = false;
                }
                else
                {
                    cbGpuDevices.Checked = true;
                    tbGpuDevices.Text = string.Join(",", value.GpuDevices);
                }

                if (value.WorkloadProfile == WorkloadProfiles.Default)
                {
                    cbWorkloadProfile.Checked = false;
                }
                else
                {
                    cbWorkloadProfile.Checked = true;
                    nudWorkloadProfile.Value = (int)value.WorkloadProfile;
                }

                if (value.GpuAcceleration == -1)
                {
                    cbGpuAccel.Checked = false;
                }
                else
                {
                    cbGpuAccel.Checked = true;
                    nudGpuAccel.Value = value.GpuAcceleration;
                }

                if (value.GpuLoops == -1)
                {
                    cbGpuLoops.Checked = false;
                }
                else
                {
                    cbGpuLoops.Checked = true;
                    nudGpuLoops.Value = value.GpuLoops;
                }

                cbGpuTempDisable.Checked = value.GpuTempDisable;

                if (value.GpuTempAbort == -1)
                {
                    cbGpuTempAbort.Checked = false;
                }
                else
                {
                    cbGpuTempAbort.Checked = true;
                    nudGpuTempAbort.Value = value.GpuTempAbort;
                }

                if (value.GpuTempRetain == -1)
                {
                    cbGpuTempRetain.Checked = false;
                }
                else
                {
                    cbGpuTempRetain.Checked = true;
                    nudGpuTempRetain.Value = value.GpuTempRetain;
                }

                cbPowertuneEnable.Checked = value.PowertuneEnable;

                if (value.ScriptTMTO == -1)
                {
                    cbScryptTmto.Checked = false;
                }
                else
                {
                    cbScryptTmto.Checked = true;
                    nudScryptTmto.Value = value.ScriptTMTO;
                }
            }
        }
        public DistributedSettings Distributed
        {
            get
            {
                return new DistributedSettings
                {
                    Skip = cbSkip.Checked ? (int)nudSkip.Value : -1,
                    Limit = cbLimit.Checked ? (int)nudLimit.Value : -1
                };
            }
            set
            {
                if (value.Skip == -1)
                {
                    cbSkip.Checked = false;
                }
                else
                {
                    cbSkip.Checked = true;
                    nudSkip.Value = value.Skip;
                }

                if (value.Limit == -1)
                {
                    cbLimit.Checked = false;
                }
                else
                {
                    cbLimit.Checked = true;
                    nudLimit.Value = value.Limit;
                }
            }
        }
        public RulesSettings Rules
        {
            get
            {
                return new RulesSettings
                {
                    RuleLeft = cbRuleLeft.Checked ? tbRuleLeft.Text : "",
                    RuleRight = cbRuleRight.Checked ? tbRuleRight.Text : "",
                    RulesFiles = cbRulesFiles.Checked ? new List<string>(tbRulesFiles.Text.Split(','))
                                                                            : new List<string>(),
                    GenerateRules = cbGenerateRules.Checked ? (int)nudGenerateRules.Value : -1,
                    GenerateRulesFuncMin = cbGenerateRulesFuncMin.Checked ? (int)nudGenerateRulesFuncMin.Value : -1,
                    GenerateRulesFuncMax = cbGenerateRulesFuncMax.Checked ? (int)nudGenerateRulesFuncMax.Value : -1,
                    GenerateRulesSeed = cbGenerateRulesSeed.Checked ? (int)nudGenerateRulesSeed.Value : -1
                };
            }
            set
            {
                if (string.IsNullOrEmpty(value.RuleLeft))
                {
                    cbRuleLeft.Checked = false;
                }
                else
                {
                    cbRuleLeft.Checked = true;
                    tbRuleLeft.Text = value.RuleLeft;
                }

                if (string.IsNullOrEmpty(value.RuleRight))
                {
                    cbRuleRight.Checked = false;
                }
                else
                {
                    cbRuleRight.Checked = true;
                    tbRuleRight.Text = value.RuleRight;
                }

                if (value.RulesFiles.Count == 0)
                {
                    cbRulesFiles.Checked = false;
                }
                else
                {
                    cbRulesFiles.Checked = true;
                    tbRulesFiles.Text = string.Join(",", value.RulesFiles);
                }

                if (value.GenerateRules == -1)
                {
                    cbGenerateRules.Checked = false;
                }
                else
                {
                    cbGenerateRules.Checked = true;
                    nudGenerateRules.Value = value.GenerateRules;
                }

                if (value.GenerateRulesFuncMin == -1)
                {
                    cbGenerateRulesFuncMin.Checked = false;
                }
                else
                {
                    cbGenerateRulesFuncMin.Checked = true;
                    nudGenerateRulesFuncMin.Value = value.GenerateRulesFuncMin;
                }

                if (value.GenerateRulesFuncMax == -1)
                {
                    cbGenerateRulesFuncMax.Checked = false;
                }
                else
                {
                    cbGenerateRulesFuncMax.Checked = true;
                    nudGenerateRulesFuncMax.Value = value.GenerateRulesFuncMax;
                }

                if (value.GenerateRulesSeed == -1)
                {
                    cbGenerateRulesSeed.Checked = false;
                }
                else
                {
                    cbGenerateRulesSeed.Checked = true;
                    nudGenerateRulesSeed.Value = value.GenerateRulesSeed;
                }
            }
        }
        public ICrackDataSource CrackDataSource
        {
            get
            {
                ICrackDataSource singleSource = null;

                if (!(
                        (string.IsNullOrEmpty(cmbLeftSource.Text))
                        || ((rbCombination.Checked || rbDictMask.Checked || rbMaskDict.Checked)
                            && (string.IsNullOrEmpty(cmbRightSource.Text)))
                    ))
                {
                    if (rbStraight.Checked)
                    {
                        singleSource = new Dictionary(cmbLeftSource.Text);
                    }
                    else if (rbBruteforce.Checked)
                    {
                        singleSource = new Mask(cmbLeftSource.Text)
                        {
                            CharsetsSettings = Charsets,
                            IncrementSettings = Increment
                        };
                    }
                    else if (rbCombination.Checked)
                    {
                        singleSource = new Combination(
                            new Dictionary(cmbLeftSource.Text),
                            new Dictionary(cmbRightSource.Text));
                    }
                    else if (rbDictMask.Checked)
                    {
                        singleSource = new HybridDictMask(
                            new Dictionary(cmbLeftSource.Text),
                            new Mask(cmbRightSource.Text)
                            {
                                CharsetsSettings = Charsets,
                                IncrementSettings = Increment
                            });
                    }
                    else
                    {
                        singleSource = new HybridMaskDict(
                            new Mask(cmbLeftSource.Text)
                            {
                                CharsetsSettings = Charsets,
                                IncrementSettings = Increment
                            },
                            new Dictionary(cmbRightSource.Text));
                    }
                }

                return singleSource;
            }
        }

        public TaskEditorForm()
        {
            InitializeComponent();
        }
        public TaskEditorForm(CrackTask source)
        {
            InitializeComponent();
            crackTask = source;
            lvPredefined.Enabled = false;
            FillForm();
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
        private void btnOK_Click(object sender, EventArgs e)
        {
            UpdateCrackTasks();
            DialogResult = DialogResult.OK;
            Close();
        }
        private void TaskEditorForm_Shown(object sender, EventArgs e)
        {
            FillPredefined();
            FillAttackSources();
            FillHashTypes();
        }

        private void FillForm()
        {
            if (crackTask == null)
            {
                return;
            }

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

            cmbLeftSource.Text = crackTask.CrackDataSourceLeft;
            cmbRightSource.Text = crackTask.CrackDataSourceRight;
            cmbTarget.Text = crackTask.CrackTarget;
            cmbHashType.Items.Add(crackTask.HashType);
            cmbHashType.SelectedItem = crackTask.HashType;

            Increment = (IncrementSettings)crackTask.IncrementSettings.Clone();
            Charsets = (CustomCharsetsSettings)crackTask.CustomCharsetsSettings.Clone();
            Misc = (MiscSettings)crackTask.MiscSettings.Clone();
            Markov = (MarkovSettings)crackTask.MarkovSettings.Clone();
            Sessions = (SessionSettings)crackTask.SessionSettings.Clone();
            Files = (FilesSettings)crackTask.FilesSettings.Clone();
            Resources = (ResourcesSettings)crackTask.ResourcesSettings.Clone();
            Distributed = (DistributedSettings)crackTask.DistributedSettings.Clone();
            Rules = (RulesSettings)crackTask.RulesSettings.Clone();
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
        private void FillHashTypes()
        {
            foreach (var hashType in DataManager.HashTypes)
            {
                cmbHashType.Items.Add(hashType);
            }
        }
        private void InitCrackTask(CrackTask crackTask, ICrackDataSource withSource)
        {
            crackTask.CustomCharsetsSettings = Charsets;
            crackTask.IncrementSettings = Increment;
            crackTask.MiscSettings = Misc;
            crackTask.MarkovSettings = Markov;
            crackTask.SessionSettings = Sessions;
            crackTask.FilesSettings = Files;
            crackTask.ResourcesSettings = Resources;
            crackTask.DistributedSettings = Distributed;
            crackTask.RulesSettings = Rules;
            crackTask.CrackDataSourceLeft = withSource.Source;
            crackTask.CrackDataSourceRight = (withSource as ICombinedCrackData)?.AdditionalSource ?? "";
            crackTask.CrackTarget = cmbTarget.Text;
            crackTask.HashType = (HashType)cmbHashType.SelectedItem
                ?? new HashType(cmbHashType.Text, int.Parse(cmbHashType.Text));
        }

        private void UpdateCrackTasks()
        {
            ICrackDataSource singleSource = CrackDataSource;

            if (crackTask != null)
            {
                InitCrackTask(crackTask, singleSource);
            }

            crackTasks.Clear();

            var sources = (from item in lvPredefined.Items.Cast<ListViewItem>()
                           where item.Checked
                           select item.Tag as ICrackDataSource).ToList();

            if (singleSource != null)
            {
                sources.Add(singleSource);
            }

            if (sources.Count > 0)
            {
                foreach (var source in sources)
                {
                    CrackTask crackTask = new CrackTask();
                    InitCrackTask(crackTask, source);
                    crackTasks.Add(crackTask);
                }
            }
        }
    }
}
