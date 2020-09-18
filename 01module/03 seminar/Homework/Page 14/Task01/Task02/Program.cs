using System;
/*
    1.1 Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 12.09.2020
    Задача: Вычислить значение выражения
*/
namespace Homework_2
{
    class Program
    {
        // 2.2 Обработка
        public static double G(double x, double y)
        {
            double g;
            if (x < y && x > 0) g = x + Math.Sin(y);
            else if (x > y && x < 0) g = y - Math.Cos(x);
            else g = x * y / 2;
            return g;
        }
        // метод для корректного ввода значения
        public static double P(string p) {
            double x;
            do
            {
                Console.Write("Введите {0}: ", p);
            } while (!double.TryParse(Console.ReadLine(), out x));
            return x;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            // 2.1 Ввод
            do
            {
                double x = Program.P("x");
                double y = Program.P("y");

                // 2.3 Вывод.
                Console.WriteLine($"Значение функции G: {Program.G(x, y)}");
                // 2.4 Эпилог.
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}