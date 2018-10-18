using System;
using System.Collections.Generic;

namespace SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> undoStack = new Stack<string>();
            string text = string.Empty;           

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                int cmd = int.Parse(input[0]);

                switch (cmd)
                {
                    case 1:

                        string str = input[1];

                        undoStack.Push(text);
                        text += str;
                        break;

                    case 2:

                        int count = int.Parse(input[1]);

                        undoStack.Push(text);
                        text = text.Substring(0, text.Length - count);
                        break;

                    case 3:

                        int index = int.Parse(input[1]);

                        Console.WriteLine(text[index - 1]);
                        break;

                    case 4:

                        text = undoStack.Pop();
                        break;

                    default:
                        Console.WriteLine("Wrong Command! Try again!");
                        break;
                }
              
            }
        }
    }
}
