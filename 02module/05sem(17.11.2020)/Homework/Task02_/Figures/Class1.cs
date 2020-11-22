using System;

namespace MyLibForTask02
{
    public class Point
    {
        double x, y;
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public virtual double Area
        {
            get
            {
                return 0;
            }
        }
        public virtual double Len { get; }
        public virtual void Display()
        {
            Console.WriteLine($"Просто точка ({X}, {Y})");
        }
    }
    public class Circle : Point
    {
        double rad;
        public double Rad
        {
            get
            {
                return rad;
            }
            set
            {
                rad = value;
            }
        }
        public Circle(double x, double y, double rad)
        {
            Rad = rad;
            X = x;
            Y = y;
        }
        public override void Display()
        {
            Console.WriteLine($"Окружность с центром в точке ({X},{Y});\tРадиус - {Rad};\nПлощядь - {this.Area}");
        }
        public override double Area => Math.PI * Rad * Rad;
        public override double Len => 2 * Math.PI* Rad;
    }
    public class Square : Point
    {
        double side;
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }
        public Square(double x, double y, double side)
        {
            Side = side;
            X = x;
            Y = y;
        }
        public override double Len => side * 4;
        public override void Display()
        {
            Console.WriteLine($"Квадрат с центром в точке ({X},{Y});\tСторона = {Side};\tПлощадь - {this.Area}");
        }
        public override double Area => side * side;
    }
}

