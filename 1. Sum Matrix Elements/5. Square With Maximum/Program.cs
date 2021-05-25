using System;
using System.Linq;

namespace _05.__Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[,] matrix = ReadMatrix(rows, cols);


            int maxSum = int.MinValue;
            int rw = 0;
            int cl = 0;

            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < cols - 1; c++)
                {
                    int squareSum = matrix[r, c] +
                                    matrix[r + 1, c] +
                                    matrix[r, c + 1] +
                                    matrix[r + 1, c + 1];
                    if (maxSum < squareSum)
                    {
                        rw = r;
                        cl = c;
                        maxSum = squareSum;
                    }


                }
            }
            Console.WriteLine($"{matrix[rw, cl]} {matrix[rw, cl + 1]}");
            Console.WriteLine($"{matrix[rw + 1, cl]} {matrix[rw + 1, cl + 1]}");
            Console.WriteLine($"{maxSum}");

        }
        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }


            }
            return matrix;
        }


    }
}
