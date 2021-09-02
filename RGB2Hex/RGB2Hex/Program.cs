using System;
using System.Text.RegularExpressions;

namespace RGB2Hex
{
    public class RGB2Hex
    {
        public static string Rgb(int r, int g, int b)
        {
            return "FFF";
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

