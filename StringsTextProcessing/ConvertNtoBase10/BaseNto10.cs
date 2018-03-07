using System;
using System.Linq;
using System.Numerics;

namespace ConvertNtoBase10
{
    class BaseNto10
    {
        static BigInteger ToDecimal(char[] toConvert, int numBase)
        {
            BigInteger dec = 0;
           
            for (int i = 0; i <toConvert.Length; i++)
            {
                dec=dec* numBase+ (toConvert[i] - '0');
                            
            }
            return dec;
        }
        static void Main()
        {

            string number = Console.ReadLine();   
            
            int baseOfNumber = int.Parse(number.Split(' ').First());
            string toConvert = number.Split(' ').Last().Trim().ToUpper();            
            char[] numberToConvert = toConvert.ToCharArray();


            Console.WriteLine(ToDecimal(numberToConvert, baseOfNumber));        // Converts from 2-16 to decimal

            
        }
    }
}
