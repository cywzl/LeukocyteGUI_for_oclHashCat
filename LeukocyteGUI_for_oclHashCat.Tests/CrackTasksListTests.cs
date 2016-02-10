using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeukocyteGUI_for_oclHashCat.Tests
{
    [TestClass]
    public class CrackTasksListTests
    {
        bool Add_Single_AddEventCalled_Flag;
        bool Add_Multiple_AddEventCalledAndRightArgs_Flag1;
        bool Add_Multiple_AddEventCalledAndRightArgs_Flag2;

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

        private void Add_Multiple_CrackTasksList_CrackTaskAdded(object sender, CrackTasksListTaskChangedEventArgs e)
        {
            if((!Add_Multiple_AddEventCalledAndRightArgs_Flag2)
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
