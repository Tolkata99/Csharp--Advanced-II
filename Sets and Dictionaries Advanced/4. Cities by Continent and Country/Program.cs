using System;
using System.Collections.Generic;

namespace _4._Cities_by_Continent_and_Country
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var world = new Dictionary<string, Dictionary<string, List<string>>>();
            int length = int.Parse(Console.ReadLine());

            //            9
            //Europe Bulgaria Sofia
            //Asia China Beijing
            //Asia Japan Tokyo
            //Europe Poland Warsaw
            //Europe Germany Berlin
            //Europe Poland Poznan
            //Europe Bulgaria Plovdiv
            //Africa Nigeria Abuja
            //Asia China Shanghai
            for (int i = 0; i < length; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continents = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if(!world.ContainsKey(continents))
                {
                    world.Add(continents , new Dictionary<string, List<string>>());
                }

                if(!world[continents].ContainsKey(country))
                {
                    world[continents].Add(country, new List<string>());
                }

                world[continents][country].Add(city);

            }
            //Europe:
            //       Bulgaria->Sofia, Plovdiv
            //       Poland->Warsaw, Poznan
            //       Germany->Berlin
            //Asia:
            //       China->Beijing, Shanghai
            //       Japan->Tokyo
            //Africa:
            //        Nigeria->Abuja

            foreach (var (continentsKey,countryValue) in world)
            {
                Console.WriteLine($"{continentsKey}:");

                foreach (var (country,city) in countryValue)
                {
                    Console.WriteLine($"  {country} -> {string.Join(", ", city)}");
                }
                
            }

        }
    }
}
