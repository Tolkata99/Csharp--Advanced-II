using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int sizes = int.Parse(Console.ReadLine());

            var matrix = new int[sizes, sizes];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currElements[col];
                }
            }

            int result = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(row == col)
                    {
                       result += matrix[row, col];
                    }
                   
                }
            }

            Console.WriteLine(result);
        }
    }
}
