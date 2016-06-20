using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace LeukocyteCore_for_oclHashcat.Classes
{
    public class CrackerEventArgs
    {
        private int crackTaskId;
        private CrackTask crackTask;

        public int CrackTaskId
        {
            get
            {
                return crackTaskId;
            }
        }
        public CrackTask CrackTask
        {
            get
            {
                return crackTask;
            }
        }

        public CrackerEventArgs(CrackTask crackTask, int crackTaskId)
        {
            this.crackTask = crackTask;
            this.crackTaskId = crackTaskId;
        }
    }

    public class Cracker
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool GenerateConsoleCtrlEvent(ConsoleCtrlEvent sigevent, int dwProcessGroupId);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AttachConsole(uint dwProcessId);
        [DllImport("kernel32.dll")]
        static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate HandlerRoutine, bool Add);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool FreeConsole();

        public enum ConsoleCtrlEvent
        {
            CTRL_C = 0,
            CTRL_BREAK = 1,
            CTRL_CLOSE = 2,
            CTRL_LOGOFF = 5,
            CTRL_SHUTDOWN = 6
        }

        delegate bool ConsoleCtrlDelegate(ConsoleCtrlEvent CtrlType);
        public delegate void CrackerEventHandler(object sender, EventArgs e);
        public delegate void CrackerStateChangedEventHandler(object sender, CrackerEventArgs e);

        public event CrackerStateChangedEventHandler BeforeStart = delegate { };
        public event CrackerStateChangedEventHandler Started = delegate { };
        public event CrackerStateChangedEventHandler ProgressChanged = delegate { };
        public event CrackerStateChangedEventHandler Stopped = delegate { };

        CrackTasksList crackTasks;
        Process cracker;
        string speed;
        byte util;
        byte temp;
        byte fan;
        int processingTaskId = -1;
        int lastProcessedTaskId = -1;
        bool processNextQueued = false;
        Regex recoveredRegex = new Regex(@"(.*?)/(.*?) \(.*?\%\) Digests, (.*?)/(.*?) \(.*?\%\) Salts");
        Regex monitorRegex = new Regex(@"(.*?)% Util, (.*?)c Temp, (.*?)% Fan");
        CultureInfo cultureInfo;

        public CrackTasksList CrackTasks
        {
            get
            {
                return crackTasks;
            }
            set
            {
                crackTasks = value;
            }
        }
        public string CrackerFile
        {
            get
            {
                return cracker.StartInfo.FileName;
            }
            set
            {
                cracker.StartInfo.FileName = value;
            }
        }
        public string WorkingDirectory
        {
            get
            {
                return cracker.StartInfo.WorkingDirectory;
            }
            set
            {
                cracker.StartInfo.WorkingDirectory = value;
            }
        }
        public string Speed
        {
            get
            {
                return speed;
            }
        }
        public byte Util
        {
            get
            {
                return util;
            }
        }
        public byte Fan
        {
            get
            {
                return fan;
            }
        }
        public int ProcessingTaskId
        {
            get
            {
                return processingTaskId;
            }
        }
        public CrackTask ProcessingTask
        {
            get
            {
                if (processingTaskId > -1)
                {
                    return crackTasks[processingTaskId];
                }
                else
                {
                    return null;
                }
            }
        }
        public int LastProcessedTaskId
        {
            get
            {
                return lastProcessedTaskId;
            }
        }
        public CrackTask LastProcessedTask
        {
            get
            {
                if (lastProcessedTaskId > -1)
                {
                    return crackTasks[lastProcessedTaskId];
                }
                else
                {
                    return null;
                }
            }
        }
        public bool IsRunning
        {
            get
            {
                return processingTaskId != -1;
            }
        }
        public bool ProcessNextQueued
        {
            get
            {
                return processNextQueued;
            }
            set
            {
                processNextQueued = value;
            }
        }

        public Cracker()
        {
            cultureInfo = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";

            crackTasks = new CrackTasksList();
            crackTasks.CrackTaskMoved += CrackTasks_CrackTaskMoved;

            cracker = new Process();
            cracker.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };
            cracker.EnableRaisingEvents = true;
            cracker.ErrorDataReceived += Cracker_ErrorDataReceived;
            cracker.Exited += Cracker_Exited;
            cracker.OutputDataReceived += Cracker_OutputDataReceived;
        }
        public Cracker(string crackerFile, string workingDirectory = "") : this()
        {
            cracker.StartInfo.FileName = crackerFile;
            cracker.StartInfo.WorkingDirectory = workingDirectory;
        }

        private void CrackTasks_CrackTaskMoved(object sender, CrackTasksListTaskMovedEventArgs e)
        {
            if (e.CrackTaskOldId == processingTaskId)
            {
                processingTaskId = e.CrackTaskNewId;
            }
        }
        private void Cracker_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if ((e.Data != null) && (e.Data.Length > 0))
            {
                lock (ProcessingTask)
                {
                    if (ProcessingTask == null)
                    {
                        return;
                    }

                    string[] parts = e.Data.Split(new string[] { ": " }, 2, StringSplitOptions.None);

                    switch (parts[0])
                    {
                        case "Status.........":
                            switch (parts[1])
                            {
                                case "Cracked":
                                    ProcessingTask.CrackStatus = CrackStatuses.Cracked;
                                    ProcessingTask.Progress = 100;
                                    break;
                                case "Exhausted":
                                    ProcessingTask.CrackStatus = CrackStatuses.Exausted;
                                    break;
                            }

                            break;

                        case "Time.Estimated.":
                            int startE = parts[1].IndexOf('(') + 1;

                            if (startE > 0)
                            {
                                int lengthE = parts[1].IndexOf(')') - startE;
                                ProcessingTask.TimeEstimated = parts[1].Substring(startE, lengthE);
                            }
                            else
                            {
                                ProcessingTask.TimeEstimated = parts[1];
                            }

                            break;

                        case "Speed.GPU.#1...":
                            speed = parts[1].TrimStart(' ');
                            break;

                        case "Recovered......":
                            Match matchRecovered = recoveredRegex.Match(parts[1]);
                            ProcessingTask.RecoveredDigests = int.Parse(matchRecovered.Groups[1].Value);
                            ProcessingTask.Digests = int.Parse(matchRecovered.Groups[2].Value);
                            ProcessingTask.RecoveredSalts = int.Parse(matchRecovered.Groups[3].Value);
                            ProcessingTask.Salts = int.Parse(matchRecovered.Groups[4].Value);
                            break;

                        case "Input.Mode.....":
                            int startL = parts[1].IndexOf('[') + 1;
                            int lengthL = parts[1].IndexOf(']') - startL;

                            if ((startL > -1) && (lengthL > 0))
                            {
                                ProcessingTask.CurrentLength = byte.Parse(parts[1].Substring(startL, lengthL));
                            }

                            break;

                        case "Progress.......":
                            int startP = parts[1].IndexOf('(') + 1;
                            int lengthP = parts[1].IndexOf('%') - startP;

                            if ((startP > -1) && (lengthP > 0))
                            {
                                ProcessingTask.Progress = float.Parse(parts[1].Substring(startP, lengthP),
                                    NumberStyles.Any, cultureInfo);
                            }

                            break;

                        case "HWMon.GPU.#1...":
                            Match matchMonitor = monitorRegex.Match(parts[1]);
                            util = byte.Parse(matchMonitor.Groups[1].Value);
                            temp = byte.Parse(matchMonitor.Groups[2].Value);
                            fan = byte.Parse(matchMonitor.Groups[3].Value);
                            break;

                        default:
                            if ((parts.Length == 1)
                                && (ProcessingTask.FilesSettings.OutFileFormat == -1))
                            {
                                parts = e.Data.Split(':');

                                if (parts[0] == ProcessingTask.CrackTarget)
                                {
                                    ProcessingTask.Plain = parts[1];
                                }
                            }
                            break;
                    }

                    ProgressChanged(this, new CrackerEventArgs(ProcessingTask, processingTaskId));
                }
            }
        }
        private void Cracker_Exited(object sender, EventArgs e)
        {
            lock (ProcessingTask)
            {
                if (ProcessingTask == null)
                {
                    return;
                }

                if (ProcessingTask.CrackStatus == CrackStatuses.Cracking)
                {
                    if (ProcessingTask.SessionSettings.Restore)
                    {
                        ProcessingTask.CrackStatus = CrackStatuses.Paused;
                    }
                    else
                    {
                        ProcessingTask.CrackStatus = CrackStatuses.Stopped;
                    }

                }

                Stopped(this, new CrackerEventArgs(ProcessingTask, processingTaskId));

                if (processNextQueued)
                {
                    lastProcessedTaskId = processingTaskId;
                }
                else
                {
                    lastProcessedTaskId = -1;
                }

                ClearAfterCracking();
            }

            if (processNextQueued)
            {
                CrackNextQueued();
            }
        }
        private void Cracker_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
        }
        private void ClearAfterCracking()
        {
            try
            {
                cracker.Close();
                cracker.CancelOutputRead();
                cracker.CancelErrorRead();
            }
            catch { }

            speed = "";
            util = 0;
            temp = 0;
            fan = 0;
            processingTaskId = -1;
        }
        private void CrackingProcessCleanKill()
        {
            if (AttachConsole((uint)cracker.Id))
            {
                SetConsoleCtrlHandler(null, true);
                GenerateConsoleCtrlEvent(ConsoleCtrlEvent.CTRL_C, 0);
                cracker.WaitForExit(1000);
                FreeConsole();
                SetConsoleCtrlHandler(null, false);
            }
        }

        public void Crack(int crackTaskId)
        {
            crackTasks.CheckCrackTaskIdException(crackTaskId);
            processingTaskId = crackTaskId;

            BeforeStart(this, new CrackerEventArgs(ProcessingTask, processingTaskId));

            if (ProcessingTask.Started == DateTime.MinValue)
            {
                ProcessingTask.Started = DateTime.Now;
            }

            cracker.StartInfo.Arguments = ProcessingTask.ToString();
            cracker.Start();

            try
            {
                cracker.BeginErrorReadLine();
            }
            catch { }

            try
            {
                cracker.BeginOutputReadLine();
            }
            catch { }
            

            ProcessingTask.SessionSettings.Restore = !ProcessingTask.SessionSettings.RestoreDisable;
            ProcessingTask.CrackStatus = CrackStatuses.Cracking;

            Started(this, new CrackerEventArgs(ProcessingTask, processingTaskId));
        }
        public void CrackNextQueued()
        {
            for (int i = lastProcessedTaskId + 1; i < crackTasks.Count; i++)
            {
                if (crackTasks[i].CrackStatus == CrackStatuses.Queued)
                {
                    Crack(i);
                    break;
                }
            }
        }
        public void Stop(bool processNextQueued = true)
        {
            this.processNextQueued = processNextQueued;
            CrackingProcessCleanKill();
        }
        public void WaitForStop()
        {
            cracker.WaitForExit();
        }
        public bool WaitForStop(int milliseconds)
        {
            if (milliseconds <= 0)
            {
                throw new ArgumentOutOfRangeException("milliseconds", "Time to wait value must be bigger than 0.");
            }

            return cracker.WaitForExit(milliseconds);
        }
    }
}
