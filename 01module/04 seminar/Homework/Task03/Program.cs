using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
/*
    Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 28.09.2020
*/
namespace Task03
{
    class Program
    {
        // Метод считает значение функции в точке x.
        // Здесь просто формальное переписывание системы урванений, которые были на слайде.
        private static double Fuction(double a, double b, double c, double x)
        {
            double y;
            if (x < 1.2)
            {
                y = a * x * x + b * x + c;
            }
            else if (x == 1.2)
            {
                y = a / x + Math.Sqrt(x * x + 1);
            }
            else
            {
                y = (a + b * x) / Math.Sqrt(x * x + 1);
            }
            return y;
        }
        // Метод проверяет корректность введенных данных.
        private static double CorrectCheck(string a)
        {
            double x;
            do
            {
                Console.WriteLine($"Введите коэффициент {a}");
            } while (!double.TryParse(Console.ReadLine(), out x));
            return x;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            do
            {
                double a = Program.CorrectCheck("a");
                double b = Program.CorrectCheck("b");
                double c = Program.CorrectCheck("c");

                // Этот цикл выполняет табцляцию. (каждый раз мы x+0.05 и вызываем метод)
                for (double x = 1; x <= 2; x += 0.05)
                {
                    Console.WriteLine("y = " + Program.Fuction(a, b, c, x));
                }

                Console.WriteLine("Нажмите Enter, чтобы выйти\nЛюбую другую клавишу - начать заново.");
                Key = Console.ReadKey();
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
