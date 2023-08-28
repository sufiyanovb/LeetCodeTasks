using LeetCodeTasks;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        #region 6. Zigzag Conversion
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(new Solution().Convert("PAYPALISHIRING", 3), "PAHNAPLSIIGYIR");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(new Solution().Convert("PAYPALISHIRING", 4), "PINALSIGYAHRPI");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(new Solution().Convert("A", 1), "A");
        } 
        #endregion
    }
}