using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeukocyteGUI_for_oclHashCat.Tests
{
    [TestClass]
    public class CrackTasksListTests
    {
        bool Add_Single_AddEventCalled_Flag;

        bool Add_Multiple_AddEventCalledAndRightArgs_Flag1;
        bool Add_Multiple_AddEventCalledAndRightArgs_Flag2;

        bool MoveTask_From2To6_2to5_Flag;
        bool MoveTask_From2To6_3to2_Flag;
        bool MoveTask_From2To6_4to3_Flag;
        bool MoveTask_From2To6_5to4_Flag;

        bool MoveTask_From7to3_7to3_Flag;
        bool MoveTask_From7to3_3to4_Flag;
        bool MoveTask_From7to3_4to5_Flag;
        bool MoveTask_From7to3_5to6_Flag;
        bool MoveTask_From7to3_6to7_Flag;

        bool Insert_InsertionIn7_7to8_Flag;
        bool Insert_InsertionIn7_8to9_Flag;
        bool Insert_InsertionIn7_9to10_Flag;

        bool Insert_InsertionIn7_AddedOn7_Flag;

        [TestMethod]
        public void Add_Single_AddEventCalled()
        {
            var crackTasksList = new CrackTasksList();
            crackTasksList.CrackTaskAdded += Add_Single_CrackTasksList_CrackTaskAdded;
            var crackTask = new CrackTask();
            crackTask.CrackTarget = "test";

            crackTasksList.Add(crackTask);

            Assert.IsTrue(Add_Single_AddEventCalled_Flag);
        }

        [TestMethod]
        public void Add_Multiple_AddEventCalledAndRightArgs()
        {
            var crackTasksList = new CrackTasksList();
            crackTasksList.CrackTaskAdded += Add_Multiple_CrackTasksList_CrackTaskAdded;
            var crackTask1 = new CrackTask();
            crackTask1.CrackTarget = "test1";
            var crackTask2 = new CrackTask();
            crackTask2.CrackTarget = "test2";

            crackTasksList.Add(crackTask1);
            crackTasksList.Add(crackTask2);

            Assert.IsTrue(Add_Multiple_AddEventCalledAndRightArgs_Flag1);
            Assert.IsTrue(Add_Multiple_AddEventCalledAndRightArgs_Flag2);
        }

        [TestMethod]
        public void MoveTask_From2To6_Moved_2to5_3to2_4to3_5to4()
        {
            var crackTasksList = InitTestCrackTasksList();
            crackTasksList.CrackTaskMoved += MoveTask_From2To6_CrackTasksList_CrackTaskMoved;

            crackTasksList.MoveTask(2, 6);

            Assert.IsTrue(MoveTask_From2To6_2to5_Flag);
            Assert.IsTrue(MoveTask_From2To6_3to2_Flag);
            Assert.IsTrue(MoveTask_From2To6_4to3_Flag);
            Assert.IsTrue(MoveTask_From2To6_5to4_Flag);
        }

        [TestMethod]
        public void MoveTask_From7To3_Moved_7to3_3to4_4to5_5to6_6to7()
        {
            var crackTasksList = InitTestCrackTasksList();
            crackTasksList.CrackTaskMoved += MoveTask_From7To3_CrackTasksList_CrackTaskMoved;

            crackTasksList.MoveTask(7, 3);

            Assert.IsTrue(MoveTask_From7to3_7to3_Flag);
            Assert.IsTrue(MoveTask_From7to3_3to4_Flag);
            Assert.IsTrue(MoveTask_From7to3_4to5_Flag);
            Assert.IsTrue(MoveTask_From7to3_5to6_Flag);
            Assert.IsTrue(MoveTask_From7to3_6to7_Flag);
        }

        [TestMethod]
        public void Insert_InsertionIn7_Moved_7to8_8to9_9to10()
        {
            var crackTasksList = InitTestCrackTasksList();
            crackTasksList.CrackTaskMoved += Insert_InsertionIn7_CrackTasksList_CrackTaskMoved;
            var crackTaskInserted = new CrackTask();
            crackTaskInserted.SessionSettings.Session = "task_inserted";

            crackTasksList.Insert(7, crackTaskInserted);

            Assert.IsTrue(Insert_InsertionIn7_7to8_Flag);
            Assert.IsTrue(Insert_InsertionIn7_8to9_Flag);
            Assert.IsTrue(Insert_InsertionIn7_9to10_Flag);
        }

        [TestMethod]
        public void Insert_InsertionIn7_TaskAddedEventCalledAndRightArgs()
        {
            var crackTasksList = InitTestCrackTasksList();
            crackTasksList.CrackTaskAdded += Insert_InsertionIn7_CrackTasksList_CrackTaskAdded;
            var crackTaskInserted = new CrackTask();
            crackTaskInserted.SessionSettings.Session = "task_inserted";

            crackTasksList.Insert(7, crackTaskInserted);

            Assert.IsTrue(Insert_InsertionIn7_AddedOn7_Flag);
        }


        private CrackTasksList InitTestCrackTasksList()
        {
            var crackTasksList = new CrackTasksList();

            for (int i = 0; i < 10; i++)
            {
                var crackTask = new CrackTask();
                crackTask.SessionSettings.Session = "task#" + i;
                crackTasksList.Add(crackTask);
            }

            return crackTasksList;
        }


        private void Insert_InsertionIn7_CrackTasksList_CrackTaskAdded(object sender, CrackTasksListTaskChangedEventArgs e)
        {
            if ((e.CrackTaskId == 7)
                && (e.CrackTask.SessionSettings.Session == "task_inserted"))
            {
                Insert_InsertionIn7_AddedOn7_Flag = true;
            }
        }

        private void Insert_InsertionIn7_CrackTasksList_CrackTaskMoved(object sender, CrackTasksListTaskMovedEventArgs e)
        {
            if ((e.CrackTaskOldId == 7) && (e.CrackTaskNewId == 8)
                && (e.CrackTask.SessionSettings.Session == "task#7"))
            {
                Insert_InsertionIn7_7to8_Flag = true;
            }
            if ((e.CrackTaskOldId == 8) && (e.CrackTaskNewId == 9)
                && (e.CrackTask.SessionSettings.Session == "task#8"))
            {
                Insert_InsertionIn7_8to9_Flag = true;
            }
            if ((e.CrackTaskOldId == 9) && (e.CrackTaskNewId == 10)
                && (e.CrackTask.SessionSettings.Session == "task#9"))
            {
                Insert_InsertionIn7_9to10_Flag = true;
            }
        }

        private void MoveTask_From7To3_CrackTasksList_CrackTaskMoved(object sender, CrackTasksListTaskMovedEventArgs e)
        {
            if ((e.CrackTaskOldId == 7) && (e.CrackTaskNewId == 3)
                && (e.CrackTask.SessionSettings.Session == "task#7"))
            {
                MoveTask_From7to3_7to3_Flag = true;
            }
            if ((e.CrackTaskOldId == 3) && (e.CrackTaskNewId == 4)
                && (e.CrackTask.SessionSettings.Session == "task#3"))
            {
                MoveTask_From7to3_3to4_Flag = true;
            }
            if ((e.CrackTaskOldId == 4) && (e.CrackTaskNewId == 5)
                && (e.CrackTask.SessionSettings.Session == "task#4"))
            {
                MoveTask_From7to3_4to5_Flag = true;
            }
            if ((e.CrackTaskOldId == 5) && (e.CrackTaskNewId == 6)
                && (e.CrackTask.SessionSettings.Session == "task#5"))
            {
                MoveTask_From7to3_5to6_Flag = true;
            }
            if ((e.CrackTaskOldId == 6) && (e.CrackTaskNewId == 7)
                && (e.CrackTask.SessionSettings.Session == "task#6"))
            {
                MoveTask_From7to3_6to7_Flag = true;
            }
        }

        private void MoveTask_From2To6_CrackTasksList_CrackTaskMoved(object sender, CrackTasksListTaskMovedEventArgs e)
        {
            if ((e.CrackTaskOldId == 2) && (e.CrackTaskNewId == 5)
                && (e.CrackTask.SessionSettings.Session == "task#2"))
            {
                MoveTask_From2To6_2to5_Flag = true;
            }
            if ((e.CrackTaskOldId == 3) && (e.CrackTaskNewId == 2)
                && (e.CrackTask.SessionSettings.Session == "task#3"))
            {
                MoveTask_From2To6_3to2_Flag = true;
            }
            if ((e.CrackTaskOldId == 4) && (e.CrackTaskNewId == 3)
                && (e.CrackTask.SessionSettings.Session == "task#4"))
            {
                MoveTask_From2To6_4to3_Flag = true;
            }
            if ((e.CrackTaskOldId == 5) && (e.CrackTaskNewId == 4)
                && (e.CrackTask.SessionSettings.Session == "task#5"))
            {
                MoveTask_From2To6_5to4_Flag = true;
            }
        }

        private void Add_Multiple_CrackTasksList_CrackTaskAdded(object sender, CrackTasksListTaskChangedEventArgs e)
        {
            if ((!Add_Multiple_AddEventCalledAndRightArgs_Flag2)
                && e.CrackTask.CrackTarget == "test1"
                && e.CrackTaskId == 0)
            {
                Add_Multiple_AddEventCalledAndRightArgs_Flag1 = true;
            }
            else if (Add_Multiple_AddEventCalledAndRightArgs_Flag1
                && e.CrackTask.CrackTarget == "test2"
                && e.CrackTaskId == 1)
            {
                Add_Multiple_AddEventCalledAndRightArgs_Flag2 = true;
            }
        }

        private void Add_Single_CrackTasksList_CrackTaskAdded(object sender, CrackTasksListTaskChangedEventArgs e)
        {
            Add_Single_AddEventCalled_Flag = true;
        }


    }
}
