using System;
using System.Globalization;


namespace Excercises230917
{
    class Excercise230917
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());                                 //   Time + 15 minutes
            int minute = int.Parse(Console.ReadLine());
            minute += 15;
            if (minute < 60)
            {
                if (minute < 10)
                    Console.WriteLine("{0}:0{1}", hour, minute);

                else
                    Console.WriteLine("{0}:{1}", hour, minute);

            }
            else
            {
                hour++;
                minute %= 60;

                if (hour == 24)
                {
                    if (minute < 10)
                        Console.WriteLine("0:0{0}", minute);

                    else
                        Console.WriteLine("0:{0}", minute);
                }
                else
                {
                    if (minute < 10)
                        Console.WriteLine("{0}:0{1}", hour, minute);
                    else
                        Console.WriteLine("{0}:{1}", hour, minute);
                }

            }


        }
    }
}
