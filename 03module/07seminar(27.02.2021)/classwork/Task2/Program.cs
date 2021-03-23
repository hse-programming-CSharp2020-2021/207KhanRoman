using System;
using System.Diagnostics.CodeAnalysis;

namespace Task2
{
    struct PointS
    {
        double x;
        double y;
        public PointS(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(PointS other)
        {
            return Math.Sqrt(Math.Pow(x - other.x, 2)+ Math.Pow(y - other.y, 2));
        }
    }
    struct CircleS : IComparable<CircleS>
    {
        PointS center;
        double rad;
        public double Rad => rad;
        public PointS Center => center;
        public CircleS(double x, double y, double r)
        {
            center = new PointS(x, y);
            rad = r;
        }
        public double Lenght => 2 * Math.PI * rad;
        public override string ToString()
        {
            return $"Круг с центром в {center} и радиусом {Rad}";
        }

        public int CompareTo([AllowNull] CircleS other)
        {
            if (rad > other.rad) return 1;
            else if (rad < other.rad) return -1;
            else return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CircleS circle1 = new CircleS(1,3,7);
            CircleS circle2 = new CircleS(-1, 6, 5);
            Console.WriteLine(circle2.Lenght);
            Console.WriteLine(circle1.Lenght);
            Console.WriteLine(circle1.CompareTo(circle2));
        }
    }
}
