using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> ch = new Dictionary<char, int>();

            char[] tokens = Console.ReadLine().ToCharArray();

            for (int i = 0; i < tokens.Length; i++)
            {
                if(!ch.ContainsKey(tokens[i]))
                {
                    ch.Add(tokens[i], 0);
                }

                ch[tokens[i]]++;
            }

            foreach (var (chKey,timesValue) in ch.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{chKey}: {timesValue} time/s");
            }
        }
    }
}
