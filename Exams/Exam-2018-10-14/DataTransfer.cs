using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace DataTransfer
{
    class DataTransfer
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<string> validMatches = new List<string>();
            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                
                string mainPattern = @"s:([^;]+);r:([^;]+);m--""([A-Za-z ]+)""";

                MatchCollection matches = Regex.Matches(input, mainPattern);

                foreach(var match in matches) {

                   
                    validMatches.Add(match.ToString());
                    
                }

                
            }

            
            int totalData = 0;

            

            string fnPattern = @"s:([^;]+);";
            string snPattern = @"r:([^;]+);";
            string msgPattern = "m--\"([A-Za-z ]+)\"";

            foreach (var validMatch in validMatches)
            {
                string message = string.Empty;
                Match fnMatch = Regex.Match(validMatch, fnPattern);

                if (fnMatch.Success)
                {
                    char[] fNameChars = fnMatch.ToString().ToCharArray();

                    for (int i = 2; i < fNameChars.Length - 1; i++)
                    {
                        char current = fNameChars[i];

                        if (Char.IsLetter(current) || Char.IsWhiteSpace(current))
                        {
                            message += current;
                        }
                        if (Char.IsDigit(current))
                        {
                            totalData += int.Parse(current.ToString());

                        }

                    }
                }

                    message += " says \"";

                    Match msgMatch = Regex.Match(validMatch, msgPattern);

                if (msgMatch.Success)
                {
                    char[] msgChars = msgMatch.ToString().ToCharArray();

                    for (int i = 4; i < msgChars.Length - 1; i++)
                    {
                        char current = msgChars[i];

                        if (Char.IsLetter(current) || Char.IsWhiteSpace(current))
                        {
                            message += current;
                        }
                        if (Char.IsDigit(current))
                        {
                            totalData += int.Parse(current.ToString());
                        }
                    }
                }
                        message += "\" to ";

                        Match snMatch = Regex.Match(validMatch, snPattern);

                        if (snMatch.Success)
                        {
                            char[] sNameChars = snMatch.ToString().ToCharArray();

                            for (int i = 2; i < sNameChars.Length - 1; i++)
                            {
                                char current = sNameChars[i];

                                if (Char.IsLetter(current) || Char.IsWhiteSpace(current))
                                {
                                    message += current;
                                }
                        if (Char.IsDigit(current))
                        {
                            totalData += int.Parse(current.ToString());
                        }

                    }
                        }

                        


                Console.WriteLine(message);
               
            }

            Console.WriteLine($"Total data transferred: {totalData}MB");

        }
    }
}
