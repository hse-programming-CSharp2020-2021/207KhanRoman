using System;
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
        // Генерируем массив с степенями двойки.
        private static long[] ArrayGen(int n, long a, long d)
        {
            long[] NewArray = new long[n];
            for (int i = 0; i < n; i++)
            {
                NewArray[i] = (long)(a+d*i);
            }
            return NewArray;
        }
        // Метод просто проверяет введенное число (размерность массива).
        public static int DigitCheck1()
        {
            int n;
            do
            {
                Console.Write("Введите размерность массива(n)\nПомните, что n>1 долно быть натуральным числом!\nn = ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 2);
            return n;
        }
        // Метод проверки корректности ввод а и d.
        public static int DigitCheck2(string x)
        {
            int Digit;
            do
            {
                Console.Write($"Введие {x}: ");
            } while (!int.TryParse(Console.ReadLine(), out Digit));
            return Digit;
        }
        // Метод вывода массива.
        public static void PrintArray(long[] Array)
        {
            Console.WriteLine("Все члены арифметической прогрессии");
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
                int n = Program.DigitCheck1();
                long a = Program.DigitCheck2("A");
                long d = Program.DigitCheck2("D");

                long[] Array = Program.ArrayGen(n, a, d);
                Program.PrintArray(Array);

                Console.WriteLine("Введие Enter, чтобы продожить\nЛюбую другую клавишу - начать заново");
                Key = Console.ReadKey();
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
