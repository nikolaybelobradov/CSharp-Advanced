using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] cmds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(cmds[0]);

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < cmds[0]; i++)
            {
                queue.Enqueue(input[i]);
            }
            for (int i = 0; i < cmds[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(cmds[2]))
            {
                Console.WriteLine("true");
            }
            else if(queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
