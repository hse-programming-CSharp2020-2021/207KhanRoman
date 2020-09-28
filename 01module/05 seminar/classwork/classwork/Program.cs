using System;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            // массив хранится в памяти единым боком, и, при обращении к индексу, к константе прибавляем нидекс(нельзя добавлять элименты).
            // лист: ссылка хранится в каждом эллементе(можно добавлять элименты)
            int n,b,c;
            int.TryParse(Console.ReadLine(), out n);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);
            int[,] a = gen(n, b, c);
            write(n, a);
        }

        private static void write(int n, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(" " +  a[i,j]);
                Console.WriteLine("");
            }
        }

        private static int[,] gen(int n, int b, int c)
        {
            int[,] a = new int[n,n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                // a[i] = (i + 1) * (i + 1);
                for (int j = 0; j < n; j++)
                    a[i,j] = rnd.Next(b,c);
            }
            return a;
        }
    }
}
