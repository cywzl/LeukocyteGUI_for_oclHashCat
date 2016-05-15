using System;
using System.Collections.Generic;

namespace LeukocyteCore_for_oclHashcat.Classes
{
    public class CrackTasksListTaskChangedEventArgs : EventArgs
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

        public CrackTasksListTaskChangedEventArgs(CrackTask crackTask, int crackTaskId) : base()
        {
            this.crackTask = crackTask;
            this.crackTaskId = crackTaskId;
        }
    }
    public class CrackTasksListTaskMovedEventArgs : EventArgs
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

        public CrackTasksListTaskMovedEventArgs(CrackTask crackTask, int crackTaskOldId, int crackTaskNewId) : base()
        {
            this.crackTask = crackTask;
            this.crackTaskOldId = crackTaskOldId;
            this.crackTaskNewId = crackTaskNewId;
        }
    }

    [Serializable()]
    public class CrackTasksList : List<CrackTask>
    {
        public delegate void CrackTasksListTaskChangedEventHandler(object sender, CrackTasksListTaskChangedEventArgs e);
        public delegate void CrackTasksListTaskMovedEventHandler(object sender, CrackTasksListTaskMovedEventArgs e);
        public delegate void CrackTasksListEventHandler(object sender, EventArgs e);

        public event CrackTasksListTaskChangedEventHandler CrackTaskAdded = delegate { };
        public event CrackTasksListTaskChangedEventHandler CrackTaskRemoved = delegate { };
        public event CrackTasksListTaskChangedEventHandler CrackTaskChanged = delegate { };
        public event CrackTasksListTaskMovedEventHandler CrackTaskMoved = delegate { };
        public event CrackTasksListEventHandler CrackTasksCleared = delegate { };

        public CrackTasksList() : base() { }
        public CrackTasksList(int capacity) : base(capacity) { }
        public CrackTasksList(IEnumerable<CrackTask> collection) : base(collection) { }

        public void CheckCrackTaskIdException(int crackTaskId)
        {
            if (crackTaskId < 0)
            {
                throw new ArgumentOutOfRangeException("TaskId cannot be less than 0.");
            }
            if (crackTaskId >= Count)
            {
                throw new ArgumentOutOfRangeException("TaskId cannot be greater than last task's id.");
            }
        }

        public new void Add(CrackTask crackTask)
        {
            base.Add(crackTask);
            CrackTaskAdded(this, new CrackTasksListTaskChangedEventArgs(crackTask, Count - 1));
        }
        public new bool Remove(CrackTask crackTask)
        {
            int index = IndexOf(crackTask);

            if (index > -1)
            {
                RemoveAt(index);

                return true;
            }
            else
            {
                return false;
            }
        }
        public new void RemoveAt(int crackTaskId)
        {
            CrackTask crackTask = this[crackTaskId];
            base.RemoveAt(crackTaskId);
            CrackTaskRemoved(this, new CrackTasksListTaskChangedEventArgs(crackTask, crackTaskId));

            for (int i = crackTaskId; i < Count; i++)
            {
                CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(this[i], i + 1, i));
            }
        }
        public new void Clear()
        {
            base.Clear();
            CrackTasksCleared(this, new EventArgs());
        }
        public new void Insert(int crackTaskId, CrackTask crackTask)
        {
            base.Insert(crackTaskId, crackTask);
            CrackTaskAdded(this, new CrackTasksListTaskChangedEventArgs(crackTask, crackTaskId));

            for (int i = crackTaskId + 1; i < Count; i++)
            {
                CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(this[i], i - 1, i));
            }
        }
        public void SwapTasks(int firstCrackTaskId, int secondCrackTaskId)
        {
            CheckCrackTaskIdException(firstCrackTaskId);
            CheckCrackTaskIdException(secondCrackTaskId);

            CrackTask firstCrackTask = this[firstCrackTaskId];
            CrackTask secondCrackTask = this[secondCrackTaskId];

            this[secondCrackTaskId] = firstCrackTask;
            CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(firstCrackTask,
                firstCrackTaskId, secondCrackTaskId));

            this[firstCrackTaskId] = secondCrackTask;
            CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(secondCrackTask,
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
            CheckCrackTaskIdException(crackTaskId);

            if (newCrackTaskId < 0)
            {
                throw new ArgumentOutOfRangeException("secondCrackTaskId", "TaskId cannot be less than 0.");
            }
            if (newCrackTaskId > Count)
            {
                throw new ArgumentOutOfRangeException("secondCrackTaskId", "TaskId cannot be greater than last task's id more than by 1.");
            }
            if (crackTaskId == newCrackTaskId)
            {
                throw new ArgumentException("NewCrackTask cannot be the same as CrackTaskId.", "newCrackTaskId");
            }

            CrackTask crackTask = this[crackTaskId];
            base.RemoveAt(crackTaskId);
            base.Insert(newCrackTaskId, crackTask);

            if (newCrackTaskId < crackTaskId)
            {
                CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(crackTask, crackTaskId, newCrackTaskId));

                for (int i = newCrackTaskId; i < crackTaskId; i++)
                {
                    CrackTask curCrackTask = this[i + 1];
                    CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(curCrackTask, i, i + 1));
                }
            }
            else
            {
                CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(crackTask, crackTaskId, newCrackTaskId - 1));

                for (int i = crackTaskId + 1; i < newCrackTaskId; i++)
                {
                    CrackTask curCrackTask = this[i - 1];
                    CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(curCrackTask, i, i - 1));
                }
            }
        }
        public void UpdateTask(int crackTaskId, CrackTask crackTask)
        {
            CheckCrackTaskIdException(crackTaskId);
            this[crackTaskId] = crackTask;
            CrackTaskChanged(this, new CrackTasksListTaskChangedEventArgs(crackTask, crackTaskId));
        }
        public bool TryUpdateTask(int crackTaskId, CrackTask crackTask)
        {
            try
            {
                UpdateTask(crackTaskId, crackTask);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
