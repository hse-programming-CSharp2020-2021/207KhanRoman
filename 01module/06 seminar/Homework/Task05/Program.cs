using System;
using System.Runtime.CompilerServices;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявляем массив.
            int[] a = new int[CorrectCheck()];

            // Заполняем массив.
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-10, 11);
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            int k=0;
            ArrayWork(a, ref k);
            Console.WriteLine();
            for (int i = 0; i < a.Length-k; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }

        private static void ArrayWork(int[] a, ref int k)
        {
            for (int i = 0; i < a.Length-k; i++)
            {
                if ((a[i] + a[i + 1]) % 3 == 0)
                {
                    k++;
                    //6.2
                    Console.WriteLine($"\n{k} успешных сжатий - {i+1}-ый({a[i]}) и {i + 2}-ый({a[i + 1]})");
                    a[i] = a[i] * a[i + 1];
                    for (int p = 1; p < a.Length-i-1; p++)
                    {
                        a[i + p] = a[i + p + 1];
                    }
                }

            }
        }

        private static int CorrectCheck()
        {
            int x;
            bool ErrorCheck = false;
            do
            {
                if (ErrorCheck)
                    Console.WriteLine("Error");
                Console.Write("введите кол-во элиментов в массиве: ");
                ErrorCheck = true;
            } while (!int.TryParse(Console.ReadLine(), out x) || x <= 0);
            return x;
        }
    }

}
