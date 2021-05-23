using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOfFood = int.Parse(Console.ReadLine());

            Queue<int> queueInReastaurant = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            if (queueInReastaurant.Any())
                Console.WriteLine(queueInReastaurant.Max());

            while (true)
            {
                if(queueInReastaurant.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
                
                if(queueInReastaurant.Peek() <= valueOfFood)
                {
                    valueOfFood -= queueInReastaurant.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ",queueInReastaurant.ToArray())}");
                    break;
                }

            }


        }
    }
}
