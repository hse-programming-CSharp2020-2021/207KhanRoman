using System;
using System.Runtime.CompilerServices;

namespace Classwork03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x;
            do
            {
                Console.WriteLine("введите число n");
            } while (!int.TryParse(Console.ReadLine(), out x));

            int[] a = new int[x];
            for (int i = 0; i<a.Length; i++)
            {
                a[i] = rnd.Next(-10, 11);
            }
            Array.ForEach(a, x => Console.Write($"{x} "));
            Console.WriteLine();

            Array.Sort(a, (x, y) =>
            {
                if (y < 0 && x>=0)
                    return -1;
                else if (y < 0 && x<0) return 1;
                else return 0;
            });
            Array.ForEach(a, x => Console.Write($"{x} "));
        }
    }
}
