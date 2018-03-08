using System;


namespace _30112017Class
{
    class Program
    {
        static void Main(string[] args)
        {                       //Inside, Outside or Border

            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool insideBaseRectangle = (0 < x && x < 3 * h) && (0 < y && y < h);
            bool insideErectedRectangle = (h < x && x < 2 * h) && (0 < y && y < 4 * h);

            bool outsideBaseRectangle = y<0||y>4*h||x<0|x>3*h||(x<h&&y>h)||(x>2*h&&y>h);
            
            bool rectBase = (0 < x && x < 3 * h)&&y==0;
            bool rectSecondBase = ((0 <= x && x <= h)||(2*h <= x && x <= 3*h)) && y == h;
            bool rectThirdBase = (h <= x && x <= 2*h)  && y == 4*h;
            bool firstSide = x == 0 && (0 <= y && y <= h);
            bool secondSide = x == h && (h <= y && y <= 4*h);
            bool forthSide = x == 3*h && (0 <= y && y <= h);
            bool thirddSide = x == 2*h && (h <= y && y <= 4 * h);

            bool border = rectBase || rectSecondBase || rectThirdBase || firstSide || secondSide || thirddSide || forthSide;


            if (insideBaseRectangle|| insideErectedRectangle)
            {
                Console.WriteLine("inside");
            }
            else if (outsideBaseRectangle)
            {
                Console.WriteLine("outside");
            }
            else if (border)
            {
                Console.WriteLine("border");
            }

        }
    }
}
