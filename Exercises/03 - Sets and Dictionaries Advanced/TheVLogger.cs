using System;
using System.Collections.Generic;

namespace TheVLogger
{
    class TheVLogger
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, HashSet<string>> users = new Dictionary<string, HashSet<string>>();
            Dictionary<string, int> userFollowersCount = new Dictionary<string, int>();

            while(input[0] != "Statistics")
            {
                //Register

                if(input[1] == "joined" && input[2] == "The" && input[3] == "V-Logger")
                {
                    string username = input[0];

                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new HashSet<string>());
                    }
                }else if(input[1] == "followed")
                {

                    string myUser = input[0];
                    string userToFollow = input[2];

                    if(users.ContainsKey(myUser) && users.ContainsKey(userToFollow))
                    {
                        if (!users[myUser].Contains(userToFollow))
                        {
                            users[myUser].Add(userToFollow);

                            if (!userFollowersCount.ContainsKey(userToFollow))
                            {
                                userFollowersCount.Add(userToFollow, 1);
                            }
                            else
                            {
                                userFollowersCount[userToFollow]++;
                            }
                        }
                    }

                }

                input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            if(input[0] == "Statistics")
            {
                int registeredUsers = users.Count;
                Console.WriteLine($"The V-Logger has a total of {registeredUsers} vloggers in its logs.");

                string famousUser = null;
                int famousUserFollowers = 0;
                int famousUserFollowing = 0;

                foreach (var user in userFollowersCount)
                {
                    int currentFollowers = user.Value;

                    if(currentFollowers > famousUserFollowers)
                    {
                        famousUserFollowers = currentFollowers;
                        famousUser = user.Key;
                    }
                    else if(currentFollowers == famousUserFollowers)
                    {
                        if(famousUser != null)
                        {
                            int user1Following = users[famousUser].Count;
                            int user2Following = users[user.Key].Count;

                            if(user2Following < user1Following)
                            {
                                famousUser = user.Key;
                            }
                        }
                    }

                }

                famousUserFollowing = users[famousUser].Count;

                if (famousUserFollowers != 0)
                {

                    Console.WriteLine($"1. {famousUser} : {famousUserFollowers} followers, {famousUserFollowing} following");

                    findAllFollowers(famousUser, users);
                    
                }
            }
        }

        private static void findAllFollowers(string myUser, Dictionary<string, HashSet<string>> users)
        {
            List<string> myFollowers = new List<string>();

            foreach (var user in users)
            {
                if (user.Value.Contains(myUser))
                {
                    myFollowers.Add(user.Key);
                }
            }

            myFollowers.Sort();

            foreach (var follower in myFollowers)
            {
                Console.WriteLine($"* {follower}");
            }
        }
    }
}
