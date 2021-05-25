using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var sizes = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var curNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = curNumbers[col];
                }
            }   

           
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int RESULT = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    RESULT += matrix[row, col];
                    
                }
                Console.WriteLine(RESULT);
            }
        }
    }
}
