using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dictionaries_Advanced
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> times = new Dictionary<double, int>();

            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var item in input)
            {
                if (times.ContainsKey(item) == false)
                {
                    times.Add(item, 0);
                }


                times[item]++;

            }

            foreach (var (key, value) in times)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
