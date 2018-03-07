using System;
using System.Text.RegularExpressions;

namespace MoreMorseCode
{
    class MorseCode
    {
        static void Main()
        {
            string pattern = @"(\||\b)([01]+)(\||\b)";
            string text = Console.ReadLine();
            var rgx = new Regex(pattern);
            var matches = rgx.Matches(text);
            foreach (Match match in matches)
            {
                Decode(match);
            }
            Console.WriteLine();
        }

        private static void Decode(Match match)
        {
            string toDecode = match.Groups[2].Value;
            
            int wordCode = 0;
            //int totalEqualSequenceCount = 0;
            int sequenceCounter = 0;
            for (int i = 0; i < toDecode.Length; i++)
            {
                if (toDecode[i]=='1')
                {
                    wordCode += 5;
                }
                else
                {
                    wordCode += 3;
                }

                if (i<toDecode.Length-1)
                {
                    if (toDecode[i]== toDecode[i+1])
                    {
                        sequenceCounter++;
                    }
                    else if (sequenceCounter >= 1&& toDecode[i] != toDecode[i + 1])
                    {                        
                        sequenceCounter++;
                        wordCode += sequenceCounter;
                        sequenceCounter = 0;                        
                    }
                }
            }
            if (sequenceCounter >= 1)
            {
                wordCode += ++sequenceCounter;
            }

            if (32<=wordCode&& wordCode<=126)
            {
                Console.Write((char)wordCode);
            }
        }
    }
}
