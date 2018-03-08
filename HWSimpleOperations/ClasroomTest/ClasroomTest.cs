using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasroomTest
{
    class ClasroomTest
    {
        static void Main(string[] args)
        {
            float height;
            while (!((float.TryParse(Console.ReadLine(), out height)) && height >= 3 && height <= 100)) ;


            float width;
            while (!((float.TryParse(Console.ReadLine(), out width)) && width >= 3 && width <= 100 && height>=width)) ;  //Height>=Width

            int workingPlaces = 0;
            

            int row = Convert.ToInt32(Math.Floor(height *100/ 120 ));
            int coll = Convert.ToInt32(Math.Floor((width*100 - 100) / 70));

            workingPlaces = row * coll - 3;
            Console.WriteLine(workingPlaces);
            
        }
    }
}
