using System;
using System.Linq;
using System.Collections.Generic;

namespace LeterChaneg
{
    class LetChangeNum
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double result = LettersCahge(input);
            Console.WriteLine($"{result:F2}");
        }

        private static double LettersCahge(string input)
        {
            double sum = 0;
            List<string> codeWordes = input
                .Trim()
                .Split(new[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            foreach (var codeWord in codeWordes)
            {
                sum += Decode(codeWord);
            }

            return sum;
        }

        private static double Decode(string codeWord)
        {
            double currentResult = 0;
            char firstLetter = Convert.ToChar(codeWord.Substring(0, 1));
            char lastLetter = Convert.ToChar(codeWord.Substring(codeWord.Length - 1));
            int number = int.Parse(codeWord.Substring(1, codeWord.Length - 2));

            if ('A'<=firstLetter&& firstLetter<='Z')
            {
                currentResult= (double)number/(firstLetter - '@');
            }
            else
            {
                currentResult = (double)number* (firstLetter - '`');
            }

            if ('A' <= lastLetter && lastLetter <= 'Z')
            {
                currentResult -= (lastLetter - '@');
            }
            else
            {
                currentResult += (lastLetter - '`');
            }
            
            return currentResult;
        }
    }
}
