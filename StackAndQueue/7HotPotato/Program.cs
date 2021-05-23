using System;
using System.Collections.Generic;

namespace _7HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            int count = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(names);
            var currentIndex = 1;

            while (queue.Count > 1)
            {
                var currentName = queue.Dequeue();

                if(currentIndex == count)
                {
                    Console.WriteLine($"Removed {currentName}");
                    currentIndex = 0;
                }
                else
                {
                    queue.Enqueue(currentName);

                }

                currentIndex++;
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");

        }
    }
}
