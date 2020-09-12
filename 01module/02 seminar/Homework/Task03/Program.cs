using System;
/*
    1.1 Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 12.09.2020
    Задача:
*/
namespace Homework_2
{
    class Program
    {
        public static void Metod1(double a, double b, double c)
        {
            double x1, x2;
            double D = b * b - 4 * a * c;
            if (D>0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine();
            }
        }
        public static double Metod2(string k)
        {
            double x;
            do {
                Console.Write($"Введите коэффициент {k}: ");
            } while (!double.TryParse(Console.ReadLine(), out x));
            return x;
        }
        static void Main(string[] args)
        {
            // 1.2
            ConsoleKeyInfo Key;
            // 2.1 Ввод
            do
            {
                double a = Program.Metod2("a");
                double b = Program.Metod2("b");
                double c = Program.Metod2("c");


                // 2.4 Эпилог
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}