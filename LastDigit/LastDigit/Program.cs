// https://www.codewars.com/kata/584dee06fe9c9aef810001e8/train/csharp
using System;
using System.Collections.Generic;
using System.Numerics; 

namespace Kata
{
    public class GreenNumbers
    {

        public static BigInteger Get(int v)
        {
            //List<int> list1 = new List<int>();
            int n = 0;
            double result = 0;

            //for (int i = 0; list1.Count <= v; i++)
            for (int i = 0; n <= v; i++)
            {

                double s = Math.Pow(i, 2);
                int il = i.ToString().Length;
                var ss = s.ToString();
                string s1 = ss.Substring(ss.Length - il, il);

                if (s1 == i.ToString())
                {
                    result = i;
                    n++;
                }
            }

            return (BigInteger)result;// list1[list1.Count - 1];
        }

        static void Main() {}

    }
}
