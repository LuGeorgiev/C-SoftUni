using System;
using System.Text.RegularExpressions;

namespace Jul17RegexMon
{
    class RegexMon
    {
        static void Main(string[] args)
        {
            var dimondPattern = @"[^a-zA-Z-]+";
            var bojPattern = @"[a-zA-Z]+-[a-zA-Z]+";

            var rgxDim = new Regex(dimondPattern);
            var rgxBoj = new Regex(bojPattern);

            var input = Console.ReadLine();
            int startIndex = 0;
            while (true)
            {
                var matchDim = rgxDim.Match(input,startIndex);
                if (matchDim.Success==false)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(matchDim.Value);
                    startIndex = matchDim.Index+matchDim.Length;
                }

                var matchBoj = rgxBoj.Match(input, startIndex);
                if (matchBoj.Success ==false)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(matchBoj.Value);
                    startIndex = matchBoj.Index+matchBoj.Length;
                }

            }
        }
    }
}
