using System;
using System.Text.RegularExpressions;

namespace Jan18Snowflake
{
    class Snowflake
    {
        static void Main()
        {

            var surfaceOne = Console.ReadLine();
            var mantleOne = Console.ReadLine();
            var wholeSnowflake = Console.ReadLine();
            var mantleTwo = Console.ReadLine();
            var surfaceTwo = Console.ReadLine();            
            int coreLength = 0;

            if (!ValidSurface(surfaceOne))
            {
                Console.WriteLine("Invalid");
                return;
            }
            if (!ValidMantle(mantleOne))
            {
                Console.WriteLine("Invalid");
                return;
            }

            coreLength = ValidFlake(wholeSnowflake);
            if (coreLength==0)
            {
                Console.WriteLine("Invalid");
                return;
            }
            if (!ValidSurface(surfaceTwo))
            {
                Console.WriteLine("Invalid");
                return;
            }
            if (!ValidMantle(mantleTwo))
            {
                Console.WriteLine("Invalid!");
                return;
            }

            Console.WriteLine("Valid");
            Console.WriteLine(coreLength);
        }

        private static int ValidFlake(string wholeSnowflake)
        {
            int coreLength = 0;
            string corePattern = @"([^a-zA-Z0-9]+)([0-9_]+)([a-zA-Z]+)([0-9_]+)([^a-zA-Z0-9]+)";
            var rgx = new Regex(corePattern);
            var match = rgx.Match(wholeSnowflake);
            if (match.Length!= wholeSnowflake.Length)
            {
                return coreLength;
            }

            //var matches = rgx.Matches(wholeSnowflake);
            coreLength = match.Groups[3].Length;

            return coreLength;
        }

        private static bool ValidMantle(string input)
        {
            bool isValid = true;
            var chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (!(('0' <= chars[i] && chars[i] <= '9')|| chars[i]=='_'))
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }

        private static bool ValidSurface(string input)
        {
            bool isValid = true;
            var chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if ('0'<=chars[i]&&chars[i]<='9'||
                    'a' <= chars[i] && chars[i] <= 'z' ||
                    'A' <= chars[i] && chars[i] <= 'Z')
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
    }
}
