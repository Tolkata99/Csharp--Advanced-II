using System;
using System.Collections.Generic;

namespace Sets_and_Dictionaries_Advanced___Exercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SortedSet<string> names = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
