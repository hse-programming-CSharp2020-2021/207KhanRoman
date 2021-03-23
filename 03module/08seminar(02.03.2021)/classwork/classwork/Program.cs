using System;

namespace classwork
{
    interface IFigure
    {
        double Square { get; }
    }
    abstract class Figure
    {
    }
    class Square : Figure, IFigure
    {
        double side;
        double IFigure.Square => side * side;
        public Square(double side)
        {
            this.side = side;
        }
        public override string ToString()
        {
            return $"Rdflhfn";
        }
    }
    class Circle : Figure, IFigure
    {
        double rad;
        double IFigure.Square => rad * rad * Math.PI;
        public Circle(double rad)
        {
            this.rad = rad;
        }
        public override string ToString()
        {
            return $"Круг";
        }
    }
    class Program
    {
        public static void Print<T>(T[] array, int limit) where T : IFigure
        {
            foreach (IFigure fig in array)
            {
                if (fig.Square > limit)
                    Console.WriteLine($"{fig} с площадью - {fig.Square}");
            }
        }
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Figure[] figurs = new Figure[n];

            for (int i = 0; i < n; i++)
            {
                if (rnd.Next(0, 2) == 1)
                    figurs[i] = new Square(rnd.Next(100) + rnd.NextDouble());
                else
                    figurs[i] = new Circle(rnd.Next(100) + rnd.NextDouble());
            }

            Print<IFigure>(Array.ConvertAll(figurs, x => (IFigure)x), 1000);
        }
    }
}
