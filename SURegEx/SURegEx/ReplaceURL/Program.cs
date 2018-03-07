using System;
using System.Text.RegularExpressions;

namespace ReplaceURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<a.+?href.*?=""(.+?)"">(.+?)<\/a>";
            string text = @"<ul> <li> <a href=""http://softuni.bg"">SoftUni</a></li></ul>";
            var rex = new Regex(pattern);

            var result = rex.Replace(text, "[URL href=\"$1\"]$2[/URL]");
            Console.WriteLine(result);
        }
    }
}
