using System;
using System.Diagnostics.CodeAnalysis;

namespace Task05
{
    class Program
    {
        public static double sum (ref double sum, int n)
        {
            for (int k = 0; k<n; k++)
            {
                sum += (k + 0.3) / (3*k * k + 5);
                Console.WriteLine($"n = {k},\t sum = {sum:f2}");
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            double sum = 0;
            Program.sum(ref sum, n);
        }
    }
}
