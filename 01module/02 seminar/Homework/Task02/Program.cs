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
        const int N = 3;
        public static string Metod1(int p)
        {
            /* 2.2 обработка 
                Суть алгоритма: на вход поступает число p,
                затем в массив 'a' записывються колличество каждой цифры в числе p(0,1,2..9),(*)
                после чего строиться строка, в которой сначала идут все 9 из числа p, потом 8, 7 ... 0 (**)
            */
            int[] a = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            // (*)
            while (p > 0)
            {
                a[p % 10]++;
                p /= 10;
            }
            //(**)
            string max = "";
            for (int i = 9; i > -1; i--)
                for (int j = 0; j < a[i]; j++)
                    max += (a[i] != 0) ? Convert.ToString(i) : null;

            return max;

        }
        static void Main(string[] args)
        {
            // 1.2
            ConsoleKeyInfo Key;
            do
            {
                int p;
                // 2.1 Ввод
                do
                {
                    Console.Write($"Введите натуральное {N}-значное число: ");
                } while (!(int.TryParse(Console.ReadLine(), out p) && p < Math.Pow(10, N) && p > Math.Pow(10, N - 1)));
                // 2.3 Вывод
                Console.WriteLine(Program.Metod1(p));


                // 2.4 Эпилог
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
