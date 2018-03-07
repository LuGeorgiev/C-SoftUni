using System;
using System.Text;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    class KeyReplacer
    {
        static void Main()
        {
            string pattern = @"^([a-zA-Z]+)[\\|\\<\\\\](.+)[\\|\\<\\\\]([a-zA-Z]+)$";
            string input = Console.ReadLine();
            Regex rgx = new Regex(pattern);
            Match match = rgx.Match(input);


            string start = match.Groups[1].Value;
            string end = match.Groups[3].Value;

            string wordPattern = $@"{start}(?!{end})(.*?){end}";
            string textInput = Console.ReadLine();

            MatchCollection matches = Regex.Matches(textInput, wordPattern);
            
            if (matches.Count>0)
            {
                foreach (Match item in matches)
                {
                    Console.Write(item.Groups[1].Value);
                }
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
