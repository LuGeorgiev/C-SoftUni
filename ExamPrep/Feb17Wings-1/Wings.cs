using System;
using System.Numerics;

namespace Feb17Wings_1
{
    class Wings
    {
        static void Main(string[] args)
        {
            int flaps = int.Parse(Console.ReadLine());
            double metFor1000Flaps = double.Parse(Console.ReadLine());
            int restPerFlaps = int.Parse(Console.ReadLine());

            double distance = (flaps / 1000d) * metFor1000Flaps;
            BigInteger seconds = flaps / 100;

            seconds += (flaps / restPerFlaps)*5;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{seconds} s.");
        }
    }
}
