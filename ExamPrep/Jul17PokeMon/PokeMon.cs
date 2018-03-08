using System;

namespace Jul17PokeMon
{
    class PokeMon
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int countPoked = 0;
            int currentN = N;

            while (currentN >= M)
            {
                currentN -= M;
                countPoked++;
                if (currentN==N/2&& currentN>Y&&Y!=0)
                {
                    currentN /= Y;
                }
            }

            Console.WriteLine(currentN);
            Console.WriteLine(countPoked);
        }
    }
}
