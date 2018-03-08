using System;
using System.Collections.Generic;
using System.Linq;

namespace Feb17Assault_3
{
    class Assault
    {
        static void Main()
        {
            var beeHives = Console.ReadLine()
                 .Split(' ')
                 .Select(long.Parse)
                 .ToList();
            var hornets = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            var hornetsAttack = hornets.Sum();
            for (int i = 0; i < beeHives.Count; i++)
            {
                if (hornets.Count==0)
                {
                    break;
                }

                var attackResult = beeHives[i] - hornetsAttack;
                if (attackResult<0)
                {
                    beeHives[i] = 0;
                }
                else if (attackResult == 0)
                {
                    beeHives[i] = 0;
                    hornetsAttack -= hornets[0];
                    hornets.RemoveAt(0);

                }
                else
                {
                    beeHives[i] = attackResult;
                    hornetsAttack -= hornets[0];
                    hornets.RemoveAt(0);
                }

            }

            if (beeHives.Sum()>0)
            {
                foreach (var hive in beeHives)
                {
                    if (hive>0)
                    {
                        Console.Write(hive+" ");
                    }
                }
            }
            else
            {
                foreach (var hornet in hornets)
                {
                    Console.Write(hornet+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
