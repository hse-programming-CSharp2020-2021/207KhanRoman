using System;
using System.Security.Cryptography;
/*
    Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 28.09.2020
*/
namespace Page8_Task07
{
    class Program
    {
        // Метод вычисляет НОД и НОК 2-х чисел.
        public static void NodNok(int a, int b, out int NOD, out int NOK)
        {
            // Ничего умнее, как запомнить 2 переменных для их дальнейшего использования, я не придумал.
            int a1 = a, b1=b;
            // Находим НОД.
            while (a != b)
            {
                if (a > b)
                {
                    (a, b) = (b, a);
                }
                b -= a;
            }
            NOD = a;
            // Находим НОК.
            NOK = b1 * a1 / NOD;
        }
        // Метод просто проверяет корректность введнных данных.
        private static int CorrectCheck(string a)
        {
            int x;
            do
            {
                Console.WriteLine($"Введите неотрицательное {a}");
            } while (!int.TryParse(Console.ReadLine(), out x));
            return x;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            do
            {
                int NOD, NOK;
                int a = Program.CorrectCheck("a");
                int b = Program.CorrectCheck("b");
                Program.NodNok(a, b, out NOD, out NOK);
                Console.WriteLine($"НОД - {NOD}, Нок - {NOK}");

                Console.WriteLine("Нажмите Enter, чтобы выйти\nЛюбую другую клавишу - начать заново.");
                Key = Console.ReadKey();
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
