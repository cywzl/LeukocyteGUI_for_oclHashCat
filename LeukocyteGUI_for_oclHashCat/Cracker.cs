using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeukocyteGUI_for_oclHashCat
{
    class CrackerEventArgs
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

    class Cracker
    {
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
        int processingTaskId;

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
                if(processingTaskId > -1)
                {
                    return crackTasks[processingTaskId];
                }
                else
                {
                    return null;
                }
            }
        }

        public Cracker()
        {
            crackTasks = new CrackTasksList();
            crackTasks.CrackTaskMoved += CrackTasks_CrackTaskMoved;

            cracker = new Process();
            cracker.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = true
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
            if(e.CrackTaskOldId == processingTaskId)
            {
                processingTaskId = e.CrackTaskNewId;
            }
        }
        private void Cracker_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Cracker_Exited(object sender, EventArgs e)
        {
            if(ProcessingTask.CrackStatus == CrackStatuses.Cracking)
            {
                if(ProcessingTask.SessionSettings.Restore)
                {
                    ProcessingTask.CrackStatus = CrackStatuses.Paused;
                }
                else
                {
                    ProcessingTask.CrackStatus = CrackStatuses.Stopped;
                }
                
            }

            Stopped(this, new CrackerEventArgs(ProcessingTask, processingTaskId));

            ClearAfterCracking();
        }
        private void Cracker_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ClearAfterCracking()
        {
            cracker.Close();
            cracker.CancelOutputRead();
            cracker.CancelErrorRead();
            speed = "";
            util = 0;
            temp = 0;
            fan = 0;
            processingTaskId = -1;
        }
        private void CrackingProcessCleanKill()
        {

        }

        public void Crack(int crackTaskId)
        {
            crackTasks.CheckCrackTaskIdException(crackTaskId);
            processingTaskId = crackTaskId;

            BeforeStart(this, new CrackerEventArgs(ProcessingTask, processingTaskId));

            if(ProcessingTask.Started == DateTime.MinValue)
            {
                ProcessingTask.Started = DateTime.Now;
            }

            cracker.StartInfo.Arguments = ProcessingTask.ToString();
            cracker.Start();

            ProcessingTask.SessionSettings.Restore = !ProcessingTask.SessionSettings.RestoreDisable;
            ProcessingTask.CrackStatus = CrackStatuses.Cracking;

            Started(this, new CrackerEventArgs(ProcessingTask, processingTaskId));
        }
        public void Stop()
        {
            CrackingProcessCleanKill();
        }
    }
}
