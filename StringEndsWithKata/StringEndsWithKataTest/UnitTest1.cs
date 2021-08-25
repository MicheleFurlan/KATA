using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace KataTest
{
    [TestClass]
    public class StringEndsWithTest
    {

        [TestMethod]
        public void ReturnTrueWhenStringEndsWithLetters()
        {
            Assert.AreEqual(true, StringEndsWith.Solution("abc", "bc"));
        }

        [TestMethod]
        public void ReturnFalseWhenStringDoesNotEndsWithLetters()
        {
            Assert.AreEqual(false, StringEndsWith.Solution("abc", "d"));
        }
    }

}
