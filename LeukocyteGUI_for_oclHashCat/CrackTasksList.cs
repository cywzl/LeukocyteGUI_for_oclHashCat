using System;
using System.Collections.Generic;
using System.Collections;

namespace LeukocyteGUI_for_oclHashCat
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
    public class CrackTasksList : IList<CrackTask>
    {
        public delegate void CrackTasksListTaskChangedEventHandler(object sender, CrackTasksListTaskChangedEventArgs e);
        public delegate void CrackTasksListTaskMovedEventHandler(object sender, CrackTasksListTaskMovedEventArgs e);
        public delegate void CrackTasksListEventHandler(object sender, EventArgs e);

        public event CrackTasksListTaskChangedEventHandler CrackTaskAdded = delegate { };
        public event CrackTasksListTaskChangedEventHandler CrackTaskRemoved = delegate { };
        public event CrackTasksListTaskChangedEventHandler CrackTaskChanged = delegate { };
        public event CrackTasksListTaskMovedEventHandler CrackTaskMoved = delegate { };
        public event CrackTasksListEventHandler CrackTasksCleared = delegate { };

        List<CrackTask> crackTasks;

        public int Count
        {
            get
            {
                return crackTasks.Count;
            }
        }
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public CrackTask this[int crackTaskId]
        {
            get
            {
                CheckCrackTaskIdException(crackTaskId);
                return crackTasks[crackTaskId];
            }
            set
            {
                CheckCrackTaskIdException(crackTaskId);
                crackTasks[crackTaskId] = value;
            }
        }

        public CrackTasksList()
        {
            crackTasks = new List<CrackTask>();
        }

        IEnumerator<CrackTask> IEnumerable<CrackTask>.GetEnumerator()
        {
            return crackTasks.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return crackTasks.GetEnumerator();
        }

        public void CheckCrackTaskIdException(int crackTaskId)
        {
            if (crackTaskId < 0)
            {
                throw new ArgumentOutOfRangeException("TaskId cannot be less than 0.");
            }
            if (crackTaskId >= crackTasks.Count)
            {
                throw new ArgumentOutOfRangeException("TaskId cannot be greater than last task's id.");
            }
        }
        public void Add(CrackTask crackTask)
        {
            crackTasks.Add(crackTask);
            CrackTaskAdded(this, new CrackTasksListTaskChangedEventArgs(crackTask, crackTasks.Count - 1));
        }
        public bool Remove(CrackTask crackTask)
        {
            int index = crackTasks.IndexOf(crackTask);

            if (index > -1)
            {
                crackTasks.RemoveAt(index);
                CrackTaskRemoved(this, new CrackTasksListTaskChangedEventArgs(crackTask, index));

                for (int i = index; i < crackTasks.Count; i++)
                {
                    CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(crackTasks[i], i + 1, i));
                }

                return true;
            }
            else
            {
                return false;
            }
        }
        public void RemoveAt(int crackTaskId)
        {
            CheckCrackTaskIdException(crackTaskId);

            CrackTask crackTask = crackTasks[crackTaskId];
            crackTasks.RemoveAt(crackTaskId);
            CrackTaskRemoved(this, new CrackTasksListTaskChangedEventArgs(crackTask, crackTaskId));

            for (int i = crackTaskId; i < crackTasks.Count; i++)
            {
                CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(crackTasks[i], i + 1, i));
            }
        }
        public void Clear()
        {
            crackTasks.Clear();
            CrackTasksCleared(this, new EventArgs());
        }
        public int IndexOf(CrackTask crackTask)
        {
            return crackTasks.IndexOf(crackTask);
        }
        public bool Contains(CrackTask crackTask)
        {
            return crackTasks.Contains(crackTask);
        }
        public void Insert(int crackTaskId, CrackTask crackTask)
        {
            if (crackTaskId < 0)
            {
                throw new ArgumentOutOfRangeException("secondCrackTaskId", "TaskId cannot be less than 0.");
            }
            if (crackTaskId > crackTasks.Count)
            {
                throw new ArgumentOutOfRangeException("secondCrackTaskId", "TaskId cannot be greater than last task's id more than by 1.");
            }

            crackTasks.Insert(crackTaskId, crackTask);
            CrackTaskAdded(this, new CrackTasksListTaskChangedEventArgs(crackTask, crackTaskId));

            for (int i = crackTaskId + 1; i < crackTasks.Count; i++)
            {
                CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(crackTasks[i], i - 1, i));
            }
        }
        public void CopyTo(CrackTask[] array, int arrayIndex)
        {
            crackTasks.CopyTo(array, arrayIndex);
        }
        public void SwapTasks(int firstCrackTaskId, int secondCrackTaskId)
        {
            CheckCrackTaskIdException(firstCrackTaskId);
            CheckCrackTaskIdException(secondCrackTaskId);

            CrackTask firstCrackTask = crackTasks[firstCrackTaskId];
            CrackTask secondCrackTask = crackTasks[secondCrackTaskId];

            crackTasks[secondCrackTaskId] = firstCrackTask;
            CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(firstCrackTask,
                firstCrackTaskId, secondCrackTaskId));

            crackTasks[firstCrackTaskId] = secondCrackTask;
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

            if (newCrackTaskId < crackTaskId)
            {
                CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(crackTask, crackTaskId, newCrackTaskId));

                for (int i = newCrackTaskId; i < crackTaskId; i++)
                {
                    CrackTask curCrackTask = crackTasks[i + 1];
                    CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(curCrackTask, i, i + 1));
                }
            }
            else
            {
                CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(crackTask, crackTaskId, newCrackTaskId - 1));

                for (int i = crackTaskId + 1; i < newCrackTaskId; i++)
                {
                    CrackTask curCrackTask = crackTasks[i - 1];
                    CrackTaskMoved(this, new CrackTasksListTaskMovedEventArgs(curCrackTask, i, i - 1));
                }
            }
        }
        public void UpdateTask(int crackTaskId, CrackTask crackTask)
        {
            CheckCrackTaskIdException(crackTaskId);
            crackTasks[crackTaskId] = crackTask;
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
