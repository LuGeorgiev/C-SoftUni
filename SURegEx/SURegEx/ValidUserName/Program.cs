using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace QueryMess
{
    class QueryMess
    {
        static void Main()
        {
            string pattern = @"([a-zA-Z]+)=([a-zA-Z%20\+]+)";
            string input = Console.ReadLine();
            while (input != "END")
            {
                var keyValue = new Dictionary<string, string>();
                var matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    if (keyValue.ContainsKey(match.Groups[1].Value))
                    {
                        keyValue[match.Groups[1].Value] += ", " + match.Groups[2].Value;
                    }
                    else
                    {
                        keyValue.Add(match.Groups[1].Value, match.Groups[2].Value);
                    }
                }

                foreach (var kvp in keyValue)
                {
                    Console.Write(kvp.Key + "=[");

                    Console.Write(kvp.Value + "]");
                    Console.WriteLine();
                }

                input = Console.ReadLine();
            }

        }
    }
}
