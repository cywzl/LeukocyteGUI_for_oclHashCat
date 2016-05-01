using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace LeukocyteGUI_for_oclHashcat.Tests
{
    [TestClass]
    public class DataManagerTests
    {
        string crackTasksListFileName = "CrackTasksList.dat";

        [TestMethod]
        public void SaveToFile_SaveCrackTasksList_FileExists()
        {
            CrackTasksList crackTasksList = new CrackTasksList();
            ClearDirectory();

            DataManager.SaveToFile(crackTasksList.ToArray(), crackTasksListFileName);

            Assert.IsTrue(File.Exists(crackTasksListFileName));
        }

        [TestMethod]
        public void SaveToFile_GetFromFile_CorrectlyRestored()
        {
            CrackTasksList crackTasksList = new CrackTasksList();
            CrackTask crackTask = new CrackTask();
            crackTask.SessionSettings.Session = "test_task";
            crackTasksList.Add(crackTask);
            ClearDirectory();
            
            DataManager.SaveToFile(crackTasksList.ToArray(), crackTasksListFileName);
            CrackTask[] crackTasks = DataManager.GetFromFile<CrackTask[]>(crackTasksListFileName);
            crackTasksList = new CrackTasksList(crackTasks);

            Assert.AreEqual(crackTask.SessionSettings.Session, crackTasksList[0].SessionSettings.Session);
        }

        private void ClearDirectory()
        {
            if (File.Exists(crackTasksListFileName))
            {
                File.Delete(crackTasksListFileName);
            }
        }
    }
}
