using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthProblemTest
{
    class ForthProblemTest
    {
        static void Main()
        {
            //int n = int.Parse(Console.ReadLine());                                        // Granpa STAVRI
            //double litters = 0.0;
            //double totalLitters = 0.0;
            //double degree =  0.0;
            //double totalDegrees = 0.0;

            //for (int i = 0; i < n; i++)
            //{
            //    litters = double.Parse(Console.ReadLine());
            //    degree = double.Parse(Console.ReadLine());

            //    totalLitters += litters;
            //    totalDegrees += litters * degree;
            //}
            //totalDegrees = totalDegrees / totalLitters;

            //Console.WriteLine("Liter: {0:f2}",totalLitters);
            //Console.WriteLine("Degrees: {0:f2}", totalDegrees);

            //if (totalDegrees<38)
            //    Console.WriteLine("Not good, you should baking!");
            //else if (totalDegrees>=38&& totalDegrees<=42)
            //    Console.WriteLine("Super!");
            //else
            //    Console.WriteLine("Dilution with distilled water!");                     // Granpa STAVRI

            //int length = int.Parse(Console.ReadLine());                                   // CAKE
            //int width = int.Parse(Console.ReadLine());
            //int pices = length * width;

            //do
            //{
            //    string taken = Console.ReadLine();
            //    if (taken=="STOP")
            //    {                    
            //        break;
            //    }
            //    pices -= int.Parse(taken);

            //} while (pices>=0);


            //if (pices<0)
            //{
            //    Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(pices));
            //}
            //else
            //{
            //    Console.WriteLine("{0} pieces are left.", pices);
            //}                                                                              //Cake



            //int days    = int.Parse(Console.ReadLine());                                        //enrgy loss
            //int dancers = int.Parse(Console.ReadLine());
            //double energy = 0.0;
            //for (int i = 1; i <= days; i++)
            //{
            //    int hours = int.Parse(Console.ReadLine());

            //    if (i%2==0&&hours%2==0)
            //    {
            //        energy += 68 * dancers;
            //    }
            //    else if (i % 2 == 1 && hours % 2 == 0)
            //    {
            //        energy += 49 * dancers;
            //    }
            //    else if (i % 2 == 0 && hours % 2 == 1)
            //    {
            //        energy += 65 * dancers;
            //    }
            //    else
            //    {
            //        energy += 30 * dancers;
            //    }                
            //}
            //energy = (100 * dancers * days - energy)/days/dancers;

            //if (energy<50)
            //{
            //    Console.WriteLine("They are wasted! Energy left: {0:f2}",energy);
            //}
            //else
            //{
            //    Console.WriteLine("They feel good! Energy left: {0:f2}", energy);
            //}                                                                                                               //energy loss

            //int pieces = int.Parse(Console.ReadLine());                                           //money Prize
            //double money = double.Parse(Console.ReadLine());
            //int points = 0;

            //for (int i = 1; i <= pieces; i++)
            //{
            //    int current= int.Parse(Console.ReadLine());

            //    if (i%2==0)
            //    {
            //        points += current*2;
            //    }
            //    else
            //    {
            //        points += current;
            //    }
            //}
            //money = money * points;
            //Console.WriteLine("The project prize was {0:f2} lv.", money);                         // money Prize

            int capacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());
            int countA = 0, countB = 0, countV = 0, countG = 0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine().ToUpper();

                if (sector == "A")
                    countA++;
                else if (sector == "B")
                    countB++;
                else if (sector == "V")
                    countV++;
                else if (sector == "G")
                    countG++;
            }
            
            Console.WriteLine("{0:f2}%", countA / (double)fans *100);
            Console.WriteLine("{0:f2}%", countB / (double)fans * 100);
            Console.WriteLine("{0:f2}%", countV / (double)fans * 100);
            Console.WriteLine("{0:f2}%", countG / (double)fans * 100);
            Console.WriteLine("{0:f2}%", fans / (double)capacity * 100);

        }
    }
}
