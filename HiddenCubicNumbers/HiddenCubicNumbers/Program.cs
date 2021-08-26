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

            // Identify numbers in string
            string[] numbers = Regex.Split(s, @"\D+");

            // Detect and separate numbers longer than 3 digits
            for (int x = 0; x<numbers.Count();x++)
            {
                string value = numbers[x];
                if (value.Length>3)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (i % 3 == 0)
                            sb.Append(' ');
                        sb.Append(value[i]);
                    }
                    string formatted = sb.ToString();

                    numbers = numbers.Concat(formatted.Split()).ToArray();

                }
            }

            // Remove empty spaced
            numbers = numbers.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            numbers = numbers.Where(x => x.Length<4).ToArray();

            // Implement
            var outcome = new List<bool>();
            var result = new List<int>();
            var cubic = new List<int>();
            StringBuilder cubic_str = new StringBuilder();
            foreach (string value in numbers)
            {
                
                var charArray = value.ToString().ToCharArray();

                int[] Aint = charArray.Select(a => a - '0').ToArray();

                for (int i = 0; i < Aint.Length; i++)
                {
                    result.Add(Aint[i] * Aint[i] * Aint[i]);
                }

                if (result.Sum() == int.Parse(value))
                {
                    outcome.Add(true);
                    cubic.Add(int.Parse(value));
                    cubic_str.Append(int.Parse(value));
                    cubic_str.Append(" ");
                }
                else
                {
                    outcome.Add(false);
                }
                result.Clear();
            }

            // Set output
            if (outcome.Any(x => x))
            {
                cubic_str.Append(cubic.Sum());
                cubic_str.Append(" Lucky");
                return cubic_str.ToString();
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

