using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ7
{
    public struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void PrintCoordinates()
        {
            Console.WriteLine($"({X}, {Y})");
        }

        public double DistanceTo(Point other)
        {
            return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
        }
    }

    class Program
    {
        static void Main()
        {
            Point point1 = new Point(3, 4);
            Point point2 = new Point(7, 1);

            Console.WriteLine("Координаты точки 1:");
            point1.PrintCoordinates();

            Console.WriteLine("Координаты точки 2:");
            point2.PrintCoordinates();

            double distance = point1.DistanceTo(point2);
            Console.WriteLine($"Расстояние между точками: {distance:F2}");
            Console.ReadKey ();
        }
    }
}
