using System;
using System.Linq;
using System.Collections.Generic;

namespace MultiplyBiNUmbers
{
    class MultiplyBig
    {
        static string MultiyBig(string first, string second)
        {
            List<byte> firstNum= first.TrimStart('0')
                .Reverse()
                .ToArray()
                .Select(x => Convert.ToByte(x-'0'))
                .ToList();
            List<byte> secondNum= second.TrimStart('0')
                .Reverse()
                .ToArray().Select(x => Convert.ToByte(x-'0'))
                .ToList();
            List<byte> result = new List<byte>(secondNum.Count+firstNum.Count+1);
            for (int i = 0; i < secondNum.Count + firstNum.Count+1; i++)
            {
                result.Add(0);
            }
            for (int i = 0; i < firstNum.Count; i++)
            {
                for (int j = 0; j < secondNum.Count; j++)
                {
                    int index = j + i;
                    byte currentMultyply = Convert.ToByte( firstNum[i] * secondNum[j]);
                    byte secondDig = Convert.ToByte(currentMultyply % 10);
                    result[index] += secondDig;                  

                    byte firstDig = Convert.ToByte(currentMultyply / 10);
                    if (firstDig>0)
                    {
                        result[index + 1] += firstDig;                       
                    }

                    for (int k = index; k < result.Count-1; k++)
                    {
                        if (result[k]>9)
                        {
                            byte thisDigit = Convert.ToByte(result[k] % 10);
                            byte toTransfer = Convert.ToByte(result[k] / 10);
                            result[k] = thisDigit;
                            result[k+1] += toTransfer;
                        }
                    }
                }
            }
            string res = "";
            result.Reverse();
            while (result.Count>0&&result[0]==0)
            {
                result.RemoveAt(0);
            }
            if (result.Count==0)
            {
                return "0";
            }

            foreach (var digit in result)
            {
                res += digit;
            }      
                  
            return res;
        }

        static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();


            var result = MultiyBig(first, second);
            Console.WriteLine(result);

            
        }
    }
}
