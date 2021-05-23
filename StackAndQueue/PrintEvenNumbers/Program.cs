using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(integers);
            Queue<int> queueEvenIntegers = new Queue<int>();

            while (queue.Count > 0)
            {
                if(queue.Peek() % 2 == 0)
                {                  
                    queueEvenIntegers.Enqueue(queue.Dequeue());
                }
                else
                {
                    queue.Dequeue();
                }
            }

            Console.WriteLine(string.Join(", ", queueEvenIntegers.ToArray()));
        }
    }
}
