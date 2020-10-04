using System;
using System.Security.Cryptography.X509Certificates;

namespace Sem03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = CorrecDate();
            int[] a = ArrayGen(n);

            Output(a);
            NewArrayMade(a);
            Output(a);
        }
        // Метод, выполняющий задание.
        public static void NewArrayMade(int[] a)
        {
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    (a[(i + 1) / 2], a[a.Length - (i+1) / 2]) = (a[a.Length - (i + 1) / 2], a[(i + 1) / 2]);
                    if ((i + ((i + 1) / 2)) < a.Length+1)
                    {
                        Array.Sort(a, (i + 1) / 2, a.Length - (i + 1) );
                    }
                    else break;
                }
            }
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
                a[i] = rnd.Next(-10, 11);
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
