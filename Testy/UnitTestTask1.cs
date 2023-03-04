using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testy
{
    [TestClass]
    public class UnitTestTask1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("1t1e1s1t", TestyDoCV.Task1.StringChallenge("test"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("2a2b1c1d1e", TestyDoCV.Task1.StringChallenge("aabbcde"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("3w3b1w", TestyDoCV.Task1.StringChallenge("wwwbbbw"));
        }
    }
}
