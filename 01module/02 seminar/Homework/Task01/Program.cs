using System;
/*
    1.1 Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 12.09.2020
    Задача: Вывести значение полинома - 12x^4+9x^3-3x^2+2x-4
*/
namespace Homework_2
{
    class Program
    {
        // 2.2 Обработка
        public static double Metod(double x)
        {
            double f = x*(x*(x*(12*x+9)-3)+2) - 4;
            return f;
        }
        static void Main(string[] args)
        {
            // Для рекурсивности программы(увидел в презентации).
            ConsoleKeyInfo Key; 
            // 2.1 Ввод.
            do
            {
                double x;
                do {
                    Console.Write("Введите Ваше X: ");
                } while (!double.TryParse(Console.ReadLine(), out x));
                // 2.3 Вывод
                Console.WriteLine($"Значение полинома: {Program.Metod(x)}");
                // 2.4 Эпилог
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}

