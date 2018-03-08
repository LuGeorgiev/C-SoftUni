using System;
using System.Text.RegularExpressions;

namespace Nov17Vox
{
    class Vox
    {
        static void Main()
        {
            string patternPraceholders = @"([a-zA-Z]+)(.+)(\1)"; //Group 2 to replace
            string patternToReplace = @"{(.+?)}"; // Group 1 to replace with

            var rgxPlaceholder = new Regex(patternPraceholders);
            var rgxReplaceWith = new Regex(patternToReplace);

            string encodedText = Console.ReadLine();
            string toReplace = Console.ReadLine();

            var matchesPlaceholder = rgxPlaceholder.Matches(encodedText);
            var matchesToReplace = rgxReplaceWith.Matches(toReplace);

            for (int i = 0; i < matchesPlaceholder.Count; i++)
            {
                encodedText = encodedText.Replace(matchesPlaceholder[i].Groups[2].Value
                    , matchesToReplace[i].Groups[1].Value);
            }

            Console.WriteLine(encodedText);
        }
    }
}
