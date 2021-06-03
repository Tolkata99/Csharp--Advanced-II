using System;
using System.Collections.Generic;

namespace _5._Record_Unique_Names
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<string> unique = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string names = Console.ReadLine();

                unique.Add(names);
            }

            foreach (var name in unique)
            {
                Console.WriteLine(name);
            }
        }
    }
}
