using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            int[,] square = new int[3, 3];
            AddNumbersToMatrix(matrix);

            int maximalSum = 0;
            int min = int.MinValue;

            int rowFinish = 0;
            int colFinish = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    maximalSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (maximalSum > min)
                    {
                        min = maximalSum;

                        rowFinish = row;
                        colFinish = col;
                    }

                }
            }

            Console.WriteLine($"Sum = {min}");


            Console.WriteLine($"{matrix[rowFinish, colFinish]} {matrix[rowFinish , colFinish + 1]} {matrix[rowFinish , colFinish + 2]}");
            Console.WriteLine($"{matrix[rowFinish + 1, colFinish]} {matrix[rowFinish + 1, colFinish + 1]} {matrix[rowFinish + 1, colFinish + 2]}");
            Console.WriteLine($"{matrix[rowFinish + 2, colFinish]} {matrix[rowFinish + 2 , colFinish + 1]} {matrix[rowFinish + 2, colFinish + 2]}");




        }

        private static void AddNumbersToMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
        }
    }

    
}

