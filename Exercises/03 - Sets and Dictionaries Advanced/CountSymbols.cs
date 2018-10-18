using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            SortedDictionary<char, int> countElements = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (countElements.ContainsKey(input[i]))
                {
                    countElements[input[i]]++;
                }
                else
                {
                    countElements.Add(input[i], 1);
                }
            }

            foreach (var item in countElements)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
