//https://www.codewars.com/kata/513e08acc600c94f01000001/train/csharp
using System.Text.RegularExpressions;

namespace Kata
{
    public class RGB2Hex
    {
        public static string Rgb(int r, int g, int b)
        {
            return string.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
        }

        public static void Main(string[] args)
        {
            var RGB = Regex.Matches(args[0], @"\d{1,3}")
                .Cast<Match>()
                .Select(m => int.Parse(m.Value))
                .ToArray();

            RGB2Hex.Rgb(RGB[0], RGB[1], RGB[2]);
        }
    }
}


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
            //Assert.AreEqual("FFFFFF", Kata.Rgb(255, 255, 300));
            //Assert.AreEqual("000000", Kata.Rgb(0, 0, 0));
            //Assert.AreEqual("9400D3", Kata.Rgb(148, 0, 211));
            //Assert.AreEqual("9400D3", Kata.Rgb(148, -20, 211), "Handle negative numbers.");
            //Assert.AreEqual("90C3D4", Kata.Rgb(144, 195, 212));
            //Assert.AreEqual("D4350C", Kata.Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }
    }

}
