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
            word = word.ToLower();
            var vec = Encoding.UTF8.GetBytes(word.ToCharArray());

            // Init output
            var builder = new StringBuilder();

            for (int i = 0; i< vec.Length; i++)
            {
                var count = vec.Count(x => x == vec[i]);

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
        }
    }
}

