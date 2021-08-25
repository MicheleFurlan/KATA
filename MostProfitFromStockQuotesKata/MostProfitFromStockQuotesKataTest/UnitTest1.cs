using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace FirstKataTest
{
    [TestClass]

    public class MostProfitFromStockQuotesKataTest
    {

        [TestMethod]
        public void Return15()
        {
            Assert.AreEqual(15, MostProfitFromStockQuotes.Calculate("[1, 2, 3, 4, 5, 6]"));
        }

        [TestMethod]
        public void Return0()
        {
            Assert.AreEqual(0, MostProfitFromStockQuotes.Calculate("[6, 5, 4, 3, 2, 1]"));
        }

        [TestMethod]
        public void Return18()
        {
            Assert.AreEqual(18, MostProfitFromStockQuotes.Calculate("[ 1, 6, 5, 10, 8, 7 ]"));
        }

        [TestMethod]
        public void Return26()
        {
            Assert.AreEqual(26, MostProfitFromStockQuotes.Calculate("[ 1, 2, 10, 3, 2, 7, 3, 2 ]"));
        }
    }

}
