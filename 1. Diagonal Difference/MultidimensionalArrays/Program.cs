using System;
using System.Linq;

namespace MultidimensionalArrays
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            AddElementsMatrix(n, matrix);
            int firstSums = 0;
            int secondSums = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == row)
                    {
                        firstSums += matrix[row, col];
                    }
                }
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int row = n - i - 1;
                int col = i;

                secondSums += matrix[row, col];
            }



            Console.WriteLine(Math.Abs(firstSums - secondSums));
        }






        private static void AddElementsMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                int[] currNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currNum[col];
                }
            }
        }
    }
}
