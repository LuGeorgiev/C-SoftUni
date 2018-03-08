using System;

namespace FifthProblemTest
{
    class FifthProblem
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n/2+2; i++)
            {
                if (i == 0)
                    Console.WriteLine("@{0}@{0}@", new string(' ', n-2));
                else if(i==1)
                    Console.WriteLine("**{0}*{0}**", new string(' ', n - 3));
                else if (i ==n/2+1)
                    Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n/2),new string('*', n/2 - 2));
                else if (i == n / 2)
                    Console.WriteLine("*{0}*{1}*{0}*", new string('.', i-1), new string('.', 2 * i - 3));
                else
                    Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",new string('.', i-1), new string(' ',n-2*i-1),new string ('.', 2*i-3));
                

            }
            Console.WriteLine(new string ('*', 2*n-1));
            Console.WriteLine(new string ('*', 2*n-1));

        }
    }
}
 