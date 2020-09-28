using System;
/*
    Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 28.09.2020
*/

// Код для этой задачи я полностью скопировал из Task01, но поменял методы ArrayGen и DigitCheck.
namespace Task02
{
    class Program
    {
        // Генерируем массив с нечентыми цифрами.
        private static int[] ArrayGen(int n)
        {
            int[] NewArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                NewArray[i] = 2*(i+1)-1;
            }
            return NewArray;
        }
        // Метод просто проверяет введенное число (размерность массива).
        public static int DigitCheck()
        {
            int n;
            do
            {
                Console.Write("Введите размерность массива(n)\nПомните, что n долно быть натуральным числом\nn = ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1);
            return n;
        }
        // Метод вывода массива.
        public static void PrintArray(int[] Array)
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
                int[] Array = Program.ArrayGen(n);
                Program.PrintArray(Array);

                Console.WriteLine("Введие Enter, чтобы продожить\nЛюбую другую клавишу - начать заново");
                Key = Console.ReadKey();
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}