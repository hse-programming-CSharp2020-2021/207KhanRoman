using System;
/*
    Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 28.09.2020
*/

// Извините за самодеятельность, но я захотел написать эту программу для 2-хмерного массив(на мой взгляд, это интереснее).

namespace Page17
{
    class Program
    {
        // Массив генерирует 2-хмерный массив с рандомными значениями.
        public static double[,] ArrayGen(int n)
        {
            double[,] NewArray = new double[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    NewArray[i, j] = rnd.Next(-n, n);
                }
            }
            return NewArray;
        }
        // 9.1
        public static double[,] ArrayNotMax(double x, int n, double[,] Array)
        {
            double max = double.NegativeInfinity;
            // Поиск макс. элемента.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Array[i, j] > max)
                    {
                        max = Array[i, j];
                    }
                }
            }

            // Замена макс элемента.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Array[i, j] == max)
                    {
                        Array[i, j] = x;
                    }
                }
            }
            return Array;
        }
        // Метод просто проверяет введенное число (размерность массива).
        public static int DigitCheck1()
        {
            int n;
            do
            {
                Console.Write("Введите размерность массива(n)\nПомните, что n долно быть натуральным числом!\nn = ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1);
            return n;
        }
        // Метод проверяет, что человек ввел именно число.
        public static double DigitCheck2()
        {
            double x;
            do
            {
                Console.Write("Введие число, которым вы хотите заменить максимальный в массиве: ");
            } while (!double.TryParse(Console.ReadLine(), out x));
            return x;
        }
        // Метод выводит массив.
        public static void PrintArray(double[,] Array, int n)
        {
            Console.WriteLine("Массив сейчас выглядит так: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{Array[i, j]} ");
                }
                Console.WriteLine("");
            }
        }
        // 9.2
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            do
            {
                // Вводим размерность массива.
                int n = Program.DigitCheck1();
                // Генерируем массив.
                double[,] Array = Program.ArrayGen(n);
                // Вводим число, на которое хотим заменить max элемент.
                double x = Program.DigitCheck2();
                // Выводим текущий масив.
                Program.PrintArray(Array, n);
                // Заменяем max элемент на x.
                Array = Program.ArrayNotMax(x, n, Array);
                // Выводим измененный массив.
                Console.WriteLine("Изменяем массив...");
                Program.PrintArray(Array, n);

                Console.WriteLine("Введие Enter, чтобы продожить\nЛюбую другую клавишу - начать заново");
                Key = Console.ReadKey();
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
