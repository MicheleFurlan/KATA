using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HiddenCubicNumbersKata;

namespace KataTest
{
    [TestClass]
    public class HiddenCubicNumbersTest
    {

        [TestMethod]
        public void ReturnsLuckyWhenNumbersAreContained()
        {
            Assert.AreEqual("0 1 153 154 Lucky", HiddenCubicNumbers.isSumOfCubes("aqdf&0#1xyz!22[153(777.777"));
        }

        [TestMethod]
        public void ReturnsUnluckyWhenNumbersAreNotContained()
        {
            Assert.AreEqual("Unlucky", HiddenCubicNumbers.isSumOfCubes("QK29a45[&erui9026315"));
        }

        [TestMethod]
        public void ReturnsLuckyWhenNumbersAreZeros()
        {
            Assert.AreEqual("0 0 Lucky", HiddenCubicNumbers.isSumOfCubes("0 9026315 -827&()"));
        }

    }

}

