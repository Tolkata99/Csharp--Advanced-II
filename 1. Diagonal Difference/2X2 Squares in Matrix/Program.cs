using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            char[,] matrix = new char[sizes[0], sizes[1]];


            AddElementsMatrix(sizes[0], sizes[1], matrix);

            int counter = 0;

            for (int row = 0; row <= sizes[0] - 2; row++)
            {
                for (int col = 0; col <= sizes[1] - 2 ; col++)
                {
                    
                    if (IsValid(row,col,matrix))
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }

        private static bool IsValid(int row,int col, char[,] matrix)
        {
            return matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col];
        }

        private static void AddElementsMatrix(int n, int n2, char[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                char[] curItems = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < n2; col++)
                {
                    
                        matrix[row, col] = curItems[col];
                    
                }
            }
        }
    }
}
