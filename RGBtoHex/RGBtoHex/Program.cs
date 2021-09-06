//https://www.codewars.com/kata/513e08acc600c94f01000001/train/csharp
using System.Text.RegularExpressions;
using System.Linq;

namespace Kata
{
    public class RGB2Hex
    {
        public static string Rgb(string numbers)
        {
            var RGB = Regex.Matches(numbers, @"\d{1,3}")
                .Cast<Match>()
                .Select(m => int.Parse(m.Value))
                .Select(x => x > 255 ? 255 : x)
                .Select(x => x < 0 ? 0 : x)
                .ToArray();

            return string.Format("{0:X2}{1:X2}{2:X2}", RGB[0], RGB[1], RGB[2]);
        }

        public static void Main(string[] args)
        {
            RGB2Hex.Rgb(args[0]);
        }
    }
}

