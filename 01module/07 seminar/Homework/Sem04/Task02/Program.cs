using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = CorrecDate();
            int count = ArrayCount(n);
            int[][] a = ArrayGen(n, count);

            Output(a);

        }
        // Генерируем массив. Заполняем его в соответсвии с условием задачи.
        public static int[][] ArrayGen(int n, int count)
        {
            int[][] a = new int[count][];
            for (int i = 0; i< a.Length; i++)
            {
                a[i] = new int[i+1];
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = n;
                    n--;
                }
            }
            return a;
        }
        // Метод определяющий кол-во массивов.
        public static int ArrayCount (int n)
        {
            int count;
            double k = (1 + Math.Sqrt(1 + 8 * n)) / 2 -1;
            if (k>(int)k)
            {
                count = (int)k + 1;
            }
            else
            {
                count = (int)k;
            }
            return count;
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
        // Выводим массив на экран.
        public static void Output(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
