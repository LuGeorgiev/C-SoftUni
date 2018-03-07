using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FirstTask
{
    class First
    {
        static void Main()
        {
            var moneyIvan = decimal.Parse(Console.ReadLine());
            var numberOfStudent = int.Parse(Console.ReadLine());
            var priceOfSabre = decimal.Parse(Console.ReadLine());
            var priceOfRobe = decimal.Parse(Console.ReadLine());
            var priceOfBelt = decimal.Parse(Console.ReadLine());

            int sabresMustPay = (int)Math.Ceiling(numberOfStudent * 1.1);
            int beltsMustpay = 0;
            int beltCount = 0;
            for (int i = 0; i < numberOfStudent; i++)
            {
                beltCount++;
                beltsMustpay++;
                if (beltCount%6==0)
                {
                    beltCount = 0;
                    beltsMustpay--;
                }
            }

            decimal totalAmount = numberOfStudent * priceOfRobe + sabresMustPay * priceOfSabre + priceOfBelt * beltsMustpay;

            if (totalAmount<= moneyIvan)
            {
                Console.WriteLine($"The money is enough - it would cost {totalAmount:F2}lv.");                
            }
            else
            {
                var moreMOneyNeeded = totalAmount - moneyIvan;
                Console.WriteLine($"Ivan Cho will need {moreMOneyNeeded:F2}lv more.");
            }
                      

        }
    }
}
