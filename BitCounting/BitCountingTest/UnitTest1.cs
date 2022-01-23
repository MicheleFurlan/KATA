using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace BitCountingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountBitsReturns0()
        {
            Assert.AreEqual(0, Kata.CountBits(0));
        }

        [TestMethod]
        public void CountBitsReturns1given4()
        {
            Assert.AreEqual(1, Kata.CountBits(4));
        }

        [TestMethod]
        public void CountBitsReturns3given7()
        {
            Assert.AreEqual(3, Kata.CountBits(7));
        }

        [TestMethod]
        public void CountBitsReturns2given9()
        {
            Assert.AreEqual(2, Kata.CountBits(9));
        }

        [TestMethod]
        public void CountBitsReturns2given10()
        {
            Assert.AreEqual(2, Kata.CountBits(10));
        }
    }
}