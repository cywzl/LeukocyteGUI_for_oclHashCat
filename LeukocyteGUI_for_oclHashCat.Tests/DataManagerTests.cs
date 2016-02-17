using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace LeukocyteGUI_for_oclHashCat.Tests
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

            DataManager.SaveToFile(crackTasksList, crackTasksListFileName);

            Assert.IsTrue(File.Exists(crackTasksListFileName));
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
