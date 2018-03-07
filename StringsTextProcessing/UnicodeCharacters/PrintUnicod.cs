using System;

namespace UnicodeCharacters
{
    class PrintUnicod
    {
        static void Main()
        {
            var symbols = Console.ReadLine().ToCharArray();

            foreach (var symbol in symbols)
            {
                Console.Write("\\u"+((int)symbol).ToString("X4").ToLower());
            }
            Console.WriteLine();
        }
    }
}
