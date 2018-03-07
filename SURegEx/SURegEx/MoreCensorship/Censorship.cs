using System;
using System.Text.RegularExpressions;

namespace MoreCensorship
{
    class Censorship
    {
        static void Main()
        {
            ////1.Censorship
            //string patern = Console.ReadLine();
            //string censoreWith = "";
            //for (int i = 0; i < patern.Length; i++)
            //{
            //    censoreWith += "*";
            //}
            //string input = Console.ReadLine();            
            //string result = Regex.Replace(input, patern, censoreWith);

            //Console.WriteLine(result);

            //2.Email Me
            string eMail = Console.ReadLine();

            string patternAccount = "(.+)@";
            string patternHost = "@(.+)";
            var rgxAccound = new Regex(patternAccount);
            var rgxHost = new Regex(patternHost);

            int accLength = rgxAccound.Match(eMail).Length;
            int hostLength = rgxHost.Match(eMail).Length;

            if (accLength>= hostLength)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");

            }
        }
    }
}
