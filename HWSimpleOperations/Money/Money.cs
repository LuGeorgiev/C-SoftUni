using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            //int bit;
            //while (!(int.TryParse(Console.ReadLine(), out bit) && bit >= 0 && bit <= 20)) ;

            //decimal joan;
            //while (!(decimal.TryParse(Console.ReadLine(), out joan) && joan >= 0m && joan <= 50000m)) ;

            //decimal commission;
            //while (!(decimal.TryParse(Console.ReadLine(), out commission) && commission >= 0m && commission <= 5m)) ;

            //decimal money;
            //money = (bit * 1168m / 1.95m +joan*0.15m*1.76m/1.95m)*((100m-commission)/100m);

            //Console.WriteLine("{0:F2}", money);

            int bit = int.Parse(Console.ReadLine());
            double joan= double.Parse(Console.ReadLine());
            double commission =double.Parse(Console.ReadLine());
            double money;
            money = (bit * 1168d / 1.95d + joan * 0.15d * 1.76d / 1.95d) * ((100 - commission) / 100);

            Console.WriteLine("{0:F2}", money);








        }
    }
}
