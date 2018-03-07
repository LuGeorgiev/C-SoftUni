using System;
using System.Linq;
using System.Collections.Generic;

namespace LettersChangeNumbers
{

    public class LettersChangeNums
    {
        static void Main()
        {
            string input = Console.ReadLine();
            long result = LettersCahge(input);
            Console.WriteLine(result);
        }

        private static long LettersCahge(string input)
        {
            long sum = 0;
            List<string> codeWordes = input
                .Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            foreach (var codeWord in codeWordes)
            {
                sum += Decode(codeWord);

            }       

            return sum;
        }

        private static long Decode(string codeWord)
        {
            long currentResult = 0;
            char firstLetter = Convert.ToChar(codeWord.Substring(0, 1));
            char lastLetter = Convert.ToChar(codeWord.Substring(codeWord.Length-1));
            int number = int.Parse(codeWord.Substring(1, codeWord.Length - 2));

            Console.WriteLine(firstLetter);
            Console.WriteLine(lastLetter);
            Console.WriteLine(number);


            return currentResult;
        }
    }

}
