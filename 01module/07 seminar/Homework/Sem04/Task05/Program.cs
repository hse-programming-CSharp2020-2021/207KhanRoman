using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = CorrecDate();
            int[,] a = ArrayGen(n);

            Output1(a);
            Output2(a);
            Output3(a);

        }
        // Вывод массива на экран (картинка 1).
        public static void Output1(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i > j && i < a.GetLength(1) - j - 1)
                    {
                        Console.Write($"{a[i, j]}\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
        // Вывод массива на экран (картинка 2).
        public static void Output2(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i > j && i > a.GetLength(1) - j - 1)
                    {
                        Console.Write($"{a[i, j]}\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
        // Вывод массива на экран (картинка 3).
        public static void Output3(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i < j && j< a.GetLength(1)/2 || i > j && j > a.GetLength(1) / 2)
                    {
                        Console.Write($"{a[i, j]}\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
        // Генерируем массив.
        public static int[,] ArrayGen(int n)
        {
            int[,] a = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(0, 26);
                }
            }
            return a;
        }
        // Проверка корректности введенных данных.
        private static int CorrecDate()
        {
            int x;
            bool ErrorCheck = false;
            do
            {
                if (ErrorCheck)
                {
                    Console.WriteLine("Error");
                }
                Console.Write("Введите размерность массива: ");
            } while (!int.TryParse(Console.ReadLine(), out x) || x < 1);
            return x;
        }
    }
}
