using System;
using System.Linq;
using System.Collections.Generic;

namespace MagicExchangambeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var firstWord = input.Split(' ').First();
            var secondWord = input.Split(' ').Last();
            Console.WriteLine(MagicExchangamleWords(firstWord, secondWord)); 
        }

        private static string MagicExchangamleWords(string firstWord, string secondWord)
        {
            int fLen= firstWord.Length;
            int sLen= secondWord.Length;
            var longerArr = fLen >= sLen ? firstWord.ToArray() : secondWord.ToArray();
            var shorterArr = fLen < sLen ? firstWord.ToArray() : secondWord.ToArray();

            var charMap = new Dictionary<char, char>();
            for (int i = 0; i < shorterArr.Length; i++)
            {
                if (charMap.ContainsKey(shorterArr[i]))
                {
                    if (charMap[shorterArr[i]]!=longerArr[i])
                    {
                        return "false";
                    }

                }
                else
                {
                    charMap.Add(shorterArr[i], longerArr[i]);

                    foreach (var symbol in charMap)
                    {
                        if (charMap[shorterArr[i]]==symbol.Value&&
                            shorterArr[i]!=symbol.Key)
                        {
                            return "false";
                        }
                    }
                }
            }
            for (int i = shorterArr.Length-1; i < longerArr.Length; i++)
            {
                if (!charMap.ContainsValue(longerArr[i]))
                {
                    return "false";
                }
            }           

            return "true";
        }
    }
}
