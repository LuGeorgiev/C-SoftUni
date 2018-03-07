using System;
using System.Text.RegularExpressions;

namespace UseChains
{
    class UseChains
    {
        static void Main()
        {
            string pTagPattern = @"<p>(.*?)<\/p>";
            string replaceNonLetPattern = @"[^a-z0-9]+";
            string textToDecode = Console.ReadLine();

            var rgx = new Regex(pTagPattern);
            var matches = rgx.Matches(textToDecode);
            var noTagsText = "";
            foreach (Match match in matches)
            {
                noTagsText+= Regex.Replace(match.Groups[1].Value, replaceNonLetPattern, w => " ");
            }

            Decode(noTagsText);
        }

        private static void Decode(string noTagsText)
        {
            var arrChar = noTagsText.ToCharArray();
            var result = new char[arrChar.Length];
            for (int i=0; i< arrChar.Length;i++)
            {
                if ('a'<= arrChar[i] && arrChar[i] <= 'm')
                {
                    result[i] = (char)(arrChar[i] + 13);
                }
                else if('n' <= arrChar[i] && arrChar[i] <= 'z') 
                {
                    result[i]= (char)(arrChar[i] - 13);
                }
                else
                {
                    result[i]= arrChar[i];
                }
            }
            Console.WriteLine(string.Join("",result));
        }
    }
}
