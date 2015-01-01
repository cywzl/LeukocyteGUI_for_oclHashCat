﻿using System;
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

        public CrackTaskManager()
        {
            CrackTasks = new CrackTask[0];
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
            return AddTask(CrackTasks.Length) - 1;
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

        public int TaskMoveUp(int Index)
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

        public int TaskMoveDown(int Index)
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
            private string HashFileName, HashTypeName, BruteforceMask, Separator,
                Charset1, Charset2, Charset3, Charset4, Dictionary, OutputFileName,
                OutputFormatName, SessionId, WorkloadProfileName;
            private int HashTypeCode, WorkloadFineTuning;
            private byte WorkloadProfileCode, OutputFormatCode, StartLength, MaxLength,
                WorkloadTuning, AbortTemp, RetainTemp, AttackType;
            public bool UseCharset1, UseCharset2, UseCharset3, UseCharset4,
                EnableIncrementMode, EnableGPUAsync, EnableSpecificWorkloadProfile,
                EnableWorkloadTuning, EnableWorkloadFineTuning, DisableTempReading,
                AbortSessionIfReachesMaxTemp, TryToRetain, DisableAutoPowertuning,
                CharsetIsInHex, SaltIsInHex, IgnoreWarnings, EnableLoopback,
                IgnoreUsernames, RemoveCrackedHashes, DisablePotfile, DisableLogfile,
                OutputToFile;

            public bool SetHashFileName(string HashFileName, bool ShowErrorMessages = false)
            {
                bool result = false;

                if (HashFileName.Contains('.') || HashFileName.Contains('/') || HashFileName.Contains(@"\"))
                {
                    if (System.IO.File.Exists(HashFileName))
                    {
                        result = true;
                    }
                    else
                    {
                        if (ShowErrorMessages)
                        {
                            if (MessageBox.Show("Hash file does not exist. Continue anyway?",
                                "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                result = true;
                            }
                        }
                    }

                    if (result)
                    {
                        this.HashFileName = HashFileName;
                    }
                }
                else
                {
                    result = true;
                }

                return result;   
            }

            public bool SetHashTypeName(string HashTypeName)
            {
                this.HashTypeName = HashTypeName;
                return true;
            }

            public bool SetBruteforceMask(string BruteforceMask)
            {
                this.BruteforceMask = BruteforceMask;
                return true;
            }

            public bool SetSeparator(string Separator)
            {
                this.Separator = Separator;
                return true;
            }

            public bool SetCharset1(string Charset1)
            {
                this.Charset1 = Charset1;
                return true;
            }

            public bool SetCharset2(string Charset2)
            {
                this.Charset2 = Charset2;
                return true;
            }

            public bool SetCharset3(string Charset3)
            {
                this.Charset3 = Charset3;
                return true;
            }

            public bool SetCharset4(string Charset4)
            {
                this.Charset4 = Charset4;
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
                    this.Dictionary = Dictionary;
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

                return result;
            }

            public bool SetOutputFormatName(string OutputFormatName)
            {
                this.OutputFormatName = OutputFormatName;
                return true;
            }

            public bool SetSessionId(string SessionId)
            {
                this.SessionId = SessionId;
                return true;
            }

            public bool SetWorkloadProfileName(string WorkloadProfileName)
            {
                this.WorkloadProfileName = WorkloadProfileName;
                return true;
            }

            public bool SetHashTypeCode(int HashTypeCode)
            {
                this.HashTypeCode = HashTypeCode;
                return true;
            }

            public bool SetWorkloadFineTuning(int WorkloadFineTuning)
            {
                this.WorkloadFineTuning = WorkloadFineTuning;
                return true;
            }

            public bool SetWorkloadProfileCode(byte WorkloadProfileCode)
            {
                this.WorkloadProfileCode = WorkloadProfileCode;
                return true;
            }

            public bool SetOutputFormatCode(byte OutputFormatCode)
            {
                this.OutputFormatCode = OutputFormatCode;
                return true;
            }

            public bool SetStartLength(byte StartLength)
            {
                this.StartLength = StartLength;
                return true;
            }

            public bool SetMaxLength(byte MaxLength)
            {
                this.MaxLength = MaxLength;
                return true;
            }

            public bool SetWorkloadTuning(byte WorkloadTuning)
            {
                this.WorkloadTuning = WorkloadTuning;
                return true;
            }

            public bool SetAbortTemp(byte AbortTemp)
            {
                this.AbortTemp = AbortTemp;
                return true;
            }

            public bool SetRetainTemp(byte RetainTemp)
            {
                this.RetainTemp = RetainTemp;
                return true;
            }

            public bool SetAttackType(byte AttackType)
            {
                this.AttackType = AttackType;
                return true;
            }

            public string GetHashcatParams()
            {
                string result = "";

                result
                   += " --hash-type="      + AttackType.ToString()
                    + " --attack-mode="    + HashTypeCode.ToString()
                    + " --session="        + SessionId
                    + " --status"
                    + " --status-timer="   + "2"
                    + " --separator="      + Separator;

                if (OutputToFile)
                {
                    result
                        += " --outfile="        + OutputFileName
                         + " --outfile-format=" + OutputFormatCode.ToString();
                }

                if (UseCharset1)
                {
                    result += " --custom-charset1=" + Charset1;
                }

                if (UseCharset2)
                {
                    result += " --custom-charset1=" + Charset2;
                }

                if (UseCharset3)
                {
                    result += " --custom-charset1=" + Charset3;
                }

                if (UseCharset4)
                {
                    result += " --custom-charset1=" + Charset4;
                }

                if (EnableIncrementMode)
                {
                    result
                        += " --increment"
                         + " --increment-min=" + StartLength
                         + " --increment-max=" + MaxLength;
                }

                if (EnableGPUAsync)
                {
                    result += " --gpu-async";
                }

                if (EnableSpecificWorkloadProfile)
                {
                    result += " --workload-profile=" + WorkloadProfileCode.ToString();
                }

                if (EnableWorkloadTuning)
                {
                    result += " --gpu-accel=" + WorkloadTuning.ToString();
                }

                if (EnableWorkloadFineTuning)
                {
                    result += " --gpu-loops" + WorkloadFineTuning.ToString();
                }

                if (DisableTempReading)
                {
                    result += " --gpu-temp-disable";
                }

                if (AbortSessionIfReachesMaxTemp)
                {
                    result += " --gpu-temp-abort=" + AbortTemp.ToString();
                }

                if (TryToRetain)
                {
                    result += " --gpu-temp-retain=" + RetainTemp.ToString();
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

                result += " " + HashFileName;

                switch (AttackType)
                {
                    case 0:
                        result += " " + Dictionary;
                        break;
                    case 3:
                        result += " " + BruteforceMask;
                        break;
                }

                return result;
            }
        }
    }
}
