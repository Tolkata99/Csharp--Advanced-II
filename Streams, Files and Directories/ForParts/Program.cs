using System;
using System.IO;

namespace ForParts
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using FileStream stream = new FileStream(@"..\..\..\TextForParts.txt",FileMode.Open);
            var parts = 4;

           

            var leghtbyte = (int)Math.Ceiling(stream.Length / (decimal)parts);

            var buffer = new byte[leghtbyte];

            for (int i = 0; i < parts; i++)
            {
                var byteread = stream.Read(buffer, 0, buffer.Length);

                using var currentPart = new FileStream($"Part{i + 1}.txt",FileMode.OpenOrCreate);

                currentPart.Write(buffer, 0, buffer.Length);


            }

        }
    }
}
