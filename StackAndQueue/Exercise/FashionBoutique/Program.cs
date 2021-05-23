using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> dreses = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            int capacity = int.Parse(Console.ReadLine());

            int realCapac = 0;
            int boxes = 1;

            while (true)
            {
                if (realCapac + dreses.Peek() <= capacity)
                {
                    realCapac += dreses.Pop();
                }
                else
                {
                    realCapac = 0;
                    boxes++;
                }

                if(dreses.Count == 0)
                {
                    break;
                }
            }

            Console.WriteLine(boxes);
        }
    }
}
