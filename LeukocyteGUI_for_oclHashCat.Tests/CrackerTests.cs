using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeukocyteGUI_for_oclHashCat.Tests
{
    [TestClass]
    public class CrackerTests
    {
        [TestMethod]
        public void Crack_single_md5hash_CorrectCrackResults()
        {
            Cracker cracker = InitCracker();
            CrackTask crackTask = new CrackTask();
            crackTask.CrackTarget = "ab56b4d92b40713acc5af89985d4b786";
            crackTask.AttackMode = AttackModes.BruteForce;
            crackTask.HashType = 0;
            crackTask.CrackDataSource = "?l?l?l?l?l";
            crackTask.FilesSettings.PotfileDisable = true;
            cracker.CrackTasks.Add(crackTask);

            cracker.Crack(0);
            cracker.WaitForStop();
            
            Assert.AreEqual("abcde", cracker.CrackTasks[0].Plain, false);
            Assert.AreEqual(CrackStatuses.Cracked, cracker.CrackTasks[0].CrackStatus);
            Assert.AreEqual(5, cracker.CrackTasks[0].CurrentLength);
            Assert.AreEqual(1, cracker.CrackTasks[0].RecoveredDigests);
            Assert.AreEqual(1, cracker.CrackTasks[0].Digests);
            Assert.AreEqual(1, cracker.CrackTasks[0].RecoveredSalts);
            Assert.AreEqual(1, cracker.CrackTasks[0].Salts);
        }

        private Cracker InitCracker()
        {
            Cracker cracker = new Cracker(@"E:\Program Files (x86)\oclHashcat\oclHashcat64.exe",
                @"E:\Program Files (x86)\oclHashcat\");
            return cracker;
        }
    }
}
