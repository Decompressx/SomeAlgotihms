using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeAlgorithms;


namespace MyAlgorithmTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReverse()
        {
            string str = "����";
            string reverseStr = str.Reverse();

            Assert.AreEqual(reverseStr,"����");
        }

        [TestMethod]
        public void TestReverseNull()
        {
            string str = null;
            string reverseStr = str.Reverse();

            Assert.AreEqual(reverseStr, null);
        }
    }
}
