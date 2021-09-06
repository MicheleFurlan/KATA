

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace KataTest
{
    [TestClass]
    public class RGBtoHexTest
    {

        [TestMethod]
        public void ReturnCorrectHex()
        {
            Assert.AreEqual("FFFFFF", RGB2Hex.Rgb("255 255 255"));
            Assert.AreEqual("FFFFFF", RGB2Hex.Rgb("255 255 300"));
            Assert.AreEqual("000000", RGB2Hex.Rgb("0 0 0"));
            Assert.AreEqual("9400D3", RGB2Hex.Rgb("148 0 211"));
        }
    }

}