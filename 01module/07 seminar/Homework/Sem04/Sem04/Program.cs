using System;

namespace Sem04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = CorrecDate();
            int[,] a = ArrayGen(n);

            Output(a);
        }
        // Выводим массив на экран.
        public static void Output(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Генерируем массив. Заполняем числа змейкой.
        public static int[,] ArrayGen(int n)
        {
            int[,] a = new int[n, n];
            int p = 1;
            int inv = 1;
            for (int k = 0; k < n / 2; k++)
            {
                for (int j = k; j < n - k - 1; j++)
                {
                    a[k, j] = p;
                    p++;
                }
                for (int i = k; i < n - k-1; i++)
                {
                    a[i, n - k - 1] = p;
                    p++;
                }
                for (int j = k; j < n -k-1; j++)
                {
                    a[n - k - 1, n - j - 1] = p;
                    p++;
                }
                for (int i = k; i < n - k - 1; i++)
                {
                    a[n - i - 1, k] = p;
                    p++;
                }
                if (n % 2 == 1) a[n/2, n / 2] = p;
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
