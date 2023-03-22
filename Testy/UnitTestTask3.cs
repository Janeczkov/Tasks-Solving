using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskTests
{
    [TestClass]
    public class UnitTestTask3
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, Tasks.Task3.ArrayChallenge(new int[] { 12,2,6,7,11 }));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, Tasks.Task3.ArrayChallenge(new int[] { 6,4 }));
        }
    }
}
