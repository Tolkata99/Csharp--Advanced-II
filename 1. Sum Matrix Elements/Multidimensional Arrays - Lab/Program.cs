using System;
using System.Linq;

namespace Multidimensional_Arrays___Lab
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] curNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = curNumbers[col];
                }
            }

            Console.WriteLine(size[0]);
            Console.WriteLine(size[1]);
            int result = 0;

            foreach (var number in matrix)
            {
                result += number;
            }


            Console.WriteLine(result);

        }
    }
}
