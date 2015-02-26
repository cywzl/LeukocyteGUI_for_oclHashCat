//  Copyright (C) 2015  Igor Kotlerman <igor.kotlerman@gmail.com>

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
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
            int newIndex = CrackTasks.Length - 1;

            CrackTasks[newIndex] = NewCrackTask;
            TaskAdded(this, newIndex);

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

                Array.Resize<CrackTask>(ref CrackTasks, CrackTasks.Length - 1);

                if (Cracker.LastCrackingTaskId == Index)
                {
                    Cracker.LastCrackingTaskId = -1;
                }

                TaskDeleted(this, Index);
            }

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
            int newIndex = Index;

            if ((Index < 1) || (Index >= CrackTasks.Length))
            {
                TaskMovedToStart(this, Index, Index);
                return Index;
            }

            newIndex = Index - 1;

            CrackTask buffer = CrackTasks[Index];

            CrackTasks[Index] = CrackTasks[newIndex];
            CrackTasks[newIndex] = buffer;

            if (Cracker.LastCrackingTaskId == Index)
            {
                Cracker.LastCrackingTaskId = newIndex;
            }

            TaskMovedToStart(this, Index, newIndex);
            return newIndex;
        }
        public int TaskMoveToEnd(int Index)
        {
            int newIndex = Index;

            if ((Index < 0) || (Index > CrackTasks.Length - 2))
            {
                TaskMovedToStart(this, Index, newIndex);
                return newIndex;
            }

            newIndex = Index + 1;

            CrackTask buffer = CrackTasks[Index];

            CrackTasks[Index] = CrackTasks[newIndex];
            CrackTasks[newIndex] = buffer;

            if (Cracker.LastCrackingTaskId == Index)
            {
                Cracker.LastCrackingTaskId = newIndex;
            }

            TaskMovedToStart(this, Index, newIndex);
            return newIndex;
        }

        [Serializable()]
        public class CrackTask
        {
            private string hashTypeName = "";
            private string bruteforceMask = "";
            private string separator = "";
            private string charset1 = "";
            private string charset2 = "";
            private string charset3 = "";
            private string charset4 = "";
            private string dictionary = "";
            private string outputFileName = "";
            private string outputFormatName = "";
            private string sessionId = "";
            private string workloadProfileName = "";
            private string plain = "";
            private string hash = "";
            private string status = "";
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

    public class DictionaryManager
    {
        public Dictionary[] Dictionaries;

        public DictionaryManager(Dictionary[] dictionaries)
        {
            Dictionaries = dictionaries;
        }
        public DictionaryManager() : this(new Dictionary[0]) { }

        public int AddDictionary(Dictionary newDictionary)
        {
            Array.Resize<Dictionary>(ref Dictionaries, Dictionaries.Length + 1);
            Dictionaries[Dictionaries.Length - 1] = newDictionary;
            return Dictionaries.Length;
        }
        public int AddDictionaries(Dictionary[] newDictionaries)
        {
            for (int index = 0; index < newDictionaries.Length; index++)
            {
                AddDictionary(newDictionaries[index]);
            }

            return Dictionaries.Length;
        }
        public bool UpdateDictionary(int Index, Dictionary UpdatedDictionary)
        {
            bool result = false;

            if ((Index < Dictionaries.Length) && (Index > -1))
            {
                Dictionaries[Index] = UpdatedDictionary;
                result = true;
            }

            return result;
        }
        public int DeleteDictionary(int Index)
        {
            if ((Index < Dictionaries.Length) && (Index > -1))
            {
                for (int i = Index; i < Dictionaries.Length - 1; i++)
                {
                    Dictionaries[i] = Dictionaries[i + 1];
                }
            }

            Array.Resize<Dictionary>(ref Dictionaries, Dictionaries.Length - 1);

            return Dictionaries.Length;
        }
        public int DeleteLastDictionary()
        {
            return DeleteDictionary(Dictionaries.Length - 1);
        }
        public void DeleteAllDictionaries()
        {
            Dictionaries = new Dictionary[0];
        }
        public int DictionaryMoveToStart(int Index)
        {
            int result = Index;

            if ((Index > 0) && (Index < Dictionaries.Length))
            {
                Dictionary buffer = Dictionaries[Index];

                Dictionaries[Index] = Dictionaries[Index - 1];
                Dictionaries[Index - 1] = buffer;
                result = Index - 1;
            }

            return result;
        }
        public int DictionaryMoveToEnd(int Index)
        {
            int result = Index;

            if ((Index > -1) && (Index < Dictionaries.Length - 1))
            {
                Dictionary buffer = Dictionaries[Index];

                Dictionaries[Index] = Dictionaries[Index + 1];
                Dictionaries[Index + 1] = buffer;
                result = Index + 1;
            }

            return result;
        }

        [Serializable()]
        public class Dictionary
        {
            private FileInfo fileInfo;

            public string Description { get; set; }
            public string FileName
            {
                get { return fileInfo.FullName; }
                set
                {
                    fileInfo = new FileInfo(value);
                }
            }
            public string FormattedSize
            {
                get
                {
                    int length = fileInfo.Length.ToString().Length;

                    if (length < 3)
                    {
                        return fileInfo.Length.ToString() + " B";
                    }
                    else if (length < 6)
                    {
                        return Math.Round(fileInfo.Length / 1024.0, 1).ToString() + " KB";
                    }
                    else if (length < 9)
                    {
                        return Math.Round(fileInfo.Length / 1048576.0, 1).ToString() + " MB";
                    }
                    else if (length < 12)
                    {
                        return Math.Round(fileInfo.Length / 1073741824.0, 1).ToString() + " GB";
                    }
                    else
                    {
                        return Math.Round(fileInfo.Length / 1099511627776.0, 1).ToString() + " TB";
                    }
                }
            }
            public long Size
            {
                get { return fileInfo.Length; }
            }

            public Dictionary(string fileName)
            {
                fileInfo = new FileInfo(fileName);
            }
        }
    }

    public class MaskManager
    {
        public Mask[] Masks;

        public MaskManager(Mask[] masks)
        {
            Masks = masks;
        }
        public MaskManager() : this(new Mask[0]) { }

        public int AddMask(Mask newMask)
        {
            Array.Resize<Mask>(ref Masks, Masks.Length + 1);
            Masks[Masks.Length - 1] = newMask;
            return Masks.Length;
        }
        public int AddMasks(Mask[] newMasks)
        {
            for (int index = 0; index < newMasks.Length; index++)
            {
                AddMask(newMasks[index]);
            }

            return Masks.Length;
        }
        public bool UpdateMask(int Index, Mask UpdatedMask)
        {
            bool result = false;

            if ((Index < Masks.Length) && (Index > -1))
            {
                Masks[Index] = UpdatedMask;
                result = true;
            }

            return result;
        }
        public int DeleteMask(int Index)
        {
            if ((Index < Masks.Length) && (Index > -1))
            {
                for (int i = Index; i < Masks.Length - 1; i++)
                {
                    Masks[i] = Masks[i + 1];
                }
            }

            Array.Resize<Mask>(ref Masks, Masks.Length - 1);

            return Masks.Length;
        }
        public int DeleteLastMask()
        {
            return DeleteMask(Masks.Length - 1);
        }
        public void DeleteAllMasks()
        {
            Masks = new Mask[0];
        }
        public int MaskMoveToStart(int Index)
        {
            int result = Index;

            if ((Index > 0) && (Index < Masks.Length))
            {
                Mask buffer = Masks[Index];

                Masks[Index] = Masks[Index - 1];
                Masks[Index - 1] = buffer;
                result = Index - 1;
            }

            return result;
        }
        public int MaskMoveToEnd(int Index)
        {
            int result = Index;

            if ((Index > -1) && (Index < Masks.Length - 1))
            {
                Mask buffer = Masks[Index];

                Masks[Index] = Masks[Index + 1];
                Masks[Index + 1] = buffer;
                result = Index + 1;
            }

            return result;
        }

        [Serializable()]
        public class Mask
        {
            public string BruteMask { get; set; }
            public string Charset1 { get; set; }
            public string Charset2 { get; set; }
            public string Charset3 { get; set; }
            public string Charset4 { get; set; }
            public string CharsetString
            {
                get
                {
                    string result = "";

                    if (UseCharset1)
                    {
                        result += "[1]" + Charset1;
                    }
                    if (UseCharset2)
                    {
                        result += "[2]" + Charset2;
                    }
                    if (UseCharset3)
                    {
                        result += "[3]" + Charset3;
                    }
                    if (UseCharset4)
                    {
                        result += "[4]" + Charset4;
                    }

                    return result;
                }
            }
            public string Description { get; set; }
            public byte IncrementMin { get; set; }
            public byte IncrementMax { get; set; }
            public bool EnableIncrement { get; set; }
            public bool UseCharset1 { get; set; }
            public bool UseCharset2 { get; set; }
            public bool UseCharset3 { get; set; }
            public bool UseCharset4 { get; set; }
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

    public class NotifyMessage : Component
    {
        private System.ComponentModel.IContainer components = null;
        private MessageSettings messageSettings;
        private Queue<MessageSettings> messageQueue;
        private BackgroundWorker messageQueueProcessor;

        public string Caption
        {
            get { return messageSettings.Caption; }
            set { messageSettings.Caption = value; }
        }
        public string Text
        {
            get { return messageSettings.Text; }
            set { messageSettings.Text = value; }
        }
        public int MessageTime
        {
            get { return messageSettings.MessageTime; }
            set { messageSettings.MessageTime = value; }
        }
        public int ShowingValue
        {
            get { return messageSettings.ShowingValue; }
            set { messageSettings.ShowingValue = value; }
        }
        public int HidingValue
        {
            get { return messageSettings.HidingValue; }
            set { messageSettings.HidingValue = value; }
        }
        public Color CaptionForeColor
        {
            get { return messageSettings.CaptionForeColor; }
            set { messageSettings.CaptionForeColor = value; }
        }
        public Color CaptionBackColor
        {
            get { return messageSettings.CaptionBackColor; }
            set { messageSettings.CaptionBackColor = value; }
        }
        public Color TextForeColor
        {
            get { return messageSettings.TextForeColor; }
            set { messageSettings.TextForeColor = value; }
        }
        public Color TextBackColor
        {
            get { return messageSettings.TextBackColor; }
            set { messageSettings.TextBackColor = value; }
        }
        public Bitmap Icon
        {
            get { return messageSettings.Icon; }
            set { messageSettings.Icon = value; }
        }
        public bool ShowIcon
        {
            get { return messageSettings.ShowIcon; }
            set { messageSettings.ShowIcon = value; }
        }
        public Form ConnectedForm { get; set; }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        public NotifyMessage()
        {
            InitializeComponent();

            messageSettings = new MessageSettings();

            messageSettings.Caption = "";
            messageSettings.Text = "";
            messageSettings.MessageTime = 3000;
            messageSettings.ShowingValue = 20;
            messageSettings.HidingValue = 20;
            messageSettings.CaptionForeColor = Color.White;
            messageSettings.CaptionBackColor = Color.FromArgb(51, 51, 51);
            messageSettings.TextForeColor = Color.Black;
            messageSettings.TextBackColor = Color.White;

            messageQueue = new Queue<MessageSettings>();
            messageQueueProcessor = new BackgroundWorker();
            messageQueueProcessor.DoWork += messageQueueProcessor_DoWork;
        }

        public NotifyMessage(IContainer container)
            : this()
        {
            container.Add(this);
        }

        private void messageQueueProcessor_DoWork(object sender, DoWorkEventArgs e)
        {
            EventWaitHandle formClosed = new EventWaitHandle(false, EventResetMode.AutoReset);

            while (messageQueue.Count > 0)
            {
                if (ConnectedForm == null)
                {
                    throw new Exception("ConnectedForm is not specified.");
                }

                ConnectedForm.Invoke((MethodInvoker)delegate()
                {
                    MessageForm messageForm = new MessageForm(messageQueue.Dequeue());
                    messageForm.FormClosed += delegate(object send, FormClosedEventArgs args) { formClosed.Set(); };
                    messageForm.Show();
                });

                formClosed.WaitOne();
            }
        }

        public void Show()
        {
            Show(Text, Caption, MessageTime);
        }
        public void Show(string text)
        {
            Show(text, Caption, MessageTime);
        }
        public void Show(string text, string caption)
        {
            Show(text, caption, MessageTime);
        }
        public void Show(string text, string caption, Bitmap icon)
        {
            Show(text, caption, MessageTime, icon);
        }
        public void Show(string text, string caption, int messageTime, Bitmap icon = null)
        {
            MessageSettings messageSettings = MessageSettings.Copy(this.messageSettings);

            messageSettings.Text = text;
            messageSettings.Caption = caption;
            messageSettings.MessageTime = messageTime;

            if (icon != null)
            {
                messageSettings.Icon = icon;
                messageSettings.ShowIcon = true;
            }

            messageQueue.Enqueue(messageSettings);

            if (!messageQueueProcessor.IsBusy)
            {
                messageQueueProcessor.RunWorkerAsync();
            }
        }

        private class MessageForm : Form
        {
            private System.ComponentModel.IContainer components = null;
            protected override bool ShowWithoutActivation
            {
                get { return true; }
            }

            public System.Windows.Forms.Timer timerShowing;
            public System.Windows.Forms.Timer timerWaiting;
            public System.Windows.Forms.Timer timerHiding;
            public PictureBox pictureBoxHeader;
            public PictureBox pictureBoxIcon;
            public Label labelCaption;
            public Label labelText;

            public MessageForm()
            {
                InitializeComponent();

                Rectangle screen = Screen.PrimaryScreen.WorkingArea;
                Left = screen.Right - Width - 10;
                Top = screen.Bottom - Height - 10;
            }
            public MessageForm(MessageSettings messageSettings)
                : this()
            {
                timerWaiting.Interval = messageSettings.MessageTime;
                timerShowing.Interval = messageSettings.ShowingValue;
                timerHiding.Interval = messageSettings.HidingValue;
                pictureBoxHeader.BackColor = messageSettings.CaptionBackColor;
                labelCaption.BackColor = messageSettings.CaptionBackColor;
                labelCaption.ForeColor = messageSettings.CaptionForeColor;
                labelCaption.Text = messageSettings.Caption;
                labelText.BackColor = messageSettings.TextBackColor;
                labelText.ForeColor = messageSettings.TextForeColor;
                labelText.Text = messageSettings.Text;
                BackColor = messageSettings.TextBackColor;

                if (messageSettings.ShowIcon)
                {
                    pictureBoxIcon.Image = messageSettings.Icon;
                    pictureBoxIcon.Size = messageSettings.Icon.Size;
                    pictureBoxIcon.Location = new System.Drawing.Point(12,
                        (int)((Height - pictureBoxIcon.Height - pictureBoxHeader.Height) / 2.0)
                        + pictureBoxHeader.Height);

                    labelText.Left = pictureBoxIcon.Right + 12;
                    labelText.Top = pictureBoxHeader.Height + 12;
                    labelText.AutoSize = false;
                    labelText.Size = new Size(Width - labelText.Left - 12,
                        Height - labelText.Top - 12);
                }
                else
                {
                    pictureBoxIcon.Size = new Size(0, 0);

                    labelText.Location = new System.Drawing.Point(12, 42);
                    labelText.Size = new System.Drawing.Size(35, 13);
                    labelText.AutoSize = true;
                }
            }

            private void InitializeComponent()
            {
                this.components = new System.ComponentModel.Container();
                this.timerShowing = new System.Windows.Forms.Timer(this.components);
                this.pictureBoxHeader = new System.Windows.Forms.PictureBox();
                this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
                this.labelCaption = new System.Windows.Forms.Label();
                this.labelText = new System.Windows.Forms.Label();
                this.timerWaiting = new System.Windows.Forms.Timer(this.components);
                this.timerHiding = new System.Windows.Forms.Timer(this.components);
                ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).BeginInit();
                this.SuspendLayout();
                // 
                // timerShowing
                // 
                this.timerShowing.Enabled = true;
                this.timerShowing.Interval = 20;
                this.timerShowing.Tick += new System.EventHandler(this.timerShowing_Tick);
                // 
                // pictureBoxHeader
                // 
                this.pictureBoxHeader.Dock = System.Windows.Forms.DockStyle.Top;
                this.pictureBoxHeader.Location = new System.Drawing.Point(0, 0);
                this.pictureBoxHeader.Name = "pictureBoxHeader";
                this.pictureBoxHeader.Size = new System.Drawing.Size(349, 30);
                this.pictureBoxHeader.TabIndex = 0;
                this.pictureBoxHeader.TabStop = false;
                //
                // pictureBoxIcon
                //
                this.pictureBoxIcon.Name = "pictureBoxIcon";
                this.pictureBoxIcon.TabIndex = 0;
                this.pictureBoxIcon.TabStop = false;
                // 
                // labelCaption
                // 
                this.labelCaption.AutoSize = true;
                this.labelCaption.BackColor = System.Drawing.Color.Transparent;
                this.labelCaption.ForeColor = System.Drawing.Color.White;
                this.labelCaption.Location = new System.Drawing.Point(12, 9);
                this.labelCaption.Name = "labelCaption";
                this.labelCaption.Size = new System.Drawing.Size(35, 13);
                this.labelCaption.TabIndex = 1;
                this.labelCaption.Text = "labelCaption";
                // 
                // labelText
                // 
                this.labelText.Location = new System.Drawing.Point(12, 42);
                this.labelText.Name = "labelText";
                this.labelText.Size = new System.Drawing.Size(35, 13);
                this.labelText.TabIndex = 2;
                this.labelText.Text = "labelText";
                this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // timerWaiting
                // 
                this.timerWaiting.Tick += new System.EventHandler(this.timerWaiting_Tick);
                // 
                // timerHiding
                // 
                this.timerHiding.Interval = 20;
                this.timerHiding.Tick += new System.EventHandler(this.timerHiding_Tick);
                // 
                // messageForm
                // 
                this.AllowTransparency = true;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(349, 93);
                this.Controls.Add(this.labelText);
                this.Controls.Add(this.labelCaption);
                this.Controls.Add(this.pictureBoxHeader);
                this.Controls.Add(this.pictureBoxIcon);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Name = "messageForm";
                this.Opacity = 0D;
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                this.Text = "MessageForm";
                ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeader)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            private void timerShowing_Tick(object sender, EventArgs e)
            {
                Opacity += 0.05;

                if (Opacity == 1)
                {
                    timerShowing.Enabled = false;
                    timerWaiting.Enabled = true;
                }
            }
            private void timerWaiting_Tick(object sender, EventArgs e)
            {
                timerWaiting.Enabled = false;
                timerHiding.Enabled = true;
            }
            private void timerHiding_Tick(object sender, EventArgs e)
            {
                Opacity -= 0.05;

                if (Opacity == 0)
                {
                    Close();
                }
            }
        }

        private class MessageSettings
        {
            public string Caption { get; set; }
            public string Text { get; set; }
            public int MessageTime { get; set; }
            public int ShowingValue { get; set; }
            public int HidingValue { get; set; }
            public Color CaptionForeColor { get; set; }
            public Color CaptionBackColor { get; set; }
            public Color TextForeColor { get; set; }
            public Color TextBackColor { get; set; }
            public Bitmap Icon { get; set; }
            public bool ShowIcon { get; set; }

            public static MessageSettings Copy(MessageSettings messageToCopy)
            {
                MessageSettings messageSettings = new MessageSettings();

                if (String.IsNullOrEmpty(messageToCopy.Caption))
                {
                    messageSettings.Caption = "";
                }
                else
                {
                    messageSettings.Caption = String.Copy(messageToCopy.Caption);
                }

                if (String.IsNullOrEmpty(messageToCopy.Text))
                {
                    messageSettings.Text = "";
                }
                else
                {
                    messageSettings.Text = String.Copy(messageToCopy.Caption);
                }

                messageSettings.MessageTime = messageToCopy.MessageTime;
                messageSettings.ShowingValue = messageToCopy.ShowingValue;
                messageSettings.HidingValue = messageToCopy.HidingValue;
                messageSettings.CaptionForeColor = Color.FromArgb(messageToCopy.CaptionForeColor.ToArgb());
                messageSettings.CaptionBackColor = Color.FromArgb(messageToCopy.CaptionBackColor.ToArgb());
                messageSettings.TextForeColor = Color.FromArgb(messageToCopy.TextForeColor.ToArgb());
                messageSettings.TextBackColor = Color.FromArgb(messageToCopy.TextBackColor.ToArgb());

                if (messageToCopy.Icon != null)
                {
                    messageSettings.Icon = (Bitmap)messageToCopy.Icon.Clone();
                }

                return messageSettings;
            }
        }
    }

    public class ListViewSubItemTip
    {
        int duration = 2000;
        string caption = "";
        ToolTip toolTip;
        ListView listView;
        ListViewItem.ListViewSubItem lastSubItem;
        System.Windows.Forms.Timer timer;
        Point location;

        public int Delay
        {
            get { return timer.Interval; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Delay is less than 0.");
                }

                timer.Interval = value;
            }
        }
        public int Duration
        {
            get { return duration; }
            set
            {
                if (duration < 0)
                {
                    throw new ArgumentException("Duration is less than 0.");
                }

                duration = value;
            }
        }

        public ListViewSubItemTip(ListView listView, int delay = 1000)
        {
            this.listView = listView;
            this.toolTip = new ToolTip();
            this.toolTip.SetToolTip(listView, "");
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = delay;
            this.timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toolTip.Show(caption, listView, location, duration);
            timer.Stop();
        }

        public void ShowSubItemTip(Point location)
        {
            ListViewHitTestInfo ht = listView.HitTest(location);

            if (ht.SubItem != lastSubItem)
            {
                timer.Stop();
                toolTip.Hide(listView);
                lastSubItem = ht.SubItem;

                if ((ht.SubItem != null) && (ht.SubItem.Tag != null))
                {
                    caption = ht.SubItem.Tag.ToString();
                    timer.Start();
                }
                else
                {
                    caption = "";
                }
            }

            this.location = location;
        }
    }
}
