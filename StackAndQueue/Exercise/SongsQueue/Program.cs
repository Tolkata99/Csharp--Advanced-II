using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine()
                .Split(", ")
                .ToArray());

            while (true)
            {
                string comand = Console.ReadLine();

                if(songs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
                else if(comand.StartsWith("Add"))
                {
                    string song = comand.Replace("Add"," ").TrimStart();

                    if(songs.Contains(song) == false)
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if(comand == "Play")
                {
                    if(songs.Any())
                    {
                        songs.Dequeue();
                    }
                }
                else if(comand == "Show")
                {
                    Console.WriteLine(string.Join(", ",songs.ToArray()));
                }
            }


        }
    }
}
