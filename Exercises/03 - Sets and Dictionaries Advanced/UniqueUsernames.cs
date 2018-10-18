using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> usernames = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string username = Console.ReadLine();

                if (!usernames.Contains(username))
                {
                    usernames.Add(username);
                }
            }

            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }
            {

            }
        }
    }
}
