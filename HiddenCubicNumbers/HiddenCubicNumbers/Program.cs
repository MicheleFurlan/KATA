//https://www.codewars.com/kata/55031bba8cba40ada90011c4/train/csharp

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using static System.Math;

namespace HiddenCubicNumbersKata
{
    public class HiddenCubicNumbers
    {
        public static string isSumOfCubes(string s)
        {

            // Extract numbers
            var numbers = Regex.Matches(s, @"\d{1,3}")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();

            // Check if any magic cube exists
            var exist = numbers.Where(x => x
                .Select(c => Pow((int)char.GetNumericValue(c), 3)).Sum() == int.Parse(x))
                .Select(x => int.Parse(x));

            // Produce output
            if (exist.Any())
            {
                return exist.Aggregate(string.Empty, (a, b) => a + b + ' ') + exist.Sum() + " Lucky";
            }
            else
            {
                return "Unlucky";
            }
        }

        public static void Main(string[] args)
        {
            HiddenCubicNumbers.isSumOfCubes(args[0]);
        }
    }
}

