using System;

namespace Classwork02
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

            string[][] a = new string[x - 1][];
            for (int i = 0; i<a.Length; i++)
            {
                a[i] = new string[i + 1];
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = "*";
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
