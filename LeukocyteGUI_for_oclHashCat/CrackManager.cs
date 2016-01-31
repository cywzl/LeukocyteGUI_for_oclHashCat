using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LeukocyteGUI_for_oclHashCat
{
    class CrackManagerTaskChangedEventArgs : EventArgs
    {
        public int CrackTaskId
        {
            get
            {
                return crackTaskId;
            }
        }
        private int crackTaskId;

        public CrackTask CrackTask
        {
            get
            {
                return crackTask;
            }
        }
        private CrackTask crackTask;

        public CrackManagerTaskChangedEventArgs(CrackTask crackTask, int crackTaskId) : base()
        {
            this.crackTask = crackTask;
            this.crackTaskId = crackTaskId;
        }
    }
    class CrackManagerTaskMovedEventArgs : EventArgs
    {
        public int CrackTaskOldId
        {
            get
            {
                return crackTaskOldId;
            }
        }
        private int crackTaskOldId;

        public int CrackTaskNewId
        {
            get
            {
                return crackTaskNewId;
            }
        }
        private int crackTaskNewId;

        public CrackTask CrackTask
        {
            get
            {
                return crackTask;
            }
        }
        private CrackTask crackTask;

        public CrackManagerTaskMovedEventArgs(CrackTask crackTask, int crackTaskOldId, int crackTaskNewId) : base()
        {
            this.crackTask = crackTask;
            this.crackTaskOldId = crackTaskOldId;
            this.crackTaskNewId = crackTaskNewId;
        }
    }

    class CrackManager
    {
        public delegate void CrackManagerTaskChangedEventHandler(object sender, CrackManagerTaskChangedEventArgs e);
        public delegate void CrackManagerTaskMovedEventHandler(object sender, CrackManagerTaskMovedEventArgs e);
        public delegate void CrackManagerEventHandler(object sender, EventArgs e);

        public event CrackManagerTaskChangedEventHandler CrackTaskAdded = delegate { };
        public event CrackManagerTaskChangedEventHandler CrackTaskRemoved = delegate { };
        public event CrackManagerTaskMovedEventHandler CrackTaskMoved = delegate { };
        public event CrackManagerEventHandler CrackTasksCleared = delegate { };

        private Process cracker;
        
        public ReadOnlyCollection<CrackTask> CrackTasks
        {
            get
            {
                return crackTasks.AsReadOnly();
            }
        }
        private List<CrackTask> crackTasks;

        public CrackManager(string crackerFile, string workingDirectory = "")
        {
            cracker = new Process();
            cracker.StartInfo = new ProcessStartInfo
            {
                FileName = crackerFile,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                WorkingDirectory = workingDirectory
            };
            cracker.EnableRaisingEvents = true;
            cracker.OutputDataReceived += Cracker_OutputDataReceived;
            cracker.Exited += Cracker_Exited;

            crackTasks = new List<CrackTask>();
        }

        public void AddTask(CrackTask crackTask)
        {
            crackTasks.Add(crackTask);
            CrackTaskAdded(this, new CrackManagerTaskChangedEventArgs(crackTask, crackTasks.Count - 1));
        }
        public bool RemoveTask(CrackTask crackTask)
        {
            int index = crackTasks.IndexOf(crackTask);

            if (index > -1)
            {
                crackTasks.RemoveAt(index);
                CrackTaskRemoved(this, new CrackManagerTaskChangedEventArgs(crackTask, index));
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RemoveTaskAt(int crackTaskId)
        {
            if (crackTaskId < 0)
            {
                throw new ArgumentOutOfRangeException("crackTaskId", "TaskId cannot be less than 0.");
            }
            if (crackTaskId >= crackTasks.Count)
            {
                throw new ArgumentOutOfRangeException("crackTaskId", "TaskId cannot be greater than last task's id.");
            }

            CrackTask crackTask = crackTasks[crackTaskId];
            crackTasks.RemoveAt(crackTaskId);
            CrackTaskRemoved(this, new CrackManagerTaskChangedEventArgs(crackTask, crackTaskId));
        }
        public void ClearTasks()
        {
            crackTasks.Clear();
            CrackTasksCleared(this, new EventArgs());
        }
        public void SwapTasks(int firstCrackTaskId, int secondCrackTaskId)
        {
            if (firstCrackTaskId < 0)
            {
                throw new ArgumentOutOfRangeException("firstCrackTaskId", "TaskId cannot be less than 0.");
            }
            if (firstCrackTaskId >= crackTasks.Count)
            {
                throw new ArgumentOutOfRangeException("firstCrackTaskId", "TaskId cannot be greater than last task's id.");
            }
            if (secondCrackTaskId < 0)
            {
                throw new ArgumentOutOfRangeException("secondCrackTaskId", "TaskId cannot be less than 0.");
            }
            if (secondCrackTaskId >= crackTasks.Count)
            {
                throw new ArgumentOutOfRangeException("secondCrackTaskId", "TaskId cannot be greater than last task's id.");
            }

            CrackTask firstCrackTask = crackTasks[firstCrackTaskId];
            CrackTask secondCrackTask = crackTasks[secondCrackTaskId];

            crackTasks[secondCrackTaskId] = firstCrackTask;
            CrackTaskMoved(this, new CrackManagerTaskMovedEventArgs(firstCrackTask,
                firstCrackTaskId, secondCrackTaskId));

            crackTasks[firstCrackTaskId] = secondCrackTask;
            CrackTaskMoved(this, new CrackManagerTaskMovedEventArgs(secondCrackTask,
                secondCrackTaskId, firstCrackTaskId));
        }
        public bool TrySwapTasks(int firstCrackTaskId, int secondCrackTaskId)
        {
            try
            {
                SwapTasks(firstCrackTaskId, secondCrackTaskId);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void MoveTask(int crackTaskId, int newCrackTaskId)
        {
            if (crackTaskId < 0)
            {
                throw new ArgumentOutOfRangeException("firstCrackTaskId", "TaskId cannot be less than 0.");
            }
            if (crackTaskId >= crackTasks.Count)
            {
                throw new ArgumentOutOfRangeException("firstCrackTaskId", "TaskId cannot be greater than last task's id.");
            }
            if (newCrackTaskId < 0)
            {
                throw new ArgumentOutOfRangeException("secondCrackTaskId", "TaskId cannot be less than 0.");
            }
            if (newCrackTaskId > crackTasks.Count)
            {
                throw new ArgumentOutOfRangeException("secondCrackTaskId", "TaskId cannot be greater than last task's id more than by 1.");
            }
            if (crackTaskId == newCrackTaskId)
            {
                throw new ArgumentException("NewCrackTask cannot be the same as CrackTaskId.", "newCrackTaskId");
            }

            CrackTask crackTask = crackTasks[crackTaskId];
            crackTasks.RemoveAt(crackTaskId);
            crackTasks.Insert(newCrackTaskId, crackTask);
            
            if(newCrackTaskId < crackTaskId)
            {
                CrackTaskMoved(this, new CrackManagerTaskMovedEventArgs(crackTask, crackTaskId, newCrackTaskId));

                for(int i = newCrackTaskId; i < crackTaskId; i++)
                {
                    CrackTask curCrackTask = crackTasks[i + 1];
                    CrackTaskMoved(this, new CrackManagerTaskMovedEventArgs(curCrackTask, i, i + 1));
                }
            }
            else
            {
                CrackTaskMoved(this, new CrackManagerTaskMovedEventArgs(crackTask, crackTaskId, newCrackTaskId - 1));

                for(int i = crackTaskId + 1; i < newCrackTaskId; i++)
                {
                    CrackTask curCrackTask = crackTasks[i - 1];
                    CrackTaskMoved(this, new CrackManagerTaskMovedEventArgs(curCrackTask, i, i - 1));
                }
            }
        }

        private void Cracker_Exited(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Cracker_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
