using System;

using System.Globalization;

namespace _1000DaysOnEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime birth = DateTime.Parse(Console.ReadLine());
            // birth = birth.AddDays(999);
            //string date = birth.ToString("dd-MM-yyy");
            // Console.WriteLine(date);

            //String format;                                                       //Correct solution MINE
            //DateTime result;
            //CultureInfo provider = CultureInfo.InvariantCulture;

            //string birthDay = Console.ReadLine();

            //format = "dd-MM-yyyy";

            //result = DateTime.ParseExact(birthDay, format,provider);
            //result = result.AddDays(999);

            //Console.WriteLine(result.ToString(format));



            //Slav Petev solution
            var birthDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            birthDate = birthDate.AddDays(999);
            Console.WriteLine(birthDate.ToString("d-M-yyyy"));
        }
    }
}
