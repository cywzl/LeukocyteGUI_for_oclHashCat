using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LeukocyteGUI_for_oclHashCat
{
    public class Converter : System.Diagnostics.Process
    {
        private bool result = false;

        public string OutPath { get; set; }
        public string ConverterFileName { get; set; }

        public Converter(string OutPath = "/", string ConverterFileName = "aircrack-ng.exe")
        {
            this.OutPath = OutPath;
            this.ConverterFileName = ConverterFileName;
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

        public CrackTaskManager(CrackTask[] crackTasks)
        {
            CrackTasks = crackTasks;
            Cracker = new CrackManager(this);
        }
        public CrackTaskManager() : this(new CrackTask[0]) { }

        public int AddTasks(CrackTask[] NewCrackTasks)
        {
            for (int index = 0; index < NewCrackTasks.Length; index++)
            {
                AddTask(NewCrackTasks[index]);
            }

            return CrackTasks.Length;
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

            if ((Index < CrackTasks.Length) && (Index > -1))
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

            if (Cracker.LastCrackingTaskId == Index)
            {
                Cracker.LastCrackingTaskId = -1;
            }

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
            Cracker.LastCrackingTaskId = -1;
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

            if (Cracker.LastCrackingTaskId == Index)
            {
                Cracker.LastCrackingTaskId = result;
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

            if (Cracker.LastCrackingTaskId == Index)
            {
                Cracker.LastCrackingTaskId = result;
            }

            TaskMovedToStart(this, Index, result);
            return result;
        }

        [Serializable()]
        public class CrackTask
        {
            private string hashTypeName;
            private string bruteforceMask;
            private string separator;
            private string charset1;
            private string charset2;
            private string charset3;
            private string charset4;
            private string dictionary;
            private string outputFileName;
            private string outputFormatName;
            private string sessionId;
            private string workloadProfileName;
            private string plain;
            private string hash;
            private string status;
            private int hashTypeCode;
            private int workloadFineTuning = 8;
            private ulong restorePosition;
            private ulong keyspace;
            private byte workloadProfileCode;
            private byte outputFormatCode;
            private byte startLength;
            private byte currentLength;
            private byte maxLength;
            private byte workloadTuning;
            private byte abortTemp;
            private byte retainTemp;
            private byte attackType;

            public string HashTypeName
            {
                get
                {
                    return hashTypeName;
                }
            }
            public string BruteforceMask
            {
                get
                {
                    return bruteforceMask;
                }
            }
            public string Separator
            {
                get
                {
                    return separator;
                }
            }
            public string Charset1
            {
                get
                {
                    return charset1;
                }
            }
            public string Charset2
            {
                get
                {
                    return charset2;
                }
            }
            public string Charset3
            {
                get
                {
                    return charset3;
                }
            }
            public string Charset4
            {
                get
                {
                    return charset4;
                }
            }
            public string Dictionary
            {
                get
                {
                    return dictionary;
                }
            }
            public string OutputFileName
            {
                get
                {
                    return outputFileName;
                }
            }
            public string OutputFormatName
            {
                get
                {
                    return outputFormatName;
                }
            }
            public string SessionId
            {
                get
                {
                    return sessionId;
                }
            }
            public string WorkloadProfileName
            {
                get
                {
                    return workloadProfileName;
                }
            }
            public string Plain
            {
                get
                {
                    return plain;
                }

                set
                {
                    plain = value;
                }
            }
            public string Hash
            {
                get
                {
                    return hash;
                }
            }
            public string Status
            {
                get
                {
                    return status;
                }

                set
                {
                    status = value;
                }
            }
            public string Estimated { get; set; }
            public int HashTypeCode
            {
                get
                {
                    return hashTypeCode;
                }
            }
            public int WorkloadFineTuning
            {
                get
                {
                    return workloadFineTuning;
                }
            }
            public int Digests { get; set; }
            public int RecoveredDigests { get; set; }
            public int Salts { get; set; }
            public int RecoveredSalts { get; set; }
            public ulong RestorePosition
            {
                get
                {
                    return restorePosition;
                }

                set
                {
                    restorePosition = value;
                }
            }
            public ulong Keyspace
            {
                get
                {
                    return keyspace;
                }

                set
                {
                    keyspace = value;
                }
            }
            public float Progress { get; set; }
            public byte WorkloadProfileCode
            {
                get
                {
                    return workloadProfileCode;
                }
            }
            public byte OutputFormatCode
            {
                get
                {
                    return outputFormatCode;
                }
            }
            public byte StartLength
            {
                get
                {
                    return startLength;
                }
            }
            public byte MaxLength
            {
                get
                {
                    return maxLength;
                }
            }
            public byte WorkloadTuning
            {
                get
                {
                    return workloadTuning;
                }
            }
            public byte AbortTemp
            {
                get
                {
                    return abortTemp;
                }
            }
            public byte RetainTemp
            {
                get
                {
                    return retainTemp;
                }
            }
            public byte AttackType
            {
                get
                {
                    return attackType;
                }
            }
            public byte CurrentLength
            {
                get
                {
                    return currentLength;
                }

                set
                {
                    currentLength = value;
                }
            }
            public bool UseCharset1 { get; set; }
            public bool UseCharset2 { get; set; }
            public bool UseCharset3 { get; set; }
            public bool UseCharset4 { get; set; }
            public bool EnableIncrementMode { get; set; }
            public bool EnableGPUAsync { get; set; }
            public bool EnableSpecificWorkloadProfile { get; set; }
            public bool EnableWorkloadTuning { get; set; }
            public bool EnableWorkloadFineTuning { get; set; }
            public bool DisableTempReading { get; set; }
            public bool AbortSessionIfReachesMaxTemp { get; set; }
            public bool TryToRetain { get; set; }
            public bool DisableAutoPowertuning { get; set; }
            public bool CharsetIsInHex { get; set; }
            public bool SaltIsInHex { get; set; }
            public bool IgnoreWarnings { get; set; }
            public bool EnableLoopback { get; set; }
            public bool IgnoreUsernames { get; set; }
            public bool RemoveCrackedHashes { get; set; }
            public bool DisablePotfile { get; set; }
            public bool DisableLogfile { get; set; }
            public bool OutputToFile { get; set; }
            public bool Restore { get; set; }
            public DateTime Started { get; set; }
            public DateTime Finished { get; set; }

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
                            this.hash = HashFileName;
                        }
                        else
                        {
                            if (ShowErrorMessages)
                            {
                                if (MessageBox.Show("Hash file does not exist. Continue anyway?",
                                    "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    result = true;
                                    this.hash = HashFileName;
                                }
                            }
                        }
                    }
                    else
                    {
                        result = true;
                        this.hash = HashFileName;
                    }
                }

                return result;
            }
            public bool SetHashTypeName(string HashTypeName)
            {
                this.hashTypeName = HashTypeName;
                return true;
            }
            public bool SetBruteforceMask(string BruteforceMask)
            {
                this.bruteforceMask = BruteforceMask;
                return true;
            }
            public bool SetSeparator(string Separator)
            {
                this.separator = Separator;
                return true;
            }
            public bool SetCharset1(string Charset1)
            {
                this.charset1 = Charset1;
                return true;
            }
            public bool SetCharset2(string Charset2)
            {
                this.charset2 = Charset2;
                return true;
            }
            public bool SetCharset3(string Charset3)
            {
                this.charset3 = Charset3;
                return true;
            }
            public bool SetCharset4(string Charset4)
            {
                this.charset4 = Charset4;
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
                    this.dictionary = Dictionary;
                }

                return result;
            }
            public bool SetOutputFileName(string OutputFileName, bool ShowErrorMessages = false)
            {
                bool result = false;

                if (OutputFileName == "")
                {
                    if (ShowErrorMessages)
                    {
                        MessageBox.Show("Output file name cannot be empty", "Error");
                    }
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
                    this.outputFileName = OutputFileName;
                }

                return result;
            }
            public bool SetOutputFormatName(string OutputFormatName)
            {
                this.outputFormatName = OutputFormatName;
                return true;
            }
            public bool SetSessionId(string SessionId)
            {
                this.sessionId = SessionId;
                return true;
            }
            public bool SetWorkloadProfileName(string WorkloadProfileName)
            {
                this.workloadProfileName = WorkloadProfileName;
                return true;
            }
            public bool SetHashTypeCode(int HashTypeCode)
            {
                this.hashTypeCode = HashTypeCode;
                return true;
            }
            public bool SetWorkloadFineTuning(int WorkloadFineTuning)
            {
                this.workloadFineTuning = WorkloadFineTuning;
                return true;
            }
            public bool SetWorkloadProfileCode(byte WorkloadProfileCode)
            {
                this.workloadProfileCode = WorkloadProfileCode;
                return true;
            }
            public bool SetOutputFormatCode(byte OutputFormatCode)
            {
                this.outputFormatCode = OutputFormatCode;
                return true;
            }
            public bool SetStartLength(byte StartLength)
            {
                this.startLength = StartLength;
                return true;
            }
            public bool SetMaxLength(byte MaxLength)
            {
                this.maxLength = MaxLength;
                return true;
            }
            public bool SetWorkloadTuning(byte WorkloadTuning)
            {
                this.workloadTuning = WorkloadTuning;
                return true;
            }
            public bool SetAbortTemp(byte AbortTemp)
            {
                this.abortTemp = AbortTemp;
                return true;
            }
            public bool SetRetainTemp(byte RetainTemp)
            {
                this.retainTemp = RetainTemp;
                return true;
            }
            public bool SetAttackType(byte AttackType)
            {
                this.attackType = AttackType;
                return true;
            }

            public CrackTask DeepCopy()
            {
                CrackTask CrackTaskCopy = (CrackTask)this.MemberwiseClone();
                return CrackTaskCopy;
            }
            public string GetHashcatParams(bool GenerateKeyspace = false)
            {
                string result = "";

                result
                   += " --hash-type=" + hashTypeCode.ToString()
                    + " --attack-mode=" + attackType.ToString()
                    + " --status"
                    + " --status-timer=" + "1"
                    + " --separator=" + separator;

                if (GenerateKeyspace)
                {
                    result += " --keyspace";
                }
                else
                {
                    result += " --skip=" + restorePosition.ToString();
                }

                if (OutputToFile)
                {
                    result
                        += " --outfile=\"" + outputFileName + "\""
                         + " --outfile-format=" + outputFormatCode.ToString();
                }

                if (UseCharset1)
                {
                    result += " --custom-charset1=" + charset1;
                }

                if (UseCharset2)
                {
                    result += " --custom-charset2=" + charset2;
                }

                if (UseCharset3)
                {
                    result += " --custom-charset3=" + charset3;
                }

                if (UseCharset4)
                {
                    result += " --custom-charset4=" + charset4;
                }

                if (EnableIncrementMode)
                {
                    result
                        += " --increment"
                         + " --increment-min=" + startLength
                         + " --increment-max=" + maxLength;
                }

                if (EnableGPUAsync)
                {
                    result += " --gpu-async";
                }

                if (EnableSpecificWorkloadProfile)
                {
                    result += " --workload-profile=" + workloadProfileCode.ToString();
                }

                if (EnableWorkloadTuning)
                {
                    result += " --gpu-accel=" + workloadTuning.ToString();
                }

                if (EnableWorkloadFineTuning)
                {
                    result += " --gpu-loops=" + workloadFineTuning.ToString();
                }

                if (DisableTempReading)
                {
                    result += " --gpu-temp-disable";
                }

                if (AbortSessionIfReachesMaxTemp)
                {
                    result += " --gpu-temp-abort=" + abortTemp.ToString();
                }

                if (TryToRetain)
                {
                    result += " --gpu-temp-retain=" + retainTemp.ToString();
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

                result += " --session=" + sessionId;

                if (hash.Contains('.') || hash.Contains('/') || hash.Contains(@"\"))
                {
                    result += " \"" + hash + "\"";
                }
                else
                {
                    result += " " + hash;
                }

                switch (attackType)
                {
                    case 0:
                        result += " \"" + dictionary + "\"";
                        break;
                    case 3:
                        result += " " + bruteforceMask;
                        break;
                }

                return result;
            }
        }

        public class CrackManager : System.Diagnostics.Process
        {
            private CrackTaskManager crackTaskManager;
            private CrackTask crackingTask;
            private CultureInfo culture;
            private int crackingTaskId = -1;
            private int lastCrackingTaskId = -1;
            private bool isCracking;
            private bool isCalculatingKeyspace;

            public string Speed { get; set; }
            public byte Util { get; set; }
            public byte Temp { get; set; }
            public byte Fan { get; set; }
            public int CrackingTaskId
            {
                get
                {
                    return crackingTaskId;
                }
            }
            public int LastCrackingTaskId
            {
                get
                {
                    return lastCrackingTaskId;
                }

                set
                {
                    lastCrackingTaskId = value;
                }
            }
            public bool IsCracking
            {
                get
                {
                    return isCracking;
                }
            }
            public bool IsCalculatingKeyspace
            {
                get
                {
                    return isCalculatingKeyspace;
                }
            }

            public delegate void StartedCrackingStoppedEventHandler(object sender, int TaskId);

            public event StartedCrackingStoppedEventHandler BeforeStart = delegate { };
            public event StartedCrackingStoppedEventHandler OnStart = delegate { };
            public event StartedCrackingStoppedEventHandler OnStop = delegate { };
            public event StartedCrackingStoppedEventHandler OnManualStop = delegate { };
            public event StartedCrackingStoppedEventHandler OnManualPause = delegate { };
            public event StartedCrackingStoppedEventHandler OnCracking = delegate { };

            public CrackManager(CrackTaskManager tskManager)
            {
                Speed = "0";
                Util = 0;
                Temp = 0;
                Fan = 0;
                culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                culture.NumberFormat.CurrencyDecimalSeparator = ".";
                crackTaskManager = tskManager;
                StartInfo.UseShellExecute = false;
                StartInfo.CreateNoWindow = true;
                StartInfo.RedirectStandardOutput = true;
                EnableRaisingEvents = true;
                OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(Cracker_OutputDataReceived);
                ErrorDataReceived += new System.Diagnostics.DataReceivedEventHandler(Cracker_OutputDataReceived);
                Exited += new EventHandler(Cracker_Exited);
                crackTaskManager.TaskMovedToEnd += sCrackTaskManager_TaskMovedToEnd;
                crackTaskManager.TaskMovedToStart += sCrackTaskManager_TaskMovedToStart;
                crackTaskManager.TaskDeleted += sCrackTaskManager_TaskDeleted;
            }

            private void sCrackTaskManager_TaskDeleted(object sender, int TaskId)
            {
                if ((TaskId < crackingTaskId) && (crackingTaskId > -1))
                {
                    crackingTaskId--;
                    crackingTask = crackTaskManager.CrackTasks[crackingTaskId];
                }
            }
            private void sCrackTaskManager_TaskMovedToStart(object sender, int OriginalId, int NewId)
            {
                if (crackingTaskId == OriginalId)
                {
                    crackingTaskId = NewId;
                    crackingTask = crackTaskManager.CrackTasks[crackingTaskId];
                }
                else if (crackingTaskId == NewId)
                {
                    crackingTaskId = OriginalId;
                    crackingTask = crackTaskManager.CrackTasks[crackingTaskId];
                }
            }
            private void sCrackTaskManager_TaskMovedToEnd(object sender, int OriginalId, int NewId)
            {
                if (crackingTaskId == OriginalId)
                {
                    crackingTaskId = NewId;
                    crackingTask = crackTaskManager.CrackTasks[crackingTaskId];
                }
                else if (crackingTaskId == NewId)
                {
                    crackingTaskId = OriginalId;
                    crackingTask = crackTaskManager.CrackTasks[crackingTaskId];
                }
            }
            private void Cracker_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
            {
                if (e.Data != null)
                {
                    if (isCalculatingKeyspace)
                    {
                        uint rp;

                        if (uint.TryParse(e.Data, out rp))
                        {
                            crackingTask.Keyspace = rp;
                        }

                        return;
                    }

                    string[] parameters = e.Data.Split(':');

                    if (parameters.Length > 1)
                    {
                        parameters[1] = parameters[1].Trim();

                        switch (parameters[0])
                        {
                            case "Status.........":
                                {
                                    crackingTask.Status = parameters[1];

                                    break;
                                }
                            case "Input.Mode.....":
                                {
                                    byte start = (byte)(parameters[1].IndexOf('[') + 1);
                                    byte length = (byte)(parameters[1].IndexOf(']') - start);

                                    if ((start > 0) && (length > 0) && (length < 255))
                                    {
                                        crackingTask.CurrentLength = byte.Parse(parameters[1].Substring(start, length));
                                    }

                                    break;
                                }
                            case "Time.Started...":
                                {
                                    break;
                                }
                            case "Time.Estimated.":
                                {
                                    if (parameters.Length > 3)
                                    {
                                        byte start = (byte)(parameters[3].IndexOf('(') + 1);
                                        byte length = (byte)(parameters[3].IndexOf(')') - start);

                                        if ((start > 0) && (length > 0) && (length < 255))
                                        {
                                            crackingTask.Estimated = parameters[3].Substring(start, length);
                                        }
                                    }

                                    break;
                                }
                            case "Speed.GPU.#1...":
                                {
                                    Speed = parameters[1];

                                    break;
                                }
                            case "Recovered......":
                                {
                                    string[] recovered = parameters[1].Split(',');
                                    byte slashPos;
                                    byte spacePos;

                                    recovered[1] = recovered[1].Trim();

                                    slashPos = (byte)recovered[0].IndexOf('/');
                                    spacePos = (byte)recovered[0].IndexOf(' ');
                                    crackingTask.RecoveredDigests = int.Parse(recovered[0].Substring(0, slashPos));
                                    crackingTask.Digests = int.Parse(recovered[0].Substring(slashPos + 1,
                                        spacePos - slashPos - 1));

                                    slashPos = (byte)recovered[1].IndexOf('/');
                                    spacePos = (byte)recovered[1].IndexOf(' ');
                                    crackingTask.RecoveredSalts = int.Parse(recovered[1].Substring(0, slashPos));
                                    crackingTask.Salts = int.Parse(recovered[1].Substring(slashPos + 1,
                                        spacePos - slashPos - 1));

                                    break;
                                }
                            case "Progress.......":
                                {
                                    byte start = (byte)(parameters[1].IndexOf('(') + 1);
                                    byte length = (byte)(parameters[1].IndexOf('%') - start);

                                    crackingTask.Progress = float.Parse(parameters[1].Substring(start, length),
                                        NumberStyles.Any, culture);

                                    break;
                                }
                            case "HWMon.GPU.#1...":
                                {
                                    string[] monitors = parameters[1].Split(',');

                                    monitors[0] = monitors[0].Trim();
                                    monitors[1] = monitors[1].Trim();
                                    monitors[2] = monitors[2].Trim();

                                    Util = byte.Parse(monitors[0].Substring(0, monitors[0].IndexOf('%')));
                                    Temp = byte.Parse(monitors[1].Substring(0, monitors[1].IndexOf('c')));
                                    Fan = byte.Parse(monitors[2].Substring(0, monitors[2].IndexOf('%')));

                                    break;
                                }
                            default:
                                {
                                    if ((parameters[0] == crackingTask.Hash)
                                        || ((crackingTask.HashTypeCode == 2500) && (parameters.Length == 4)
                                           && (parameters[0] != "Started") && (parameters[0] != "Stopped")))
                                    {
                                        crackingTask.Plain = parameters[parameters.Length - 1];
                                    }

                                    break;
                                }
                        }
                    }
                }

                if (crackingTaskId != -1)
                {
                    OnCracking(this, crackingTaskId);
                }
                else if (lastCrackingTaskId != -1)
                {
                    OnCracking(this, lastCrackingTaskId);
                }
            }
            private void Cracker_Exited(object sender, System.EventArgs e)
            {
                if (crackingTaskId != -1)
                {
                    if ((ExitCode != 0) && (crackingTask.Status == "Running"))
                    {
                        if (crackingTask.Restore)
                        {
                            crackingTask.Status = "Paused";
                        }
                        else
                        {
                            crackingTask.Status = "Stopped";
                        }
                    }

                    if (crackingTask.Restore)
                    {
                        crackingTask.RestorePosition = (uint)(crackingTask.Keyspace * crackingTask.Progress / 100);
                    }
                    else
                    {
                        crackingTask.RestorePosition = 0;
                    }

                    lastCrackingTaskId = crackingTaskId;
                }

                CancelOutputRead();
                Close();

                if (isCalculatingKeyspace)
                {
                    isCalculatingKeyspace = false;
                    crackingTask.Restore = true;
                    Crack(crackingTaskId);
                }
                else
                {
                    Temp = 0;
                    Util = 0;
                    Fan = 0;
                    Speed = "0 h/s";
                    isCracking = false;
                    crackingTask.Finished = DateTime.Now;
                    crackingTaskId = -1;
                    OnStop(this, lastCrackingTaskId);
                }
            }

            public void Crack(int TaskId)
            {
                BeforeStart(this, TaskId);

                crackingTaskId = TaskId;
                crackingTask = crackTaskManager.CrackTasks[TaskId];

                if (crackTaskManager.CrackTasks[TaskId].Started == DateTime.MinValue)
                {
                    crackTaskManager.CrackTasks[TaskId].Started = DateTime.Now;
                }

                try
                {
                    if (!crackingTask.Restore)
                    {
                        isCalculatingKeyspace = true;
                        crackingTask.RestorePosition = 0;
                        StartInfo.Arguments = crackingTask.GetHashcatParams(true);
                        Start();
                        BeginOutputReadLine();
                        crackingTask.Status = "Calculating keyspace";
                    }
                    else
                    {
                        StartInfo.Arguments = crackingTask.GetHashcatParams();
                        Start();
                        BeginOutputReadLine();
                        isCracking = true;
                        crackingTask.Restore = true;
                        crackingTask.Status = "Cracking";
                    }

                    OnStart(this, crackingTaskId);
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error occurred trying to crack Task #" + (TaskId + 1).ToString() + ":\n" + e.Message);
                }
            }
            public void PauseCracking()
            {
                if (isCracking)
                {
                    crackingTask.Status = "Paused";
                    crackingTask.Restore = true;
                    Kill();
                    OnManualPause(this, crackingTaskId);
                }
            }
            public void StopCracking(int TaskId)
            {
                if ((TaskId > -1)
                    && (TaskId < crackTaskManager.CrackTasks.Length))
                {
                    CrackTask tsk = crackTaskManager.CrackTasks[TaskId];
                    tsk.Status = "Stopped";
                    tsk.Plain = "";
                    tsk.Progress = 0;
                    tsk.Restore = false;
                    tsk.CurrentLength = 0;
                    tsk.RecoveredDigests = 0;
                    tsk.RecoveredSalts = 0;
                    tsk.Estimated = "";
                    tsk.Started = DateTime.MinValue;
                    tsk.Finished = DateTime.MinValue;
                }

                if (isCracking)
                {
                    Kill();
                }

                OnManualStop(this, TaskId);
            }
            public void StopCracking()
            {
                StopCracking(crackingTaskId);
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
            public bool SetWorkingDirectory(string WorkingDirectory)
            {
                bool result = true;

                StartInfo.WorkingDirectory = WorkingDirectory;

                return result;
            }
        }
    }

    public class SimpleProgressBar : UserControl
    {
        private int value = 0;
        private int minimum = 0;
        private int maximum = 100;
        private string caption = "";

        public int Value
        {
            get { return value; }
            set
            {
                if (value > maximum)
                {
                    throw new ArgumentException("The value specified is greater than the value of the Maximum property.");
                }
                if (value < minimum)
                {
                    throw new ArgumentException("The value specified is less than the value of the Minimum property.");
                }

                this.value = value;
                Invalidate();
            }
        }
        public int Minimum
        {
            get { return minimum; }
            set
            {
                if (value > maximum)
                {
                    throw new ArgumentException("The value specified is greater than the value of the Maximum property.");
                }
                if (value < 0)
                {
                    throw new ArgumentException("The value specified is less than 0.");
                }

                this.minimum = value;
                Invalidate();
            }
        }
        public int Maximum
        {
            get { return maximum; }
            set
            {
                if (value < minimum)
                {
                    throw new ArgumentException("The value specified is less than the value of the Minimum property.");
                }

                this.maximum = value;
                Invalidate();
            }
        }
        public bool ShowText { get; set; }
        public string Caption
        {
            get { return caption; }
            set
            {
                caption = value;

                if (ShowText)
                {
                    Invalidate();
                }
            }
        }

        public SimpleProgressBar()
        {
            BackColor = Colors.BackColors.Default;
            ForeColor = Colors.ForeColors.Processing;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = CreateGraphics();
            string text = "";

            if (ShowText)
            {
                text = Caption;
            }

            Render(graphics, ClientRectangle, (int)100.0 * (value - minimum) / (maximum - minimum), text, BackColor, ForeColor);
        }
        public static void Render(Graphics Graph, Rectangle Rect, int Position, string Text,
            Color BackColor, Color ForeColor)
        {
            Rectangle rectProgress = new Rectangle(Rect.Left, Rect.Top, (int)Rect.Width * Position / 100, Rect.Height);

            Graph.FillRectangle(new SolidBrush(BackColor), Rect.X + 1, Rect.Y + 1, Rect.Width - 2, Rect.Height - 2);
            Graph.FillRectangle(new SolidBrush(ForeColor), rectProgress.X + 1, rectProgress.Y + 1, rectProgress.Width - 2, rectProgress.Height - 2);

            if (Text != "")
            {
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                Graph.DrawString(Text, new Font("Arial", (float)8), Brushes.Black, Rect, sf);
            }
        }
        public static void Render(Graphics Graph, Rectangle Rect, int Position, string Text = "")
        {
            Render(Graph, Rect, Position, Text, Colors.BackColors.Default, Colors.ForeColors.Processing);
        }

        public static class Colors
        {
            public struct ForeColors
            {
                public static readonly Color Processing = Color.FromArgb(132, 194, 255);
                public static readonly Color Complete = Color.FromArgb(134, 196, 63);
                public static readonly Color CompleteLight = Color.FromArgb(171, 214, 121);
                public static readonly Color Stopped = Color.FromArgb(157, 160, 163);
                public static readonly Color Failure = Color.FromArgb(255, 102, 102);
            }
            public struct BackColors
            {
                public static readonly Color Default = Color.FromArgb(235, 235, 235);
            }
        }
    }
}
