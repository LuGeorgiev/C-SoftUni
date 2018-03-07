using System;
using System.Linq;
using System.Numerics;

namespace Base10toBaseN
{
    class Base10toNConverter
    {
        
        static string FromDecimalToAny(BigInteger toConvert, int numericSys)
        {
            string result = "";
            string basic = "0123456789ABCDEF";
            do
            {
                result = toConvert % numericSys + result;
                toConvert /= numericSys;
            } while (toConvert > 0);

            return result;
        }
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();

            int outputBase = int.Parse(numbers[0].Trim());
            BigInteger toConvert = BigInteger.Parse(numbers[1].Trim());                                    // Convert from decimal to any 2-16 numeber system

            Console.WriteLine(FromDecimalToAny(toConvert, outputBase));
           
        }
    }
}
