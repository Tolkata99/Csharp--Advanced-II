using System;
using System.Collections.Generic;

namespace Wardrobe
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] arrayWardrobe = Console.ReadLine().Split(" -> ");
                string color = arrayWardrobe[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                string[] clothes = arrayWardrobe[1].Split(",");
                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color].Add(clothes[j], 0);
                    }

                    wardrobe[color][clothes[j]]++;
                }

            }

            string[] dressFound = Console.ReadLine().Split();
            bool isFound = false;

            foreach (var (keyColor, clotherValue) in wardrobe)
            {
                if (keyColor == dressFound[0])
                {
                    if (clotherValue.ContainsKey(dressFound[1]))
                    {
                        isFound = true;
                        break;
                    }
                }
            }

            foreach (var (keyColor, clotherValue) in wardrobe)
            {
                //                Blue clothes:
                //*dress - 1(found!)
                //* jeans - 1
                //* hat - 1
                //* gloves - 1
                
                Console.WriteLine($"{keyColor} clothes:");
                foreach (var (clother,times) in clotherValue)
                {
                    Console.Write($"* {clother} - {times}");
                    if (isFound && dressFound[0] == keyColor && clother == dressFound[1])
                    {                      
                        Console.Write(" (found!)");
                        
                       
                    }

                    Console.WriteLine();
                }
               
            }

        }
    }
}
