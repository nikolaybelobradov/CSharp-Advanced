using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(n);

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                int cmd = int.Parse(input[0]);

                if (cmd == 1)
                {
                    int element = int.Parse(input[1]);

                    stack.Push(element);
                }

                if (cmd == 2)
                {
                    stack.Pop();
                }

                if (cmd == 3)
                {
                    Console.WriteLine(stack.Max());
                }
            }
        }
    }
}
