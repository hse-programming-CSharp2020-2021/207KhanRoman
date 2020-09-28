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
namespace Task04
{
    class Program
    {
        // Проверяем корректность введенных данных.
        private static int CorrectCheck(string a)
        {
            int x;
            do
            {
                Console.WriteLine($"Введите неотрицательное {a}");
            } while (!int.TryParse(Console.ReadLine(), out x) || x<0);
            return x;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo KeyToExit;
            do
            {
                ulong x = 1, y = 1;
                int a = Program.CorrectCheck("a");
                int b = Program.CorrectCheck("b");

                // Делаем проверку на случай переполнения(ulong не может вместить больше 64 бит => 2 в 65 и более быть не может).
                if (a < 65 && b < 65 && a + b != 64)
                {
                    Console.WriteLine("сумма равна: " + ((x << a) + (y << b)));
                }
                else {
                    Console.WriteLine("error");
                }

                Console.WriteLine("Нажмине Enter, если хотите выйти\nЛюбую другую клавишу - чтобы продожить");
                KeyToExit = Console.ReadKey();
            } while (KeyToExit.Key!=ConsoleKey.Enter);
        }
    }
}
