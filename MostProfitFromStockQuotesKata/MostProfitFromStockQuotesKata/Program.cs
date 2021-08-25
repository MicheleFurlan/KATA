//https://www.codewars.com/kata/597ef546ee48603f7a000057/train/csharp

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Kata
{
    public class MostProfitFromStockQuotes
    {

        public static int Calculate(string quotes)
        {
            // Change from string to int type
            int[] sequence = quotes.Substring(1, quotes.Length - 2).Split(',').Select(n => int.Parse(n.Trim())).ToArray();

            // Find max values
            List<int> tmp = new List<int>();
            for (int i = 1; i < sequence.Length; i++)
            {
                tmp.Add(sequence[i-1] - sequence[i]);
            }

            // Calculate differences within sequences
            List<string> BuyOrSell = new List<string>();

            int nOperations = sequence.Length - 1;
            for (int i = 0; i < nOperations; i++)
            {
                if (sequence[i] < sequence[i + 1])
                {
                    BuyOrSell.Add("Buy");
                }
                else if (sequence[i] > sequence[i + 1])
                {
                    if (BuyOrSell.Count > 0)
                    { 
                        if (BuyOrSell.Last() == "Sell")
                        {
                            BuyOrSell.Add("Buy");
                        }
                        else if (BuyOrSell.Last() == "None")
                        {
                            BuyOrSell.Add("None");
                        }
                        else
                        {
                            BuyOrSell.Add("Sell");
                        }
                    }
                    else if (BuyOrSell.Count == 0)
                    {
                        BuyOrSell.Add("None");
                    }


                }
                else if (sequence[i] == sequence[i + 1])
                {
                    BuyOrSell.Add("None");
                }
                Console.WriteLine(sequence[i]);
                Console.WriteLine(sequence[i + 1]);
                Console.WriteLine(BuyOrSell.Last());
            }

            // Last member

            if (sequence[sequence.Length-1]< sequence[sequence.Length - 2])
            {
                if (BuyOrSell.Last() == "None")
                {
                    BuyOrSell.Add("None");
                }
                else
                {
                    BuyOrSell.Add("Buy");
                }
            }
            else if (sequence[sequence.Length - 1] > sequence[sequence.Length - 2])
            {
                if (BuyOrSell.Last() == "Sell")
                {
                    BuyOrSell.Add("Buy");
                }
                else if (BuyOrSell.Last() == "None")
                {
                    BuyOrSell.Add("None");
                }
                else
                {
                    BuyOrSell.Add("Sell");
                }
            }
            else 
            {
                BuyOrSell.Add("None");
            }

            // Erase the last elements if they are 'buy'
            bool erase = true;
            while (erase == true)
            {
                if (BuyOrSell.Count > 0)
                {
                    if (BuyOrSell.Last() == "Buy")
                    {
                        BuyOrSell.RemoveAt(BuyOrSell.Count - 1);
                    }
                    else if (BuyOrSell.Last() == "Sell")
                    {
                        erase = false;
                    }
                    else if (BuyOrSell.Last() == "None")
                    {
                        BuyOrSell.RemoveAt(BuyOrSell.Count - 1);
                    }
                }
                else
                {
                    erase = false;
                }
            }

            // Sum
            List<int> NetGain = new List<int>();
            List<int> TmpGain = new List<int>();
            for (int i = 0; i < BuyOrSell.Count; i++)
            {
                if (BuyOrSell[i] == "Buy")
                {
                    TmpGain.Add(sequence[i] * -1);
                }
                if (BuyOrSell[i] == "Sell")
                {
                    var result = TmpGain.Select(n => n + sequence[i]);
                    NetGain.Add(result.Sum());
                    TmpGain.Clear();
                }
            }

            return NetGain.Sum();
        }

        public static void Main(string[] args)
        {
            MostProfitFromStockQuotes.Calculate(args[0]);
        }
    }
}
