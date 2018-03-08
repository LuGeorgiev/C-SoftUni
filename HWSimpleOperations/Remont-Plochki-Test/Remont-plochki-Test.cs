using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remont_Plochki_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n;
            //while (!(int.TryParse(Console.ReadLine(), out n) && n >= 1 && n <= 100)) ;
            //double w;
            //while (!(double.TryParse(Console.ReadLine(), out w) && w >= 0.1 && w <= 10.00)) ;
            //double l;
            //while (!(double.TryParse(Console.ReadLine(), out l) && l >= 0.1 && l <= 10.00)) ;
            //int m;
            //while (!(int.TryParse(Console.ReadLine(), out m) && m >= 0 && m <= 10)) ;
            //int o;
            //while (!(int.TryParse(Console.ReadLine(), out o) && m >= 0 && o <= 10)) ;
            //double tiles;        

            //tiles = (double)(n * n-m*o) / (w * l);
            //Console.WriteLine("{0:F2}",tiles);
            //Console.WriteLine("{0:F2}",(tiles*0.2));

            int n = int.Parse(Console.ReadLine());
                       
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
                        
            int m = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());
            
            double tiles;

            tiles = (double)(n * n - m * o) / (w * l);
            Console.WriteLine("{0:F2}", tiles);
            Console.WriteLine("{0:F2}", (tiles * 0.2));




        }
    }
}
