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
            // Обработка
        {
            double x1, x2; // корни урва.
            double D = b * b - 4 * a * c; // Считаем D
            if (D > 0) //2 корня
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"корень 1: {x1}\nкорень 2: {x2}");
            }
            else if (D == 0) // 1 корень
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"корень 1: {x1}");
            }
            else Console.WriteLine("Корней нет"); // 0 корней
        }
        public static double Metod2(string k) //метод запрашивает коэффициент у пользователя
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
                //2.3 Вывод
                Program.Metod1(a, b, c);


                // 2.4 Эпилог
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}