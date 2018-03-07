using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class ExtractMails
    {
        static void Main(string[] args)
        {
            //string pattern = @"\w+([-.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            string pattern = @"[a-zA-Z0-9]+([-.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            //string text = "Please contact us at: _support@github.com email to s.miller@mit.edu and j.hopking@york.ac.uk ";
            var text = Console.ReadLine();
            var regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
