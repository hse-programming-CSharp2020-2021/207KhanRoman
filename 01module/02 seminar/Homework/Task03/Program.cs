using System;
/*
    1.1 Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 12.09.2020
    Задача: Получить коэфициенты. Посчитать корни квадратного уравнения(если они есть).
*/
namespace Homework_2
{
    class Program
    {
        public static void Metod1(double a, double b, double c)
        // 2.2 Обработка. Сначала рассматриваем случай, когда все коэфициенты не нулевые, а затем те, где хотя бы один из коэфициентов равен нулю
        {
            double x1, x2; // корни урав.
            double D = b * b - 4 * a * c; // Считаем D
            if (a * b!= 0)
            {
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
            else
            {
                if (a==0)
                {
                    Console.WriteLine(b!=0 ? $"корень 1: {-c/b}" : "error");
                }
                else if (b == 0)
                {
                    x1 = Math.Sqrt(-c / a);
                    x2 = Math.Sqrt(-c / a);
                    Console.WriteLine(-c>0 && a!=0 ? $"корень 1: {x1}\nкорень 2: {x2}" : c==0 && a!=0 ? $"корень 1: 0" : "error");
                }
                else Console.WriteLine("error");
            }
        }
        // Метод запрашивает коэффициент у пользователя.
        public static double Metod2(string k)
        {
            double x;
            do
            {
                Console.Write($"Введите коэффициент {k}: ");
            } while (!double.TryParse(Console.ReadLine(), out x));
            return x;
        }
        static void Main(string[] args)
        {
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