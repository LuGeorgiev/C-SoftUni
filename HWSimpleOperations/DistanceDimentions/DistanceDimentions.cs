using System;


namespace DistanceDimentions
{
    class DistanceDimentions
    {
        static void Main()
        {
            decimal distance = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            decimal result = 0.0m;

            if (input == "m" && output == "mm") result = distance * 1000;                           //Meters in Rest
            else if (input == "m" && output == "cm") result = distance * 100;
            else if (input == "m" && output == "mi") result = distance * 0.000621371192m;
            else if (input == "m" && output == "in") result = distance * 39.3700787m;
            else if (input == "m" && output == "km") result = distance * 0.001m;
            else if (input == "m" && output == "ft") result = distance * 3.2808399m;
            else if (input == "m" && output == "yd") result = distance * 1.0936133m;

            else if (input == "mm" && output == "m") result = distance /1000;                           //All in meters
            else if (input == "cm" && output == "m") result = distance /100;
            else if (input == "mi" && output == "m") result = distance /0.000621371192m;
            else if (input == "in" && output == "m") result = distance /39.3700787m;
            else if (input == "km" && output == "m") result = distance /0.001m;
            else if (input == "ft" && output == "m") result = distance / 3.2808399m;
            else if (input == "yd" && output == "m") result = distance / 1.0936133m;

            else if (input == "mm" && output == "cm") result = distance /10;                           //mm in rest
            else if (input == "mm" && output == "mi") result = distance * 0.000000621371192m;
            else if (input == "mm" && output == "in") result = distance * 0.0393700787m;
            else if (input == "mm" && output == "km") result = distance * 0.000001m;
            else if (input == "mm" && output == "ft") result = distance * 0.0032808399m;
            else if (input == "mm" && output == "yd") result = distance * 0.0010936133m;

            else if (input == "cm" && output == "mm") result = distance * 10;                           //All in mm
            else if (input == "mi" && output == "mm") result = distance *10000/ 0.000621371192m;
            else if (input == "in" && output == "mm") result = distance * 1000/ 39.3700787m;
            else if (input == "km" && output == "mm") result = distance * 1000000;
            else if (input == "ft" && output == "mm") result = distance * 1000/3.2808399m;
            else if (input == "yd" && output == "mm") result = distance * 1000/1.0936133m;
                                                                                                      // cm in rest
            else if (input == "cm" && output == "mi") result = distance * 0.00000621371192m;
            else if (input == "cm" && output == "in") result = distance * 0.393700787m;
            else if (input == "cm" && output == "km") result = distance * 0.00001m;
            else if (input == "cm" && output == "ft") result = distance * 0.032808399m;
            else if (input == "cm" && output == "yd") result = distance * 0.010936133m;

            else if (input == "mi" && output == "cm") result = distance * 100/0.000621371192m;
            else if (input == "in" && output == "cm") result = distance * 100/ 39.3700787m;
            else if (input == "km" && output == "cm") result = distance * 100/ 0.001m ;
            else if (input == "ft" && output == "cm") result = distance * 100/3.2808399m;
            else if (input == "yd" && output == "cm") result = distance * 100/1.0936133m;

            else if (input == "mi" && output == "in") result = distance * 39.3700787m / 0.000621371192m;                    // Miles
            else if (input == "mi" && output == "km") result = distance * 0.001m / 0.000621371192m;
            else if (input == "mi" && output == "ft") result = distance * 3.2808399m / 0.000621371192m;
            else if (input == "mi" && output == "yd") result = distance * 1.0936133m / 0.000621371192m;

            else if (input == "in" && output == "mi") result = distance *   0.000621371192m/ 39.3700787m;                    // rest to Miles
            else if (input == "km" && output == "mi") result = distance *   0.621371192m;
            else if (input == "ft" && output == "mi") result = distance *   0.000621371192m/ 3.2808399m;
            else if (input == "yd" && output == "mi") result = distance *   0.000621371192m/ 1.0936133m;

            else if (input == "in" && output == "km") result = distance * 0.001m / 39.3700787m;                                 //in to rest
            else if (input == "in" && output == "ft") result = distance * 3.2808399m / 39.3700787m;
            else if (input == "in" && output == "yd") result = distance * 1.0936133m / 39.3700787m;

            else if (input == "km" && output == "in") result = distance *  39370.0787m;                                 //in to rest
            else if (input == "ft" && output == "in") result = distance *  39.3700787m/ 3.2808399m;
            else if (input == "yd" && output == "in") result = distance *  39.3700787m/ 1.0936133m;

            else if (input == "km" && output == "ft") result = distance * 3280.8399m;
            else if (input == "km" && output == "yd") result = distance * 1093.6133m;

            else if (input == "ft" && output == "km") result = distance * 0.001m/ 3.2808399m;
            else if (input == "yd" && output == "km") result = distance * 0.001m/ 1.0936133m;

            else if (input == "ft" && output == "yd") result = distance * 1.0936133m/ 3.2808399m;

            else if (input == "yd" && output == "ft") result = distance * 3.2808399m/ 1.0936133m;


            Console.WriteLine("{0:F8}",result);
        }
    }
}
