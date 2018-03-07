using System;
using System.Text.RegularExpressions;

namespace MoreKarateString
{
    class KarateString
    {
        static void Main(string[] args)
        {
            string karate = Console.ReadLine();
            //string karate = "abv>1>1>2>2asdasd";
            string pattern = @"(>)(\d+)";
            var rgx = new Regex(pattern);

            int strikePower = 0;
            int strikeIndex = 0;
            int powerToAdd = 0;

            while (true)
            {
                var match = rgx.Match(karate);
                if (!match.Success)
                {
                    break;
                }

                strikePower = int.Parse(match.Groups[2].Value)+powerToAdd;
                strikeIndex = match.Groups[1].Index;

                var nextMatch = rgx.Match(karate,strikeIndex+1);
                int nextStrike = nextMatch.Groups[1].Index;
                powerToAdd = 0;
                if (strikeIndex+strikePower >= nextStrike&& nextStrike!=0)
                {
                    powerToAdd = strikePower - (nextStrike - strikeIndex - 1);
                    strikePower = nextStrike - strikeIndex - 1;                     
                }

                karate = karate.Remove(strikeIndex+1, strikePower);
                strikePower = 0;
            }

            Console.WriteLine(karate);
        }
    }
}
