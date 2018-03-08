using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Vegetables_Exchange_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //decimal priceVegi;
            // while (!(decimal.TryParse(Console.ReadLine(), out priceVegi) && priceVegi >= 0m && priceVegi <= 1000m)) ;

            //decimal priceFruit;
            // while (!(decimal.TryParse(Console.ReadLine(), out priceFruit) && priceFruit >= 0m && priceFruit <= 1000m)) ;

            // int vegiWeight;
            // while (!(int.TryParse(Console.ReadLine(), out vegiWeight) && vegiWeight >= 0 && vegiWeight <= 1000)) ;

            // int fruitWeight;
            // while (!(int.TryParse(Console.ReadLine(), out fruitWeight) && fruitWeight >= 0 && fruitWeight <= 1000)) ;

            //decimal income;

            //income = (priceVegi *vegiWeight + priceFruit * fruitWeight) / 1.94m;

            //Console.WriteLine("{0:F2}",income);

            double prV = double.Parse(Console.ReadLine());
            double prF = double.Parse(Console.ReadLine());
            int vegiW= int.Parse(Console.ReadLine());
            int fruitW = int.Parse(Console.ReadLine());

            double income;
            income = (prV * vegiW + prF * fruitW) / 1.94d;
            Console.WriteLine("{0:F2}", income);



        }
    }
}
