using System;

namespace Claswork
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("введите число n");
            } while (!int.TryParse(Console.ReadLine(), out x));

            int[,] a = new int[x,x];

            for (int i = 0; i<a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    a[i, j] = i == j ? 0 : i > j ? -1 : 1;
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    a[i, j] = i == x-j-1 ? 0 : i > x-j-1 ? 1 : -1;
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }


        }
    }
}
