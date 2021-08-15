using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace FirstKataTest
{
    [TestClass]
    public class DisemvowelTest
    {

        [TestMethod]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual("Ths wbst s fr lsrs LL!", Disemvowel.Remove("This website is for losers LOL!"));
        }

        [TestMethod]
        public void MultilineString()
        {
            Assert.AreEqual("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd", Disemvowel.Remove("No offense but,\nYour writing is among the worst I've ever read"));
        }

        [TestMethod]
        public void OneMoreForGoodMeasure()
        {
            Assert.AreEqual("Wht r y,  cmmnst?", Disemvowel.Remove("What are you, a communist?"));
        }
    }

}
