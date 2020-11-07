using System;

namespace Task02
{
    class Program
    {
        public static int GetInt()
        {
            bool err = false;
            int x;
            do
            {
                if (err) Console.WriteLine("Error");
                Console.WriteLine("Введите размеронтсть массива");
            } while (!int.TryParse(Console.ReadLine(), out x) && x <= 0);
            return x;
        }
        public static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = GetInt();
            int[,] arr = new int[n, n];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j != n-i-1)
                    {
                        arr[i, j] = (j + 1 + i) % n;
                    }
                    else
                    {
                        arr[i, j] = n;
                    }
                }
            }
            Print(arr);
        }
    }
}