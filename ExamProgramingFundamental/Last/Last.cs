using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Last
{
    class Last
    {
        static SortedDictionary<string, SortedSet<string>> sideWithUsers = new SortedDictionary<string, SortedSet<string>>();
        static void Main()
        {
            string splitPattern = @"(.+)( \| | -> )(.+)";
            var rgx = new Regex(splitPattern);

            string input = "";
            while ((input= Console.ReadLine())!= "Lumpawaroo")
            {
                string user = "";
                string side = "";

                var match = rgx.Match(input);
                if (!match.Success)
                {
                    continue;
                }
                if (match.Groups[2].Value==" | ")
                {
                    user = match.Groups[3].Value;
                    side = match.Groups[1].Value;

                    if (sideWithUsers.ContainsKey(side))
                    {
                        //side was created
                        sideWithUsers[side].Add(user);

                        CheckIfUserAlraedyExist(user, side);                      
                       
                    }
                    else
                    {
                        sideWithUsers.Add(side, new SortedSet<string>());
                        sideWithUsers[side].Add(user);

                        CheckIfUserAlraedyExist(user, side);
                    }
                }
                else
                {
                    //print
                    user = match.Groups[1].Value;
                    side = match.Groups[3].Value;
                    Console.WriteLine($"{user} joins the {side} side!");
                    if (sideWithUsers.ContainsKey(side))
                    {
                        //side was created
                        sideWithUsers[side].Add(user);

                        CheckIfUserAlraedyExist(user, side);

                    }
                    else
                    {
                        sideWithUsers.Add(side, new SortedSet<string>());
                        sideWithUsers[side].Add(user);

                        CheckIfUserAlraedyExist(user, side);
                    }

                }

            }

            var sortedSides = sideWithUsers
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count);
                


                foreach (var item in sortedSides)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");                   

                    foreach (var soldier in item.Value)
                    {
                        Console.WriteLine($"! {soldier}");
                    }                  

                }
        }

        private static void CheckIfUserAlraedyExist(string user, string side)
        {
            foreach (var forceSide in sideWithUsers)
            {
                if (forceSide.Value.Count>0&& forceSide.Key != side)
                {
                    foreach (var forceUser in forceSide.Value)
                    {
                        if (forceUser == user)
                        {
                            forceSide.Value.Remove(user);
                            return;
                        }
                    }
                }
            }
        }
    }
}
