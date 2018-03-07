using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var search = Console.ReadLine();
            var text = Console.ReadLine();
            string[] sentenses = text.Split(new[] { '.', '?', '!' }).ToArray();
            var pattern = "\\W"+search+"\\W";

            Regex rgx = new Regex(pattern);
            foreach (var sentence in sentenses)
            {
                if (rgx.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
            
        }
    }
}
