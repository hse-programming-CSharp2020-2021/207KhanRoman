using System;
/*
    1.1 Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 12.09.2020
    Задача: Получить 3 числа и проверить - выполняеться ли для них неравенство треугольника.
*/

namespace Homework_2
{
    class Program
    {
        public static bool Metod1(double a, double b, double c)
        {
            /* 2.2 обработка 
               Суть алгоритма: 
               получаем 3 числа,
               если сумма 2-х любых из них больше 3-го, то истина, иначе - ложь 
             */
            bool T = (a + b > c) ? true : (a + c > b) ? true : (b + c > a) ? true : false;
            return T;
        }
        // Предназначен для сокращения кода (вводим числа a,b,c, которые могу быть длинами сторон треугольника).
        public static double Metod2() 
        {
            double x;
            do
            {
                Console.Write("Введите вещественное число: ");
            } while (!double.TryParse(Console.ReadLine(), out x) || x<=0);
            return x;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            // 2.1 Ввод.
            do
            {
                double a, b, c;
                a = Program.Metod2();
                b = Program.Metod2();
                c = Program.Metod2();
                // 2.3 Вывод.
                Console.WriteLine(Program.Metod1(a, b, c) ? "да" : "нет");


                // 2.4 Эпилог.
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
