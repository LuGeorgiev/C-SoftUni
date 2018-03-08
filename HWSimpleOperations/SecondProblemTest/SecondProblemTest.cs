using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProblemTest
{
    class SecondProblemTest
    {
        static void Main()
        {
            //    double kilometers = double.Parse(Console.ReadLine());                 // Transport Price
            //    string time = Console.ReadLine();

            //    double taxiPrice = double.MaxValue;
            //    double busPrice = double.MaxValue;
            //    double trainiPrice = double.MaxValue;
            //    double bestPrice = 0.0;

            //    if (kilometers>=100)            
            //        trainiPrice = kilometers * 0.06;

            //    if (kilometers >= 20)            
            //        busPrice = kilometers * 0.09;

            //    if (time=="day")            
            //        taxiPrice = 0.70 + kilometers * 0.79;

            //    else             
            //        taxiPrice = 0.70 + kilometers * 0.90;


            //    if (trainiPrice<taxiPrice&&trainiPrice<busPrice)            
            //        bestPrice = trainiPrice;

            //    else if (busPrice<trainiPrice&&busPrice<taxiPrice)            
            //        bestPrice = busPrice;

            //    else            
            //        bestPrice = taxiPrice;            

            //    Console.WriteLine("{0:F2}",bestPrice);



            //int volume = int.Parse(Console.ReadLine());                                 // Pipes
            //int firstPipe = int.Parse(Console.ReadLine());
            //int secondPipe = int.Parse(Console.ReadLine());

            //double time = double.Parse(Console.ReadLine());

            //if ((firstPipe+secondPipe)*time>volume)
            //{
            //    double overflow = (firstPipe + secondPipe) * time - volume;                
            //    Console.WriteLine("For {0:F1} hours the pool overflows with {1:F1} liters.",time,overflow);
            //}
            //else
            //{
            //    double pp = (firstPipe + secondPipe) * time;
            //    double finalVolume = pp/volume;
            //    double firstPipeVolume = firstPipe*time/pp;
            //    double secondPipeVolume = secondPipe*time/pp;

            //    Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
            //        Math.Truncate(finalVolume*100),Math.Truncate(firstPipeVolume*100),Math.Truncate(secondPipeVolume*100));
            //}

                                                                                        // Tom sleep
            //int dayOff = int.Parse(Console.ReadLine());
            //int playtime = (365 - dayOff) * 63 + dayOff * 127;
            //if (playtime>30000)
            //{
            //    Console.WriteLine("Tom will run away");
            //    int hours = (playtime - 30000) / 60;
            //    int minutes = (playtime - 30000) % 60;
            //    Console.WriteLine("{0} hours and {1} minutes more for play",hours,minutes);
            //}
            //else
            //{
            //    Console.WriteLine("Tom sleeps well");
            //    int hours = (30000-playtime) / 60;
            //    int minutes = (30000 - playtime) % 60;
            //    Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            //}

            int area = int.Parse(Console.ReadLine());                                          // Wine-producing
            double grapePerMeter = double.Parse(Console.ReadLine());
            int wineToSell = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double wine = area * 0.4*grapePerMeter/2.5;

            if (wine<wineToSell)
            {
                wine = wineToSell - wine;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(wine));
            }

            else
            {
                double literPerWorker = (wine - wineToSell) / workers;
                Console.WriteLine(literPerWorker);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters. {1} liters left -> {2} liters per person.", 
                    Math.Floor(wine),Math.Ceiling(wine - wineToSell), Math.Ceiling(literPerWorker));
            }

        }
    }
}
