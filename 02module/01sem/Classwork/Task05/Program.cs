using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int.TryParse(Console.ReadLine(), out x);
            int[][] binom = new int[x][];
            for (int i = 0; i < binom.Length; i++)
            {
                binom[i] = new int[i + 1];
                binom[i][0] = binom[i][i] = 1;
                for (int j = 1; j < binom[i].Length - 1; j++)
                {
                    binom[i][j] = binom[i - 1][j - 1] + binom[i - 1][j];
                }
            }
            Array.ForEach(binom, x => {
                Array.ForEach(x, y => Console.Write(y + " "));
                Console.WriteLine();
                });
        }
    }
}
