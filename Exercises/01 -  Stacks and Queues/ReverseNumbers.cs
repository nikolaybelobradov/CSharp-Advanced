using System;
using System.Collections.Generic;

namespace ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            string[] input = Console.ReadLine().Split();

            foreach(string str in input)
            {
                int num = int.Parse(str);

                stack.Push(num);
            }

            foreach(int num in stack)
            {
                Console.Write(num+" ");
            }

            Console.WriteLine();
                        
        }
    }
}
