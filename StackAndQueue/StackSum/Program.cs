using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> stackInt = new Stack<int>(integers);

            string comand = Console.ReadLine().ToLower();
            while (comand != "end")
            {
                string[] tokens = comand.Split();

                if (tokens[0] == "add")
                {
                    int firstNumber = int.Parse(tokens[1]);
                    int secondNumber = int.Parse(tokens[2]);

                    stackInt.Push(firstNumber);
                    stackInt.Push(secondNumber);

                }
                else if (tokens[0] == "remove")
                {
                    if(int.Parse(tokens[1]) <= stackInt.Count)
                    {
                        for (int i = 0; i < int.Parse(tokens[1]); i++)
                        {

                            stackInt.Pop();

                        }
                    }
                   
                }

                comand = Console.ReadLine().ToLower();
            }


            Console.WriteLine($"Sum: {stackInt.Sum()}");

        }
    }
}
