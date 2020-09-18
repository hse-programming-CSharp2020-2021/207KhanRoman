using System;
using System.Security.Cryptography.X509Certificates;
/*
1.1 Шапка

Дисциплина: "Программирование"
Группа: 207ПИ/2
Студент: Хан Роман
Дата: 12.09.2020
Задача: Написать 2 метода - 1-ый возращает корень из числа и его квадрат, а 2-ой дробную часть и целую.
        Получить число и (по возвожности) вывести для него корень, квадрат, дробную и целые части.
*/
namespace Homework_2
{
    class Program
    {
        // 2.2 Обработка. 1 метод
        public static (double, double) Metod1(double a)
        {
            if (a >= 0)
            {
                return (a < 0 ? -1 : Math.Sqrt(a), a * a);
            }
            else
            {
                return (-1, a*a);
            }
        }
        // 2.2 Обработка. 2 метод
        public static (double, double) Metod2(double a)
        {
            return ((int)a, a-(int)a);
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            // 2.1 Ввод.
            do
            {
                double x;
                do
                {
                    Console.Write("Введие вещесвтенное число");
                } while (!double.TryParse(Console.ReadLine(), out x));

                // Вывод.
                Console.WriteLine(Program.Metod2(x));
                Console.WriteLine(Program.Metod1(x));

                // 2.4 Эпилог.
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
