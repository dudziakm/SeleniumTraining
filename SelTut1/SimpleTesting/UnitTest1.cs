using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 5;
            int y = 10;

            int sum = x + y;

            Assert.AreEqual(15, sum);
        }
    }
}
