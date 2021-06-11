using System;
using System.IO;

namespace Streams__Files_and_Directories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader(@"..\..\..\text1.txt");
            int counter = 0;


            while (true)
            {
                var lline = reader.ReadLine();

                if(lline == null)
                {
                    break;
                }
                


                if(counter % 2 == 1)
                {
                    Console.WriteLine(lline);
                }


                counter++;
            }
        }
    }
}
