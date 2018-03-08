using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProfit
{
    class DaylyProfit
    {
        static void Main(string[] args)
        {
            //int workDays;
            //while (!(int.TryParse(Console.ReadLine(), out workDays) && workDays >= 5 && workDays <= 30)) ;

            //decimal dailySalary;
            //while (!(decimal.TryParse(Console.ReadLine(), out dailySalary) && dailySalary >= 10m && dailySalary <= 2000m)) ;

            //decimal exchangeRate;
            //while (!(decimal.TryParse(Console.ReadLine(), out exchangeRate) && exchangeRate >= 0.99m && exchangeRate <= 1.99m)) ;

            //decimal dailyAerage;

            //dailyAerage = ((workDays * dailySalary*exchangeRate) * 14.5m * 0.75m)/365m;

            //Console.WriteLine("{0:F2}",dailyAerage);

            int workDays = int.Parse(Console.ReadLine());


            double dailySalary = double.Parse(Console.ReadLine());
            double exchangeRate = double.Parse(Console.ReadLine());
            double dailyAerage;
            dailyAerage = ((workDays * dailySalary * exchangeRate) * 14.5d * 0.75d) / 365d;
            Console.WriteLine("{0:F2}", dailyAerage);




        }
    }
}
