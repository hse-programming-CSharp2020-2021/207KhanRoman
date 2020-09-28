using System;
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
        // Генерируем массив с цифрами фибоначи.
        private static ulong[] ArrayGen(int n)
        {
            ulong[] NewArray = new ulong[n];
            NewArray[0] = 1;
            NewArray[1] = 1;
            for (int i = 2; i < n; i++)
            {
                NewArray[i] = NewArray[i-2]+ NewArray[i - 1];
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
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 2);
            return n;
        }
        // Метод вывода массива.
        public static void PrintArray(ulong[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine($"{Array.Length-i}-ый эллемент массива = {Array[Array.Length-i-1]}");
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
