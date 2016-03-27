using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeukocyteGUI_for_oclHashCat.Tests
{
    [TestClass]
    public class CrackTaskTests
    {
        [TestMethod]
        public void ToString_Mask_Sample()
        {
            var crackTask = new CrackTask();
            crackTask.AttackMode = AttackModes.BruteForce;
            crackTask.CrackDataSourceLeft = "?l?l?l?l?l?l?l";
            crackTask.CrackTarget = "7ac66c0f148de9519b8bd264312c4d64";

            string hashcatString = crackTask.ToString();

            Assert.AreEqual(hashcatString, "-a 3 -m 0 --workload-profile=2 7ac66c0f148de9519b8bd264312c4d64 ?l?l?l?l?l?l?l", false);
        }

        [TestMethod]
        public void ToString_Mask_Restore()
        {
            var crackTask = new CrackTask();
            crackTask.AttackMode = AttackModes.BruteForce;
            crackTask.CrackDataSourceLeft = "?l?l?l?l?l?l?l";
            crackTask.CrackTarget = "7ac66c0f148de9519b8bd264312c4d64";
            crackTask.SessionSettings.Session = "testSession";
            crackTask.SessionSettings.Restore = true;

            string hashcatString = crackTask.ToString();

            Assert.AreEqual(hashcatString, "--restore --session=testSession", false);
        }
    }
}
