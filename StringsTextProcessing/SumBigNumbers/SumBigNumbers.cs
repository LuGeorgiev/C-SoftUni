using System;
using System.Linq;
using System.Collections.Generic;

namespace SumBigNumbers
{
    class SumBigNumbers
    {
        static string SumTwoArrays(string first, string second)
        {
            var shorter = first.Length < second.Length
              ? first.Reverse().ToArray().Select(x => Convert.ToByte(x - '0')).ToArray()
              : second.Reverse().ToArray().Select(x => Convert.ToByte(x - '0')).ToArray();

            var longer = first.Length >= second.Length
                ? first.Reverse().ToArray().Select(x => Convert.ToByte(x - '0')).ToArray()
                : second.Reverse().ToArray().Select(x => Convert.ToByte(x - '0')).ToArray();
            int k = shorter.Length;

            byte[] sum = new byte[longer.Length + 1];

            for (int i = 0; i < k; i++)
            {
                byte a = shorter[i];
                byte b = longer[i];
                byte ab = sum[i];

                if ((a + b + ab) >= 10)
                {
                    sum[i + 1] ++;
                }
                sum[i] = Convert.ToByte((a + b+ ab) % 10);

            }

            for (int i = k; i < longer.Length; i++)
            {
                if (sum[i] + longer[i] >= 10)
                {
                    sum[i + 1] ++;
                }
                sum[i] = Convert.ToByte((sum[i] + longer[i]) % 10);
            }

            string result = "";
            List<byte> res = sum.ToList();
            byte member = res[res.Count - 1];
            while (member==0)
            {
                res.RemoveAt(res.Count - 1);
                member = res[res.Count - 1];
            }
            res.Reverse();

            foreach (var item in res)
            {
                result += item;
            }

            return result;
        }
        static void Main()
        {
            string first  = Console.ReadLine();
            string second = Console.ReadLine();


            var result = SumTwoArrays(first, second);
            
            Console.WriteLine(result);



        }
    }
}
