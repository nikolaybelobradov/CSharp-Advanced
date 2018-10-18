using System;
using System.Collections.Generic;

namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            string[] cmdInput = Console.ReadLine().Split();

            int n = int.Parse(cmdInput[0]);
            int s = int.Parse(cmdInput[1]);
            int x = int.Parse(cmdInput[2]);

            string[] input = Console.ReadLine().Split();

            var firstStack = new Stack<int>();
            var secondStack = new Stack<int>();

            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(input[i]);

                firstStack.Push(num);
            }
            secondStack = firstStack;
            for(int i = 0; i < s; i++)
            {
                secondStack.Pop();
            }

            if (secondStack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if(secondStack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int min = firstStack.Pop();

                while (firstStack.Count > 1)
                {
                    if (firstStack.Peek() < min)
                    {
                        min = firstStack.Peek();
                    }
                    firstStack.Pop();
                }

                Console.WriteLine(min);
            }



        }
    }
}
