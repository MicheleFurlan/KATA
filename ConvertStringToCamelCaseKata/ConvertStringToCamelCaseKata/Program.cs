using System.Text;
using System.Text.RegularExpressions;

namespace Kata
{
    public class ConvertToCamelcase
    {
        public static string ToCamelCase(string name)
        {
            return Regex.Replace(name, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
        }

        public static void Main(string[] args)
        {
            ConvertToCamelcase.ToCamelCase(args[0]);
        }
    }
}
