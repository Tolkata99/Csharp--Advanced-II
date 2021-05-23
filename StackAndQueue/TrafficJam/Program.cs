using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int passingCars = int.Parse(Console.ReadLine());
            int totalCarsPassed = 0;
            Queue<string> cars = new Queue<string>();

            while (true)
            {
                string comand = Console.ReadLine();

                if(comand == "end")
                {
                    break;
                }
                else if(comand == "green")
                {
                    for (int i = 0; i < passingCars; i++)
                    {
                        if(cars.Any())
                        {
                            totalCarsPassed++;
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                        }

                    }
                }
                else
                {
                    cars.Enqueue(comand);
                }
            }


            Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
        }
    }
}
