using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Jan17WinTicket_4
{
    class WinningTicket_4
    {
        static void Main(string[] args)
        {
            var pattern = @"([@\#\$\^]{6,10}).*(\1)";
            //var pattern = @"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}.*(\1)";

            var rgx = new Regex(pattern);

            var tickets = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length!=20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var match = rgx.Match(tickets[i]);
                    if (match.Success==false)
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                    else
                    {
                        bool isJackpot = (match.Groups[1].Length + match.Groups[2].Length) == 20;
                        string matchSymbol = match.Groups[1].ToString()[0].ToString();
                        int matchLength = match.Groups[1].Length;
                        if (isJackpot)
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {matchLength}{matchSymbol} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {matchLength}{matchSymbol}");
                        }
                    }
                }
            }
        }
    }
}
