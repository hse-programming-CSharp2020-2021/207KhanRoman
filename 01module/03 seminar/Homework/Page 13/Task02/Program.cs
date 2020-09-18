using System;
/*
1.1 Шапка

Дисциплина: "Программирование"
Группа: 207ПИ/2
Студент: Хан Роман
Дата: 12.09.2020
Задача: Поменять все цифры в 4-х значном чилсе так, чтобы они шли в обратном порядке.
*/
namespace Homework_3
{
    class Program
    {
        // 2.2 Обработка.
        public static int Metod1(int x)
        {
            int x2 = 0;
            while (x>0) {
                x2 = x2 * 10 + x % 10;
                x /= 10;
            }
            return x2;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            // 2.1 Ввод.
            do
            {
                int x;
                do {
                    Console.WriteLine("Введите число:");
                } while (!int.TryParse(Console.ReadLine(), out x));

                // Вывод.
                Console.WriteLine(Program.Metod1(x));
                
                // 2.4 Эпилог.
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
