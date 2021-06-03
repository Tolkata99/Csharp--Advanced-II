using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._Average_Student_Grades
{
    public class StartUp
    {
        

        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            //            7
            //Ivancho 5.20
            //Mariika 5.50
            //Ivancho 3.20
            //Mariika 2.50
            //Stamat 2.00
            //Mariika 3.46
            //Stamat 3.00

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (grades.ContainsKey(input[0]) == false)
                {
                    grades.Add(input[0], new List<decimal>());
                }

                grades[input[0]].Add(decimal.Parse(input[1]));


            }

            //            Ivancho-> 5.20 3.20(avg: 4.20)
            //Mariika-> 5.50 2.50 3.46(avg: 3.82)
            //Stamat-> 2.00 3.00(avg: 2.50)


           

            foreach (var key in grades)
            {
                decimal average = 0;
                int count = 0;
                Console.Write($"{key.Key} -> ");
                

                foreach (var item in key.Value)
                {
                    Console.Write($"{item:F2}" + " ");
                    average += item;
                    count++;
                }

                

                Console.Write($"(avg: {average / count :F2})");
                Console.WriteLine();
                
            }


        }
    }
}
