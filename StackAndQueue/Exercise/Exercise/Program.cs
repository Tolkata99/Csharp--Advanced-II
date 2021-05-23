using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] comands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> stackNumbers = new Stack<int>(numbers);


            bool isTrue = true;
            int N = comands[0];
            int S = comands[1];
            int X = comands[2];
            //for (int i = 0; i < N; i++)
            //{
            //    stackNumbers.Push(numbers[i]);
            //}

            for (int i = 0; i < S; i++)
            {
                stackNumbers.Pop();
            }



            if (stackNumbers.Contains(X))
            {
                Console.WriteLine("true");
                isTrue = false;
            }

            if (isTrue)
            {
                if (stackNumbers.Any())
                {
                    Console.WriteLine(stackNumbers.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }

            }
        }
    }
}
