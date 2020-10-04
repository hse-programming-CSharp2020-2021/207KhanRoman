using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = CorrecDate();
            double[,] a = ArrayGen(n);

            Console.WriteLine("Сгенерированная матрица: ");
            Output(a);

            if (n == 2)
            {
                Console.WriteLine($"Детерминант матрицы 2*2 = {Det2X2(a)}");
            }
            else if (n == 3)
            {
                Console.WriteLine($"Детерминант матрицы 2*2 = {Det3X3(a)}");
            }
            else
            {
                Console.WriteLine($"Увы, но детерминант матрицы размера {n}*{n} программа считать не умеет");
            }
        }
        // Определитель матрицы 2*2.
        public static double Det2X2(double[,] a)
        {
            return a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];
        }
        // Определитель матрицы 3*3.
        public static double Det3X3(double[,] a)
        {
            return a[0, 0] * a[1, 1] * a[2, 2] + a[1, 0] * a[2, 1] * a[0, 2] + a[0, 1] * a[1, 2] * a[2, 0] - a[0, 2] * a[1, 1] * a[2, 0] - a[0, 1] * a[1, 0] * a[2, 2] - a[1, 2] * a[2, 1] * a[0, 0];
        }
        // Вывод матрицы на экран.
        public static void Output(double[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]:f3} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Генерируем массив.
        public static double[,] ArrayGen(int n)
        {
            double[,] a = new double[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
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
