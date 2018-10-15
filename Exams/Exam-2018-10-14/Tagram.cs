using System;
using System.Linq;
using System.Collections.Generic;

namespace Tagram
{
    class Tagram
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);

            var database = new Dictionary<string, Dictionary<string, int>>();

           

            while(input[0] != "end")
            {

                if (input[0] == "ban")
                {
                    string user = input[1];

                    if (database.ContainsKey(user))
                    {
                        database.Remove(user);
                    }


                }
                else
                {

                    string username = input[0];
                    string tag = input[1];
                    int likes = int.Parse(input[2]);

                    if (!database.ContainsKey(username))
                    {
                        database.Add(username, new Dictionary<string, int>());
                    }

                    if (!database[username].ContainsKey(tag))
                    {
                        database[username].Add(tag, 0);
                    }

                    database[username][tag] += likes;
                }
                    input = Console.ReadLine()
                    .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                
            }

            var sumOfLikes = new Dictionary<string, Dictionary<int, int>>();

            foreach (var user in database)
            {
                if (!sumOfLikes.ContainsKey(user.Key))
                {

                    int sumLikes = 0;
                    int sumTags = 0;
                    foreach (var item in user.Value)
                    {
                        sumLikes += item.Value;
                        sumTags++;
                    }
                    sumOfLikes.Add(user.Key, new Dictionary<int, int>());
                    sumOfLikes[user.Key].Add(sumLikes, sumTags);
                }
            }

            foreach (var outer in database.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x=> x.Value.Count))
            {
                Console.WriteLine(outer.Key);
                foreach (var inner in outer.Value)
                {
                    Console.WriteLine($"- {inner.Key}: {inner.Value}");
                }
            }

            
        }
    }
}
