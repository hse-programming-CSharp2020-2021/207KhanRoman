using System;

namespace Classwork04
{
    class Program
    {
        // Рекурсивные метод:
        public static int Stirling (int n, int k)
        {
            if (n == k && n>=0) return 1;
            else if (k == 0 && n > 0) return 0;
            else if (n == 0 && k > 0) return 0;
            return Stirling(n - 1, k - 1) + k * Stirling(n - 1, k);

        }
        static void Main(string[] args)
        {
            int n, k;
            do
            {
                Console.WriteLine("введите число n");
            } while (!int.TryParse(Console.ReadLine(), out n));
            do
            {
                Console.WriteLine("введите число k");
            } while (!int.TryParse(Console.ReadLine(), out k));
            if (k > 0 && n > k)
            {
                Console.WriteLine(Stirling(n, k));
            }
            else
                Console.WriteLine("Error");
        }
    }
}
