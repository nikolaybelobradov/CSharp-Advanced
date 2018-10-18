using System;
using System.Collections.Generic;

namespace StackFibbonaci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var fibNums = new Stack<long>();

            if(n == 0)
            {
                Console.WriteLine(0);
            }
            else if(n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {

                fibNums.Push(0);
                fibNums.Push(1);

                for (int i = 1; i < n; i++)
                {
                    long num1 = fibNums.Pop();
                    long num2 = fibNums.Peek();

                    fibNums.Push(num1);
                    fibNums.Push(num1 + num2);
                }

                Console.WriteLine(fibNums.Peek());
            }

        }
    }
}
