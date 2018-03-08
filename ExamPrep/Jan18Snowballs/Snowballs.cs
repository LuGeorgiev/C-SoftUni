using System;
using System.Numerics;

namespace Jan18Snowballs
{
    class Snowballs
    {
        static void Main()
        {
            int numberOfsnowballs = int.Parse(Console.ReadLine());
            int snowballSnow = int.Parse(Console.ReadLine()); 
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            BigInteger snowballValue = BigInteger.Pow(snowballSnow /snowballTime, snowballQuality);

            int maxSnowballSnow = snowballSnow;
            int maxSnowballTime = snowballTime;
            int maxSnowballQuality = snowballQuality;
            BigInteger maxSnowballValue = snowballValue;

            for (int i = 0; i < numberOfsnowballs-1; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (maxSnowballValue< snowballValue)
                {
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                    maxSnowballValue = snowballValue;
                }
            }

            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");
        }
    }
}
