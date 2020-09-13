using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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

        public static int Metod1(int a, int b, int c)
        {
            int g = Math.Min(Math.Min(a / 100, b / 100), c/100);
            return g;
        }
        public static int P(int p)
        {
            double x;
            do
            {
                Console.Write("Введите № аудитории {0}: ", p);
            } while (!double.TryParse(Console.ReadLine(), out x) || x <= 100 || x>999 || x-(int)x!=0);

            return (int)x;
        }
        static void Main(string[] args)
        {
            // 1.2
            ConsoleKeyInfo Key;
            // 2.1 Ввод
            do
            {
                int a = Program.P(1);
                int b = Program.P(2);
                int c = Program.P(3);

                int g = Program.Metod1(a, b, c);

                if (g == a) Console.WriteLine($"Минимальный номер внутри этажа у 1 - {a}");
                else if (g == b) Console.WriteLine($"Минимальный номер внутри этажа у 2 - {b}");
                else Console.WriteLine($"Минимальный номер внутри этажа у 3 - {c}");

                Console.WriteLine();
                // 2.4 Эпилог
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}