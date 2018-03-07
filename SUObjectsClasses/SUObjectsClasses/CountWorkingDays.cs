using System;
using System.Globalization;

namespace SUObjectsClasses
{
    class CountWorkingDays
    {
        static void Main()
        {
            string format= "dd-MM-yyyy";
            var startDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
            var workingDayCount = 0;
            while (startDate<= endDate)
            {
                string currentDate = startDate.Day + "-" + startDate.Month;

                if (!(startDate.DayOfWeek.ToString()=="Saturday" || startDate.DayOfWeek.ToString() == "Sunday"))
                {
                    
                    if(currentDate!="1-1"&& currentDate != "3-3" && currentDate != "1-5" &&
                        currentDate != "6-6" && currentDate != "24-5" && currentDate != "6-9" &&
                        currentDate != "22-9" && currentDate != "1-11" &&
                        currentDate != "24-12" && currentDate != "25-12" && currentDate != "26-12")
                    {
                        workingDayCount++;
                    }
                }

                startDate = startDate.AddDays(1);
            }           

            Console.WriteLine(workingDayCount);
                 
        }
    }
}
