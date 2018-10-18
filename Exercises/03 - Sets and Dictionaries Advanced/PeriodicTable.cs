using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> chemicalCompounds = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < elements.Length; j++)
                {
                    if (!chemicalCompounds.Contains(elements[j]))
                    {
                        chemicalCompounds.Add(elements[j]);
                    }
                }
            }

            chemicalCompounds = chemicalCompounds.OrderBy(x => x).ToList();

            Console.WriteLine(String.Join(" ", chemicalCompounds));
        }
    }
}
