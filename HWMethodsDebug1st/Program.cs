using System;
using System.Collections.Generic;

namespace HWMethodsDebug1st
{
    class Program
    {
        //1.	Hello, Name!
        public static void HelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        //2.	Max Method
        public static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }
        //3.	English Name оf the Last Digit
        public static void NameOfLastDigit(string num)
        {
            char reminder = num[num.Length - 1];
            switch (reminder)
            {
                case '1':
                    Console.WriteLine("one");
                    break;
                case '2':
                    Console.WriteLine("two");
                    break;
                case '3':
                    Console.WriteLine("three");
                    break;
                case '4':
                    Console.WriteLine("four");
                    break;
                case '5':
                    Console.WriteLine("five");
                    break;
                case '6':
                    Console.WriteLine("six");
                    break;
                case '7':
                    Console.WriteLine("seven");
                    break;
                case '8':
                    Console.WriteLine("eight");
                    break;
                case '9':
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("zero");
                    break;
            }
        }
        //4.	Numbers in Reversed Order
        public static void ReviseStrig(string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }
        //5.	Fibonacci Numbers
        public static decimal NthFibonachi(int n)
        {
            decimal fibNth = 0;
            decimal fibNthMinusTwo = 1;
            decimal fibNthMinusOne = 1;
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {

                for (int i = 1; i < n; i++)
                {
                    fibNth = fibNthMinusTwo + fibNthMinusOne;
                    fibNthMinusTwo = fibNthMinusOne;
                    fibNthMinusOne = fibNth;
                }
                return fibNth;
            }

        }
        //6.	Prime Checker
        public static bool IsPrime(long num)
        {
            var isPrime = true;
            if (num == 2)
            {
                return true;
            }
            else if (num % 2 == 0)
            {
                return false;
            }
            else if (num == 0 || num == 1)
            {
                return false;
            }

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
        //7.	* Primes in Given Range
        public static List<int> PrimeNumbers(int startNum, int endNum)
        {
            var primes = new List<int>();
            if (endNum < startNum)
            {
                return primes;
            }
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
        //8.	Center Point
        public static double[] ClosestToCenter(double[] coordinates)
        {
            double[] closest = new double[2];

            closest[0] = coordinates[0];
            closest[1] = coordinates[1];

            for (int i = 2; i < coordinates.Length; i += 2)
            {
                double currentClosest = Math.Sqrt(closest[0] * closest[0] + closest[1] * closest[1]);
                double nextLine = Math.Sqrt(coordinates[i] * coordinates[i] + coordinates[i + 1] * coordinates[i + 1]);

                if (currentClosest > nextLine)
                {
                    closest[0] = coordinates[i];
                    closest[1] = coordinates[i + 1];
                }
            }

            return closest;
        }
        //9.	Longer Line
        public static void LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double lineOneLength = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double lineTwoLength = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            double longerX1 = x1;
            double longerY1 = y1;
            double longerX2 = x2;
            double longerY2 = y2;

            if (lineTwoLength > lineOneLength)
            {
                longerX1 = x3;
                longerY1 = y3;
                longerX2 = x4;
                longerY2 = y4;
            }

            double poinOneDist = Math.Sqrt(longerX1 * longerX1 + longerY1 * longerY1);
            double poinTwoDist = Math.Sqrt(longerX2 * longerX2 + longerY2 * longerY2);
            if (poinTwoDist < poinOneDist)
            {
                double tempX1 = longerX1;
                double tempY1 = longerY1;
                longerX1 = longerX2;
                longerY1 = longerY2;
                longerX2 = tempX1;
                longerY2 = tempY1;
            }

            Console.WriteLine($"({longerX1}, {longerY1})({longerX2}, {longerY2})");
        }

        static void Main(string[] args)
        {
            //1.
            //string name = Console.ReadLine();
            //HelloName(name);

            //2.
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine(GetMax(c, GetMax(a, b)));

            //3.	English Name оf the Last Digit
            string num = Console.ReadLine();
            NameOfLastDigit(num);

            //4.Numbers in Reversed Order
            //string num = Console.ReadLine();
            //ReviseStrig(num);

            //5.	Fibonacci Numbers
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(NthFibonachi(num));

            //6. Prime Checker
            //long num = long.Parse(Console.ReadLine());
            //Console.WriteLine(IsPrime(num)); 

            //7.  * Primes in Given Range
            //int startNum = int.Parse(Console.ReadLine());
            //int endNum = int.Parse(Console.ReadLine());            
            //var line = new List<int>();
            //line = PrimeNumbers(startNum, endNum);
            //Console.WriteLine(String.Join(", ",line));

            //8.Center Point
            //var lines = new double[4];
            //for (int i = 0; i < 4; i++)
            //{
            //    lines[i]= double.Parse(Console.ReadLine());
            //}
            //var closest = new double[2];
            //closest = ClosestToCenter(lines);
            //Console.WriteLine("("+String.Join(", ",closest)+")");

            //9.Longer Line
            //var x1 = double.Parse(Console.ReadLine());
            //var y1 = double.Parse(Console.ReadLine());
            //var x2 = double.Parse(Console.ReadLine());
            //var y2 = double.Parse(Console.ReadLine());
            //var x3 = double.Parse(Console.ReadLine());
            //var y3 = double.Parse(Console.ReadLine());
            //var x4 = double.Parse(Console.ReadLine());
            //var y4 = double.Parse(Console.ReadLine());
            //LongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
    }
}
