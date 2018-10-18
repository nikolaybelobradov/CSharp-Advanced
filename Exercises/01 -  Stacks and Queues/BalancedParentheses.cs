using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Stack<char> stack = new Stack<char>();

        
            int error = 0;

            if(input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                char element = input[i];

                if(element == '(' || element =='{' || element == '[')
                {
                    stack.Push(element);
                }
                if(element == ')' || element == '}' || element == ']')
                {
                    char popElement = stack.Pop();

                    if(element == ')' && popElement != '(')
                    {
                        error = 1;
                    }
                    if (element == '}' && popElement != '{')
                    {
                        error = 1;
                    }
                    if (element == ']' && popElement != '[')
                    {
                        error = 1;
                    }
                }
            }

            if(error == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
