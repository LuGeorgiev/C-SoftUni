using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SixthProblem
{
    class SixthProblem
    {
        static void Main()
        {
            var sum = 0;
            var num = 3456;
            var add = 1;
            for (int i = 1; i <= num; i++)
            {

                sum += add;
                if (i % 2 == 0)
                    add++;
            }
            Console.WriteLine(sum);

        }
    }
}
