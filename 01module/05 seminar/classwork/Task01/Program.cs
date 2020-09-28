using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, b1;
            int.TryParse(Console.ReadLine(), out a1);
            int.TryParse(Console.ReadLine(), out b1);
            int[] a = Program.gen(a1);
            int[] b = Program.gen(b1);
            int[] c = new int[a1 + b1];

            c = genC(a1, b1, a, b);

            Program.write(a1, a);
            Program.write(b1, b);
            Program.write(a1+b1, c);

        }

        private static int[] genC(int a1, int b1, int[] a, int[] b)
        {
            int[] c = new int[a1+b1];
            int p = 0;
            for (int i = 0; i < b1+a1; i++)
            {
                if (i < a1)
                    c[i] = a[i];
                else if (b[i-a1] % 2 == 0)
                {
                    c[a1 + p] = b[i-a1];
                    p++;
                }
            }

            return c;
        }

        private static int[] gen(int n)
        {
            int[] x = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                x[i] = rnd.Next(10, 50);
            }
            return x;
        }
        private static void write(int n, int[] a)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + a[i]);
            }
            Console.WriteLine("");
        }
    }
}
