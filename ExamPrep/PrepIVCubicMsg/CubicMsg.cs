using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PrepIVCubicMsg
{
    class CubicMsg
    {
        static void Main()
        {
            while (true)
            {
                var msg = Console.ReadLine();
                if (msg=="Over!")
                {
                    break;
                }
                var msgLength = int.Parse(Console.ReadLine());
                var pattern = "^([0-9]+)([a-zA-Z]{" + msgLength + "})([^a-zA-Z])*$";
                var rgx = new Regex(pattern);
                var match = rgx.Match(msg);

                if (!match.Success)
                {
                    continue;
                }
                var decriptedMsg = match.Groups[2].Value.ToString();
                
                Console.Write($"{decriptedMsg} == ");
                if (match.Groups[1].Success)
                {
                    PrintVerification(match.Groups[1].Value, decriptedMsg);
                }
                if (match.Groups[3].Success)
                {
                    PrintVerification(match.Groups[3].Value, decriptedMsg);
                }
                Console.WriteLine();
                
            }
        }

        private static void PrintVerification(string verification, string decriptedMsg)
        {
            var maxIndex = decriptedMsg.Length - 1;
            foreach (var s in verification)
            {
                var index = s - '0';

                if ('0'<=s&&s<='9')
                {
                    if (0 <= index && index <= maxIndex)
                    {
                        Console.Write(decriptedMsg[index]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            } 
        }
    }
}
