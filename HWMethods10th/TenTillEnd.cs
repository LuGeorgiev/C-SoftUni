using System;
using System.Numerics;

namespace HWMethods10th
{
    class TenTillEnd
    {
        //10.	Cube Properties
        public static void CubeCalculations(double edge, string characteristic)
        {
            double result = 0;
            if (characteristic=="face")
            {
                result = Math.Sqrt(2 * edge * edge);
            }
            else if (characteristic == "space")
            {
                result = Math.Sqrt(3 * edge * edge);

            }
            else if (characteristic == "volume")
            {
                result = edge * edge * edge;
            }
            else
            {
                result = 6 * edge * edge;

            }
            Console.WriteLine($"{result:F2}");
        }
        //11.	Geometry Calculator
        public static void TriangleSurface(double side, double height)
        {
            double surface = side * height / 2.0;
            Console.WriteLine($"{surface:f2}");
        }
        public static void RectangleSurface(double width, double height)
        {
            double surface = width * height;
            Console.WriteLine($"{surface:f2}");
        }
        public static void CircleSurface(double radius)
        {
            double surface = Math.PI*radius*radius;
            Console.WriteLine($"{surface:f2}");
        }
        public static void SquareSurface(double side)
        {
            double surface = side * side;
            Console.WriteLine($"{surface:f2}");
        }
        //12.	Master Numbers
        public static bool IsSymmetric(int num)
        {
            bool symetric = true;
            string number = num.ToString();
            for (int i = 0; i < number.Length/2; i++)
            {
                if (number[i] != number[number.Length-1-i])
                {
                    symetric = false;
                    break;
                }
            }

            return symetric;
        }
        public static bool HoldsEvenDigit(int num)
        {
            bool hasEvenDigit = false;
            while (num>0)
            {
                if (num%2==0)
                {
                    hasEvenDigit = true;
                    break;
                }
                num /= 10;
            }
            return hasEvenDigit;
        }
        public static bool DigitsSumDivisibleBySeven(int num)
        {
            bool divisibleBySevenSum = false;
            int sum = 0;
            while (num>0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum%7==0)
            {
                divisibleBySevenSum = true;
            }
            return divisibleBySevenSum;
        }
        public static void MasterNumber(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                bool isSymmetric = IsSymmetric(i);
                bool holdEvenDigit = HoldsEvenDigit(i);
                bool isDevisibvBySeven =(DigitsSumDivisibleBySeven(i));

                if (isSymmetric&& holdEvenDigit && isDevisibvBySeven)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //13. Factorial
        public static BigInteger Factorial(int num)
        {
            BigInteger nTHFact = 1;
            for (int i = 1; i <= num; i++)
            {
                nTHFact *= i;
            }
            return nTHFact;
        }
        //14.	Factorial Trailing Zeroes
        public static int FactorialTrailingZeroes(int factNumber)
        {
            BigInteger factorial = Factorial(factNumber);
            int zeroes = 0;
            while (factorial%10==0)
            {
                zeroes++;
                factorial /= 10;
            }

            return zeroes;
        }

        static void Main(string[] args)
        {
            //10.Cube Properties
            //double edge = double.Parse(Console.ReadLine());
            //string charecteristic = Console.ReadLine();
            //CubeCalculations(edge, charecteristic);

            //11.Geometry Calculator
            //string figureType = Console.ReadLine();
            //if (figureType=="triangle")
            //{
            //    double side = double.Parse(Console.ReadLine());
            //    double height = double.Parse(Console.ReadLine());
            //    TriangleSurface(side,height);
            //}
            //else if (figureType == "rectangle")
            //{
            //    double width = double.Parse(Console.ReadLine());
            //    double height = double.Parse(Console.ReadLine());
            //    RectangleSurface(width, height);
            //}
            //else if (figureType == "square")
            //{
            //    double side = double.Parse(Console.ReadLine());
            //    SquareSurface(side);
            //}
            //else
            //{
            //    double radius = double.Parse(Console.ReadLine());
            //    CircleSurface(radius);
            //}

            //12.Master Numbers
            //int masterNum = int.Parse(Console.ReadLine());
            //MasterNumber(masterNum);

            //13. Factorial
            //int factorial = int.Parse(Console.ReadLine());
            //Console.WriteLine(Factorial(factorial)); 

            //14.factorial trailing zeroes
            int factorial = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialTrailingZeroes(factorial));

        }
    }
}
