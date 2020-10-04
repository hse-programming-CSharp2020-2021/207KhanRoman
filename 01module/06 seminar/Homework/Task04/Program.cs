using System;

namespace Task04
{
    class Program
    {
        // 4.3
        static void Main(string[] args)
        {
            long a0 = CorrectCheck();
            long[] a = ArrayGen(a0);

            // 4.2
            for (int i = 1; i < a.Length; i++)
            {
                Console.Write($"{a[i]}\t");
                if (i%5==0)
                {
                    Console.WriteLine();
                }
            }

        }
        // Генерируем Массив. 4.1
        private static long[] ArrayGen(long a0)
        {
            long m = a0;
            int k = 1;
            while (m != 1)
            {
                m = m % 2 == 0 ? m / 2 : (3 * m + 1);
                k++;
            }
            long[] a = new long[k];
            a[0] = a0;
            for (int i = 1; i < k; i++)
            {
                a[i] = a[i - 1] % 2 == 0 ? a[i - 1] / 2 : (3 * a[i - 1] + 1);
            }
            return a;
        }

        // Метод проверка корректности введенных данных.
        private static long CorrectCheck()
        {
            long x;
            bool ErrorCheck = false;
            do
            {
                if (ErrorCheck)
                    Console.WriteLine("Error");
                Console.Write("введите первый элимент массива: ");
                ErrorCheck = true;
            } while (!long.TryParse(Console.ReadLine(), out x) || x<0);
            return x;
        }
    }
}
