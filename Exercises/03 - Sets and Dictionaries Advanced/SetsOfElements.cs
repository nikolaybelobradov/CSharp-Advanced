using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = sizes[0];
            int m = sizes[1];

            
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            HashSet<int> resultSet = new HashSet<int>();

          
                for (int i = 0; i < n; i++)
                {
                    int element = int.Parse(Console.ReadLine());

                    firstSet.Add(element);
                }

                for (int i = 0; i < m; i++)
                {
                    int element = int.Parse(Console.ReadLine());

                    secondSet.Add(element);
                }

            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    resultSet.Add(item);
                }
            }

            Console.WriteLine(String.Join(" ", resultSet));
            
        }
    }
}
