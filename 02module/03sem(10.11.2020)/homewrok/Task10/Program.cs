using System;

namespace Task10
{
    class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }

        public Circle ()
        {
            Random rnd = new Random();
            X = rnd.Next(1, 16);
            Y = rnd.Next(1, 16);
            R = rnd.Next(1, 16);
        }

        public static bool Intersection (Circle A, Circle B)
        {
            if (Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y)) < A.R + B.R &&
                Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y))+Math.Min(A.R, B.R) >Math.Max(A.R, B.R))
                return true;
            else return false;
        }
        public override string ToString()
        {
            return $"Координаты центра - ({X}, {Y})\t Радиус = {R}";
        }
    }
    class Program
    {
        public static int CorrectCheck(string a)
        {
            int x;
            bool err = false;
            do
            {
                if (err) Console.WriteLine("Произошла ошибка! Повторите ввод...");
                Console.Write(a);
                err = true;
            } while (!int.TryParse(Console.ReadLine(), out x) || x < 0);
            return x;
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                int n = CorrectCheck("Введите количество обьектов: ");
                Circle[] circles = new Circle[n];
                Circle oneCircle = new Circle();
                for (int i = 0; i < circles.Length; i++)
                {
                    circles[i] = new Circle();
                }

                Console.WriteLine("\nИнформация обо всех кругах:");
                Array.ForEach(circles, x => Console.WriteLine(x.ToString()));
                Console.WriteLine("Уникальный круг:" + oneCircle.ToString());

                Console.WriteLine("\nИнформация обо всех кругах, которые пересекаются с уникальным:");
                Array.ForEach(Array.FindAll(circles, x => Circle.Intersection(x, oneCircle) == true), y => Console.WriteLine(y.ToString()));

                Console.WriteLine("Нажмите Escape, если хоитте выйти\nИли любую другую клавишу, если хотите продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
