using System;
/*
    Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 28.09.2020
*/
namespace Task01
{
    class Program
    {
        // Генерируем массив с степенями двойки.
        private static ulong[] ArrayGen(int n)
        {
            ulong[] NewArray = new ulong[n];
            for (int i = 0; i < n; i++)
            {
                NewArray[i] = (ulong)Math.Pow(2, i);
            }
            return NewArray;
        }
        // Метод просто проверяет введенное число (размерность массива).
        public static int DigitCheck()
        {
            int n;
            do
            {
                Console.Write("Введите размерность массива(n)\nПомните, что n долно быть натуральным числом и оно не может быть больше 64!\nn = ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 64);
            return n;
        }
        // Метод вывода массива.
        public static void PrintArray(ulong[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine($"{i + 1}-ый эллемент массива = {Array[i]}");
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            do
            {
                int n = Program.DigitCheck();
                ulong[] Array = Program.ArrayGen(n);
                Program.PrintArray(Array);

                Console.WriteLine("Введие Enter, чтобы продожить\nЛюбую другую клавишу - начать заново");
                Key = Console.ReadKey();
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
