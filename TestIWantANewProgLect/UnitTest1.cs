using prjILieToSirAboutUnitTesting;

namespace TestIWantANewProgLect
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestgetName()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getName();
            String Expected = "Jeff";
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestEmail()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getEMail();
            String Expected = "jess@gmail.com";
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestAge()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getDate();
            String Expected = "2024/05/04";
            Assert.AreEqual(Expected, Actual);
        }
    }
}