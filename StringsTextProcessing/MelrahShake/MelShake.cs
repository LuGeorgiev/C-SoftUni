using System;

namespace MelrahShake
{
    class MelShake
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                int frontIndex = input.IndexOf(pattern);
                int backIndex = input.LastIndexOf(pattern);

                if (frontIndex>-1&&backIndex>-1&& frontIndex!=backIndex&&input.Length>0&& pattern.Length > 0)
                {
                    input = input.Remove(backIndex, pattern.Length);
                    input = input.Remove(frontIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");                    
                    pattern = pattern.Remove(pattern.Length / 2, 1);                    
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }

            }
        }
    }
}
