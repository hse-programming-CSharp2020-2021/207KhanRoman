using System;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 0, 5, -10, 9, 23, 6, 7 };
            Array.Sort(a1,(x, y)=>
            {
                if (x > y) return -1;
                else if (x < y) return 1;
                else return 0; // для равенства.
            }
            );
            Array.Reverse(a1);
            Array.ForEach(a1, x=> Console.Write($"{x}" ));

            foreach (int a in a1)
            {
                Console.WriteLine($"{a}");
            }
        }
    }
}
