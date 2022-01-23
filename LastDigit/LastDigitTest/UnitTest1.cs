using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using Kata;

namespace LastDigitTest
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void BasicTests()
        {
            Assert.AreEqual(new BigInteger(1), GreenNumbers.Get(1), "for n = 1");
            Assert.AreEqual(new BigInteger(5), GreenNumbers.Get(2), "for n = 2");
            Assert.AreEqual(new BigInteger(6), GreenNumbers.Get(3), "for n = 3");
            Assert.AreEqual(new BigInteger(25), GreenNumbers.Get(4), "for n = 4");
        }

        [TestMethod]
        public void BiggerTests()
        {
            Assert.AreEqual(new BigInteger(2890625), GreenNumbers.Get(12), "for n = 12");
            //Assert.AreEqual(new BigInteger(7109376), GreenNumbers.Get(13), "for n = 13");
        }

        [TestMethod]
        public void AdvancedTests()
        {
            Assert.AreEqual(BigInteger.Parse("6188999442576576769103890995893380022607743740081787109376"), GreenNumbers.Get(100), "for n = 100");
            Assert.AreEqual(BigInteger.Parse("9580863811000557423423230896109004106619977392256259918212890625"), GreenNumbers.Get(110), "for n = 110");
        }
    }
}