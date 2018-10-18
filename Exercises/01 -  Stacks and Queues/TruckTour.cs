using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(Console.ReadLine());
            }

            bool success = false;

            for (int i = 0; i < n; i++)
            {
                long fuel = 0;

                foreach (var item in queue)
                {
                    fuel += item.Trim().Split().Select(long.Parse).ToArray()[0];
                    fuel -= item.Trim().Split().Select(long.Parse).ToArray()[1];


                    if (fuel < 0)
                    {
                        success = false;
                        break;
                    }
                    else
                    {
                        success = true;
                    }
                }

                    if (success)
                    {
                        Console.WriteLine(i);
                        return;
                    }

                    queue.Enqueue(queue.Dequeue());

                
            }
        }
    }
}
