using System;
using System.Linq;

namespace CirclesAndPoints
{
    class CirclesAndPoints
    {
        public static bool IsCircleIntersect(Circle c1, Circle c2)
        {
            bool isIntersected = false;
            double c1X = c1.center.XCoordinate;
            double c1Y = c1.center.YCoordinate;
            double c2X = c2.center.XCoordinate;
            double c2Y = c2.center.YCoordinate;
            double c1Radius = c1.Radius;
            double c2Radius = c2.Radius;

            double distance = Math.Sqrt((c2X-c1X)* (c2X - c1X) + (c2Y - c1Y) * (c2Y - c1Y));

            if (distance<=(c1Radius+c2Radius))
            {
                isIntersected = true;
            }


            return isIntersected;
        }
        static void Main()
        {
            double[] circ1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] circ2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var circleOne = new Circle(circ1[0], circ1[1], circ1[2]);
            var circleTwo = new Circle(circ2[0], circ2[1], circ2[2]);

            if (IsCircleIntersect(circleOne,circleTwo))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

    public class Point
    {
        private double xCoodinate;
        private double yCoodinate;

        internal double XCoordinate
        {
            get
            {
                return this.xCoodinate;
            }
            set
            {
                this.xCoodinate = value;
            }
        }
        internal double YCoordinate
        {
            get
            {
                return this.yCoodinate;
            }
            set
            {
                this.yCoodinate = value;
            }
        }

        public Point(double x, double y)
        {
            this.XCoordinate = x;
            this.YCoordinate = y;
        }
    }
    public class Circle
    {
        internal Point center;
        private double radius;

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;
            }
        }
        public Circle(double x, double y, double rad)
        {
            this.center = new Point(x, y);
            this.radius = rad;
        }
    }
}
