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
        //2.2 обработка
        public static void Metod1(int x)
        {
            while (x > 0)
            {
                Console.WriteLine(x % 10);
                x /= 10;
            }
        }
        static void Main(string[] args)
        {
            // 1.2
            ConsoleKeyInfo Key;
            do
            {
                int x; // вводимое число
                // 2.1 Ввод
                do
                {
                    Console.Write("Введие натуральное четырехзначное число: ");
                } while (!int.TryParse(Console.ReadLine(), out x) && x < 10000 && x > 999);
                // 2.3 Вывод
                Program.Metod1(x);

                // 2.4 Эпилог
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
