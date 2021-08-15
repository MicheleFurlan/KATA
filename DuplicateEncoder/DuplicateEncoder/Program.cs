using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuplicateEncoderKata
{
    public class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {

            // Init dictionary
            var map = new Dictionary<char, int>();

            // Init output
            var builder = new StringBuilder();

            for (int i = 0; i< word.ToLower().Length; i++)
            {
                var count = word.Count(x => x == word.ToLower()[i]);

                if (count > 1)
                {
                    builder.Append(')');
                }
                else
                {
                    builder.Append('(');
                }
            }

            // Convert to string
            word = builder.ToString();

            return word;
        }

        public static void Main(string[] args)
        {
            DuplicateEncoder.DuplicateEncode(args[0]);
            //Console.WriteLine(DuplicateEncoder.DuplicateEncode("(( @"));
        }
    }
}

