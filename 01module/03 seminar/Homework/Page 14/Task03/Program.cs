using System;
/*
    1 Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 12.09.2020
    Задача:Вычислить функцию, данную в условии.
*/
namespace Homework_2
{
    class Program
    {
        // 2.2 Обработка. Наша функция.
        public static double G(double x)
        {
            double g;
            if (x<=0.5) g = 1;
            else g = Math.Sin(Math.PI * (x - 1) / 2);
            return g;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            // 2.1 Ввод.
            do
            {
                double x;
                do {
                    Console.WriteLine("Введите x: ");
                } while (!double.TryParse(Console.ReadLine(), out x));

                // 2.3 Вывод.
                Console.WriteLine(Program.G(x).ToString("f3"));

                // 2.4 Эпилог.
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
