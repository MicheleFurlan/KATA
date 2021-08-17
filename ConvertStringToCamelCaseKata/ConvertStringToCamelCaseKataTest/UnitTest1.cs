using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace ConvertToCamelcaseTest
{
    [TestClass]
    public class ConvertToCamelcaseTest
    {

        [TestMethod]
        public void ConvertWithUnderscore()
        {
            Assert.AreEqual("theStealthWarrior", ConvertToCamelcase.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");

        }

        [TestMethod]
        public void ConvertWithHyphen()
        {
            Assert.AreEqual("TheStealthWarrior", ConvertToCamelcase.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");

        }

    }

}

    