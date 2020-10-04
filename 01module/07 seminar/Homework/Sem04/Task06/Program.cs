using System;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = ArrayGen();
            int det1 = Det3X3_1(a);
            int det2 = Det3X3_2(a);
            int[] b = new int[2] { det1, det2 };

            Console.WriteLine("Матрица детерминантов: ");
            Console.WriteLine($"{b[0]}\t{b[1]}");

        }
        // Считаем детерминанты.
        public static int Det3X3_1(int[,] a)
        {
            return a[0, 0] * a[1, 1] * a[2, 2] + a[1, 0] * a[2, 1] * a[0, 2] + a[0, 1] * a[1, 2] * a[2, 0] - a[0, 2] * a[1, 1] * a[2, 0] - a[0, 1] * a[1, 0] * a[2, 2] - a[1, 2] * a[2, 1] * a[0, 0];
        }
        public static int Det3X3_2(int[,] a)
        {
            return a[0, 3] * a[0, 4] * a[2, 5] + a[1, 3] * a[2, 4] * a[0, 5] + a[0, 4] * a[1, 5] * a[2, 3] - a[0, 5] * a[1, 4] * a[2, 3] - a[0, 4] * a[1, 3] * a[2, 5] - a[1, 5] * a[2, 4] * a[0, 3];
        }
        // Генерируем массив.
        public static int[,] ArrayGen()
        {
            int[,] a = new int[3, 6];
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    a[i, j] = rnd.Next(0, 21);
                }
            }
            return a;
        }
    }
}
