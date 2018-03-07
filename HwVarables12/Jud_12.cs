using System;

namespace HwVarables12
{
    class Jud_12
    {
        public static string numbTO;

        static void Main()
        {
            //12.Rectangle Properties
            //double height = double.Parse(Console.ReadLine());
            //double width = double.Parse(Console.ReadLine());

            //double perim = 2 * height + 2 * width;
            //double area = height* width;
            //double diagonal = Math.Sqrt(height * height + width* width);

            //Console.WriteLine("{0}",perim);
            //Console.WriteLine("{0}",area);
            //Console.WriteLine("{0}",diagonal);

            //13.Vowel or Digit
            //char symbol = Char.Parse(Console.ReadLine());
            //bool isDig = Char.IsDigit(symbol);
            //if (isDig)
            //{
            //    Console.WriteLine("digit");
            //}
            //else if (symbol=='a'|| symbol == 'A' || symbol == 'e' || symbol == 'E' || symbol == 'I' || symbol == 'i'
            //    ||symbol=='O' || symbol == 'o' || symbol == 'U' || symbol == 'u' || symbol == 'Y' || symbol == 'y')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("other");
            //}

            //14.Integer to Hex and Binary
            //int num = int.Parse(Console.ReadLine());
            //string hex = Convert.ToString(num, 16).ToUpper();
            //string bin = Convert.ToString(num, 2);
            //Console.WriteLine(hex);
            //Console.WriteLine(bin);

            //15.Fast Prime Checker -Refactor
            //int numb = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= numb; i++)
            //{
            //    bool isPrime = true;
            //    for (int j = 2; j*j <= i; j++)
            //    {
            //        if (i%j==0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    Console.WriteLine($"{i} -> {isPrime}");
            //}

            //16. Comparing Floats
            //double num1 = double.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());
            //double eps = 0.000001d;
            //if (Math.Abs(num1-num2)<eps)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");

            //}

            //17.Print Part of the ASCII Table
            //int first = int.Parse(Console.ReadLine());
            //int second = int.Parse(Console.ReadLine());

            //for (int i = first; i <= second; i++)
            //{

            //    Console.Write((char)i+" ");
            //}


            //18. * Different Integers Size
            //try
            //{
            //    numbTO = Console.ReadLine();                
            //    long num = long.Parse(numbTO);
            //    Console.WriteLine("{0} can fit in:", num);


            //    if (num>=SByte.MinValue&& num <= SByte.MaxValue)
            //    {
            //        Console.WriteLine("* sbyte");

            //    }
            //    if (num >= Byte.MinValue && num <= Byte.MaxValue)
            //    {
            //        Console.WriteLine("* byte");

            //    }
            //    if (num >= -32768 && num <= 32768)
            //    {
            //        Console.WriteLine("* short");

            //    }
            //    if (num >= 0 && num <= 65535)
            //    {
            //        Console.WriteLine("* ushort");

            //    }
            //    if (num >= Int32.MinValue && num <= Int32.MaxValue)
            //    {
            //        Console.WriteLine("* int");

            //    }
            //    if (num >= UInt32.MinValue && num <= UInt32.MaxValue)
            //    {
            //        Console.WriteLine("* uint");
            //        }

            //    if (num >= Int64.MinValue && num <= Int64.MaxValue)
            //    {
            //        Console.WriteLine("* long");

            //    }
            //}
            //catch(Exception)
            //{

            //    Console.WriteLine($"{numbTO} can't fit in any type");
            //}

            //19. * Thea the Photographer

            ulong n = ulong.Parse(Console.ReadLine());
            ulong ft = ulong.Parse(Console.ReadLine());
            ulong ff = ulong.Parse(Console.ReadLine());
            ulong ut = ulong.Parse(Console.ReadLine());
            ulong timeForReview = n * ft;
            ulong phForUpload = Convert.ToUInt64(Math.Ceiling(n * (ff / 100d)));
            ulong totalTime = Convert.ToUInt64(phForUpload * ut + timeForReview);
            
            ulong days = totalTime / 86400;
            ulong hours = (totalTime% 86400) / 3600;
            ulong minutes = (totalTime - days * 86400 - hours * 3600) / 60;
            ulong seconds = (totalTime - days * 86400 - hours * 3600 - minutes * 60);

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
        //public static string numbTO;
    }
}
