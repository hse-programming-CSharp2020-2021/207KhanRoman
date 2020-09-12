using System;

namespace Homework_2
{
    class Program
    {
        public static bool Metod1(double a, double b, double c)
        {
            bool T = (a + b > c) ? true : (a + c > b) ? true : (b + c > a) ? true : false;
            return T;
        }
        public static double Metod2()
        {
            double x;
            do
            {
                Console.Write("Введите вещественное число: ");
            } while (!double.TryParse(Console.ReadLine(), out x));
            return x;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            do
            {
                double a, b, c;
                a = Program.Metod2();
                b = Program.Metod2();
                c = Program.Metod2();

                Console.WriteLine(Program.Metod1(a, b, c) ? "да" : "нет");



                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
