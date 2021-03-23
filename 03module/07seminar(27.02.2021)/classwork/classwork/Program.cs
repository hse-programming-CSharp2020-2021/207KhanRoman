using System;

namespace classwork
{
    struct Coords
    {
        double x;
        double y;
        public Coords(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"({x} {y})";
        }
    }
    class Circle
    {
        Coords center;
        double r;
        public Coords Center
        {
            get
            {
                return center;
            }
        }
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Все плохо");
                r = value;
            }
        }
        public Circle(double x, double y, double r)
        {
            center = new Coords(x, y);
            R = r;
        }
        public override string ToString()
        {
            return $"Круг с центром в {center} и радиусом {R}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle circle = new Circle(5, 4, 8);
                Console.WriteLine(circle);
                Circle newCircle = new Circle(5, 1, -1);
                Console.WriteLine(newCircle);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
