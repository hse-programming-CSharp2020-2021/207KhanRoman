using System;
/*
1.1 Шапка

Дисциплина: "Программирование"
Группа: 207ПИ/2
Студент: Хан Роман
Дата: 12.09.2020
Задача:
*/
namespace Homework_3
{
    class Program
    {
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
            // 1.2
            ConsoleKeyInfo Key;
            // 2.1 Ввод
            do
            {
                int x;
                do {
                    Console.WriteLine("Введите число:");
                } while (!int.TryParse(Console.ReadLine(), out x));
                Console.WriteLine(Program.Metod1(x));
                
                // 2.4 Эпилог
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
