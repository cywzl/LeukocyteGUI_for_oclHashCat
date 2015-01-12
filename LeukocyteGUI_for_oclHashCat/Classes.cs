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
    class Converter : System.Diagnostics.Process
    {
        public string OutPath = "/";
        public string ConverterFileName = "aircrack-ng.exe";
        private bool result = false;

        public Converter(string OutPath, string ConverterFileName)
            : this()
        {
            this.OutPath = OutPath;
            this.ConverterFileName = ConverterFileName;
        }

        public Converter()
        {
            StartInfo.UseShellExecute = false;
            StartInfo.CreateNoWindow = true;
            StartInfo.RedirectStandardOutput = true;
            OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(converter_OutputDataReceived);
        }

        private void converter_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if ((!String.IsNullOrEmpty(e.Data)) && (e.Data.Contains("Successfully written")))
            {
                this.result = true;
            }
        }

        public bool Convert(string fName)
        {
            result = false;

            StartInfo.FileName = "\"" + ConverterFileName + "\"";
            StartInfo.Arguments = '"' + fName + '"' + " -J " + "\"" + OutPath + "\""
                + System.IO.Path.GetFileNameWithoutExtension(fName);
            Start();
            BeginOutputReadLine();
            WaitForExit();
            CancelOutputRead();
            Application.DoEvents();

            return result;
        }
    }

    public class CrackTaskManager
    {
        public CrackTask[] CrackTasks;
        public CrackManager Cracker;

        public delegate void TaskAddedDeletedUpdatedEventHandler(object sender, int TaskId);
        public delegate void TasksAllDeletedEventHandler(object sender);
        public delegate void TaskMovedToStartEnd(object sender, int OriginalId, int NewId);

        public event TaskAddedDeletedUpdatedEventHandler TaskAdded = delegate { };
        public event TaskAddedDeletedUpdatedEventHandler TaskDeleted = delegate { };
        public event TaskAddedDeletedUpdatedEventHandler TaskUpdated = delegate { };
        public event TasksAllDeletedEventHandler TasksAllDeleted = delegate { };
        public event TaskMovedToStartEnd TaskMovedToStart = delegate { };
        public event TaskMovedToStartEnd TaskMovedToEnd = delegate { };

        public CrackTaskManager()
        {
            CrackTasks = new CrackTask[0];
            Cracker = new CrackManager(this);
        }

        public int AddTask(CrackTask NewCrackTask)
        {
            Array.Resize<CrackTask>(ref CrackTasks, CrackTasks.Length + 1);
            CrackTasks[CrackTasks.Length - 1] = NewCrackTask;
            TaskAdded(this, CrackTasks.Length - 1);
            return CrackTasks.Length;
        }

        public bool UpdateTask(int Index, CrackTask UpdatedCrackTask)
        {
            bool result = false;

            if ((Index < CrackTasks.Length - 1) && (Index > 0))
            {
                CrackTasks[Index] = UpdatedCrackTask;
                TaskUpdated(this, Index);
                result = true;
            }

            return result;
        }

        public int DeleteTask(int Index)
        {
            if ((Index < CrackTasks.Length) && (Index > -1))
            {
                for (int i = Index; i < CrackTasks.Length - 1; i++)
                {
                    CrackTasks[i] = CrackTasks[i + 1];
                }
            }

            Array.Resize<CrackTask>(ref CrackTasks, CrackTasks.Length - 1);
            TaskDeleted(this, Index);

            return CrackTasks.Length;
        }

        public int DeleteLastTask()
        {
            return DeleteTask(CrackTasks.Length - 1);
        }

        public void DeleteAllTasks()
        {
            CrackTasks = new CrackTask[0];
            TasksAllDeleted(this);
        }

        public int TaskMoveToStart(int Index)
        {
            int result = Index;

            if ((Index > 0) && (Index < CrackTasks.Length))
            {
                CrackTask buffer = CrackTasks[Index];

                CrackTasks[Index] = CrackTasks[Index - 1];
                CrackTasks[Index - 1] = buffer;
                result = Index - 1;
            }

            TaskMovedToStart(this, Index, result);
            return result;
        }

        public int TaskMoveToEnd(int Index)
        {
            int result = Index;

            if ((Index > -1) && (Index < CrackTasks.Length - 1))
            {
                CrackTask buffer = CrackTasks[Index];

                CrackTasks[Index] = CrackTasks[Index + 1];
                CrackTasks[Index + 1] = buffer;
                result = Index + 1;
            }

            TaskMovedToStart(this, Index, result);
            return result;
        }

        public class CrackTask
        {
            private string sHashTypeName, sBruteforceMask, sSeparator,
                sCharset1, sCharset2, sCharset3, sCharset4, sDictionary, sOutputFileName,
                sOutputFormatName, sSessionId, sWorkloadProfileName, sPlain, sHash,
                sStatus;
            private int sHashTypeCode, sWorkloadFineTuning = 8;
            private byte sWorkloadProfileCode, sOutputFormatCode, sStartLength, sMaxLength,
                sWorkloadTuning, sAbortTemp, sRetainTemp, sAttackType, sCurrentLength;
            public float Progress;
            public int Digests, RecoveredDigests, Salts, RecoveredSalts;
            public string Estimated;
            public DateTime Started, Finished;
            public bool UseCharset1, UseCharset2, UseCharset3, UseCharset4,
                EnableIncrementMode, EnableGPUAsync, EnableSpecificWorkloadProfile,
                EnableWorkloadTuning, EnableWorkloadFineTuning, DisableTempReading,
                AbortSessionIfReachesMaxTemp, TryToRetain, DisableAutoPowertuning,
                CharsetIsInHex, SaltIsInHex, IgnoreWarnings, EnableLoopback,
                IgnoreUsernames, RemoveCrackedHashes, DisablePotfile, DisableLogfile,
                OutputToFile, Restore;

            public CrackTask DeepCopy()
            {
                CrackTask CrackTaskCopy = (CrackTask)this.MemberwiseClone();
                return CrackTaskCopy;
            }

            public string HashTypeName
            {
                get
                {
                    return sHashTypeName;
                }
            }

            public string BruteforceMask
            {
                get
                {
                    return sBruteforceMask;
                }
            }

            public string Separator
            {
                get
                {
                    return sSeparator;
                }
            }

            public string Charset1
            {
                get
                {
                    return sCharset1;
                }
            }

            public string Charset2
            {
                get
                {
                    return sCharset2;
                }
            }

            public string Charset3
            {
                get
                {
                    return sCharset3;
                }
            }

            public string Charset4
            {
                get
                {
                    return sCharset4;
                }
            }

            public string Dictionary
            {
                get
                {
                    return sDictionary;
                }
            }

            public string OutputFileName
            {
                get
                {
                    return sOutputFileName;
                }
            }

            public string OutputFormatName
            {
                get
                {
                    return sOutputFormatName;
                }
            }

            public string SessionId
            {
                get
                {
                    return sSessionId;
                }
            }

            public string WorkloadProfileName
            {
                get
                {
                    return sWorkloadProfileName;
                }
            }

            public string Plain
            {
                get
                {
                    return sPlain;
                }
            }

            public string Hash
            {
                get
                {
                    return sHash;
                }
            }

            public string Status
            {
                get
                {
                    return sStatus;
                }

                set
                {
                    sStatus = value;
                }
            }

            public int HashTypeCode
            {
                get
                {
                    return sHashTypeCode;
                }
            }

            public int WorkloadFineTuning
            {
                get
                {
                    return sWorkloadFineTuning;
                }
            }

            public byte WorkloadProfileCode
            {
                get
                {
                    return sWorkloadProfileCode;
                }
            }

            public byte OutputFormatCode
            {
                get
                {
                    return sOutputFormatCode;
                }
            }

            public byte StartLength
            {
                get
                {
                    return sStartLength;
                }
            }

            public byte MaxLength
            {
                get
                {
                    return sMaxLength;
                }
            }

            public byte WorkloadTuning
            {
                get
                {
                    return sWorkloadTuning;
                }
            }

            public byte AbortTemp
            {
                get
                {
                    return sAbortTemp;
                }
            }

            public byte RetainTemp
            {
                get
                {
                    return sRetainTemp;
                }
            }

            public byte AttackType
            {
                get
                {
                    return sAttackType;
                }
            }

            public byte CurrentLength
            {
                get
                {
                    return sCurrentLength;
                }

                set
                {
                    sCurrentLength = value;
                }
            }

            public bool SetHash(string HashFileName, bool ShowErrorMessages = false)
            {
                bool result = false;

                if (HashFileName == "")
                {
                    MessageBox.Show("You must specify hash or hashfile to crack", "Error");
                }
                else
                {
                    if (HashFileName.Contains('.') || HashFileName.Contains('/') || HashFileName.Contains(@"\"))
                    {
                        if (System.IO.File.Exists(HashFileName))
                        {
                            result = true;
                            this.sHash = HashFileName;
                        }
                        else
                        {
                            if (ShowErrorMessages)
                            {
                                if (MessageBox.Show("Hash file does not exist. Continue anyway?",
                                    "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    result = true;
                                    this.sHash = HashFileName;
                                }
                            }
                        }
                    }
                    else
                    {
                        result = true;
                        this.sHash = HashFileName;
                    }
                }

                return result;
            }

            public bool SetHashTypeName(string HashTypeName)
            {
                this.sHashTypeName = HashTypeName;
                return true;
            }

            public bool SetBruteforceMask(string BruteforceMask)
            {
                this.sBruteforceMask = BruteforceMask;
                return true;
            }

            public bool SetSeparator(string Separator)
            {
                this.sSeparator = Separator;
                return true;
            }

            public bool SetCharset1(string Charset1)
            {
                this.sCharset1 = Charset1;
                return true;
            }

            public bool SetCharset2(string Charset2)
            {
                this.sCharset2 = Charset2;
                return true;
            }

            public bool SetCharset3(string Charset3)
            {
                this.sCharset3 = Charset3;
                return true;
            }

            public bool SetCharset4(string Charset4)
            {
                this.sCharset4 = Charset4;
                return true;
            }

            public bool SetDictionary(string Dictionary, bool ShowErrorMessages = false)
            {
                bool result = false;

                if (System.IO.File.Exists(Dictionary))
                {
                    result = true;
                }
                else
                {
                    if (ShowErrorMessages)
                    {
                        if (MessageBox.Show("Dictionary file does not exist. Continue anyway?",
                            "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            result = true;
                        }
                    }
                }

                if (result)
                {
                    this.sDictionary = Dictionary;
                }

                return result;
            }

            public bool SetOutputFileName(string OutputFileName, bool ShowErrorMessages = false)
            {
                bool result = false;

                if (OutputFileName == "")
                {
                    MessageBox.Show("Output file name cannot be empty", "Error");
                }
                else
                {
                    string OutputDirectoryName = System.IO.Path.GetDirectoryName(OutputFileName);

                    if (System.IO.Directory.Exists(OutputDirectoryName))
                    {
                        result = true;
                    }
                    else
                    {
                        if (ShowErrorMessages)
                        {
                            if (MessageBox.Show("Output directory does not exist. Create it?",
                                "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                System.IO.Directory.CreateDirectory(OutputDirectoryName).Create();

                                if (System.IO.Directory.Exists(OutputDirectoryName))
                                {
                                    result = true;
                                }
                                else
                                {
                                    MessageBox.Show("Failed to create output directory", "Error");
                                }
                            }
                        }
                    }
                }

                if (result)
                {
                    this.sOutputFileName = OutputFileName;
                }

                return result;
            }

            public bool SetOutputFormatName(string OutputFormatName)
            {
                this.sOutputFormatName = OutputFormatName;
                return true;
            }

            public bool SetSessionId(string SessionId)
            {
                this.sSessionId = SessionId;
                return true;
            }

            public bool SetWorkloadProfileName(string WorkloadProfileName)
            {
                this.sWorkloadProfileName = WorkloadProfileName;
                return true;
            }

            public bool SetHashTypeCode(int HashTypeCode)
            {
                this.sHashTypeCode = HashTypeCode;
                return true;
            }

            public bool SetWorkloadFineTuning(int WorkloadFineTuning)
            {
                this.sWorkloadFineTuning = WorkloadFineTuning;
                return true;
            }

            public bool SetWorkloadProfileCode(byte WorkloadProfileCode)
            {
                this.sWorkloadProfileCode = WorkloadProfileCode;
                return true;
            }

            public bool SetOutputFormatCode(byte OutputFormatCode)
            {
                this.sOutputFormatCode = OutputFormatCode;
                return true;
            }

            public bool SetStartLength(byte StartLength)
            {
                this.sStartLength = StartLength;
                return true;
            }

            public bool SetMaxLength(byte MaxLength)
            {
                this.sMaxLength = MaxLength;
                return true;
            }

            public bool SetWorkloadTuning(byte WorkloadTuning)
            {
                this.sWorkloadTuning = WorkloadTuning;
                return true;
            }

            public bool SetAbortTemp(byte AbortTemp)
            {
                this.sAbortTemp = AbortTemp;
                return true;
            }

            public bool SetRetainTemp(byte RetainTemp)
            {
                this.sRetainTemp = RetainTemp;
                return true;
            }

            public bool SetAttackType(byte AttackType)
            {
                this.sAttackType = AttackType;
                return true;
            }

            public string GetHashcatParams()
            {
                string result = "";

                result
                   += " --hash-type=" + sHashTypeCode.ToString()
                    + " --attack-mode=" + sAttackType.ToString()
                    + " --status"
                    + " --status-timer=" + "2"
                    + " --separator=" + sSeparator;

                if (OutputToFile)
                {
                    result
                        += " --outfile=" + sOutputFileName
                         + " --outfile-format=" + sOutputFormatCode.ToString();
                }

                if (UseCharset1)
                {
                    result += " --custom-charset1=" + sCharset1;
                }

                if (UseCharset2)
                {
                    result += " --custom-charset2=" + sCharset2;
                }

                if (UseCharset3)
                {
                    result += " --custom-charset3=" + sCharset3;
                }

                if (UseCharset4)
                {
                    result += " --custom-charset4=" + sCharset4;
                }

                if (EnableIncrementMode)
                {
                    result
                        += " --increment"
                         + " --increment-min=" + sStartLength
                         + " --increment-max=" + sMaxLength;
                }

                if (EnableGPUAsync)
                {
                    result += " --gpu-async";
                }

                if (EnableSpecificWorkloadProfile)
                {
                    result += " --workload-profile=" + sWorkloadProfileCode.ToString();
                }

                if (EnableWorkloadTuning)
                {
                    result += " --gpu-accel=" + sWorkloadTuning.ToString();
                }

                if (EnableWorkloadFineTuning)
                {
                    result += " --gpu-loops=" + sWorkloadFineTuning.ToString();
                }

                if (DisableTempReading)
                {
                    result += " --gpu-temp-disable";
                }

                if (AbortSessionIfReachesMaxTemp)
                {
                    result += " --gpu-temp-abort=" + sAbortTemp.ToString();
                }

                if (TryToRetain)
                {
                    result += " --gpu-temp-retain=" + sRetainTemp.ToString();
                }

                if (DisableAutoPowertuning)
                {
                    result += " --powertune-disable";
                }

                if (CharsetIsInHex)
                {
                    result += " --hex-charset";
                }

                if (SaltIsInHex)
                {
                    result += " --hex-salt";
                }

                if (SaltIsInHex)
                {
                    result += " --force";
                }

                if (EnableLoopback)
                {
                    result += " --loopback";
                }

                if (IgnoreUsernames)
                {
                    result += " --username";
                }

                if (RemoveCrackedHashes)
                {
                    result += " --remove";
                }

                if (DisablePotfile)
                {
                    result += " --potfile-disable";
                }

                if (DisableLogfile)
                {
                    result += " --logfile-disable";
                }

                result += " --session=" + sSessionId;

                if (Restore)
                {
                    result += " --restore";
                }

                result += " " + sHash;

                switch (sAttackType)
                {
                    case 0:
                        result += " " + sDictionary;
                        break;
                    case 3:
                        result += " " + sBruteforceMask;
                        break;
                }

                return result;
            }
        }

        public class CrackManager : System.Diagnostics.Process
        {
            private CrackTaskManager sCrackTaskManager;
            private int sCrackingTaskId;
            private System.Timers.Timer sTimer;

            public delegate void StartedCrackingStoppedEventHandler(object sender, int TaskId);

            public event StartedCrackingStoppedEventHandler BeforeStart = delegate { };
            public event StartedCrackingStoppedEventHandler OnStart = delegate { };
            public event StartedCrackingStoppedEventHandler OnCracking = delegate { };
            public event StartedCrackingStoppedEventHandler OnStop = delegate { };

            public CrackManager(CrackTaskManager tskManager)
            {
                sTimer = new System.Timers.Timer(2000);
                sTimer.Elapsed += sTimer_Elapsed;
                sCrackTaskManager = tskManager;
                StartInfo.UseShellExecute = false;
                StartInfo.CreateNoWindow = true;
                StartInfo.RedirectStandardOutput = true;
                EnableRaisingEvents = true;
                OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(Cracker_OutputDataReceived);
                Exited += new EventHandler(Cracker_Exited);
            }

            public double OnCrackInterval
            {
                get
                {
                    return sTimer.Interval;
                }

                set
                {
                    if (value > 0)
                    {
                        sTimer.Interval = value;
                    }
                }
            }

            void sTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
            {
                OnCracking(this, sCrackingTaskId);
            }

            public void Crack(int TaskId)
            {
                BeforeStart(this, sCrackingTaskId);

                sCrackingTaskId = TaskId;

                if (sCrackTaskManager.CrackTasks[TaskId].Started == DateTime.MinValue)
                {
                    sCrackTaskManager.CrackTasks[TaskId].Started = DateTime.Now;
                }

                try
                {
                    sCrackTaskManager.CrackTasks[sCrackingTaskId].Restore = true;
                    StartInfo.Arguments = sCrackTaskManager.CrackTasks[sCrackingTaskId].GetHashcatParams();
                    Start();
                    BeginOutputReadLine();
                    OnStart(this, sCrackingTaskId);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred trying to crack Task #"+ TaskId.ToString() + ":\n" + e.Message);
                }
            }

            private void Cracker_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
            {
                //todo
            }

            private void Cracker_Exited(object sender, System.EventArgs e)
            {
                sTimer.Stop();
            }

            public bool SetHashcat(string Hashcat, bool ShowErrorMessages = false)
            {
                bool result = false;

                if (System.IO.File.Exists(Hashcat))
                {
                    StartInfo.FileName = Hashcat;
                    result = true;
                }
                else if (ShowErrorMessages)
                {
                    if (MessageBox.Show("Specified hashcat.exe does not exist. Continue anyway (not recommended)?",
                        "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        StartInfo.FileName = Hashcat;
                        result = true;
                    }
                }

                return result;
            }
        }
    }
}
