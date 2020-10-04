using System;
using System.Runtime.Serialization;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = CorrecDate();
            long[] a = ArrayCreate(n);
            Output(a);

        }

        // Вывод массива.
        public static void Output(long[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]} ");
            }
            Console.WriteLine();
        }

        // Создаем массив. (суть задания)
        public static long[] ArrayCreate(int n)
        {
            long[] a = new long[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Sum(i);
            }
            return a;
        }
        // Считаем n-ую сумму. 
        public static long Sum(int n)
        {
            long sum;
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return sum = 34 * Sum(n - 1) - Sum(n - 2) + 2;
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
