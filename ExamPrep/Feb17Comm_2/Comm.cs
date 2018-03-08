using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Feb17Comm_2
{
    class Comm
    {
        static void Main()
        {
            var broadcastPattern = @"^(\D+) <-> ([0-9a-zA-z]+)$";
            var privatePattern = @"^([0-9]+) <-> ([0-9a-zA-z]+)$";
            var rgxBroadcast = new Regex(broadcastPattern);
            var rgxPrivate = new Regex(privatePattern);

            var booadcastMsg = new List<string>();
            var privateMsg = new List<string>();

            string input = "";
            while ((input=Console.ReadLine())!= "Hornet is Green")
            {
                var matchBroadcast = rgxBroadcast.Match(input);
                if (matchBroadcast.Success)
                {
                    string msg = DecodBroadcast(matchBroadcast.Groups[1].Value
                        , matchBroadcast.Groups[2].Value);

                    booadcastMsg.Add(msg);
                }

                var matchPrivate = rgxPrivate.Match(input);
                if (matchPrivate.Success)
                {
                    string msg = DecodPrivate(matchPrivate.Groups[1].Value
                        , matchPrivate.Groups[2].Value);

                    privateMsg.Add(msg);
                }
            }
            Console.WriteLine("Broadcasts:");
            if (booadcastMsg.Count==0)
            {
                Console.WriteLine("None");
            }
            else
            {

                foreach (var msg in booadcastMsg)
                {
                    Console.WriteLine(msg);
                }
            }
            Console.WriteLine("Messages:");
            if (privateMsg.Count==0)
            {
                Console.WriteLine("None");
            }
            else
            {

                foreach (var msg in privateMsg)
                {
                    Console.WriteLine(msg);
                }
            }
        }

        private static string DecodPrivate(string recepient, string message)
        {
            var temp = recepient.ToArray();
            var result = new StringBuilder();
            for (int i = temp.Length-1; i >= 0; i--)
            {
                result.Append(temp[i].ToString());
            }

            result.Append(" -> ");
            result.Append(message);
            return result.ToString();
        }

        private static string DecodBroadcast(string msg, string frequency)
        {
            var result = new StringBuilder();
            var freqToDecode = frequency.ToCharArray();

            for (int i = 0; i < freqToDecode.Length; i++)
            {
                if ('a' <= frequency[i] && freqToDecode[i] <= 'z')
                {
                    result.Append(freqToDecode[i].ToString().ToUpper());
                }
                else if ('A' <= frequency[i] && freqToDecode[i] <= 'Z')
                {
                    result.Append(freqToDecode[i].ToString().ToLower());
                }
                else
                {
                    result.Append(freqToDecode[i].ToString());
                }

            }
            result.Append(" -> ");
            result.Append(msg);

            return result.ToString();
        }

    }
}
