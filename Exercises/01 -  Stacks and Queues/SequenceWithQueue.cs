using System;
using System.Collections.Generic;

namespace SequenceWithQueue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int i = 0;

            Queue<long> queue = new Queue<long>(50);

            queue.Enqueue(n);
                        
            while(true)
            {
                i++;
                long temp = queue.Dequeue();

                Console.Write($"{temp} ");

                if(i == 50)
                {
                    break;
                }

                queue.Enqueue(temp + 1);
                queue.Enqueue(2 * temp + 1);
                queue.Enqueue(temp + 2);
            }
                        
        }
    }
}
