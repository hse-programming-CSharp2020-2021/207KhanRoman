using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = CorrecDate();
            int[] a = ArrayGen(n);

            Console.WriteLine($"Индекс наименьшего элимента - {MinMax(a).M1}");
            Console.WriteLine($"Сумма индексов Min и Max - {MinMax(a).M2}");

            // Решил вывести еще и массив, чтобы пользователь мог свериться.
            Output(a);
        }
        // Метод min/max массива. (суть программы).
        public static (int M1,int M2) MinMax(int[] a)
        {
            int Imin = 0;
            int Imax = 0;
            int min = 101;
            int max = -101;
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                    Imin = i;
                }
                if (max < a[i])
                {
                    max = a[i];
                    Imax = i;
                }
            }
            return (Imin, Imax+Imin);
        }
        // Вывод массива.
        public static void Output(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }

        // Генерируем массив.
        public static int[] ArrayGen(int n)
        {
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(-100, 101);
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
