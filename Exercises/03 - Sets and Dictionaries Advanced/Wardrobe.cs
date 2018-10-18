using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var myWardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] clothes = input[1]
                    .Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);

                if (!myWardrobe.ContainsKey(color))
                {
                    myWardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!myWardrobe[color].ContainsKey(clothes[j]))
                    {
                        myWardrobe[color].Add(clothes[j], 1);
                    }
                    else
                    {
                        myWardrobe[color][clothes[j]]++;
                    }
                }
            }

                string[] searchInput = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string searchedColor = searchInput[0];
                string searchedElement = searchInput[1];

                foreach (var KvPOuter in myWardrobe)
                {
                    Console.WriteLine($"{KvPOuter.Key} clothes:");

                    foreach (var KvPInner in KvPOuter.Value)
                    {

                        if (KvPOuter.Key == searchedColor && KvPInner.Key == searchedElement)
                        {
                            Console.WriteLine($"* {KvPInner.Key} - {KvPInner.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {KvPInner.Key} - {KvPInner.Value}");
                        }
                    }  
                }

               
                    
            
        }
    }
}
