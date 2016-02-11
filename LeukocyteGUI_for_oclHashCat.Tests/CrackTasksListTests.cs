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
            var crackTasksList = new CrackTasksList();
            crackTasksList.CrackTaskMoved += MoveTask_From2To6_CrackTasksList_CrackTaskMoved;

            for (int i = 0; i < 10; i++)
            {
                var crackTask = new CrackTask();
                crackTask.SessionSettings.Session = "task#" + i;
                crackTasksList.Add(crackTask);
            }

            crackTasksList.MoveTask(2, 6);

            Assert.IsTrue(MoveTask_From2To6_2to5_Flag);
            Assert.IsTrue(MoveTask_From2To6_3to2_Flag);
            Assert.IsTrue(MoveTask_From2To6_4to3_Flag);
            Assert.IsTrue(MoveTask_From2To6_5to4_Flag);
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
