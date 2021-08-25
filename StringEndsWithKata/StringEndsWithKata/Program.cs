//https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d/train/csharp


namespace Kata
{
    public class StringEndsWith
    {
        public static bool Solution(string str, string ending)
        {
            return str.EndsWith(ending);
        }

        public static void Main(string[] args)
        {
            StringEndsWith.Solution(args[0], args[1]);
        }
    }
}
