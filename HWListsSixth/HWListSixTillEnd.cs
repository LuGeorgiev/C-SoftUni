using System;
using System.Linq;
using System.Collections.Generic;

namespace HWListsSixth
{
    class HWListSixTillEnd
    {
        //6.	Sum Reversed Numbers
        private static void ReverseDigitAndSum(string[] toReversAndSum)
        {
            var reverestDigitArr  = toReversAndSum
                .Reverse()
                .Select(c => new string(c.Reverse().ToArray()))
                .ToArray();

            List<int> listToSum = reverestDigitArr
                .Select(int.Parse)
                .ToList();

            int sum = listToSum.Sum();
            Console.WriteLine(sum);
        }
        //7.Bomb Numbers
        private static void BombNumbersSum(string intLine, string bomb)
        {
            List<int> intList = intLine.Split(' ')
                .Select(x => int.Parse(x))
                .ToList();
            int[] bombNumb = bomb.Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();

            int bombIndex = intList.IndexOf(bombNumb[0]); ;
            List<int> afterExplosion = new List<int>();
            
            while (bombIndex!=-1)
            {
                afterExplosion.Clear();
                int explosionStart = bombIndex - bombNumb[1];
                int explosionEnd = bombIndex + bombNumb[1];

                if (explosionStart<0)
                {
                    explosionStart = 0;
                }
                if (explosionEnd > intList.Count-1)
                {
                    explosionEnd = intList.Count - 1;
                }

                for (int i = 0; i < intList.Count; i++)
                {
                    if (i< explosionStart|| explosionEnd<i)
                    {
                        afterExplosion.Add(intList[i]);
                    }
                }
                intList.Clear();
                intList.AddRange(afterExplosion);
                bombIndex = intList.IndexOf(bombNumb[0]);
            }
                int sum = afterExplosion.Sum();
                Console.WriteLine(sum);
        }

        static void Main()
        {
            //6.Sum Reversed Numbers
            string[] toReversAndSum = Console.ReadLine().Split(' ').ToArray();
            ReverseDigitAndSum(toReversAndSum);

            //7.Bomb Numbers
            //string line = Console.ReadLine();
            //string bomb = Console.ReadLine();
            //BombNumbersSum(line,bomb);
        }

    }
}
