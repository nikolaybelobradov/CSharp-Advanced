using System;
using System.Linq;
using System.Collections.Generic;

namespace CupsAndBottles
{
    class CupsAndBottles
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] filledBottles = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> cupsQueue = new Queue<int>();
            Stack<int> bottlesStack = new Stack<int>();

            for (int i = 0; i < cupsCapacity.Length; i++)
            {
                cupsQueue.Enqueue(cupsCapacity[i]);
            }

            for (int i = 0; i < filledBottles.Length; i++)
            {
                bottlesStack.Push(filledBottles[i]);
            }

            int wastedWater = 0;

            while (true) { 

                int currentCup = cupsQueue.Dequeue();

                while (currentCup > 0)
                {
                    int currentBottle = bottlesStack.Pop();

                    currentCup -= currentBottle;

                    if(currentCup < 0)
                    {
                        wastedWater += Math.Abs(currentCup);
                    }
                }

                if(bottlesStack.Count == 0 || cupsQueue.Count == 0)
                {
                    break;
                }
            }

            if(bottlesStack.Count == 0)
            {
                int[] temp = cupsQueue.ToArray();
                Console.Write("Cups: ");
                for (int i = 0; i < temp.Length; i++)
                {
                    if (i == temp.Length - 1)
                    {
                        Console.Write($"{temp[i]}");
                    }
                    else
                    {
                        Console.Write($"{temp[i]} ");
                    }
                }
                
            }else if(cupsQueue.Count == 0)
            {

                int[] temp = bottlesStack.ToArray();
                temp.Reverse();

                Console.Write("Bottles: ");
                for (int i = 0; i < temp.Length; i++)
                {
                    if (i == temp.Length - 1)
                    {
                        Console.Write($"{temp[i]}");
                    }
                    else
                    {
                        Console.Write($"{temp[i]} ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
