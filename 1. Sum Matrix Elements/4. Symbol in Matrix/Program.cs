using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int sizes = int.Parse(Console.ReadLine());

            var matrix = new char[sizes, sizes];

            for (int row = 0; row < sizes; row++)
            {
                char[] currElement = Console.ReadLine().ToCharArray();
                for (int col = 0; col < sizes; col++)
                {
                    matrix[row, col] = currElement[col];
                }
            }

            char findSymbol = char.Parse(Console.ReadLine());
            bool isFind = false;
            int r = 0;
            int c = 0;

            for (int row = 0; row < sizes; row++)
            {
                for (int col = 0; col < sizes; col++)
                {
                   if(matrix[row,col] == findSymbol)
                    {
                        r = row;
                        c = col;
                        isFind = true;
                        break;
                        
                    }
                }

                if(isFind)
                {
                    break;
                }
            }

            if(isFind)
            {
                Console.WriteLine($"{(r,c)}");
            }
            else
            {
                Console.WriteLine($"{findSymbol} does not occur in the matrix ");
            }

        }
    }
}
