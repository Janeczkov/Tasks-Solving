using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskTests
{
    [TestClass]
    public class UnitTestTask2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("jc", Tasks.Task2.StringChallenge("abjchba"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("not possible", Tasks.Task2.StringChallenge("mmop"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("k", Tasks.Task2.StringChallenge("kjjjhjjj"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("palindrome", Tasks.Task2.StringChallenge("abba"));
        }
    }
}
