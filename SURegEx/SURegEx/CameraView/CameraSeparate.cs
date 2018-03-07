using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    class CameraSeparate
    {
        static void Main()
        {
            string[] separators = Console.ReadLine().Split(' ').ToArray();
            string text = Console.ReadLine();
            int toSkip = int.Parse(separators[0]);
            int toKeep = int.Parse(separators[1]);

            string pattern = @"\|<([a-zA-Z0-9]{" + toSkip + @"})([a-zA-Z0-9]{0," + toKeep + "})";

            var rgx = new Regex(pattern);
            MatchCollection matches = Regex.Matches(text,pattern);
            int count = 0;
            foreach (Match match in matches)
            {
                if (count>0)
                {
                    Console.Write(", ");
                }
                Console.Write(match.Groups[2].Value);
                count++;
            }
            Console.WriteLine();
        }
    }
}
