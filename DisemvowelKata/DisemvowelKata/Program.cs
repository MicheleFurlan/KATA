using System;
using System.Text.RegularExpressions;

namespace Kata
{
    public class Disemvowel
    {
        public static string Remove(string name)
        {
            name = Regex.Replace(name, "[aeiou]", "", RegexOptions.IgnoreCase);
            return name;
        }

        public static void Main(string[] args)
        {
            Disemvowel.Remove(args[0]);
        }
    }
}
