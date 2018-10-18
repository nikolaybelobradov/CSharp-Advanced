using System;
using System.Collections.Generic;
using System.Linq;

namespace PoisonousPlants
{
    class PoisonousPlants
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] pst = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> plants = new Queue<int>(pst);
            Queue<int> tempQueue = new Queue<int>();

            tempQueue = plants;
            bool diedPlants = true;
            int days = 0;

            while (diedPlants)
            {
                days++;
                diedPlants = false;

                while (tempQueue.Count > 1)
                {

                    int lastPlant = tempQueue.Dequeue();
                    int bLastPlant = tempQueue.Peek();
                    
                    if (lastPlant >= bLastPlant)
                    {
                        plants.Enqueue(bLastPlant);
                        diedPlants = true;
                    }
                    else
                    {
                        plants.Enqueue(lastPlant);
                        plants.Enqueue(bLastPlant);
                    }

                }

                tempQueue = plants;
                plants.Clear();
            }

            Console.WriteLine(days);



        }
    }
}
