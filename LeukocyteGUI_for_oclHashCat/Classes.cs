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
        public VisualManager Visualizer;

        public CrackTaskManager()
        {
            CrackTasks = new CrackTask[0];
            Visualizer = new VisualManager(this);
        }

        public int AddTask(int Index)
        {
            if (Index > -1)
            {
                Array.Resize<CrackTask>(ref CrackTasks, CrackTasks.Length + 1);

                if (Index != CrackTasks.Length - 1)
                {
                    for (int i = CrackTasks.Length - 1; i > Index; i--)
                    {
                        CrackTasks[i] = CrackTasks[i - 1];
                    }
                }

                CrackTasks[Index] = new CrackTask();
            }

            return CrackTasks.Length;
        }

        public int AddTask()
        {
            return AddTask(CrackTasks.Length);
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

            return CrackTasks.Length;
        }

        public int DeleteLastTask()
        {
            return DeleteTask(CrackTasks.Length - 1);
        }

        public void DeleteAllTasks()
        {
            CrackTasks = new CrackTask[0];
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

            return result;
        }

        public class CrackTask
        {
            private string sHashFileName, sHashTypeName, sBruteforceMask, sSeparator,
                sCharset1, sCharset2, sCharset3, sCharset4, sDictionary, sOutputFileName,
                sOutputFormatName, sSessionId, sWorkloadProfileName, sPlain, sHash,
                sStatus;
            private int sHashTypeCode, sWorkloadFineTuning = 8;
            private byte sWorkloadProfileCode, sOutputFormatCode, sStartLength, sMaxLength,
                sWorkloadTuning, sAbortTemp, sRetainTemp, sAttackType, sCurrentLength;
            private float sProgress;
            public DateTime Started, Finished, Estimated;
            public bool UseCharset1, UseCharset2, UseCharset3, UseCharset4,
                EnableIncrementMode, EnableGPUAsync, EnableSpecificWorkloadProfile,
                EnableWorkloadTuning, EnableWorkloadFineTuning, DisableTempReading,
                AbortSessionIfReachesMaxTemp, TryToRetain, DisableAutoPowertuning,
                CharsetIsInHex, SaltIsInHex, IgnoreWarnings, EnableLoopback,
                IgnoreUsernames, RemoveCrackedHashes, DisablePotfile, DisableLogfile,
                OutputToFile, Restore;

            public string HashFileName
            {
                get
                {
                    return sHashFileName;
                }
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

            public float Progress
            {
                get
                {
                    return sProgress;
                }

                set
                {
                    sProgress = value;
                }
            }

            public bool SetHash(string Hash)
            {
                this.sHash = Hash;
                return true;
            }

            public bool SetHashFileName(string HashFileName, bool ShowErrorMessages = false)
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
                            this.sHashFileName = HashFileName;
                        }
                        else
                        {
                            if (ShowErrorMessages)
                            {
                                if (MessageBox.Show("Hash file does not exist. Continue anyway?",
                                    "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    result = true;
                                    this.sHashFileName = HashFileName;
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

                result += " " + sHashFileName;

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

        public class VisualManager
        {
            private ListView sListView;
            private CrackTaskManager sCrackTaskManager;
            public Indexes InfoIndexes;
            public int StartId = 0;
            public string DateTimeFormat = "dd-MM-yyyy HH:mm:ss";

            public VisualManager(CrackTaskManager tskManager)
            {
                sCrackTaskManager = tskManager;
                InfoIndexes = new Indexes();
            }

            public void SetListView(ListView VisualizerListView)
            {
                sListView = VisualizerListView;
            }

            public bool VisualizeTask(int TaskId)
            {
                bool result = true;

                try
                {
                    string[] values = new string[InfoIndexes.RealLength];

                    if (InfoIndexes.AbortTemp > -1)
                    {
                        values[InfoIndexes.AbortTemp] = sCrackTaskManager.CrackTasks[TaskId].AbortTemp.ToString();
                    }

                    if (InfoIndexes.AttackType > -1)
                    {
                        values[InfoIndexes.AttackType] = sCrackTaskManager.CrackTasks[TaskId].AttackType.ToString();
                    }

                    if (InfoIndexes.BruteforceMaskDictionary > -1)
                    {
                        switch (sCrackTaskManager.CrackTasks[TaskId].AttackType)
                        {
                            case 0:
                                values[InfoIndexes.BruteforceMaskDictionary] = sCrackTaskManager.CrackTasks[TaskId].Dictionary;
                                break;
                            case 3:
                                values[InfoIndexes.BruteforceMaskDictionary] = sCrackTaskManager.CrackTasks[TaskId].BruteforceMask;
                                break;
                        }
                    }

                    if (InfoIndexes.Charset1 > -1)
                    {
                        values[InfoIndexes.Charset1] = sCrackTaskManager.CrackTasks[TaskId].Charset1;
                    }

                    if (InfoIndexes.Charset2 > -1)
                    {
                        values[InfoIndexes.Charset2] = sCrackTaskManager.CrackTasks[TaskId].Charset2;
                    }

                    if (InfoIndexes.Charset3 > -1)
                    {
                        values[InfoIndexes.Charset3] = sCrackTaskManager.CrackTasks[TaskId].Charset3;
                    }

                    if (InfoIndexes.Charset4 > -1)
                    {
                        values[InfoIndexes.Charset4] = sCrackTaskManager.CrackTasks[TaskId].Charset4;
                    }

                    if (InfoIndexes.Hash > -1)
                    {
                        values[InfoIndexes.Hash] = sCrackTaskManager.CrackTasks[TaskId].Hash;
                    }

                    if (InfoIndexes.HashFileName > -1)
                    {
                        values[InfoIndexes.HashFileName] = sCrackTaskManager.CrackTasks[TaskId].HashFileName;
                    }

                    if (InfoIndexes.HashTypeCode > -1)
                    {
                        values[InfoIndexes.HashTypeCode] = sCrackTaskManager.CrackTasks[TaskId].HashTypeCode.ToString();
                    }

                    if (InfoIndexes.HashTypeName > -1)
                    {
                        values[InfoIndexes.HashTypeName] = sCrackTaskManager.CrackTasks[TaskId].HashTypeName;
                    }

                    if (InfoIndexes.Separator > -1)
                    {
                        values[InfoIndexes.Separator] = sCrackTaskManager.CrackTasks[TaskId].HashTypeName;
                    }

                    if (InfoIndexes.MaxLength > -1)
                    {
                        values[InfoIndexes.MaxLength] = sCrackTaskManager.CrackTasks[TaskId].MaxLength.ToString();
                    }

                    if (InfoIndexes.OutputFileName > -1)
                    {
                        values[InfoIndexes.OutputFileName] = sCrackTaskManager.CrackTasks[TaskId].OutputFileName;
                    }

                    if (InfoIndexes.OutputFormatCode > -1)
                    {
                        values[InfoIndexes.OutputFormatCode] = sCrackTaskManager.CrackTasks[TaskId].OutputFormatCode.ToString();
                    }

                    if (InfoIndexes.OutputFormatName > -1)
                    {
                        values[InfoIndexes.OutputFormatName] = sCrackTaskManager.CrackTasks[TaskId].OutputFormatName;
                    }

                    if (InfoIndexes.Plain > -1)
                    {
                        values[InfoIndexes.Plain] = sCrackTaskManager.CrackTasks[TaskId].Plain;
                    }

                    if (InfoIndexes.RetainTemp > -1)
                    {
                        values[InfoIndexes.RetainTemp] = sCrackTaskManager.CrackTasks[TaskId].RetainTemp.ToString();
                    }

                    if (InfoIndexes.SessionId > -1)
                    {
                        values[InfoIndexes.SessionId] = sCrackTaskManager.CrackTasks[TaskId].SessionId;
                    }

                    if (InfoIndexes.StartLength > -1)
                    {
                        values[InfoIndexes.StartLength] = sCrackTaskManager.CrackTasks[TaskId].StartLength.ToString();
                    }

                    if (InfoIndexes.WorkloadFineTuning > -1)
                    {
                        values[InfoIndexes.WorkloadFineTuning] = sCrackTaskManager.CrackTasks[TaskId].WorkloadFineTuning.ToString();
                    }

                    if (InfoIndexes.WorkloadProfileCode > -1)
                    {
                        values[InfoIndexes.WorkloadProfileCode] = sCrackTaskManager.CrackTasks[TaskId].WorkloadProfileCode.ToString();
                    }

                    if (InfoIndexes.WorkloadProfileName > -1)
                    {
                        values[InfoIndexes.WorkloadProfileName] = sCrackTaskManager.CrackTasks[TaskId].WorkloadProfileName;
                    }

                    if (InfoIndexes.WorkloadTuning > -1)
                    {
                        values[InfoIndexes.WorkloadTuning] = sCrackTaskManager.CrackTasks[TaskId].WorkloadTuning.ToString();
                    }

                    if (InfoIndexes.Started > -1)
                    {
                        values[InfoIndexes.Started] = sCrackTaskManager.CrackTasks[TaskId].Started.ToString(DateTimeFormat);
                    }

                    if (InfoIndexes.Finished > -1)
                    {
                        values[InfoIndexes.Finished] = sCrackTaskManager.CrackTasks[TaskId].Finished.ToString(DateTimeFormat);
                    }

                    if (InfoIndexes.Id > -1)
                    {
                        values[InfoIndexes.Id] = (TaskId + StartId).ToString();
                    }

                    sListView.Items[TaskId] = new ListViewItem(values);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    result = false;
                }

                return result;
            }

            public bool VisualizeNewTask()
            {
                sListView.Items.Add("");
                return VisualizeTask(sCrackTaskManager.CrackTasks.Length - 1);
            }

            public bool VisualizeTasks()
            {
                bool result = true;

                try
                {
                    sListView.Items.Clear();

                    for (int i = 0; i < sCrackTaskManager.CrackTasks.Length; i++)
                    {
                        sListView.Items.Add("");
                        VisualizeTask(i);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }

                return result;
            }

            public class Indexes
            {
                private Dictionary<string, int> sIndexes = new Dictionary<string, int>()
                {
                    { "HashFileName", -1 },
                    { "HashTypeName", -1 },
                    { "BruteforceMaskDictionary", -1 },
                    { "Separator", -1 },
                    { "Charset1", -1 },
                    { "Charset2", -1 },
                    { "Charset3", -1 },
                    { "Charset4", -1 },
                    { "OutputFileName", -1 },
                    { "OutputFormatName", -1 },
                    { "SessionId", -1 },
                    { "WorkloadProfileName", -1 },
                    { "HashTypeCode", -1 },
                    { "WorkloadFineTuning", -1 },
                    { "WorkloadProfileCode", -1 },
                    { "OutputFormatCode", -1 },
                    { "StartLength", -1 },
                    { "MaxLength", -1 },
                    { "WorkloadTuning", -1 },
                    { "AbortTemp", -1 },
                    { "RetainTemp", -1 },
                    { "AttackType", -1 },
                    { "Plain", -1 },
                    { "Hash", -1 },
                    { "Started", -1 },
                    { "Finished", -1 },
                    { "Id", -1 }
                };

                private int sRealLength = 0;

                private int UpdateRealLength()
                {
                    int max = -1;

                    foreach (KeyValuePair<string, int> pair in sIndexes)
                    {
                        if (pair.Value > max)
                        {
                            max = pair.Value;
                        }
                    }

                    sRealLength = max + 1;

                    return sRealLength;
                }

                public int HashFileName
                {
                    get
                    {
                        return sIndexes["HashFileName"];
                    }

                    set
                    {
                        sIndexes["HashFileName"] = value;
                        UpdateRealLength();
                    }
                }

                public int HashTypeName
                {
                    get
                    {
                        return sIndexes["HashTypeName"];
                    }

                    set
                    {
                        sIndexes["HashTypeName"] = value;
                        UpdateRealLength();
                    }
                }

                public int BruteforceMaskDictionary
                {
                    get
                    {
                        return sIndexes["BruteforceMaskDictionary"];
                    }

                    set
                    {
                        sIndexes["BruteforceMaskDictionary"] = value;
                        UpdateRealLength();
                    }
                }

                public int Separator
                {
                    get
                    {
                        return sIndexes["Separator"];
                    }

                    set
                    {
                        sIndexes["Separator"] = value;
                        UpdateRealLength();
                    }
                }

                public int Charset1
                {
                    get
                    {
                        return sIndexes["Charset1"];
                    }

                    set
                    {
                        sIndexes["Charset1"] = value;
                        UpdateRealLength();
                    }
                }

                public int Charset2
                {
                    get
                    {
                        return sIndexes["Charset2"];
                    }

                    set
                    {
                        sIndexes["Charset2"] = value;
                        UpdateRealLength();
                    }
                }

                public int Charset3
                {
                    get
                    {
                        return sIndexes["Charset3"];
                    }

                    set
                    {
                        sIndexes["Charset3"] = value;
                        UpdateRealLength();
                    }
                }

                public int Charset4
                {
                    get
                    {
                        return sIndexes["Charset4"];
                    }

                    set
                    {
                        sIndexes["Charset4"] = value;
                        UpdateRealLength();
                    }
                }

                public int OutputFileName
                {
                    get
                    {
                        return sIndexes["OutputFileName"];
                    }

                    set
                    {
                        sIndexes["OutputFileName"] = value;
                        UpdateRealLength();
                    }
                }

                public int OutputFormatName
                {
                    get
                    {
                        return sIndexes["OutputFormatName"];
                    }

                    set
                    {
                        sIndexes["OutputFormatName"] = value;
                        UpdateRealLength();
                    }
                }

                public int SessionId
                {
                    get
                    {
                        return sIndexes["SessionId"];
                    }

                    set
                    {
                        sIndexes["SessionId"] = value;
                        UpdateRealLength();
                    }
                }

                public int WorkloadProfileName
                {
                    get
                    {
                        return sIndexes["WorkloadProfileName"];
                    }

                    set
                    {
                        sIndexes["WorkloadProfileName"] = value;
                        UpdateRealLength();
                    }
                }

                public int HashTypeCode
                {
                    get
                    {
                        return sIndexes["HashTypeCode"];
                    }

                    set
                    {
                        sIndexes["HashTypeCode"] = value;
                        UpdateRealLength();
                    }
                }

                public int WorkloadFineTuning
                {
                    get
                    {
                        return sIndexes["WorkloadFineTuning"];
                    }

                    set
                    {
                        sIndexes["WorkloadFineTuning"] = value;
                        UpdateRealLength();
                    }
                }

                public int WorkloadProfileCode
                {
                    get
                    {
                        return sIndexes["WorkloadProfileCode"];
                    }

                    set
                    {
                        sIndexes["WorkloadProfileCode"] = value;
                        UpdateRealLength();
                    }
                }

                public int OutputFormatCode
                {
                    get
                    {
                        return sIndexes["OutputFormatCode"];
                    }

                    set
                    {
                        sIndexes["OutputFormatCode"] = value;
                        UpdateRealLength();
                    }
                }

                public int StartLength
                {
                    get
                    {
                        return sIndexes["StartLength"];
                    }

                    set
                    {
                        sIndexes["StartLength"] = value;
                        UpdateRealLength();
                    }
                }

                public int MaxLength
                {
                    get
                    {
                        return sIndexes["MaxLength"];
                    }

                    set
                    {
                        sIndexes["MaxLength"] = value;
                        UpdateRealLength();
                    }
                }

                public int WorkloadTuning
                {
                    get
                    {
                        return sIndexes["WorkloadTuning"];
                    }

                    set
                    {
                        sIndexes["WorkloadTuning"] = value;
                        UpdateRealLength();
                    }
                }

                public int AbortTemp
                {
                    get
                    {
                        return sIndexes["AbortTemp"];
                    }

                    set
                    {
                        sIndexes["AbortTemp"] = value;
                        UpdateRealLength();
                    }
                }

                public int RetainTemp
                {
                    get
                    {
                        return sIndexes["RetainTemp"];
                    }

                    set
                    {
                        sIndexes["RetainTemp"] = value;
                        UpdateRealLength();
                    }
                }

                public int AttackType
                {
                    get
                    {
                        return sIndexes["AttackType"];
                    }

                    set
                    {
                        sIndexes["AttackType"] = value;
                        UpdateRealLength();
                    }
                }

                public int Plain
                {
                    get
                    {
                        return sIndexes["Plain"];
                    }

                    set
                    {
                        sIndexes["Plain"] = value;
                        UpdateRealLength();
                    }
                }

                public int Hash
                {
                    get
                    {
                        return sIndexes["Hash"];
                    }

                    set
                    {
                        sIndexes["Hash"] = value;
                        UpdateRealLength();
                    }
                }

                public int Started
                {
                    get
                    {
                        return sIndexes["Started"];
                    }

                    set
                    {
                        sIndexes["Started"] = value;
                        UpdateRealLength();
                    }
                }

                public int Finished
                {
                    get
                    {
                        return sIndexes["Finished"];
                    }

                    set
                    {
                        sIndexes["Finished"] = value;
                        UpdateRealLength();
                    }
                }

                public int Id
                {
                    get
                    {
                        return sIndexes["Id"];
                    }

                    set
                    {
                        sIndexes["Id"] = value;
                        UpdateRealLength();
                    }
                }

                public int RealLength
                {
                    get
                    {
                        return sRealLength;
                    }
                }
            }
        }

        public class Cracker : System.Diagnostics.Process
        {
            private string sHashcat;

            public Cracker()
            {
                StartInfo.UseShellExecute = false;
                StartInfo.CreateNoWindow = true;
                StartInfo.RedirectStandardOutput = true;
                OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(Cracker_OutputDataReceived);
            }

            private void Cracker_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
            {

            }

            public bool SetHashcat(string Hashcat, bool ShowErrorMessages = false)
            {
                bool result = false;

                if (System.IO.File.Exists(Hashcat))
                {
                    sHashcat = Hashcat;
                    result = true;
                }
                else if (ShowErrorMessages)
                {
                    if (MessageBox.Show("Specified hashcat.exe does not exist. Continue anyway (not recommended)?",
                        "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        sHashcat = Hashcat;
                        result = true;
                    }
                }

                return result;
            }
        }
    }
}
