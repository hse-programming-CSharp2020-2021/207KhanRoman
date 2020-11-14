using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Classwork
{
    class Point
    {
        public double A { get; set; }
        public double B { get; set; }
        public Point(double x, double y)
        {
            A = x;
            B = y;
        }
        public Point()
        {
            Random rnd = new Random();
            A = rnd.Next(-10, 11);
            B = rnd.Next(-10, 11);
        }
        public double Length(Point b)
        {
            return Math.Sqrt((A - b.A) * (A - b.A) + (B - b.B) * (B - b.B));
        }
    }
    class Triangle
    {
        string name;
        static int count = 0;
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public double Perimetr
        {
            get
            {
                return A.Length(B) + B.Length(C) + C.Length(A);
            }
        }
        public double S
        {
            get
            {
                double p = (A.Length(B) + B.Length(C) + C.Length(A)) / 2;
                return Math.Sqrt(p*(p-A.Length(B))*(p-B.Length(C))*(p-C.Length(A)));
            }
        }
        public Triangle(Point a, Point b, Point c)
        {
            if (A.Length(B) + B.Length(C) > C.Length(A) || A.Length(B) + C.Length(A) > B.Length(C) ||  B.Length(C)+ C.Length(A)> A.Length(B)) {
                A = a;
                B = b;
                C = c;
                count++;
                name = "A" + count;
            }
            else
            {
                throw new Exception("Плохо :(");
            }
        }
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Point a = new Point(x1,y1);
            Point b = new Point(x2, y2);
            Point c = new Point(x3, y3);
            if (a.Length(b) + b.Length(c) > c.Length(a) || a.Length(b) + c.Length(a) > b.Length(c) || b.Length(c) + c.Length(a) > a.Length(b))
            {
                A = a;
                B = b;
                C = c;
                count++;
                name = "A" + count;
            }
            else
            {
                throw new Exception("Плохо :(");
            }
        }
        public override string ToString()
        {
            return $"Треугольник: {name:f2}    Периметр: {Perimetr:f2}    Площядь: {S:f2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Triangle[] tr = new Triangle[rnd.Next(5,16)];
            for (int i = 0; i<tr.Length; i++)
            {
                tr[i] = new Triangle(rnd.Next(-10,11), rnd.Next(-10, 11), rnd.Next(-10, 11), rnd.Next(-10, 11), rnd.Next(-10, 11), rnd.Next(-10, 11));
            }
            foreach (Triangle x in tr)
            {
                Console.WriteLine(x.ToString());
            }
            Array.Sort(tr, (x,y) => {
                if (x.S > y.S) return 1;
                if (x.S < y.S) return -1;
                else return 0;
            });
            Console.WriteLine();
            foreach (Triangle x in tr)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
}
