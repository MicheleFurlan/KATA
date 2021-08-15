using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DuplicateEncoderKata;

namespace KataTest
{
    [TestClass]
    public class DisemvowelTest
    {

        [TestMethod]
        public void DifferentLetters()
        {
            Assert.AreEqual("(((", DuplicateEncoder.DuplicateEncode("din"));
        }

        [TestMethod]
        public void RepeatedLetters()
        {
            Assert.AreEqual("()()()", DuplicateEncoder.DuplicateEncode("recede"));
        }

        [TestMethod]
        public void RepeatedLettersInArray()
        {
            Assert.AreEqual(")())())", DuplicateEncoder.DuplicateEncode("Success"), "should ignore case");
        }

        [TestMethod]
        public void NoLettersButSimbols()
        {
            Assert.AreEqual("))((", DuplicateEncoder.DuplicateEncode("(( @"));
        }
    }

}
