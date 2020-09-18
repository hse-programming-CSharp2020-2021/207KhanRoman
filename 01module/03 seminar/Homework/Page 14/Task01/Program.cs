using System;
/*
    1.1 Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 12.09.2020
    Задача: Определить: принадлежит ли точка G(X,Y),
    где G - сектор круга с произвольным центром, R=2 и -90<=fi<=45
*/
namespace Homework_2
{
    class Program
    {
        // 2.3 Обработка.
        /* Я учитываю 3 условия для принадлежности точки к данному сектору:
         * 1. Точка лежит в нутри круга с радиусом R
         * 2. X координата больше, чем координата X0
         * 3. Синус должен быть меньше корня из двух
        */
        public const int R = 2;
        public static bool Metod1(double x0, double y0, double x, double y)
        {
            if ((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y) <= R * R && x - x0 >= 0 && y / Math.Sqrt(x * x + y * y) < Math.Sqrt(2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // метод для корректного ввода значения
        public static double Metod2(string u) 
        {
            double x;
            do
            {
                Console.Write("Координаты {0}: ", u);
            } while (!double.TryParse(Console.ReadLine(), out x));
            return x;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            // 2.1 Ввод
            do
            {
                Console.WriteLine("Введите координаты цетра круга");
                double x0 = Program.Metod2("x0");
                double y0 = Program.Metod2("y0");
                Console.WriteLine("Введите координаты точки");
                double x = Program.Metod2("x");
                double y = Program.Metod2("y");

                // 2.2 Вывод
                Console.WriteLine(Program.Metod1(x0, y0, x, y));

                // 2.4 Эпилог
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
