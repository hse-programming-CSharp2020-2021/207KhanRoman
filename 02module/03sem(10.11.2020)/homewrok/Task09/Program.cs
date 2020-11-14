using System;

namespace Task09
{
    class LinearEquation
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public LinearEquation ()
        {
            Random rnd = new Random();
            A = rnd.Next(-10, 11);
            B = rnd.Next(-10, 11);
            C = rnd.Next(-10, 11);
        }

        public double Decision ()
        {
            if (A != 0)
            {
                return (C - B) / A;
            }
            return 0;
        }
        public override string ToString()
        {
            return $"Коэффициент A - {A}\tКоэффициент B - {B}\tКоэффициент C - {C}";
        }
    } 
    class Program
    {
        public static int CorrectCheck (string a)
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
                int n = CorrectCheck("Введите количество обьектов: ");
                LinearEquation[] equations = new LinearEquation[n];
                for (int i =0; i<equations.Length; i++)
                {
                    equations[i] = new LinearEquation();
                }

                Console.WriteLine("\nСозданный массив:");
                Array.ForEach(equations, x => Console.WriteLine(x.ToString()));

                Array.Sort(equations, (x,y) => {
                    if (x.Decision() > y.Decision()) return 1;
                    else if (x.Decision() < y.Decision()) return -1;
                    else return 0;
                });

                Console.WriteLine("\nОтсортированный массив:");
                Array.ForEach(equations, x => Console.WriteLine(x.ToString() + $"\tРешение: {x.Decision()}"));

                Console.WriteLine("Нажмите Escape, если хоитте выйти\nИли любую другую клавишу, если хотите продолжить");
            } while (Console.ReadKey().Key!=ConsoleKey.Escape);

        }
    }
}
