    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace MaximumandMinimumElement
    {
        class Program
        {
            static void Main(string[] args)
            {
                Stack<int> stack = new Stack<int>();

                int queries = int.Parse(Console.ReadLine());

                for (int i = 0; i < queries; i++)
                {
                    int[] queriesAndNumbers = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    if(queriesAndNumbers[0] == 1)
                    {
                        stack.Push(queriesAndNumbers[1]);
                    }
                    else if (queriesAndNumbers[0] == 2)
                    {
                        if(stack.Any())
                        {
                            stack.Pop();
                        }
                    }
                    else if (queriesAndNumbers[0] == 3)
                    {
                        if (stack.Any())
                            Console.WriteLine(stack.Max());
                    }
                    else if (queriesAndNumbers[0] == 4)
                    {
                        if (stack.Any())
                            Console.WriteLine(stack.Min());
                    }



                }

                if(stack.Any())
                {
                    Console.WriteLine(string.Join(", ", stack.ToArray()));
                }
            }
        }
    }
